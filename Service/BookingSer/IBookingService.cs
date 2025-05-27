using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;

namespace Service.BookingSer
{
    public interface IBookingService
    {
        Task<List<BookingAgriculturalTour>> ListTourBookeds(Guid UserId);
        Task<BookingAgriculturalTour> GetBookTourDetails(Guid BookingId);
        Task<Data.Models.BookingAgriculturalTour> AddBookTour(BookingAgriculturalTour bookingAgriculturalTour);
        Task AddBookPayment(VNPayPaymentResponse checkResponse);
        Task<List<BookingAgriculturalTour>> ListTourBookingTour_TourCompany(Guid UserId);
        Task UpdateBookingStatus(BookingAccept bookingAccept);
        Task<List<VNPayPaymentResponse>> ListHistoryPayments(Guid UserId);
        Task UpdateStatus(Guid bookingId, int paymentStatus, StatusBooking canceled);
        Task<bool> IsActiveBooking(Guid id);
        Task AddBookPaymentRefund(VNPayPaymentResponse checkResponse);
        Task<ICollection<AgriculturalTourPackage_TourGuide_Respone>?> GetTourGuide(List<Guid>? tourGuidIds);
    }
}
