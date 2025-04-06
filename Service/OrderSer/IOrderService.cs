using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.OrderSer
{
    public interface IOrderService
    {
        Task<List<Order>> ListOrders(Guid UserId);
        Task<Order> GetOrderDetails(Guid OrderId);
        Task<Data.Models.Order> AddOrder(Order order);
        Task<bool> UpdateOrder(Guid OrderId, Order order);

        // cart
        Task AddToCart(Guid userId, OrderDetail_Cart orderDetail);
        Task ClearCart(Guid userId);
        Task<List<OrderDetail_Cart_Respone>> GetCart(Guid userId);
        Task AddOrderPayment(VNPayPaymentResponse checkResponse);
        Task UpdateOrderShipping(Guid orderId, ShippingOrderResponse shippingResponse);
    }
}
