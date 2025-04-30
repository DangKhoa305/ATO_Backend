using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.WithdrawalSer;

public class WithdrawalService(
    IRepository<WithdrawalRequest> requestRepo,
    IRepository<WithdrawalHistory> historyRepo,
    IRepository<AdminBalance> adminBalanceRepo,
    IRepository<BookingAgriculturalTour> bookingRepo,
    IRepository<Order> orderRepo,
    IRepository<Contract> contractRepo) : IWithdrawalService
{
    private readonly IRepository<WithdrawalRequest> _requestRepo = requestRepo;
    private readonly IRepository<WithdrawalHistory> _historyRepo = historyRepo;
    private readonly IRepository<AdminBalance> _adminBalanceRepo = adminBalanceRepo;
    private readonly IRepository<Contract> _contractRepo = contractRepo;
    private readonly IRepository<BookingAgriculturalTour> _bookingRepo = bookingRepo;
    private readonly IRepository<Order> _orderRepo = orderRepo;

    public async Task<List<WithdrawalRequest>> GetUserWithdrawalRequests(Guid userId)
    {
        return await _requestRepo.Query()
            .Where(x => x.UserId == userId)
            .OrderByDescending(x => x.RequestDate)
            .ToListAsync();
    }

    public async Task<List<WithdrawalRequest>> GetAllPendingRequests()
    {
        return await _requestRepo.Query()
            .Where(x => x.Status == WithdrawalRequestStatus.Pending)
            .OrderBy(x => x.RequestDate)
            .Include(x => x.User)
            .ToListAsync();
    }

    public async Task<bool> CreateWithdrawalRequest(WithdrawalRequest request)
    {
        request.RequestId = Guid.NewGuid();
        request.RequestDate = DateTime.UtcNow;
        request.Status = WithdrawalRequestStatus.Pending;

        await _requestRepo.AddAsync(request);
        return true;
    }

    public async Task<bool> ProcessWithdrawalRequest(Guid requestId, bool isApproved, string adminResponse, Guid adminId)
    {
        var request = await _requestRepo.GetByIdAsync(requestId);
        if (request == null) return false;

        request.Status = isApproved ? WithdrawalRequestStatus.Approved : WithdrawalRequestStatus.Rejected;
        request.AdminResponse = adminResponse;
        request.ProcessedDate = DateTime.UtcNow;

        if (isApproved)
        {
            // Create negative transaction in admin balance for withdrawal
            var transaction = new AdminBalance
            {
                TransactionId = Guid.NewGuid(),
                Amount = -request.Amount, // Negative amount for withdrawal
                Description = $"Withdrawal approved for request #{request.RequestId}",
                TransactionType = TransactionType.Withdrawal,
                TransactionDate = DateTime.UtcNow
            };

            await _adminBalanceRepo.AddAsync(transaction);
        }

        await _requestRepo.UpdateAsync(request);
        return true;
    }

    public async Task<bool> CompleteWithdrawal(Guid requestId, string note, string image)
    {
        var request = await _historyRepo.GetByIdAsync(requestId);
        if (request == null || request.WithdrawalStatus != WithdrawalStatus.New)
            return false;

        request.WithdrawalStatus = WithdrawalStatus.Completed;
        request.Note = note;
        request.TransactionImage = image;

        await _historyRepo.UpdateAsync(request);
        return true;
    }

    public async Task<bool> CancelWithdrawal(Guid requestId, string note)
    {
        var request = await _historyRepo.GetByIdAsync(requestId);
        if (request == null || request.WithdrawalStatus != WithdrawalStatus.Completed)
            return false;

        request.WithdrawalStatus = WithdrawalStatus.Cancelled;
        request.Note = note;
        await _historyRepo.UpdateAsync(request);
        return true;
    }

    public async Task<List<WithdrawalHistory>> GetUserWithdrawalHistory(Guid userId)
    {
        return await _historyRepo.Query()
            .Include(x => x.TourCompany)
            .Include(x => x.TouristFacility)
            .Where(x => x.TouristFacilityId == userId || x.TouristFacilityId == userId)
            .OrderByDescending(x => x.ProcessedDate)
            .ToListAsync();
    }
    public async Task<List<WithdrawalHistory>> GetWithdrawalHistory_Admin()
    {
        return await _historyRepo.Query()
            .Include(x => x.TourCompany)
            .Include(x => x.TouristFacility)
            .OrderByDescending(x => x.ProcessedDate)
            .ToListAsync();
    }

    public async Task<bool> GenerateMonthlyWithdrawals()
    {
        var now = DateTime.UtcNow;
        var firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
        var lastMonthStart = firstDayOfMonth.AddMonths(-1);
        var lastMonthEnd = firstDayOfMonth.AddDays(-1);

        // Check if withdrawals already processed this month
        var existingWithdrawals = await _historyRepo.Query()
            .Where(x => x.ProcessedDate >= firstDayOfMonth)
            .AnyAsync();

        if (existingWithdrawals)
            return false;

        // Get active contracts and their bill rates
        var activeContracts = await _contractRepo.Query()
            .Where(x => x.StartDate <= now && x.EndDate >= now)
            .Where(x => x.SigningStatus == SigningStatus.Signed
                || x.SigningStatus == SigningStatus.ApprovedExtend)
            .Include(x => x.TourCompany)
            .Include(x => x.TouristFacility)
            .ToListAsync();

        foreach (var contract in activeContracts)
        {
            // Calculate total earnings for the company from last month's bookings
            var companyEarnings = await _bookingRepo.Query()
                .Include(x => x.AgriculturalTourPackage)
                .Where(b => b.AgriculturalTourPackage!.TourCompanyId == contract.TourCompanyId &&
                           b.BookingDate >= lastMonthStart &&
                           b.BookingDate <= lastMonthEnd)
                .SumAsync(b => b.TotalAmmount);

            // Calculate total earnings for the facility from last month's orders
            var facilityEarnings = (decimal)await _orderRepo.Query()
                .Include(x => x.OrderDetails).ThenInclude(x => x.Product)
                .Where(o => o.OrderDetails.Any(x => x.Product!.TouristFacilityId == contract.TouristFacilityId) &&
                           o.OrderDate >= lastMonthStart &&
                           o.OrderDate <= lastMonthEnd)
                .SumAsync(o => o.TotalAmount);

            // Calculate withdrawal amount based on discount rate
            var withdrawalAmount = (companyEarnings + facilityEarnings) * (contract.DiscountRate ?? 0);

            var isForCompany = contract.TourCompanyId is not null;
            var amount = isForCompany ? companyEarnings * (contract.DiscountRate ?? 0) : facilityEarnings * (contract.DiscountRate ?? 0);

            var withdrawal = new WithdrawalHistory
            {
                WithdrawalId = Guid.NewGuid(),
                TouristFacilityId = contract.TouristFacility?.TouristFacilityId,
                TourCompanyId = contract.TourCompany?.TourCompanyId,
                Amount = amount,
                TransactionReference = $"auto-{DateTime.UtcNow:yyyyMMddHHmmss}",
                ProcessedDate = now,
                Note = $"Yêu cầu giải ngân tháng {lastMonthStart.Month}",
                WithdrawalStatus = WithdrawalStatus.New
            };

            if (amount > 0)
            {
                await _historyRepo.AddAsync(withdrawal);
            }
        }

        return true;
    }

    public async Task<WithdrawalHistory> GetWithdrawalHistory(Guid id)
        => await _historyRepo.Query().Include(x => x.TourCompany)
        .Include(x => x.TouristFacility)
        .FirstOrDefaultAsync(x => x.WithdrawalId == id);
}