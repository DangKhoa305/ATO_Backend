using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.WithdrawalSer;

public class WithdrawalService(
    IRepository<WithdrawalRequest> requestRepo,
    IRepository<WithdrawalHistory> historyRepo,
    IRepository<AdminBalance> adminBalanceRepo) : IWithdrawalService
{
    private readonly IRepository<WithdrawalRequest> _requestRepo = requestRepo;
    private readonly IRepository<WithdrawalHistory> _historyRepo = historyRepo;
    private readonly IRepository<AdminBalance> _adminBalanceRepo = adminBalanceRepo;

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

    public async Task<bool> CompleteWithdrawal(Guid requestId, string transactionReference)
    {
        var request = await _requestRepo.GetByIdAsync(requestId);
        if (request == null || request.Status != WithdrawalRequestStatus.Approved)
            return false;

        request.Status = WithdrawalRequestStatus.Completed;
        await _requestRepo.UpdateAsync(request);

        var history = new WithdrawalHistory
        {
            WithdrawalId = Guid.NewGuid(),
            RequestId = requestId,
            UserId = request.UserId,
            Amount = request.Amount,
            TransactionReference = transactionReference,
            ProcessedDate = DateTime.UtcNow
        };

        await _historyRepo.AddAsync(history);
        return true;
    }

    public async Task<List<WithdrawalHistory>> GetUserWithdrawalHistory(Guid userId)
    {
        return await _historyRepo.Query()
            .Where(x => x.UserId == userId)
            .OrderByDescending(x => x.ProcessedDate)
            .Include(x => x.Request)
            .ToListAsync();
    }
    public async Task<List<WithdrawalHistory>> GetWithdrawalHistory_Admin()
    {
        return await _historyRepo.Query()
            .OrderByDescending(x => x.ProcessedDate)
            .Include(x => x.Request)
            .ToListAsync();
    }
}