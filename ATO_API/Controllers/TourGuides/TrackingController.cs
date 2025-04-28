using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.BookingTourDestinationSer;

namespace ATO_API.Controllers;

[Route("api/tracking")]
[ApiController]
public class BookingTourDestinationController(IBookingTourDestinationService service) : ControllerBase
{
    private readonly IBookingTourDestinationService _service = service;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] BookingTourDestination bookingDestination)
    {

        var result = await _service.CreateAsync(bookingDestination);
        return result ? Ok() : BadRequest();
    }

}