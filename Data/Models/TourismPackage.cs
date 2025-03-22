using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TourismPackage
    {
        public Guid PackageId { get; set; }
        public Guid TouristFacilityId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        public StatusOperating StatusOperating { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
        public virtual ICollection<Activity>? Activities { get; set; }
        public virtual ICollection<TourDestination>? TourDestinations { get; set; }
    }
    public enum TimeType
    {
        second,
        minute,
        hour,
        day,
        month,
        year
    }
    public enum StatusOperating
    {
        Active,
        Inactive
    }
}
