using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ArmsContext
{
    public class ATOContextFactory : IDesignTimeDbContextFactory<ATODbContext>
    {
        public ATODbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ATO_Database");
            var optionBuilder = new DbContextOptionsBuilder<ATODbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new ATODbContext(optionBuilder.Options);
        }
    }
}
