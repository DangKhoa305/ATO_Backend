using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.TourismPackageSer;

namespace ATO_API.Controllers;

[Route("api/content-moderators/package")]
[ApiController]
[Authorize(Roles = "ContentModerators")]
public class PackageController(
    ITourismPackageService service,
    IMapper mapper) : ControllerBase
{
    private readonly ITourismPackageService _service = service;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    [ProducesResponseType(typeof(List<TourismPackageRespone>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var response = await _service.GetAllAsync();
            var mapped = _mapper.Map<List<TourismPackageRespone>>(response);
            return Ok(mapped);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(true, ex.Message));
        }
    }
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TourismPackageRespone), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var response = await _service.GetTourismPackage(id);
            var mapped = _mapper.Map<TourismPackageRespone>(response);
            return Ok(mapped);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(true, ex.Message));
        }
    }

    [HttpPut("process-approval/{id}/{status}")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ProccessApprovalAsync(Guid id, StatusApproval status)
    {
        try
        {
            var result = await _service.ProcessApprovalAsync(id, status);
            if (result is false)
                throw new Exception("Cập nhật trạng thái thất bại!");

            return Ok(new ResponseModel(true, "Cập nhật trạng thái thành công!"));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(true, ex.Message));
        }
    }
    [HttpGet("activity/{id}")]
    [ProducesResponseType(typeof(ActivityRespone), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]

    public async Task<IActionResult> GetActivityAsync(Guid id)
    {
        try
        {
            var response = await _service.GetActivity(id);
            var mapped = _mapper.Map<ActivityRespone>(response);
            return Ok(mapped);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseModel(true, ex.Message));
        }
    }
}

