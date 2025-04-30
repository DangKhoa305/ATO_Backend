using Data.DTO.Request;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.AdminBalanceSer;
using StackExchange.Redis;
using System.Text.Json;
using Service.Repository;

namespace Service.OrderSer;

public class OrderService : IOrderService
{
    private readonly IAdminBalanceService _adminBalanceService;
    private readonly IRepository<Data.Models.Order> _orderRepository;
    private readonly IRepository<Data.Models.VNPayPaymentResponse> _VNPayPaymentResponseRepository;
    private readonly IRepository<OrderDetail> _orderDetailRepository;
    private readonly IRepository<Product> _productRepository;
    private readonly IRepository<TouristFacility> _touristFacilityRepository;

    private readonly IConnectionMultiplexer _redis;
    private readonly StackExchange.Redis.IDatabase _db;

    public OrderService(
        IRepository<Data.Models.Order> orderRepository,
        IRepository<OrderDetail> orderDetailRepository,
        IRepository<TouristFacility> touristFacilityRepository,
        IConnectionMultiplexer redis,
        IRepository<Product> productRepository,
        IRepository<Data.Models.VNPayPaymentResponse> vNPayPaymentResponseRepository,
     IAdminBalanceService adminBalanceService)
    {
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
        _redis = redis;
        _db = _redis.GetDatabase();
        _productRepository = productRepository;
        _VNPayPaymentResponseRepository = vNPayPaymentResponseRepository;
        _touristFacilityRepository = touristFacilityRepository;
        _adminBalanceService = adminBalanceService;
    }

    public async Task<Data.Models.Order> AddOrder(Data.Models.Order order)
    {
        try
        {
            order.OrderId = Guid.NewGuid();
            order.OrderDate = DateTime.UtcNow;
            order.StatusOrder = StatusOrder.Processing;
            if (order.PaymentType == PaymentType.Transfer)
            {
                order.PaymentStatus = PaymentStatus.UnPaid;
            }
            order.CreateDate = DateTime.UtcNow;
            order.TotalAmount = (double)order.TotalAmount;
            foreach (var item in order.OrderDetails)
            {
                item.OrderId = order.OrderId;
            }
            await _orderRepository.AddRangeAsync(order);
            return order;
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
                        .ThenInclude(y => y.TouristFacility)
                .Include(x => x.OrderDetails)
                .Include(y => y.VNPayPaymentResponses)
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
                .Where(x => x.CustomerId == UserId && x.BookingId == null)
                .OrderByDescending(x => x.CreateDate)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
    public async Task<List<Data.Models.Order>> ListOrders_AFTO(Guid UserId)
    {
        try
        {
            TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                .SingleOrDefaultAsync(x => x.UserId == UserId);
            return await _orderRepository.Query()
                .Include(x => x.OrderDetails)
                .ThenInclude(y => y.Product)
                .Where(x => x.OrderDetails.Any(x => x.Product.TouristFacilityId == TouristFacility.TouristFacilityId))
                .OrderByDescending(x => x.OrderDate)
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
    public async Task<bool> UpdateShipCode(Guid OrderId, string ShipCode)
    {
        try
        {
            var order = await _orderRepository.Query()
                   .SingleOrDefaultAsync(x => x.OrderId == OrderId);
            //order.ShipCode = ShipCode;
            order.StatusOrder = StatusOrder.AcceptOrder;
            await _orderRepository.UpdateAsync(order);
            return true;

        }
        catch (Exception)
        {
            return false;
        }
    }


    public async Task<bool> UpdateStatus(Guid OrderId, StatusOrder statusOrder)
    {
        try
        {
            var order = await _orderRepository.Query()
                   .SingleOrDefaultAsync(x => x.OrderId == OrderId);
            if (order is null) return false;

            order.StatusOrder = statusOrder;
            await _orderRepository.UpdateAsync(order);
            return true;

        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task AddOrderPayment(Data.Models.VNPayPaymentResponse checkResponse)
    {
        try
        {
            var order = await _orderRepository.Query()
                .Include(x => x.OrderDetails)
                .ThenInclude(od => od.Product)
                .ThenInclude(p => p.OCOPSells)
                .SingleOrDefaultAsync(x => x.OrderId == checkResponse.OrderId);
            if (order == null) return;
            checkResponse.Amount = (decimal)order.TotalAmount;
            await _VNPayPaymentResponseRepository.AddAsync(checkResponse);

            if (checkResponse.TransactionStatus == "00" && checkResponse.TypePayment != TypePayment.Refunded)
            {
                order.PaymentStatus = PaymentStatus.Paid;
                await _adminBalanceService.AddOrderTransaction(order);
            }
            await _orderRepository.UpdateAsync(order);

            // Update OCOP quantities for each order detail
            foreach (var orderDetail in order.OrderDetails)
            {
                var latestValidSell = orderDetail.Product?.OCOPSells?
                    .Where(s => s.ExpiryDate == null || s.ExpiryDate > DateTime.UtcNow)
                    .OrderBy(s => s.ExpiryDate)
                    .FirstOrDefault();

                if (latestValidSell != null && checkResponse.TypePayment != TypePayment.Refunded)
                {
                    latestValidSell.SellVolume -= orderDetail.Quantity;
                }
                else if (latestValidSell != null && checkResponse.TypePayment == TypePayment.Refunded)
                {
                    latestValidSell.SellVolume += orderDetail.Quantity;
                }
            }


        }
        catch (Exception ex)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }

    }
    public async Task<List<VNPayPaymentResponse>> ListHistoryPaymentsOrder(Guid UserId)
    {
        try
        {
            // Lấy TouristFacility theo UserId
            var touristFacility = await _touristFacilityRepository.Query()
                .SingleOrDefaultAsync(x => x.UserId == UserId);

            if (touristFacility == null)
                return new List<VNPayPaymentResponse>();

            var touristFacilityId = touristFacility.TouristFacilityId;

            // Lấy danh sách các lịch sử thanh toán
            return await _VNPayPaymentResponseRepository.Query()
                .Include(x => x.Order)
                    .ThenInclude(o => o.Account)
                .Include(x => x.Order)
                    .ThenInclude(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                .Where(x => x.BookingId == null &&
                            x.Order.OrderDetails.Any(od => od.Product.TouristFacilityId == touristFacilityId))
                .OrderByDescending(x => x.PayDate)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi, vui lòng thử lại sau!");
        }
    }


    //public async Task UpdateOrderShipping(Guid orderId, ShippingOrderResponse shippingResponse)
    //{
    //    var order =  await _orderRepository.Query()
    //            .SingleOrDefaultAsync(x => x.OrderId == orderId);
    //    if (order == null)
    //        throw new Exception("Order not found");

    //    order.ShippingCode = shippingResponse.OrderCode;
    //    _orderRepository.UpdateAsync(order);
    //}

    public async Task UpdateOrderStatus(Guid orderId, PaymentType refunded, int paymentStatus, StatusOrder canceled)
    {
        var order = await _orderRepository.Query()
                .SingleOrDefaultAsync(x => x.OrderId == orderId);
        if (order == null)
            throw new Exception("Order not found");
        order.PaymentType = refunded;
        order.StatusOrder = canceled;
        order.PaymentStatus = (PaymentStatus)paymentStatus;
        _orderRepository.UpdateAsync(order);
    }

    public async Task AcceptOrder(OrderAcceptRequest orderAcceptRequest)
    {
        var order = await _orderRepository.Query()
               .SingleOrDefaultAsync(x => x.OrderId == orderAcceptRequest.OrderId);
        order.StatusOrder = orderAcceptRequest.StatusOrder;
        await _orderRepository.UpdateAsync(order);
    }

    public Task<List<VNPayPaymentResponse>> ListHistoryPayments()
    {
        throw new NotImplementedException();
    }
}
