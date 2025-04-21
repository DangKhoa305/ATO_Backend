

using ATO_API.Config;
using ATO_API.Extensions;
using ATO_API.Helper;
using Data.ArmsContext;
using Data.DTO.Request;
using Data.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Service.AboutSer;
using Service.AccommodationSer;
using Service.AccountSer;
using Service.AgriculturalTourPackageSer;
using Service.BlogSer;
using Service.BookingSer;
using Service.BookingTourDestinationSer;
using Service.DriverSer;
using Service.EmailSer;
using Service.FeedbackSer;
using Service.OrderSer;
using Service.ProductSer;
using Service.Repository;
using Service.ShipAddressSer;
using Service.ShippingSer;
using Service.SystemConfigSer;
using Service.TourCompanySer;
using Service.TourGuideSer;
using Service.TourismPackageSer;
using Service.TouristFacilitySer;
using Service.UserSupportSer;
using Service.VnPaySer;
using StackExchange.Redis;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo("/var/data/dataprotection-keys"));


ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<ATODbContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("ATO_Database")
));
// create mapper
var mapper = AutoMapperConfig.Initialize();
builder.Services.AddSingleton(mapper);

// For Identity
builder.Services.AddIdentity<Account, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ATODbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("guest", policy =>
        policy.RequireRole("guest"));
});

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"])),
        ValidateLifetime = true,
        ClockSkew = TimeSpan.FromDays(5)
    };
});
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger ATO", Version = "v1" });
    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "@JWT Authorization header using the Bearer schema. \r\n\r\n" +
            "Enter 'Bearer' [Space] and then your token in the text input below. \r\n\r\n" +
            "Example: 123456abcdef",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    config.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(
    builder.Configuration.GetValue<string>("Redis:ConnectionString")));
// token helper 
builder.Services.AddSingleton<TokenHelper>();
// account service
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IRepository<Account>, Repository<Account>>();
// blog service
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IRepository<Blog>, Repository<Blog>>();
// email service 
//builder.Services.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));
builder.Services.AddScoped<IEmailService, EmailService>();
// about
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IRepository<About>, Repository<About>>();
// user support
builder.Services.AddScoped<IUserSupportService, UserSupportService>();
builder.Services.AddScoped<IRepository<UserSupport>, Repository<UserSupport>>();
//SystemConfigurations
builder.Services.AddScoped<ISystemConfigurationsService, SystemConfigurationsService>();
builder.Services.AddScoped<IRepository<SystemConfigurations>, Repository<SystemConfigurations>>();
//TouristFacility
builder.Services.AddScoped<ITouristFacilityService, TouristFacilityService>();
builder.Services.AddScoped<IRepository<TouristFacility>, Repository<TouristFacility>>();
//Product
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
//OCOPSell
builder.Services.AddScoped<IRepository<OCOPSell>, Repository<OCOPSell>>();
//TourCompany
builder.Services.AddScoped<ITourCompanyService, TourCompanyService>();
builder.Services.AddScoped<IRepository<TourCompany>, Repository<TourCompany>>();
//Certification
builder.Services.AddScoped<IRepository<Certification>, Repository<Certification>>();
//TourGuide
builder.Services.AddScoped<ITourGuideService, TourGuideService>();
builder.Services.AddScoped<IRepository<TourGuide>, Repository<TourGuide>>();
//TourismPackage
builder.Services.AddScoped<ITourismPackageService, TourismPackageService>();
builder.Services.AddScoped<IRepository<TourismPackage>, Repository<TourismPackage>>();
//Activity
builder.Services.AddScoped<IRepository<Activity>, Repository<Activity>>();
//Driver
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<IRepository<Driver>, Repository<Driver>>();
//Accommodation
builder.Services.AddScoped<IAccommodationService, AccommodationService>();
builder.Services.AddScoped<IRepository<Accommodation>, Repository<Accommodation>>();
// AgriculturalTourPackage
builder.Services.AddScoped<IAgriculturalTourPackageService, AgriculturalTourPackageService>();
builder.Services.AddScoped<IRepository<AgriculturalTourPackage>, Repository<AgriculturalTourPackage>>();
// TourDestination
builder.Services.AddScoped<IRepository<TourDestination>, Repository<TourDestination>>();
// Order
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IRepository<Data.Models.Order>, Repository<Data.Models.Order>>();
// OrderDetail
builder.Services.AddScoped<IRepository<OrderDetail>, Repository<OrderDetail>>();
//vnpay 
builder.Services.AddScoped<IVnPayService, VnPayService>();
builder.Services.AddScoped<IRepository<VNPayPaymentResponse>, Repository<VNPayPaymentResponse>>();
//ship 
builder.Services.AddHttpClient();
builder.Services.AddScoped<IShippingService, ShippingService>();
//booking 
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IRepository<BookingAgriculturalTour>, Repository<BookingAgriculturalTour>>();
//Feedback 
builder.Services.AddScoped<IFeedbackService, FeedbackService>();
builder.Services.AddScoped<IRepository<Feedback>, Repository<Feedback>>();
//ShipAddress 
builder.Services.AddScoped<IShipAddressService, ShipAddressService>();
builder.Services.AddScoped<IRepository<ShipAddress>, Repository<ShipAddress>>();

builder.Services.AddScoped<IBookingTourDestinationService, BookingTourDestinationService>();
// app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.ApplyMigrations();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();
