using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TourCompany
    {
        public Guid TourCompanyId { get; set; }
        public Guid UserId { get; set; }
        public string CompanynName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? AddressCompany { get; set; }
        public string? EmailCompany { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        //FK
        public virtual Account? Account { get; set; }
        public virtual ICollection<TourGuide>? TourGuides { get; set; }
        public virtual ICollection<Driver>? Drivers { get; set; }
        public virtual ICollection<Accommodation>? Accommodations { get; set; }
        public virtual ICollection<TourismPackage>? TourismPackages { get; set; }
        public virtual ICollection<AgriculturalTourPackage>? AgriculturalTourPackages { get; set; }
    }
}
