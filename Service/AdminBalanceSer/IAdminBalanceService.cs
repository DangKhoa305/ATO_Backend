using Data.Models;
using System;
using System.Threading.Tasks;

namespace Service.AdminBalanceSer
{
    public interface IAdminBalanceService
    {
        Task<bool> AddOrderTransaction(Order order);
        Task<bool> AddBookingTransaction(BookingAgriculturalTour booking);
        Task<decimal> GetTotalBalance();
    }
}