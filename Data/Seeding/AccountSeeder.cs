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
        /*
         */
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
                new IdentityRole<Guid>() { Id = Guid.Parse("49E15EF3-2D88-4812-955F-D00859B3F7E3"), Name = "AgriculturalTourismFacilityOwners", NormalizedName = "AGRICULTURALTOURISMFACILITYOWNERS" },
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
                new Account
                {
                    Id = Guid.Parse("D2C3E4F5-6789-0123-4567-89ABCDEF0123"),
                    UserName = "SaigontouristAccount",
                    NormalizedUserName = "SAIGONTOURISTACCOUNT",
                    Email = "contact@saigontourist.net",
                    NormalizedEmail = "CONTACT@SAIGONTOURIST.NET",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Saigontourist",
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("645F6CD7-A359-4643-9E28-0D6EB32D103B"),
                    UserName = "HanoitouristAccount",
                    NormalizedUserName = "HANOITOURISTACCOUNT",
                    Email = "support@hanoitourist.com",
                    NormalizedEmail = "SUPPORT@HANOITOURIST.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Hanoitourist",
                    isAccountActive = true
                },
                // Account cho Fiditour
                new Account
                {
                    Id = Guid.Parse("E858B667-00C1-4431-8C41-5C9F88B4FCF8"),
                    UserName = "FiditourAccount",
                    NormalizedUserName = "FIDITOURACCOUNT",
                    Email = "info@fiditour.com",
                    NormalizedEmail = "INFO@FIDITOUR.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Fiditour",
                    isAccountActive = true
                },
                // Account cho Danang Travel
                new Account
                {
                    Id = Guid.Parse("D0E45BEE-A768-4555-BFEB-788728A53751"),
                    UserName = "DanangTravelAccount",
                    NormalizedUserName = "DANANGTRAVELACCOUNT",
                    Email = "info@danangtravel.com",
                    NormalizedEmail = "INFO@DANANGTRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Danang Travel",
                    isAccountActive = true
                },
                // Account cho VietSun Travel
                new Account
                {
                    Id = Guid.Parse("AA5C5293-88E6-4110-AF70-68FEAE5D6A89"),
                    UserName = "VietSunTravelAccount",
                    NormalizedUserName = "VIETSUNTRAVELACCOUNT",
                    Email = "contact@vietsuntravel.com",
                    NormalizedEmail = "CONTACT@VIETSUNTRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "VietSun Travel",
                    isAccountActive = true
                },
                // Account cho Bamboo Travel
                new Account
                {
                    Id = Guid.Parse("2EA71D2C-9932-46BC-9423-730DCC7BEB92"),
                    UserName = "BambooTravelAccount",
                    NormalizedUserName = "BAMBOOTRAVELACCOUNT",
                    Email = "contact@bambotravel.com",
                    NormalizedEmail = "CONTACT@BAMBOOTRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Bamboo Travel",
                    isAccountActive = true
                },
                // Account cho Phương Nam Travel
                new Account
                {
                    Id = Guid.Parse("34417EFE-85A3-43BB-8DE0-DAAB43BC3E29"),
                    UserName = "PhuongNamTravelAccount",
                    NormalizedUserName = "PHUONGNAMTRAVELACCOUNT",
                    Email = "info@phuongnamtravel.com",
                    NormalizedEmail = "INFO@PHUONGNAMTRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Phương Nam Travel",
                    isAccountActive = true
                },
                // Account cho Đất Việt Tour
                new Account
                {
                    Id = Guid.Parse("A2416864-FF31-4E7A-BC1B-368CC7C1EE1C"),
                    UserName = "DatVietTourAccount",
                    NormalizedUserName = "DATVIETTOURACCOUNT",
                    Email = "contact@datviettour.com",
                    NormalizedEmail = "CONTACT@DATVIETTOUR.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Đất Việt Tour",
                    isAccountActive = true
                },
                // Account cho Redtour
                new Account
                {
                    Id = Guid.Parse("939A7F24-A476-4E7E-8345-7C58EBB737B4"),
                    UserName = "RedtourAccount",
                    NormalizedUserName = "REDTOURACCOUNT",
                    Email = "info@redtour.com.vn",
                    NormalizedEmail = "INFO@REDTOUR.COM.VN",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Redtour",
                    isAccountActive = true
                },
                // Account cho Dulichtoday
                new Account
                {
                    Id = Guid.Parse("E469A23D-F6DE-4C36-9E44-FC43EEB6A24B"),
                    UserName = "DulichTodayAccount",
                    NormalizedUserName = "DULICHTODAYACCOUNT",
                    Email = "support@dulichtoday.com",
                    NormalizedEmail = "SUPPORT@DULICHTODAY.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Dulich Today",
                    isAccountActive = true
                },
                // Account cho Havatravel
                new Account
                {
                    Id = Guid.Parse("B7D23D43-0CF4-41A6-AA07-9CF8F563DB77"),
                    UserName = "HavatravelAccount",
                    NormalizedUserName = "HAVATRAVELACCOUNT",
                    Email = "contact@havatravel.com",
                    NormalizedEmail = "CONTACT@HAVATRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Havatravel",
                    isAccountActive = true
                },
                // Account cho Vũng Tàu Travel
                new Account
                {
                    Id = Guid.Parse("BD5E9D2C-FB27-4896-B1D6-CC09DAD3CFDB"),
                    UserName = "VungTauTravelAccount",
                    NormalizedUserName = "VUNGTAUTRAVELACCOUNT",
                    Email = "info@vungtautravel.com",
                    NormalizedEmail = "INFO@VUNGTAUTRAVEL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Vũng Tàu Travel",
                    isAccountActive = true
                },
                // Account cho Nha Trang Holiday
                new Account
                {
                    Id = Guid.Parse("46A916DB-F0E3-4855-9171-EFF063B5CC90"),
                    UserName = "NhaTrangHolidayAccount",
                    NormalizedUserName = "NHATRANGHOLIDAYACCOUNT",
                    Email = "support@nhatrangholiday.com",
                    NormalizedEmail = "SUPPORT@NHATRANGHOLIDAY.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Nha Trang Holiday",
                    isAccountActive = true
                },
                // Account cho Phan Thiết Tours
                new Account
                {
                    Id = Guid.Parse("679D0AA0-710B-4026-BCDE-D274FCC269A0"),
                    UserName = "PhanThietToursAccount",
                    NormalizedUserName = "PHANTHIETTOURSACCOUNT",
                    Email = "contact@phanthiettours.com",
                    NormalizedEmail = "CONTACT@PHANTHIETTOURS.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Phan Thiết Tours",
                    isAccountActive = true
                },
                // Account cho Đà Lạt Tour
                new Account
                {
                    Id = Guid.Parse("C7E55065-CACD-4FDF-AE68-2A4BB8AE3375"),
                    UserName = "DalatTourAccount",
                    NormalizedUserName = "DALATTOURACCOUNT",
                    Email = "info@dalattour.com",
                    NormalizedEmail = "INFO@DALATOUR.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Đà Lạt Tour",
                    isAccountActive = true
                },
                // Account cho Quy Nhơn Explorer
                new Account
                {
                    Id = Guid.Parse("A173D7B4-E503-4508-892A-5D1A4901CD03"),
                    UserName = "QuyNhonExplorerAccount",
                    NormalizedUserName = "QUYNHONEXPLORERACCOUNT",
                    Email = "contact@quynhonexplorer.com",
                    NormalizedEmail = "CONTACT@QUYNHONEXPLORER.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Quy Nhơn Explorer",
                    isAccountActive = true
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
                },
                 new Account
                 {
                     Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                     UserName = "JohnDoe",
                     NormalizedUserName = "JOHNDOE",
                     Email = "johndoe@example.com",
                     NormalizedEmail = "JOHNDOE@EXAMPLE.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     Fullname = "John Doe",
                     Gender = true,
                     AvatarURL = "https://example.com/avatar1.jpg",
                     Dob = new DateTime(1990, 5, 15),
                     isAccountActive = true
                 },
                new Account
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    UserName = "EmmaWatson",
                    NormalizedUserName = "EMMAWATSON",
                    Email = "emmawatson@example.com",
                    NormalizedEmail = "EMMAWATSON@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Emma Watson",
                    Gender = false,
                    AvatarURL = "https://example.com/avatar2.jpg",
                    Dob = new DateTime(1988, 8, 20),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    UserName = "MichaelBrown",
                    NormalizedUserName = "MICHAELBROWN",
                    Email = "michaelbrown@example.com",
                    NormalizedEmail = "MICHAELBROWN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Michael Brown",
                    Gender = true,
                    AvatarURL = "https://example.com/avatar3.jpg",
                    Dob = new DateTime(1985, 11, 10),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    UserName = "SophiaLee",
                    NormalizedUserName = "SOPHIALEE",
                    Email = "sophialee@example.com",
                    NormalizedEmail = "SOPHIALEE@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Sophia Lee",
                    Gender = false,
                    AvatarURL = "https://example.com/avatar4.jpg",
                    Dob = new DateTime(1992, 3, 25),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    UserName = "DavidJohnson",
                    NormalizedUserName = "DAVIDJOHNSON",
                    Email = "davidjohnson@example.com",
                    NormalizedEmail = "DAVIDJOHNSON@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "David Johnson",
                    Gender = true,
                    AvatarURL = "https://example.com/avatar5.jpg",
                    Dob = new DateTime(1995, 7, 30),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    UserName = "LiamNguyen",
                    NormalizedUserName = "LIAMNGUYEN",
                    Email = "liamnguyen@example.com",
                    NormalizedEmail = "LIAMNGUYEN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Liam Nguyen",
                    Gender = true,
                    AvatarURL = "https://example.com/avatar6.jpg",
                    Dob = new DateTime(1987, 6, 14),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                    UserName = "OliviaKim",
                    NormalizedUserName = "OLIVIAKIM",
                    Email = "oliviakim@example.com",
                    NormalizedEmail = "OLIVIAKIM@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Olivia Kim",
                    Gender = false,
                    AvatarURL = "https://example.com/avatar7.jpg",
                    Dob = new DateTime(1993, 12, 5),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD"),
                    UserName = "DanielMartinez",
                    NormalizedUserName = "DANIELMARTINEZ",
                    Email = "daniel.martinez@example.com",
                    NormalizedEmail = "DANIEL.MARTINEZ@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Daniel Martinez",
                    Gender = true,
                    AvatarURL = "https://example.com/avatar8.jpg",
                    Dob = new DateTime(1989, 2, 18),
                    isAccountActive = true
                },
                new Account
                {
                    Id = Guid.Parse("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                    UserName = "EmilyClark",
                    NormalizedUserName = "EMILYCLARK",
                    Email = "emilyclark@example.com",
                    NormalizedEmail = "EMILYCLARK@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Fullname = "Emily Clark",
                    Gender = false,
                    AvatarURL = "https://example.com/avatar9.jpg",
                    Dob = new DateTime(1994, 9, 8),
                    isAccountActive = true
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
                new IdentityUserRole<Guid> { UserId = Guid.Parse("D2C3E4F5-6789-0123-4567-89ABCDEF0123"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("645F6CD7-A359-4643-9E28-0D6EB32D103B"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("E858B667-00C1-4431-8C41-5C9F88B4FCF8"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("D0E45BEE-A768-4555-BFEB-788728A53751"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("AA5C5293-88E6-4110-AF70-68FEAE5D6A89"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("2EA71D2C-9932-46BC-9423-730DCC7BEB92"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("34417EFE-85A3-43BB-8DE0-DAAB43BC3E29"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("A2416864-FF31-4E7A-BC1B-368CC7C1EE1C"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("939A7F24-A476-4E7E-8345-7C58EBB737B4"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("E469A23D-F6DE-4C36-9E44-FC43EEB6A24B"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("B7D23D43-0CF4-41A6-AA07-9CF8F563DB77"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("BD5E9D2C-FB27-4896-B1D6-CC09DAD3CFDB"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("46A916DB-F0E3-4855-9171-EFF063B5CC90"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("679D0AA0-710B-4026-BCDE-D274FCC269A0"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("C7E55065-CACD-4FDF-AE68-2A4BB8AE3375"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("A173D7B4-E503-4508-892A-5D1A4901CD03"), RoleId = Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A") },

                //Seed ATFO
                new IdentityUserRole<Guid> { UserId = Guid.Parse("A631BB94-66D8-44DB-932B-532892D87754"), RoleId = Guid.Parse("49E15EF3-2D88-4812-955F-D00859B3F7E3") },
                //Seed Tourists
                new IdentityUserRole<Guid> { UserId = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0"), RoleId = Guid.Parse("C78A64EB-5190-44C1-9886-CA707854B807") },
                //Seed Tour Guides
                new IdentityUserRole<Guid> { UserId = Guid.Parse("64454A5E-9883-4548-9A9D-D7986BF6B3AD"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("66666666-6666-6666-6666-666666666666"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("88888888-8888-8888-8888-888888888888"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") },
                new IdentityUserRole<Guid> { UserId = Guid.Parse("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), RoleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD") }


            );
        }
    }
}
