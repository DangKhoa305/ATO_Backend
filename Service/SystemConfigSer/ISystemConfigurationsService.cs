using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.SystemConfigSer
{
    public interface ISystemConfigurationsService
    {
        Task<bool> UpdateEmailAndAppPasswordAsync(string email, string appPassword);
        Task<EmailConfig> GetEmailAsync();
        Task<VNPayConfig> GetVNPayAsync();
        Task<bool> UpdateVNPayConfigAsync(UpdateConfigVNPAYRequest request);
        Task<string?> GetConfigValueAsync(string key);
    }

}
