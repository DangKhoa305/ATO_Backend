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
    public class TourGuideConfiguration : IEntityTypeConfiguration<TourGuide>
    {
        public void Configure(EntityTypeBuilder<TourGuide> builder)
        {
            builder.ToTable(nameof(TourGuide));
            builder.HasKey(b => b.GuideId);

            // Required properties
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.TourCompanyId).IsRequired();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();

            // Optional properties
            builder.Property(x => x.Bio).IsRequired(false);
            builder.Property(x => x.Languages).IsRequired(false);
            builder.Property(x => x.ExpertiseArea).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Account)
                .WithOne(c => c.TourGuide)
                .HasForeignKey<TourGuide>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TourCompany)
                .WithMany(c => c.TourGuides)
                .HasForeignKey(x => x.TourCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }

}