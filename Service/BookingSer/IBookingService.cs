using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BookingSer
{
    public interface IBookingService
    {
        Task<List<BookingAgriculturalTour>> ListTourBookeds(Guid UserId);
        Task<BookingAgriculturalTour> GetBookTourDetails(Guid BookingId);
        Task<Data.Models.BookingAgriculturalTour> AddBookTour(BookingAgriculturalTour bookingAgriculturalTour);
        Task AddBookPayment(VNPayPaymentResponse checkResponse);
        Task<List<BookingAgriculturalTour>> ListTourBookingTour_TourCompany(Guid UserId);
        Task BookingAccept(BookingAccept bookingAccept);
        Task<List<VNPayPaymentResponse>> ListHistoryPayments(Guid UserId);

    }
}
