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
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.Admin
{
    //[Guid("D66F7410-19D2-46D7-9C78-80C95BF57C8E")]
    [Route("api/admin/contract")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;
        private readonly IDriverService _driverService;
        private readonly IMapper _mapper;

        public ContractController(
             IMapper mapper,
             IContractService contractService,
             IDriverService driverService
            )
        {
            _mapper = mapper;
            _driverService = driverService;
            _contractService = contractService;
        }
        [HttpGet("get-list-contract")]
        [ProducesResponseType(typeof(List<Contract>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContracts()
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
        [HttpPost("add-contract")]
        [ProducesResponseType(typeof(Contract), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddContract([FromBody] Contract Contract)
        {
            try
            {
                var response = await _contractService.AddContract(Contract);
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
        [HttpPut("update-contract/{contractId}")]
        [ProducesResponseType(typeof(DriverRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDriver(Guid contractId, [FromBody] Contract request)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _contractService.UpdateContract(contractId, request);
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
    }
}
