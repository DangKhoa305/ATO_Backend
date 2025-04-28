
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.ContractSer;

namespace ATO_API.Controllers;

//[Guid("D66F7410-19D2-46D7-9C78-80C95BF57C8E")]
[Route("api/contract")]
[ApiController]
public class ContractController(IContractService contractService, IMapper mapper) : ControllerBase
{
    private readonly IContractService _contractService = contractService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var response = await _contractService.ListContract();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpGet("facility")]
    public async Task<IActionResult> GetFacilityContractAsync()
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var response = await _contractService.ListContractFacility(Guid.Parse(userId!));

            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpGet("company")]
    public async Task<IActionResult> GetCompanyContractAsync()
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var response = await _contractService.ListContractTourCompany(Guid.Parse(userId!));

            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        try
        {
            var response = await _contractService.GetContract(id);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddContract([FromBody] CreateContractRequest request)
    {
        try
        {
            var contract = _mapper.Map<Contract>(request);
            var response = await _contractService.AddContract(contract);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContract(Guid id, [FromBody] UpdateContractRequest request)
    {
        try
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var contract = _mapper.Map<Contract>(request);
            var response = await _contractService.UpdateContract(id, contract);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message,
            });
        }
    }

    [HttpPost("send-otp/{id}")]
    public async Task<IActionResult> SendOTP(Guid id)
    {
        try
        {
            var response = await _contractService.SendOTPAsync(id);
            if (!response)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Không thể gửi mã OTP"
                });
            }
            return Ok(new ResponseVM
            {
                Status = true,
                Message = "Đã gửi mã OTP thành công"
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }

    [HttpPut("sign/{id}")]
    public async Task<IActionResult> SignContract(Guid id)
    {
        try
        {
            var response = await _contractService.SignContractAsync(id);
            if (!response)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Không thể ký hợp đồng"
                });
            }
            return Ok(new ResponseVM
            {
                Status = true,
                Message = "Ký hợp đồng thành công"
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }

    [HttpPost("extend/{id}")]
    public async Task<IActionResult> ExtendContract(Guid id)
    {
        try
        {
            var response = await _contractService.SendOTPAsync(id);
            if (!response)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Không thể gửi mã OTP"
                });
            }
            return Ok(new ResponseVM
            {
                Status = true,
                Message = "Đã gửi mã OTP thành công"
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }
}
