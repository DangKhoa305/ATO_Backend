using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TourCompanySer;
using Service.TouristFacilitySer;
using Service.UserSupportSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/tour-company")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class TourCompanyController : ControllerBase
    {
        private readonly ITourCompanyService _tourCompanyService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public TourCompanyController(
            ITourCompanyService tourCompanyService,
            IAccountService accountService,
            IMapper mapper
            )
        {
            _tourCompanyService = tourCompanyService;
            _accountService = accountService;
            _mapper = mapper;
        }
        [HttpGet("list-tour-companies")]
        [ProducesResponseType(typeof(List<TourCompanyDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTouristFacility()
        {
            try
            {
                List<TourCompany> response = await _tourCompanyService.GetListTourCompanies_Admin();
                List<TourCompanyDTO> responseResult = _mapper.Map<List<TourCompanyDTO>>(response);
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
        [HttpGet("get-tour-company/{TourCompanyId}")]
        [ProducesResponseType(typeof(TourCompanyDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristFacility(Guid TourCompanyId)
        {
            try
            {
                TourCompany response = await _tourCompanyService.GetTourCompany_Admin(TourCompanyId);
                TourCompanyDTO responseResult = _mapper.Map<TourCompanyDTO>(response);
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
        [HttpPost("create-tour-company")]
        [ProducesResponseType(typeof(TourCompanyDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTourCompany([FromBody] CreateTourCompanyRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.CompanynName))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Tên công ty không được để trống."
                    });
                }
                if (request.UserId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Quản lý công ty không được để trống!"
                    });
                }

                var newTourCompany = _mapper.Map<TourCompany>(request);
                newTourCompany.TourCompanyId = Guid.NewGuid();
                newTourCompany.CreateDate = DateTime.UtcNow;

                await _tourCompanyService.AddTourCompanyAsync(newTourCompany);

                var response = _mapper.Map<TourCompanyDTO>(newTourCompany);
                return CreatedAtAction(nameof(GetTouristFacility), new { TourCompanyId = newTourCompany.TourCompanyId }, response);
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
        [HttpPut("update-tour-company")]
        [ProducesResponseType(typeof(TourCompanyDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTourCompany([FromBody] UpdateTourCompanyRequest request)
        {
            try
            {
                if (request.TourCompanyId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Tour Company Id không hợp lệ."
                    });
                }

                if (string.IsNullOrWhiteSpace(request.CompanynName))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Tên công ty không được để trống."
                    });
                }

                if (request.UserId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Quản lý công ty không được để trống!"
                    });
                }

                var existingTourCompany = await _tourCompanyService.GetTourCompany_Admin(request.TourCompanyId);
                if (existingTourCompany == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy Tour Company."
                    });
                }

                _mapper.Map(request, existingTourCompany);


                await _tourCompanyService.UpdateTourCompanyAsync(existingTourCompany);
                var response = _mapper.Map<TourCompanyDTO>(existingTourCompany);
                return Ok(response);
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
        [HttpGet("unassigned-tour-companies")]
        [ProducesResponseType(typeof(IEnumerable<UserUnassignedTourCompany>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUnassignedTourCompanies()
        {
            try
            {
                var tourCompanies = await _accountService.GetUnassignedTourCompaniesAsync();

                var response = _mapper.Map<IEnumerable<UserUnassignedTourCompany>>(tourCompanies);
                return Ok(response);
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
