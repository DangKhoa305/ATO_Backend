using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    // công ty bán tour du lịch
    public class TourCompany
    {
        public Guid TourCompanyId { get; set; }
        public Guid UserId { get; set; }
        public string CompanynName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? AddressCompany { get; set;}
        public string? EmailCompany { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        //FK
        public virtual Account Account { get; set; }
    }
}
