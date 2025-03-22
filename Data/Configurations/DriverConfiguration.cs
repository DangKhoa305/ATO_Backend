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
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable(nameof(Driver));
            builder.HasKey(x => x.DriverId);
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.VehicleType).IsRequired();
            builder.Property(x => x.Imgs).IsRequired(false);
            builder.Property(x => x.TourCompanyId).IsRequired();
            #region config relation
            builder.HasOne(x => x.TourCompany)
                      .WithMany(c => c.Drivers)
                      .HasForeignKey(x => x.TourCompanyId)
                      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}