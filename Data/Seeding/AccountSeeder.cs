using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AccountSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AccountSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {


            // Seed role data
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<Guid>() { Id = Guid.Parse("0DAE2462-9EBD-452E-A89C-06D4B6025E68"), Name = "ContentModerators", NormalizedName = "CONTENTMODERATORS" },
                new IdentityRole<Guid>() { Id = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A"), Name = "TourismCompanies", NormalizedName = "TOURISMCOMPANIES" },
                new IdentityRole<Guid>() { Id = Guid.Parse("49E15EF3-2D88-4812-955F-D00859B3F7E3"), Name = "AgriculturalTourismFacilityOwners", NormalizedName = "ATFO" },
                new IdentityRole<Guid>() { Id = Guid.Parse("C78A64EB-5190-44C1-9886-CA707854B807"), Name = "Tourists", NormalizedName = "TOURISTS" },
                new IdentityRole<Guid>() { Id = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD"), Name = "TourGuides", NormalizedName = "TOURGUIDES" }
            );
            //Seed Account
            modelBuilder.Entity<Account>().HasData(
                // admin
                new Account()
                {
                    Id = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    UserName = "Administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "thutt170727@gmail.com",
                    NormalizedEmail = "THUTT170727@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Administrator",
                    isAccountActive = true,
                },
                //Content Moderators
                new Account()
                {
                    Id = Guid.Parse("11A068D3-9AF4-484C-82A2-E2B5C9D8B5AB"),
                    UserName = "ContentModerators",
                    NormalizedUserName = "CONTENTMODERATORS",
                    Email = "lucianafuste0717@gmail.com",
                    NormalizedEmail = "LUCIANAFUSTE0717@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Content Moderators",
                    isAccountActive = true,
                },
                //Tourism Companies
                new Account()
                {
                    Id = Guid.Parse("053D18EF-BA0E-4141-B142-898D28FA9B5D"),
                    UserName = "TourismCompanies",
                    NormalizedUserName = "TOURISMCOMPANIES",
                    Email = "truongthu112201@gmail.com",
                    NormalizedEmail = "TRUONGTHU112201@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Tourism Companies",
                    isAccountActive = true,
                },
                // ATFO
                new Account()
                {
                    Id = Guid.Parse("A631BB94-66D8-44DB-932B-532892D87754"),
                    UserName = "ATFO",
                    NormalizedUserName = "ATFO",
                    Email = "thutt170727@gmail.com",
                    NormalizedEmail = "THUTT170727@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Agricultural Tourism Facility Owners",
                    isAccountActive = true,
                },
                // Tourists
                new Account()
                {
                    Id = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0"),
                    UserName = "Tourists",
                    NormalizedUserName = "TOURIST",
                    Email = "ThangNVSE151059@fpt.edu.vn",
                    NormalizedEmail = "THANGNVSE151059@FPT.EDU.VN",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Tourists",
                    isAccountActive = true,
                },
                // Tour Guides
                new Account()
                {
                    Id = Guid.Parse("64454A5E-9883-4548-9A9D-D7986BF6B3AD"),
                    UserName = "TourGuides",
                    NormalizedUserName = "TOURGUIDES",
                    Email = "thuthuhe2501@gmail.com",
                    NormalizedEmail = "THUTHUHE2501@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "TourGuides",
                    isAccountActive = true,
                }
                );
            // Seed User in role
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                //Seed admin
                new IdentityUserRole<Guid> { UserId = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
                //Seed Content Moderators
                new IdentityUserRole<Guid> { UserId = Guid.Parse("11A068D3-9AF4-484C-82A2-E2B5C9D8B5AB"), RoleId = Guid.Parse("0DAE2462-9EBD-452E-A89C-06D4B6025E68") },
                //Seed Tourism Companies
                new IdentityUserRole<Guid> { UserId = Guid.Parse("053D18EF-BA0E-4141-B142-898D28FA9B5D"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                //Seed ATFO
                new IdentityUserRole<Guid> { UserId = Guid.Parse("A631BB94-66D8-44DB-932B-532892D87754"), RoleId = Guid.Parse("49E15EF3-2D88-4812-955F-D00859B3F7E3") },
                //Seed Tourists
                new IdentityUserRole<Guid> { UserId = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0"), RoleId = Guid.Parse("C78A64EB-5190-44C1-9886-CA707854B807") },
                //Seed Tour Guides
                new IdentityUserRole<Guid> { UserId = Guid.Parse("64454A5E-9883-4548-9A9D-D7986BF6B3AD"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") }
            );
        }
    }
}
