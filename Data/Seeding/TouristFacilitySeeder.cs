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
                    LogoURL ="",
                    EmailTouristFacility = " dulichmocchaumoc@gmail.com"
                }
            );
        }
    }
}
