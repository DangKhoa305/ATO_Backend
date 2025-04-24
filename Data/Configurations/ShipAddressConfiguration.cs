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
    public class ShipAddressConfiguration : IEntityTypeConfiguration<ShipAddress>
    {
        public void Configure(EntityTypeBuilder<ShipAddress> builder)
        {
            builder.ToTable(nameof(ShipAddress));
            builder.HasKey(b => b.ShipAddressId);
            // requi
            builder.Property(x => x.DefaultAddress).IsRequired();
            builder.Property(x => x.ToName).IsRequired();
            builder.Property(x => x.ToPhone).IsRequired();
            builder.Property(x => x.ToWardCode).IsRequired();
            builder.Property(x => x.ToDistrictId).IsRequired();
            builder.Property(x => x.AccountId).IsRequired();
            //un requi
            #region config relation
            builder.HasOne(x => x.Account)
               .WithMany(c => c.ShipAddresses)
               .HasForeignKey(x => x.AccountId);
            #endregion
        }
    }
}