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
    public class OCOPProductActivityConfiguration : IEntityTypeConfiguration<OCOPProductActivity>
    {
        public void Configure(EntityTypeBuilder<OCOPProductActivity> builder)
        {
            builder.ToTable(nameof(OCOPProductActivity));
            builder.HasKey(x => new { x.ActivityId, x.ProductId });
            #region config relation
            builder.HasOne(x => x.Product)
                      .WithMany(c => c.OCOPProductActivities)
                      .HasForeignKey(x => x.ProductId)
                      .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Activity)
              .WithMany(c => c.OCOPProductActivities)
              .HasForeignKey(x => x.ActivityId)
              .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
