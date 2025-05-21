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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/516733727.jpg?alt=media&token=0b789349-cba9-4e9d-b988-5bce07d457c2" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/du-lich-phan-thiet-mui-ne-khong-gian-resort-song-bien-xanh.webp?alt=media&token=b6f4bca3-b5aa-4c86-bf5f-f58c358b1477" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images.jpg?alt=media&token=ee02614f-fc3b-4b11-a092-fd0be838362f" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(1).jpg?alt=media&token=38f10da2-3dc2-4bfc-bbc6-347729ca583a" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(2).jpg?alt=media&token=586806c2-bc7f-453d-8646-652d5edf6772" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/khach-san-mat-troi-nha-trang-top.jpg?alt=media&token=aa18f97e-2c52-4981-80b6-943366ee150c" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/nha-khach-an-binh.jpg?alt=media&token=ffed214a-b404-4354-a61d-05c1201a6eff" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/1490857443-chen%20sea%20phu%20quoc65_resort%20phu%20quoc.jpg?alt=media&token=78b1604e-3dff-40a7-8136-336f1d731838" },
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
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/278c80de4ccef04ea12ccfd4a3e15aad.jpg?alt=media&token=54dd0bf7-514f-4daf-b40c-bb861476d91b" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                },
                new Accommodation
                {
                    AccommodationId = Guid.Parse("10000000-0000-0000-0000-000000000011"),
                    AccommodationName = "Khách sạn TherHouse",
                    AccommodationDescription = "Khách sạn trung tâm, giá hợp lý.",
                    Address = "38 Phan Đình Giót, TT. Mộc Châu, Mộc Châu, Sơn La",
                    PhoneNumber = "0966 124 194",
                    Star = 5,
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/e7ba17f6_z.webp?alt=media&token=dbb8ffe7-bf92-4fcd-88ff-51757c0d86f8" },
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74")
                }
            );
        }
    }
}