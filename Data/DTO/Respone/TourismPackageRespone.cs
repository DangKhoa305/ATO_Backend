using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class TourismPackageRespone
    {
        public Guid PackageId { get; set; }
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
        public virtual ICollection<ActivityRespone>? Activities { get; set; }
    }
    public class TourismPackageRespone_TC
    {
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public virtual TouristFacilityDTO? TouristFacility { get; set; }
        public virtual ICollection<ActivityRespone>? Activities { get; set; }
    }
    public class ActivityRespone_TC
    {
        public Guid ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string? Description { get; set; }
        public double DurationInHours { get; set; }
        public string? Location { get; set; }
        public List<string>? Imgs { get; set; }
        public double BreakTimeInMinutes { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual ICollection<Product_ActivityRespone>? Products { get; set; }
    }
}
