using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public StatusOrder StatusOrder { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime? CancelDate { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Account? Account { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
    public enum OrderType
    {
        Online,
        Onsite
    }
    public enum PaymentStatus
    {
        Paid,
        UnPaid,
        Failed,
        Refunded
    }
    public enum PaymentType
    {
        CashOnDelivery,
        Transfer,
        Refunded
    }
    public enum StatusOrder
    {
        Processing,
        Shipped,
        Completed,
        Canceled,

    }
}
