using Data.DTO.Request;
using Data.DTO.Respone;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public class EmailService: IEmailService
    {
        private readonly EmailSetting _emailSettings;
        public EmailService(IOptions<EmailSetting> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<ResponseVM> SendEmailAsync(EmailRequest emailRequest)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ATO System", _emailSettings.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = emailRequest.Body
                };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_emailSettings.Email, _emailSettings.AppPassword);
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
