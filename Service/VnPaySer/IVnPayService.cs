using Data.Models;
using Microsoft.AspNetCore.Http;

namespace Service.VnPaySer
{
    public interface IVnPayService
    {
        Task<string> CreatePaymentUrlAsync(HttpContext context, dynamic codePayment, decimal fee, DateTime dateCreate, TypePayment TypePayment);
        Task<VNPayPaymentResponse> PaymentExecute(IQueryCollection collections);
        Task<(bool Success, VNPayPaymentResponse Response)> ProcessRefundAsync(VNPayPaymentResponse vNPayPaymentResponse, decimal amount, string orderInfo, string returnUrl);
        Task<Data.Models.VNPayPaymentResponse> PaymentExecuteOrder(IQueryCollection collections);
        Task<(bool Success, VNPayPaymentResponse Response)> ProcessRefundBookingAsync(VNPayPaymentResponse vNPayPaymentResponse, decimal amount, string orderInfo, string returnUrl);

    }
}
