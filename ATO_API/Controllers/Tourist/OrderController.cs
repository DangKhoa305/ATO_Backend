using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.DriverSer;
using Service.OrderSer;
using StackExchange.Redis;

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
        public OrderController(
            IMapper mapper,
            IOrderService orderService,
            IConnectionMultiplexer redis
           )
        {
            _mapper = mapper;
            _orderService = orderService;
            _redis = redis;
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
        [ProducesResponseType(typeof(OrderRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddOrder([FromBody] OrderRequest OrderRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Data.Models.Order>(OrderRequest);
                responseResult.CustomerId = Guid.Parse(userId);
                var response = await _orderService.AddOrder(responseResult);
                return Ok(OrderRequest);
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
