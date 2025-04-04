﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class UpdateConfigRequest
    {
        public string Email { get; set; }
        public string AppPassword { get; set; }
    }
    public class UpdateConfigVNPAYRequest
    {
        public string TmnCode { get; set; }
        public string HashSecret { get; set; }
        public string Url { get; set; }
        public string Command { get; set; }
        public string CurrCode { get; set; }
        public string Version { get; set; }
        public string Locale { get; set; }
        public string PaymentBackReturnUrl { get; set; }
    }
}
