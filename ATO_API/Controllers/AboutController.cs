using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Service.AboutSer;

namespace ATO_API.Controllers
{
    [Route("api/about")]
    [ApiController]
    public class AboutController : ControllerBase
    {

        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(
            IAboutService aboutService,
            IMapper mapper
        )
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAbout()
        {
            try
            {
                return Ok(await _aboutService.GetAbout());
            }
            catch (System.Exception ex)
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
