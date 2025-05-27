using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AgriculturalTourPackageSer;
using Service.BookingSer;
using Service.OrderSer;
using Service.ShippingSer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Text;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/book-tour")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class BookingController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IBookingService _bookingService;
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;
        private readonly IVnPayService _vnPayService;
        private readonly IConfiguration _configuration;
        public BookingController(
            IMapper mapper,
            IOrderService orderService,
            IVnPayService vnPayService,
            IConfiguration configuration,
            IBookingService bookingService,
             IAgriculturalTourPackageService agriculturalTourPackageService
           )
        {
            _mapper = mapper;
            _orderService = orderService;
            _vnPayService = vnPayService;
            _configuration = configuration;
            _bookingService = bookingService;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }
        [HttpGet("get-list-book-tours")]
        [ProducesResponseType(typeof(List<BookingAgriculturalTourRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBookeds()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _bookingService.ListTourBookingTour_TourCompany(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<BookingAgriculturalTourRespone>>(response);


                var result = new List<BookingAgriculturalTourRespone>();

                foreach (var item in responseResult)
                {
                    item.TotalBookedPeople = await _agriculturalTourPackageService.GetPeople(item.GroupId ?? Guid.Empty);

                    result.Add(item);
                }



                return Ok(result);
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
        [ProducesResponseType(typeof(List<VNPayPaymentResponse_History>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBookedsHistory()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _bookingService.ListHistoryPayments(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<VNPayPaymentResponse>>(response);


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
        [HttpGet("get-book-tour/{BookingId}")]
        [ProducesResponseType(typeof(BookingAgriculturalTourRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBookTourDetails(Guid BookingId)
        {
            try
            {
                var response = await _bookingService.GetBookTourDetails(BookingId);
                var responseResult = _mapper.Map<BookingAgriculturalTourRespone>(response);
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
        [HttpPost("update-booking-status")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBookingStatus([FromBody] BookingAccept BookingAccept)
        {
            try
            {
                await _bookingService.UpdateBookingStatus(BookingAccept);
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
    }
}
