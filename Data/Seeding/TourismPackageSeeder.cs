using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TourismPackageSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public TourismPackageSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {

            modelBuilder.Entity<TourismPackage>().HasData(
                new TourismPackage
                {
                    PackageId = Guid.Parse("32BA5585-D88D-4C07-8C3A-5C3F846CD138"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Hành trình khám phá Hạ Long",
                    Description = "Tour du lịch Hạ Long 3 ngày 2 đêm với nhiều hoạt động thú vị.",
                    Price = 3500000,
                    Durations = 3,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("7874FC31-CDAE-4CF7-9AEE-B802ED19ED58"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Trải nghiệm du lịch Đà Nẵng",
                    Description = "Tour 4 ngày 3 đêm tham quan các điểm nổi bật như Bà Nà Hills, Hội An.",
                    Price = 5000000,
                    Durations = 4,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = "",
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("7E5D0A21-9F4B-4C2A-AC11-AAAE96FCEC31"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Khám phá vùng Tây Bắc",
                    Description = "Tour khám phá Sapa, Mộc Châu 5 ngày 4 đêm, thích hợp cho người yêu thiên nhiên.",
                    Price = 6000000,
                    Durations = 5,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Reject,
                    ReplyRequest = "Chưa đáp ứng yêu cầu về an toàn.",
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("A649B3B4-10A2-4225-A229-BE4D66F29552"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Trải nghiệm miền Tây sông nước",
                    Description = "Tour 3 ngày 2 đêm khám phá chợ nổi Cái Răng, vườn trái cây, và cuộc sống người dân.",
                    Price = 3200000,
                    Durations = 3,
                    CreateDate = DateTime.UtcNow.AddDays(-5),
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("321C5B3A-D096-4406-BD11-FBFBD4436FC5"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Du lịch Phú Quốc - Thiên đường biển đảo",
                    Description = "Tour 4 ngày 3 đêm tận hưởng vẻ đẹp của bãi biển Phú Quốc, lặn san hô, thưởng thức hải sản.",
                    Price = 7000000,
                    Durations = 4,
                    CreateDate = DateTime.UtcNow.AddDays(-10),
                    UpdateDate = DateTime.UtcNow.AddDays(-2),
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = "",
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                }
            );


        }
    }
}
