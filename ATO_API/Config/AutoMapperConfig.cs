using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.DTO.Response;
using Data.Models;
using System.ComponentModel;
using System.Reflection;

namespace ATO_API.Config
{
    public class AutoMapperConfig : Profile
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                // blog mapper
                config.CreateMap<Blog, Blog_Guest_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
                config.CreateMap<Blog, Blog_CM_DTO>()
                .ForMember(dest => dest.TouristFacilityId, opt => opt.MapFrom(src => src.Account.TouristFacility.TouristFacilityId))
                .ForMember(dest => dest.TourCompanyId, opt => opt.MapFrom(src => src.Account.TourCompany.TourCompanyId))
                 .ForMember(dest => dest.CreateByName, opt => opt.MapFrom(src =>
                    src.Account.TourCompany != null ? src.Account.TourCompany.CompanynName :
                    src.Account.TouristFacility != null ? src.Account.TouristFacility.TouristFacilityName : "Hệ thống ATOS"
                ));
                config.CreateMap<BlogCreateRequest, Blog>();
                config.CreateMap<BlogUpdateRequest, Blog>();
                // user support
                config.CreateMap<UserSupportRequest, UserSupport>();
                config.CreateMap<UserSupport, UserSupportDetails>()
                .ForMember(dest => dest.ResponeBy, opt => opt.MapFrom(src => src.ResponeAccount.Fullname))
                .ForMember(dest => dest.IssueTypeDescription, opt => opt.MapFrom(src => GetEnumDescription(src.IssueType)));
                // manage users 
                config.CreateMap<Account, UserRespone>();
                config.CreateMap<Account, UserUnassignedTourCompany>();
                config.CreateMap<TourCompany, UserRespone_TourCompany>();
                config.CreateMap<TouristFacility, UserRespone_TouristFacility>();
                config.CreateMap<TourGuide, UserRespone_TourGuide>();
                config.CreateMap<CreateAccountRequest, Account>();
                config.CreateMap<CreateAccountRequest_GT, Account>();
                config.CreateMap<Account, TourGuideRespone_Account>();
                config.CreateMap<Account, Account_FeedbackRespone>();
                // TouristFacility
                config.CreateMap<TouristFacility, TouristFacilityDTO>();
                config.CreateMap<Account, TouristFacilityDTO_UserRespone>();
                config.CreateMap<CreateTouristFacilityRequest, TouristFacility>();
                config.CreateMap<UpdateTouristFacilityRequest, TouristFacility>();
                config.CreateMap<TouristFacility, TouristFacilityDTO_Certfication>();
                config.CreateMap<TouristFacility, TouristFacilityDTO_Guest>();
                config.CreateMap<TouristFacility, ProductDTO_TouristFacility>();
                config.CreateMap<TouristFacility, TouristFacilityModel>();
                // TourCompany
                config.CreateMap<TourCompany, TourCompanyDTO>();
                config.CreateMap<TourCompany, TourCompanyDTO_Guest>();
                config.CreateMap<Account, TourCompanyDTO_UserRespone>();
                config.CreateMap<CreateTourCompanyRequest, TourCompany>();
                config.CreateMap<UpdateTourCompanyRequest, TourCompany>();
                // product
                config.CreateMap<Product, ProductDTO>();
                config.CreateMap<Product, ProductDTO_Order>();
                config.CreateMap<Product, Product_ActivityRespone>();
                config.CreateMap<Product_ActivityResquest, Product>();
                config.CreateMap<Product, ProductDTO_CM>();
                config.CreateMap<CreateProductDTO, Product>();
                config.CreateMap<UpdateProductDTO, Product>();
                config.CreateMap<ApprovelProductDTO, Product>();
                config.CreateMap<Product, Product_OCOPProductActivityRespone>();
                config.CreateMap<Product, ProductDTO_Guest>()
                .ForMember(dest => dest.Price,
                    opt => opt.MapFrom(src =>
                        src.OCOPSells != null && src.OCOPSells.Any()
                            ? src.OCOPSells
                                .OrderBy(s => s.ExpiryDate)
                                .First().SalePrice
                            : src.Price))
                .ForMember(dest => dest.SellVolume,
                    opt => opt.MapFrom(src =>
                        src.OCOPSells != null
                            ? src.OCOPSells
                                .Where(s => s.ExpiryDate == null || s.ExpiryDate > DateTime.UtcNow)
                                .Sum(s => s.SellVolume)
                            : 0));

                // OCOPSell
                config.CreateMap<OCOPSell, OCOPSellDTO>();
                config.CreateMap<CreateOCOPSellDTO, OCOPSell>();
                config.CreateMap<UpdateOCOPSellDTO, OCOPSell>();
                // Certification
                config.CreateMap<Certification, CertificationRespone>();
                config.CreateMap<CreateCertificationDTO, Certification>();
                config.CreateMap<UpdateCertificationDTO, Certification>();
                config.CreateMap<ApprovelCertificationDTO, Certification>();
                config.CreateMap<Certification, CertificationRespone_CM>();
                config.CreateMap<Certification, CertificationRespone_Guest>();
                // TourGuide
                config.CreateMap<TourGuide, TourGuideRespone>();
                config.CreateMap<TourGuide, AgriculturalTourPackage_TourGuide_Respone>();
                config.CreateMap<AgriculturalTourPackageRequest_TourGuides, TourGuide>();
                // TourismPackage
                config.CreateMap<TourismPackage, TourismPackageRespone>();
                config.CreateMap<TourismPackage, TourismPackageRespone_Guest>();
                config.CreateMap<TourismPackage, TourismPackageRespone_TC>();
                config.CreateMap<TourismPackageRequest, TourismPackage>();
                // Activity
                config.CreateMap<Activity, ActivityRespone>();
                config.CreateMap<ActivityRequest, Activity>();
                config.CreateMap<Activity, Activity_OCOPProductActivityRespone>();
                config.CreateMap<Activity, AgriculturalTourPackage_TourDestination_Activity_Respone>();
                config.CreateMap<Activity, ActivityRespone_TC>();
                // DriverRespone
                config.CreateMap<Driver, DriverRespone>();
                config.CreateMap<DriverRequest, Driver>();
                // Accommodation
                config.CreateMap<Accommodation, AccommodationRespone>();
                config.CreateMap<AccommodationRequest, Accommodation>();
                // AgriculturalTourPackage
                config.CreateMap<AgriculturalTourPackage, AgriculturalTourPackageRespone>();
                config.CreateMap<AgriculturalTourPackageRequest, AgriculturalTourPackage>();
                config.CreateMap<AgriculturalTourPackage, AgriculturalTourPackageRespone_Guest>();

                // TourDestination
                config.CreateMap<TourDestination, AgriculturalTourPackage_TourDestination_Respone>();
                config.CreateMap<TourDestination, AgriculturalTourPackage_TourDestination_Respone_Guest>();
                config.CreateMap<TourDestinationRequest, TourDestination>();
                // Order
                config.CreateMap<Order, OrderRespone>()
                    .ForMember(dest => dest.TotalAmountProducts,
                        opt => opt.MapFrom(src =>
                            src.OrderDetails.Sum(od => od.UnitPrice * od.Quantity)))
                    .ForMember(dest => dest.TotalShip,
                        opt => opt.MapFrom(src =>
                            src.TotalAmount - (double)src.OrderDetails.Sum(od => od.UnitPrice * od.Quantity)));

                config.CreateMap<OrderRequest, Order>();
                // OrderDetail
                config.CreateMap<OrderDetail, OrderDetailRespone>();
                config.CreateMap<OrderDetailRequest, OrderDetail>();
                // VNPayPaymentResponse
                config.CreateMap<VNPayPaymentResponse, VNPayPaymentResponseDTO>();
                config.CreateMap<VNPayPaymentResponse, VNPayPaymentResponse_History>();
                //config.CreateMap<VNPayPaymentResponse, VNPayPaymentResponse_History_Order>()
                //.ForMember(dest => dest.Order.Customer, opt => opt.MapFrom(src => src.Order.Account)) ;
                config.CreateMap<VNPayPaymentResponse, VNPayPaymentResponse_History_Order>()
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order))
                .ForPath(dest => dest.Order.Customer, opt => opt.MapFrom(src => src.Order.Account));

                // BookingAgriculturalTour
                config.CreateMap<BookingAgriculturalTour, BookingAgriculturalTourRespone>()
                  .ForMember(dest => dest.TotalBookedPeople,
                        opt => opt.MapFrom(src => src.NumberOfAdults + src.NumberOfChildren));

                config.CreateMap<BookingAgriculturalTourRequest, BookingAgriculturalTour>();
                // Feedback
                config.CreateMap<Feedback, FeedbackRespone>();
                config.CreateMap<FeedbackRequest, Feedback>();
                // ShipAddress
                config.CreateMap<ShipAddress, ShipAddressRespone>();
                config.CreateMap<ShipAddressRequest, ShipAddress>();
                config.CreateMap<AddShipAddressRequest, ShipAddress>();

                config.CreateMap<Account, ProfileResponse>();


                config.CreateMap<AgriculturalTourPackage, TourGuidePackageResponse>()
                    .ForMember(dest => dest.TourName, opt => opt.MapFrom(x => x.PackageName))
                    .ForMember(dest => dest.TotalBookedPeople, opt => opt.MapFrom(src =>
                        src.BookingAgriculturalTours!.Sum(b => b.NumberOfAdults + b.NumberOfChildren)))
                    .ForMember(dest => dest.BookedTours, opt => opt.MapFrom(src =>
                        src.BookingAgriculturalTours!.Where(b => b.PaymentStatus == PaymentStatus.Paid)));

                config.CreateMap<TourDestination, TourDestinationResponse>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>
                        src.Activity != null ? src.Activity.ActivityName : src.Accommodation!.AccommodationName))
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src =>
                        src.Activity != null ? src.Activity.Location : src.Accommodation!.Address))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src =>
                        src.Activity != null ? "Activity" : "Accommodation"));

                config.CreateMap<BookingAgriculturalTour, BookedTourResponse>();

            });

            return mapperConfig.CreateMapper();
        }
        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }
    }
}

