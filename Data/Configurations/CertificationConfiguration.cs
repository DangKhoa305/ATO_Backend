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
    public class CertificationConfiguration : IEntityTypeConfiguration<Certification>
    {
        public void Configure(EntityTypeBuilder<Certification> builder)
        {
            builder.ToTable(nameof(Certification));
            builder.HasKey(b => b.CertificationId);
            // requi
            builder.Property(x => x.CertificationName).IsRequired();
            builder.Property(x => x.IssuingOrganization).IsRequired();
            builder.Property(x => x.IssueDate).IsRequired();
            builder.Property(x => x.ExpiryDate).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.StatusApproval).IsRequired();
            //un requi
            builder.Property(x => x.CertificationDetails).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.ReplyRequest).IsRequired(false);
            builder.Property(x => x.TouristFacilityId).IsRequired(false);
            builder.Property(x => x.ProductId).IsRequired(false);
            builder.Property(x => x.Imgs).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.TouristFacility)
               .WithMany(c => c.Certifications)
               .HasForeignKey(x => x.TouristFacilityId);
            builder.HasOne(x => x.Product)
              .WithMany(c => c.Certifications)
              .HasForeignKey(x => x.ProductId);
            #endregion
        }
    }
}