﻿using Data.Models;
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
                new Activity
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ActivityName = "Khám phá Hang Sửng Sốt",
                    Description = "Hành trình khám phá hang động kỳ vĩ nhất Hạ Long.",
                    DurationInHours = 2.5,
                    Location = "Vịnh Hạ Long",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 15,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("32BA5585-D88D-4C07-8C3A-5C3F846CD138"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ActivityName = "Tắm biển tại Bãi Cháy",
                    Description = "Thư giãn và tận hưởng không khí trong lành tại bãi biển nổi tiếng.",
                    DurationInHours = 2,
                    Location = "Bãi Cháy, Quảng Ninh",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 10,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("7874FC31-CDAE-4CF7-9AEE-B802ED19ED58"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ActivityName = "Tham quan Bà Nà Hills",
                    Description = "Trải nghiệm cáp treo, thăm Cầu Vàng và nhiều địa điểm thú vị.",
                    DurationInHours = 4,
                    Location = "Đà Nẵng",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 20,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = "Cần bổ sung thêm hướng dẫn viên.",
                    PackageId = Guid.Parse("7E5D0A21-9F4B-4C2A-AC11-AAAE96FCEC31"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ActivityName = "Dạo phố cổ Hội An về đêm",
                    Description = "Khám phá phố cổ Hội An với hàng trăm chiếc đèn lồng lung linh.",
                    DurationInHours = 3,
                    Location = "Hội An, Quảng Nam",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 15,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("7E5D0A21-9F4B-4C2A-AC11-AAAE96FCEC31"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ActivityName = "Leo núi Fansipan",
                    Description = "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ.",
                    DurationInHours = 6,
                    Location = "Sapa, Lào Cai",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 30,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = "",
                    PackageId = Guid.Parse("7E5D0A21-9F4B-4C2A-AC11-AAAE96FCEC31"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ActivityName = "Khám phá chợ nổi Cái Răng",
                    Description = "Trải nghiệm chợ nổi Cái Răng vào buổi sáng, thưởng thức các món ăn đặc sản trên thuyền.",
                    DurationInHours = 3,
                    Location = "Cần Thơ",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 15,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("A649B3B4-10A2-4225-A229-BE4D66F29552"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ActivityName = "Tham quan vườn trái cây",
                    Description = "Tận hưởng không gian xanh mát, thưởng thức trái cây tươi ngay tại vườn.",
                    DurationInHours = 2,
                    Location = "Vĩnh Long",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 10,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("A649B3B4-10A2-4225-A229-BE4D66F29552"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ActivityName = "Lặn ngắm san hô tại Hòn Thơm",
                    Description = "Lặn biển ngắm san hô, tận hưởng làn nước trong xanh của Phú Quốc.",
                    DurationInHours = 3.5,
                    Location = "Hòn Thơm, Phú Quốc",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 20,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Processing,
                    ReplyRequest = "Cần xác nhận thời tiết.",
                    PackageId = Guid.Parse("321C5B3A-D096-4406-BD11-FBFBD4436FC5"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                },
                new Activity
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ActivityName = "Khám phá làng chài Rạch Vẹm",
                    Description = "Tham quan làng chài nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.",
                    DurationInHours = 2.5,
                    Location = "Rạch Vẹm, Phú Quốc",
                    Imgs = new List<string> { "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media&token=9219bd24-5a76-43cb-b70c-4cabf30d8c74" },
                    BreakTimeInMinutes = 15,
                    CreateDate = DateTime.UtcNow,
                    StatusApproval = StatusApproval.Approved,
                    ReplyRequest = null,
                    PackageId = Guid.Parse("321C5B3A-D096-4406-BD11-FBFBD4436FC5"),
                    BreakTimeInMinutesType = TimeType.hour,
                    DurationInHoursType = TimeType.minute
                }
            );

        }
    }
}
