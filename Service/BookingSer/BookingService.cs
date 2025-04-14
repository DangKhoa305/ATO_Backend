using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using Service.Repository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (checkResponse.TransactionStatus == "00")
                    tour.PaymentStatus = PaymentStatus.Paid;
                tour.StatusBooking = StatusBooking.Completed;
                _bookingAgriculturalTourRepository.UpdateAsync(tour);
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
                bookingAgriculturalTour.BookingId = Guid.NewGuid();
                bookingAgriculturalTour.BookingDate = DateTime.UtcNow;
                bookingAgriculturalTour.PaymentStatus = PaymentStatus.UnPaid;
                bookingAgriculturalTour.StatusBooking = StatusBooking.Processing;
                foreach (var order in bookingAgriculturalTour.Orders)
                {
                    order.OrderId = Guid.NewGuid();
                    order.BookingId = bookingAgriculturalTour.BookingId;
                    order.CustomerId = bookingAgriculturalTour.CustomerId;
                    order.OrderDate = DateTime.UtcNow;
                    order.StatusOrder = StatusOrder.Processing;
                    order.CreateDate = DateTime.UtcNow;
                    if (order.PaymentType == PaymentType.Transfer)
                    {
                        order.PaymentStatus = PaymentStatus.UnPaid;
                    }
                    order.TotalAmount = (double)order.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
                }
                bookingAgriculturalTour.TotalAmmount =
                    (decimal)(bookingAgriculturalTour.Orders
                        .Where(x => x.PaymentType == PaymentType.Transfer)
                        .Sum(od => od.TotalAmount)
                    + (tour.Price * bookingAgriculturalTour.NumberOfPeople));
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
                    .Where(x => x.CustomerId == UserId)
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
