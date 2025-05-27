using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.BookingSer;
using Service.BookingTourDestinationSer;
using Service.OrderSer;
using Service.VnPaySer;
using System.Text;

namespace ATO_API.Controllers.Tourist;

[Route("api/tourist/book-tour")]
[ApiController]
public class BookingController(
    IMapper mapper,
    IOrderService orderService,
    IVnPayService vnPayService,
    IConfiguration configuration,
    IBookingService bookingService,
    IBookingTourDestinationService bookingTourDestinationService,
    IBookingTourDestinationService service
       ) : ControllerBase
{
    private readonly IOrderService _orderService = orderService;
    private readonly IBookingService _bookingService = bookingService;
    private readonly IBookingTourDestinationService _bookingTourDestinationService = bookingTourDestinationService;
    private readonly IMapper _mapper = mapper;
    private readonly IVnPayService _vnPayService = vnPayService;
    private readonly IConfiguration _configuration = configuration;
    private readonly IBookingTourDestinationService _service = service;

    [HttpGet("get-list-book-tours")]
    [Authorize(Roles = "Tourists")]
    [ProducesResponseType(typeof(List<BookingAgriculturalTourRespone>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetBookeds()
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var response = await _bookingService.ListTourBookeds(Guid.Parse(userId!));
            var responseResult = _mapper.Map<List<BookingAgriculturalTourRespone>>(response);

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
    [Authorize(Roles = "Tourists")]
    [ProducesResponseType(typeof(BookingAgriculturalTourRespone), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetBookTourDetails(Guid BookingId)
    {
        try
        {
            var response = await _bookingService.GetBookTourDetails(BookingId);
            var responseResult = _mapper.Map<BookingAgriculturalTourRespone>(response);
            responseResult.Trackings = await _service.GetAllByTour(responseResult.TourId);

            responseResult.AgriculturalTourPackage!.TourGuides = await _bookingService.GetTourGuide(responseResult.TourGuidIds);


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
    [HttpPost("add-book-tour")]
    [Authorize(Roles = "Tourists")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> AddBookTour([FromBody] BookingAgriculturalTourRequest BookingAgriculturalTour)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            //// TODO: restrict booked tours
            //var isActiveBooking = await _bookingService.IsActiveBooking(Guid.Parse(userId!));
            //if(isActiveBooking)
            //{
            //    return Ok(new ResponseModel(false, "Bạn đang có tour đang hoạt động"));
            //}

            var responseResult = _mapper.Map<Data.Models.BookingAgriculturalTour>(BookingAgriculturalTour);
            responseResult.CustomerId = Guid.Parse(userId);
            var response = await _bookingService.AddBookTour(responseResult);
            DateTime timecreate = DateTime.UtcNow;
            var paymentUrl = await _vnPayService.CreatePaymentUrlAsync(HttpContext, response.BookingId, response.TotalAmmount, timecreate, TypePayment.TourPayment);
            return Ok(paymentUrl);
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
    [HttpGet("return_book")]
    public async Task<IActionResult> VNPayReturnAsync()
    {
        try
        {
            var queryParams = Request.Query;
            var checkResponse = await _vnPayService.PaymentExecute(queryParams);
            await _bookingService.AddBookPayment(checkResponse);
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

    [HttpPost("cancel/{tourId}")]
    [Authorize(Roles = "Tourists")]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> RefundOrder(Guid tourId)
    {

        try
        {
            // Note: this will cancel all the booked tour of others so unable to fix it with current design
            return Ok();

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized();

            var tour = await _bookingService.GetBookTourDetails(tourId);
            if (tour == null)
            {
                return NotFound(new ResponseVM
                {
                    Status = false,
                    Message = "Không tìm thấy tour!"
                });
            }

            if (tour.CustomerId != Guid.Parse(userId))
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Bạn không có quyền hoàn tiền đơn hàng này!"
                });
            }

            var successfulPayment = tour.VNPayPaymentResponses?
                 .FirstOrDefault(x => x.TransactionStatus == "00");

            if (successfulPayment == null)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Không tìm thấy giao dịch thanh toán hợp lệ!"
                });
            }
            string returnUrl = _configuration.GetValue<string>("VNPaySettings:RefundUrl")!;
            var refundResult = await _vnPayService.ProcessRefundBookingAsync(
                successfulPayment,
                tour.TotalAmmount,
                successfulPayment.BookingId.ToString(),
                returnUrl
            );


            var PaymentStatus = 0;
            await _bookingService.UpdateStatus(tourId, PaymentStatus, StatusBooking.Canceled);
            await _bookingService.AddBookPaymentRefund(refundResult.Response);
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
}
