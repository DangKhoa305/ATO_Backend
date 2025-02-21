using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class UserIssue
    {
        public Guid IssueId { get; set; }
        public IssueType IssueType { get; set; }
        public string? IssueDescription { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public string SolutionContent { get; set; }
    }
}
