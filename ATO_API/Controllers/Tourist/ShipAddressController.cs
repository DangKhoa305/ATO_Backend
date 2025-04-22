using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ShipAddressSer;
using Service.ShippingSer;

namespace ATO_API.Controllers.Tourist;

[Route("api/tourist/address")]
[ApiController]
//[Authorize(Roles = "Tourists")]
public class ShipAddressController(IShipAddressService shipAddressService, IMapper mapper, IShippingService shippingService) : ControllerBase
{
    private readonly IShipAddressService _shipAddressService = shipAddressService;
    private readonly IShippingService _shippingService = shippingService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var addresses = await _shippingService.GetShipAddresses(Guid.Parse(userId!));
            return Ok(addresses);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var address = await _shippingService.GetShipAddressDetails(id);
            if (address == null)
                return NotFound("Shipping address not found");

            return Ok(address);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] AddShipAddressRequest shipAddress)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            ShipAddress responseResult = _mapper.Map<ShipAddress>(shipAddress);
            responseResult.AccountId = Guid.Parse(userId!);
            var result = await _shipAddressService.AddShipAddress(responseResult);

            return Ok(new ResponseModel(result, result ? "Thêm địa chỉ thành công" : "Thêm địa chỉ thất bại"));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("provinces")]
    public async Task<IActionResult> GetProvinces()
    {
        try
        {
            var provinces = await _shippingService.GetProvinces();
            return Ok(provinces);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
        }
    }

    [HttpGet("districts/{provinceId}")]
    public async Task<IActionResult> GetDistricts(int provinceId)
    {
        try
        {
            var districts = await _shippingService.GetDistricts(provinceId);
            return Ok(districts);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
        }
    }

    [HttpGet("wards/{districtId}")]
    public async Task<IActionResult> GetWards(int districtId)
    {
        try
        {
            var wards = await _shippingService.GetWards(districtId);
            return Ok(wards);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM { Status = false, Message = ex.Message });
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] ShipAddressRequest shipAddress)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            ShipAddress responseResult = _mapper.Map<ShipAddress>(shipAddress);
            responseResult.AccountId = Guid.Parse(userId!);
            var result = await _shipAddressService.UpdateShipAddress(shipAddress.ShipAddressId, responseResult);
            if (!result)
                return NotFound("Shipping address not found");

            return Ok(new ResponseModel(result, result ? "Cập nhật địa chỉ thành công" : "Cập nhật địa chỉ thất bại"));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{shipAddressId}")]
    public async Task<ActionResult<bool>> DeleteAsync(Guid shipAddressId)
    {
        try
        {
            var result = await _shipAddressService.DeleteShipAddress(shipAddressId);
            return Ok(new ResponseModel(result, result ? "Xóa địa chỉ thành công" : "Xóa địa chỉ thất bại"));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
