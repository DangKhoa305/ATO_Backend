using System;

namespace Data.Models
{
    public class AdminBalance
    {
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? BookingId { get; set; }
        public DateTime TransactionDate { get; set; }

        // Navigation properties
        public virtual Order? Order { get; set; }
        public virtual BookingAgriculturalTour? Booking { get; set; }
    }

    public enum TransactionType
    {
        OrderPayment,
        BookingPayment,
        Withdrawal,
        Other
    }
}