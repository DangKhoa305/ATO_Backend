using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class WithdrawalRequestConfiguration : IEntityTypeConfiguration<WithdrawalRequest>
    {
        public void Configure(EntityTypeBuilder<WithdrawalRequest> builder)
        {
            builder.ToTable(nameof(WithdrawalRequest));
            builder.HasKey(x => x.RequestId);

            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.BankName).IsRequired();
            builder.Property(x => x.AccountNumber).IsRequired();
            builder.Property(x => x.AccountName).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.RequestDate).IsRequired();
            builder.Property(x => x.ProcessedDate).IsRequired(false);
            builder.Property(x => x.Note).IsRequired(false);
            builder.Property(x => x.AdminResponse).IsRequired(false);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}