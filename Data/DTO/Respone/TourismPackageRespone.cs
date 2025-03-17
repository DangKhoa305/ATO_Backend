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
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        public virtual TourCompany_TourismPackageRespone? TourCompany { get; set; }
        public virtual ICollection<ActivityRespone>? Activities { get; set; }
    }
    public class TourCompany_TourismPackageRespone
    {
        public Guid TourCompanyId { get; set; }
        public string CompanynName { get; set; }
    }
}
