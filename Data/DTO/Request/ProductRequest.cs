using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class ApprovelProductDTO
    {
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
    }
}
