using Data.DTO.Respone;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.BookingSer
{
    public class BookingService : IBookingService
    {
        private readonly Service.Repository.IRepository<Data.Models.Order> _orderRepository;
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository;
        private readonly Service.Repository.IRepository<Data.Models.VNPayPaymentResponse> _VNPayPaymentResponseRepository;
        private readonly Service.Repository.IRepository<OrderDetail> _orderDetailRepository;
        private readonly Service.Repository.IRepository<Product> _productRepository;
        private readonly Service.Repository.IRepository<TouristFacility> _touristFacilityRepository;
        private readonly Service.Repository.IRepository<BookingAgriculturalTour> _bookingAgriculturalTourRepository;
        public BookingService(
            Service.Repository.IRepository<Data.Models.Order> orderRepository,
            IRepository<TourCompany> tourCompanyRepository,
        Service.Repository.IRepository<OrderDetail> orderDetailRepository,
            Service.Repository.IRepository<TouristFacility> touristFacilityRepository,
            Service.Repository.IRepository<Product> productRepository,
            Service.Repository.IRepository<BookingAgriculturalTour> bookingAgriculturalTourRepository,
            IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository,
        Service.Repository.IRepository<Data.Models.VNPayPaymentResponse> vNPayPaymentResponseRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _productRepository = productRepository;
            _VNPayPaymentResponseRepository = vNPayPaymentResponseRepository;
            _touristFacilityRepository = touristFacilityRepository;
            _bookingAgriculturalTourRepository = bookingAgriculturalTourRepository;
            _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
            _tourCompanyRepository = tourCompanyRepository;
        }

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
                    tour.PaymentStatus = PaymentStatus.Paid;
                tour.StatusBooking = StatusBooking.Completed;
                tourexist.Slot = (int)(tourexist.Slot - (tour.NumberOfAdults + tour.NumberOfChildren));
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
                    (decimal)((tour.PriceOfAdults * bookingAgriculturalTour.NumberOfAdults)
                    + (tour.PriceOfChildren * bookingAgriculturalTour.NumberOfChildren));

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
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
