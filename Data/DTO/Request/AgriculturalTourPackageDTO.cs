using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class AgriculturalTourPackageRequest
    {
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public List<string>? Imgs { get; set; }
        public int Slot { get; set; }
        public double Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public virtual ICollection<AgriculturalTourPackageRequest_TourGuides>? TourGuides { get; set; }
    }
    public class AgriculturalTourPackageRequest_TourGuides
    {
        public Guid GuideId { get; set; }
    }

}
