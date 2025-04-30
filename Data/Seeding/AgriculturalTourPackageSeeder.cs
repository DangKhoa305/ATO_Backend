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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media&token=892ef66c-cd8d-4228-b4ff-092b82961381",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media&token=374f97cb-ad21-4633-8381-8081019edabf",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media&token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f",

                    },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 2, 15, 8, 0, 0),
                    EndTime = new DateTime(2024, 2, 15, 17, 0, 0),
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
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media&token=47097c1c-c500-44d3-8737-78a0f2a8b1f2",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media&token=1e207dfe-0474-4f0f-ad34-37bcb330c20e",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media&token=546add09-5243-44b3-a1ff-0b7f8c799539",
                       "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media&token=7b90f572-93c1-4378-80da-7fe1421f7a06"

                },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 3, 1, 8, 30, 0),
                    EndTime = new DateTime(2024, 3, 1, 16, 30, 0),
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media&token=68b2ad20-405c-4353-8dae-e0b6a9a585ea",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media&token=bca7674f-dd8a-45ab-85e9-e0a9b9370734",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media&token=1190cb37-0960-4738-b183-3659addb4593",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media&token=6c678903-0762-44bb-9e34-69c9fbecc053",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media&token=aa93f1f6-7464-4016-b32a-dc298f3719a9"
                    },
                    Slot = 12,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 3, 15, 8, 0, 0),
                    EndTime = new DateTime(2024, 3, 15, 17, 0, 0),
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media&token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media&token=3ba71565-f467-437e-9b65-d71ccb1da6a8",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media&token=c02001f3-d8cb-4c16-a3f8-15d822dadf84",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media&token=2cf26d42-a673-4dde-a41c-6f1076363516"
                        },
                    Slot = 25,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 4, 1, 8, 0, 0),
                    EndTime = new DateTime(2024, 4, 1, 17, 30, 0),
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media&token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media&token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media&token=b0f66603-ed84-4706-8a10-261b21cb298c"
                        },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 4, 15, 7, 30, 0),
                    EndTime = new DateTime(2024, 4, 15, 16, 30, 0),
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media&token=b2256b37-3360-4459-afe0-7186726d21c5",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media&token=7a43cc3a-e217-41ac-a636-5a4ac970d968",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media&token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media&token=8da7861e-b793-4126-a1d4-e1541b94a286"
                        },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 5, 1, 8, 0, 0),
                    EndTime = new DateTime(2024, 5, 1, 16, 0, 0),
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media&token=5cee2720-206e-4229-b4b5-d87913de7cdd",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media&token=6389bd14-f169-4352-a396-9a29f68f0268",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media&token=f0089a61-9297-482e-8bb8-1846d6ce43b2"
                        },
                    Slot = 20,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 5, 10, 8, 0, 0),
                    EndTime = new DateTime(2024, 5, 10, 17, 30, 0),
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media&token=fab8ea01-086a-4484-b96f-572b425d36d6",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media&token=88be30a2-6b3b-4959-a55e-8feab75b12e4",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media&token=eda67947-d9fc-4646-a340-d95738ad6706"
                            },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 5, 15, 8, 0, 0),
                    EndTime = new DateTime(2024, 5, 15, 19, 0, 0),
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media&token=6cd1a961-73ee-484c-8566-9d8797539af4",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media&token=065f8c5c-45f2-4f48-bbc0-7da25c24c158",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media&token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media&token=fb34619f-9131-4144-add2-afca0ba19b9a"
                            },
                    Slot = 12,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 5, 20, 8, 0, 0),
                    EndTime = new DateTime(2024, 5, 20, 16, 0, 0),
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media&token=7291e759-0c21-44d3-b21c-2b62c04853e4",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media&token=898cb533-86cf-44dc-a119-5b5f96145d27",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media&token=398c95a8-aac6-4a5d-b9cb-628964a0294f",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media&token=0433021f-55ce-4d70-a332-44e6aab49f8e",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media&token=9d625a9d-06cc-4f71-8169-190168de597f",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media&token=bcab3f6a-f04f-4084-b72d-39de575881d1"
                        },
                    Slot = 15,
                    PriceOfAdults = RoundToNearestHundredThousand(random.Next(10000000, 20000000)),
                    PriceOfChildren = RoundToNearestHundredThousand(random.Next(10000000, 12000000)),
                    StartTime = new DateTime(2024, 5, 25, 8, 0, 0),
                    EndTime = new DateTime(2024, 5, 25, 17, 0, 0),
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
