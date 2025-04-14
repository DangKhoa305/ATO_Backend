using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media&token=892ef66c-cd8d-4228-b4ff-092b82961381",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media&token=374f97cb-ad21-4633-8381-8081019edabf",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media&token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F14.jpg?alt=media&token=19367ec0-3dd2-4349-abcf-fc17911ca4ec",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F15.jpg?alt=media&token=eebc5140-5778-4ab7-b128-7ec04c37f2b4",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F16.jpg?alt=media&token=7d281318-7494-4c09-b7bb-8bf61c965fc0"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F21.jpg?alt=media&token=5a725c29-f7ed-4f52-89e0-94e0f768b8e3",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F22.jpg?alt=media&token=244dc720-f725-42ed-bbf1-a28f3a59178d",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F23.jpg?alt=media&token=1a44b12f-8bc0-48d6-b1bb-15a2cb7d3b61",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F24.jpg?alt=media&token=ccea313e-1a38-438c-b47f-2603da9a003f",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F25.jpg?alt=media&token=7667d7c8-ec34-444a-bfd6-254fa545febb"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F31.jpg?alt=media&token=c76c7f97-077d-4e11-b851-4d14a5348e39",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F32.jpg?alt=media&token=1d3da6b4-2733-4281-bee0-e9a005d9e3bd",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F33.jpg?alt=media&token=510e194a-cf09-476d-891e-d30976dbcf74",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F34.jpg?alt=media&token=cd2d6297-a97d-4119-b924-66f84e686091",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F35.jpg?alt=media&token=5dab756d-23a9-4df1-97a2-ff3b2afedad5"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F41.jpg?alt=media&token=e217a4d7-e7f4-4b2a-98dd-0a7dd4dc2984",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F42.jpg?alt=media&token=149048cb-720f-478f-bcd1-422756adf1ac",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F43.jpg?alt=media&token=828ef767-521b-43a8-92c3-6611901f65e2",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F44.jpg?alt=media&token=f69dd952-5c11-4080-ba90-2dbc7be04fe0",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F45.jpg?alt=media&token=815c61a0-c821-4208-ad95-0915e193fd9f"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media&token=47097c1c-c500-44d3-8737-78a0f2a8b1f2",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media&token=1e207dfe-0474-4f0f-ad34-37bcb330c20e",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media&token=546add09-5243-44b3-a1ff-0b7f8c799539",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media&token=7b90f572-93c1-4378-80da-7fe1421f7a06"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F61.jpg?alt=media&token=63b5b728-ea1f-4511-a780-d3c095a200bf",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F62.jpg?alt=media&token=c7184c0e-1262-4c7c-8124-d830c6077824",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F63.jpg?alt=media&token=70feba58-f759-40fa-a09a-afc6013a2a4c"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F71.jpg?alt=media&token=8c694cc7-240c-4eac-a670-a458de5a8964",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F72.jpg?alt=media&token=9d082c03-94b1-4bc2-941d-3d80077481cf",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F73.jpg?alt=media&token=955ef861-00bc-479f-ae3f-083a78f72624"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F81.jpg?alt=media&token=6afd1b86-7467-4378-872e-35653af5b8b1",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F82.jpg?alt=media&token=70835076-bb28-4f0a-840d-8a417e6aed17",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F83.jpg?alt=media&token=68a06a61-f77e-44a6-80e7-5da69e44d21a"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media&token=68b2ad20-405c-4353-8dae-e0b6a9a585ea",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media&token=bca7674f-dd8a-45ab-85e9-e0a9b9370734",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media&token=1190cb37-0960-4738-b183-3659addb4593",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media&token=6c678903-0762-44bb-9e34-69c9fbecc053",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media&token=aa93f1f6-7464-4016-b32a-dc298f3719a9"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F102.jpg?alt=media&token=05c8e1fe-9719-4a40-ac8b-29240968deca",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F105.jpg?alt=media&token=6a6f785c-b2ff-4d18-a281-6b4fbdb24858",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F101.jpg?alt=media&token=543a6d27-d8c1-405e-8cc5-d514df96a517",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F103.jpg?alt=media&token=61052fcb-66f1-4b78-801c-7753c921eedd",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F104.jpg?alt=media&token=d6fa2240-475b-4342-b38f-4ab3ff860c6c",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F106.jpg?alt=media&token=04b992aa-add3-494d-afb6-163f295101dd"
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
                           "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F111.jpg?alt=media&token=720b5141-852a-42f7-9501-cd21845aea83",
                           "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F112.jpg?alt=media&token=071f3771-b293-4679-a2b8-9705b064e2ee"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F121.jpg?alt=media&token=9018f821-dd46-4bc6-aa56-0389aea2bf61",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F122.jpg?alt=media&token=ad974591-aff7-48af-80e6-a6e7e975941c",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F123.jpg?alt=media&token=7e9514a5-c205-468d-913e-49da8aa8b473"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media&token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media&token=3ba71565-f467-437e-9b65-d71ccb1da6a8",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media&token=c02001f3-d8cb-4c16-a3f8-15d822dadf84",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media&token=2cf26d42-a673-4dde-a41c-6f1076363516"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F141.jpg?alt=media&token=17bafc4a-ca33-416e-8b02-4d5ed8708569",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F142.jpg?alt=media&token=59c221c3-f2a5-4065-9282-37bf5874be3e",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F143.jpg?alt=media&token=6ad7d043-ae31-4bb0-a41c-d5f0f9b70e87",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F144.jpg?alt=media&token=4f03a1ff-ae27-476f-9a83-c69225dd0c3e",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F145.jpg?alt=media&token=0c56159a-0c55-49cc-afe2-86c8de27db2f"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F151.jpg?alt=media&token=637e2ba5-283d-406b-8604-e7a908ebab2d",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F152.jpg?alt=media&token=e6bd1f38-1a76-4d4d-ada9-25da7f51686f",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F153.jpg?alt=media&token=130839fb-7bbe-4186-bf90-ca1419a80582",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F154.jpg?alt=media&token=78e68037-8fcd-4fbc-a0d6-7ac9752e33bf"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F161.jpg?alt=media&token=2d7d29c8-3636-405f-9567-2a4aaae97c30",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F162.jpg?alt=media&token=9ad86d97-f35d-468b-8937-d1c4d461b0c3",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F163.jpg?alt=media&token=435f2187-da87-4cae-8b17-5f103f7b1f11",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F164.jpg?alt=media&token=1008643c-57d9-4b73-adee-a61dfa3a3a85",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F165.jpg?alt=media&token=be1854b6-921a-4b31-92b4-a8eb074729d0"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media&token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media&token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media&token=b0f66603-ed84-4706-8a10-261b21cb298c"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F191.jpg?alt=media&token=1ae42618-5c61-40f9-af64-b673a2e8b6cc",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F192.jpg?alt=media&token=ec22f901-1f9b-4d62-8a9b-2efdb9c7a95a",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F193.jpg?alt=media&token=ad98ddae-0d85-474d-a14e-a46cac5292da",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F194.jpg?alt=media&token=b33f2e48-75dd-4935-896a-e2bed0e81b8e",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F195.jpg?alt=media&token=68e9d11f-5627-4847-bee1-06d127911ba1"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F201.jpg?alt=media&token=c8aa9368-60b3-4754-8e68-183ec49665a3",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F202.jpg?alt=media&token=bdfa0975-acef-4887-b0bc-43140a5cb23b",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F203.jpg?alt=media&token=7c780014-a798-4891-ad34-a76992d7b532",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F204.jpg?alt=media&token=aceb4ca4-7664-4fe6-a325-aa77566c78ec",
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F211.jpg?alt=media&token=073d2ffd-c38c-42be-adcd-eeede14e7599",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F212.jpg?alt=media&token=823c928e-ca0d-4325-a4b7-b468d4186329",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F213.jpg?alt=media&token=61107119-364a-4a1e-acef-eb88ca4d893b",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F214.jpg?alt=media&token=9df5e91b-7227-4286-8829-349125c4d5c5",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F215.jpg?alt=media&token=a8fcab98-514f-43d2-b773-d98fee53fcd3"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media&token=b2256b37-3360-4459-afe0-7186726d21c5",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media&token=7a43cc3a-e217-41ac-a636-5a4ac970d968",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media&token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media&token=8da7861e-b793-4126-a1d4-e1541b94a286"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F231.jpg?alt=media&token=f97e225d-3650-420f-90a5-2de9e9e95cef",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F232.jpg?alt=media&token=ebbc29cf-f3db-4482-a703-40d22ef83721"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F241.jpg?alt=media&token=4463106d-794f-4fdf-a7d5-0d8480924e8c",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F242.jpg?alt=media&token=0007ab7b-3e71-433b-b91e-2ebeba70c162",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F243.jpg?alt=media&token=b0b690e9-bdf5-439c-8ef4-28c268db4620",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F244.jpg?alt=media&token=3604d3cf-9fc5-473d-af7b-c5589c0a97ea",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F245.jpg?alt=media&token=9eaef8dc-1185-42d7-9cfd-2224b1ccec20"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F251.jpg?alt=media&token=81823c6d-9776-43f3-9ebf-de22ca576eaa",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F252.jpg?alt=media&token=36bcc531-71a4-459d-965a-6622849ab584"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media&token=5cee2720-206e-4229-b4b5-d87913de7cdd",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media&token=6389bd14-f169-4352-a396-9a29f68f0268",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media&token=f0089a61-9297-482e-8bb8-1846d6ce43b2"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F271.jpg?alt=media&token=241821db-3226-4e34-a77e-e836f927b832",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F272.jpg?alt=media&token=3fd95b94-c080-48a1-a33c-26b124c01729",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F273.jpg?alt=media&token=9a6da2b9-6b90-4fb0-898e-d53d619661c4"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F281.jpg?alt=media&token=f04d5b05-7aaf-416d-97e6-2c822003f677",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F282.jpg?alt=media&token=305ac0e3-fd04-4970-a70d-47121c1bb920"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F291.jpg?alt=media&token=359dcbca-21d9-4154-a7d0-5551d716bda1",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F292.jpg?alt=media&token=8ed946de-f900-42a4-8680-1f3d874c5664",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F293.jpg?alt=media&token=cd51d4ba-d099-40ef-8f04-45c50b510f4d",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F294.jpg?alt=media&token=57db7ac9-c488-4f98-afef-4cd8fa0099be"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media&token=fab8ea01-086a-4484-b96f-572b425d36d6",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media&token=88be30a2-6b3b-4959-a55e-8feab75b12e4",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media&token=eda67947-d9fc-4646-a340-d95738ad6706"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F311.jpg?alt=media&token=c5d2e774-2892-4050-8e03-6da8b54ad1b5",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F312.jpg?alt=media&token=2f38325a-17d8-463c-8cf7-6ac1a59d0df2",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F314.jpg?alt=media&token=5b8079cb-fc25-46d1-90d8-919b1d17d017",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F315.jpg?alt=media&token=cad2491a-a26d-4c9d-a047-dec724e86aed"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F321.jpg?alt=media&token=cb1d9b94-1df8-43ff-9c40-2cb2db8e48c8",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F322.jpg?alt=media&token=9ec5a1d9-fe89-43a2-98f4-adf67c778461",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F323.jpg?alt=media&token=189aea12-33a9-4033-92c9-3aea8de5c297"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F331.jpg?alt=media&token=aeac9ff7-f16d-4843-9f8e-547cd5888511",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F332.jpg?alt=media&token=c6d546a9-22f0-47d0-b7f2-7b865d475026"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media&token=6cd1a961-73ee-484c-8566-9d8797539af4",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media&token=065f8c5c-45f2-4f48-bbc0-7da25c24c158",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media&token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media&token=fb34619f-9131-4144-add2-afca0ba19b9a"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F351.jpg?alt=media&token=7f979d6c-7fd1-41fa-95dc-5b916eaaccb6",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F352.jpg?alt=media&token=563f16cd-657a-47ae-bb8a-98a9e73c5e21",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F353.jpg?alt=media&token=f5b16d9a-5509-43cb-8390-a71fdb4ceded",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F354.jpg?alt=media&token=9b1add6f-51e5-4224-af5c-e50497f29c33"
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
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F361.jpg?alt=media&token=7bcb88d3-ed48-4d65-87ea-8e765f95eacd",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F362.jpg?alt=media&token=3ddd92d0-24eb-4731-8916-fc6ce6cf3fd1",
                            "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F363.jpg?alt=media&token=4fc8b20d-7bb7-4e4c-97f5-2f84c10bdeb9"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media&token=7291e759-0c21-44d3-b21c-2b62c04853e4",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media&token=898cb533-86cf-44dc-a119-5b5f96145d27",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media&token=398c95a8-aac6-4a5d-b9cb-628964a0294f",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media&token=0433021f-55ce-4d70-a332-44e6aab49f8e",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media&token=9d625a9d-06cc-4f71-8169-190168de597f",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media&token=bcab3f6a-f04f-4084-b72d-39de575881d1"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F381.jpg?alt=media&token=424e6c80-6192-44f3-9493-4e9e11e83d94",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F382.jpg?alt=media&token=8f8c59b9-c916-4120-b569-5219537de2aa",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F383.jpg?alt=media&token=d0758696-6d53-48de-b51d-51e2988571c8"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F391.jpg?alt=media&token=3c9ee67a-b22c-4203-b072-5858308ebd84",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F393.jpg?alt=media&token=a5be846e-f195-44fd-9d0e-02a5382cb5a9",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F392.jpg?alt=media&token=27c17e64-db04-4907-bfd5-0d6e6b1c233e"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F401.jpg?alt=media&token=d9d59523-c02a-4195-8e28-56e0b2e4eee7",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F402.jpg?alt=media&token=a48192a3-6c9e-4ecd-9eab-af6a15f5227b"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F411.jpg?alt=media&token=1a9c47f9-1b2d-4b92-91f3-28b285573140",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F412.jpg?alt=media&token=f4987f55-a4f6-42e7-a1dc-7958db0b8559"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F421.jpg?alt=media&token=6d6aee32-1e25-4324-99ad-4f707c3d63d5",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F422.jpg?alt=media&token=a81c9c91-10ec-4bf5-b6ad-d0f78222f6e6",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F423.jpg?alt=media&token=cc1d5656-20e0-44c0-ad9f-c35602eceaf3"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F431.jpg?alt=media&token=fedde1c2-82af-4101-96af-ac35b1247c05",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F432.jpg?alt=media&token=6b2b702f-d2f3-495e-bce4-b03768564e70",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F433.jpg?alt=media&token=76f636b3-f04a-4c67-a81c-e83203cf98b2"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F441.jpg?alt=media&token=37827a0f-e7c0-4b0a-9c91-dcc11d611846",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F442.jpg?alt=media&token=0168cdd6-bbd6-4d1a-9b7a-11fa787bc27a",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F443.jpg?alt=media&token=a7283cee-39ee-491b-810e-ee0683483411"
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
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F451.jpg?alt=media&token=2528b14d-5b04-46df-9276-1d8b759f8f00",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F452.jpg?alt=media&token=6461419d-900a-4753-aacf-ab7a487ce6a7",
                        "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F453.jpg?alt=media&token=cc68f5d2-853d-4efe-a640-301d5f9ef61e"
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
