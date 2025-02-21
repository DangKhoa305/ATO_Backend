using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ResponseVM
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
    }
    public class ResponseVM_Email
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public string? toEmail { get; set; }
    }
}
