using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SystemConfigurationsSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SystemConfigurationsSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<SystemConfigurations>().HasData(
               //config email
               new SystemConfigurations()
               {
                   ConfigId = 1,
                   ConfigType = ConfigType.EmailConfig,
                   ConfigKey = "SmtpServer",
                   ConfigValue = "smtp.gmail.com",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 2,
                   ConfigType = ConfigType.EmailConfig,
                   ConfigKey = "Port",
                   ConfigValue = "587",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 3,
                   ConfigType = ConfigType.EmailConfig,
                   ConfigKey = "Email",
                   ConfigValue = "thangnvse151059@fpt.edu.vn",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 4,
                   ConfigType = ConfigType.EmailConfig,
                   ConfigKey = "AppPassword",
                   ConfigValue = "sllgcjfbkpgcwnmp",
                   CreateDate = DateTime.UtcNow
               }
               ,
               new SystemConfigurations()
               {
                   ConfigId = 5,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "TmnCode",
                   ConfigValue = "7S4BSWDD",
                   CreateDate = DateTime.UtcNow
               }
               ,
               new SystemConfigurations()
               {
                   ConfigId = 6,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "HashSecret",
                   ConfigValue = "RC7QASGETNFSP0EDKUE4IT7X6VRKM4NJ",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 7,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "Url",
                   ConfigValue = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html",
                   CreateDate = DateTime.UtcNow
               }
               ,
               new SystemConfigurations()
               {
                   ConfigId = 8,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "Command",
                   ConfigValue = "pay",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 9,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "CurrCode",
                   ConfigValue = "VND",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 10,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "Version",
                   ConfigValue = "2.1.0",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 11,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "Locale",
                   ConfigValue = "vn",
                   CreateDate = DateTime.UtcNow
               },
               new SystemConfigurations()
               {
                   ConfigId = 12,
                   ConfigType = ConfigType.VnPayConfig,
                   ConfigKey = "PaymentBackReturnUrl",
                   ConfigValue = "https://localhost:5001/api/tourist/order/return_order",
                   CreateDate = DateTime.UtcNow
               }
           );
        }

    }
}
