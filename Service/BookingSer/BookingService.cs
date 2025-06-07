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
    IRepository<TourGuide> tourGuideRepo,
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
    private readonly IRepository<TourGuide> _tourGuideRepo = tourGuideRepo;
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
    public async Task AddBookPaymentRefund(VNPayPaymentResponse checkResponse)
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
                tour.StatusBooking = StatusBooking.Canceled;
                tourexist.Slot = (int)(tourexist.Slot + (tour.NumberOfAdults + tour.NumberOfChildren));

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

            bookingAgriculturalTour.GroupId = tour?.GroupId;
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

    public async Task UpdateBookingStatus(BookingAccept bookingAccept)
    {
        var booking = await _bookingAgriculturalTourRepository.Query()
            .Where(x => x.GroupId == bookingAccept.TourId)
            .ToListAsync();


        var tourId = booking.FirstOrDefault()?.TourId;

        var tour = await _agriculturalTourPackageRepository
            .Query()
            .Include(x => x.TourDestinations)
                .ThenInclude(x => x.Driver)
            .Include(x => x.TourGuides)
            .Where(x => x.TourId == tourId)
            .FirstOrDefaultAsync();

        if (tour is null) return;

        if (bookingAccept.StatusBooking == StatusBooking.InProgress || bookingAccept.StatusBooking == StatusBooking.ConfirmBooking)
        {
            tour.StatusActive = StatusActive.inProgress;
        }

        if (bookingAccept.StatusBooking == StatusBooking.Completed || bookingAccept.StatusBooking == StatusBooking.Canceled)
        {
            booking.ForEach(x =>
            {
                x.StatusBooking = bookingAccept.StatusBooking;
                x.TourGuidIds = tour.TourGuides?.Select(x => x.GuideId).ToList();
                x.DriverIds = tour.TourDestinations?.Select(x => x.DriverId).ToList();
            });

            await _bookingAgriculturalTourRepository.RealUpdateRangeAsync(booking);

            var newDestinations = tour.TourDestinations?.ToList();
            if (newDestinations is not null)
                newDestinations.ForEach(x => x.DriverId = null);

            tour.GroupId = Guid.NewGuid();
            tour.TourGuides = null;
            tour.TourDestinations = newDestinations;
            tour.StatusActive = StatusActive.active;
            await _agriculturalTourPackageRepository.UpdateAsync(tour);

            // TODO: refund user if cancel tour
            if (bookingAccept.StatusBooking == StatusBooking.Canceled)
            {

            }

            return;
        }

        booking.ForEach(x =>
        {
            x.StatusBooking = bookingAccept.StatusBooking;
        });

        await _bookingAgriculturalTourRepository.RealUpdateRangeAsync(booking);
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
    public async Task UpdateStatus(Guid bookingId, int paymentStatus, StatusBooking canceled)
    {
        var order = await _bookingAgriculturalTourRepository.Query()
                .SingleOrDefaultAsync(x => x.BookingId == bookingId);
        if (order == null)
            throw new Exception("Order not found");
        order.StatusBooking = canceled;
        order.PaymentStatus = (PaymentStatus)paymentStatus;
        await _bookingAgriculturalTourRepository.UpdateAsync(order);
    }

    public async Task<bool> IsActiveBooking(Guid id)
    {
        var any = await _bookingAgriculturalTourRepository.Query()
                .Include(x => x.AgriculturalTourPackage)
                .AnyAsync(x => x.CustomerId == id && x.AgriculturalTourPackage!.EndTime > DateTime.Now);

        return any;
    }

    public async Task<ICollection<AgriculturalTourPackage_TourGuide_Respone>?> GetTourGuide(List<Guid>? tourGuidIds)
    {
        try
        {

            return await _tourGuideRepo.Query()
          .Include(x => x.Account)
          .Where(x => tourGuidIds.Contains(x.GuideId))
          .Select(x => new AgriculturalTourPackage_TourGuide_Respone()
          {
              GuideId = x.GuideId,
              Bio = x.Bio,
              ExpertiseArea = x.ExpertiseArea,
              Languages = x.Languages,
              Rating = x.Rating,
              UserId = x.UserId,
              Account = new TourGuideRespone_Account()
              {
                  Fullname = x.Account!.Fullname,
                  Email = x.Account.Email,
                  PhoneNumber = x.Account.PhoneNumber
              }
          }).ToListAsync();
        }

        catch (Exception ex)
        {
            return [];
        }

    }
}
