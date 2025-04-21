using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.AdminBalanceSer;

public class AdminBalanceService(IRepository<AdminBalance> adminBalanceRepo) : IAdminBalanceService
{
    private readonly IRepository<AdminBalance> _adminBalanceRepo = adminBalanceRepo;

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