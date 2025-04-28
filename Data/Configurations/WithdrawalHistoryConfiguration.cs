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

            #region config relation
            builder.HasOne(x => x.TourCompany)
                      .WithMany(c => c.WithdrawalHistories)
                      .HasForeignKey(x => x.TourCompanyId)
                      .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.TouristFacility)
                      .WithMany(c => c.WithdrawalHistories)
                      .HasForeignKey(x => x.TouristFacilityId)
                      .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}