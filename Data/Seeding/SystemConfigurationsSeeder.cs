using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
           );
        }

    }
}
