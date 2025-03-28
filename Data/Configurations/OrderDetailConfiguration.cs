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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail));
            builder.HasKey(b => new { b.OrderId, b.ProductId });
            // requi
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired();

            #region config relation
            builder.HasOne(x => x.Order)
               .WithMany(c => c.OrderDetails)
               .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product)
               .WithMany(c => c.OrderDetails)
               .HasForeignKey(x => x.ProductId)
               .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}