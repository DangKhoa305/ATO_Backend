using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.FacilityCertificationSer;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATO_API.Controllers;

[Route("api/facility-certifications")]
[ApiController]
public class FacilityCertificationController(IFacilityCertificationService certificationService) : ControllerBase
{
    private readonly IFacilityCertificationService _certificationService = certificationService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var certification = await _certificationService.GetByIdAsync(id);
        if (certification == null) return NotFound();
        return Ok(certification);
    }

    [HttpGet("facility/{facilityId}")]
    public async Task<IActionResult> GetAllByFacility(Guid facilityId)
    {
        var certifications = await _certificationService.GetAllByFacilityAsync(facilityId);
        return Ok(certifications);
    }

    [HttpPost]
    [Authorize(Roles = "TouristFacilities")]
    public async Task<IActionResult> Create(FacilityCertification certification)
    {
        var result = await _certificationService.CreateAsync(certification);
        if (!result) return BadRequest();
        return CreatedAtAction(nameof(GetById), new { id = certification.CertificationId }, certification);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "TouristFacilities")]
    public async Task<IActionResult> Update(Guid id, FacilityCertification certification)
    {
        if (id != certification.CertificationId) return BadRequest();
        var result = await _certificationService.UpdateAsync(id, certification);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "TouristFacilities")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _certificationService.DeleteAsync(id);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpPost("{id}/approve")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Approve(Guid id, [FromBody] string reply)
    {
        var result = await _certificationService.ApproveCertificationAsync(id, reply);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpPost("{id}/reject")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Reject(Guid id, [FromBody] string reply)
    {
        var result = await _certificationService.RejectCertificationAsync(id, reply);
        if (!result) return NotFound();
        return NoContent();
    }
}