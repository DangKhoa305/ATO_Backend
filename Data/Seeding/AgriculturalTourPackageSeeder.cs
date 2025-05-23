using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AgriculturalTourPackageSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AgriculturalTourPackageSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        int RoundToNearestHundredThousand(int value) => (int)Math.Round(value / 100000.0) * 100000;

        public void Seed()
        {
            var random = new Random();

            modelBuilder.Entity<AgriculturalTourPackage>().HasData(
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4"),
                    PackageName = "Khám Phá Nông Nghiệp Mộc Châu",
                    Description = "Hành trình trải nghiệm nông nghiệp độc đáo tại Mộc Châu, từ tham quan nông trại dâu tây, vắt sữa bò đến thu hoạch rau hữu cơ. Du khách sẽ được trực tiếp tham gia vào các hoạt động nông nghiệp và thưởng thức đặc sản địa phương.",
                    Imgs = new List<string>
                    {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media&token=0e6e621f-912a-4639-a51a-e94e183b95e8",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa2.jpeg?alt=media&token=8159822e-9515-4532-9531-10c21c397218",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa3.webp?alt=media&token=d7b91ee8-ad6c-4ffa-a979-bcf01709d2c1",

                    },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 2, 15, 8, 0, 0),
                    EndTime = new DateTime(2025, 2, 15, 17, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C"),
                    PackageName = "Tour Hái Chè và Thưởng Trà OCOP",
                    Description = "Trải nghiệm văn hóa trà truyền thống tại Mộc Châu, từ tham quan đồi chè, học cách hái và chế biến chè, đến thưởng thức các loại trà OCOP đặc sản.",
                    Imgs = new List<string>
                    {
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb1.jpg?alt=media&token=0baec450-2c25-49fe-b319-360b3f146c89",
                       "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb2.jpg?alt=media&token=c93ad47c-b5fd-4864-ac53-6bf579f2e5ef"

                },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 3, 1, 8, 30, 0),
                    EndTime = new DateTime(2025, 3, 1, 16, 30, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22"),
                    PackageName = "Một Ngày Làm Nông Dân OCOP",
                    Description = "Trải nghiệm một ngày làm việc thực tế tại nông trại OCOP, từ chăm sóc vườn rau đến thu hoạch và đóng gói sản phẩm theo tiêu chuẩn.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc1.jpg?alt=media&token=e320026b-8c15-4ca0-9570-1c7f641c3b44",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc2.webp?alt=media&token=52f3e890-c777-421b-ba33-640a7c6b21b4",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc4.jpg?alt=media&token=73e89a47-6420-43cd-8bd9-6cc18e3771c5"
                    },
                    Slot = 12,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 3, 15, 8, 0, 0),
                    EndTime = new DateTime(2025, 3, 15, 17, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD"),
                    PackageName = "Du Lịch Thiện Nguyện & Nông Nghiệp Xanh",
                    Description = "Kết hợp du lịch với hoạt động thiện nguyện và bảo vệ môi trường, từ trồng cây xanh đến tham gia các hoạt động cộng đồng tại bản làng.",
                    Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd1.jpg?alt=media&token=de1ecc18-0ac0-424c-93e9-5fb18a05cbc4",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd2.jpg?alt=media&token=1bb550da-3a3b-4742-b23c-4075a45c7c0b",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd3.png?alt=media&token=067466e8-32b9-427a-a2c6-739358f95017"

                        },
                    Slot = 25,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 4, 1, 8, 0, 0),
                    EndTime = new DateTime(2025, 4, 1, 17, 30, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("20000000-0000-0000-0000-000000000001"),
                    PackageName = "Một Ngày Làm Nông Dân Vùng Biên",
                    Description = "Trải nghiệm cuộc sống nông dân tại vùng biên giới, từ gieo trồng, chăm sóc gia súc đến thu hoạch nông sản cùng người dân địa phương.",
                    Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe1.jpg?alt=media&token=f05fa6e1-5083-45d9-a750-7ee06162c520",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe2.jpg?alt=media&token=53afdfbf-5507-47ee-85d1-ec8442304f7e"
                        },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 4, 15, 7, 30, 0),
                    EndTime = new DateTime(2025, 4, 15, 16, 30, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("20000000-0000-0000-0000-000000000002"),
                    PackageName = "Trải Nghiệm Thu Hoạch Mùa Vụ",
                    Description = "Tham gia vào hoạt động thu hoạch mùa vụ cùng người dân địa phương, từ thu hoạch đến sơ chế và thưởng thức sản phẩm tươi ngon tại chỗ.",
                    Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff1.jpg?alt=media&token=37caad37-477d-4e55-873f-2440551d954a",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff2.webp?alt=media&token=a23fd593-3c32-4b72-9ab8-c74e86fa3368"
                        },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 5, 1, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 1, 16, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("20000000-0000-0000-0000-000000000003"),
                    PackageName = "Khám Phá Nông Nghiệp và Văn Hóa Địa Phương",
                    Description = "Hành trình khám phá nét văn hóa độc đáo và hoạt động nông nghiệp truyền thống của đồng bào dân tộc Tày - Nùng, từ trải nghiệm trồng trọt đến thưởng thức ẩm thực và nghệ thuật dân gian.",
                    Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg1.jpg?alt=media&token=40bc8d8a-10a4-4a6b-a852-bd1ab79ae219",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg2.jpg?alt=media&token=7d24a17f-5853-4bea-9aa3-488b283393ee"
                        },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 5, 10, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 17, 30, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("20000000-0000-0000-0000-000000000004"),
                    PackageName = "Du Lịch Canh Tác Hữu Cơ Kết Hợp Nghỉ Dưỡng",
                    Description = "Trải nghiệm độc đáo kết hợp giữa học tập phương pháp canh tác hữu cơ và nghỉ dưỡng tại homestay sinh thái. Du khách được tham gia vào quy trình trồng trọt sạch và tận hưởng không gian yên bình của thiên nhiên.",
                    Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh1.jpg?alt=media&token=835dc28e-4ea6-4e76-83e4-36591a577988",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh2.png?alt=media&token=162ac610-9f4f-4b8e-b8b7-c16c83f500e1"
                            },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 5, 15, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 15, 19, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("30000000-0000-0000-0000-000000000001"),
                    PackageName = "Một Ngày Làm Nông Dân H'Mông",
                    Description = "Trải nghiệm độc đáo về văn hóa nông nghiệp truyền thống của người H'Mông tại Cát Cát, từ canh tác trên ruộng bậc thang đến thu hái thuốc nam và nấu ăn truyền thống.",
                    Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi1.webp?alt=media&token=d6f2d4c0-4439-4e9e-afd8-ef36d378a6c4",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi2.jpg?alt=media&token=76d6c2e9-fe9d-4f4a-abed-55e622effe0a"
                            },
                    Slot = 12,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 5, 20, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 20, 16, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("30000000-0000-0000-0000-000000000002"),
                    PackageName = "Hành Trình Khám Phá Bản Làng và Nông Nghiệp Hữu Cơ",
                    Description = "Khám phá đời sống văn hóa độc đáo của người H'Mông tại bản Cát Cát, tìm hiểu về nông nghiệp hữu cơ và trải nghiệm làm nghề thủ công truyền thống.",
                    Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk1.jpg?alt=media&token=8a1b82a5-d372-49c8-9437-ba1d221ebe90",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk2.jpg?alt=media&token=1c08d579-60fe-4071-89fd-b58683ee5388"
                        },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2025, 5, 25, 8, 0, 0),
                    EndTime = new DateTime(2025, 5, 25, 17, 0, 0),
                    Durations = 1,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active,
                    ChildTicketAge = "3 tuổi"
                }
            );
        }
    }
}
