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
}
