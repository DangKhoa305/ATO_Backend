using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.TourCompanySer;
using Service.TouristFacilitySer;
using Service.UserSupportSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/tour-company")]
    //[Authorize(Roles = "Admin")]
    [ApiController]
    public class TourCompanyController : ControllerBase
    {
        private readonly ITourCompanyService _tourCompanyService;
        private readonly IMapper _mapper;
        public TourCompanyController(
            ITourCompanyService tourCompanyService,
            IMapper mapper
            )
        {
            _tourCompanyService = tourCompanyService;
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
    }
}
