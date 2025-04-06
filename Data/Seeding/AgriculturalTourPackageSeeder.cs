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
        public void Seed()
        {
            modelBuilder.Entity<AgriculturalTourPackage>().HasData(
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("72985040-386D-43AC-833D-1C2CC36CBD17"),
                    PackageName = "Gói Khám Phá Hang Sửng Sốt",
                    Description = "Trải nghiệm tuyệt vời tại Hang Sửng Sốt - một trong những hang động đẹp nhất Hạ Long.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 20,
                    Price = 1200000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 2.5,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("2DF2222F-37BE-4780-9EBD-D4FCF4107E28"),
                    PackageName = "Gói Tắm Biển Bãi Cháy",
                    Description = "Tận hưởng kỳ nghỉ thú vị với hoạt động tắm biển tại Bãi Cháy, Quảng Ninh.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 30,
                    Price = 800000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 2,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("938425A8-1EF7-4B26-A01E-EFFE123015C7"),
                    PackageName = "Gói Tham Quan Bà Nà Hills",
                    Description = "Hành trình khám phá Bà Nà Hills, trải nghiệm cáp treo và tham quan Cầu Vàng.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 25,
                    Price = 1200000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 4,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("7D92159E-BD23-42E8-BA5D-94F02E8ABC7A"),
                    PackageName = "Khám Phá Hội An Về Đêm",
                    Description = "Trải nghiệm không gian lung linh của phố cổ Hội An về đêm với hàng trăm chiếc đèn lồng rực rỡ.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 30,
                    Price = 900000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 3,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("F0CFB5D7-BFA4-4D0C-BF72-C8D37F62C0A1"),
                    PackageName = "Chinh Phục Fansipan",
                    Description = "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ, tận hưởng khung cảnh tuyệt đẹp của Sapa.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 25,
                    Price = 1200000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 6,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("F12A6BBE-5187-4713-B9BC-1B5E1D4EBEB8"),
                    PackageName = "Trải nghiệm chợ nổi Cái Răng",
                    Description = "Khám phá nét văn hóa miền Tây sông nước với chợ nổi Cái Răng vào sáng sớm. Thưởng thức các món ăn đặc sản trên thuyền và giao lưu với người dân địa phương.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 20,
                    Price = 750000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 3,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("D83B9062-CA46-48E2-8DB9-A05D24436FF1"),
                    PackageName = "Trải nghiệm miền Tây sông nước",
                    Description = "Tham quan chợ nổi Cái Răng vào buổi sáng, khám phá vườn trái cây buổi chiều. Trải nghiệm cuộc sống dân dã miền Tây và thưởng thức trái cây tươi ngon.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 20,
                    Price = 950000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 8,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("D470CEFB-E618-420F-A399-31BBE277596E"),
                    PackageName = "Khám phá đại dương Phú Quốc",
                    Description = "Trải nghiệm lặn biển ngắm san hô tại Hòn Thơm, tận hưởng làn nước trong xanh và hệ sinh thái đa dạng dưới đáy biển.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 15,
                    Price = 950000,
                    StartTime = new DateTime(2025, 6, 10, 9, 0, 0),
                    EndTime = new DateTime(2025, 6, 10, 11, 30, 0),
                    Durations = 3.5,
                    DurationsType = TimeType.day,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.Parse("276CB0A3-4406-4943-8E7A-EE2B62E49E79"),
                    PackageName = "Khám phá đại dương & làng chài Phú Quốc",
                    Description = "Tham gia hành trình khám phá đại dương với hoạt động lặn ngắm san hô tại Hòn Thơm, kết hợp tham quan làng chài Rạch Vẹm - nơi nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.",
                    Imgs = new List<string>
                    {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74"
                    },
                    Slot = 20,
                    Price = 1500000,
                    StartTime = new DateTime(2024, 9, 15, 9, 0, 0),
                    EndTime = new DateTime(2024, 9, 16, 17, 30, 0),
                    Durations = 8,
                    DurationsType = TimeType.hour,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null,
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    StatusActive = StatusActive.active

                }


            );
        }
    }
}
