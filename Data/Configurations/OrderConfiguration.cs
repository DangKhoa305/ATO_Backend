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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));
            builder.HasKey(b => b.OrderId);
            // requi
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.StatusOrder).IsRequired();
            builder.Property(x => x.PaymentType).IsRequired();
            builder.Property(x => x.OrderType).IsRequired();
            builder.Property(x => x.PaymentStatus).IsRequired();
            builder.Property(x => x.TotalAmount).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.CancelDate).IsRequired(false);
            builder.Property(x => x.BookingId).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Account)
               .WithMany(c => c.Orders)
               .HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.BookingAgriculturalTour)
              .WithMany(c => c.Orders)
              .HasForeignKey(x => x.BookingId);
            #endregion
        }
    }
}