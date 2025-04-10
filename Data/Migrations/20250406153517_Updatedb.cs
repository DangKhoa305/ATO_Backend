using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    AvatarURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isAccountActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigurations",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigType = table.Column<int>(type: "int", nullable: false),
                    ConfigKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfigValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigurations", x => x.ConfigId);
                });

            migrationBuilder.CreateTable(
                name: "UserIssue",
                columns: table => new
                {
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    IssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SolutionContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIssue", x => x.IssueId);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogType = table.Column<int>(type: "int", nullable: false),
                    BlogStatus = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_Account_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Account_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourCompany",
                columns: table => new
                {
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanynName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourCompany", x => x.TourCompanyId);
                    table.ForeignKey(
                        name: "FK_TourCompany_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TouristFacility",
                columns: table => new
                {
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TouristFacilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ward_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ward_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_id = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInfor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTouristFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristFacility", x => x.TouristFacilityId);
                    table.ForeignKey(
                        name: "FK_TouristFacility_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accommodation",
                columns: table => new
                {
                    AccommodationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccommodationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodation", x => x.AccommodationId);
                    table.ForeignKey(
                        name: "FK_Accommodation_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgriculturalTourPackage",
                columns: table => new
                {
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durations = table.Column<double>(type: "float", nullable: false),
                    DurationsType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturalTourPackage", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackage_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Driver_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourGuide",
                columns: table => new
                {
                    GuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertiseArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourGuide", x => x.GuideId);
                    table.ForeignKey(
                        name: "FK_TourGuide_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourGuide_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Additional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitProduct = table.Column<int>(type: "int", nullable: true),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourismPackage",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Durations = table.Column<double>(type: "float", nullable: false),
                    DurationsType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusOperating = table.Column<int>(type: "int", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourismPackage", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_TourismPackage_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_TourismPackage_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSupport",
                columns: table => new
                {
                    SupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponeBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSupport", x => x.SupportId);
                    table.ForeignKey(
                        name: "FK_UserSupport_Account_ResponeBy",
                        column: x => x.ResponeBy,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSupport_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "BookingAgriculturalTour",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    TotalAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    StatusBooking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAgriculturalTour", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_BookingAgriculturalTour_Account_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingAgriculturalTour_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgriculturalTourPackageTourGuide",
                columns: table => new
                {
                    AgriculturalTourPackagesTourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourGuidesGuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturalTourPackageTourGuide", x => new { x.AgriculturalTourPackagesTourId, x.TourGuidesGuideId });
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackageTourGuide_AgriculturalTourPackage_AgriculturalTourPackagesTourId",
                        column: x => x.AgriculturalTourPackagesTourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackageTourGuide_TourGuide_TourGuidesGuideId",
                        column: x => x.TourGuidesGuideId,
                        principalTable: "TourGuide",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certification",
                columns: table => new
                {
                    CertificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuingOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification", x => x.CertificationId);
                    table.ForeignKey(
                        name: "FK_Certification_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_Certification_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "OCOPSell",
                columns: table => new
                {
                    OCOPSellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellVolume = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCOPSell", x => x.OCOPSellId);
                    table.ForeignKey(
                        name: "FK_OCOPSell_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationInHours = table.Column<double>(type: "float", nullable: false),
                    DurationInHoursType = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreakTimeInMinutes = table.Column<double>(type: "float", nullable: false),
                    BreakTimeInMinutesType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activity_TourismPackage_PackageId",
                        column: x => x.PackageId,
                        principalTable: "TourismPackage",
                        principalColumn: "PackageId");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    StatusOrder = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Account_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                });

            migrationBuilder.CreateTable(
                name: "ActivityProduct",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityProduct", x => new { x.ActivityId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ActivityProduct_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDestination",
                columns: table => new
                {
                    TourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisitOrder = table.Column<int>(type: "int", nullable: false),
                    TypeActivity = table.Column<int>(type: "int", nullable: false),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourismPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccommodationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDestination", x => x.TourDestinationId);
                    table.ForeignKey(
                        name: "FK_TourDestination_Accommodation_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodation",
                        principalColumn: "AccommodationId");
                    table.ForeignKey(
                        name: "FK_TourDestination_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId");
                    table.ForeignKey(
                        name: "FK_TourDestination_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId");
                    table.ForeignKey(
                        name: "FK_TourDestination_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId");
                    table.ForeignKey(
                        name: "FK_TourDestination_TourismPackage_TourismPackageId",
                        column: x => x.TourismPackageId,
                        principalTable: "TourismPackage",
                        principalColumn: "PackageId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "VNPayPaymentResponse",
                columns: table => new
                {
                    ResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TxnRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankTranNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TmnCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecureHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypePayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VNPayPaymentResponse", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_VNPayPaymentResponse_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_VNPayPaymentResponse_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "TourDestinationTourGuide",
                columns: table => new
                {
                    TourDestinationsTourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourGuidesGuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDestinationTourGuide", x => new { x.TourDestinationsTourDestinationId, x.TourGuidesGuideId });
                    table.ForeignKey(
                        name: "FK_TourDestinationTourGuide_TourDestination_TourDestinationsTourDestinationId",
                        column: x => x.TourDestinationsTourDestinationId,
                        principalTable: "TourDestination",
                        principalColumn: "TourDestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourDestinationTourGuide_TourGuide_TourGuidesGuideId",
                        column: x => x.TourGuidesGuideId,
                        principalTable: "TourGuide",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "AboutId", "Content" },
                values: new object[] { 1, "<p>Du lịch nông nghiệp kết hợp với sản phẩm OCOP tại Việt Nam thường được triển khai một cách riêng biệt, thiếu sự liên kết chặt chẽ giữa các điểm đến du lịch, các cơ sở sản xuất nông sản và các công ty du lịch. Sự thiếu kết nối này dẫn đến khó khăn cho khách hàng trong việc tìm kiếm thông tin về sản phẩm OCOP và các điểm đến du lịch nông nghiệp. Các cơ sở sản xuất nông sản không có một hệ thống chung để giới thiệu sản phẩm của mình, trong khi các công ty du lịch thiếu thông tin cụ thể về các sản phẩm địa phương đặc trưng mà họ có thể đưa vào các tour du lịch của mình. Điều này khiến khách hàng khó khăn trong việc tìm hiểu và lựa chọn điểm đến, từ đó làm giảm sức hấp dẫn của các tour du lịch nông nghiệp và hạn chế khả năng quảng bá sản phẩm OCOP.</p>\r\n\r\n        <p>Thêm vào đó, mặc dù sản phẩm OCOP đã đạt tiêu chuẩn chất lượng, nhưng hệ thống phân phối các sản phẩm này, đặc biệt trên các nền tảng kỹ thuật số, vẫn còn nhiều hạn chế. Sản phẩm OCOP chủ yếu được phân phối qua các kênh truyền thống hoặc chợ địa phương, trong khi các nền tảng thương mại điện tử chưa thực sự phát triển mạnh mẽ đối với các sản phẩm này. Điều này không chỉ gây khó khăn trong việc tiếp cận thị trường trong nước mà còn hạn chế khả năng tiếp cận thị trường quốc tế, nơi mà người tiêu dùng ngày càng ưa chuộng mua sắm trực tuyến. Việc thiếu các kênh phân phối kỹ thuật số và chiến lược marketing hiệu quả khiến sản phẩm OCOP không phát triển mạnh mẽ, đồng thời giảm cơ hội mở rộng ra các thị trường tiềm năng, đặc biệt là khách quốc tế.</p>\r\n\r\n        <p>Để giải quyết những khó khăn này, một hệ thống nền tảng tích hợp giữa quản lý du lịch nông nghiệp và kinh doanh sản phẩm OCOP đã được đề xuất. Nền tảng này được thiết kế dưới dạng ứng dụng web và di động, tập trung vào việc tạo ra sự kết nối chặt chẽ giữa các liên kết nội bộ: các công ty du lịch, chủ sở hữu cơ sở sản xuất nông sản, du khách và các cơ quan quản lý địa phương. Với việc ra mắt nền tảng kỹ thuật số này, những khó khăn hiện tại sẽ được giải quyết một cách hiệu quả. Sự kết nối giữa các bên không chỉ tạo điều kiện để nâng cao trải nghiệm du lịch mà còn cung cấp tiêu thụ sản phẩm OCOP, tăng thu nhập cho người dân địa phương. Đồng thời, hệ thống sẽ đóng góp vào sự phát triển bền vững của các công ty du lịch nông nghiệp, giúp tăng giá trị sản phẩm OCOP và cải thiện nền kinh tế nông thôn tại Việt Nam.</p>\r\n    " });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[,]
                {
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "173be822-ebea-4450-bdac-abe80caff680", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAEMGwW+j7B4Q9LQYGwZb/RC6kw287RIo0H48UbgHP4iqpXU8O1rgQqZ+NDL33udyAGw==", null, false, "fa744afa-2c7d-4873-81ac-9b4ca0d36f32", false, "TourismCompanies", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "78723d35-9938-473f-8dfd-ba30cd10768c", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEDWoBK9mrVzI0W2/ZRty8/PUnbLvEFdKNwvfkQRfw3T6w9QjChChEk83u5J8oiOX0g==", null, false, "f3142731-ec1d-4974-bd8b-84aaf338914a", false, "ContentModerators", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0, "https://example.com/avatar1.jpg", "c5991262-3229-4401-90e3-008bc04c8b5d", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", true, "John Doe", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEIctrHH8fpfPATsdbyOKYVbzGRLuN4rTlBGWM6jWm++uln9UclVPyPd5KAsxTLtStw==", null, false, "ff4f8030-0a6b-466a-88c7-4f80b76ed095", false, "JohnDoe", true },
                    { new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), 0, null, "17967978-5e10-4617-9ceb-ea71ce4b9ff4", null, "contact@bambotravel.com", true, "Bamboo Travel", null, false, null, "CONTACT@BAMBOOTRAVEL.COM", "BAMBOOTRAVELACCOUNT", "AQAAAAIAAYagAAAAENa0VZhceKdGvGn4NVvOZxi0AH1azhfCbskxYtlIdxbHO7E40kpxMxXGExtrvOut1w==", null, false, "98a2c910-de9b-449a-b941-2548a3b18dd6", false, "BambooTravelAccount", true },
                    { new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), 0, null, "f737ec97-e748-4dd6-85d3-3d165ab9362b", null, "info@phuongnamtravel.com", true, "Phương Nam Travel", null, false, null, "INFO@PHUONGNAMTRAVEL.COM", "PHUONGNAMTRAVELACCOUNT", "AQAAAAIAAYagAAAAEKSqoKfKMRtFgoDS1t1RCJi3CyTA4feQcSLufFyYASzWhG2kndlCbEQe+ycPCfVYzQ==", null, false, "53f96886-150d-4f43-8a60-d3ebb0b2663d", false, "PhuongNamTravelAccount", true },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0, "https://example.com/avatar2.jpg", "8916772d-c45d-4108-b436-af3abef07098", new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmawatson@example.com", true, "Emma Watson", false, false, null, "EMMAWATSON@EXAMPLE.COM", "EMMAWATSON", "AQAAAAIAAYagAAAAEE55u9tIbNhqjBHmXavTr6dGSKDqSnBeAy79GbBxgM1xvJNgTO2Gq8B8tfD272eBpg==", null, false, "298a10f1-fa67-4a5a-9620-81569cfed0da", false, "EmmaWatson", true },
                    { new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), 0, null, "f246e0fe-397c-4d47-8c4e-73e9a7cc5a04", null, "support@nhatrangholiday.com", true, "Nha Trang Holiday", null, false, null, "SUPPORT@NHATRANGHOLIDAY.COM", "NHATRANGHOLIDAYACCOUNT", "AQAAAAIAAYagAAAAEFVA12TcTWNsiv0Dc5WxG88M3/yYIYDIXI0ryCr9NguQPM44delee+vAVpuSZX821g==", null, false, "d92d40de-ec12-4277-8654-caa1ca1c119b", false, "NhaTrangHolidayAccount", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "4d1b16a6-d020-4dc8-8e4a-725096c4d06b", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAEAITUxNZV0zw3GcFDuzTQzoaeHQtNIDIAJ2Px/eNyMtRcsFCV33v+ra0NmBW5WIXig==", null, false, "5b5f67c9-7d1e-47cb-ac73-a011e114d6fd", false, "TourGuides", true },
                    { new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), 0, null, "22ba9787-c051-439a-b7b3-1b92f5392517", null, "support@hanoitourist.com", true, "Hanoitourist", null, false, null, "SUPPORT@HANOITOURIST.COM", "HANOITOURISTACCOUNT", "AQAAAAIAAYagAAAAEInkZtelF797PdrkIylY89bvI76L3ldCRmWWeYG1i1C75NnCnls03U17O/xzHI+UHA==", null, false, "449c1ff2-43e7-4d2b-ba80-239c738d48c6", false, "HanoitouristAccount", true },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 0, "https://example.com/avatar3.jpg", "b8c81651-20c8-4585-919b-bc5317364598", new DateTime(1985, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelbrown@example.com", true, "Michael Brown", true, false, null, "MICHAELBROWN@EXAMPLE.COM", "MICHAELBROWN", "AQAAAAIAAYagAAAAEJQJzbjLl8Vbq8Qv/DVGXWLRpRzGmSy35PgzynsZxDHG9Bf8/UECcjy5ahlrmfMnFQ==", null, false, "5461991b-6621-4b1b-a40c-057a6e19731d", false, "MichaelBrown", true },
                    { new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), 0, null, "ea1c5414-372a-4bed-a32b-6d4918f828cb", null, "contact@phanthiettours.com", true, "Phan Thiết Tours", null, false, null, "CONTACT@PHANTHIETTOURS.COM", "PHANTHIETTOURSACCOUNT", "AQAAAAIAAYagAAAAEE4gUQqZmiQTCG6yk8jIUFXEX+hLOt2xLNZjtzRTVewQxMEBCBcPxMZmip5HgZ12zQ==", null, false, "7514754f-94aa-40da-ba69-520b52a8f503", false, "PhanThietToursAccount", true },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), 0, "https://example.com/avatar8.jpg", "3d487fb8-b10c-4b2e-911a-6e58dd09f3a9", new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", true, false, null, "DANIEL.MARTINEZ@EXAMPLE.COM", "DANIELMARTINEZ", "AQAAAAIAAYagAAAAEPVA8g8DRUOn3osJ+hJ3BpBvGHLVISBohNwJVAp5kxRJfbvbuyFtG1Vw47TxycCwvA==", null, false, "91e7cb41-f3ff-4756-aa4a-2285a7b0b471", false, "DanielMartinez", true },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 0, "https://example.com/avatar4.jpg", "db49cff2-4235-48d4-93b8-46708f758de2", new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophialee@example.com", true, "Sophia Lee", false, false, null, "SOPHIALEE@EXAMPLE.COM", "SOPHIALEE", "AQAAAAIAAYagAAAAEHK/F5hdvwW1+d4Dlb/nCB4OKRqf7L97PFUnN/pziOtRkhIp/YfBHhrhlL1+fzXZCA==", null, false, "1f3a97b8-58d9-4e91-97dd-7c082f524307", false, "SophiaLee", true },
                    { new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), 0, null, "11bdb5ea-0418-42d6-8078-0e5a0072499a", null, "info@redtour.com.vn", true, "Redtour", null, false, null, "INFO@REDTOUR.COM.VN", "REDTOURACCOUNT", "AQAAAAIAAYagAAAAEEQfvExhT3W4MH69Vk2+fhsUumUUzaWomFw2vaP0DBGZFQkOOk6a/2f0L3mthRJhTA==", null, false, "7bac27bf-8de1-4e4f-ac22-2cab6117fca3", false, "RedtourAccount", true },
                    { new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), 0, "https://example.com/avatar9.jpg", "1e8f6f2d-762d-4840-994d-7586e1f7c27c", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilyclark@example.com", true, "Emily Clark", false, false, null, "EMILYCLARK@EXAMPLE.COM", "EMILYCLARK", "AQAAAAIAAYagAAAAEHlxJXaBmAk8li74VZHmfWSg0sd6dl1WJKZ1zMIrTjiOjtEWDjryJXpd3pWB9pcbTA==", null, false, "29d88921-9fc1-414e-ab3a-c0a0fab9a52e", false, "EmilyClark", true },
                    { new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), 0, null, "366803ce-998e-4bef-9456-fd4021bfaad7", null, "contact@quynhonexplorer.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@QUYNHONEXPLORER.COM", "QUYNHONEXPLORERACCOUNT", "AQAAAAIAAYagAAAAEKENL4PQFbERs3oIf8jkm7llul27WcNp4JfDAEvmPbBMMTZIhgjFkrMKw9VJ5S6wfg==", null, false, "d8e33d5d-b3f1-465d-8f20-bd51c9ac4d4a", false, "QuyNhonExplorerAccount", true },
                    { new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), 0, null, "81cfe9dd-13dc-4dbf-b68f-3cd6387cb3f1", null, "contact@datviettour.com", true, "Đất Việt Tour", null, false, null, "CONTACT@DATVIETTOUR.COM", "DATVIETTOURACCOUNT", "AQAAAAIAAYagAAAAEA4uxI8lFbN777IxvAqIUMLYahVH9edXFlL2JmkJ8LkPdQVQDeJRH3Xyr7hRkMDstg==", null, false, "9425e8e5-6a45-422b-8b09-bcca19e31931", false, "DatVietTourAccount", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "80e60fb6-b64d-493c-9c57-d7771019ae2f", null, "thutt170727@gmail.com", true, "Agricultural Tourism Facility Owners", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAEPwxKXGhoU3hzr2PUrbUtWbRikuxH9WqIdqHFvSW2DvHgvY642v7uI2xsKgsgtvDag==", null, false, "fdabecff-6d4e-4aea-aba9-34bd4893bbce", false, "ATFO", true },
                    { new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), 0, null, "839c352e-17b0-400b-ac77-b522fa1c64e1", null, "contact@vietsuntravel.com", true, "VietSun Travel", null, false, null, "CONTACT@VIETSUNTRAVEL.COM", "VIETSUNTRAVELACCOUNT", "AQAAAAIAAYagAAAAEL5G/74RLO8yhxckz2BcM9MzGZyrhzBkSkQBWkqY5FaA1wizk5ztPepv88VF6gJqtw==", null, false, "3b706ea4-f0f5-413f-96fe-5163a3b5f1dc", false, "VietSunTravelAccount", true },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "https://example.com/avatar5.jpg", "bad10bd4-94a7-4e87-a904-523d867886a8", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", true, "David Johnson", true, false, null, "DAVIDJOHNSON@EXAMPLE.COM", "DAVIDJOHNSON", "AQAAAAIAAYagAAAAELNyDRlgFsuPC6Z3cPAtWfcPj4gQu87w0EUfaI5YkFxMVjZxoJi5geW5swRleCoEdQ==", null, false, "879d704a-f22a-4e3a-8cf7-5083f608b25f", false, "DavidJohnson", true },
                    { new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), 0, null, "e2db38c3-d2cc-4a42-8586-60b9358b5eab", null, "contact@havatravel.com", true, "Havatravel", null, false, null, "CONTACT@HAVATRAVEL.COM", "HAVATRAVELACCOUNT", "AQAAAAIAAYagAAAAEFGc7UVnpoX2XuhON4haZ1DbvUVQ8WHbZmYvPNfGH4mGU2av7D3s8/sXb6GnDAM0cg==", null, false, "4bd7eb65-a0d5-4f79-b2b9-2a0888a4e79e", false, "HavatravelAccount", true },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "d921bf28-7643-4b41-a4d7-f6574b29ad99", null, "thutt170727@gmail.com", true, "Administrator", null, false, null, "THUTT170727@GMAIL.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAEOWEpzAXr2eB6RoidN3o0f98SyXxpKIiETTMGsWamtS55t0phHR+2z2Y7U6ItXNHDw==", null, false, "aa240f34-6cef-4dc7-bbb3-96f773355659", false, "Administrator", true },
                    { new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), 0, null, "52e462b8-27cc-4d79-910c-08cd4da0e0b2", null, "info@vungtautravel.com", true, "Vũng Tàu Travel", null, false, null, "INFO@VUNGTAUTRAVEL.COM", "VUNGTAUTRAVELACCOUNT", "AQAAAAIAAYagAAAAENZsmUYm3UEeR/+U/4h6fBinPZAnM3PbvToWiv3+74uzExUAp+lXdEuhiDLRy0521w==", null, false, "5beaf66e-305a-4f5b-9e6e-271e1e0a7c58", false, "VungTauTravelAccount", true },
                    { new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), 0, null, "757a78ca-3b0e-430a-91b1-a24183625972", null, "info@dalattour.com", true, "Đà Lạt Tour", null, false, null, "INFO@DALATOUR.COM", "DALATTOURACCOUNT", "AQAAAAIAAYagAAAAEImimm4FlbQ0IwX7c87AD6I8unJK9iEYciZeqRO+QyJvIAvJ/fcOdlhy/IVqhdLfyA==", null, false, "bc8983c5-e533-46f6-ae11-7350ba780316", false, "DalatTourAccount", true },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0, "https://example.com/avatar6.jpg", "5264751c-2ac7-43fb-922f-8baf03668317", new DateTime(1987, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "liamnguyen@example.com", true, "Liam Nguyen", true, false, null, "LIAMNGUYEN@EXAMPLE.COM", "LIAMNGUYEN", "AQAAAAIAAYagAAAAEAUYivk0gGbrfXlr+xmW+o9VvGWXdyxi9phxbSOMzRCBSmtp9XL4YfpaQs5qWlupiA==", null, false, "b58303ab-2437-47e3-ae76-b11ddb780882", false, "LiamNguyen", true },
                    { new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), 0, null, "e30e58c0-749d-432a-8b5d-aced6f8c5ae9", null, "info@danangtravel.com", true, "Danang Travel", null, false, null, "INFO@DANANGTRAVEL.COM", "DANANGTRAVELACCOUNT", "AQAAAAIAAYagAAAAEIvH7tBZUywCjWLms15hgecsdRVyGWxpWilF13xNhNi9jiZh9rtNcOhSh8GIbywHZA==", null, false, "d8e00974-6a78-42ce-935b-251160853af2", false, "DanangTravelAccount", true },
                    { new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), 0, null, "74b3e239-13b9-4714-bc8a-a08f013b89d4", null, "contact@saigontourist.net", true, "Saigontourist", null, false, null, "CONTACT@SAIGONTOURIST.NET", "SAIGONTOURISTACCOUNT", "AQAAAAIAAYagAAAAENUIth7v3KRzKh5c6OEvZYoPnAV7375oRu+BATbFl4TwaoxHiI6OJpghLU5VzOrajA==", null, false, "290160cd-b686-4530-bcbe-d04db7da98ee", false, "SaigontouristAccount", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "b403897d-39ab-498d-a374-bfe2c9fe8ad8", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAEO2jo0SWboTvBmI3cJlwCK49I0KLAzwRVXeznCgREC68qATqNKLl97gh4sYCb4RLrA==", null, false, "1946e1e3-cede-4387-b307-0f2815b46f42", false, "Tourists", true },
                    { new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), 0, null, "f5c44168-9757-4eb9-ad47-6023f6c08db1", null, "support@dulichtoday.com", true, "Dulich Today", null, false, null, "SUPPORT@DULICHTODAY.COM", "DULICHTODAYACCOUNT", "AQAAAAIAAYagAAAAEN3viPLqyPx8htpzlJqNyp/c4E10neyzDcg9+SjHYi3qA6817DkPHcwBfRXoAcOWgw==", null, false, "f4fe190b-d6e3-4dc9-9fd9-2a6e044ea957", false, "DulichTodayAccount", true },
                    { new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), 0, null, "2ae477da-cd65-4245-a3c4-7945bf4caf12", null, "info@fiditour.com", true, "Fiditour", null, false, null, "INFO@FIDITOUR.COM", "FIDITOURACCOUNT", "AQAAAAIAAYagAAAAEH3BxZiqMsWj2m7F2C1vnlLsiiZGK7+fzwi0t9pXfWIno0hrwfwgZBkY6cSWZjsytw==", null, false, "b741a8e9-f323-41ac-9e7f-67dc847441d1", false, "FiditourAccount", true },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 0, "https://example.com/avatar7.jpg", "02a4d4be-70a5-464f-bb06-a6a7202b437a", new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviakim@example.com", true, "Olivia Kim", false, false, null, "OLIVIAKIM@EXAMPLE.COM", "OLIVIAKIM", "AQAAAAIAAYagAAAAENuGXau+ZhW2wzhU0tzoGGCVonjqEFbtawWBQEZmbA/pflMjzcMezmUp9FVQd2yh9A==", null, false, "9b73e10f-f8b8-42e7-b7a2-9164abaf4e0a", false, "OliviaKim", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), null, "ContentModerators", "CONTENTMODERATORS" },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), null, "AgriculturalTourismFacilityOwners", "AGRICULTURALTOURISMFACILITYOWNERS" },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), null, "TourismCompanies", "TOURISMCOMPANIES" },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), null, "TourGuides", "TOURGUIDES" },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), null, "Admin", "ADMIN" },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), null, "Tourists", "TOURISTS" }
                });

            migrationBuilder.InsertData(
                table: "SystemConfigurations",
                columns: new[] { "ConfigId", "ConfigKey", "ConfigType", "ConfigValue", "CreateDate", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "SmtpServer", 0, "smtp.gmail.com", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2563), null },
                    { 2, "Port", 0, "587", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2566), null },
                    { 3, "Email", 0, "thangnvse151059@fpt.edu.vn", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2569), null },
                    { 4, "AppPassword", 0, "sllgcjfbkpgcwnmp", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2572), null },
                    { 5, "TmnCode", 1, "7S4BSWDD", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2575), null },
                    { 6, "HashSecret", 1, "RC7QASGETNFSP0EDKUE4IT7X6VRKM4NJ", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2578), null },
                    { 7, "Url", 1, "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2581), null },
                    { 8, "Command", 1, "pay", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2584), null },
                    { 9, "CurrCode", 1, "VND", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2587), null },
                    { 10, "Version", 1, "2.1.0", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2912), null },
                    { 11, "Locale", 1, "vn", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2916), null },
                    { 12, "PaymentBackReturnUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2947), null }
                });

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("09e000ab-c012-4425-aae3-f37494ff7340"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2077), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("22d05b91-7515-428d-9968-eb95546e7ec4"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2122), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("29857ed2-0291-444a-9d2a-d20b12a6e29b"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2113), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("29c87374-19b3-46fb-841c-6a63f3e36ad0"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2083), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("3f5500d6-db08-458d-b2c7-51221b25f092"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2098), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("5e527cba-ac13-4308-9928-b952bde4f2b2"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2088), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("7c80dc2a-0943-4681-8b05-2463f29d7cb9"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2030), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("7e3320a4-6da0-4c52-9803-ec47dfa47f32"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2108), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("8fee14e6-e5b9-47c7-8707-e4d99f5d4d18"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2093), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("b61512ca-e48c-4ece-afba-45ac12bcd828"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2132), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("c3759e3b-376c-4bd5-97d4-57149c0ada21"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2127), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("ea62e038-44eb-47a6-8fc1-5ebd89542d1a"), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(2103), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8404), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8398), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("d549690a-59da-4c91-8179-7ba2102800e2"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8366), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("1a92b086-854b-4dda-b9f0-c8dc7673ba3c"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("4b4bcaa0-28ea-490b-b72a-ee7edaac141f"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("651d185f-2f5b-4f38-a049-0004c4b3f49b"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("8a288284-9c19-4678-8992-a7f304d657a8"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("909d22f0-5d09-486f-9db4-593fa44b4830"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("9b45d882-47f1-491d-aad8-064678b761bb"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("b446f5b2-7129-4622-99c1-9cfb275daef9"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("bb06cccb-ecbd-417a-8c64-091c8c6de0e4"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("d1e57789-a119-477f-b0e7-2ca8f9f1c035"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("e7019fb1-1632-4a23-9cc4-879a0c531e01"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("fa86db16-9b28-4131-82ff-af41f283b191"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("fc51c193-0bb4-4208-a43c-97cdafb329d3"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null }
                });

            migrationBuilder.InsertData(
                table: "TourCompany",
                columns: new[] { "TourCompanyId", "AddressCompany", "CompanyDescription", "CompanynName", "CreateDate", "EmailCompany", "LogoURL", "UpdateTime", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), "120 Phan Chu Trinh, TP.Huế", "Công ty du lịch chuyên nghiệp tại Huế.", "Havatravel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8125), "contact@havatravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), "https://havatravel.com/" },
                    { new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), "45 Điện Biên Phủ, Quận 3, TP.HCM", "Chuyên tour du lịch nội địa và quốc tế.", "VietSun Travel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8086), "contact@vietsuntravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), "https://vietsuntravel.com/" },
                    { new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), "15 Phạm Ngũ Lão, Quận 1, TP.HCM", "Dịch vụ du lịch cao cấp.", "Bamboo Travel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8093), "contact@bambotravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), "https://bambotravel.com/" },
                    { new Guid("22275542-0625-47be-a503-2f13b7576e9b"), "23 Lê Lợi, TP. Phan Thiết", "Chuyên tour khám phá biển và cát trắng.", "Phan Thiết Tours", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8141), "contact@phanthiettours.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), "https://phanthiettours.com/" },
                    { new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), "50 Nguyễn Trãi, TP. Vũng Tàu", "Tour du lịch biển chất lượng cao.", "Vũng Tàu Travel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8130), "info@vungtautravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), "https://vungtautravel.com/" },
                    { new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), "90 Nguyễn Văn Linh, Đà Nẵng", "Thông tin và tổ chức tour du lịch.", "Dulichtoday", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8118), "support@dulichtoday.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), "https://dulichtoday.com/" },
                    { new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), "75 Hùng Vương, TP. Nha Trang", "Dịch vụ đặt tour du lịch biển chuyên nghiệp.", "Nha Trang Holiday", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8136), "support@nhatrangholiday.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), "https://nhatrangholiday.com/" },
                    { new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), "15 Lê Lợi, Quận 1, TP.HCM", "Tour trọn gói, uy tín.", "Fiditour", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8071), "info@fiditour.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), "https://fiditour.com/" },
                    { new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), "99 Hoàng Diệu, Ba Đình, Hà Nội", "Du lịch chất lượng, giá rẻ.", "Phương Nam Travel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8099), "info@phuongnamtravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), "https://phuongnamtravel.com/" },
                    { new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), "10 Lê Thánh Tôn, Quận 1, TP.HCM", "Chuyên tổ chức tour du lịch trong và ngoài nước.", "Đất Việt Tour", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8105), "contact@datviettour.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), "https://datviettour.com/" },
                    { new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), "20 Trần Hưng Đạo, Hà Nội", "Dịch vụ du lịch chất lượng cao.", "Redtour", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8112), "info@redtour.com.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), "https://redtour.com.vn/" },
                    { new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), "90 Nguyễn Thị Minh Khai, Đà Nẵng", "Chuyên tour biển đảo Đà Nẵng.", "Danang Travel", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8079), "info@danangtravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), "https://danangtravel.com/" },
                    { new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), "25 Nguyễn Huệ, Quận 1, TP.HCM", "Lữ hành hàng đầu Việt Nam.", "Saigontourist", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8053), "contact@saigontourist.net", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), "https://saigontourist.net/" },
                    { new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"), "66 Trần Phú, TP. Quy Nhơn", "Tour du lịch biển và văn hóa Quy Nhơn.", "Quy Nhơn Explorer", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8154), "contact@quynhonexplorer.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), "https://quynhonexplorer.com/" },
                    { new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"), "14 Nguyễn Huệ, TP. Đà Lạt", "Tour du lịch khám phá Đà Lạt.", "Đà Lạt Tour", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8148), "info@dalattour.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), "https://dalattour.com/" },
                    { new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội", "Tour du lịch nội địa và quốc tế.", "Hanoitourist", new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8065), "support@hanoitourist.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), "https://hanoitourist.com/" },
                    { new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), "03 Hai Bà Trưng, Phường Phan Chu Trinh, Quận Hoàn Kiếm, Hà Nội.", "", "Công ty Cổ phần Vietravel", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "vtv.cholon@vietravel.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Logo%2F1.png?alt=media&token=6c69e085-dfc9-4d14-8f73-ecbcbc7d3fcb", null, new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), "https://travel.com.vn/" }
                });

            migrationBuilder.InsertData(
                table: "TouristFacility",
                columns: new[] { "TouristFacilityId", "Address", "ContactInfor", "CreateDate", "Description", "EmailTouristFacility", "LogoURL", "TouristFacilityName", "UpdateTime", "UserId", "Website", "district_id", "district_name", "phone", "province_name", "ward_code", "ward_name" },
                values: new object[] { new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), "Số 117 đường Hoàng Quốc Việt – TTNT Mộc Châu ( Ngã tư Vườn Đào )", "0946 166 538", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Là công ty trẻ tại Mộc Châu, tiên phong cung cấp những dịch vụ du lịch gắn liền với thiên nhiên, văn hóa các dân tộc Mộc Châu, Vân Hồ.\r\nHiện đang khai thác những tour du lịch khám phá nông nghiệp Mộc Châu, khám phá văn hóa đời sống các dân tộc và các chương trình du lịch thiện nguyện, cắm trại, teambuilding, thể thao, MICE…", " dulichmocchaumoc@gmail.com", "", "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, new Guid("a631bb94-66d8-44db-932b-532892d87754"), "www.mocchaumoc.com", null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d") },
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("46a916db-f0e3-4855-9171-eff063b5cc90") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("a631bb94-66d8-44db-932b-532892d87754") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("d0e45bee-a768-4555-bfeb-788728a53751") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8447), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8450), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"), "anhNv@gmail.com", "Nguyễn Văn Anh", true, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8410), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8416), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8465), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8468), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8456), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8459), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"), "BinhLeV@gmail.com", "Lê Văn Bình", true, 3, new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8427), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8431), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Accommodation",
                columns: new[] { "AccommodationId", "AccommodationDescription", "AccommodationName", "Address", "Imgs", "PhoneNumber", "Star", "TourCompanyId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Khách sạn 5 sao với dịch vụ cao cấp.", "Khách sạn Hoàng Gia", "Số 123, Đường Trần Phú, Hà Nội", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0987654321", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Resort ven biển với view đẹp và hồ bơi lớn.", "Resort Biển Xanh", "Số 456, Đường Biển Đông, Đà Nẵng", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0978543210", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Nhà nghỉ bình dân, giá rẻ, sạch sẽ.", "Nhà nghỉ Hoa Hồng", "Số 789, Đường Nguyễn Trãi, TP Hồ Chí Minh", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0967452103", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Khách sạn có view toàn cảnh thành phố.", "Khách sạn Thiên Đường", "Số 101, Đường Lê Lợi, Huế", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0956328745", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Villa yên tĩnh, phù hợp nghỉ dưỡng.", "Villa Sông Hồng", "Số 202, Đường Bờ Sông, Hải Phòng", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0945216987", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Homestay thiên nhiên với vườn cây xanh mát.", "Homestay Vườn Xanh", "Số 303, Đường Lâm Đồng, Đà Lạt", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0934125698", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Khách sạn gần biển, có hồ bơi riêng.", "Khách sạn Mặt Trời", "Số 404, Đường Võ Nguyên Giáp, Nha Trang", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0923546987", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Nhà nghỉ giá rẻ, gần trung tâm.", "Nhà nghỉ An Bình", "Số 505, Đường Nguyễn Văn Cừ, Cần Thơ", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0912564873", 2, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Resort giữa thiên nhiên, hòa mình với cây cỏ.", "Resort Thiên Nhiên", "Số 606, Đường Xanh, Phú Quốc", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0901254789", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Khách sạn trung tâm, giá hợp lý.", "Khách sạn Thành Đạt", "Số 707, Đường Lý Thường Kiệt, Quảng Ninh", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0896541237", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") }
                });

            migrationBuilder.InsertData(
                table: "AgriculturalTourPackage",
                columns: new[] { "TourId", "CreateDate", "Description", "Durations", "DurationsType", "EndTime", "Imgs", "PackageName", "Price", "Slot", "StartTime", "StatusActive", "TourCompanyId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6680), "Tham gia hành trình khám phá đại dương với hoạt động lặn ngắm san hô tại Hòn Thơm, kết hợp tham quan làng chài Rạch Vẹm - nơi nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.", 8.0, 2, new DateTime(2024, 9, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám phá đại dương & làng chài Phú Quốc", 1500000.0, 20, new DateTime(2024, 9, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6604), "Tận hưởng kỳ nghỉ thú vị với hoạt động tắm biển tại Bãi Cháy, Quảng Ninh.", 2.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Gói Tắm Biển Bãi Cháy", 800000.0, 30, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6584), "Trải nghiệm tuyệt vời tại Hang Sửng Sốt - một trong những hang động đẹp nhất Hạ Long.", 2.5, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Gói Khám Phá Hang Sửng Sốt", 1200000.0, 20, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6628), "Trải nghiệm không gian lung linh của phố cổ Hội An về đêm với hàng trăm chiếc đèn lồng rực rỡ.", 3.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám Phá Hội An Về Đêm", 900000.0, 30, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6616), "Hành trình khám phá Bà Nà Hills, trải nghiệm cáp treo và tham quan Cầu Vàng.", 4.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Gói Tham Quan Bà Nà Hills", 1200000.0, 25, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("d470cefb-e618-420f-a399-31bbe277596e"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6668), "Trải nghiệm lặn biển ngắm san hô tại Hòn Thơm, tận hưởng làn nước trong xanh và hệ sinh thái đa dạng dưới đáy biển.", 3.5, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám phá đại dương Phú Quốc", 950000.0, 15, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6659), "Tham quan chợ nổi Cái Răng vào buổi sáng, khám phá vườn trái cây buổi chiều. Trải nghiệm cuộc sống dân dã miền Tây và thưởng thức trái cây tươi ngon.", 8.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Trải nghiệm miền Tây sông nước", 950000.0, 20, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6638), "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ, tận hưởng khung cảnh tuyệt đẹp của Sapa.", 6.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Chinh Phục Fansipan", 1200000.0, 25, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6648), "Khám phá nét văn hóa miền Tây sông nước với chợ nổi Cái Răng vào sáng sớm. Thưởng thức các món ăn đặc sản trên thuyền và giao lưu với người dân địa phương.", 3.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Trải nghiệm chợ nổi Cái Răng", 750000.0, 20, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("624a2f35-9027-4621-a71f-9745472247fb"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(5004), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(5000), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4999), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a91a077b-079b-4e67-8006-bbe82812d0f4"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4994), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4992), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4991), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "DriverId", "DriverName", "Imgs", "PhoneNumber", "TourCompanyId", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Nguyễn Văn A", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0987654321", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Trần Văn B", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0978543210", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 1 },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Phạm Văn C", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0967452103", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 2 },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Lê Thị D", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0956328745", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 3 },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Hoàng Văn E", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0945216987", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 4 },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Đỗ Thị F", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0934125698", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 5 },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Ngô Văn G", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0923546987", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 6 },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bùi Văn H", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0912564873", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 7 },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Vũ Thị I", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0901254789", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Dương Văn J", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0896541237", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 1 },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Phan Thị K", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0889652314", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 2 },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Lý Văn L", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0871236549", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 3 },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Trịnh Văn M", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0867412365", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 4 },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Nguyễn Thị N", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0859632147", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 5 },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Lê Văn O", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0847125639", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 6 },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Võ Văn P", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0836547891", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 7 },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Trần Văn Q", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]", "0825478963", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Additional", "AddressManufacturer", "Age", "CreateDate", "Description", "Imgs", "Ingredient", "Manufacturer", "NutritionType", "Origin", "Price", "ProductCategory", "ProductName", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UnitProduct", "UpdateDate", "Volume" },
                values: new object[,]
                {
                    { new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3456), "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media\\u0026token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media\\u0026token=bad36b93-8f59-4463-8622-b0a7ea89821e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media\\u0026token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media\\u0026token=7c347385-45bd-474f-9930-77dca305655c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media\\u0026token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media\\u0026token=d3542914-5791-4d36-95a6-071e554aa407\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media\\u0026token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 0, "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3576), "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F71.png?alt=media\\u0026token=e0442041-c3de-4760-9c8e-63d59580a5be\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F73.webp?alt=media\\u0026token=98568704-49be-4377-beb7-5598f453c2b4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media\\u0026token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media\\u0026token=13fdd758-187b-44b8-9b9f-e9fb47148524\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media\\u0026token=be498a71-dc12-42a0-bebd-844b732aa1c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media\\u0026token=41f13948-a8de-49ff-88d4-a37b46dd87b8\"]", "Tía tô, cỏ ngọt", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "150g" },
                    { new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3591), "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F81.mp4?alt=media\\u0026token=1361932f-6380-4f8f-a8d1-31881efc4ebf\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media\\u0026token=b855f4ab-4b51-43ea-af26-e0deb629f97c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media\\u0026token=15012cad-7f6f-4cae-842c-c1e8e35d0c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media\\u0026token=0576465d-964e-4ffc-93fa-54f410c761e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media\\u0026token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media\\u0026token=521f7498-9a95-424e-884b-72b611b6f0ee\"]", "Trầm hương, Bột Trầm Hương", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 6, "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 0, null, "1kg" },
                    { new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Trà túi lọc & lá trà", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3524), "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media\\u0026token=5218426e-19ff-4feb-b968-93e08e7f6c92\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media\\u0026token=65af2dec-b460-4f5c-8c4b-8c76b6581a83\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media\\u0026token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media\\u0026token=94412ff3-d1eb-427a-8114-3290d62edd31\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media\\u0026token=1cade255-31ff-4248-ac2f-0f2f8513b33c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media\\u0026token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media\\u0026token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media\\u0026token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53\"]", "Trà xanh, Khác", "Xưởng Mộc Việt", "Truyền thống", "Việt Nam", 80000.0, 1, "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null, null, "10 bông" },
                    { new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3476), "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F3-1.mp4?alt=media\\u0026token=37fe4454-a6ed-4f76-a68e-784edb1b2089\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media\\u0026token=1b2c7198-56da-46dc-bef8-c1371e4bbd16\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media\\u0026token=feac05a6-f278-4bae-85ab-4a9453decd2a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media\\u0026token=153f06d6-d1ee-4781-a17a-b43c0028fbea\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media\\u0026token=0cf39ab3-b794-4d99-90a6-4d4026b690d8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media\\u0026token=0f2875bb-7146-4a3d-8774-d449d78a925a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media\\u0026token=4ef86b59-4468-4e52-af69-5084c99281c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media\\u0026token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media\\u0026token=1c52bcc3-1800-4c86-a874-842c62dca2af\"]", "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU", "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 0, "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "750g" },
                    { new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3561), "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F61.mp4?alt=media\\u0026token=9fde074e-3db4-4035-9816-923ff1caef9b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media\\u0026token=5e7d93e8-e10e-47e1-be82-573a9436bdca\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media\\u0026token=7b8fd32b-486b-4fec-bb89-ec59959708d0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media\\u0026token=d7b0593b-a8a7-44de-917a-35e3699f5cd1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media\\u0026token=daa304f2-2707-486e-862e-e39f5aff3c25\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media\\u0026token=e9b4469d-a2c9-458a-ba20-e2968a4db706\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media\\u0026token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce\"]", null, "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 1, "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "750ml" },
                    { new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", "Người lớn", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3413), "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51c69bc2dd52e99cedbea5ae436d8172.mp4?alt=media\\u0026token=0321ec29-4610-42b8-a908-44fb85efbac1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media\\u0026token=8df7ec0c-528c-4420-b9d8-1aa642cf458b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media\\u0026token=e4a624c3-296d-4553-812e-c17832510225\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media\\u0026token=b6600b96-94ef-473e-ba86-72a4f5568635\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media\\u0026token=2df35c4e-8b69-4210-80f3-58f6dee45ac5\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\"]", "Tinh bột nghệ, Mật ong nguyên chất", "Xưởng Mộc Việt", "Nghệ", "Việt Nam", 80000.0, 2, "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500ml" },
                    { new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3498), "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F41.png?alt=media\\u0026token=a06f9212-5073-41f6-9cc9-79311b9eb056\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media\\u0026token=fb9ba94c-fdec-47fb-b782-f145d2b611e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media\\u0026token=4b849fd1-6be9-4fa5-846c-c1865071899d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media\\u0026token=d50897e6-af7d-47bd-bc4b-e8e196dd65af\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media\\u0026token=facf05b2-93fb-4519-b412-b73961492d1f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media\\u0026token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media\\u0026token=47195d9c-a6f1-4416-a67b-cae2ba719f10\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media\\u0026token=5a284068-ab8c-486e-a50a-407e1ed4489d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media\\u0026token=a0c04528-e4db-427c-984d-f1ef780fd838\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourGuide",
                columns: new[] { "GuideId", "Bio", "CreateDate", "ExpertiseArea", "Languages", "Rating", "TourCompanyId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Expert in eco-tourism with 5 years of experience.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6801), "Eco-farming, fruit orchards", "English, French", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Specialist in sustainable agriculture tours.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6812), "Tea plantations, organic farming", "English, Spanish", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6813), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Guided over 200 eco-tours with top reviews.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6825), "Mountain trekking, herbal farming", "English, Vietnamese", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Passionate about agritourism and cultural exchange.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6835), "Coffee plantations, farm stays", "English, German", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "10 years of experience in eco-tourism industry.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6843), "Rice farming, eco-tourism", "English, Chinese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "An expert in organic farming and sustainable tourism.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6851), "Tea plantations, eco-farms", "English, Korean", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6852), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Combining tourism and local culture for unique experiences.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6861), "Cultural farming, organic coffee", "English, Japanese", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bringing sustainable travel to the next level.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6868), "Tropical fruit farms, eco-friendly tours", "English, Thai", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6869), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Guiding farm tours with an educational approach.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6877), "Dairy farming, vineyard tours", "English, Portuguese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Committed to authentic rural tourism experiences.", new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6887), "Olive farming, agritourism", "English, Italian", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6888), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") }
                });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), new DateTime(2025, 3, 27, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5231), "Tour 4 ngày 3 đêm tận hưởng vẻ đẹp của bãi biển Phú Quốc, lặn san hô, thưởng thức hải sản.", 4.0, 2, "Du lịch Phú Quốc - Thiên đường biển đảo", 7000000.0, "", 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), new DateTime(2025, 4, 4, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5233) },
                    { new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5184), "Tour du lịch Hạ Long 3 ngày 2 đêm với nhiều hoạt động thú vị.", 3.0, 2, "Hành trình khám phá Hạ Long", 3500000.0, null, 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5196), "Tour 4 ngày 3 đêm tham quan các điểm nổi bật như Bà Nà Hills, Hội An.", 4.0, 2, "Trải nghiệm du lịch Đà Nẵng", 5000000.0, "", 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5204), "Tour khám phá Sapa, Mộc Châu 5 ngày 4 đêm, thích hợp cho người yêu thiên nhiên.", 5.0, 2, "Khám phá vùng Tây Bắc", 6000000.0, "Chưa đáp ứng yêu cầu về an toàn.", 2, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5205) },
                    { new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), new DateTime(2025, 4, 1, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5214), "Tour 3 ngày 2 đêm khám phá chợ nổi Cái Răng, vườn trái cây, và cuộc sống người dân.", 3.0, 2, "Trải nghiệm miền Tây sông nước", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), "Khám phá chợ nổi Cái Răng", 15.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5438), "Trải nghiệm chợ nổi Cái Răng vào buổi sáng, thưởng thức các món ăn đặc sản trên thuyền.", 3.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Cần Thơ", new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), null, 0, null },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), "Tham quan vườn trái cây", 10.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5449), "Tận hưởng không gian xanh mát, thưởng thức trái cây tươi ngay tại vườn.", 2.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Vĩnh Long", new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), null, 0, null },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), "Tắm biển tại Bãi Cháy", 10.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5394), "Thư giãn và tận hưởng không khí trong lành tại bãi biển nổi tiếng.", 2.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Bãi Cháy, Quảng Ninh", new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"), null, 0, null },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), "Khám phá Hang Sửng Sốt", 15.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5380), "Hành trình khám phá hang động kỳ vĩ nhất Hạ Long.", 2.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Vịnh Hạ Long", new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), null, 0, null },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), "Leo núi Fansipan", 30.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5428), "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ.", 6.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Sapa, Lào Cai", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), "", 1, null },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), "Dạo phố cổ Hội An về đêm", 15.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5418), "Khám phá phố cổ Hội An với hàng trăm chiếc đèn lồng lung linh.", 3.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Hội An, Quảng Nam", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), null, 0, null },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), "Tham quan Bà Nà Hills", 20.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5407), "Trải nghiệm cáp treo, thăm Cầu Vàng và nhiều địa điểm thú vị.", 4.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Đà Nẵng", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), "Cần bổ sung thêm hướng dẫn viên.", 1, null },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), "Lặn ngắm san hô tại Hòn Thơm", 20.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5471), "Lặn biển ngắm san hô, tận hưởng làn nước trong xanh của Phú Quốc.", 3.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Hòn Thơm, Phú Quốc", new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), "Cần xác nhận thời tiết.", 1, null },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), "Khám phá làng chài Rạch Vẹm", 15.0, 2, new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5480), "Tham quan làng chài nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.", 2.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Rạch Vẹm, Phú Quốc", new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1d9efd15-9147-426e-8105-bd8007af1f2d"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4943), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4941), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4940), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3281ec32-01fb-4e5b-9199-acad5418a500"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4971), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4970), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4969), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("34086e48-8544-4db3-8f41-00bd096e808b"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4983), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4982), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4980), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("47a33192-f794-4ae3-9edf-f5a1b6ef25c2"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4930), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4928), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4927), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("59be8ac0-198e-46d0-b3b6-219da0b46528"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4901), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4899), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8246b278-d495-470e-aa39-b509ecb57f01"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4886), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4884), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4882), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("85da839f-dc8b-4821-a991-e635ffc8a8a1"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4959), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4957), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4956), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e7551df2-2a27-46d9-9c3d-67ef17f349c8"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4917), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4915), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4914), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0053d4ea-c514-498f-9506-9c826773c21c"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4658), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("132d31f9-622b-4459-ae39-2b95fadb739c"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4580), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("18304b9a-1fee-40f6-8b3a-83d53d25e86e"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4627), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1f5fc607-7341-4060-8ec7-14eb7dc565e0"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4384), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("2c29ca9f-2698-4342-95b6-499b1185df73"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4642), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("2f375fd1-531f-4376-ad27-9e54656a0ae3"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4166), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("3ba64c12-62e1-4917-b174-64a0e3a44e4b"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4708), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("3d732db2-6ed7-4adb-9983-c6c9ec661833"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4253), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("3f6b459d-a8a0-4395-a326-f76aef9bc0ff"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4400), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("465d4bc6-c22f-44ed-8e70-35eb373fb3db"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4368), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("474c0b87-ffa0-4e1a-b493-0e3c8e59b1b4"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4693), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("4af801fd-e032-4390-b426-ee9d61073027"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4596), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("540f8443-62cb-48d1-b46a-2386197b54b8"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4186), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("5a9662fd-6364-488a-8efe-69cf20ea7d30"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4280), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("5edc6596-c7df-4548-8992-ac7787ab07e1"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4677), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("72f5675d-0535-463f-bdfd-820ed8f7c798"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4297), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("761c6901-07df-488a-bb1b-cf94b184b518"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4352), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("80e48782-9e90-4bef-a7b3-928fb796700c"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4140), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("82b9d6d5-ba69-4bdd-a888-c939407e18a8"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4416), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("86383bcf-8d76-456f-b500-4b9c7ec009c4"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4611), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("8d0272c1-bc01-4f65-b4ee-d1bfd10b1e1e"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4454), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("9a9ba7fa-dd8a-40d9-9b57-aeeaff6e2864"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4432), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("ac0b5154-7f00-4fc0-b28c-37f514bcf2ab"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4204), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("cf6a8b22-a798-4bd3-bc7e-d84f2f5446b5"), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(4560), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000003"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6993), "Khởi hành từ bến cảng nổi tiếng của Hạ Long.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Cảng Tuần Châu", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), 2, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Accommodation_TourCompanyId",
                table: "Accommodation",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_PackageId",
                table: "Activity",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityProduct_ProductId",
                table: "ActivityProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturalTourPackage_TourCompanyId",
                table: "AgriculturalTourPackage",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturalTourPackageTourGuide_TourGuidesGuideId",
                table: "AgriculturalTourPackageTourGuide",
                column: "TourGuidesGuideId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CreateBy",
                table: "Blog",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgriculturalTour_CustomerId",
                table: "BookingAgriculturalTour",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgriculturalTour_TourId",
                table: "BookingAgriculturalTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_ProductId",
                table: "Certification",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_TouristFacilityId",
                table: "Certification",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_TourCompanyId",
                table: "Driver",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OCOPSell_ProductId",
                table: "OCOPSell",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookingId",
                table: "Order",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TouristFacilityId",
                table: "Product",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TourCompany_UserId",
                table: "TourCompany",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_AccommodationId",
                table: "TourDestination",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_ActivityId",
                table: "TourDestination",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_DriverId",
                table: "TourDestination",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_TourId",
                table: "TourDestination",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_TourismPackageId",
                table: "TourDestination",
                column: "TourismPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestinationTourGuide_TourGuidesGuideId",
                table: "TourDestinationTourGuide",
                column: "TourGuidesGuideId");

            migrationBuilder.CreateIndex(
                name: "IX_TourGuide_TourCompanyId",
                table: "TourGuide",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TourGuide_UserId",
                table: "TourGuide",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourismPackage_TourCompanyId",
                table: "TourismPackage",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TourismPackage_TouristFacilityId",
                table: "TourismPackage",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristFacility_UserId",
                table: "TouristFacility",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSupport_ResponeBy",
                table: "UserSupport",
                column: "ResponeBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserSupport_TouristFacilityId",
                table: "UserSupport",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_VNPayPaymentResponse_BookingId",
                table: "VNPayPaymentResponse",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_VNPayPaymentResponse_OrderId",
                table: "VNPayPaymentResponse",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "ActivityProduct");

            migrationBuilder.DropTable(
                name: "AgriculturalTourPackageTourGuide");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Certification");

            migrationBuilder.DropTable(
                name: "OCOPSell");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "SystemConfigurations");

            migrationBuilder.DropTable(
                name: "TourDestinationTourGuide");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserIssue");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserSupport");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VNPayPaymentResponse");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "TourDestination");

            migrationBuilder.DropTable(
                name: "TourGuide");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Accommodation");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "BookingAgriculturalTour");

            migrationBuilder.DropTable(
                name: "TourismPackage");

            migrationBuilder.DropTable(
                name: "AgriculturalTourPackage");

            migrationBuilder.DropTable(
                name: "TouristFacility");

            migrationBuilder.DropTable(
                name: "TourCompany");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
