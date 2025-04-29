using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class FacilityCertificationConfiguration : IEntityTypeConfiguration<FacilityCertification>
    {
        public void Configure(EntityTypeBuilder<FacilityCertification> builder)
        {
            builder.ToTable(nameof(FacilityCertification));
            builder.HasKey(x => x.CertificationId);

            // Required fields
            builder.Property(x => x.CertificationName).IsRequired();
            builder.Property(x => x.IssueDate).IsRequired();
            builder.Property(x => x.ExpiryDate).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.StatusApproval).IsRequired();

            // Optional fields
            builder.Property(x => x.Imgs).IsRequired(false);
            builder.Property(x => x.CertificationDetails).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.ReplyRequest).IsRequired(false);

            // Relationships
            builder.HasOne(x => x.TouristFacility)
                .WithMany()
                .HasForeignKey(x => x.TouristFacilityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}