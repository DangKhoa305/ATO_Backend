using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
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
        //Task UpdateOrderShipping(Guid orderId, ShippingOrderResponse shippingResponse);
        Task<List<Data.Models.Order>> ListOrders_AFTO(Guid UserId);
        Task UpdateOrderStatus(Guid orderId, PaymentType refunded, int paymentStatus, StatusOrder canceled);
        Task<bool> UpdateShipCode(Guid OrderId, string ShipCode);
        Task AcceptOrder(OrderAcceptRequest orderAcceptRequest);
        Task<List<VNPayPaymentResponse>> ListHistoryPaymentsOrder(Guid UserId);
        Task<List<VNPayPaymentResponse>> ListHistoryPayments();
    }
}
