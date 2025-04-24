using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class UpdateReplyRequestDto
    {
        public string ReplyContent { get; set; }
        public BlogStatus NewStatus { get; set; }
    }
}
