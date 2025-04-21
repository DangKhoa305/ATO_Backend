using AutoMapper;
using Azure;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.AgriculturalTourPackageSer;

namespace ATO_API.Controllers
{
    [Route("api/content-moderators/package")]
    [ApiController]
    [Authorize(Roles = "ContentModerators")]
    public class PackageController : ControllerBase
    {
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;

        public PackageController(
             IMapper mapper,
             IAgriculturalTourPackageService agriculturalTourPackageService
        )
        {
            _mapper = mapper;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<AgriculturalTourPackageRespone_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackages()
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetAll();
                var responseResult = _mapper.Map<List<AgriculturalTourPackageRespone_Guest>>(response);


                return Ok(responseResult);
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
        [HttpGet("{tourId}")]
        [ProducesResponseType(typeof(AgriculturalTourPackageRespone_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackage(Guid tourId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetAgriculturalTourPackage_Guest(tourId);
                var responseResult = _mapper.Map<AgriculturalTourPackageRespone_Guest>(response);
                return Ok(responseResult);
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

        [HttpPut("process-approval/{tourId}/{status}")]
        [ProducesResponseType(typeof(AgriculturalTourPackageRespone_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackage(Guid tourId, StatusApproval status)
        {
            try
            {
                var success = await _agriculturalTourPackageService.ProcessApproval(tourId, status);
                var action = status == StatusApproval.Approved ? "Duyệt" : "Từ chối";
                var response = new { success, message = success ? $"{action} thành công" : $"{action} thất bại" };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var error = new { success = false, message = ex.Message };
                return Ok(error);
            }
        }

        [HttpGet("destination/{id}")]
        [ProducesResponseType(typeof(AgriculturalTourPackage_TourDestination_Respone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTourDestination(Guid id)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetTourDestination(id);
                var responseResult = _mapper.Map<AgriculturalTourPackage_TourDestination_Respone>(response);
                return Ok(responseResult);
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
