using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class VNPayPaymentResponse
    {
        public Guid ResponseId { get; set; }
        public Guid? OrderId { get; set; }
        public string TxnRef { get; set; }
        public decimal Amount { get; set; }
        public string BankCode { get; set; }
        public string BankTranNo { get; set; }
        public string CardType { get; set; }
        public string OrderInfo { get; set; }
        public DateTime PayDate { get; set; }
        public string ResponseCode { get; set; }
        public string TmnCode { get; set; }
        public string TransactionNo { get; set; }
        public string TransactionStatus { get; set; }
        public string SecureHash { get; set; }

        public TypePayment TypePayment { get; set; }
        public virtual Order? Order { get; set; }
    }
    public enum TypePayment
    {
        TourPayment =0,
        OrderPayment=1
    }
}
