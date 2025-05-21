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
    public class AgriculturalTourPackageConfiguration : IEntityTypeConfiguration<AgriculturalTourPackage>
    {
        public void Configure(EntityTypeBuilder<AgriculturalTourPackage> builder)
        {
            builder.ToTable(nameof(AgriculturalTourPackage));
            builder.HasKey(b => b.TourId);
            // requi
            builder.Property(x => x.PackageName).IsRequired();
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Imgs).IsRequired(false);
            builder.Property(x => x.Slot).IsRequired();
            builder.Property(x => x.PriceOfAdults).IsRequired();
            builder.Property(x => x.PriceOfChildren).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.Durations).IsRequired();
            builder.Property(x => x.DurationsType).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.TourCompanyId).IsRequired();
            builder.Property(x => x.GatheringLocation);


            #region config relation
            builder.HasOne(x => x.TourCompany)
               .WithMany(c => c.AgriculturalTourPackages)
               .HasForeignKey(x => x.TourCompanyId);
            #endregion
        }
    }
}