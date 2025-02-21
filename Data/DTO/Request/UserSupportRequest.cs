using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class UserSupportRequest
    {
        public IssueType IssueType { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string SupportMessage { get; set; }
    }
    public class ReplyUserSupportRequest
    {
        public Guid SupportId { get; set; }
        public string SupportMessage { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string? ResponseMessage { get; set; }
        public Guid? ResponeBy { get; set; }

    }
}
