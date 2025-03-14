using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class TourGuideRespone
    {
        public Guid GuideId { get; set; }
        public Guid TourCompanyId { get; set; }
        public Guid UserId { get; set; }
        public string? Bio { get; set; }
        public string? Languages { get; set; }
        public string? ExpertiseArea { get; set; }
        public double Rating { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual TourGuideRespone_Account? Account { get; set; }
    }
    public class TourGuideRespone_Account
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public DateTime? Dob { get; set; }
        public bool isAccountActive { get; set; }
    }
}
