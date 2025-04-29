using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.DashboardSer;

namespace ATO_API.Controllers;

[Route("api/dashboard")]
[ApiController]
public class DashboardController(IDashboardService dashboardService) : ControllerBase
{
    private readonly IDashboardService _dashboardService = dashboardService;

    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAdminDashboard()
    {
        var data = await _dashboardService.GetAdminDashboardDataAsync();
        return Ok(data);
    }

    [HttpGet("company")]
    [Authorize(Roles = "TourismCompanies")]
    public async Task<IActionResult> GetTourCompanyDashboard()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        var companyId = await _dashboardService.GetCompanyIdFromUserIdAsync(Guid.Parse(userId!)) ?? Guid.Empty;
        var data = await _dashboardService.GetTourCompanyDashboardDataAsync(companyId);
        return Ok(data);
    }

    [HttpGet("facility")]
    public async Task<IActionResult> GetTouristFacilityDashboard()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var facilityId = await _dashboardService.GetFacilityIdFromUserIdAsync(Guid.Parse(userId!)) ?? Guid.Empty;
        var data = await _dashboardService.GetTouristFacilityDashboardDataAsync(facilityId);
        return Ok(data);
    }
}