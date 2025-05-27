using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AgriculturalTourPackage
    {
        public Guid TourId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public List<string>? Imgs { get; set; }
        public int Slot { get; set; }
        public double PriceOfAdults { get; set; }
        public double PriceOfChildren { get; set; }
        public string? ChildTicketAge { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid TourCompanyId { get; set; }
        public StatusActive StatusActive { get; set; }
        public string? GatheringLocation { get; set; }
        public Guid? GroupId { get; set; }

        public virtual TourCompany? TourCompany { get; set; }
        public virtual ICollection<TourDestination>? TourDestinations { get; set; }
        public virtual ICollection<TourGuide>? TourGuides { get; set; }
        public virtual ICollection<BookingAgriculturalTour>? BookingAgriculturalTours { get; set; }
        public virtual ICollection<Feedback>? Feedbacks { get; set; }

    }
    public enum StatusActive
    {
        active = 0,
        inactive = 1
    }
}
