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
            modelBuilder.ApplyConfiguration(new SystemConfigurationsConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new TourCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new TouristFacilityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CertificationConfiguration());
            modelBuilder.ApplyConfiguration(new UserIssueConfiguration());
            modelBuilder.ApplyConfiguration(new UserSupportConfiguration());
            modelBuilder.ApplyConfiguration(new TourGuideConfiguration());
            modelBuilder.ApplyConfiguration(new TourismPackageConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new AgriculturalTourPackageConfiguration());
            modelBuilder.ApplyConfiguration(new DriverConfiguration());
            modelBuilder.ApplyConfiguration(new AccommodationConfiguration());
            modelBuilder.ApplyConfiguration(new TourDestinationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new VNPayPaymentResponseConfiguration());
            modelBuilder.ApplyConfiguration(new BookingAgriculturalTourConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new ShipAddressConfiguration());

            modelBuilder.ApplyConfiguration(new ContractConfiguration());


            // Addition
            modelBuilder.ApplyConfiguration(new AdminBalanceConfiguration());
            modelBuilder.ApplyConfiguration(new BookingTourDestinationConfiguration());
            modelBuilder.ApplyConfiguration(new WithdrawalHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new WithdrawalRequestConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());

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
            // Seed các bảng cơ bản trước
            new AccountSeeder(modelBuilder).Seed();
            new AboutSeeder(modelBuilder).Seed();
            new BlogSeeder(modelBuilder).Seed();
            new SystemConfigurationsSeeder(modelBuilder).Seed();

            // Seed các bảng liên quan đến Tourist Facility
            new TourCompanySeeder(modelBuilder).Seed();
            new TouristFacilitySeeder(modelBuilder).Seed();

            // Seed các bảng phụ thuộc vào Tourist Facility
            new ProductSeeder(modelBuilder).Seed();
            new OCOPSellSeeder(modelBuilder).Seed();
            new CertificationSeeder(modelBuilder).Seed();

            // Seed các bảng khác
            new UserSupportSeeder(modelBuilder).Seed();
            new UserIssueSeeder(modelBuilder).Seed();
            new TourismPackageSeeder(modelBuilder).Seed();
            new ActivitySeeder(modelBuilder).Seed();
            new AgriculturalTourPackageSeeder(modelBuilder).Seed();
            new TourGuideSeeder(modelBuilder).Seed();
            new TourDestinationSeeder(modelBuilder).Seed();
            new DriverSeeder(modelBuilder).Seed();
            new AccommodationSeeder(modelBuilder).Seed();
            new ShipAddressSeeder(modelBuilder).Seed();
            new BankAccountSeeder(modelBuilder).Seed();
            #endregion

        }
        #region DbSet
        public DbSet<SystemConfigurations> SystemConfigurationses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TourCompany> TourCompanies { get; set; }
        public DbSet<TouristFacility> TouristFacilities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<UserSupport> UserSupports { get; set; }
        public DbSet<UserIssue> UserIssues { get; set; }
        public DbSet<TourGuide> TourGuides { get; set; }
        public DbSet<TourismPackage> TourismPackages { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<AgriculturalTourPackage> AgriculturalTourPackages { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<TourDestination> TourDestinations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<VNPayPaymentResponse> VNPayPaymentResponses { get; set; }
        public DbSet<BookingAgriculturalTour> BookingAgriculturalTours { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ShipAddress> ShipAddresses { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<AdminBalance> AdminBalances { get; set; }
        public DbSet<BookingTourDestination> BookingTourDestinations { get; set; }
        public DbSet<WithdrawalRequest> WithdrawalRequests { get; set; }
        public DbSet<WithdrawalHistory> WithdrawalHistories { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }


        #endregion
    }

}
