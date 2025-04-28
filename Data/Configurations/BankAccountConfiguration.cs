using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable(nameof(BankAccount));
            builder.HasKey(x => x.BankAccountId);

            builder.Property(x => x.BankName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.AccountNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.AccountName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.BranchName).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.IsPrimary).IsRequired();
            builder.Property(x => x.OwnerType).IsRequired();
        }
    }
}