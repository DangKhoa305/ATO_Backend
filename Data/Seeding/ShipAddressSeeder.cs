using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class ShipAddressSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public ShipAddressSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed Tour Company
            modelBuilder.Entity<ShipAddress>().HasData(
               new ShipAddress
               {
                   ShipAddressId = Guid.Parse("D4E1DD61-A5B3-4E6E-94D5-6CEFEA2C6B8F"),
                   DefaultAddress = true,
                   ToName = "Nguyễn Văn An",
                   ToAddress = "123 Lê Lợi, Phường Bến Nghé",
                   ToPhone = "0901234567",
                   ToWardCode = "20109",
                   ToDistrictId = 1442,
                   AccountId = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0")
               },
                new ShipAddress
                {
                    ShipAddressId = Guid.Parse("B2E1CC65-B21B-4E6E-94D5-6CEFEA2C6B8F"),
                    DefaultAddress = false,
                    ToName = "Trần Thị Bình",
                    ToAddress = "45 Nguyễn Huệ, Phường Bến Thành",
                    ToPhone = "0912345678",
                    ToWardCode = "20211",
                    ToDistrictId = 1443,
                    AccountId = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0")
                },
                new ShipAddress
                {
                    ShipAddressId = Guid.Parse("A3E2DD63-C5B3-4E6E-94D5-6CEFEA2C6B8F"),
                    DefaultAddress = true,
                    ToName = "Lê Hoàng Cường",
                    ToAddress = "789 Điện Biên Phủ, Phường Đa Kao",
                    ToPhone = "0923456789",
                    ToWardCode = "20314",
                    ToDistrictId = 1444,
                    AccountId = Guid.Parse("E025738E-4686-4282-ABC3-DAE9C65907F0")
                }
            );
        }
    }
}
