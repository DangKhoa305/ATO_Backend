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
            #region CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC
                new TourismPackage
                {
                    PackageId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Khám phá nông nghiệp Mộc Châu",
                    Description = "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.",
                    Price = 3500000,
                    Durations = 6,
                    DurationsType = TimeType.hour,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Tour hái chè và thưởng trà OCOP",
                    Description = "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.",
                    Price = 2800000,
                    Durations = 4,
                    DurationsType = TimeType.hour,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Một ngày làm nông dân OCOP",
                    Description = "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.",
                    Price = 3200000,
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD"),
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    PackageName = "Du lịch thiện nguyện & nông nghiệp xanh",
                    Description = "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.",
                    Price = 4000000,
                    Durations = 2,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
            #endregion
            #region Du Lịch Sinh Thái Thác Bản Giốc
                new TourismPackage
                {
                    PackageId = Guid.Parse("20000000-0000-0000-0000-000000000001"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    PackageName = "Một ngày làm nông dân vùng biên",
                    Description = "Tham gia gieo trồng rau hữu cơ, thu hoạch nông sản, học cách chăm sóc trâu bò, và dùng cơm trưa với người dân bản địa.",
                    Price = 1200000,
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("20000000-0000-0000-0000-000000000002"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    PackageName = "Trải nghiệm thu hoạch mùa vụ",
                    Description = "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa; tìm hiểu quy trình chế biến thực phẩm sạch tại trang trại.",
                    Price = 950000,
                    Durations = 6,
                    DurationsType = TimeType.hour,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("20000000-0000-0000-0000-000000000003"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    PackageName = "Khám phá nông nghiệp và văn hóa địa phương",
                    Description = "Kết hợp hoạt động nông nghiệp với giao lưu văn hóa dân tộc Tày - Nùng, thưởng thức các món ăn truyền thống và xem múa hát dân gian.",
                    Price = 1800000,
                    Durations = 2,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("20000000-0000-0000-0000-000000000004"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    PackageName = "Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng",
                    Description = "Tham gia làm vườn, chăm sóc cây trồng không hóa chất, nghỉ dưỡng tại homestay chuẩn sinh thái ngay chân núi.",
                    Price = 2500000,
                    Durations = 2,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },

            #endregion
            #region Sa Pa Eco Farm Tour
                new TourismPackage
                {
                    PackageId = Guid.Parse("30000000-0000-0000-0000-000000000001"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    PackageName = "Một ngày làm nông dân H'Mông",
                    Description = "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.",
                    Price = 1450000,
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("30000000-0000-0000-0000-000000000002"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    PackageName = "Hành trình khám phá bản làng và nông nghiệp hữu cơ",
                    Description = "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.",
                    Price = 1650000,
                    Durations = 8,
                    DurationsType = TimeType.hour,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("30000000-0000-0000-0000-000000000003"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    PackageName = "Farmstay Sa Pa 2N1Đ",
                    Description = "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.",
                    Price = 2700000,
                    Durations = 2,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                },
                new TourismPackage
                {
                    PackageId = Guid.Parse("30000000-0000-0000-0000-000000000004"),
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    PackageName = "Chợ phiên & nông nghiệp vùng cao",
                    Description = "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.",
                    Price = 1100000,
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    StatusOperating = StatusOperating.Active
                }

                #endregion

            );


        }
    }
}
