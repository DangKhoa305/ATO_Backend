using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class OCOPSellSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public OCOPSellSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        /*
         */
        public void Seed()
        {
            modelBuilder.Entity<OCOPSell>().HasData(
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                   ManufacturingDate = DateTime.Parse("2023-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 90000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 90000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                   ManufacturingDate = DateTime.Parse("2024-03-01"),
                   ExpiryDate = DateTime.Parse("2026-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                   ManufacturingDate = DateTime.Parse("2024-05-01"),
                   ExpiryDate = DateTime.Parse("2026-09-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               },
               new OCOPSell()
               {
                   OCOPSellId = Guid.NewGuid(),
                   SellVolume = 1000,
                   ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                   ManufacturingDate = DateTime.Parse("2025-03-01"),
                   ExpiryDate = DateTime.Parse("2027-03-01"),
                   CreateDate = DateTime.UtcNow,
                   SalePrice = 100000,
               }
           );
        }

    }
}
