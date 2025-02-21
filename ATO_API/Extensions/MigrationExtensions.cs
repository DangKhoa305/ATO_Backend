using Microsoft.EntityFrameworkCore;

namespace ATO_API.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using Data.ArmsContext.ATODbContext dbContext =
                scope.ServiceProvider.GetRequiredService<Data.ArmsContext.ATODbContext>();

            dbContext.Database.Migrate();
        }
    }
}
