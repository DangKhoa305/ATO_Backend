using Data.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Data.Seeding
{
    public class ContractSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ContractSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var contracts = new List<Contract>();

            var facilities = new List<TouristFacility>

{

new TouristFacility { TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"), TouristFacilityName = "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"), TouristFacilityName = "Du Lịch Sinh Thái Thác Bản Giốc" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"), TouristFacilityName = "Sa Pa Eco Farm Tour" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000003"), TouristFacilityName = "Farm Du Lịch Grape Valley" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000004"), TouristFacilityName = "Nông Trại Chè Trải Nghiệm Đại Từ" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000005"), TouristFacilityName = "Buôn Đôn Coffee Farm Tour" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000006"), TouristFacilityName = "Hà Giang Farmstay & Trek" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000007"), TouristFacilityName = "Trà My Sâm Ngọc Linh Tour" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000008"), TouristFacilityName = "Đà Lạt Organic Farm Tour" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000009"), TouristFacilityName = "Farmstay Nho & Thanh Long Bắc Bình" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000010"), TouristFacilityName = "Ba Bể Lake Ecofarm Tour" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000011"), TouristFacilityName = "Trang Trại Nông Sản Sạch Tân Châu" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000012"), TouristFacilityName = "Trải nghiệm Nông trại Biển & Rau Tuy An" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000013"), TouristFacilityName = "Trang Trại Nông Sản Sạch Càng Long" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000014"), TouristFacilityName = "Mỹ Xuyên Farmstay" },

new TouristFacility { TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000015"), TouristFacilityName = "Trang Trại Châu Đốc" }

};    // Seed bank accounts for tour companies

            var companies = new List<TourCompany>

{

new TourCompany { TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"), CompanynName = "Công ty Cổ phần Vietravel" },

new TourCompany { TourCompanyId = Guid.Parse("A1D2C3E4-F567-8901-2345-6789ABCDEF01"), CompanynName = "Saigontourist" },

new TourCompany { TourCompanyId = Guid.Parse("DC13D1DD-12CC-4153-9511-F59FF63F679B"), CompanynName = "Hanoitourist" },

new TourCompany { TourCompanyId = Guid.Parse("74E66DEF-A1C3-4140-A386-FA10E49D80F6"), CompanynName = "Fiditour" },

new TourCompany { TourCompanyId = Guid.Parse("98D9CAB9-C57E-4395-B1DB-00BEA4D22E46"), CompanynName = "Danang Travel" },

new TourCompany { TourCompanyId = Guid.Parse("0EA7235B-CC8C-4C1B-8304-4C0FC5BD26BA"), CompanynName = "VietSun Travel" },

new TourCompany { TourCompanyId = Guid.Parse("1301343C-9827-4152-8FC8-B72C13CC3B4A"), CompanynName = "Bamboo Travel" },

new TourCompany { TourCompanyId = Guid.Parse("7C1DF83B-ACED-4175-A3BE-280C8D651CC2"), CompanynName = "Phương Nam Travel" },

new TourCompany { TourCompanyId = Guid.Parse("7F325BE1-4B4A-4153-8151-23706FC88617"), CompanynName = "Đất Việt Tour" },

new TourCompany { TourCompanyId = Guid.Parse("896386C5-C839-48CA-8459-E4D033A644C0"), CompanynName = "Redtour" },

new TourCompany { TourCompanyId = Guid.Parse("4D0A0C3F-DE0A-4985-B188-21A65EB1F9B9"), CompanynName = "Dulichtoday" },

new TourCompany { TourCompanyId = Guid.Parse("09B0336B-C136-4FC3-BB9F-CEB605B7A7F8"), CompanynName = "Havatravel" },

new TourCompany { TourCompanyId = Guid.Parse("444F5CA4-481E-4004-AF73-78EC29765E05"), CompanynName = "Vũng Tàu Travel" },

new TourCompany { TourCompanyId = Guid.Parse("5887A0DB-ED74-49D2-AA02-7DB5943F11A3"), CompanynName = "Nha Trang Holiday" },

new TourCompany { TourCompanyId = Guid.Parse("22275542-0625-47BE-A503-2F13B7576E9B"), CompanynName = "Phan Thiết Tours" }

};

            // Create contracts between companies and facilities
            var random = new Random();
            var contractContents = new List<string>
            {
                "Hợp đồng hợp tác kinh doanh du lịch",
                "Thỏa thuận cung cấp dịch vụ lưu trú",
                "Hợp đồng đại lý du lịch",
                "Thỏa thuận hợp tác phát triển tour",
                "Hợp đồng cung cấp dịch vụ vận chuyển",
                "Thỏa thuận hợp tác quảng bá du lịch",
                "Hợp đồng cung cấp dịch vụ ăn uống",
                "Thỏa thuận hợp tác đào tạo nhân lực",
                "Hợp đồng cung cấp dịch vụ hướng dẫn viên",
                "Thỏa thuận hợp tác phát triển sản phẩm du lịch"
            };

            foreach (var company in companies)
            {
                contracts.Add(new Contract
                {
                    ContractId = Guid.NewGuid(),
                    TourCompanyId = company.TourCompanyId,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddYears(random.Next(1, 6)),
                    DiscountRate = random.Next(1, 6) / 100m,
                    CreateDate = DateTime.UtcNow,
                    ContractContent = contractContents[random.Next(contractContents.Count)],
                    SigningStatus = (SigningStatus)random.Next(0, 2)
                });
            }

            foreach (var facility in facilities)
            {
                contracts.Add(new Contract
                {
                    ContractId = Guid.NewGuid(),
                    TouristFacilityId = facility.TouristFacilityId,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddYears(random.Next(1, 6)),
                    DiscountRate = random.Next(1, 6) / 100m,
                    CreateDate = DateTime.UtcNow,
                    ContractContent = contractContents[random.Next(contractContents.Count)],
                    SigningStatus = (SigningStatus)random.Next(0, 2)
                });
            }

            modelBuilder.Entity<Contract>().HasData(contracts);
        }
    }
}