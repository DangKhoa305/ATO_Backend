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
    public class TourDestinationConfiguration : IEntityTypeConfiguration<TourDestination>
    {
        public void Configure(EntityTypeBuilder<TourDestination> builder)
        {
            builder.ToTable(nameof(TourDestination));
            builder.HasKey(x => x.TourDestinationId);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.CheckInDate).IsRequired(false);
            builder.Property(x => x.CheckOutDate).IsRequired(false);
            builder.Property(x => x.VisitOrder).IsRequired();
            builder.Property(x => x.TypeActivity).IsRequired();
            builder.Property(x => x.StatusApproval).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.ReplyRequest).IsRequired(false);
            builder.Property(x => x.TourId).IsRequired();
            builder.Property(x => x.TourismPackageId).IsRequired();
            builder.Property(x => x.DriverId).IsRequired();
            builder.Property(x => x.AccommodationId).IsRequired();
            builder.Property(x => x.ActivityId).IsRequired();
            #region config relation
            builder.HasOne(x => x.AgriculturalTourPackage)
                      .WithMany(c => c.TourDestinations)
                      .HasForeignKey(x => x.TourId)
                      .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.TourismPackage)
                      .WithMany(c => c.TourDestinations)
                      .HasForeignKey(x => x.TourismPackageId)
                      .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Driver)
                      .WithMany(c => c.TourDestinations)
                      .HasForeignKey(x => x.DriverId)
                      .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Accommodation)
                      .WithMany(c => c.TourDestinations)
                      .HasForeignKey(x => x.AccommodationId)
                      .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Activity)
                      .WithMany(c => c.TourDestinations)
                      .HasForeignKey(x => x.ActivityId)
                      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}