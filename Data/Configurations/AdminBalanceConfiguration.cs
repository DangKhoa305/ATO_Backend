using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class AdminBalanceConfiguration : IEntityTypeConfiguration<AdminBalance>
    {
        public void Configure(EntityTypeBuilder<AdminBalance> builder)
        {
            builder.ToTable(nameof(AdminBalance));
            builder.HasKey(x => x.TransactionId);

            // Required fields
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.TransactionType).IsRequired();
            builder.Property(x => x.TransactionDate).IsRequired();

            // Optional fields
            builder.Property(x => x.OrderId).IsRequired(false);
            builder.Property(x => x.BookingId).IsRequired(false);

            // Relationships
            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Booking)
                .WithMany()
                .HasForeignKey(x => x.BookingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}