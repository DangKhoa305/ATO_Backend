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
    internal class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.ToTable(nameof(Feedback));
            builder.HasKey(b => b.FeedbackId);
            // requi
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.CreateTime).IsRequired();
            //un requi
            builder.Property(x => x.ProductId).IsRequired(false);
            builder.Property(x => x.TourId).IsRequired(false);
            builder.Property(x => x.UpdateTime).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Product)
               .WithMany(c => c.Feedbacks)
               .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.AgriculturalTourPackage)
              .WithMany(c => c.Feedbacks)
              .HasForeignKey(x => x.TourId);
            builder.HasOne(x => x.Account)
              .WithMany(c => c.Feedbacks)
              .HasForeignKey(x => x.UserId);
            #endregion
        }
    }
}