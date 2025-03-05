

using ATO_API.Config;
using ATO_API.Extensions;
using ATO_API.Helper;
using Data.ArmsContext;
using Data.DTO.Request;
using Data.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Service.AboutSer;
using Service.AccountSer;
using Service.BlogSer;
using Service.EmailSer;
using Service.Repository;
using Service.SystemConfigSer;
using Service.UserSupportSer;
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

// app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.ApplyMigrations();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
