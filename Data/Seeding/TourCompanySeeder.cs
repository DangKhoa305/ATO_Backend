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
    public class TourCompanySeeder
    {
        /*

         */
        private readonly ModelBuilder modelBuilder;

        public TourCompanySeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed Tour Company
            modelBuilder.Entity<TourCompany>().HasData(
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("053D18EF-BA0E-4141-B142-898D28FA9B5D"),
                    AddressCompany = "03 Hai Bà Trưng, Phường Phan Chu Trinh, Quận Hoàn Kiếm, Hà Nội.",
                    CompanynName = "Công ty Cổ phần Vietravel",
                    CompanyDescription = "",
                    EmailCompany = "vtv.cholon@vietravel.com",
                    Website = "https://travel.com.vn/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253)
                },
                new TourCompany
                {
                    TourCompanyId = Guid.Parse("A1D2C3E4-F567-8901-2345-6789ABCDEF01"),
                    UserId = Guid.Parse("D2C3E4F5-6789-0123-4567-89ABCDEF0123"),
                    AddressCompany = "25 Nguyễn Huệ, Quận 1, TP.HCM",
                    CompanynName = "Saigontourist",
                    CompanyDescription = "Lữ hành hàng đầu Việt Nam.",
                    EmailCompany = "contact@saigontourist.net",
                    Website = "https://saigontourist.net/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany
                {
                    TourCompanyId = Guid.Parse("DC13D1DD-12CC-4153-9511-F59FF63F679B"),
                    UserId = Guid.Parse("645F6CD7-A359-4643-9E28-0D6EB32D103B"),
                    AddressCompany = "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội",
                    CompanynName = "Hanoitourist",
                    CompanyDescription = "Tour du lịch nội địa và quốc tế.",
                    EmailCompany = "support@hanoitourist.com",
                    Website = "https://hanoitourist.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany
                {
                    TourCompanyId = Guid.Parse("74E66DEF-A1C3-4140-A386-FA10E49D80F6"),
                    UserId = Guid.Parse("E858B667-00C1-4431-8C41-5C9F88B4FCF8"),
                    AddressCompany = "15 Lê Lợi, Quận 1, TP.HCM",
                    CompanynName = "Fiditour",
                    CompanyDescription = "Tour trọn gói, uy tín.",
                    EmailCompany = "info@fiditour.com",
                    Website = "https://fiditour.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany
                {
                    TourCompanyId = Guid.Parse("98D9CAB9-C57E-4395-B1DB-00BEA4D22E46"),
                    UserId = Guid.Parse("D0E45BEE-A768-4555-BFEB-788728A53751"),
                    AddressCompany = "90 Nguyễn Thị Minh Khai, Đà Nẵng",
                    CompanynName = "Danang Travel",
                    CompanyDescription = "Chuyên tour biển đảo Đà Nẵng.",
                    EmailCompany = "info@danangtravel.com",
                    Website = "https://danangtravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("0EA7235B-CC8C-4C1B-8304-4C0FC5BD26BA"),
                    UserId = Guid.Parse("AA5C5293-88E6-4110-AF70-68FEAE5D6A89"),
                    AddressCompany = "45 Điện Biên Phủ, Quận 3, TP.HCM",
                    CompanynName = "VietSun Travel",
                    CompanyDescription = "Chuyên tour du lịch nội địa và quốc tế.",
                    EmailCompany = "contact@vietsuntravel.com",
                    Website = "https://vietsuntravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("1301343C-9827-4152-8FC8-B72C13CC3B4A"),
                    UserId = Guid.Parse("2EA71D2C-9932-46BC-9423-730DCC7BEB92"),
                    AddressCompany = "15 Phạm Ngũ Lão, Quận 1, TP.HCM",
                    CompanynName = "Bamboo Travel",
                    CompanyDescription = "Dịch vụ du lịch cao cấp.",
                    EmailCompany = "contact@bambotravel.com",
                    Website = "https://bambotravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("7C1DF83B-ACED-4175-A3BE-280C8D651CC2"),
                    UserId = Guid.Parse("34417EFE-85A3-43BB-8DE0-DAAB43BC3E29"),
                    AddressCompany = "99 Hoàng Diệu, Ba Đình, Hà Nội",
                    CompanynName = "Phương Nam Travel",
                    CompanyDescription = "Du lịch chất lượng, giá rẻ.",
                    EmailCompany = "info@phuongnamtravel.com",
                    Website = "https://phuongnamtravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                 new TourCompany()
                 {
                     TourCompanyId = Guid.Parse("7F325BE1-4B4A-4153-8151-23706FC88617"),
                     UserId = Guid.Parse("A2416864-FF31-4E7A-BC1B-368CC7C1EE1C"),
                     AddressCompany = "10 Lê Thánh Tôn, Quận 1, TP.HCM",
                     CompanynName = "Đất Việt Tour",
                     CompanyDescription = "Chuyên tổ chức tour du lịch trong và ngoài nước.",
                     EmailCompany = "contact@datviettour.com",
                     Website = "https://datviettour.com/",
                     LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                     CreateDate = DateTime.UtcNow
                 },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("896386C5-C839-48CA-8459-E4D033A644C0"),
                    UserId = Guid.Parse("939A7F24-A476-4E7E-8345-7C58EBB737B4"),
                    AddressCompany = "20 Trần Hưng Đạo, Hà Nội",
                    CompanynName = "Redtour",
                    CompanyDescription = "Dịch vụ du lịch chất lượng cao.",
                    EmailCompany = "info@redtour.com.vn",
                    Website = "https://redtour.com.vn/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("4D0A0C3F-DE0A-4985-B188-21A65EB1F9B9"),
                    UserId = Guid.Parse("E469A23D-F6DE-4C36-9E44-FC43EEB6A24B"),
                    AddressCompany = "90 Nguyễn Văn Linh, Đà Nẵng",
                    CompanynName = "Dulichtoday",
                    CompanyDescription = "Thông tin và tổ chức tour du lịch.",
                    EmailCompany = "support@dulichtoday.com",
                    Website = "https://dulichtoday.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("09B0336B-C136-4FC3-BB9F-CEB605B7A7F8"),
                    UserId = Guid.Parse("B7D23D43-0CF4-41A6-AA07-9CF8F563DB77"),
                    AddressCompany = "120 Phan Chu Trinh, TP.Huế",
                    CompanynName = "Havatravel",
                    CompanyDescription = "Công ty du lịch chuyên nghiệp tại Huế.",
                    EmailCompany = "contact@havatravel.com",
                    Website = "https://havatravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("444F5CA4-481E-4004-AF73-78EC29765E05"),
                    UserId = Guid.Parse("BD5E9D2C-FB27-4896-B1D6-CC09DAD3CFDB"),
                    AddressCompany = "50 Nguyễn Trãi, TP. Vũng Tàu",
                    CompanynName = "Vũng Tàu Travel",
                    CompanyDescription = "Tour du lịch biển chất lượng cao.",
                    EmailCompany = "info@vungtautravel.com",
                    Website = "https://vungtautravel.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("5887A0DB-ED74-49D2-AA02-7DB5943F11A3"),
                    UserId = Guid.Parse("46A916DB-F0E3-4855-9171-EFF063B5CC90"),
                    AddressCompany = "75 Hùng Vương, TP. Nha Trang",
                    CompanynName = "Nha Trang Holiday",
                    CompanyDescription = "Dịch vụ đặt tour du lịch biển chuyên nghiệp.",
                    EmailCompany = "support@nhatrangholiday.com",
                    Website = "https://nhatrangholiday.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("22275542-0625-47BE-A503-2F13B7576E9B"),
                    UserId = Guid.Parse("679D0AA0-710B-4026-BCDE-D274FCC269A0"),
                    AddressCompany = "23 Lê Lợi, TP. Phan Thiết",
                    CompanynName = "Phan Thiết Tours",
                    CompanyDescription = "Chuyên tour khám phá biển và cát trắng.",
                    EmailCompany = "contact@phanthiettours.com",
                    Website = "https://phanthiettours.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("CD55E17F-17E9-4DF8-82AB-1BD0FDFDEE92"),
                    UserId = Guid.Parse("C7E55065-CACD-4FDF-AE68-2A4BB8AE3375"),
                    AddressCompany = "14 Nguyễn Huệ, TP. Đà Lạt",
                    CompanynName = "Đà Lạt Tour",
                    CompanyDescription = "Tour du lịch khám phá Đà Lạt.",
                    EmailCompany = "info@dalattour.com",
                    Website = "https://dalattour.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                },
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("C2A98B89-B536-48A0-96F6-29D23A0138AC"),
                    UserId = Guid.Parse("A173D7B4-E503-4508-892A-5D1A4901CD03"),
                    AddressCompany = "66 Trần Phú, TP. Quy Nhơn",
                    CompanynName = "Quy Nhơn Explorer",
                    CompanyDescription = "Tour du lịch biển và văn hóa Quy Nhơn.",
                    EmailCompany = "contact@quynhonexplorer.com",
                    Website = "https://quynhonexplorer.com/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb",
                    CreateDate = DateTime.UtcNow
                }
            );
        }
    }
}
