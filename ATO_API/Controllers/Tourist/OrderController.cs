using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Service.AccountSer;
using Service.DriverSer;
using Service.OrderSer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Text;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/order")]
    [ApiController]
    [Authorize(Roles = "Tourists")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IConnectionMultiplexer _redis;
        private readonly IMapper _mapper;
        private readonly IVnPayService _vnPayService;
        private readonly IConfiguration _configuration;
        public OrderController(
            IMapper mapper,
            IOrderService orderService,
            IConnectionMultiplexer redis,
            IVnPayService vnPayService,
            IConfiguration configuration
           )
        {
            _mapper = mapper;
            _orderService = orderService;
            _redis = redis;
            _vnPayService = vnPayService;
            _configuration = configuration;
        }
        [HttpGet("get-list-orders")]
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
        [ProducesResponseType(typeof(OrderRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDriver(Guid OrderId)
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
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddOrder([FromBody] OrderRequest OrderRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Data.Models.Order>(OrderRequest);
                responseResult.CustomerId = Guid.Parse(userId);
                var response = await _orderService.AddOrder(responseResult);
                if (OrderRequest.PaymentType == PaymentType.Transfer)
                {
                    decimal fee = (decimal)response.TotalAmount;
                    DateTime timecreate = DateTime.UtcNow;

                    var paymentUrl = await _vnPayService.CreatePaymentUrlAsync(HttpContext, response.OrderId, fee, timecreate, TypePayment.OrderPayment);
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
                var checkResponse = await _vnPayService.PaymentExecute(queryParams);
                await _orderService.AddOrderPayment(checkResponse);
                var queryString = new StringBuilder();
                foreach (var param in queryParams)
                {
                    var encodedValue = Uri.EscapeDataString(param.Value);
                    queryString.Append($"{param.Key}={encodedValue}&");
                }
                string returnUrl = _configuration.GetValue<string>("VNPaySettings:ReturnUrl");
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

    }
}
