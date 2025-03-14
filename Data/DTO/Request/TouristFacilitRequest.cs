using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class CreateTouristFacilityRequest
    {
        public Guid UserId { get; set; }
        public string TouristFacilityName { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
    public class UpdateTouristFacilityRequest
    {
        public Guid TouristFacilityId { get; set; }
        public Guid UserId { get; set; }
        public string TouristFacilityName { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
}
