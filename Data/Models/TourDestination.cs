using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TourDestination
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
        //fk
        public Guid TourId { get; set; }
        public Guid TourismPackageId { get; set; }
        public Guid DriverId { get; set; }
        public Guid AccommodationId { get; set; }
        public Guid ActivityId { get; set; }
        public virtual AgriculturalTourPackage? AgriculturalTourPackage { get; set; }
        public virtual TourismPackage? TourismPackage { get; set; }
        public virtual Driver? Driver { get; set; }
        public virtual Accommodation? Accommodation { get; set; }
        public virtual Activity? Activity { get; set; }
    }
    public enum TypeActivity
    {
        Accommodation,
        Drive,
        Destination
    }
}
