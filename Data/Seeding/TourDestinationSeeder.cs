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
                    TourDestinationId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    Title = "Lái xe",
                    Description = "Mô tả lái xe",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 6, 10, 9, 30, 0),
                    EndTime = new DateTime(2025, 6, 10, 10, 30, 0),
                    VisitOrder = 1,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("72985040-386D-43AC-833D-1C2CC36CBD17"),
                    DriverId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    Title = "Khách sạn",
                    Description = "Mô tả khách sạn.",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 6, 10, 9, 30, 0),
                    EndTime = new DateTime(2025, 6, 10, 10, 30, 0),
                    VisitOrder = 3,
                    TypeActivity = TypeActivity.Accommodation,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("72985040-386D-43AC-833D-1C2CC36CBD17"),
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    Title = "Cảng Tuần Châu",
                    Description = "Khởi hành từ bến cảng nổi tiếng của Hạ Long.",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 6, 10, 9, 30, 0),
                    EndTime = new DateTime(2025, 6, 10, 10, 30, 0),
                    VisitOrder = 1,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("72985040-386D-43AC-833D-1C2CC36CBD17"),
                    TourismPackageId = Guid.Parse("32BA5585-D88D-4C07-8C3A-5C3F846CD138"),
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                },
                new TourDestination
                {
                    TourDestinationId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    Title = "Cảng Tuần Châu",
                    Description = "Khởi hành từ bến cảng nổi tiếng của Hạ Long.",
                    CreateDate = DateTime.UtcNow,
                    StartTime = new DateTime(2025, 6, 10, 9, 30, 0),
                    EndTime = new DateTime(2025, 6, 10, 10, 30, 0),
                    VisitOrder = 2,
                    TypeActivity = TypeActivity.Destination,
                    StatusApproval = StatusApproval.Approved,
                    TourId = Guid.Parse("72985040-386D-43AC-833D-1C2CC36CBD17"),
                    TourismPackageId = Guid.Parse("32BA5585-D88D-4C07-8C3A-5C3F846CD138"),
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                }
            );
        }

    }
}
