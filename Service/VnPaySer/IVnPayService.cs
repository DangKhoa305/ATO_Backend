using Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.VnPaySer
{
    public interface IVnPayService
    {
        Task<string> CreatePaymentUrlAsync(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate, TypePayment TypePayment);
        Task<VNPayPaymentResponse> PaymentExecute(IQueryCollection collections);
    }
}
