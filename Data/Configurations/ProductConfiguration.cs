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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(b => b.ProductId);
            // requi
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ProductCategory).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.UnitProduct).IsRequired();
            //un requi
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);


            #region config relation
            builder.HasOne(x => x.TouristFacility)
               .WithMany(c => c.Products)
               .HasForeignKey(x => x.TouristFacilityId);
            #endregion
        }
    }
}