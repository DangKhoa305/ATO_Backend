using Data.DTO.Request;
using Data.DTO.Respone;
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

        public async Task<EmailConfig> GetEmailAsync()
        {
            var emailConfig = await _systemConfigurationsRepository.Query()
    .FirstOrDefaultAsync(c => c.ConfigKey == "Email" && c.ConfigType == ConfigType.EmailConfig);

            var appPasswordConfig = await _systemConfigurationsRepository.Query()
                .FirstOrDefaultAsync(c => c.ConfigKey == "AppPassword" && c.ConfigType == ConfigType.EmailConfig);
            EmailConfig config = new EmailConfig()
            {
                Email = emailConfig.ConfigValue,
                AppPassword = appPasswordConfig.ConfigValue
            };
            return config;
        }

        public async Task<VNPayConfig> GetVNPayAsync()
        {
            var configKeys = new List<string>
    {
        "TmnCode", "HashSecret", "Url", "Command",
        "CurrCode", "Version", "Locale", "PaymentBackReturnUrl"
    };

            var configs = await _systemConfigurationsRepository.Query()
                .Where(c => configKeys.Contains(c.ConfigKey) && c.ConfigType == ConfigType.VnPayConfig)
                .ToListAsync();

            var configDict = configs.ToDictionary(c => c.ConfigKey, c => c.ConfigValue ?? string.Empty);

            return new VNPayConfig
            {
                TmnCode = configDict.GetValueOrDefault("TmnCode"),
                HashSecret = configDict.GetValueOrDefault("HashSecret"),
                Url = configDict.GetValueOrDefault("Url"),
                Command = configDict.GetValueOrDefault("Command"),
                CurrCode = configDict.GetValueOrDefault("CurrCode"),
                Version = configDict.GetValueOrDefault("Version"),
                Locale = configDict.GetValueOrDefault("Locale"),
                PaymentBackReturnUrl = configDict.GetValueOrDefault("PaymentBackReturnUrl")
            };
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
        public async Task<bool> UpdateVNPayConfigAsync(UpdateConfigVNPAYRequest request)
        {
            var configKeys = new List<string>
                {
                    "TmnCode", "HashSecret", "Url", "Command",
                    "CurrCode", "Version", "Locale", "PaymentBackReturnUrl"
                };

            var configs = await _systemConfigurationsRepository.Query()
                .Where(c => configKeys.Contains(c.ConfigKey) && c.ConfigType == ConfigType.VnPayConfig)
                .ToListAsync();

            var configDict = new Dictionary<string, string>
                {
                    { "TmnCode", request.TmnCode },
                    { "HashSecret", request.HashSecret },
                    { "Url", request.Url },
                    { "Command", request.Command },
                    { "CurrCode", request.CurrCode },
                    { "Version", request.Version },
                    { "Locale", request.Locale },
                    { "PaymentBackReturnUrl", request.PaymentBackReturnUrl }
                };

            foreach (var config in configs)
            {
                if (configDict.TryGetValue(config.ConfigKey, out var newValue))
                {
                    config.ConfigValue = newValue;
                    config.UpdateTime = DateTime.Now;
                    await _systemConfigurationsRepository.UpdateAsync(config);
                }
            }



            return true;
        }

    }
}
