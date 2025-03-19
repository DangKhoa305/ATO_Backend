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
    public class TourismPackageConfiguration : IEntityTypeConfiguration<TourismPackage>
    {
        public void Configure(EntityTypeBuilder<TourismPackage> builder)
        {
            builder.ToTable(nameof(TourismPackage));
            builder.HasKey(b => b.PackageId);

            // Required properties
            builder.Property(x => x.TouristFacilityId).IsRequired();
            builder.Property(x => x.PackageName).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Durations).IsRequired();
            builder.Property(x => x.StatusOperating).IsRequired();
            builder.Property(x => x.StatusApproval).IsRequired();

            // Optional properties
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.TourCompanyId).IsRequired(false);
            builder.Property(x => x.ReplyRequest).IsRequired(false);

            #region config relation

            builder.HasOne(x => x.TouristFacility)
                .WithMany(c => c.TourismPackages)
                .HasForeignKey(x => x.TouristFacilityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.TourCompany)
                .WithMany(c => c.TourismPackages)
                .HasForeignKey(x => x.TourCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }

}