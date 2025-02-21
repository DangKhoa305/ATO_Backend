using Data.Configurations;
using Data.Models;
using Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Data.ArmsContext
{
    public class ATODbContext : IdentityDbContext<Account, IdentityRole<Guid>, Guid>
    {
        public ATODbContext(DbContextOptions options) : base(options)
        {
        }
        /// <summary>
        /// Get connection strings in appsetings.json
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ATO_Database"));
            }
        }
        /// <summary>
        /// Apply db configuration
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region configuration
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new TourCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new TouristFacilityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CertificationConfiguration());
            modelBuilder.ApplyConfiguration(new UserIssueConfiguration());
            modelBuilder.ApplyConfiguration(new UserSupportConfiguration());
            #endregion
            #region config FK for generate account and role,...
            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne<IdentityRole<Guid>>()
                      .WithMany()
                      .HasForeignKey(e => e.RoleId)
                      .OnDelete(DeleteBehavior.Cascade);

            });
            modelBuilder.Entity<IdentityUserToken<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure IdentityUserClaim
            modelBuilder.Entity<IdentityUserClaim<Guid>>()
                .HasKey(uc => uc.Id);

            modelBuilder.Entity<IdentityUserClaim<Guid>>()
                .HasOne<Account>()
                .WithMany()
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure IdentityRoleClaim
            modelBuilder.Entity<IdentityRoleClaim<Guid>>()
                .HasKey(rc => rc.Id);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>()
                .HasOne<Account>()
                .WithMany()
                .HasForeignKey(rc => rc.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            // seeding data
            #region seeding data
            new AccountSeeder(modelBuilder).Seed();
            new AboutSeeder(modelBuilder).Seed();
            new BlogSeeder(modelBuilder).Seed();
            new TourCompanySeeder(modelBuilder).Seed();
            new TouristFacilitySeeder(modelBuilder).Seed();
            new UserSupportSeeder(modelBuilder).Seed();
            new UserIssueSeeder(modelBuilder).Seed();
            #endregion

        }
        #region DbSet
        public DbSet<Account> Accounts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TourCompany> TourCompanies { get; set; }
        public DbSet<TouristFacility> TouristFacilities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<UserSupport> UserSupports { get; set; }
        public DbSet<UserIssue> UserIssues { get; set; }
        #endregion
    }

}
