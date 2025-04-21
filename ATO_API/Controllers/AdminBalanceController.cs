using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.AdminBalanceSer;

namespace ATO_API.Controllers;

[Route("api/admin/balance")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminBalanceController(IAdminBalanceService adminBalanceService) : ControllerBase
{
    private readonly IAdminBalanceService _adminBalanceService = adminBalanceService;

    [HttpGet("history")]
    public async Task<IActionResult> GetBalanceHistory()
    {
        var history = await _adminBalanceService.GetBalanceHistory();
        return Ok(history);
    }

    [HttpGet("current-balance")]
    public async Task<IActionResult> GetCurrentBalance()
    {
        var balance = await _adminBalanceService.GetCurrentBalance();
        return Ok(new { Balance = balance });
    }
}