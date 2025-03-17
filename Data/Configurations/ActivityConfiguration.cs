using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable(nameof(Activity));
            builder.HasKey(b => b.ActivityId);
            // requi
            builder.Property(x => x.ActivityName).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.DurationInHours).IsRequired();
            builder.Property(x => x.BreakTimeInMinutes).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.StatusApproval).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.ReplyRequest).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Location).IsRequired(false);
            builder.Property(x => x.Imgs).IsRequired(false);
            builder.Property(x => x.UpdateDate).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.TourismPackage)
               .WithMany(c => c.Activities)
               .HasForeignKey(x => x.PackageId);
            #endregion
        }
    }
}