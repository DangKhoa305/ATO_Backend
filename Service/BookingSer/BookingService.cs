using Data.DTO.Respone;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.AdminBalanceSer;
using Service.Repository;

namespace Service.BookingSer;

public class BookingService(
    IRepository<Order> orderRepository,
    IRepository<TourCompany> tourCompanyRepository,
    IRepository<OrderDetail> orderDetailRepository,
    IRepository<TouristFacility> touristFacilityRepository,
    IRepository<Product> productRepository,
    IRepository<BookingAgriculturalTour> bookingAgriculturalTourRepository,
    IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository,
    IRepository<VNPayPaymentResponse> vNPayPaymentResponseRepository,
    IRepository<BookingTourDestination> bookingDestinationRepo,
    IAdminBalanceService adminBalanceService) : IBookingService
{
    private readonly IRepository<Order> _orderRepository = orderRepository;
    private readonly IRepository<TourCompany> _tourCompanyRepository = tourCompanyRepository;
    private readonly IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
    private readonly IRepository<VNPayPaymentResponse> _VNPayPaymentResponseRepository = vNPayPaymentResponseRepository;
    private readonly IRepository<OrderDetail> _orderDetailRepository = orderDetailRepository;
    private readonly IRepository<Product> _productRepository = productRepository;
    private readonly IRepository<TouristFacility> _touristFacilityRepository = touristFacilityRepository;
    private readonly IRepository<BookingAgriculturalTour> _bookingAgriculturalTourRepository = bookingAgriculturalTourRepository;
    private readonly IRepository<BookingTourDestination> _bookingDestinationRepo = bookingDestinationRepo;
    private readonly IAdminBalanceService _adminBalanceService = adminBalanceService;

    public async Task AddBookPayment(VNPayPaymentResponse checkResponse)
    {
        try
        {
            await _VNPayPaymentResponseRepository.AddAsync(checkResponse);

            var tour = await _bookingAgriculturalTourRepository.Query()
                .SingleOrDefaultAsync(x => x.BookingId == checkResponse.BookingId);
            var tourexist = _agriculturalTourPackageRepository.Query()
                .FirstOrDefault(x => x.TourId == tour.TourId);
            if (checkResponse.TransactionStatus == "00")
            {

                tour.PaymentStatus = PaymentStatus.Paid;
                tour.StatusBooking = StatusBooking.Completed;
                tourexist.Slot = (int)(tourexist.Slot - (tour.NumberOfAdults + tour.NumberOfChildren));

                // Add to admin balance
                await _adminBalanceService.AddBookingTransaction(tour);
            }
            _bookingAgriculturalTourRepository.UpdateAsync(tour);
            _agriculturalTourPackageRepository.UpdateAsync(tourexist);
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<BookingAgriculturalTour> AddBookTour(BookingAgriculturalTour bookingAgriculturalTour)
    {
        try
        {
            var tour = _agriculturalTourPackageRepository.Query()
                .FirstOrDefault(x => x.TourId == bookingAgriculturalTour.TourId);
            if (tour?.Slot <= 0) throw new Exception("Hết vé!");
            bookingAgriculturalTour.BookingId = Guid.NewGuid();
            bookingAgriculturalTour.BookingDate = DateTime.UtcNow;
            bookingAgriculturalTour.PaymentStatus = PaymentStatus.UnPaid;
            bookingAgriculturalTour.StatusBooking = StatusBooking.Processing;
            bookingAgriculturalTour.TotalAmmount =
                (decimal)((tour!.PriceOfAdults * bookingAgriculturalTour.NumberOfAdults)
                + (tour.PriceOfChildren * bookingAgriculturalTour.NumberOfChildren!));

            await _bookingAgriculturalTourRepository.AddRangeAsync(bookingAgriculturalTour);

            return bookingAgriculturalTour;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task BookingAccept(BookingAccept bookingAccept)
    {
        var booking = await _bookingAgriculturalTourRepository.Query()
                .SingleOrDefaultAsync(x => x.BookingId == bookingAccept.BookingId);

        booking.StatusBooking = bookingAccept.StatusBooking;
        await _bookingAgriculturalTourRepository.UpdateAsync(booking);
    }

    public async Task<BookingAgriculturalTour> GetBookTourDetails(Guid BookingId)
    {
        try
        {
            return await _bookingAgriculturalTourRepository.Query()
                .Include(x => x.Orders)
                    .ThenInclude(y => y.OrderDetails)
                        .ThenInclude(z => z.Product)
                .Include(y => y.VNPayPaymentResponses)
                .Include(x => x.AgriculturalTourPackage)
                    .ThenInclude(x => x.TourDestinations)
                .SingleOrDefaultAsync(x => x.BookingId == BookingId);
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<List<BookingAgriculturalTour>> ListTourBookeds(Guid UserId)
    {
        try
        {

            return await _bookingAgriculturalTourRepository.Query()
                .Include(x => x.AgriculturalTourPackage)
                .Include(x => x.VNPayPaymentResponses)
                .Include(x => x.Customer)
                .Where(x => x.CustomerId == UserId)
                .OrderByDescending(x => x.BookingDate)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
    public async Task<List<VNPayPaymentResponse>> ListHistoryPayments(Guid UserId)
    {
        try
        {
            TourCompany TourCompany = await _tourCompanyRepository.Query()
               .SingleOrDefaultAsync(x => x.UserId == UserId);
            return await _VNPayPaymentResponseRepository.Query()
                .Include(x => x.BookingAgriculturalTour)
                .ThenInclude(x => x.Customer)
                .Include(x => x.BookingAgriculturalTour)
                .ThenInclude(x => x.AgriculturalTourPackage)
                .Where(x => x.OrderId == null && x.BookingAgriculturalTour.AgriculturalTourPackage.TourCompanyId == TourCompany.TourCompanyId)
                .OrderByDescending(x => x.PayDate)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<List<BookingAgriculturalTour>> ListTourBookingTour_TourCompany(Guid UserId)
    {
        try
        {
            TourCompany TourCompany = await _tourCompanyRepository.Query()
                .SingleOrDefaultAsync(x => x.UserId == UserId);
            return await _bookingAgriculturalTourRepository.Query()
                .Include(x => x.AgriculturalTourPackage)
                .Include(x => x.Customer)
                .Include(x => x.VNPayPaymentResponses)
                .Where(x => x.AgriculturalTourPackage.TourCompanyId == TourCompany.TourCompanyId)
                .OrderByDescending(x => x.BookingDate)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
}
