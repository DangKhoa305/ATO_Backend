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
    public class AccommodationConfiguration : IEntityTypeConfiguration<Accommodation>
    {
        public void Configure(EntityTypeBuilder<Accommodation> builder)
        {
            builder.ToTable(nameof(Accommodation));
            builder.HasKey(x => x.AccommodationId);
            builder.Property(x => x.AccommodationName).IsRequired();
            builder.Property(x => x.AccommodationDescription).IsRequired(false);
            builder.Property(x => x.Imgs).IsRequired(false);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Star).IsRequired(false);
            builder.Property(x => x.TourCompanyId).IsRequired();
            #region config relation
            builder.HasOne(x => x.TourCompany)
                      .WithMany(c => c.Accommodations)
                      .HasForeignKey(x => x.TourCompanyId)
                      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}