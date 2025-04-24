using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.BookingTourDestinationSer;

namespace ATO_API.Controllers.TourGuides;

[Route("api/tour-guide/tracking")]
[ApiController]
[Authorize(Roles = "TourGuides")]
public class TrackingController(
    IBookingTourDestinationService destinationService,
    IMapper mapper) : ControllerBase
{
    private readonly IBookingTourDestinationService _destinationService = destinationService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("booking/{bookingId}/destinations")]
    [ProducesResponseType(typeof(List<BookingTourDestination>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetBookingDestinations(Guid bookingId)
    {
        try
        {
            var destinations = await _destinationService.GetBookingDestinations(bookingId);
            return Ok(destinations);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(false, ex.Message));
        }
    }

    [HttpPut("destination/{destinationId}/status")]
    [ProducesResponseType(typeof(BookingTourDestination), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateDestinationStatus(
        Guid destinationId,
        [FromBody] UpdateBookingDestinationRequest request)
    {
        try
        {
            var guideId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var result = await _destinationService.UpdateBookingDestination(
                destinationId,
                request,
                Guid.Parse(guideId!));

            if (!result)
                throw new Exception("Failed to update destination status. Please verify you are assigned to this tour.");

            return Ok(new ResponseModel(true, "Destination status updated successfully"));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(false, ex.Message));
        }
    }

    [HttpGet("destination/{destinationId}")]
    [ProducesResponseType(typeof(BookingTourDestination), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetDestinationDetails(Guid destinationId)
    {
        try
        {
            var destination = await _destinationService.GetBookingDestination(destinationId);

            if (destination == null)
                throw new Exception("Destination not found");

            return Ok(destination);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(false, ex.Message));
        }
    }
}
