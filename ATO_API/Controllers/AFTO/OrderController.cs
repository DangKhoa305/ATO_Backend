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
using Service.ShipAddressSer;
using Service.ShippingSer;
using Service.TouristFacilitySer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Text;
using System.Transactions;
using static Service.ShippingSer.ShippingService;

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/order")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IConnectionMultiplexer _redis;
        private readonly IMapper _mapper;
        private readonly IVnPayService _vnPayService;
        private readonly IConfiguration _configuration;
        private readonly IShippingService _shippingService;
        private readonly ITouristFacilityService _touristFacilityService;
        private readonly IShipAddressService _shipAddressService;
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
            _touristFacilityService = touristFacilityService;
            _shipAddressService = shipAddressService;
        }
        [HttpGet("get-list-orders")]
        [ProducesResponseType(typeof(List<OrderRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _orderService.ListOrders_AFTO(Guid.Parse(userId));
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
        [HttpGet("get-list-history-payment")]
        [ProducesResponseType(typeof(List<VNPayPaymentResponse_History_Order>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBookedsHistory()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _orderService.ListHistoryPaymentsOrder(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<VNPayPaymentResponse_History_Order>>(response);


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
        [HttpPost("accept-order")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AcceptOrder([FromBody] OrderAcceptRequest OrderAcceptRequest)
        {
            try
            {
                await _orderService.AcceptOrder(OrderAcceptRequest);
                return Ok();
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
        [HttpGet("provinces")]
        [ProducesResponseType(typeof(ProvinceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvinces()
        {
            try
            {
                var provinces = await _shippingService.GetProvinces();
                return Ok(provinces);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

        [HttpGet("districts/{provinceId}")]
        [ProducesResponseType(typeof(DistrictResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDistricts(int provinceId)
        {
            try
            {
                var districts = await _shippingService.GetDistricts(provinceId);
                return Ok(districts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }

        [HttpGet("wards/{districtId}")]
        [ProducesResponseType(typeof(WardResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWards(int districtId)
        {
            try
            {
                var wards = await _shippingService.GetWards(districtId);
                return Ok(wards);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
            }
        }
        [HttpGet("ship-address-details/{shipAddressId}")]
        public async Task<ActionResult<ShipAddressRespone>> GetShipAddressDetails(Guid shipAddressId)
        {
            try
            {
                var address = await _shippingService.GetShipAddressDetails(shipAddressId);

                if (address == null)
                    return NotFound("Shipping address not found");

                return Ok(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
                        price = int.Parse(item.UnitPrice.ToString().Replace(".00", "")),
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
