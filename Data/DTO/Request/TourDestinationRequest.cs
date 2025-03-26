using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class TourDestinationRequest
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int VisitOrder { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public Guid? TourismPackageId { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? AccommodationId { get; set; }
        public Guid? ActivityId { get; set; }
        public virtual ICollection<AgriculturalTourPackageRequest_TourGuides>? TourGuides { get; set; }
    }

}
