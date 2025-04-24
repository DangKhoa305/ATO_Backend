using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class OrderRequest
    {
        public double TotalAmount { get; set; }
        public Guid ShipAddressId { get; set; }
        public OrderType OrderType { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public virtual ICollection<OrderDetailRequest> OrderDetails { get; set; }
    }
    public class OrderAcceptRequest
    {
        public Guid OrderId { get; set; }
        public StatusOrder StatusOrder { get; set; }
    }
    public class OrderDetailRequest
    {
        public Guid FacilityId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
    public class OrderDetail_Cart
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

    }
    public class OrderDetail_Cart_Respone
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Product_Cart_Respone? Product { get; set; }

    }
    public class Product_Cart_Respone
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string>? Imgs { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }

        public UnitProduct? UnitProduct { get; set; }
        //category
        public ProductCategory ProductCategory { get; set; }
    }
}
