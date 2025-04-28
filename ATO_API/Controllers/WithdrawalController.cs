using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.WithdrawalSer;

namespace ATO_API.Controllers;

[Route("api/withdrawl")]
[ApiController]
[Authorize]
public class WithdrawalController(IWithdrawalService withdrawalService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var history = await withdrawalService.GetUserWithdrawalHistory(Guid.Parse(userId!));
        return Ok(history);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var history = await withdrawalService.GetWithdrawalHistory(id);
        return Ok(history);
    }
}