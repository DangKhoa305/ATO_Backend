using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/product")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
    public class TourismPackageController : ControllerBase
    {
    }
}
