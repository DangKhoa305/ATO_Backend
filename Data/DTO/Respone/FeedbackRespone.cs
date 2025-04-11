using Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class FeedbackRespone
    {
        public Guid FeedbackId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual Account_FeedbackRespone? Account { get; set; }
    }
    public class Account_FeedbackRespone
    {
        public string? Fullname { get; set; }
        public string? AvatarURL { get; set; }
    }
}
