using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TourCompanySer;
using Service.TourismPackageSer;

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/tourism-package")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
    public class TourismPackageController : ControllerBase
    {
        private readonly ITourismPackageService _tourismPackageService;
        private readonly IMapper _mapper;

        public TourismPackageController(
            ITourismPackageService tourismPackageService,
            IMapper mapper
            )
        {
            _tourismPackageService = tourismPackageService;
            _mapper = mapper;
        }
        [HttpGet("list-tourism-package")]
        [ProducesResponseType(typeof(List<TourismPackageRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTouristPackages()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                List<Data.Models.TourismPackage> response = await _tourismPackageService.GetListTourismPackages(Guid.Parse(userId));
                List<TourismPackageRespone> responseResult = _mapper.Map<List<TourismPackageRespone>>(response);
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
        [HttpGet("get-tourism-package/{PackageId}")]
        [ProducesResponseType(typeof(TourismPackageRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristPackage(Guid PackageId)
        {
            try
            {
                Data.Models.TourismPackage response = await _tourismPackageService.GetTourismPackage(PackageId);
                TourismPackageRespone responseResult = _mapper.Map<TourismPackageRespone>(response);
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
        [HttpPost("create-tourism-package")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTouristPackage([FromBody] TourismPackageRequest tourismPackageRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                TourismPackage responseResult = _mapper.Map<TourismPackage>(tourismPackageRequest);
                bool result = await _tourismPackageService.CreateTourismPackage_AFTO(responseResult, Guid.Parse(userId));
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới không thành công!",
                });
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
        [HttpPut("update-tourism-package/{PackageId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTouristPackage(Guid PackageId, [FromBody] TourismPackageRequest tourismPackageRequest)
        {
            try
            {
                TourismPackage responseResult = _mapper.Map<TourismPackage>(tourismPackageRequest);
                bool result = await _tourismPackageService.UpdateTourismPackage_AFTO(PackageId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật không thành công!",
                });
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
        [HttpPost("create-activity")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateActivity([FromBody] ActivityRequest activityRequest)
        {
            try
            {
                Activity responseResult = _mapper.Map<Activity>(activityRequest);
                bool result = await _tourismPackageService.CreateActivity_AFTO(responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới không thành công!",
                });
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
        [HttpPut("update-activity/{ActivityId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateActivity(Guid ActivityId, [FromBody] ActivityRequest activityRequest)
        {
            try
            {
                Activity responseResult = _mapper.Map<Activity>(activityRequest);
                bool result = await _tourismPackageService.UpdateActivity_AFTO(ActivityId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật không thành công!",
                });
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
