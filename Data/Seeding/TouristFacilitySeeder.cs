using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TouristFacilitySeeder
    {
        /*
        // {D9E2DE12-D4BC-436A-9209-9F1DE3EF185C}
IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, 
0xd9e2de12, 0xd4bc, 0x436a, 0x92, 0x9, 0x9f, 0x1d, 0xe3, 0xef, 0x18, 0x5c);

         */
        private readonly ModelBuilder modelBuilder;

        public TouristFacilitySeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed Account
            modelBuilder.Entity<TouristFacility>().HasData(
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("D9E2DE12-D4BC-436A-9209-9F1DE3EF185C"),
                    UserId = Guid.Parse("A631BB94-66D8-44DB-932B-532892D87754"),
                    TouristFacilityName = "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC",
                    Address = "Số 117 đường Hoàng Quốc Việt – TTNT Mộc Châu ( Ngã tư Vườn Đào )",
                    Description = "Là công ty trẻ tại Mộc Châu, tiên phong cung cấp những dịch vụ du lịch gắn liền với thiên nhiên, văn hóa các dân tộc Mộc Châu, Vân Hồ.\r\nHiện đang khai thác những tour du lịch khám phá nông nghiệp Mộc Châu, khám phá văn hóa đời sống các dân tộc và các chương trình du lịch thiện nguyện, cắm trại, teambuilding, thể thao, MICE…",
                    ContactInfor = "0946 166 538",
                    CreateDate = new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253),
                    Website = "www.mocchaumoc.com",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F1.png?alt=media&token=f86dba4c-f25c-4c65-adc9-c2e662b1deb5",
                    EmailTouristFacility = "dulichmocchaumoc@gmail.com",
                    phone = "0987654321",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    TouristFacilityName = "Du Lịch Sinh Thái Thác Bản Giốc",
                    Address = "Xã Đàm Thủy, Huyện Trùng Khánh, Cao Bằng",
                    Description = "Khu du lịch sinh thái kết hợp nông nghiệp tại vùng biên giới Thác Bản Giốc.",
                    ContactInfor = "0206 388 8888",
                    CreateDate = DateTime.Now,
                    Website = "www.bangiocfarmtour.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F2.webp?alt=media&token=401b4f70-d92e-4656-805d-f50712f67043",
                    EmailTouristFacility = "contact@bangiocfarmtour.vn",
                    phone = "0988888999",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    TouristFacilityName = "Sa Pa Eco Farm Tour",
                    Address = "Thôn Cát Cát, Xã San Sả Hồ, Sa Pa",
                    Description = "Tour trải nghiệm nông nghiệp và văn hóa H'Mông tại bản Cát Cát.",
                    ContactInfor = "0214 666 7777",
                    CreateDate = DateTime.Now,
                    Website = "www.sapaecotour.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F3.jpg?alt=media&token=396747b2-3c0a-4e37-9d13-7f07dea2890f",
                    EmailTouristFacility = "eco@sapa.vn",
                    phone = "0911777555",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    TouristFacilityName = "Farm Du Lịch Grape Valley",
                    Address = "Thôn Thái An, Xã Vĩnh Hải, Huyện Ninh Hải",
                    Description = "Trải nghiệm hái nho, làm rượu vang và nghỉ dưỡng tại thung lũng nho.",
                    ContactInfor = "0259 333 4567",
                    CreateDate = DateTime.Now,
                    Website = "www.grapevalley.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F4.jpg?alt=media&token=25f62207-6552-4052-aca8-608b93335980",
                    EmailTouristFacility = "info@grapevalley.vn",
                    phone = "0909000011",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    TouristFacilityName = "Nông Trại Chè Trải Nghiệm Đại Từ",
                    Address = "Xóm Cầu Tre, Xã La Bằng, Huyện Đại Từ",
                    Description = "Du lịch nông nghiệp kết hợp trải nghiệm hái chè, sao chè và thưởng thức tại chỗ.",
                    ContactInfor = "0208 123 4567",
                    CreateDate = DateTime.Now,
                    Website = "www.daitu-teafarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F5.jpg?alt=media&token=799ba94b-35db-4332-bd15-f16d52411fa1",
                    EmailTouristFacility = "farm@daitu.vn",
                    phone = "0977000111",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    TouristFacilityName = "Buôn Đôn Coffee Farm Tour",
                    Address = "Xã Ea M’nang, Huyện Cư M’gar, Đắk Lắk",
                    Description = "Tour trải nghiệm vườn cà phê, tham quan quy trình rang xay và cưỡi voi Buôn Đôn.",
                    ContactInfor = "0262 888 8899",
                    CreateDate = DateTime.Now,
                    Website = "www.buondoncoffee.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F6.jpg?alt=media&token=f81fee5d-3e8e-4aa8-a25b-0526c1daab9d",
                    EmailTouristFacility = "visit@buondoncoffee.vn",
                    phone = "0918888777",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    TouristFacilityName = "Hà Giang Farmstay & Trek",
                    Address = "Xã Sà Phìn, Huyện Đồng Văn",
                    Description = "Trải nghiệm cuộc sống vùng cao, làm nông, làm bánh truyền thống và trekking đèo đá.",
                    ContactInfor = "0219 366 6888",
                    CreateDate = DateTime.Now,
                    Website = "www.hagiangfarmstay.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F7.jpg?alt=media&token=3a5d4f25-f909-4d81-a4b3-0a7d3a945c26",
                    EmailTouristFacility = "trek@hagiang.vn",
                    phone = "0988999111",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    TouristFacilityName = "Trà My Sâm Ngọc Linh Tour",
                    Address = "Xã Trà Linh, Huyện Nam Trà My",
                    Description = "Khám phá vườn sâm Ngọc Linh, trải nghiệm trồng sâm, thưởng thức dược liệu.",
                    ContactInfor = "0235 322 3222",
                    CreateDate = DateTime.Now,
                    Website = "www.tramyfarmtour.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F8.jpg?alt=media&token=8d9dca9e-1aaf-43f6-bd36-d8d512972744",
                    EmailTouristFacility = "info@tramyfarm.vn",
                    phone = "0966555777",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    TouristFacilityName = "Đà Lạt Organic Farm Tour",
                    Address = "Phường 7, Thành phố Đà Lạt",
                    Description = "Du lịch trải nghiệm trồng dâu, làm rau thủy canh, check-in nông trại xanh.",
                    ContactInfor = "0263 355 8888",
                    CreateDate = DateTime.Now,
                    Website = "www.dalatorganic.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F9.jpg?alt=media&token=eb13f3b8-e307-4907-865b-27b5f25c34ab",
                    EmailTouristFacility = "info@dalatorganic.vn",
                    phone = "0933222111",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000009"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000009"),
                    TouristFacilityName = "Farmstay Nho & Thanh Long Bắc Bình",
                    Address = "Xã Phan Thanh, Huyện Bắc Bình",
                    Description = "Trải nghiệm hái nho, tham quan vườn thanh long sạch và picnic giữa đồng nắng gió Bình Thuận.",
                    ContactInfor = "0252 355 9000",
                    CreateDate = DateTime.Now,
                    Website = "www.binhthuanfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F10.jpg?alt=media&token=0113dd93-8a2e-478d-9ac1-e165995e1936",
                    EmailTouristFacility = "hello@binhthuanfarm.vn",
                    phone = "0933444555",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000010"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000010"),
                    TouristFacilityName = "Ba Bể Lake Ecofarm Tour",
                    Address = "Xã Nam Mẫu, Huyện Ba Bể",
                    Description = "Trải nghiệm chèo thuyền, nông nghiệp sinh thái, ở nhà sàn truyền thống người Tày.",
                    ContactInfor = "0209 366 2333",
                    CreateDate = DateTime.Now,
                    Website = "www.babeecotour.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F11.jpg?alt=media&token=81df566c-b4ed-4591-acc0-f17238f14f21",
                    EmailTouristFacility = "contact@babeecotour.vn",
                    phone = "0966001122",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000011"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000011"),
                    TouristFacilityName = "Trang Trại Nông Sản Sạch Tân Châu",
                    Address = "Xã Tân Hưng, Huyện Tân Châu",
                    Description = "Khám phá quy trình trồng rau hữu cơ, nuôi bò sữa, làm sữa chua và trồng nấm sạch.",
                    ContactInfor = "0276 366 7788",
                    CreateDate = DateTime.Now,
                    Website = "www.tayninhfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F12.jpg?alt=media&token=0393caa4-5c9e-4bde-bf5b-b68712ec4469",
                    EmailTouristFacility = "info@tayninhfarm.vn",
                    phone = "0944111222",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000012"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000012"),
                    TouristFacilityName = "Trải nghiệm Nông trại Biển & Rau Tuy An",
                    Address = "Xã An Chấn, Huyện Tuy An",
                    Description = "Trải nghiệm canh tác rau ven biển, tắm biển, đốt lửa trại và học làm nước mắm truyền thống.",
                    ContactInfor = "0257 388 8888",
                    CreateDate = DateTime.Now,
                    Website = "www.phuyentour.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F13.jpg?alt=media&token=9c9796b8-e39a-48d1-8863-0fc7142ae7b4",
                    EmailTouristFacility = "tour@phuyentour.vn",
                    phone = "0977222333",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000013"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000013"),
                    TouristFacilityName = "Trang Trại Nông Sản Sạch Càng Long",
                    Address = "Xã Mỹ Long Bắc, Huyện Càng Long",
                    Description = "Khám phá quy trình sản xuất mắm, trồng cây ăn trái và sản phẩm nông sản sạch.",
                    ContactInfor = "0294 355 1122",
                    CreateDate = DateTime.Now,
                    Website = "www.travinhfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F14.jpg?alt=media&token=843e14d6-3851-4315-bc98-6260f35d3d4e",
                    EmailTouristFacility = "contact@travinhfarm.vn",
                    phone = "0908222333",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000014"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000014"),
                    TouristFacilityName = "Mỹ Xuyên Farmstay",
                    Address = "Xã Mỹ Xuyên, Huyện Mỹ Xuyên",
                    Description = "Trải nghiệm mô hình nông nghiệp hữu cơ, tham quan các cánh đồng lúa, vườn cây ăn trái.",
                    ContactInfor = "0299 555 2333",
                    CreateDate = DateTime.Now,
                    Website = "www.soctrangfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F15.jpg?alt=media&token=7342e675-73c3-43d0-97cc-684082c6ee44",
                    EmailTouristFacility = "tour@soctrangfarm.vn",
                    phone = "0933112233",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000015"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000015"),
                    TouristFacilityName = "Trang Trại Châu Đốc",
                    Address = "Xã Vĩnh Tế, Huyện Châu Đốc",
                    Description = "Trải nghiệm canh tác nông nghiệp tại đồng bưng, tham quan vườn trái cây đặc sản miền Tây.",
                    ContactInfor = "0296 388 1133",
                    CreateDate = DateTime.Now,
                    Website = "www.angiangfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F16.jpg?alt=media&token=9e2b8638-1acb-4191-9a20-b41aabf0e29f",
                    EmailTouristFacility = "contact@angiangfarm.vn",
                    phone = "0977445566",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000016"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000016"),
                    TouristFacilityName = "Cần Thơ Farmstay",
                    Address = "Xã Nhơn Ái, Huyện Phong Điền",
                    Description = "Trải nghiệm mô hình trồng cây trái, tham quan các vườn rau hữu cơ và chợ nổi Cần Thơ.",
                    ContactInfor = "0292 388 1222",
                    CreateDate = DateTime.Now,
                    Website = "www.canthoexplore.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F17.jpg?alt=media&token=69beecb6-461f-4481-899f-3674b48c06f4",
                    EmailTouristFacility = "info@canthoexplore.vn",
                    phone = "0939332111",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000017"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000017"),
                    TouristFacilityName = "Phú Quốc Nông Trại Sản Xuất Hữu Cơ",
                    Address = "Xã Cửa Dương, Huyện Phú Quốc",
                    Description = "Tham quan mô hình nông nghiệp hữu cơ, vườn dưa lưới, vườn trái cây nhiệt đới.",
                    ContactInfor = "0297 223 4455",
                    CreateDate = DateTime.Now,
                    Website = "www.phuquocfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F18.jpg?alt=media&token=3e95d7ab-1114-421e-bb7b-defe761897e8",
                    EmailTouristFacility = "tour@phuquocfarm.vn",
                    phone = "0909888777",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000018"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000018"),
                    TouristFacilityName = "Trại Nông Sản Hạ Long",
                    Address = "Xã Đồng Mai, TP. Hạ Long",
                    Description = "Trải nghiệm mô hình trồng rau hữu cơ và nuôi trồng thủy sản, tham quan khu vườn cây ăn trái đặc sản.",
                    ContactInfor = "0203 356 7890",
                    CreateDate = DateTime.Now,
                    Website = "www.halongfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F19.jpg?alt=media&token=e8f5ef36-21fa-426b-a36b-9f9c9e709591",
                    EmailTouristFacility = "info@halongfarm.vn",
                    phone = "0912345678",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000019"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000019"),
                    TouristFacilityName = "Trang Trại Nông Sản An Lão",
                    Address = "Xã An Thắng, Huyện An Lão",
                    Description = "Khám phá mô hình trồng trọt và chăn nuôi, học hỏi cách trồng rau sạch và gia cầm.",
                    ContactInfor = "0225 350 1000",
                    CreateDate = DateTime.Now,
                    Website = "www.anlaofarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F20.jpg?alt=media&token=c8f94cf0-425e-45b1-9745-f0ed7c51a609",
                    EmailTouristFacility = "contact@anlaofarm.vn",
                    phone = "0932556789",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000020"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000020"),
                    TouristFacilityName = "Nông Trại Đại Từ",
                    Address = "Xã Phú Lạc, Huyện Đại Từ",
                    Description = "Trải nghiệm các hoạt động nông nghiệp như trồng lúa, chăm sóc vườn rau và tham gia các hoạt động nông dân.",
                    ContactInfor = "0208 382 5000",
                    CreateDate = DateTime.Now,
                    Website = "www.daitufarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F21.jpg?alt=media&token=0402e7c8-075d-4cb0-bbea-98efe121ede8",
                    EmailTouristFacility = "tour@daitufarm.vn",
                    phone = "0988776655",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000021"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000021"),
                    TouristFacilityName = "Trại Nông Sản Vinh",
                    Address = "Xã Nghi Phú, TP. Vinh",
                    Description = "Khám phá các vườn cây ăn trái, trồng rau hữu cơ và tìm hiểu về sản phẩm nông sản của vùng đất xứ Nghệ.",
                    ContactInfor = "0238 379 1111",
                    CreateDate = DateTime.Now,
                    Website = "www.vinhfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F22.jpg?alt=media&token=eb04cf86-f0c9-4301-977b-89e9cbd7d75e",
                    EmailTouristFacility = "contact@vinhfarm.vn",
                    phone = "0912233445",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000022"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000022"),
                    TouristFacilityName = "Trang Trại Nông Sản Triệu Sơn",
                    Address = "Xã Sơn Lâm, Huyện Triệu Sơn",
                    Description = "Tham gia vào các hoạt động nông nghiệp như thu hoạch rau, chăm sóc cây ăn trái, tham quan vườn thuốc nam.",
                    ContactInfor = "0237 375 6789",
                    CreateDate = DateTime.Now,
                    Website = "www.trieusonfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F23.jpg?alt=media&token=3855d2e9-4a16-4c6f-b5db-da2623520b5d",
                    EmailTouristFacility = "contact@trieusonfarm.vn",
                    phone = "0988112233",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000023"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000023"),
                    TouristFacilityName = "Trại Nông Sản Hà Tĩnh",
                    Address = "Xã Thạch Hưng, TP. Hà Tĩnh",
                    Description = "Khám phá nông sản hữu cơ, tham gia các hoạt động làm vườn và trồng cây ăn quả.",
                    ContactInfor = "0239 354 5678",
                    CreateDate = DateTime.Now,
                    Website = "www.hatinhfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F24.jpg?alt=media&token=c759c7e9-f707-4c22-afdd-13809209e5cf",
                    EmailTouristFacility = "contact@hatinhfarm.vn",
                    phone = "0916889900",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000024"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000024"),
                    TouristFacilityName = "Trang Trại Đồng Hới",
                    Address = "Xã Quảng Phú, TP. Đồng Hới",
                    Description = "Trải nghiệm nông nghiệp sinh thái với các mô hình trồng cây, chăm sóc động vật và tham quan các khu vườn.",
                    ContactInfor = "0232 382 7890",
                    CreateDate = DateTime.Now,
                    Website = "www.donghoifarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F25.jpg?alt=media&token=fbb74270-5fe0-4a44-ba94-4b9a0ebd9a61",
                    EmailTouristFacility = "contact@donghoifarm.vn",
                    phone = "0977223344",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000025"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000025"),
                    TouristFacilityName = "Trang Trại Nông Sản Đông Hà",
                    Address = "Xã Hải Lệ, TP. Đông Hà",
                    Description = "Khám phá các mô hình trồng cây dược liệu và rau hữu cơ, tham gia các hoạt động chăm sóc động vật.",
                    ContactInfor = "0233 350 5678",
                    CreateDate = DateTime.Now,
                    Website = "www.donghafarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F26.jpg?alt=media&token=1e91565d-c6ba-43f2-b73f-35c6710abcc5",
                    EmailTouristFacility = "contact@donghafarm.vn",
                    phone = "0912345678",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000026"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000026"),
                    TouristFacilityName = "Trại Nông Sản Quy Nhơn",
                    Address = "Xã Phước Sơn, TP. Quy Nhơn",
                    Description = "Tham gia vào các hoạt động trồng rau hữu cơ và chăm sóc vườn trái cây, tìm hiểu sản phẩm nông sản đặc trưng của Bình Định.",
                    ContactInfor = "0256 382 7890",
                    CreateDate = DateTime.Now,
                    Website = "www.quynhonfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F27.jpg?alt=media&token=a7f4dd9e-46f1-450e-850b-0733e35be659",
                    EmailTouristFacility = "contact@quynhonfarm.vn",
                    phone = "0988776655",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000027"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000027"),
                    TouristFacilityName = "Trang Trại Nông Sản Tuy Hòa",
                    Address = "Xã Hòa Thịnh, TP. Tuy Hòa",
                    Description = "Trải nghiệm các hoạt động trồng trọt, chăm sóc vườn cây ăn quả, tìm hiểu về các sản phẩm nông sản đặc biệt của Phú Yên.",
                    ContactInfor = "0257 355 6789",
                    CreateDate = DateTime.Now,
                    Website = "www.tuyhoafarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F28.jpg?alt=media&token=7c964137-2b0f-4ed8-aea7-7393bd154599",
                    EmailTouristFacility = "contact@tuyhoafarm.vn",
                    phone = "0972345678",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000028"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000028"),
                    TouristFacilityName = "Trại Nông Sản Nha Trang",
                    Address = "Xã Vĩnh Thạnh, TP. Nha Trang",
                    Description = "Khám phá các mô hình trồng cây ăn quả, rau hữu cơ, và các hoạt động du lịch nông nghiệp kết hợp nghỉ dưỡng.",
                    ContactInfor = "0258 382 9000",
                    CreateDate = DateTime.Now,
                    Website = "www.nhatrangfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F29.jpg?alt=media&token=80ea2316-f380-48f7-bc74-7919f6d2e718",
                    EmailTouristFacility = "contact@nhatrangfarm.vn",
                    phone = "0916345678",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000029"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000029"),
                    TouristFacilityName = "Trại Nông Sản Phan Rang",
                    Address = "Xã Phước Hải, TP. Phan Rang-Tháp Chàm",
                    Description = "Trải nghiệm du lịch nông nghiệp, tham quan các vườn cây ăn quả, mô hình trồng nho và sản xuất nông sản.",
                    ContactInfor = "0259 382 1111",
                    CreateDate = DateTime.Now,
                    Website = "www.phanrangfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F30.jpg?alt=media&token=5c8bf85f-5ac6-4d67-bde7-20cdbe7ac7f7",
                    EmailTouristFacility = "contact@phanrangfarm.vn",
                    phone = "0934567890",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000030"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000030"),
                    TouristFacilityName = "Trang Trại Nông Sản Phan Thiết",
                    Address = "Xã Phú Hài, TP. Phan Thiết",
                    Description = "Trải nghiệm các mô hình trồng cây nông sản và khám phá các sản phẩm đặc trưng của Bình Thuận như thanh long, dừa.",
                    ContactInfor = "0252 382 5678",
                    CreateDate = DateTime.Now,
                    Website = "www.phanthietfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F31.jpg?alt=media&token=44480008-26be-4bef-96f2-4ebf5375dc35",
                    EmailTouristFacility = "contact@phanthietfarm.vn",
                    phone = "0982334455",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000031"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000031"),
                    TouristFacilityName = "Trại Nông Sản Tân An",
                    Address = "Xã An Thạnh, TP. Tân An",
                    Description = "Khám phá các mô hình trồng cây, chăm sóc cây ăn trái, và tìm hiểu về sản phẩm nông sản của Long An.",
                    ContactInfor = "0272 384 5000",
                    CreateDate = DateTime.Now,
                    Website = "www.tananfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F32.jpg?alt=media&token=bc7d9acf-b383-4306-b69c-e9bf9d52f0a5",
                    EmailTouristFacility = "contact@tananfarm.vn",
                    phone = "0932456789",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                },
                new TouristFacility()
                {
                    TouristFacilityId = Guid.Parse("10000000-0000-0000-0000-000000000032"),
                    UserId = Guid.Parse("10000000-0000-0000-0000-000000000032"),
                    TouristFacilityName = "Trại Nông Sản Vĩnh Long",
                    Address = "Xã Phước Hòa, TP. Vĩnh Long",
                    Description = "Trải nghiệm du lịch nông nghiệp tại vườn cây ăn trái, học hỏi kỹ thuật trồng rau sạch và các hoạt động sinh thái.",
                    ContactInfor = "0270 382 8888",
                    CreateDate = DateTime.Now,
                    Website = "www.vinhlongfarm.vn",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F33.jpg?alt=media&token=65103687-a722-4ba0-84f9-0b6eff272d30",
                    EmailTouristFacility = "contact@vinhlongfarm.vn",
                    phone = "0913445566",
                    ward_code = "91295",
                    ward_name = "Phường 14",
                    district_id = 1976,
                    district_name = "Huyện Mộc Châu",
                    province_name = "Sơn La"
                }


            );
        }
    }
}
