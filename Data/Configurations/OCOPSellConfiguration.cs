using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class OCOPSellConfiguration : IEntityTypeConfiguration<OCOPSell>
    {
        public void Configure(EntityTypeBuilder<OCOPSell> builder)
        {
            builder.ToTable(nameof(OCOPSell));
            builder.HasKey(b => b.OCOPSellId);
            // requi
            builder.Property(x => x.SellVolume).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.ExpiryDate).IsRequired(false);
            builder.Property(x => x.ManufacturingDate).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Product)
               .WithMany(c => c.OCOPSells)
               .HasForeignKey(x => x.ProductId);
            #endregion
        }
    }
}