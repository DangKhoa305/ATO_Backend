using Data.DTO.Request;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Service.Repository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.OrderSer
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Data.Models.Order> _orderRepository;
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IConnectionMultiplexer _redis;
        private readonly StackExchange.Redis.IDatabase _db;
        public OrderService(
            IRepository<Data.Models.Order> orderRepository,
            IRepository<OrderDetail> orderDetailRepository,
            IConnectionMultiplexer redis,
            IRepository<Product> productRepository
            )
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _redis = redis;
            _db = _redis.GetDatabase();
            _productRepository = productRepository;
        }

        public async Task<bool> AddOrder(Data.Models.Order order)
        {
            try
            {
                order.OrderId = Guid.NewGuid();
                order.OrderDate = DateTime.UtcNow;
                order.StatusOrder = StatusOrder.Processing;
                order.CreateDate = DateTime.UtcNow;
                order.TotalAmount = (double)order.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
                foreach (var item in order.OrderDetails)
                {
                    item.OrderId = order.OrderId;
                }
                await _orderRepository.AddRangeAsync(order);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task AddToCart(Guid userId, OrderDetail_Cart orderDetail)
        {
            string cartKey = $"cart:{userId}";

            // Lấy danh sách sản phẩm hiện có trong giỏ hàng
            var cartData = await _db.StringGetAsync(cartKey);
            List<OrderDetail_Cart> cart = cartData.HasValue
                ? JsonSerializer.Deserialize<List<OrderDetail_Cart>>(cartData)
                : new List<OrderDetail_Cart>();

            // Thêm sản phẩm vào giỏ hàng
            cart.Add(orderDetail);

            // Lưu lại vào Redis
            await _db.StringSetAsync(cartKey, JsonSerializer.Serialize(cart));
        }

        public async Task<List<OrderDetail_Cart_Respone>> GetCart(Guid userId)
        {
            string cartKey = $"cart:{userId}";
            var cartData = await _db.StringGetAsync(cartKey);
            List<OrderDetail_Cart_Respone> cart = cartData.HasValue
                ? JsonSerializer.Deserialize<List<OrderDetail_Cart_Respone>>(cartData)
                : new List<OrderDetail_Cart_Respone>();
            foreach (var item in cart)
            {
                Product product = await _productRepository.Query()
                    .Include(x => x.OCOPSells)
                    .FirstOrDefaultAsync(x => x.ProductId == item.ProductId);
                var latestSale = product.OCOPSells
                    .Where(s => s.ExpiryDate == null || s.ExpiryDate > DateTime.UtcNow)
                    .OrderBy(s => s.ExpiryDate)
                    .FirstOrDefault();


                item.Product = new Product_Cart_Respone
                {
                    ProductId = product.ProductId,
                    Description = product.Description,
                    Imgs = product.Imgs,
                    ProductCategory = product.ProductCategory,
                    ProductName = product.ProductName,
                    UnitProduct = product.UnitProduct,
                    Price = latestSale.SalePrice
                };
            }
            return cart;
        }

        public async Task ClearCart(Guid userId)
        {
            string cartKey = $"cart:{userId}";
            await _db.KeyDeleteAsync(cartKey);
        }

        public async Task<Data.Models.Order> GetOrderDetails(Guid OrderId)
        {
            try
            {
                return await _orderRepository.Query()
                    .Include(x => x.OrderDetails)
                        .ThenInclude(y => y.Product)
                    .SingleOrDefaultAsync(x => x.OrderId == OrderId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Data.Models.Order>> ListOrders(Guid UserId)
        {
            try
            {
                return await _orderRepository.Query()
                    .Where(x => x.CustomerId == UserId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public Task<bool> UpdateOrder(Guid OrderId, Data.Models.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
