using Data.Migrations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Account : IdentityUser<Guid>
    {
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public DateTime? Dob { get; set; }
        public bool isAccountActive { get; set; }


        // FK
        public virtual ICollection<Blog>? Blogs { get; set; }
        // người dùng này nếu là tour company
        public virtual TourCompany? TourCompany { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
        public virtual TourGuide? TourGuide { get; set; }
        public virtual ICollection<UserSupport>? UserSupports { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
