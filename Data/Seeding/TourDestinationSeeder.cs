using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TourDestinationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public TourDestinationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<TourDestination>().HasData(
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000004"),
                    Title = "Di chuyển đến Mộc Châu",
                    Description = "Xe 45 chỗ đón khách tại điểm hẹn và di chuyển đến Mộc Châu",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 6, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 8, 0, 0),
                    VisitOrder = 1,
                    TypeActivity = TypeActivity.Drive,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4"),
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000005")
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000001"),
                    Title = "Tham quan nông trại dâu tây",
                    Description = "Tham quan và trải nghiệm tại nông trại dâu tây Bản Áng",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 8, 15, 0),
                    EndTime = new DateTime(2025, 5, 10, 9, 45, 0),
                    VisitOrder = 2,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000002"),
                    Title = "Trải nghiệm tại trang trại bò sữa",
                    Description = "Tham quan và trải nghiệm tại trang trại bò sữa Dairy Farm",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 10, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 11, 15, 0),
                    VisitOrder = 3,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000003"),
                    Title = "Khám phá vườn rau hữu cơ",
                    Description = "Tham quan và trải nghiệm tại trang trại rau hữu cơ Mộc Châu Xanh",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 11, 30, 0),
                    EndTime = new DateTime(2025, 5, 10, 12, 45, 0),
                    VisitOrder = 4,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000006"),
                    Title = "Nghỉ trưa tại khách sạn TherHouse",
                    Description = "Nghỉ ngơi và dùng bữa trưa tại khách sạn 5 sao TherHouse, trung tâm Mộc Châu",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 13, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 14, 30, 0),
                    VisitOrder = 5,
                    TypeActivity = TypeActivity.Accommodation,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4"),
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000011")
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("64000000-0000-0000-0000-000000000005"),
                    Title = "Di chuyển giữa các điểm tham quan",
                    Description = "Di chuyển giữa các điểm tham quan trong khu vực Mộc Châu",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 5, 10, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 14, 30, 0),
                    VisitOrder = 6,
                    TypeActivity = TypeActivity.Drive,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4"),
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000005")
                }
            );

        }

    }
}
