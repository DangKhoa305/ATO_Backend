using Data.Models;
using Service.AdminBalanceSer;
using Service.BookingTourDestinationSer;
using Service.Repository;
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

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services, nameof(services));

        services.AddScoped<IBookingTourDestinationService, BookingTourDestinationService>();
        services.AddScoped<IAdminBalanceService, AdminBalanceService>();
        services.AddScoped<IWithdrawalService, WithdrawalService>();

        return services;
    }
}
