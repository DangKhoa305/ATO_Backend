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
    public class TourCompanyConfiguration : IEntityTypeConfiguration<TourCompany>
    {
        public void Configure(EntityTypeBuilder<TourCompany> builder)
        {
            builder.ToTable(nameof(TourCompany));
            builder.HasKey(b => b.TourCompanyId);
            // requi
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.CompanynName).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.EmailCompany).IsRequired(false);
            builder.Property(x => x.CompanyDescription).IsRequired(false);
            builder.Property(x => x.AddressCompany).IsRequired(false);
            builder.Property(x => x.Website).IsRequired(false);
            builder.Property(x => x.UpdateTime).IsRequired(false);
            builder.Property(x => x.LogoURL).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.Account)
               .WithOne(c => c.TourCompany)
               .HasForeignKey<TourCompany>(x => x.UserId);
            #endregion
        }
    }
}