using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Certification
    {
        public Guid CertificationId { get; set; }
        public string CertificationName { get; set;}
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? CertificationDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        // Request Certificate
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        //FK
        public Guid? TouristFacilityId { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
        public Guid? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
    public enum StatusApproval
    {
        Approved,
        Processing,
        Reject
    }
}
