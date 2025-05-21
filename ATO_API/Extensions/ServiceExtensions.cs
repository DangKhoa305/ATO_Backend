using Data.Models;
using Service;
using Service.AdminBalanceSer;
using Service.BookingTourDestinationSer;
using Service.FacilityCertificationSer;
using Service.Repository;
using Service.TourGuidePackageSer;
using Service.WithdrawalSer;

namespace ATO_API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services, nameof(services));

        services.AddScoped<IRepository<AdminBalance>, Repository<AdminBalance>>();
        services.AddScoped<IRepository<WithdrawalHistory>, Repository<WithdrawalHistory>>();
        services.AddScoped<IRepository<WithdrawalRequest>, Repository<WithdrawalRequest>>();
        services.AddScoped<IRepository<BookingTourDestination>, Repository<BookingTourDestination>>();
        services.AddScoped<IRepository<FacilityCertification>, Repository<FacilityCertification>>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services, nameof(services));

        services.AddScoped<IBookingTourDestinationService, BookingTourDestinationService>();
        services.AddScoped<IAdminBalanceService, AdminBalanceService>();
        services.AddScoped<IWithdrawalService, WithdrawalService>();
        services.AddScoped<ITourGuidePackageService, TourGuidePackageService>();
        services.AddScoped<IFacilityCertificationService, FacilityCertificationService>();
        services.AddScoped<IGeneralService, GeneralService>();

        return services;
    }
}
