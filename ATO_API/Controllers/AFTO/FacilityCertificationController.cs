using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.DashboardSer;
using Service.FacilityCertificationSer;

namespace ATO_API.Controllers;

[Route("api/facility-certifications")]
[ApiController]
[Authorize]
public class FacilityCertificationController(IFacilityCertificationService certificationService,
    IDashboardService dashboardService) : ControllerBase
{
    private readonly IFacilityCertificationService _certificationService = certificationService;
    private readonly IDashboardService _dashboardService = dashboardService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var certification = await _certificationService.GetAll();
        if (certification == null) return NotFound();
        return Ok(certification);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var certification = await _certificationService.GetByIdAsync(id);
        if (certification == null) return NotFound();
        return Ok(certification);
    }

    [HttpGet("facility")]
    public async Task<IActionResult> GetAllByFacility()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var facilityId = await _dashboardService.GetFacilityIdFromUserIdAsync(Guid.Parse(userId!)) ?? Guid.Empty;

        var certifications = await _certificationService.GetAllByFacilityAsync(facilityId);
        return Ok(certifications);
    }

    [HttpPost]
    public async Task<IActionResult> Create(FacilityCertification certification)
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        certification.TouristFacilityId = await _dashboardService.GetFacilityIdFromUserIdAsync(Guid.Parse(userId!));
        var result = await _certificationService.CreateAsync(certification);
        if (!result) return BadRequest();
        return CreatedAtAction(nameof(GetById), new { id = certification.CertificationId }, certification);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, FacilityCertification certification)
    {
        if (id != certification.CertificationId) return BadRequest();
        var result = await _certificationService.UpdateAsync(id, certification);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _certificationService.DeleteAsync(id);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpPost("{id}/approve")]
    public async Task<IActionResult> Approve(Guid id, [FromBody] string reply)
    {
        var result = await _certificationService.ApproveCertificationAsync(id, reply);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpPost("{id}/reject")]
    public async Task<IActionResult> Reject(Guid id, [FromBody] string reply)
    {
        var result = await _certificationService.RejectCertificationAsync(id, reply);
        if (!result) return NotFound();
        return NoContent();
    }
}