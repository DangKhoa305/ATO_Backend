using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BookingTourDestinationConfiguration : IEntityTypeConfiguration<BookingTourDestination>
    {
        public void Configure(EntityTypeBuilder<BookingTourDestination> builder)
        {
            builder.ToTable(nameof(BookingTourDestination));
            builder.HasKey(x => x.BookingDestinationId);

            // Required fields
            builder.Property(x => x.TourDestinationId).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            // Optional fields
            builder.Property(x => x.ActualStartTime).IsRequired(false);
            builder.Property(x => x.ActualEndTime).IsRequired(false);
            builder.Property(x => x.Notes).IsRequired(false);

            builder.HasOne(x => x.TourDestination)
               .WithMany()
               .HasForeignKey(x => x.TourDestinationId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}