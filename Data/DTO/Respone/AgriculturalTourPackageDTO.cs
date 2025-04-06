using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class AgriculturalTourPackageRespone
    {
        public Guid TourId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public List<string>? Imgs { get; set; }
        public int Slot { get; set; }
        public double Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourDestination_Respone>? TourDestinations { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourGuide_Respone>? TourGuides { get; set; }
    }
    public class AgriculturalTourPackage_TourDestination_Respone
    {
        public Guid TourDestinationId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int VisitOrder { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        public virtual TourismPackageRespone? TourismPackage { get; set; }
        public virtual DriverRespone? Driver { get; set; }
        public virtual AccommodationRespone? Accommodation { get; set; }
        public virtual AgriculturalTourPackage_TourDestination_Activity_Respone? Activity { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourGuide_Respone>? TourGuides { get; set; }
    }
    public class AgriculturalTourPackage_TourGuide_Respone
    {
        public Guid GuideId { get; set; }
        public Guid UserId { get; set; }
        public string? Bio { get; set; }
        public string? Languages { get; set; }
        public string? ExpertiseArea { get; set; }
        public double Rating { get; set; }
        public virtual TourGuideRespone_Account? Account { get; set; }
    }
    public class AgriculturalTourPackage_TourDestination_Activity_Respone
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
    }
    public class AgriculturalTourPackageRespone_Guest
    {
        public Guid TourId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public List<string>? Imgs { get; set; }
        public int Slot { get; set; }
        public double Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourDestination_Respone_Guest>? TourDestinations { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourGuide_Respone>? TourGuides { get; set; }
    }
    public class AgriculturalTourPackage_TourDestination_Respone_Guest
    {
        public Guid TourDestinationId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int VisitOrder { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public virtual TourismPackageRespone_Guest? TourismPackage { get; set; }
        public virtual DriverRespone? Driver { get; set; }
        public virtual AccommodationRespone? Accommodation { get; set; }
        public virtual AgriculturalTourPackage_TourDestination_Activity_Respone? Activity { get; set; }
        public virtual ICollection<AgriculturalTourPackage_TourGuide_Respone>? TourGuides { get; set; }
    }
    public class TourismPackageRespone_Guest
    {
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
    }
}
