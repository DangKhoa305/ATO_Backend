using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.AccountSer;
using Service.DriverSer;
using Service.OrderSer;
using Service.ShipAddressSer;
using Service.ShippingSer;
using Service.TouristFacilitySer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Net.Http;
using System.Text;
using System.Transactions;
using static Service.ShippingSer.ShippingService;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IConnectionMultiplexer _redis;
        private readonly IMapper _mapper;
        private readonly IVnPayService _vnPayService;
        private readonly IConfiguration _configuration;
        private readonly IShippingService _shippingService;
        private readonly IShipAddressService _shipAddressService;
        private readonly ITouristFacilityService _touristFacilityService;
        public OrderController(
            IMapper mapper,
            IOrderService orderService,
            IConnectionMultiplexer redis,
            IVnPayService vnPayService,
            IConfiguration configuration,
            IShippingService shippingService,
            IShipAddressService shipAddressService,
             ITouristFacilityService touristFacilityService
           )
        {
            _mapper = mapper;
            _orderService = orderService;
            _redis = redis;
            _vnPayService = vnPayService;
            _configuration = configuration;
            _shippingService = shippingService;
            _shipAddressService = shipAddressService;
            _touristFacilityService = touristFacilityService;
        }
        [HttpGet("get-list-orders")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(List<OrderRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDrivers()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _orderService.ListOrders(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<OrderRespone>>(response);


                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("get-order/{OrderId}")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(OrderRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOrder(Guid OrderId)
        {
            try
            {
                var response = await _orderService.GetOrderDetails(OrderId);
                var responseResult = _mapper.Map<OrderRespone>(response);
                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpPost("add-order")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddOrder([FromBody] OrderRequest orderRequest)
        {
            try
            {

                var groupProducts = orderRequest.OrderDetails.GroupBy(x => x.FacilityId).ToList();
                var groupResponses = new Dictionary<Guid, decimal>();
                foreach (var products in groupProducts)
                {
                    var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

                    orderRequest.OrderDetails = products.ToList();
                    orderRequest.TotalAmount = (double)products.Sum(x => x.Quantity * x.UnitPrice) + 21001;
                    var responseResult = _mapper.Map<Data.Models.Order>(orderRequest);

                    responseResult.CustomerId = Guid.Parse(userId!);
                    var response = await _orderService.AddOrder(responseResult);

                    groupResponses.Add(response.OrderId, (decimal)response.TotalAmount);
                }

                if (orderRequest.PaymentType == PaymentType.Transfer)
                {
                    decimal fee = groupResponses.Sum(x => x.Value);
                    DateTime timecreate = DateTime.UtcNow;

                    var listOrderId = string.Join(",", groupResponses.Keys);
                    var paymentUrl = await _vnPayService.CreatePaymentUrlAsync(HttpContext, listOrderId, fee, timecreate, TypePayment.OrderPayment);
                    return Ok(paymentUrl);
                }
                else
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo đơn thành công!",
                    });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("return_order")]
        public async Task<IActionResult> VNPayReturnAsync()
        {
            try
            {
                var queryParams = Request.Query;
                var checkResponse = await _vnPayService.PaymentExecuteOrder(queryParams);

                var listOrderIdRaw = checkResponse.OrderInfo;
                var listOrderId = listOrderIdRaw.Split(",")
                    .Select(x => Guid.Parse(x)).ToList();

                foreach (var id in listOrderId)
                {
                    checkResponse.OrderId = id;
                    checkResponse.ResponseId = Guid.NewGuid();
                    await _orderService.AddOrderPayment(checkResponse);
                }

                var queryString = new StringBuilder();
                foreach (var param in queryParams)
                {
                    var encodedValue = Uri.EscapeDataString(param.Value!);
                    queryString.Append($"{param.Key}={encodedValue}&");
                }
                var returnUrl = _configuration.GetValue<string>("VNPaySettings:ReturnUrl");
                return Redirect($"{returnUrl}?{queryString}");
            }
            catch (Exception)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }

        [HttpPost("add-to-cart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddToCart([FromBody] OrderDetail_Cart orderDetail)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                await _orderService.AddToCart(Guid.Parse(userId), orderDetail);
                return Ok(new { Message = "Thêm vào giỏ hàng thành công!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpGet("get-cart")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(List<OrderDetail_Cart_Respone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCart()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                var cart = await _orderService.GetCart(Guid.Parse(userId));
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpPost("refund-order/{orderId}")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RefundOrder(Guid orderId)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (userId == null) return Unauthorized();

                var order = await _orderService.GetOrderDetails(orderId);
                if (order == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy đơn hàng!"
                    });
                }

                if (order.CustomerId != Guid.Parse(userId))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Bạn không có quyền hoàn tiền đơn hàng này!"
                    });
                }

                var successfulPayment = order.VNPayPaymentResponses?
                     .FirstOrDefault(x => x.TransactionStatus == "00");

                if (successfulPayment == null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy giao dịch thanh toán hợp lệ!"
                    });
                }
                string returnUrl = _configuration.GetValue<string>("VNPaySettings:RefundUrl");
                var refundResult = await _vnPayService.ProcessRefundAsync(
                    successfulPayment,
                    (decimal)order.TotalAmount,
                    order.OrderId.ToString(),
                    returnUrl
                );

                if (refundResult.Success == false)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Hoàn tiền thất bại. Vui lòng thử lại sau!"
                    });
                }
                var PaymentStatus = refundResult.Success ? 3 : 2;
                await _orderService.UpdateOrderStatus(orderId, PaymentType.Refunded, PaymentStatus, StatusOrder.RejecOrder);
                await _orderService.AddOrderPayment(refundResult.Response);
                return Ok(new ResponseVM
                {
                    Status = true,
                    Message = "Hoàn tiền thành công!"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi trong quá trình hoàn tiền: " + ex.Message
                });
            }
        }

        [HttpPost("calculate-shipping-fee")]
        [ProducesResponseType(typeof(ShippingFeeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CalculateShippingFee([FromBody] ShippingFeeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Request body cannot be null" });
                }

                // Validate required fields
                if (string.IsNullOrEmpty(request.ToWardCode) || request.ToDistrictId <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "ToWardCode and ToDistrictId are required" });
                }

                // Validate dimensions and weight
                if (request.Weight <= 0 || request.Length <= 0 || request.Width <= 0 || request.Height <= 0)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Invalid package dimensions or weight" });
                }

                // Validate insurance value (max 5,000,000 VND according to GHN)
                if (request.InsuranceValue > 5000000)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Insurance value cannot exceed 5,000,000 VND" });
                }

                var fee = await _shippingService.CalculateShippingFee(request);
                return Ok(fee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = $"Calculate shipping fee failed: {ex.Message}" });
            }
        }

        [HttpPost("create-shipping")]
        [Authorize(Roles = "Tourists")]

        [ProducesResponseType(typeof(ShippingOrderResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateShipping([FromBody] ShippingOrderRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Request body cannot be null" });
                }
                if (request.client_order_code == null)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Order Id cannot be null" });
                }
                // Validate insurance value (max 10,000,000 VND according to GHN)
                if (request.insurance_value > 10000000)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Insurance value cannot exceed 10,000,000 VND" });
                }
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var shipToUser = await _shipAddressService.GetShipAddressDetails(request.ShipAddressId);
                request.to_name = shipToUser.ToName;
                request.to_phone = shipToUser.ToPhone;
                request.to_address = shipToUser.ToAddress;
                request.to_ward_code = shipToUser.ToWardCode;
                request.to_district_id = shipToUser.ToDistrictId;
                var order = await _orderService.GetOrderDetails(Guid.Parse(request.client_order_code));
                Guid TouristFacilityId = Guid.NewGuid();
                foreach (var item in order.OrderDetails)
                {
                    request.items.Add(new ShippingOrderItem
                    {
                        name = item.Product.ProductName,
                        code = item.Product.ProductId.ToString(),
                        quantity = item.Quantity,
                        price = int.Parse(item.UnitPrice.ToString().Replace("00", "")),
                        length = 15,
                        weight = 15,
                        height = 15,
                        width = 15,
                        category = new Category
                        {
                            level1 = item.Product.ProductCategory.ToString()
                        }

                    });
                    TouristFacilityId = item.Product.TouristFacilityId;
                }
                var faci = await _touristFacilityService.GetTouristFacilities_Guest(TouristFacilityId);
                request.from_name = faci.TouristFacilityName;
                request.from_phone = faci.phone;
                request.from_address = faci.Address;
                request.from_ward_name = faci.ward_name;
                request.from_district_name = faci.district_name;
                request.from_province_name = faci.province_name;
                request.from_ward_code = faci.ward_code;
                request.to_district_id = (int)faci.district_id;
                request.return_phone = faci.phone;
                request.return_address = faci.Address;
                request.return_district_id = faci.district_id;
                request.return_ward_code = faci.ward_code;

                request.pick_shift = [2];
                request.pick_station_id = 1444;
                request.deliver_station_id = null;
                request.payment_type_id = 2;
                request.service_type_id = 2;
                request.service_id = 0;
                request.coupon = "";
                request.note = "nothing";
                var shipping = await _shippingService.CreateShippingOrder(request);
                await _orderService.UpdateShipCode(Guid.Parse(request.client_order_code), shipping.order_code);
                return Ok(shipping);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = $"Create shipping order failed: {ex.Message}" });
            }
        }

        [HttpGet("track-shipping/{OrderId}")]
        [Authorize(Roles = "Tourists")]
        [ProducesResponseType(typeof(ShippingTrackingResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> TrackShipping(Guid OrderId)
        {
            try
            {
                var response = await _orderService.GetOrderDetails(OrderId);
                var tracking = await _shippingService.TrackShippingOrder(response.ShipCode);
                return Ok(tracking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

    }
}
