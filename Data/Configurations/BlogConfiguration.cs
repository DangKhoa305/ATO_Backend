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
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable(nameof(Blog));
            builder.HasKey(b => b.BlogId);
            // requi
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.LinkImg).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();
            builder.Property(x => x.BlogType).IsRequired();
            builder.Property(x => x.BlogStatus).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            //un requi
            builder.Property(x => x.ReplyRequest).IsRequired(false);
            builder.Property(x => x.UpdateTime).IsRequired(false);


            #region config relation
            builder.HasOne(x => x.Account)
               .WithMany(c => c.Blogs)
               .HasForeignKey(x => x.CreateBy);
            #endregion
        }
    }
}