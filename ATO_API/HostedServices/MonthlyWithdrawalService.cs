using Service.WithdrawalSer;

namespace ATO_API.HostedServices;

public class MonthlyWithdrawalService(IServiceProvider services) : BackgroundService
{
    private readonly IServiceProvider _services = services;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var now = DateTime.UtcNow;
            var nextRun = new DateTime(now.Year, now.Month, 1).AddMonths(1);
            var delay = nextRun - now;

            await Task.Delay(delay, stoppingToken);

            using var scope = _services.CreateScope();
            var withdrawalService = scope.ServiceProvider.GetRequiredService<IWithdrawalService>();
            await withdrawalService.GenerateMonthlyWithdrawals();
        }
    }
}
