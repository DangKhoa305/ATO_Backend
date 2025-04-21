using Microsoft.AspNetCore.Mvc;
using Service.AdminBalanceSer;

namespace ATO_API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(Roles = "Admin")]
public class AdminBalanceController(IAdminBalanceService adminBalanceService) : ControllerBase
{
    [HttpGet("total")]
    public async Task<IActionResult> GetTotalBalance()
    {
        var balance = await adminBalanceService.GetTotalBalance();
        return Ok(new { TotalBalance = balance });
    }
}