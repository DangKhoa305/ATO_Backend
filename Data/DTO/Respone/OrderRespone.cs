using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class OrderRespone
    {
        public Guid? BookingId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public StatusOrder StatusOrder { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Guid ShipAddressId { get; set; }
        public DateTime? CancelDate { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double TotalAmountProducts { get; set; }
        public double TotalShip { get; set; }
        public virtual UserRespone? Customer { get; set; }
        public virtual ICollection<OrderDetailRespone> OrderDetails { get; set; }
        public virtual ICollection<VNPayPaymentResponseDTO> VNPayPaymentResponses { get; set; }
    }
    public class OrderDetailRespone
    {
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual ProductDTO_Order? Product { get; set; }
    }
    public class ProductDTO_Order
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string>? Imgs { get; set; }
        public string? Description { get; set; }
        public UnitProduct? UnitProduct { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
    public class VNPayPaymentResponseDTO
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
    }
    public class VNPayPaymentResponse_History
    {
        public Guid ResponseId { get; set; }
        public Guid? BookingId { get; set; }
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
        public virtual BookingAgriculturalTourRespone? BookingAgriculturalTour { get; set; }
    }
    public class VNPayPaymentResponse_History_Order
    {
        public Guid ResponseId { get; set; }
        public Guid? BookingId { get; set; }
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
        public virtual OrderRespone? Order { get; set; }
        public TypePayment TypePayment { get; set; }
    }
}
