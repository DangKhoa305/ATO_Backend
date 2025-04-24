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
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable(nameof(Contract));
            builder.HasKey(x => x.ContractId);
            builder.Property(x => x.TourCompanyId).IsRequired(false);
            builder.Property(x => x.TouristFacilityId).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.TourCompany)
                      .WithMany(c => c.Contracts)
                      .HasForeignKey(x => x.TourCompanyId)
                      .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.TouristFacility)
                      .WithMany(c => c.Contracts)
                      .HasForeignKey(x => x.TouristFacilityId)
                      .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}