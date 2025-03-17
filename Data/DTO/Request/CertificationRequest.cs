using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class CreateCertificationDTO
    {
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public List<string>? Imgs { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? CertificationDetails { get; set; }
        public Guid? ProductId { get; set; }
    }
    public class UpdateCertificationDTO
    {
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; }
        public List<string>? Imgs { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? CertificationDetails { get; set; }
        public Guid? ProductId { get; set; }
    }
    public class ApprovelCertificationDTO
    {
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
    }
}
