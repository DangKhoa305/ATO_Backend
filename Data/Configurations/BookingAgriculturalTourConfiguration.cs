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
    public class BookingAgriculturalTourConfiguration : IEntityTypeConfiguration<BookingAgriculturalTour>
    {
        public void Configure(EntityTypeBuilder<BookingAgriculturalTour> builder)
        {
            builder.ToTable(nameof(BookingAgriculturalTour));
            builder.HasKey(b => b.BookingId);
            // requi
            builder.Property(x => x.TourId).IsRequired();
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.NumberOfAdults).IsRequired();
            builder.Property(x => x.NumberOfChildren).IsRequired(false);
            builder.Property(x => x.TotalAmmount).IsRequired();
            builder.Property(x => x.PaymentStatus).IsRequired();
            builder.Property(x => x.StatusBooking).IsRequired();
            builder.Property(x => x.BookingDate).IsRequired();
            #region config relation
            builder.HasOne(x => x.Customer)
               .WithMany(c => c.BookingAgriculturalTours)
               .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.AgriculturalTourPackage)
              .WithMany(c => c.BookingAgriculturalTours)
              .HasForeignKey(x => x.TourId)
              .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}