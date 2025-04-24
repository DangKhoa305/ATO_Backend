using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    // Đơn vị cung cấp du lịch nông nghiệp
    public class TouristFacility
    {
        public Guid TouristFacilityId { get; set; }
        public Guid UserId { get; set; }
        public string TouristFacilityName { get; set; }
        public string? Address { get; set; }
        // thong tin ship
        public string? phone { get; set; }
        public string? ward_name { get; set; }
        public string? district_name { get; set; }
        public string? province_name { get; set; }
        public string? ward_code { get; set; }
        public int? district_id { get; set; }

        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        //FK
        public virtual Account? Account { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Certification>? Certifications { get; set; }
        public virtual ICollection<UserSupport>? UserSupports { get; set; }
        public virtual ICollection<TourismPackage>? TourismPackages { get; set; }
        public virtual ICollection<Contract>? Contracts { get; set; }
    }
}
