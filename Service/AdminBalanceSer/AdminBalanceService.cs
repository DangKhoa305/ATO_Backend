using Data.DTO.Response;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.AdminBalanceSer;

public class AdminBalanceService(
    IRepository<AdminBalance> adminBalanceRepo,
    IRepository<Order> orderRepo,
    IRepository<BookingAgriculturalTour> bookingRepo) : IAdminBalanceService
{
    private readonly IRepository<AdminBalance> _adminBalanceRepo = adminBalanceRepo;
    private readonly IRepository<Order> _orderRepo = orderRepo;
    private readonly IRepository<BookingAgriculturalTour> _bookingRepo = bookingRepo;

    public async Task<List<AdminBalanceHistoryResponse>> GetBalanceHistory()
    {
        var transactions = await _adminBalanceRepo.Query()
            .Include(x => x.Order)
            .Include(x => x.Booking)
            .OrderByDescending(x => x.TransactionDate)
            .ToListAsync();

        decimal runningBalance = 0;
        var history = new List<AdminBalanceHistoryResponse>();

        foreach (var transaction in transactions.OrderBy(x => x.TransactionDate))
        {
            runningBalance += transaction.Amount;

            history.Add(new AdminBalanceHistoryResponse
            {
                TransactionId = transaction.TransactionId,
                Amount = transaction.Amount,
                Description = transaction.Description,
                TransactionType = transaction.TransactionType,
                TransactionDate = transaction.TransactionDate,
                OrderReference = transaction.Order?.OrderId.ToString(),
                BookingReference = transaction.Booking?.BookingId.ToString(),
                RunningBalance = runningBalance
            });
        }

        return history.OrderByDescending(x => x.TransactionDate).ToList();
    }

    public async Task<decimal> GetCurrentBalance()
    {
        var transactions = await _adminBalanceRepo.Query().ToListAsync();
        return transactions.Sum(x => x.Amount);
    }

    public async Task<bool> AddOrderTransaction(Order order)
    {
        var transaction = new AdminBalance
        {
            TransactionId = Guid.NewGuid(),
            Amount = (decimal)order.TotalAmount,
            Description = $"Payment received for Order #{order.OrderId}",
            TransactionType = TransactionType.OrderPayment,
            OrderId = order.OrderId,
            TransactionDate = DateTime.UtcNow
        };

        await _adminBalanceRepo.AddAsync(transaction);
        return true;
    }

    public async Task<bool> AddBookingTransaction(BookingAgriculturalTour booking)
    {
        var transaction = new AdminBalance
        {
            TransactionId = Guid.NewGuid(),
            Amount = booking.TotalAmmount,
            Description = $"Payment received for Booking #{booking.BookingId}",
            TransactionType = TransactionType.BookingPayment,
            BookingId = booking.BookingId,
            TransactionDate = DateTime.UtcNow
        };

        await _adminBalanceRepo.AddAsync(transaction);
        return true;
    }

    public async Task<decimal> GetTotalBalance()
    {
        var transactions = await _adminBalanceRepo.Query().ToListAsync();
        return transactions.Sum(t => t.Amount);
    }
}