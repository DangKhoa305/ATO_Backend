using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Activity
    {
        public Guid ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string? Description { get; set; }
        public double DurationInHours { get; set; }
        public TimeType DurationInHoursType { get; set; }
        public string? Location { get; set; }
        public List<string>? Imgs { get; set; }
        public double BreakTimeInMinutes { get; set; }
        public TimeType BreakTimeInMinutesType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        public Guid? PackageId { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual TourismPackage? TourismPackage { get; set; }
        public virtual ICollection<TourDestination>? TourDestinations { get; set; }
        public int? MaxCapacity { get; set; }

    }
}
