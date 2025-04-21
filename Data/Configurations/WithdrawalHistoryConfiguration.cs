using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class WithdrawalHistoryConfiguration : IEntityTypeConfiguration<WithdrawalHistory>
    {
        public void Configure(EntityTypeBuilder<WithdrawalHistory> builder)
        {
            builder.ToTable(nameof(WithdrawalHistory));
            builder.HasKey(x => x.WithdrawalId);

            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.TransactionReference).IsRequired();
            builder.Property(x => x.ProcessedDate).IsRequired();
            builder.Property(x => x.Note).IsRequired(false);

            builder.HasOne(x => x.Request)
                .WithMany()
                .HasForeignKey(x => x.RequestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}