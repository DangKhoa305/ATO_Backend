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
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public StatusOrder StatusOrder { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime? CancelDate { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<OrderDetailRespone> OrderDetails { get; set; }
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
}
