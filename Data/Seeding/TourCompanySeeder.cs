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
    public class TourCompanySeeder
    {
        /*

         */
        private readonly ModelBuilder modelBuilder;

        public TourCompanySeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed Tour Company
            modelBuilder.Entity<TourCompany>().HasData(
                new TourCompany()
                {
                    TourCompanyId = Guid.Parse("E33545B1-C97E-412F-B844-17B15CD28B74"),
                    UserId = Guid.Parse("053D18EF-BA0E-4141-B142-898D28FA9B5D"),
                    AddressCompany = "03 Hai Bà Trưng, Phường Phan Chu Trinh, Quận Hoàn Kiếm, Hà Nội.",
                    CompanynName = "Công ty Cổ phần Vietravel",
                    CompanyDescription ="",
                    EmailCompany = "vtv.cholon@vietravel.com",
                    Website = "https://travel.com.vn/",
                    LogoURL = "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", 
                    CreateDate = new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253)
                }
            );
        }
    }
}
