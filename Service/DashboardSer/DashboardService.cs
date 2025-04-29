using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.DashboardSer;

public class DashboardService(
    IRepository<Account> accountRepo,
    IRepository<TourCompany> companyRepo,
    IRepository<TouristFacility> facilityRepo,
    IRepository<Order> orderRepo,
    IRepository<BookingAgriculturalTour> bookingRepo,
    IRepository<AgriculturalTourPackage> tourPackageRepo,
    IRepository<Driver> driverRepo,
    IRepository<TourismPackage> tourismPackageRepo,
    IRepository<Accommodation> accommodationRepo) : IDashboardService
{
    public async Task<AdminDashboardData> GetAdminDashboardDataAsync()
    {
        var userCount = await accountRepo.Query().CountAsync();
        var companyCount = await companyRepo.Query().CountAsync();
        var facilityCount = await facilityRepo.Query().CountAsync();
        var monthlyRevenues = await GetMonthlyRevenueAsync();
        var yearlyRevenues = await GetYearlyRevenueAsync();
        var totalOrderAmount = await orderRepo.Query()
            .SumAsync(o => o.TotalAmount);

        var totalTourAmount = await bookingRepo.Query()
            .SumAsync(b => b.TotalAmmount);

        var totalAmount = (decimal)totalOrderAmount + totalTourAmount;

        return new AdminDashboardData
        {
            UserCount = userCount,
            CompanyCount = companyCount,
            FacilityCount = facilityCount,
            TotalOrderAmount = (decimal)totalOrderAmount,
            TotalTourAmount = totalTourAmount,
            TotalAmount = totalAmount,
            MonthlyRevenues = monthlyRevenues,
            YearlyRevenues = yearlyRevenues
        };
    }

    public async Task<TourCompanyDashboardData> GetTourCompanyDashboardDataAsync(Guid companyId)
    {
        // Count tours for the company
        var tourCount = await tourPackageRepo.Query()
            .Where(t => t.TourCompanyId == companyId)
            .CountAsync();

        // Count drivers for the company
        var driverCount = await driverRepo.Query()
            .Where(d => d.TourCompanyId == companyId)
            .CountAsync();

        // Count accommodations for the company
        var accommodationCount = await accommodationRepo.Query()
            .Where(a => a.TourCompanyId == companyId)
            .CountAsync();

        // Calculate total earnings from bookings
        var totalEarnings = await bookingRepo.Query()
            .Where(b => b.AgriculturalTourPackage!.TourCompanyId == companyId)
            .SumAsync(b => b.TotalAmmount);

        // Get recent bookings (last 10)
        var recentBookings = await bookingRepo.Query()
            .Where(b => b.AgriculturalTourPackage!.TourCompanyId == companyId)
            .OrderByDescending(b => b.BookingDate)
            .Take(10)
            .Select(b => new
            {
                b.BookingId,
                b.AgriculturalTourPackage!.PackageName,
                b.BookingDate,
                b.TotalAmmount,
                b.StatusBooking
            })
            .ToListAsync();

        var monthlyRevenues = await GetMonthlyRevenueForCompanyAsync(companyId);
        var yearlyRevenues = await GetYearlyRevenueForCompanyAsync(companyId);

        return new TourCompanyDashboardData
        {
            TourCount = tourCount,
            DriverCount = driverCount,
            AccommodationCount = accommodationCount,
            TotalEarnings = totalEarnings,
            RecentBookings = recentBookings.Select(b => new RecentBooking
            {
                BookingId = b.BookingId,
                PackageName = b.PackageName,
                BookingDate = b.BookingDate,
                TotalAmount = b.TotalAmmount,
                Status = b.StatusBooking
            }).ToList(),
            MonthlyRevenues = monthlyRevenues,
            YearlyRevenues = yearlyRevenues
        };
    }

    public async Task<TouristFacilityDashboardData> GetTouristFacilityDashboardDataAsync(Guid facilityId)
    {
        // Count products for the facility
        var productCount = await facilityRepo.Query()
            .Where(f => f.TouristFacilityId == facilityId)
            .SelectMany(f => f.Products)
            .CountAsync();

        // Count orders for the facility
        var orderCount = await orderRepo.Query()
            .Where(o => o.OrderDetails.Any(od => od.Product.TouristFacilityId == facilityId))
            .CountAsync();

        // Calculate total earnings from orders
        var totalEarnings = await orderRepo.Query()
            .Where(o => o.OrderDetails.Any(od => od.Product.TouristFacilityId == facilityId))
            .SumAsync(o => o.TotalAmount);

        // Get recent orders (last 10)
        var recentOrders = await orderRepo.Query()
            .Where(o => o.OrderDetails.Any(od => od.Product.TouristFacilityId == facilityId))
            .OrderByDescending(o => o.OrderDate)
            .Take(10)
            .Select(o => new
            {
                o.OrderId,
                o.OrderDate,
                o.TotalAmount,
                o.StatusOrder
            })
            .ToListAsync();

        var monthlyRevenues = await GetMonthlyRevenueForFacilityAsync(facilityId);
        var yearlyRevenues = await GetYearlyRevenueForFacilityAsync(facilityId);
        var totalPackage = await tourismPackageRepo.Query().Where(x => x.TouristFacilityId == facilityId).CountAsync();
        return new TouristFacilityDashboardData
        {
            ProductCount = productCount,
            OrderCount = orderCount,
            TotalEarnings = (decimal)totalEarnings,
            TotalPackage = totalPackage,
            RecentOrders = recentOrders.Select(o => new RecentOrder
            {
                OrderId = o.OrderId,
                OrderDate = o.OrderDate,
                TotalAmount = (decimal)o.TotalAmount,
                Status = o.StatusOrder
            }).ToList(),
            MonthlyRevenues = monthlyRevenues,
            YearlyRevenues = yearlyRevenues
        };
    }

    public async Task<Guid?> GetCompanyIdFromUserIdAsync(Guid userId)
    {
        var company = await companyRepo.Query()
            .FirstOrDefaultAsync(c => c.UserId == userId);
        return company?.TourCompanyId;
    }

    public async Task<Guid?> GetFacilityIdFromUserIdAsync(Guid userId)
    {
        var facility = await facilityRepo.Query()
            .FirstOrDefaultAsync(f => f.UserId == userId);
        return facility?.TouristFacilityId;
    }

    public async Task<List<MonthlyRevenue>> GetMonthlyRevenueAsync()
    {
        var monthlyRevenue = await bookingRepo.Query()
            .GroupBy(b => new { b.BookingDate.Year, b.BookingDate.Month })
            .Select(g => new MonthlyRevenue
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                TotalAmount = g.Sum(b => b.TotalAmmount)
            })
            .ToListAsync();

        return monthlyRevenue;
    }

    public async Task<List<YearlyRevenue>> GetYearlyRevenueAsync()
    {
        var yearlyRevenue = await bookingRepo.Query()
            .GroupBy(b => b.BookingDate.Year)
            .Select(g => new YearlyRevenue
            {
                Year = g.Key,
                TotalAmount = g.Sum(b => b.TotalAmmount)
            })
            .ToListAsync();

        return yearlyRevenue;
    }

    public async Task<List<MonthlyRevenue>> GetMonthlyRevenueForCompanyAsync(Guid companyId)
    {
        var monthlyRevenue = await bookingRepo.Query()
            .Where(b => b.AgriculturalTourPackage!.TourCompanyId == companyId)
            .GroupBy(b => new { b.BookingDate.Year, b.BookingDate.Month })
            .Select(g => new MonthlyRevenue
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                TotalAmount = g.Sum(b => b.TotalAmmount)
            })
            .ToListAsync();

        return monthlyRevenue;
    }

    public async Task<List<YearlyRevenue>> GetYearlyRevenueForCompanyAsync(Guid companyId)
    {
        var yearlyRevenue = await bookingRepo.Query()
            .Where(b => b.AgriculturalTourPackage!.TourCompanyId == companyId)
            .GroupBy(b => b.BookingDate.Year)
            .Select(g => new YearlyRevenue
            {
                Year = g.Key,
                TotalAmount = g.Sum(b => b.TotalAmmount)
            })
            .ToListAsync();

        return yearlyRevenue;
    }

    public async Task<List<MonthlyRevenue>> GetMonthlyRevenueForFacilityAsync(Guid facilityId)
    {
        var monthlyRevenue = await orderRepo.Query()
            .Where(o => o.OrderDetails.Any(od => od.Product.TouristFacilityId == facilityId))
            .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
            .Select(g => new MonthlyRevenue
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                TotalAmount = (decimal)g.Sum(o => o.TotalAmount)
            })
            .ToListAsync();

        return monthlyRevenue;
    }

    public async Task<List<YearlyRevenue>> GetYearlyRevenueForFacilityAsync(Guid facilityId)
    {
        var yearlyRevenue = await orderRepo.Query()
            .Where(o => o.OrderDetails.Any(od => od.Product.TouristFacilityId == facilityId))
            .GroupBy(o => o.OrderDate.Year)
            .Select(g => new YearlyRevenue
            {
                Year = g.Key,
                TotalAmount = (decimal)g.Sum(o => o.TotalAmount)
            })
            .ToListAsync();

        return yearlyRevenue;
    }
}



public class AdminDashboardData
{
    public int UserCount { get; set; }
    public int CompanyCount { get; set; }
    public int FacilityCount { get; set; }
    public decimal TotalOrderAmount { get; set; }
    public decimal TotalTourAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public List<MonthlyRevenue> MonthlyRevenues { get; set; }
    public List<YearlyRevenue> YearlyRevenues { get; set; }
}

public class TourCompanyDashboardData
{
    public int TourCount { get; set; }
    public int DriverCount { get; set; }
    public int AccommodationCount { get; set; }
    public decimal TotalEarnings { get; set; }
    public List<RecentBooking> RecentBookings { get; set; }
    public List<MonthlyRevenue> MonthlyRevenues { get; set; }
    public List<YearlyRevenue> YearlyRevenues { get; set; }
}

public class RecentBooking
{
    public Guid BookingId { get; set; }
    public string PackageName { get; set; }
    public DateTime BookingDate { get; set; }
    public decimal TotalAmount { get; set; }
    public StatusBooking Status { get; set; }
}

public class TouristFacilityDashboardData
{
    public int ProductCount { get; set; }
    public int OrderCount { get; set; }
    public int TotalPackage { get; set; }
    public decimal TotalEarnings { get; set; }
    public List<RecentOrder> RecentOrders { get; set; }
    public List<MonthlyRevenue> MonthlyRevenues { get; set; }
    public List<YearlyRevenue> YearlyRevenues { get; set; }
}

public class RecentOrder
{
    public Guid OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public StatusOrder Status { get; set; }
}


public class MonthlyRevenue
{
    public int Year { get; set; }
    public int Month { get; set; }
    public decimal TotalAmount { get; set; }
}

public class YearlyRevenue
{
    public int Year { get; set; }
    public decimal TotalAmount { get; set; }
}

