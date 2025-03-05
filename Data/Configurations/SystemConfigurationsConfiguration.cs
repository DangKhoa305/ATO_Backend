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
    public class SystemConfigurationsConfiguration : IEntityTypeConfiguration<SystemConfigurations>
    {
        public void Configure(EntityTypeBuilder<SystemConfigurations> builder)
        {
            builder.ToTable(nameof(SystemConfigurations));
            builder.HasKey(b => b.ConfigId);
            // requi
            builder.Property(x => x.ConfigType).IsRequired();
            builder.Property(x => x.ConfigKey).IsRequired();
            builder.Property(x => x.ConfigValue).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.UpdateTime).IsRequired(false);
        }
    }
}