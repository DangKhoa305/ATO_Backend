using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Data.Seeding
{
    public class ActivitySeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ActivitySeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Activity>().HasData(
                new List<Activity>
                {
                    #region Khám phá nông nghiệp Mộc Châu
                    new Activity
                    {
                        ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                        ActivityName = "Tham quan nông trại dâu tây",
                        Description = "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nông trại Dâu Mộc Châu – Bản Áng",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau%201.jpg?alt=media&token=37e256ac-3428-4dde-9923-a4ab34d79416",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau2.webp?alt=media&token=60ffaa7a-600a-41f6-9997-b01f487965a3"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("947AF66B-AF9B-4C98-888F-9CDBCC3DC84F"),
                        ActivityName = "Vắt sữa bò tại trang trại",
                        Description = "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Trang trại bò sữa Dairy Farm",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media&token=680679bc-ae88-495c-b39b-35205cdca5c1",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua2.jpg?alt=media&token=29672e8d-f9af-4be5-aa8c-9e7922fa3a9f"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("AD5FCE0F-1E34-4E92-8F71-DF6E99CB72C9"),
                        ActivityName = "Tham quan và thu hoạch rau hữu cơ",
                        Description = "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 5,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Trang trại rau hữu cơ Mộc Châu Xanh",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media&token=26a27576-3ee8-45e5-b4bd-0dfbac591c77",
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media&token=146de905-406d-4ef8-8ddd-8aa978e38123"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("F47A6C1C-9D25-41A2-93AF-E2C18F22BFA7"),
                        ActivityName = "Dùng bữa trưa đặc sản Mộc Châu",
                        Description = "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 0,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nhà hàng Truyền thống Bản Áng",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media&token=9500933b-9b09-4e07-a3b7-8d3899347fe7"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("64FAD407-A8BB-4B84-923F-65A9131D77E4")
                    },
                    #endregion
                    #region Tour hái chè và thưởng trà OCOP
                    new Activity
                    {
                        ActivityId = Guid.Parse("2A42085C-8A76-4C67-B01E-1C4AD0B5A733"),
                        ActivityName = "Tham quan đồi chè Mộc Châu",
                        Description = "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Đồi chè trái tim – Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media&token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("BE52B9C5-C471-4DC7-BD41-CC5A2F38CDB2"),
                        ActivityName = "Trải nghiệm hái chè",
                        Description = "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Đồi chè Thanh Bình – Mộc Châu",
                        Imgs = new List<string>
                        {
                           "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche2.webp?alt=media&token=0275c711-2581-48c0-9e13-bcc383b8cfe2"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("7DF7CB1A-90D7-4761-BD95-1AD4A2C1CF91"),
                        ActivityName = "Tham gia chế biến chè thủ công",
                        Description = "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 5,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Xưởng chè OCOP Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media&token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("DF4BC05F-450D-43FD-8A8E-87965CF3B6D4"),
                        ActivityName = "Thưởng thức trà OCOP",
                        Description = "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 0,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Không gian trà đạo Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media&token=d4fa66e3-818a-4641-a3d8-95f75b586fa5"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("B07F1613-0A7D-4BBF-8A2F-8F5F3A4E118C")
                    },
                    #endregion
                    #region Một ngày làm nông dân OCOP
                    new Activity
                    {
                        ActivityId = Guid.Parse("6D94E38B-3D50-4E47-9E1D-AB7D8883CC7F"),
                        ActivityName = "Chăm sóc vườn rau hữu cơ",
                        Description = "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn rau hữu cơ – Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media&token=d34657e1-2aae-4b60-a825-a7319b98235b"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("EF67F287-6846-4271-8F6F-CE6E0C8DC72A"),
                        ActivityName = "Thu hoạch cà chua",
                        Description = "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn cà chua – Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media&token=13165082-87a3-46d1-bc9c-8d08acebc905"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("E8C4BC1F-38CB-4642-B58F-6E5B31F93961"),
                        ActivityName = "Thu hoạch và chế biến nấm",
                        Description = "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Trang trại nấm – Mộc Châu",
                        Imgs = new List<string>
                        {
                           "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media&token=0c350e96-b627-4792-87e7-45d0502309e4",
                           "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam2.jpg?alt=media&token=04893537-abb2-4936-ba89-6e26b4b54aea"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("E075DFA8-0105-485B-A4F7-DC0551B11069"),
                        ActivityName = "Tìm hiểu quy trình đóng gói sản phẩm OCOP",
                        Description = "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 5,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Xưởng sản xuất nông sản OCOP Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhop1.jpg?alt=media&token=9dd3a3ac-52cb-4632-81aa-91a90dec35d0"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("9115F3C1-F621-464D-9C4A-71D67FE65A22")
                    },
                    #endregion
                    #region Du lịch thiện nguyện & nông nghiệp xanh
                     new Activity
                    {
                        ActivityId = Guid.Parse("2D71C1E3-FF2E-4F65-B7C6-2C2B02944C92"),
                        ActivityName = "Hoạt động từ thiện tại bản làng",
                        Description = "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.",
                        DurationInHours = 4,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 30,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Bản làng vùng cao Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media&token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("8E5F378D-2D33-4AC3-9B8B-265EC7F4D34A"),
                        ActivityName = "Trồng cây xanh tại khu vực du lịch",
                        Description = "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 20,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Khu du lịch Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftrongcay1.webp?alt=media&token=cbaae9c7-aa33-4943-a297-b1e3d2f95d58"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("1F22EC6D-442C-4632-8A6C-A1BBE87E6C2D"),
                        ActivityName = "Chăm sóc vườn hoa và cây cảnh",
                        Description = "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn hoa du lịch – Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media&token=d34657e1-2aae-4b60-a825-a7319b98235b"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("6A6A33F1-37E1-4C32-BED6-4D9C3FB6C99D"),
                        ActivityName = "Chế biến thực phẩm từ nông sản địa phương",
                        Description = "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 20,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Xưởng chế biến thực phẩm – Mộc Châu",
                        Imgs = new List<string>
                        {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media&token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("C2D2AD88-BF20-4AC9-9E2C-0B1B5FE502AD")
                    },
                    #endregion
                    #region Một ngày làm nông dân vùng biên
                     new Activity
                    {
                        ActivityId = Guid.Parse("A1110000-0000-0000-0000-000000000001"),
                        ActivityName = "Gieo trồng rau hữu cơ",
                        Description = "Hướng dẫn kỹ thuật gieo hạt, làm đất và chăm sóc rau theo phương pháp hữu cơ tại nông trại vùng cao.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nông trại hữu cơ – xã biên giới",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media&token=26a27576-3ee8-45e5-b4bd-0dfbac591c77"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000001")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A1110000-0000-0000-0000-000000000002"),
                        ActivityName = "Thu hoạch nông sản",
                        Description = "Trải nghiệm thu hoạch rau củ quả đúng vụ, phân loại và sơ chế tại chỗ theo hướng dẫn của người dân bản địa.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Ruộng nông sản – xã biên giới",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media&token=13165082-87a3-46d1-bc9c-8d08acebc905"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000001")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A1110000-0000-0000-0000-000000000003"),
                        ActivityName = "Chăm sóc trâu bò",
                        Description = "Học cách tắm rửa, cho ăn và dắt trâu ra đồng cùng người dân – trải nghiệm đời sống chăn nuôi thực tế.",
                        DurationInHours = 0.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Chuồng trại địa phương",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media&token=680679bc-ae88-495c-b39b-35205cdca5c1"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000001")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A1110000-0000-0000-0000-000000000004"),
                        ActivityName = "Dùng cơm trưa với người dân bản địa",
                        Description = "Thưởng thức bữa cơm dân dã tại nhà người dân với các món đặc sản vùng cao: măng xào, cá suối nướng, cơm lam...",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 0,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nhà sàn truyền thống",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media&token=9500933b-9b09-4e07-a3b7-8d3899347fe7"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000001")
                    },
                     #endregion               
                    #region Trải nghiệm thu hoạch mùa vụ
                    new Activity
                    {
                        ActivityId = Guid.Parse("A2220000-0000-0000-0000-000000000001"),
                        ActivityName = "Thu hoạch mùa vụ",
                        Description = "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa cùng với nông dân địa phương.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Cánh đồng hợp tác xã biên giới",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Flua.webp?alt=media&token=2c6a3258-acda-42d4-8a5a-9122a700047a"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000002")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A2220000-0000-0000-0000-000000000002"),
                        ActivityName = "Sơ chế và bảo quản thực phẩm",
                        Description = "Học cách phân loại, sơ chế và bảo quản thực phẩm thu hoạch được bằng phương pháp thủ công và tự nhiên.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nhà sơ chế tại trang trại",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media&token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000002")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A2220000-0000-0000-0000-000000000003"),
                        ActivityName = "Thưởng thức sản phẩm sạch tại chỗ",
                        Description = "Dùng thử các món ăn chế biến từ chính nông sản vừa thu hoạch như ngô luộc, khoai nướng, rau luộc chấm muối vừng.",
                        DurationInHours = 1,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 5,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Khu vực ăn uống ngoài trời",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media&token=d4fa66e3-818a-4641-a3d8-95f75b586fa5"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000002")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A2220000-0000-0000-0000-000000000004"),
                        ActivityName = "Giao lưu văn nghệ và chia sẻ",
                        Description = "Giao lưu với người dân bản địa, nghe chia sẻ về đời sống sản xuất nông nghiệp và văn hóa vùng cao.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 0,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Sân cộng đồng xã",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media&token=c9a1233d-7fd4-485b-92af-2d662e830cae"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000002")
                    },
                    #endregion       
                    #region Khám phá nông nghiệp và văn hóa địa phương
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3330000-0000-0000-0000-000000000001"),
                        ActivityName = "Trải nghiệm trồng trọt địa phương",
                        Description = "Tham gia các công việc nông nghiệp truyền thống như trồng rau, làm đất, tưới tiêu cùng người dân.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Cánh đồng bản Tày",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media&token=c9a1233d-7fd4-485b-92af-2d662e830cae",
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media&token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000003")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3330000-0000-0000-0000-000000000002"),
                        ActivityName = "Thưởng thức món ăn truyền thống",
                        Description = "Dùng bữa với các món ăn dân tộc như khẩu sli, thắng cố, lạp xưởng, và rượu ngô bản địa.",
                        DurationInHours = 1.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Nhà sàn truyền thống",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media&token=9500933b-9b09-4e07-a3b7-8d3899347fe7"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000003")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3330000-0000-0000-0000-000000000003"),
                        ActivityName = "Giao lưu văn hóa dân gian",
                        Description = "Tham gia đêm giao lưu văn nghệ với các tiết mục múa khèn, hát then, hát lượn đặc trưng dân tộc Tày - Nùng.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 5,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Sân nhà văn hóa bản",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdangian.jpg?alt=media&token=7df3d302-ee8c-454b-a2b6-36951632720a"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000003")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3330000-0000-0000-0000-000000000004"),
                        ActivityName = "Thăm quan làng nghề truyền thống",
                        Description = "Khám phá làng nghề làm hương, dệt thổ cẩm và thủ công mỹ nghệ bản địa.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Làng nghề Tày - Nùng",
                        Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdet.jpg?alt=media&token=648cbac8-add0-4056-a2a3-44d5241ed9ed"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("20000000-0000-0000-0000-000000000003")
                    },

                     #endregion
                    #region Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng
                        new Activity
                        {
                            ActivityId = Guid.Parse("A4440000-0000-0000-0000-000000000001"),
                            ActivityName = "Hướng dẫn canh tác hữu cơ",
                            Description = "Tham gia buổi giới thiệu quy trình trồng rau, hoa quả theo hướng hữu cơ không sử dụng thuốc trừ sâu hóa học.",
                            DurationInHours = 1.5,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 10,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Trang trại sinh thái hữu cơ",
                            Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media&token=d34657e1-2aae-4b60-a825-a7319b98235b"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("20000000-0000-0000-0000-000000000004")
                        },
                        new Activity
                        {
                            ActivityId = Guid.Parse("A4440000-0000-0000-0000-000000000002"),
                            ActivityName = "Trải nghiệm làm vườn hữu cơ",
                            Description = "Tự tay gieo hạt, chăm sóc rau và thu hoạch sản phẩm sạch theo hướng dẫn của người dân địa phương.",
                            DurationInHours = 2,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 15,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Vườn rau hữu cơ",
                            Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media&token=26a27576-3ee8-45e5-b4bd-0dfbac591c77"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("20000000-0000-0000-0000-000000000004")
                        },
                        new Activity
                        {
                            ActivityId = Guid.Parse("A4440000-0000-0000-0000-000000000003"),
                            ActivityName = "Nghỉ dưỡng tại homestay sinh thái",
                            Description = "Thư giãn tại homestay thân thiện với môi trường, sử dụng năng lượng tái tạo, có view rừng và núi.",
                            DurationInHours = 6,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 30,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Homestay chân núi Pù Luông",
                            Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media&token=e9eca292-9a58-49e7-851a-985a7c2fcc99"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("20000000-0000-0000-0000-000000000004")
                        },
                        new Activity
                        {
                            ActivityId = Guid.Parse("A4440000-0000-0000-0000-000000000004"),
                            ActivityName = "Chế biến món ăn từ nông sản hữu cơ",
                            Description = "Học nấu các món ăn truyền thống từ nguyên liệu hữu cơ tự tay thu hoạch.",
                            DurationInHours = 1.5,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 10,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Khu bếp homestay",
                            Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media&token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("20000000-0000-0000-0000-000000000004")
                        },
                        #endregion
                    #region Một ngày làm nông dân H'Mông
                         new Activity
                        {
                            ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000001"),
                            ActivityName = "Trồng rau trên ruộng bậc thang",
                            Description = "Trải nghiệm làm nông cùng người H'Mông: cuốc đất, gieo hạt và chăm sóc rau trên ruộng bậc thang.",
                            DurationInHours = 2,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 15,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Ruộng bậc thang bản Cát Cát",
                            Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fbacthang.webp?alt=media&token=1090ca2a-4ec4-4de7-99cf-316da2719b9d"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("30000000-0000-0000-0000-000000000001")
                        },
                        new Activity
                        {
                            ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000002"),
                            ActivityName = "Hái và phân loại thuốc nam",
                            Description = "Cùng người bản địa đi hái các loại cây thuốc nam đặc trưng vùng cao, học cách phân loại và sử dụng.",
                            DurationInHours = 1.5,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 10,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Khu rừng ven bản",
                             Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media&token=0c350e96-b627-4792-87e7-45d0502309e4"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("30000000-0000-0000-0000-000000000001")
                        },
                        new Activity
                        {
                            ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000003"),
                            ActivityName = "Nấu ăn cùng người H'Mông",
                            Description = "Tham gia chuẩn bị bữa trưa với các món ăn truyền thống của người H'Mông, sử dụng nguyên liệu địa phương.",
                            DurationInHours = 2,
                            DurationInHoursType = TimeType.hour,
                            BreakTimeInMinutes = 15,
                            BreakTimeInMinutesType = TimeType.minute,
                            Location = "Nhà truyền thống H'Mông, bản Cát Cát",
                             Imgs = new List<string> {
                            "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media&token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af"
                            },
                            CreateDate = DateTime.UtcNow,
                            StatusApproval = StatusApproval.Approved,
                            ReplyRequest = null,
                            PackageId = Guid.Parse("30000000-0000-0000-0000-000000000001")
                        },
                    #endregion
                    #region Hành trình khám phá bản làng và nông nghiệp hữu cơ
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000004"),
                        ActivityName = "Đi bộ khám phá bản Cát Cát",
                        Description = "Hành trình đi bộ qua các con đường lát đá, tìm hiểu kiến trúc nhà truyền thống và đời sống người H'Mông.",
                        DurationInHours = 2.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 20,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Bản Cát Cát",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdibo1.png?alt=media&token=85dab42a-d4de-4155-b10f-dcb86020ddbd"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000002")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000005"),
                        ActivityName = "Tham quan mô hình nông nghiệp hữu cơ",
                        Description = "Tìm hiểu quy trình trồng rau sạch, dược liệu không hóa chất và chăm sóc vườn theo tiêu chuẩn hữu cơ.",
                        DurationInHours = 2.5,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn hữu cơ bản Cát Cát",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvuon1.jpg?alt=media&token=bca13e04-6ddc-4abc-aeea-ceb3544c67c4"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000002")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000006"),
                        ActivityName = "Trải nghiệm làm giấy thủ công",
                        Description = "Tự tay chế tác giấy dó từ nguyên liệu tự nhiên, học cách in họa tiết dân tộc truyền thống.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 20,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Xưởng giấy thủ công trong bản",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fgiay1.webp?alt=media&token=8d97fe12-81fb-4baf-bca6-2310db5d10a6"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000002")
                    },
                    #endregion                     
                    #region Farmstay Sa Pa 2N1Đ
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000007"),
                        ActivityName = "Nghỉ dưỡng tại homestay Mường Hoa",
                        Description = "Thư giãn tại homestay trong thung lũng Mường Hoa với view ruộng bậc thang, tận hưởng không khí trong lành và yên tĩnh.",
                        DurationInHours = 6,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 30,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Homestay Mường Hoa",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media&token=e9eca292-9a58-49e7-851a-985a7c2fcc99"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000003")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000008"),
                        ActivityName = "Trải nghiệm thu hoạch và nấu ăn",
                        Description = "Tham gia thu hoạch rau củ tại vườn và cùng người bản địa nấu các món ăn truyền thống như thắng cố, lợn cắp nách, cá suối nướng.",
                        DurationInHours = 4,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn rau & gian bếp homestay",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media&token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000003")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000009"),
                        ActivityName = "Giao lưu văn nghệ bản địa",
                        Description = "Thưởng thức các tiết mục múa hát dân tộc, tham gia múa sạp, múa chuông và uống rượu ngô cùng người dân địa phương.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 10,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Sân sinh hoạt cộng đồng tại bản",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media&token=c9a1233d-7fd4-485b-92af-2d662e830cae"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000003")
                    },
                    #endregion
                    #region Chợ phiên & nông nghiệp vùng cao
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000010"),
                        ActivityName = "Tham quan chợ phiên Sa Pa",
                        Description = "Khám phá chợ phiên truyền thống với các gian hàng thổ cẩm, dược liệu, đặc sản vùng cao và giao lưu với người dân bản địa.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 30,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Chợ trung tâm Sa Pa",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcho-vung-cao.jpg?alt=media&token=fb63de66-558d-4ab7-8aae-829750571863"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000004")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000011"),
                        ActivityName = "Trải nghiệm gieo trồng và thu hoạch",
                        Description = "Tham gia gieo hạt, chăm sóc rau theo phương pháp truyền thống của người dân tộc thiểu số và tự tay thu hoạch nông sản.",
                        DurationInHours = 2,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Vườn rau bản Tả Phìn",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media&token=146de905-406d-4ef8-8ddd-8aa978e38123"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000004")
                    },
                    new Activity
                    {
                        ActivityId = Guid.Parse("A3000000-0000-0000-0000-000000000012"),
                        ActivityName = "Học nấu món ăn đặc sản vùng cao",
                        Description = "Hướng dẫn chế biến các món ăn đặc trưng của người H’Mông như thắng cố, cải mèo luộc chấm chẩm chéo và thịt trâu gác bếp.",
                        DurationInHours = 3,
                        DurationInHoursType = TimeType.hour,
                        BreakTimeInMinutes = 15,
                        BreakTimeInMinutesType = TimeType.minute,
                        Location = "Bếp cộng đồng trong bản",
                        Imgs = new List<string> {
                        "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media&token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af"
                        },
                        CreateDate = DateTime.UtcNow,
                        StatusApproval = StatusApproval.Approved,
                        ReplyRequest = null,
                        PackageId = Guid.Parse("30000000-0000-0000-0000-000000000004")
                    }
                    #endregion
                }


            );
            modelBuilder.Entity<Activity>()
            .HasMany(a => a.Products)
            .WithMany(a => a.Activities)
            .UsingEntity<Dictionary<string, object>>(
                "ActivityProduct",
                r => r.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
                l => l.HasOne<Activity>().WithMany().HasForeignKey("ActivityId"),
                je =>
                {
                    je.HasData(
                        new Dictionary<string, object>
                        {
                            ["ProductId"] = Guid.Parse("E5C3D8D2-6FC1-41F0-A2C9-28D3DDBBFA55"),
                            ["ActivityId"] = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546")
                        },
                         new Dictionary<string, object>
                         {
                             ["ProductId"] = Guid.Parse("23C7F3C2-5915-4F10-B937-6A34DA949A17"),
                             ["ActivityId"] = Guid.Parse("947AF66B-AF9B-4C98-888F-9CDBCC3DC84F")
                         },
                         new Dictionary<string, object>
                         {
                             ["ProductId"] = Guid.Parse("9A8BA610-2FB7-4B75-A482-328D76DC1D18"),
                             ["ActivityId"] = Guid.Parse("AD5FCE0F-1E34-4E92-8F71-DF6E99CB72C9")
                         },
                         new Dictionary<string, object>
                         {
                             ["ProductId"] = Guid.Parse("D56F8C35-68B1-4C42-95F5-D0E4A5D89988"),
                             ["ActivityId"] = Guid.Parse("F47A6C1C-9D25-41A2-93AF-E2C18F22BFA7")
                         },
                         new Dictionary<string, object>
                         {
                             ["ProductId"] = Guid.Parse("D56F8C35-68B1-4C42-95F5-D0E4A5D89988"),
                             ["ActivityId"] = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546")
                         },
                         new Dictionary<string, object>
                         {
                             ["ProductId"] = Guid.Parse("9A8BA610-2FB7-4B75-A482-328D76DC1D18"),
                             ["ActivityId"] = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546")
                         }
                         //new Dictionary<string, object>
                         //{
                         //    ["ProductId"] = Guid.Parse(""),
                         //    ["ActivityId"] = Guid.Parse("")
                         //},
                         //new Dictionary<string, object>
                         //{
                         //    ["ProductId"] = Guid.Parse(""),
                         //    ["ActivityId"] = Guid.Parse("")
                         //},
                         //new Dictionary<string, object>
                         //{
                         //    ["ProductId"] = Guid.Parse(""),
                         //    ["ActivityId"] = Guid.Parse("")
                         //}
                    );
                }
            );
        }
    }
}
