using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MimeKit;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public class EmailService : IEmailService
    {
        private readonly IRepository<SystemConfigurations> _systemConfigurationsRepository;
        public EmailService(IRepository<SystemConfigurations> systemConfigurationsRepository)
        {
            _systemConfigurationsRepository = systemConfigurationsRepository;
        }

        public async Task<ResponseVM> SendEmailAsync(EmailRequest emailRequest)
        {
            try
            {
                EmailSetting emailSetting = new EmailSetting();
                emailSetting.Port = int.TryParse(
                await _systemConfigurationsRepository.Query()
                    .Where(b => b.ConfigKey == "Port")
                    .Select(b => b.ConfigValue)
                    .FirstOrDefaultAsync(), out int portValue) ? portValue : 587;

                emailSetting.Email = await _systemConfigurationsRepository.Query()
                    .Where(b => b.ConfigKey == "Email")
                    .Select(b => b.ConfigValue)
                    .FirstOrDefaultAsync() ?? "";

                emailSetting.SmtpServer = await _systemConfigurationsRepository.Query()
                    .Where(b => b.ConfigKey == "SmtpServer")
                    .Select(b => b.ConfigValue)
                    .FirstOrDefaultAsync() ?? "";
                emailSetting.AppPassword = await _systemConfigurationsRepository.Query()
                    .Where(b => b.ConfigKey == "AppPassword")
                    .Select(b => b.ConfigValue)
                    .FirstOrDefaultAsync() ?? "";

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ATO System", emailSetting.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = emailRequest.Body
                };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(emailSetting.SmtpServer, emailSetting.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(emailSetting.Email, emailSetting.AppPassword);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return new ResponseVM() { Status = true, Message = "Gửi mail thành công" };
            }
            catch (Exception)
            {
                return new ResponseVM() { Status = false, Message = "Gửi mail không thành công" };
            }
        }

    }
}
