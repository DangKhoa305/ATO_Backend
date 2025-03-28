using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AccommodationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AccommodationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed Accommodation
            modelBuilder.Entity<Accommodation>().HasData(
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    AccommodationName = "Khách sạn Hoàng Gia",
                    AccommodationDescription = "Khách sạn 5 sao với dịch vụ cao cấp.",
                    Address = "Số 123, Đường Trần Phú, Hà Nội",
                    PhoneNumber = "0987654321",
                    Star = 5,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    AccommodationName = "Resort Biển Xanh",
                    AccommodationDescription = "Resort ven biển với view đẹp và hồ bơi lớn.",
                    Address = "Số 456, Đường Biển Đông, Đà Nẵng",
                    PhoneNumber = "0978543210",
                    Star = 4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    AccommodationName = "Nhà nghỉ Hoa Hồng",
                    AccommodationDescription = "Nhà nghỉ bình dân, giá rẻ, sạch sẽ.",
                    Address = "Số 789, Đường Nguyễn Trãi, TP Hồ Chí Minh",
                    PhoneNumber = "0967452103",
                    Star = 3,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    AccommodationName = "Khách sạn Thiên Đường",
                    AccommodationDescription = "Khách sạn có view toàn cảnh thành phố.",
                    Address = "Số 101, Đường Lê Lợi, Huế",
                    PhoneNumber = "0956328745",
                    Star = 4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    AccommodationName = "Villa Sông Hồng",
                    AccommodationDescription = "Villa yên tĩnh, phù hợp nghỉ dưỡng.",
                    Address = "Số 202, Đường Bờ Sông, Hải Phòng",
                    PhoneNumber = "0945216987",
                    Star = 5,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    AccommodationName = "Homestay Vườn Xanh",
                    AccommodationDescription = "Homestay thiên nhiên với vườn cây xanh mát.",
                    Address = "Số 303, Đường Lâm Đồng, Đà Lạt",
                    PhoneNumber = "0934125698",
                    Star = 3,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    AccommodationName = "Khách sạn Mặt Trời",
                    AccommodationDescription = "Khách sạn gần biển, có hồ bơi riêng.",
                    Address = "Số 404, Đường Võ Nguyên Giáp, Nha Trang",
                    PhoneNumber = "0923546987",
                    Star = 4,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    AccommodationName = "Nhà nghỉ An Bình",
                    AccommodationDescription = "Nhà nghỉ giá rẻ, gần trung tâm.",
                    Address = "Số 505, Đường Nguyễn Văn Cừ, Cần Thơ",
                    PhoneNumber = "0912564873",
                    Star = 2,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000009"),
                    AccommodationName = "Resort Thiên Nhiên",
                    AccommodationDescription = "Resort giữa thiên nhiên, hòa mình với cây cỏ.",
                    Address = "Số 606, Đường Xanh, Phú Quốc",
                    PhoneNumber = "0901254789",
                    Star = 5,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000010"),
                    AccommodationName = "Khách sạn Thành Đạt",
                    AccommodationDescription = "Khách sạn trung tâm, giá hợp lý.",
                    Address = "Số 707, Đường Lý Thường Kiệt, Quảng Ninh",
                    PhoneNumber = "0896541237",
                    Star = 3,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media&token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                }
            );
        }
    }
}
