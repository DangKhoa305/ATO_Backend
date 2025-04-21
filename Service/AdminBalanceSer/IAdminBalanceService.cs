using Data.DTO.Response;
using Data.Models;

namespace Service.AdminBalanceSer
{
    public interface IAdminBalanceService
    {
        Task<bool> AddOrderTransaction(Order order);
        Task<bool> AddBookingTransaction(BookingAgriculturalTour booking);
        Task<decimal> GetTotalBalance();
        Task<List<AdminBalanceHistoryResponse>> GetBalanceHistory();
        Task<decimal> GetCurrentBalance();
    }
}