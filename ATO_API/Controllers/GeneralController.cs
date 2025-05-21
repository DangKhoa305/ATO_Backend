using Microsoft.AspNetCore.Mvc;
using Service;

namespace ATO_API.Controllers;

[Route("api/general")]
[ApiController]
public class GeneralController(IGeneralService service) : ControllerBase
{

    [HttpGet("{tourId}")]
    public async Task<IActionResult> GetTourInfo(Guid tourId)
    {
        var data = await service.GetTourAsync(tourId);
        return Ok(data);
    }

    [HttpPut("{tourId}/{location}")]
    public async Task<IActionResult> UpdateLocation(Guid tourId, string location)
    {
        await service.UpdateLocationAsync(tourId, location);
        return Ok();
    }
}
