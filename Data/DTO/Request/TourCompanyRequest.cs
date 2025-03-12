using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class CreateTourCompanyRequest
    {
        public Guid UserId { get; set; }
        public string CompanynName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? AddressCompany { get; set; }
        public string? EmailCompany { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
    public class UpdateTourCompanyRequest
    {
        public Guid TourCompanyId { get; set; }
        public Guid UserId { get; set; }
        public string CompanynName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? AddressCompany { get; set; }
        public string? EmailCompany { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
}
