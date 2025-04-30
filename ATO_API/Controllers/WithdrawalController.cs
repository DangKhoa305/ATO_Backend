using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.DashboardSer;
using Service.WithdrawalSer;

namespace ATO_API.Controllers;

[Route("api/withdrawl")]
[ApiController]
[Authorize]
public class WithdrawalController(IWithdrawalService withdrawalService, IDashboardService dashboardService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var facilityId = await dashboardService.GetFacilityIdFromUserIdAsync(Guid.Parse(userId!));
        var companyId = await dashboardService.GetCompanyIdFromUserIdAsync(Guid.Parse(userId!));


        var id = facilityId is null ? companyId : facilityId;

        var history = await withdrawalService.GetUserWithdrawalHistory(id ?? Guid.Empty);
        return Ok(history);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var history = await withdrawalService.GetWithdrawalHistory(id);
        return Ok(history);
    }
}