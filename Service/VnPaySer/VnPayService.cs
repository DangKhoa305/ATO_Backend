using Data.Migrations;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Service.SystemConfigSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.VnPaySer
{
    public class VnPayService : IVnPayService
    {
        private readonly ISystemConfigurationsService _configRepository;

        public VnPayService(ISystemConfigurationsService configRepository)
        {
            _configRepository = configRepository;
        }

        public async Task<string> CreatePaymentUrlAsync(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate, TypePayment TypePayment)
        {
            var tick = DateTime.Now.Ticks.ToString();

            var vnpay = new VnPayLibrary();
            vnpay.AddRequestData("vnp_Version", await _configRepository.GetConfigValueAsync("Version"));
            vnpay.AddRequestData("vnp_Command", await _configRepository.GetConfigValueAsync("Command"));
            vnpay.AddRequestData("vnp_TmnCode", await _configRepository.GetConfigValueAsync("TmnCode"));
            vnpay.AddRequestData("vnp_Amount", ((int)(fee * 100)).ToString());

            vnpay.AddRequestData("vnp_CreateDate", dateCreate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", await _configRepository.GetConfigValueAsync("CurrCode"));
            vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress(context));
            vnpay.AddRequestData("vnp_Locale", await _configRepository.GetConfigValueAsync("Locale"));

            vnpay.AddRequestData("vnp_OrderInfo", "" + codePayment);
            vnpay.AddRequestData("vnp_OrderType", TypePayment.ToString());
            vnpay.AddRequestData("vnp_ReturnUrl", await _configRepository.GetConfigValueAsync("PaymentBackReturnUrl"));

            vnpay.AddRequestData("vnp_TxnRef", tick);

            var baseUrl = await _configRepository.GetConfigValueAsync("BaseUrl");
            var hashSecret = await _configRepository.GetConfigValueAsync("HashSecret");

            var paymentUrl = vnpay.CreateRequestUrl(baseUrl, hashSecret);
            return await _configRepository.GetConfigValueAsync("Url") + paymentUrl;
        }
        //public async Task<Data.Models.VNPayPaymentResponse> PaymentExecute(IQueryCollection collections)
        //{
        //    var vnpay = new VnPayLibrary();
        //    foreach (var (key, value) in collections)
        //    {
        //        if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
        //        {
        //            vnpay.AddResponseData(key, value.ToString());
        //        }
        //    }

        //    var vnp_TxnRef = vnpay.GetResponseData("vnp_TxnRef");
        //    var vnp_Amount = decimal.Parse(vnpay.GetResponseData("vnp_Amount")) / 100;
        //    var vnp_BankCode = vnpay.GetResponseData("vnp_BankCode");
        //    var vnp_BankTranNo = vnpay.GetResponseData("vnp_BankTranNo");
        //    var vnp_CardType = vnpay.GetResponseData("vnp_CardType");
        //    var vnp_OrderInfo = vnpay.GetResponseData("vnp_OrderInfo");
        //    var vnp_OrderType = vnpay.GetResponseData("vnp_OrderType");
        //    var vnp_PayDate = DateTime.ParseExact(vnpay.GetResponseData("vnp_PayDate"), "yyyyMMddHHmmss", null);
        //    var vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
        //    var vnp_TmnCode = vnpay.GetResponseData("vnp_TmnCode");
        //    var vnp_TransactionNo = vnpay.GetResponseData("vnp_TransactionNo");
        //    var vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
        //    var vnp_SecureHash = collections["vnp_SecureHash"];
        //    PaymentType typePayment = (PaymentType)(vnp_OrderType == "0" ? TypePayment.TourPayment : TypePayment.OrderPayment);

        //    return new Data.Models.VNPayPaymentResponse
        //    {
        //        ResponseId = Guid.NewGuid(),
        //        OrderId = Guid.Parse(vnp_OrderType),
        //        TxnRef = vnp_TxnRef,
        //        Amount = vnp_Amount,
        //        BankCode = vnp_BankCode,
        //        BankTranNo = vnp_BankTranNo,
        //        CardType = vnp_CardType,
        //        OrderInfo = vnp_OrderInfo,
        //        PayDate = vnp_PayDate,
        //        ResponseCode = vnp_ResponseCode,
        //        TmnCode = vnp_TmnCode,
        //        TransactionNo = vnp_TransactionNo,
        //        TransactionStatus = vnp_TransactionStatus,
        //        SecureHash = vnp_SecureHash,
        //        TypePayment = (TypePayment)typePayment
        //    };
        //}

        public async Task<Data.Models.VNPayPaymentResponse> PaymentExecute(IQueryCollection collections)
        {
            var vnpay = new VnPayLibrary();
            foreach (var (key, value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(key, value.ToString());
                }
            }

            var vnp_TxnRef = vnpay.GetResponseData("vnp_TxnRef");
            var vnp_Amount = decimal.Parse(vnpay.GetResponseData("vnp_Amount")) / 100;
            var vnp_BankCode = vnpay.GetResponseData("vnp_BankCode");
            var vnp_BankTranNo = vnpay.GetResponseData("vnp_BankTranNo");
            var vnp_CardType = vnpay.GetResponseData("vnp_CardType");
            var vnp_OrderInfo = vnpay.GetResponseData("vnp_OrderInfo");
            var vnp_OrderType = vnpay.GetResponseData("vnp_OrderType");
            var vnp_PayDate = DateTime.ParseExact(vnpay.GetResponseData("vnp_PayDate"), "yyyyMMddHHmmss", null);
            var vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
            var vnp_TmnCode = vnpay.GetResponseData("vnp_TmnCode");
            var vnp_TransactionNo = vnpay.GetResponseData("vnp_TransactionNo");
            var vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
            var vnp_SecureHash = collections["vnp_SecureHash"];
            PaymentType typePayment = (PaymentType)(vnp_OrderType == "0" ? TypePayment.TourPayment : TypePayment.OrderPayment);

            return new Data.Models.VNPayPaymentResponse
            {
                ResponseId = Guid.NewGuid(),
                OrderId = Guid.Parse(vnp_OrderInfo),
                TxnRef = vnp_TxnRef,
                Amount = vnp_Amount,
                BankCode = vnp_BankCode,
                BankTranNo = vnp_BankTranNo,
                CardType = vnp_CardType,
                OrderInfo = vnp_OrderInfo,
                PayDate = vnp_PayDate,
                ResponseCode = vnp_ResponseCode,
                TmnCode = vnp_TmnCode,
                TransactionNo = vnp_TransactionNo,
                TransactionStatus = vnp_TransactionStatus,
                SecureHash = vnp_SecureHash,
                TypePayment = (TypePayment)typePayment
            };
        }


    }
}
