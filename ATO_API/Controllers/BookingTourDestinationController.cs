using Data.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.BookingTourDestinationSer;
using System;
using System.Threading.Tasks;

namespace ATO_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingTourDestinationController : ControllerBase
    {
        private readonly IBookingTourDestinationService _service;

        public BookingTourDestinationController(IBookingTourDestinationService service)
        {
            _service = service;
        }

        [HttpGet("booking/{bookingId}")]
        public async Task<IActionResult> GetBookingDestinations(Guid bookingId)
        {
            var result = await _service.GetBookingDestinations(bookingId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingDestination(Guid id)
        {
            var result = await _service.GetBookingDestination(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookingDestination(
            Guid id,
            [FromBody] UpdateBookingDestinationRequest request,
            [FromQuery] Guid tourGuideId)
        {
            var result = await _service.UpdateBookingDestination(id, request, tourGuideId);
            if (!result) return BadRequest();
            return Ok();
        }

        [HttpPost("initialize/{bookingId}")]
        public async Task<IActionResult> InitializeBookingDestinations(Guid bookingId)
        {
            var result = await _service.InitializeBookingDestinations(bookingId);
            if (!result) return BadRequest();
            return Ok();
        }
    }
}