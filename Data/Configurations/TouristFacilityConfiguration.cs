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
    public class TouristFacilityConfiguration : IEntityTypeConfiguration<TouristFacility>
    {
        public void Configure(EntityTypeBuilder<TouristFacility> builder)
        {
            builder.ToTable(nameof(TouristFacility));
            builder.HasKey(b => b.TouristFacilityId);
            // requi
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.TouristFacilityName).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();

            //un requi
            builder.Property(x => x.phone).IsRequired(false);
            builder.Property(x => x.ward_name).IsRequired(false);
            builder.Property(x => x.district_name).IsRequired(false);
            builder.Property(x => x.province_name).IsRequired(false);
            builder.Property(x => x.ward_code).IsRequired(false);
            builder.Property(x => x.district_id).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.ContactInfor).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.UpdateTime).IsRequired(false);
            builder.Property(x => x.EmailTouristFacility).IsRequired(false);
            builder.Property(x => x.Website).IsRequired(false);
            builder.Property(x => x.LogoURL).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.Account)
               .WithOne(c => c.TouristFacility)
               .HasForeignKey<TouristFacility>(x => x.UserId);
            #endregion
        }
    }
}