using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Contract
    {
        public Guid ContractId { get; set; }
        public string? ContractContent { get; set; }   
        public decimal? DiscountRate { get; set;}
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set;}
        public DateTime? SignedDate { get; set; }
        public bool? Status { get; set; }
        public bool? RequestReSignContract { get; set; }
        public DateTime? CreateDate { get; set;}
        public DateTime? UpdateDate { get; set; }
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        public virtual TourCompany? TourCompany { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
    }
}
