using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdoi-che-trai-tim-moc-chau-68-1.jpg?alt=media&token=c217f596-e09e-4d34-b21b-84d11eaaa103",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F-8824-1745223484_860x0.jpg?alt=media&token=fb1bda90-6cdd-4217-a7b0-4a4d37a31bbb",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthac-cat-cat-tho-mong3.jpg?alt=media&token=29507071-2069-4ca3-b3b3-1665e293a282",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvuon-nho-thai-an-2-1-1024x614.webp?alt=media&token=e7af45e4-d132-45e8-aca3-07787d22528b",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthai-nguyen-17435107247911118713237.jpg?alt=media&token=c3f1ab76-1e22-4e54-a2b8-f9085b18d47c",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F20220314-161611-QzoiJN59.webp?alt=media&token=a5eb0314-334f-4769-bde3-b06e2d609274",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ftam-gia-c-ma-ch-ha-giang-vnexpress-3-1571666979.webp?alt=media&token=70e2dc65-1f50-4a28-a48f-62b42ddcc235",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2FHHKD2333-900x600.jpg?alt=media&token=169fa448-c537-46dd-895c-381865ffb514",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmaxresdefault.jpg?alt=media&token=21b101b4-89c4-42cb-bb2b-65b0cd229be6",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F18fcefcc98cb5d9504da.jpg?alt=media&token=f8859fe5-b77e-476e-bfea-25c22cadf72a",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4273865435811_cb279364c608be7f093bda58a64acfd3-nongnghiep-170638.jpg?alt=media&token=952a2a5d-0d1f-44d9-8332-cc4659752bd8",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F835b7b66.jpg?alt=media&token=259978a6-a141-40d8-b3a0-42b7d5a67947",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F4-1708062548800.webp?alt=media&token=dcbe2825-b390-49fa-b21b-14f53ee19f5b",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11%20(42).jpg?alt=media&token=9dfb8626-bc21-4d09-a374-a91ec8e3b319",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F23.12.-DL-Sinh-thai-My-Hoa-Hung-1-1024x576%20(1).jpg?alt=media&token=d1487100-cca6-4bbd-880f-b7824a266507",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-miet-vuon-7_1631758474.jpg?alt=media&token=c8ad0b62-50d1-4625-81f6-c418467da795",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fimg_1732330219066_o_1idbeqphmbm29dj1ubq1jl81474d.jpg?alt=media&token=f96b59da-0276-4805-b58f-bcbbdb37bad0",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdua-luoi-7-061822_327-062713.jpg?alt=media&token=3cbc44a6-67a9-49dd-b28f-5403391b186b",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvung(1).jpg?alt=media&token=39115e9e-dec1-4982-9638-899d54f7a488",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmuc-so-thi-vuon-rau-huu-co-tho-canh-va-thuy-canh-1833_20230315_542-154329.jpeg?alt=media&token=ce7b46e6-7256-4a0f-8706-dc77675f512d",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-nong-nghiep-3.jpg?alt=media&token=de31295c-a66b-445d-8182-9055639cc598",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fbase64-1723456186444345111180.webp?alt=media&token=7e8bd8c2-28e4-43b2-aece-09355b55bd61",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fkhu-vuon-trong-nong-san-sach-0-1641207763997.webp?alt=media&token=33a5a74c-8d0b-4bfb-b0dd-1f9dc9e3607b",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ft3a_20240425210851.jpg?alt=media&token=b77127b1-30b3-45c5-b547-c8324de43606",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11-1611829270-mo-hinh-trong-dau-tay-da-lat-3.jpg?alt=media&token=d4626806-3666-4331-a7df-53cd52eb18c2",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media&token=8397bb0a-f130-4be6-abbe-aeceac5bc8e1",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fhanoimoi.com.vn-uploads-images-tuandiep-2020-03-02-_ba-dang-thi-cuoi-xa-dan-phuong-.jpg?alt=media&token=5d50e486-d791-4dcb-bfb2-87b9d7af8011",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F0603.phuyen2.jpg?alt=media&token=b90710db-3fee-47d4-ba7a-a4054ff6d83f",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4462200782496_874af9e67ff41504f733f389a740cb34.jpg?alt=media&token=e9324dd1-f67a-4b97-932f-321ce44f952f",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F1609.tham_quan_nong_trai_ho_vang_-_mo_hinh_du_lich_sach2.jpg?alt=media&token=178d2881-82bc-43dd-a0cc-650703da54dd",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F114293275_161596928798230_7012125940469886738_o(1).jpg?alt=media&token=2106d196-7206-4cc3-9940-54cbb12d7e6c",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F631f711e5c833f7e0b2af244_vinhthuan7_high.jpg?alt=media&token=ddb786b7-89f7-4b53-871a-8c32d168dbd5",
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
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F2-phat-trien-du-lich-con-nhieu-kho-khan-FILEminimizer.jpg_636705230132460445.jpg?alt=media&token=75d4bffb-4bb2-4aa7-8a0f-179e003f45c9",
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
