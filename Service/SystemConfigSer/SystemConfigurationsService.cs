using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.SystemConfigSer
{
    public class SystemConfigurationsService : ISystemConfigurationsService
    {
        private readonly IRepository<SystemConfigurations> _systemConfigurationsRepository;
        public SystemConfigurationsService(IRepository<SystemConfigurations> systemConfigurationsRepository)
        {
            _systemConfigurationsRepository = systemConfigurationsRepository;
        }
        public async Task<bool> UpdateEmailAndAppPasswordAsync(string email, string appPassword)
        {
            var emailConfig = await _systemConfigurationsRepository.Query()
                .FirstOrDefaultAsync(c => c.ConfigKey == "Email" && c.ConfigType == ConfigType.EmailConfig);

            var appPasswordConfig = await _systemConfigurationsRepository.Query()
                .FirstOrDefaultAsync(c => c.ConfigKey == "AppPassword" && c.ConfigType == ConfigType.EmailConfig);

            if (emailConfig == null || appPasswordConfig == null)
                return false;

            emailConfig.ConfigValue = email;
            emailConfig.UpdateTime = DateTime.Now;
            await _systemConfigurationsRepository.UpdateAsync(emailConfig);
            appPasswordConfig.ConfigValue = appPassword;
            appPasswordConfig.UpdateTime = DateTime.Now;
            await _systemConfigurationsRepository.UpdateAsync(appPasswordConfig);
            return true;
        }
    }
}
