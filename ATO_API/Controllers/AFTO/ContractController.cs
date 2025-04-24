using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.AccountSer;
using Service.ContractSer;
using Service.DriverSer;
using Service.TourGuideSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/contract")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;
        private readonly IMapper _mapper;

        public ContractController(
             IMapper mapper,
             IContractService contractService
            )
        {
            _mapper = mapper;
            _contractService = contractService;
        }
        [HttpGet("get-list-contract")]
        [ProducesResponseType(typeof(List<Contract>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContracts()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _contractService.ListContractFacility(Guid.Parse(userId));

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
        [HttpGet("get-contract/{ContractId}")]
        [ProducesResponseType(typeof(Contract), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContract(Guid ContractId)
        {
            try
            {
                var response = await _contractService.GetContract(ContractId);
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

        [HttpPost("send-otp/{contractId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SendOTP(Guid contractId)
        {
            try
            {
                var response = await _contractService.SendOTPAsync(contractId);
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

        [HttpPut("sign-contract/{contractId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SignContract(Guid contractId)
        {
            try
            {
                var response = await _contractService.SignContractAsync(contractId);
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
    }
}
