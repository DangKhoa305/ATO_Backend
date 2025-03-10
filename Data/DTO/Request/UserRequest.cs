using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class CreateAccountRequest
    {
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public DateTime? Dob { get; set; }
        public Guid Role { get; set; }
        // afto
        public CreateAccountRequest_TouristFacility? TouristFacility { get; set; }
        public CreateAccountRequest_TourCompany? TourCompany { get; set; }
        public CreateAccountRequest_TourGuide? TourGuide { get; set; }
    }
    public class CreateAccountRequest_TouristFacility
    {
        public string TouristFacilityName { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
    public class CreateAccountRequest_TourCompany
    {
        public string CompanynName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? AddressCompany { get; set; }
        public string? EmailCompany { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
    public class CreateAccountRequest_TourGuide
    {
        public Guid TourCompanyId { get; set; }
        public string? Bio { get; set; }
        public string? Languages { get; set; }
        public string? ExpertiseArea { get; set; }
        public double Rating { get; set; }
    }
    public class UpdateAccountRequest
    {
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public DateTime? Dob { get; set; }
        public Guid Role { get; set; }
        // afto
        public CreateAccountRequest_TouristFacility? TouristFacility { get; set; }
        public CreateAccountRequest_TourCompany? TourCompany { get; set; }
        public CreateAccountRequest_TourGuide? TourGuide { get; set; }
    }
}
