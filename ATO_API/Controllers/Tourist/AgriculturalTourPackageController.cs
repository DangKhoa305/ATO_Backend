using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccommodationSer;
using Service.AgriculturalTourPackageSer;

namespace ATO_API.Controllers.Tourist
{
    [Route("api/tourist/agricultural-tour-package")]
    [ApiController]
    public class AgriculturalTourPackageController : ControllerBase
    {
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;

        public AgriculturalTourPackageController(
             IMapper mapper,
             IAgriculturalTourPackageService agriculturalTourPackageService
        )
        {
            _mapper = mapper;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }

    }
}
