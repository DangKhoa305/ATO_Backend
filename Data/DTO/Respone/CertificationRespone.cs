using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class CertificationRespone
    {
        public Guid CertificationId { get; set; }
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public List<string>? Imgs { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? CertificationDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
    }
    public class CertificationRespone_CM
    {
        public Guid CertificationId { get; set; }
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? CertificationDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        //FK
        public Guid? TouristFacilityId { get; set; }
        public virtual TouristFacilityDTO_Certfication? TouristFacility { get; set; }
        public Guid? ProductId { get; set; }
        public virtual ProductDTO? Product { get; set; }
    }
}
