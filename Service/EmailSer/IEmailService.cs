using Data.DTO.Request;
using Data.DTO.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public interface IEmailService
    {
        Task<ResponseVM> SendEmailAsync(EmailRequest emailRequest);
    }
}
