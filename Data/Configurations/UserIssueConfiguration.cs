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
    public class UserIssueConfiguration : IEntityTypeConfiguration<UserIssue>
    {
        public void Configure(EntityTypeBuilder<UserIssue> builder)
        {
            builder.ToTable(nameof(UserIssue));
            builder.HasKey(x => x.IssueId);
            builder.Property(x => x.IssueType).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.SolutionContent).IsRequired();

            builder.Property(x => x.IssueDescription).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(false);
        }
    }
}
