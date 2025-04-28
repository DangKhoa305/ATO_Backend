using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
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
                name: "BankAccount",
                columns: table => new
                {
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerType = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.BankAccountId);
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
                name: "ShipAddress",
                columns: table => new
                {
                    ShipAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultAddress = table.Column<bool>(type: "bit", nullable: false),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToProvinceId = table.Column<int>(type: "int", nullable: false),
                    ToProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWardCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToDistrictId = table.Column<int>(type: "int", nullable: false),
                    ToDistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipAddress", x => x.ShipAddressId);
                    table.ForeignKey(
                        name: "FK_ShipAddress_Account_AccountId",
                        column: x => x.AccountId,
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
                name: "WithdrawalRequest",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminResponse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_WithdrawalRequest_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    PriceOfAdults = table.Column<double>(type: "float", nullable: false),
                    PriceOfChildren = table.Column<double>(type: "float", nullable: false),
                    ChildTicketAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Contract",
                columns: table => new
                {
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SignedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    RequestReSignContract = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SigningStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contract_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_Contract_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
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
                name: "WithdrawalHistory",
                columns: table => new
                {
                    WithdrawalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WithdrawalStatus = table.Column<int>(type: "int", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalHistory", x => x.WithdrawalId);
                    table.ForeignKey(
                        name: "FK_WithdrawalHistory_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_WithdrawalHistory_TouristFacility_TouristFacilityId",
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
                    NumberOfAdults = table.Column<int>(type: "int", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: true),
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
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_Feedback_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId");
                    table.ForeignKey(
                        name: "FK_Feedback_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
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
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: true),
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
                    ShipAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AdminBalance",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminBalance", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_AdminBalance_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminBalance_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "BookingTourDestination",
                columns: table => new
                {
                    BookingDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookingAgriculturalTourBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTourDestination", x => x.BookingDestinationId);
                    table.ForeignKey(
                        name: "FK_BookingTourDestination_BookingAgriculturalTour_BookingAgriculturalTourBookingId",
                        column: x => x.BookingAgriculturalTourBookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_BookingTourDestination_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingTourDestination_TourDestination_TourDestinationId",
                        column: x => x.TourDestinationId,
                        principalTable: "TourDestination",
                        principalColumn: "TourDestinationId",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "dd9d7be0-8a3f-4405-95ac-c6c408249469", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAEFhYujBbB58qqU43ZYOY/p3RZU1Zzv+yJ+lsrf+HSlAdJMOyXII6gj4whiHVSP7XVQ==", null, false, "09126e0c-c2a6-4f4a-abe2-bc6b332f82f0", false, "TourismCompanies", true },
                    { new Guid("10000000-0000-0000-0000-000000000001"), 0, null, "87cc8186-59c2-4444-a6d0-ab5ad7faabc3", null, "bangiocfarmtour@gmail.com", true, "Du Lịch Sinh Thái Thác Bản Giốc", null, false, null, "bangiocfarmtour@GMAIL.COM", "bangiocfarmtour", "AQAAAAIAAYagAAAAENRsYCbnuOfvNWUgtbUMzeHqYK6OHD7usR7nr9EpM8iy9rhVTOtvcGWWwuY8A3aeXw==", null, false, "e656ac9d-47bb-4cc5-8dfb-42bafd0b670d", false, "bangiocfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 0, null, "d8c96ea3-2500-4d1e-9f46-0993bbd98c5b", null, "sapa@gmail.com", true, "Sa Pa Eco Farm Tour", null, false, null, "sapa@GMAIL.COM", "sapa", "AQAAAAIAAYagAAAAEJekcj0qm6d7alCoxnQkxaYC+8IJZBRDqUIVegtX8ZiNFI4L+gSpOS+owAX+9kpxdw==", null, false, "f32cbf74-4e79-4aed-8466-f3c608da46d7", false, "sapa", true },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 0, null, "781101a0-43a0-4379-91ef-a4327d6f5c6e", null, "grapevalley@gmail.com", true, "Farm Du Lịch Grape Valley", null, false, null, "grapevalley@GMAIL.COM", "grapevalley", "AQAAAAIAAYagAAAAEC2FC9NTQGL+2oHb6GDYHr3UMIlaIAHjgFmg7GGx1UkYcanrL8WnsCgbaFXmJkyrIA==", null, false, "33734a89-f4b0-4f18-bcc5-27973fa0cdd6", false, "grapevalley", true },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 0, null, "09c60f36-cd5a-4e2a-99e7-70c0650ed68f", null, "daitu@gmail.com", true, "Nông Trại Chè Trải Nghiệm Đại Từ", null, false, null, "daitu@GMAIL.COM", "daitu", "AQAAAAIAAYagAAAAEEvHqkmU0wbenUHNlUlkiD1Cr14UivcbmsLqdRq4MnxZK6hT72FHlRO1ggdEagC63g==", null, false, "67815c9c-71a3-4617-9b2b-b51b0467414e", false, "daitu", true },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 0, null, "1cf5295c-016f-4240-a330-d182e790f776", null, "buondoncoffee@gmail.com", true, "Buôn Đôn Coffee Farm Tour", null, false, null, "buondoncoffee@GMAIL.COM", "buondoncoffee", "AQAAAAIAAYagAAAAECixCFPH/tvY21JopJ+B4i7c2w70PYa04fM8Kr5g3CQNSyHjyuos+LveHxtVK4K9bA==", null, false, "a06bf3b9-b533-42f5-b214-f104b92d31cc", false, "buondoncoffee", true },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 0, null, "0d677edb-ac38-42c0-8c16-303c8db9c059", null, "hagiang@gmail.com", true, "Hà Giang Farmstay & Trek", null, false, null, "hagiang@GMAIL.COM", "hagiang", "AQAAAAIAAYagAAAAEBRhYNRWxdzf1XXvrC0co05EG5/zlu0AwXbSoHwvn0W/ax+1rJ0vWRaNHGqgbHB0SA==", null, false, "27e1844a-5f95-47a8-b5f2-200a952cf2b1", false, "hagiang", true },
                    { new Guid("10000000-0000-0000-0000-000000000007"), 0, null, "cce343ec-4905-43f2-a768-90dbf530333a", null, "tramyfarmtour@gmail.com", true, "Trà My Sâm Ngọc Linh Tour", null, false, null, "tramyfarmtour@GMAIL.COM", "tramyfarmtour", "AQAAAAIAAYagAAAAEAQy7PQQTq0LSzEIOgl/Cminymu8/WpBGmhJprMS1SeDOpR3ISNyrhcjxcSQPB3oGg==", null, false, "4648aba3-9c03-463b-8df5-1fdf02ccbc92", false, "tramyfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000008"), 0, null, "0b672f77-bf8e-409d-9260-21ad1b1d839c", null, "dalatorganic@gmail.com", true, "Đà Lạt Organic Farm Tour", null, false, null, "dalatorganic@GMAIL.COM", "dalatorganic", "AQAAAAIAAYagAAAAEIQk1d83lXDSwaKexOHKB2fH1pe2z4Z4mG/7M//c2ii7XyEQ1tLUQbePAg4GJAUbgQ==", null, false, "0b001e17-1c75-4ff6-bd16-e66d9940b61c", false, "dalatorganic", true },
                    { new Guid("10000000-0000-0000-0000-000000000009"), 0, null, "7d754bb8-6749-4699-9538-db5d64b629a4", null, "binhthuanfarm@gmail.com", true, "Farmstay Nho & Thanh Long Bắc Bình", null, false, null, "binhthuanfarm@GMAIL.COM", "binhthuanfarm", "AQAAAAIAAYagAAAAEC/TS8FAg5iuVbfBhMfQZMamejnoVQD1idI10l7oZJ+gBRBqsFArtzI4u68xGGUHTQ==", null, false, "0cf1e1ed-1ff8-4254-b427-5da1e801b564", false, "binhthuanfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000010"), 0, null, "2fba2d02-bd23-4644-9afd-9527c6bedc4b", null, "babeecotour@gmail.com", true, "Ba Bể Lake Ecofarm Tour", null, false, null, "babeecotour@GMAIL.COM", "babeecotour", "AQAAAAIAAYagAAAAEI3HosCW6aFqVTFJT98jmQAgnj7epZDb/CxnGLK11z7x57SXhHDQV0L//V6TX6enZg==", null, false, "c4634677-9964-42ff-96c4-03d3eae78513", false, "babeecotour", true },
                    { new Guid("10000000-0000-0000-0000-000000000011"), 0, null, "4348f6c7-2a5a-4a08-9e13-5ee7b9fe9e2d", null, "tayninhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Tân Châu", null, false, null, "tayninhfarm@GMAIL.COM", "tayninhfarm", "AQAAAAIAAYagAAAAEMPoLdY4eN8WKpw3Rv0b1Wr+5MlBgxs/my0xpty5RReLKRDIVs9j+F2O1VOpPw32BQ==", null, false, "08796b79-2731-4683-9ab8-9b2c45ed0c95", false, "tayninhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000012"), 0, null, "1786dc78-bb49-44aa-8e2e-462ff4e47124", null, "phuyentour@gmail.com", true, "Trải nghiệm Nông trại Biển & Rau Tuy An", null, false, null, "phuyentour@GMAIL.COM", "phuyentour", "AQAAAAIAAYagAAAAEE+A7dLFUc+wnWZmvSQPtmsSVck4oc0boc3vCxqfoPQo13zBm7MZxLzHWghosXvqnA==", null, false, "b87a96fa-1bc2-4df4-9e64-67bdacad9244", false, "phuyentour", true },
                    { new Guid("10000000-0000-0000-0000-000000000013"), 0, null, "4c237fa5-d7a6-44ad-b7e8-1371c60f8fff", null, "travinhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Càng Long", null, false, null, "travinhfarm@GMAIL.COM", "travinhfarm", "AQAAAAIAAYagAAAAEK8aRDMMvS9fpNiPJH4EcjRcJbva+bcsB66X7qi8ci1heqmvvHCmIhzPHR8ZAwDMqw==", null, false, "fe48d006-acd4-4d01-849f-daf58ba3f2ac", false, "travinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000014"), 0, null, "7184feaa-c9c1-42d8-9b0a-c9f805469843", null, "soctrangfarm@gmail.com", true, "Mỹ Xuyên Farmstay", null, false, null, "soctrangfarm@GMAIL.COM", "soctrangfarm", "AQAAAAIAAYagAAAAEPWCxpuSx6endQQIGDxmF3R0q467Tn6slezlGZMRi2W/cNmI/MC9YENIRDm8MCcNEg==", null, false, "53f8714a-2fec-439a-a16a-026f8a0c411b", false, "soctrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000015"), 0, null, "4425dd8e-c439-4f6b-acae-b1344bac7bad", null, "angiangfarm@gmail.com", true, "Trang Trại Châu Đốc", null, false, null, "angiangfarm@GMAIL.COM", "angiangfarm", "AQAAAAIAAYagAAAAEFSEixSLDgcuwdqV1XJ+emKzzTiKGokiSQ8SvVV/Exy7PGfC43IgFMGBpitP7oCFsw==", null, false, "c38f6c0c-d947-4580-b978-46659cd56033", false, "angiangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000016"), 0, null, "4a34df89-9546-4b6d-9287-baf73f37fcb2", null, "canthoexplore@gmail.com", true, "Cần Thơ Farmstay", null, false, null, "canthoexplore@GMAIL.COM", "canthoexplore", "AQAAAAIAAYagAAAAEKtleXkpj5NmZ1/bMwb7hwuOx1a4HYYz15XbzVvxmiPzTsNSHnN5laWLqH9d5kBqTA==", null, false, "f9894f6b-2973-456c-8ae6-f40e409a470c", false, "canthoexplore", true },
                    { new Guid("10000000-0000-0000-0000-000000000017"), 0, null, "fce576b6-8c02-4233-a744-2318516349fc", null, "phuquocfarm@gmail.com", true, "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, false, null, "phuquocfarm@GMAIL.COM", "phuquocfarm", "AQAAAAIAAYagAAAAEMgRUbs3m2j/mHYRpJ7I72nByy8UcXpg3Ev5kGZazdcxgivHknFR5tKLgOpxhWZuWA==", null, false, "b574efe9-128b-4061-8147-b6854938186f", false, "phuquocfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000018"), 0, null, "c3910a3c-0c36-4b3b-87c7-52642aeed6cf", null, "halongfarm@gmail.com", true, "Trại Nông Sản Hạ Long", null, false, null, "halongfarm@GMAIL.COM", "halongfarm", "AQAAAAIAAYagAAAAEB1/8AcYQy3ZnvIDef/UgDwyVQfcI516Se4xnMJZVu8HU/uhgsMmAbG+w6xhjMZs8w==", null, false, "d3883bfa-b569-4b19-b456-369764664d3d", false, "halongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000019"), 0, null, "2263be56-2355-4e83-87eb-49283add4bcf", null, "anlaofarm@gmail.com", true, "Trang Trại Nông Sản An Lão", null, false, null, "anlaofarm@GMAIL.COM", "anlaofarm", "AQAAAAIAAYagAAAAEO81cxw4xMio/kIYW2z6Yx4zOCerP2Hf/YsqK7zfXRm1xtwzVfdkjyzHjh7absw+oQ==", null, false, "63d5278e-e02e-43aa-b657-54c637cb0d2d", false, "anlaofarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000020"), 0, null, "071a47bc-520e-4504-a3cc-83921d36b63f", null, "daitufarm@gmail.com", true, "Nông Trại Đại Từ", null, false, null, "daitufarm@GMAIL.COM", "daitufarm", "AQAAAAIAAYagAAAAEDVS+Yan6+njhDpXGuRnZQIx10D7vzjemiRMEEKJaMDPklfha1ihB4oBILR1nolw6g==", null, false, "4f422931-4c5b-463d-9bb8-98abb748ee76", false, "daitufarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000021"), 0, null, "4ffa34cf-bda4-4a95-b3c0-3a33fa93880e", null, "vinhfarm@gmail.com", true, "Trại Nông Sản Vinh", null, false, null, "vinhfarm@GMAIL.COM", "vinhfarm", "AQAAAAIAAYagAAAAECcBsozvCcIVZKl4ugoJ6WtmQDmjtAnyHdpEfivTQgs8rXn3UH0+H7IBD7mKjB9NgA==", null, false, "6049ec3a-e79f-4a25-a461-68d75f7c5005", false, "vinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000022"), 0, null, "e692b478-0bc2-48fd-89c2-d0d8fe140ea3", null, "trieusonfarm@gmail.com", true, "Trang Trại Nông Sản Triệu Sơn", null, false, null, "trieusonfarm@GMAIL.COM", "trieusonfarm", "AQAAAAIAAYagAAAAEPCpCfHeAMGlsEDPkTmsOPSGhoqumvDzsQsCnWZeUJ1syGg9+H0XKT4PIv1YiCwLpg==", null, false, "71dc1c19-344e-420f-a33e-34d079bedf09", false, "trieusonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000023"), 0, null, "2a3ae457-b1c9-4649-a28c-33507b0aab58", null, "hatinhfarm@gmail.com", true, "Trại Nông Sản Hà Tĩnh", null, false, null, "hatinhfarm@GMAIL.COM", "hatinhfarm", "AQAAAAIAAYagAAAAENOGH/7Ro2/xnkQ4+Vi/6+cg5nEp9qwsVJrweQ6g7Lg6twsovoLyAMPEeioacWgBZw==", null, false, "1a269a67-4060-43dc-9f2b-3ff47bf73b9e", false, "hatinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000024"), 0, null, "ddf4340f-7e4e-49ca-a6bf-af0f697c31fe", null, "donghoifarm@gmail.com", true, "Trang Trại Đồng Hới", null, false, null, "donghoifarm@GMAIL.COM", "donghoifarm", "AQAAAAIAAYagAAAAEOjibxRfZjMq+g2kMIItj43eiCsrAVY4tl8k1iJCU6roGewBhrUsljMpzhWxsgXbDg==", null, false, "27a2c985-7a32-4737-acd0-1218f2a3ddb1", false, "donghoifarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000025"), 0, null, "037332e9-53c2-4ce8-a346-cddab982af8a", null, "donghafarm@gmail.com", true, "Trang Trại Nông Sản Đông Hà", null, false, null, "donghafarm@GMAIL.COM", "donghafarm", "AQAAAAIAAYagAAAAEPYjEeAGWuK4kdwFAqK4vF/HXZHQ+5rQ1QSDuBIbhDg70G7GVF6/RQ0x8hbyAr6mEA==", null, false, "48b29b81-4fbf-4938-9b24-eb99a2b6a76b", false, "donghafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000026"), 0, null, "9e952dfa-0e7a-4812-9f35-eda828d7e09c", null, "quynhonfarm@gmail.com", true, "Trại Nông Sản Quy Nhơn", null, false, null, "quynhonfarm@GMAIL.COM", "quynhonfarm", "AQAAAAIAAYagAAAAEAesk3001zeTJifRNteVe4CbFnRSAPy4hk+w8T9NRHfdmekicymkwln08ZK7N5t27A==", null, false, "43abb8fe-e2ee-4c11-8490-8091668dfccc", false, "quynhonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000027"), 0, null, "89ead67e-a053-4dd9-8d9c-38af776ab30b", null, "tuyhoafarm@gmail.com", true, "Trang Trại Nông Sản Tuy Hòa", null, false, null, "tuyhoafarm@GMAIL.COM", "tuyhoafarm", "AQAAAAIAAYagAAAAEMiCzZIvQ8F4xMFa7PVZtccC2Cjf3J4V25iRvgmmMozSaA9cQ1uL46mgzsj8AjlbzA==", null, false, "13052a0f-0ac3-44af-9149-eea967c6c767", false, "tuyhoafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000028"), 0, null, "a5deeaba-4736-4f7f-8833-36906b159ed0", null, "nhatrangfarm@gmail.com", true, "Trại Nông Sản Nha Trang", null, false, null, "nhatrangfarm@GMAIL.COM", "nhatrangfarm", "AQAAAAIAAYagAAAAEIEpZQhQtXOHWGWCvJkjY1nCeaEU0katCce+/pV6qzI9RM+9kaptyD0jKNVgg6iquw==", null, false, "2d0ff843-9719-4d74-9247-6a9feedd4f8b", false, "nhatrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000029"), 0, null, "a984f8fe-b8a1-411e-ae6f-e44fa56b77df", null, "phanrangfarm@gmail.com", true, "Trại Nông Sản Phan Rang", null, false, null, "phanrangfarm@GMAIL.COM", "phanrangfarm", "AQAAAAIAAYagAAAAEKHlp1EzRn8EnAq05WV7zpoJduOp86jc35O3962GrVxudjses8SzPPj4TL/TkVM1bg==", null, false, "d96ca7ad-1bea-4536-969b-24b71caff4bf", false, "phanrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000030"), 0, null, "8af3d1d0-b387-4ca9-aa75-db7cf917a470", null, "phanthietfarm@gmail.com", true, "Trang Trại Nông Sản Phan Thiết", null, false, null, "phanthietfarm@GMAIL.COM", "phanthietfarm", "AQAAAAIAAYagAAAAEJpdO9GRP2RIMrV5bpLD0fez+Pe02NYKM/WEQO2lrx9P6yrVem5sON0uzW3gKUiwsA==", null, false, "d03c42b4-f6c1-4634-ae8c-d2ba4fe32fc3", false, "phanthietfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000031"), 0, null, "e4b64974-81eb-4ed5-a721-5c64c5369f4a", null, "tananfarm@gmail.com", true, "Trại Nông Sản Tân An", null, false, null, "tananfarm@GMAIL.COM", "tananfarm", "AQAAAAIAAYagAAAAEFEQrg6G/sGMDGY0g3mnt+awQtBEc5xihXepQiYCFYkyEkxJx0rQVRBrXYKP5Wdt3A==", null, false, "464fc051-8221-4e44-85d6-1795212de89e", false, "tananfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000032"), 0, null, "d430979d-f4fd-40c9-9af6-56300bab397a", null, "vinhlongfarm@gmail.com", true, "Trại Nông Sản Vĩnh Long", null, false, null, "vinhlongfarm@GMAIL.COM", "nhavinhlongfarmtrangfarm", "AQAAAAIAAYagAAAAEC4UHX5T4b2LfbrfXSO9EUSVof+GcUt+MFnpfMpc9b27Z3FVqvZANeoHgPqSMEiCPA==", null, false, "12996efe-637f-4f96-999b-cfd2240441ae", false, "vinhlongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000033"), 0, null, "8b242b43-f95e-46ee-947e-c9bab0c46d8a", null, "contact@vinpearlresort.com", true, "CÔNG TY TNHH VINPEARL RESORT & SPA", null, false, null, "CONTACT@VINPEARLRESORT.COM", "VINPEARLRESORT", "AQAAAAIAAYagAAAAELVj4ku+sTAovP4TWq13V328auHgBZYScTiwsc15CROZ6QpoWhWmbuUd4lRAC1cHHA==", null, false, "41ef1a71-30f7-4d31-9e79-0e327aade5e4", false, "VinpearlResort", true },
                    { new Guid("10000000-0000-0000-0000-000000000034"), 0, null, "d84fc3f4-f1f3-40ce-af89-69a483857e08", null, "info@muongthanhhotel.com", true, "TẬP ĐOÀN KHÁCH SẠN MƯỜNG THANH", null, false, null, "INFO@MUONGTHANHHOTEL.COM", "MUONGTHANHHOTEL", "AQAAAAIAAYagAAAAEDtGO0Hdl2KsVOme3TJ5X6L9ouJiBIeDxyti5oILdWkOV7wSHdDCMJUq0+YAU3oz6w==", null, false, "34fc6327-ffa8-433c-8c50-a9ed16e423b4", false, "MuongThanhHotel", true },
                    { new Guid("10000000-0000-0000-0000-000000000035"), 0, null, "63804ec3-fe05-4a03-818f-38b7321869ac", null, "reservation@intercontinental.com", true, "KHÁCH SẠN INTERCONTINENTAL HANOI WESTLAKE", null, false, null, "RESERVATION@INTERCONTINENTAL.COM", "INTERCONHANOI", "AQAAAAIAAYagAAAAEP2KjdctUlmnTnPx4SOb/c7qWZDpS6aaT+be5sPGyKweTO0Ct7Mg7MBgmr+LudmGlw==", null, false, "3a52b405-3b2b-46a1-9080-dadd9981d4f7", false, "InterConHanoi", true },
                    { new Guid("10000000-0000-0000-0000-000000000036"), 0, null, "e620ae24-e5a9-419c-be44-1be5ea950dfd", null, "info@sofitellegend.com", true, "KHÁCH SẠN SOFITEL LEGEND METROPOLE HÀ NỘI", null, false, null, "INFO@SOFITELLEGEND.COM", "SOFITELLEGEND", "AQAAAAIAAYagAAAAEBFHdz7vXus4mSvCgTWsX78cy2+MqPaR5MJGfhNSCB8fJHyH2xrBMFRejZzt0nQUFg==", null, false, "4edb1a31-ac70-4392-9582-0a3782506467", false, "SofitelLegend", true },
                    { new Guid("10000000-0000-0000-0000-000000000037"), 0, null, "fa46c046-cee2-45db-b521-28ae1d1fa873", null, "reservation@furamadanang.com", true, "CÔNG TY TNHH FURAMA RESORT ĐÀ NẴNG", null, false, null, "RESERVATION@FURAMADANANG.COM", "FURAMADANANG", "AQAAAAIAAYagAAAAEHNVvQQ/kswlXFEPUxzSWPO6zW/HhK42UyLCrGpIx59vG2cLvxsoUkGinJH9iYZRbA==", null, false, "8487af31-3d7e-4e5e-8378-602874c23dc7", false, "FuramaDanang", true },
                    { new Guid("10000000-0000-0000-0000-000000000038"), 0, null, "28bf94c2-20c9-4b55-8727-32aacb597d8c", null, "spa@anantara.com", true, "CÔNG TY TNHH ANANTARA QUY NHƠN VILLAS", null, false, null, "SPA@ANANTARA.COM", "ANANTARASPA", "AQAAAAIAAYagAAAAEH4I+RPQ1CleDpEv/5MbgHnmEpPBjMLn2dxVO9y/NXt9lQHoUmTWF3hozKqk6EQMaw==", null, false, "ff1f013a-6919-4cef-bcce-9c93e8d1c292", false, "AnantaraSpa", true },
                    { new Guid("10000000-0000-0000-0000-000000000039"), 0, null, "4b16de80-e58f-4fef-a8a2-b2dc649b22c5", null, "resort@amanoi.com", true, "CÔNG TY TNHH AMANOI RESORT NINH THUẬN", null, false, null, "RESORT@AMANOI.COM", "AMANOISPA", "AQAAAAIAAYagAAAAEPQ4HQoqKpa+oAazXdCRV7EhdHiJQlnSBnu7GixoHLHhhXcXqtcFFfT8KP8FbZ/zPg==", null, false, "a3ace062-9abc-4ae4-8d38-f926c14695f1", false, "Amanoispa", true },
                    { new Guid("10000000-0000-0000-0000-000000000040"), 0, null, "c4aecef2-7efe-409c-a998-504a4f1cf52b", null, "contact@sixsenses.com", true, "CÔNG TY TNHH SIX SENSES CÔN ĐẢO", null, false, null, "CONTACT@SIXSENSES.COM", "SIXSENSESCON", "AQAAAAIAAYagAAAAEAXeq/uEeT8XPjTYRkkfFjm03XjnQ/jOBUBT96+SesEYFq3OpAAeoceC8BD9MSXc8w==", null, false, "ae58aff3-e431-452f-ab0b-7b5940ccc497", false, "SixSensesCon", true },
                    { new Guid("10000000-0000-0000-0000-000000000041"), 0, null, "4f128555-3d17-4ca0-bba2-7bc21c5c3ed0", null, "langco@banyantree.com", true, "CÔNG TY TNHH BANYAN TREE LĂNG CÔ", null, false, null, "LANGCO@BANYANTREE.COM", "BANYANTREE", "AQAAAAIAAYagAAAAENBhXzpbgouJzqQSZ8lrzE+OA2jCRMO2dQNg1DA45Yoeiz8TylXxTQCaOBsMQW5ZVg==", null, false, "9e768a29-793a-4b9c-97fb-d6fdb6d74691", false, "BanyanTree", true },
                    { new Guid("10000000-0000-0000-0000-000000000042"), 0, null, "729cdf13-27da-4dfc-a10f-d17e01544668", null, "saigon@hyatt.com", true, "CÔNG TY TNHH PARK HYATT SÀI GÒN", null, false, null, "SAIGON@HYATT.COM", "PARKHYATT", "AQAAAAIAAYagAAAAEBc7OtuOXeG/rZbwuiqbvph+OFdCSVm+inR1yZs+njmEvZNFFV2/MK+U13KZhDAQsA==", null, false, "8ee1c06a-93b9-4917-a894-1a60dc01feb3", false, "ParkHyatt", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "b49eab0a-b67a-4b32-b232-ce28090a7031", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEBSqAxbEgxym7y5sJxHhCeEMQRoKKdMTaeMLrTXsJETPlqy5BgfpIU3kEaHPvM59RA==", null, false, "760a9957-0915-40dc-94a7-6b9d9d4139c2", false, "ContentModerators", true },
                    { new Guid("20000000-0000-0000-0000-000000000018"), 0, null, "88219209-cfbf-454d-9214-289f90af9e9b", null, "contact@gmail.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@GMAIL.COM", "QUYNHONEXPLORER", "AQAAAAIAAYagAAAAEMkAJK2spXUW/SnRw65BpDcsctwsLDum4iNqJlESv/1fjyqvBReo/+FaV1aw5sjX0A==", null, false, "c4f50201-b370-48d1-991b-a71b7ee434ce", false, "quynhonexplorer", true },
                    { new Guid("20000000-0000-0000-0000-000000000019"), 0, null, "f0669bdb-a9c5-4d68-a0f1-0a368f46d73f", null, "contact@hoianheritage.com", true, "Hoi An Heritage Tours", null, false, null, "CONTACT@HOIANHERITAGE.COM", "HOIANHERITAGEACCOUNT", "AQAAAAIAAYagAAAAEKKRsew9xXWiia7jQijnArmdQqsn6KO3A2yV6kdXeDkIasAPkMkbAWZyEPLf9zae9A==", null, false, "276cc42d-f7f6-4af3-941d-56c1aaf6c97e", false, "hoianheritage", true },
                    { new Guid("20000000-0000-0000-0000-000000000020"), 0, null, "3421de4a-bba8-460d-aa69-a8bb73a65738", null, "info@danangdiscovery.com", true, "Da Nang Discovery Travel", null, false, null, "INFO@DANANGDISCOVERY.COM", "DANANGDISCOVERYACCOUNT", "AQAAAAIAAYagAAAAECEUVh6iL3R8zy6gLTJgU3zvoYMiUGQlS5aszvj7PctHPXEIicA6Isn78ObvK9roJg==", null, false, "a3b0f7d4-cabb-419d-920b-66e350febf24", false, "DaNangDiscoveryAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000021"), 0, null, "acfac3ee-ed0d-4e72-8ccd-075d3c549edc", null, "contact@hueimperial.com", true, "Hue Imperial Adventures", null, false, null, "CONTACT@HUEIMPERIAL.COM", "HUEIMPERIALACCOUNT", "AQAAAAIAAYagAAAAEMrXmqH9l8tDFiiEzN4yJ7Ch8Cp1Db+h/+wSQQBsxN9sJsaEW+QaTjmFsvEQs98TZg==", null, false, "4c941be5-59e1-4415-bf95-e39c57bc218b", false, "HueImperialAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000022"), 0, null, "8bca174f-4d63-4bc4-9a1b-84cb5db7d6a7", null, "info@nhatrangbay.com", true, "Nha Trang Bay Tours", null, false, null, "INFO@NHATRANGBAY.COM", "NHATRANGBAYACCOUNT", "AQAAAAIAAYagAAAAEN+H2sjhWCUaGUSKqDkdqlq4zBIAuugYVUR11QPUZzoaiXZw8BFegr8VfsMWtsLetA==", null, false, "c8b04024-f3b9-4470-8ca7-212c17b8d0a5", false, "NhaTrangBayAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000023"), 0, null, "c7426baa-0092-4f9b-bb00-1791aa70a500", null, "booking@halongcruise.com", true, "Ha Long Cruise Experience", null, false, null, "BOOKING@HALONGCRUISE.COM", "HALONGCRUISEACCOUNT", "AQAAAAIAAYagAAAAEB5/jNKAbLfWtCTqhOoa7D7cu+79m7D2bo+Q4fSiDHtLVZwRKDD/V8Zwiv4iYrbSLw==", null, false, "5f8ac021-6cc5-4207-96d3-06cd1e4b517d", false, "HaLongCruiseAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000024"), 0, null, "4da8e0df-2ee1-4ad2-ad85-1656be6acafa", null, "contact@sapahighland.com", true, "Sapa Highland Adventures", null, false, null, "CONTACT@SAPAHIGHLAND.COM", "SAPAHIGHLANDACCOUNT", "AQAAAAIAAYagAAAAEJQ7CoV3/r/BWd6k4uciSyrHoYk2VpAP0utbVioO/AIZ4ExVwbwAxIHHnrCPrRTCHw==", null, false, "bcb1863c-6f1a-41fd-bb5a-5572acf00401", false, "SapaHighlandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000025"), 0, null, "98ce07fb-8ab0-4563-aff7-08a650ec01c8", null, "info@mekongdelta.com", true, "Mekong Delta Explorers", null, false, null, "INFO@MEKONGDELTA.COM", "MEKONGDELTAACCOUNT", "AQAAAAIAAYagAAAAEAyJa89VCMxOP481PK4mS1JDENTBDuTZl1Kc42bNs/cSjItUzJYGqixV0EV6u0fqcg==", null, false, "d501c02a-a497-4b86-b1ed-1c7443db142b", false, "MekongDeltaAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000026"), 0, null, "5161bfd7-1c11-4765-812f-20489fb2ec1b", null, "contact@phuquocisland.com", true, "Phu Quoc Island Tours", null, false, null, "CONTACT@PHUQUOCISLAND.COM", "PHUQUOCISLANDACCOUNT", "AQAAAAIAAYagAAAAECPckTx7vYu4czBb+pqwdYCX2yMGGvDJQWmCRzqG3olDUxxdh4qJVo6EPwA/vMWb8w==", null, false, "c8c505a0-67d8-4d53-8d8b-7b1f34b510f9", false, "PhuQuocIslandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000027"), 0, null, "7c5d24a6-2eb4-4417-a9d9-6f96da525ccf", null, "info@dalateco.com", true, "Da Lat Eco Tourism", null, false, null, "INFO@DALATECO.COM", "DALATECOACCOUNT", "AQAAAAIAAYagAAAAEB2DqlP66bw72E9EY6cV9ea5dnxg8QoF0XOYseDtcFBHrwy5pgffmrS+EMld1Erb2g==", null, false, "4ccbe24f-9cf8-4916-a6b8-06a8f8c4046b", false, "DaLatEcoAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000028"), 0, null, "13c1bc83-f66b-4afc-8eba-cf4f77dbdac5", null, "booking@condaotours.com", true, "Con Dao Heritage Tours", null, false, null, "BOOKING@CONDAOTOURS.COM", "CONDAOACCOUNT", "AQAAAAIAAYagAAAAEMYOcDF0Zs9Avtyn9ukoM+XbIzu+BCrtU4rRd8UzUQEQwS5zmeHJTR2/b/qCzXDNiA==", null, false, "3bf2be1c-cdc9-4272-bb59-5297445c08cd", false, "ConDaoAccount", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0, "https://example.com/avatar1.jpg", "f5c449f8-9a6e-4d27-9f1a-219523004963", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", true, "John Doe", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEGQH+YoImKfbaZeQeardks5tNnunbLoNvXDkpcjg+7f8CubD3ZoxVjrQ3V0JTaqP+w==", null, false, "13a1407e-83eb-4e71-9f9f-f8f50c6de65b", false, "JohnDoe", true },
                    { new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), 0, null, "a0333e1f-dceb-4906-9d4b-3c9a06ef2c54", null, "contact@bambotravel.com", true, "Bamboo Travel", null, false, null, "CONTACT@BAMBOOTRAVEL.COM", "BAMBOOTRAVELACCOUNT", "AQAAAAIAAYagAAAAELbNJbLkXRYt1u1naXasjWuCVsec2R8S5m9dXO3SdEoxf2Ljy+D9raBZNVAOg7P3mg==", null, false, "0fe14329-4289-4ccb-8595-ce8b7fc5ec32", false, "BambooTravelAccount", true },
                    { new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), 0, null, "78d4e86c-95a8-44e2-863c-54008d44ce02", null, "info@phuongnamtravel.com", true, "Phương Nam Travel", null, false, null, "INFO@PHUONGNAMTRAVEL.COM", "PHUONGNAMTRAVELACCOUNT", "AQAAAAIAAYagAAAAEJ6ehTKyuHXdMJkGky+4oOGpUgQ0lf8Os4urfNZhT2QxCWQmP46qDlRVGr9EXNkmiw==", null, false, "ab6a70ac-031d-4e4b-ba85-206a45db6857", false, "PhuongNamTravelAccount", true },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0, "https://example.com/avatar2.jpg", "05455c2f-d248-486a-8c4d-6605ff9259e4", new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmawatson@example.com", true, "Emma Watson", false, false, null, "EMMAWATSON@EXAMPLE.COM", "EMMAWATSON", "AQAAAAIAAYagAAAAEL0qrdCVALfSPFBDACZsafW6ThSCcd3Ukll8rcbuo+iV+rA2hD0GIxFo02jLlM06OA==", null, false, "fc81777e-0453-43e8-9498-eb650d72614a", false, "EmmaWatson", true },
                    { new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), 0, null, "288572a9-6ef1-4a23-aece-5c12c1e5937d", null, "support@nhatrangholiday.com", true, "Nha Trang Holiday", null, false, null, "SUPPORT@NHATRANGHOLIDAY.COM", "NHATRANGHOLIDAYACCOUNT", "AQAAAAIAAYagAAAAEI3p6DHECkM1WP06u1FFNzcM41hTve4jSHa12uPCApFibwhkWGK/E6Z+aCmMohStxA==", null, false, "95af1c5f-8fe4-4cc9-8f48-eef7e680349a", false, "NhaTrangHolidayAccount", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "88f8b183-9be4-48ae-ab90-139a7cfdb1b4", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAENzqaMy9vt/AOLaT7k01NXAXDM8XYvKw9GBzhRzrE3bNBeWkaiDtK2K9bDunQV6k7Q==", null, false, "c109864c-20da-4606-bb82-202d12345b90", false, "TourGuides", true },
                    { new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), 0, null, "0282a300-3b76-426d-b089-011faa9482ba", null, "support@hanoitourist.com", true, "Hanoitourist", null, false, null, "SUPPORT@HANOITOURIST.COM", "HANOITOURISTACCOUNT", "AQAAAAIAAYagAAAAEIYatg+J+2lOlYR/hNiSyiSM51IizmznfbVHKCMSfAiv8pyug6TI/RPpK8SitxVDDg==", null, false, "36707ae8-8675-4b0a-a7b1-f1496a982dc9", false, "HanoitouristAccount", true },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 0, "https://example.com/avatar3.jpg", "2430008d-ec0c-439d-b7bb-2224304d819e", new DateTime(1985, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelbrown@example.com", true, "Michael Brown", true, false, null, "MICHAELBROWN@EXAMPLE.COM", "MICHAELBROWN", "AQAAAAIAAYagAAAAELBXj4Culz3y2aID6MD10zlV/Lg2ALMY2AXWVZLlcosWVNuvEvJhmK6AvZH4dpOXlg==", null, false, "381d967b-a7f7-4ccb-acb6-1971e41a2aea", false, "MichaelBrown", true },
                    { new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), 0, null, "f7fdb8ce-eb73-4c67-b9a2-981a5dfe4e52", null, "contact@phanthiettours.com", true, "Phan Thiết Tours", null, false, null, "CONTACT@PHANTHIETTOURS.COM", "PHANTHIETTOURSACCOUNT", "AQAAAAIAAYagAAAAEIZ8ReJilWRu0mzw67IOlA8i29kq0gl84zBwmbuU943hxVyjvclMpDTpf0iPWRLFaQ==", null, false, "3bac95d3-a042-46ae-b1e6-17d14205c765", false, "PhanThietToursAccount", true },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), 0, "https://example.com/avatar8.jpg", "152bc5b0-bb1d-4b10-81a2-b3d5eddadc94", new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", true, false, null, "DANIEL.MARTINEZ@EXAMPLE.COM", "DANIELMARTINEZ", "AQAAAAIAAYagAAAAECZCJnnK23n8OHnjhQv7M0u4rYaJop3xf094w4ysInec5bZdHigELH5xdZ6GJn5p9A==", null, false, "aceef102-f620-468e-80fe-46de8df4bed0", false, "DanielMartinez", true },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 0, "https://example.com/avatar4.jpg", "54b51f46-afb8-4f71-8ef9-3ce2bbe552db", new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophialee@example.com", true, "Sophia Lee", false, false, null, "SOPHIALEE@EXAMPLE.COM", "SOPHIALEE", "AQAAAAIAAYagAAAAEHfbmgEzNgz5FJZ7GbR/h7JNgNB250Vc32b2jQjUxasYZffFTG+YW1rusLbf1HlkWg==", null, false, "2d4711c4-61bb-4b41-980a-f3b952a3cd16", false, "SophiaLee", true },
                    { new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), 0, null, "3d9035c8-182c-435a-ad3a-33a95fb959a2", null, "info@redtour.com.vn", true, "Redtour", null, false, null, "INFO@REDTOUR.COM.VN", "REDTOURACCOUNT", "AQAAAAIAAYagAAAAEAVdFAcNV2vtoNd4uH/tTuv/PZWgyW0KEzvwXBpWUuGuaNII/+JQ8PjNDWHc0T9sxA==", null, false, "763aac9a-d917-4fcb-acd2-30a5919e37ec", false, "RedtourAccount", true },
                    { new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), 0, "https://example.com/avatar9.jpg", "72bb9d6f-3f5c-4230-b7af-3b0fbdebe48e", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilyclark@example.com", true, "Emily Clark", false, false, null, "EMILYCLARK@EXAMPLE.COM", "EMILYCLARK", "AQAAAAIAAYagAAAAED3MlPJcu9N4pWK9zGs3SFbUMEb1uZfxEs7T33z9DTS/DgetioiHBkgRhkdaeeRC+g==", null, false, "c915f61d-4dd5-4dbf-9f00-d5db1aaffbc4", false, "EmilyClark", true },
                    { new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), 0, null, "29cf7231-820f-4fbd-90d2-2c203bf1a414", null, "contact@quynhonexplorer.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@QUYNHONEXPLORER.COM", "QUYNHONEXPLORERACCOUNT", "AQAAAAIAAYagAAAAEHIbZKhHq673pKnHF0STqAFeB86DMg86XXy3uc10Y8Z4nt2ihMz5cOPg73eeUwOe+A==", null, false, "54e465f6-0a0e-48fc-ad5c-b7895d887638", false, "QuyNhonExplorerAccount", true },
                    { new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), 0, null, "b64df55c-026b-4edc-9e10-5c7c136bc0c4", null, "contact@datviettour.com", true, "Đất Việt Tour", null, false, null, "CONTACT@DATVIETTOUR.COM", "DATVIETTOURACCOUNT", "AQAAAAIAAYagAAAAEJ4cYGnZLpAt9idnZTv3/tk7gryzVNlFymWO7t2gompIVRZEba7sAnvhRTjJ/iUu5g==", null, false, "099fea62-6469-4615-853f-a1d2f30ad340", false, "DatVietTourAccount", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "8826f7bd-c28e-4192-9d64-9a3fc1659dbb", null, "thutt170727@gmail.com", true, "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAEGiXMl914h0bNlrftY9gSYzK24MJubvryGH+QCCLVy9nP3kf7zodtyfbPf+CVUgCeg==", null, false, "f702f2d2-d05b-4b60-be85-c043b142c5f7", false, "ATFO", true },
                    { new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), 0, null, "bfaa7c71-237d-494e-b8c5-bf758b5702de", null, "contact@vietsuntravel.com", true, "VietSun Travel", null, false, null, "CONTACT@VIETSUNTRAVEL.COM", "VIETSUNTRAVELACCOUNT", "AQAAAAIAAYagAAAAEMN0uK8/hA0uptFUVoYF5q6SgRQh5P/H4EspJxT5nDK8tm4KA6/heh19bk+rNdj89Q==", null, false, "f3b50e63-0853-48c3-9575-23e31261d45d", false, "VietSunTravelAccount", true },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "https://example.com/avatar5.jpg", "f9831aa1-2c97-490f-8095-7720e7ca90d9", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", true, "David Johnson", true, false, null, "DAVIDJOHNSON@EXAMPLE.COM", "DAVIDJOHNSON", "AQAAAAIAAYagAAAAEPEtjVlfP5bpESRGQfpFh+zRwMc3lMRhJhUIjqn1ajWCRviYS5l5lqs5TOt8OHinrw==", null, false, "6545fdcd-ea19-4406-9475-5ccb08e78386", false, "DavidJohnson", true },
                    { new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), 0, null, "64338b5d-adc0-42e1-b125-3641f341abba", null, "contact@havatravel.com", true, "Havatravel", null, false, null, "CONTACT@HAVATRAVEL.COM", "HAVATRAVELACCOUNT", "AQAAAAIAAYagAAAAEA8a/V9EYLriY2JMDekuVJYKt9U3/HpEgM+Sw0Ve4PQoEsPvwHBpkdsoAo6wVA8rXg==", null, false, "b7ab6c35-4864-4a03-a04c-e7e216508ad7", false, "HavatravelAccount", true },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "7098e5c6-2003-4c69-92f9-1ab43a8866f5", null, "thutt170727@gmail.com", true, "Administrator", null, false, null, "THUTT170727@GMAIL.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAELJZOYfpgjKp1GSP7mkqzwiFA5dO1MvPTgBQX33TP64x7n7iRQnt1GU0gAX232WGTg==", null, false, "5870c0eb-1f18-462d-afeb-40b0278bbd04", false, "Administrator", true },
                    { new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), 0, null, "f6a32936-d374-4165-ad78-d0f44a9ae6a3", null, "info@vungtautravel.com", true, "Vũng Tàu Travel", null, false, null, "INFO@VUNGTAUTRAVEL.COM", "VUNGTAUTRAVELACCOUNT", "AQAAAAIAAYagAAAAEP9lGqCCCvnsRmijujmtPJlsW9Xi9d5ngdncxMjwADMSVGoAv98bd4vSVX0e1RzvWw==", null, false, "333d7f0f-cd4c-43d2-9cf4-6a0ec646dfbc", false, "VungTauTravelAccount", true },
                    { new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), 0, null, "3dc9a797-bc12-4bda-8c7c-e08a87cb1366", null, "info@dalattour.com", true, "Đà Lạt Tour", null, false, null, "INFO@DALATOUR.COM", "DALATTOURACCOUNT", "AQAAAAIAAYagAAAAEDZRBRmTTa/5QAEC9GVEtsIiTjRRsi/pbQKaIgnv6IoLIbzySnrYRsWuueIJCzjd1Q==", null, false, "caf13941-93a8-4149-ad06-c6f2aa4c8508", false, "DalatTourAccount", true },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0, "https://example.com/avatar6.jpg", "8e5c89de-ce3c-497a-8f83-184cbf6fa907", new DateTime(1987, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "liamnguyen@example.com", true, "Liam Nguyen", true, false, null, "LIAMNGUYEN@EXAMPLE.COM", "LIAMNGUYEN", "AQAAAAIAAYagAAAAEBFAO2f8BtO4ntn525meb9FXJcSiNYpXbh5JdMfm4jhqR/UkoHfP7TfyCZcfpBiGNw==", null, false, "7ae5ff67-ea91-40e7-a593-edd7c3210120", false, "LiamNguyen", true },
                    { new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), 0, null, "56df9df9-ad12-42b4-ae02-27023ee5b6be", null, "info@danangtravel.com", true, "Danang Travel", null, false, null, "INFO@DANANGTRAVEL.COM", "DANANGTRAVELACCOUNT", "AQAAAAIAAYagAAAAEGx8nqaJKBo2u6okjJYU07HTC+a/t4YsB/Tj2uFkZh0NAvDHXRFBLm1iQaju0/vlvw==", null, false, "88b16ff3-2475-4863-a731-5ce06a1cccda", false, "DanangTravelAccount", true },
                    { new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), 0, null, "b548f4fa-e50a-4025-b746-50ddbd1c7604", null, "contact@saigontourist.net", true, "Saigontourist", null, false, null, "CONTACT@SAIGONTOURIST.NET", "SAIGONTOURISTACCOUNT", "AQAAAAIAAYagAAAAEAvo0T2tXYmHsRrVT3J9M8v0oXwLRbpDKHzWKhXQrRfrp2fP0Pm4zYpY7WbO7v6yqw==", null, false, "673e0250-9a50-4448-b63b-67f5f93bfdc7", false, "SaigontouristAccount", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "247a8485-f828-4fb8-9707-96907a898a03", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAEJwZz+WLUOFpT9PhdNNKuEP9fliZrTg6VveOmP6ukM7Pmb9DF0E6dAlLeL0ljyziFg==", null, false, "b2edfbec-3e8d-4838-a65c-36f44800cb78", false, "Tourists", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f1"), 0, null, "f53f593b-bee7-4fd5-94a7-de3d15d4926e", null, "thuylinh@fpt.edu.vn", true, "Thùy Linh", null, false, null, "THUYLINH@FPT.EDU.VN", "THUYLINH", "AQAAAAIAAYagAAAAEKeVi3UoLouS+8cMBQ3CE1kcsDoa1TBg3LjeriX8YOE50aDDVWIbe0QA0Q2LPzbADw==", null, false, "872d8e81-bf53-4f67-b0ee-9c2a6abee8cd", false, "thuylinh", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f2"), 0, null, "fda1c408-f8f2-4d40-9a7e-e9da70ebecc5", null, "hoaithu@fpt.edu.vn", true, "Hoài Thu", null, false, null, "HOAITHU@FPT.EDU.VN", "HOAITHU", "AQAAAAIAAYagAAAAEMagfABDK/JsBkEQWwBH7St2vdrnkp0NCVd8fjahPIRWCkG0WzKpGqabSdVUPluuGQ==", null, false, "7fc36b18-b0a4-4d17-9893-9d71b88de15d", false, "hoaithu", true },
                    { new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), 0, null, "e499b534-2b63-4755-89ed-42325e21aa3f", null, "support@dulichtoday.com", true, "Dulich Today", null, false, null, "SUPPORT@DULICHTODAY.COM", "DULICHTODAYACCOUNT", "AQAAAAIAAYagAAAAEJseiGWtDsOh3o9/gPS4TMNU0q5fxq64vMLSMGzIDZm356mH+xRcp2iAqgea33H5pg==", null, false, "64bc75ce-2e29-44d9-b9c5-64ef60cb12d1", false, "DulichTodayAccount", true },
                    { new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), 0, null, "4ac1e8a0-803e-4375-9640-8c3f1f055171", null, "info@fiditour.com", true, "Fiditour", null, false, null, "INFO@FIDITOUR.COM", "FIDITOURACCOUNT", "AQAAAAIAAYagAAAAEEHZIiksZZFEvfacEbf8vQ2L/6aKu/eQz43Y9dRS/h8CyWlcuwfScjYIDX9m5nXP3w==", null, false, "1ab25ebe-56e7-46dd-9573-6e5f643d8a13", false, "FiditourAccount", true },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 0, "https://example.com/avatar7.jpg", "1c209f7e-410d-4892-89c8-bb6d3f1a5dd0", new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviakim@example.com", true, "Olivia Kim", false, false, null, "OLIVIAKIM@EXAMPLE.COM", "OLIVIAKIM", "AQAAAAIAAYagAAAAEGhle/DbljcR1oprbhuniR5VA/gBvzKTdyhU5SNQs34nl5bTfgBmSX1Y8KVO3KjOvA==", null, false, "987acecd-207e-4cb0-bcfa-0f2a213f9c3f", false, "OliviaKim", true }
                });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03d771ca-b645-499a-83ad-9c8580b6cc35"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011005502113", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1800), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("05bb015c-237a-48ae-983a-85f0cdb179bb"), "Hanoitourist", "0011006103902", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2092), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("05f1bf3e-efea-49e6-ac39-863bc010627e"), "Trang Trại Nông Sản Sạch Càng Long", "0011007194611", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2017), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("1d93f949-4181-4d3a-b196-3088bb8e01cd"), "Dulichtoday", "0011007678308", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2118), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("1fca40b6-5109-43de-9cfd-4097a270c5a7"), "Nha Trang Holiday", "0011005240090", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2171), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("2cff9c65-3985-44bc-a866-fc6c7974121a"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011004761120", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1970), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("3804e13f-33e7-4875-96c5-1de7d99fd1f3"), "Farm Du Lịch Grape Valley", "0011001293403", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1978), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("3a273dea-012e-454f-9125-afee7d5a1a45"), "Farmstay Nho & Thanh Long Bắc Bình", "0011001311071", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2004), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("426a0f79-ab65-40da-b3e4-845663188e0c"), "VietSun Travel", "0011004570666", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2102), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null },
                    { new Guid("511c3a47-6e97-4357-b542-8347291a476d"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011004301411", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1983), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("54e6efbd-d5df-45e7-b8a1-defd2edc357b"), "Ba Bể Lake Ecofarm Tour", "0011005326351", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2007), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null },
                    { new Guid("6cffd60b-1803-43b4-851c-e7cb0295ba33"), "Fiditour", "0011004606242", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2095), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("6f61a0a6-3277-4593-9130-28e68dc367a1"), "Saigontourist", "0011006066733", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2089), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("76e1ab80-87a8-42e4-bfc7-0c8a1f2e8cdf"), "Phan Thiết Tours", "0011005163643", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2175), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("7f201548-f329-4755-9996-641ea2badecc"), "Trà My Sâm Ngọc Linh Tour", "0011007051485", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1996), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("997a9562-65e5-4a58-8a48-152810665c34"), "Hà Giang Farmstay & Trek", "0011003319313", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1990), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("a0be5c7b-dbba-44a7-a6ab-eb860de6aa0f"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011006163214", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2014), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null },
                    { new Guid("a53b43e0-44c4-423b-9905-a58a770f67bb"), "Havatravel", "0011009472331", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2121), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("a64b229f-f0d3-4bb7-ae6c-39c077d6b8e8"), "Danang Travel", "0011005613315", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2100), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("a7e4a413-a4b1-429d-ab64-92e9f5b045e2"), "Công ty Cổ phần Vietravel", "0011005428636", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2083), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("ae0b4c53-848a-4403-8773-1c61d46504ed"), "Phương Nam Travel", "0011006834044", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2109), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("b0fd9a7d-252e-4572-b87d-320468c4a97b"), "Bamboo Travel", "0011002422876", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2105), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("bb76d12b-97de-46aa-a2a7-245ed943a8e6"), "Mỹ Xuyên Farmstay", "0011007498851", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2020), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null },
                    { new Guid("c1bcff1d-bfe9-49fe-8a71-c8c683e2ce42"), "Trang Trại Châu Đốc", "0011008655344", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2025), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("cbe3809a-6407-4cd8-a189-a1571bce830d"), "Buôn Đôn Coffee Farm Tour", "0011005512319", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1987), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("cc2057d4-4dea-4d0e-99c5-586a263202f1"), "Sa Pa Eco Farm Tour", "0011004300779", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1975), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("d1b3df6d-5e91-4780-9886-2231ff99b770"), "Redtour", "0011002104702", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2115), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("d7ebe97e-506f-4f3b-9c32-d3b0ed53b191"), "Vũng Tàu Travel", "0011009970742", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2125), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null },
                    { new Guid("db3f9a25-040e-486a-8139-172f920f0e7a"), "Đà Lạt Organic Farm Tour", "0011002817870", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1999), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("e576f815-574e-4312-99d1-28053c4940b9"), "Trang Trại Nông Sản Sạch Tân Châu", "0011004119360", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2010), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("f77d8e2a-97fd-4dc8-924c-1c5bd2e917f0"), "Đất Việt Tour", "0011004990071", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(2111), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null }
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
                    { 1, "SmtpServer", 0, "smtp.gmail.com", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(194), null },
                    { 2, "Port", 0, "587", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(197), null },
                    { 3, "Email", 0, "thangnvse151059@fpt.edu.vn", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(198), null },
                    { 4, "AppPassword", 0, "sllgcjfbkpgcwnmp", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(199), null },
                    { 5, "TmnCode", 1, "7S4BSWDD", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(200), null },
                    { 6, "HashSecret", 1, "RC7QASGETNFSP0EDKUE4IT7X6VRKM4NJ", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(201), null },
                    { 7, "Url", 1, "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(202), null },
                    { 8, "Command", 1, "pay", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(204), null },
                    { 9, "CurrCode", 1, "VND", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(205), null },
                    { 10, "Version", 1, "2.1.0", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(206), null },
                    { 11, "Locale", 1, "vn", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(207), null },
                    { 12, "PaymentBackReturnUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(208), null },
                    { 13, "BookingUrl", 1, "https://localhost:5001/api/tourist/book-tour/return_book", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(209), null },
                    { 14, "OrderUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(210), null }
                });

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0209cdc3-1f77-4eb2-a624-20a429feb140"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(2005), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("2edb6ccc-be39-4e76-bc96-f4ba24238b8e"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1985), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("44ce8d65-0fa4-4edd-b490-ec1c22191599"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1979), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("61f36e55-771e-48b2-b71a-ca1ed13239b9"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(2009), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("720dfde0-ef92-4082-8ef9-8b9fe038ca33"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(2002), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("83e7b88a-48aa-4101-a49b-7a1053425dad"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1990), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("9a1adc97-37f2-418d-afd2-06d2a5f5ac54"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1988), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("ae51a830-0dd0-4033-b625-fc7e1be8fe76"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1993), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("b82b43d2-72e0-4e91-81bd-d97cc6daaf69"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1983), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("beddc0a8-5271-46f6-af20-92380deb6cf0"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1986), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("c23e5757-7c34-462e-85ba-fb983c2c3958"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(2007), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("dcbbdd6a-c14b-4d58-8b17-6ddbecb72168"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1992), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1916), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1914), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("d549690a-59da-4c91-8179-7ba2102800e2"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1910), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("157ef278-f5d4-4eb9-9f56-c50d68411170"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("19e9c900-4ddb-403e-9318-b0401622f780"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("1a192792-cddf-4635-8137-eee0b2eb2197"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("27866973-0e1b-48fe-b5d8-9d38e6bdb898"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("3968c0b3-7437-4be8-bc4d-f589742491b2"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("6ab977a9-f092-40b5-bfbc-41105fcac982"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("8b134392-9342-4bbf-8da9-95630bd808d5"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("8bd7725a-2cfb-43cb-a72e-a7708fbb332b"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("8f09eb53-4207-497a-999f-d5ed4f73a167"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("b5e5f9ab-f143-464e-9ee9-4ae66bbdc938"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("ec97e0d4-565e-4133-a6ff-f445531858ad"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("f52e20aa-bfab-4e56-8cc5-ec205c649bf1"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null }
                });

            migrationBuilder.InsertData(
                table: "ShipAddress",
                columns: new[] { "ShipAddressId", "AccountId", "DefaultAddress", "ToAddress", "ToDistrictId", "ToDistrictName", "ToName", "ToPhone", "ToProvinceId", "ToProvinceName", "ToWardCode", "ToWardName" },
                values: new object[,]
                {
                    { new Guid("a3e2dd63-c5b3-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), true, "789 Điện Biên Phủ, Phường Đa Kao", 1444, "Quận 3", "Lê Hoàng Cường", "0923456789", 202, "Hồ Chí Minh", "20314", "Phường 14" },
                    { new Guid("b2e1cc65-b21b-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), false, "45 Nguyễn Huệ, Phường Bến Thành", 1443, "Quận 2", "Trần Thị Bình", "0912345678", 202, "Hồ Chí Minh", "20211", "Phường Thủ Thiêm" },
                    { new Guid("d4e1dd61-a5b3-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), false, "123 Lê Lợi, Phường Bến Nghé", 1442, "Quận 1", "Nguyễn Văn An", "0901234567", 202, "Hồ Chí Minh", "20109", "Phường Phạm Ngũ Lão" }
                });

            migrationBuilder.InsertData(
                table: "TourCompany",
                columns: new[] { "TourCompanyId", "AddressCompany", "CompanyDescription", "CompanynName", "CreateDate", "EmailCompany", "LogoURL", "UpdateTime", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), "120 Phan Chu Trinh, TP.Huế", "Công ty du lịch chuyên nghiệp tại Huế.", "Havatravel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(296), "contact@havatravel.com", "https://img.freepik.com/premium-vector/tours-travel-logo-with-airplane-passing-blue-world_101890-71.jpg?w=2000", null, new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), "https://havatravel.com/" },
                    { new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), "45 Điện Biên Phủ, Quận 3, TP.HCM", "Chuyên tour du lịch nội địa và quốc tế.", "VietSun Travel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(277), "contact@vietsuntravel.com", "https://th.bing.com/th/id/OIP.nwXDxpVx9hsOdW9efOtlRAHaDq?w=334&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), "https://vietsuntravel.com/" },
                    { new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), "15 Phạm Ngũ Lão, Quận 1, TP.HCM", "Dịch vụ du lịch cao cấp.", "Bamboo Travel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(279), "contact@bambotravel.com", "https://th.bing.com/th/id/OIP.8nxVZ-RcEPQMdis_Yg4TWAHaHa?w=180&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), "https://bambotravel.com/" },
                    { new Guid("22275542-0625-47be-a503-2f13b7576e9b"), "23 Lê Lợi, TP. Phan Thiết", "Chuyên tour khám phá biển và cát trắng.", "Phan Thiết Tours", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(305), "contact@phanthiettours.com", "https://th.bing.com/th/id/OIP.KBj43NwwtJw5Ht71M6ts8gHaF7?rs=1&pid=ImgDetMain", null, new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), "https://phanthiettours.com/" },
                    { new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), "50 Nguyễn Trãi, TP. Vũng Tàu", "Tour du lịch biển chất lượng cao.", "Vũng Tàu Travel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(299), "info@vungtautravel.com", "https://mir-s3-cdn-cf.behance.net/project_modules/1400/2cf01f84467867.5d5da886617be.jpg", null, new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), "https://vungtautravel.com/" },
                    { new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), "90 Nguyễn Văn Linh, Đà Nẵng", "Thông tin và tổ chức tour du lịch.", "Dulichtoday", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(290), "support@dulichtoday.com", "https://png.pngtree.com/png-clipart/20200722/original/pngtree-travel-and-tour-logo-png-image_5051851.jpg", null, new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), "https://dulichtoday.com/" },
                    { new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), "75 Hùng Vương, TP. Nha Trang", "Dịch vụ đặt tour du lịch biển chuyên nghiệp.", "Nha Trang Holiday", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(302), "support@nhatrangholiday.com", "https://th.bing.com/th/id/OIP.inoQUXN-Y4DfWTpe5-ec-gHaFJ?w=241&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), "https://nhatrangholiday.com/" },
                    { new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), "15 Lê Lợi, Quận 1, TP.HCM", "Tour trọn gói, uy tín.", "Fiditour", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(273), "info@fiditour.com", "https://th.bing.com/th/id/OIP.kzYdv7-VmS2zRF7qZaOyvwAAAA?w=212&h=212&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), "https://fiditour.com/" },
                    { new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), "99 Hoàng Diệu, Ba Đình, Hà Nội", "Du lịch chất lượng, giá rẻ.", "Phương Nam Travel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(282), "info@phuongnamtravel.com", "https://th.bing.com/th/id/OIP.p6Shq1r_4g--m-4Q8nIUfgHaHa?rs=1&pid=ImgDetMain", null, new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), "https://phuongnamtravel.com/" },
                    { new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), "10 Lê Thánh Tôn, Quận 1, TP.HCM", "Chuyên tổ chức tour du lịch trong và ngoài nước.", "Đất Việt Tour", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(284), "contact@datviettour.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMJbyGoIQYOyNFDh34TrlaOOozlKmiTefzoQ&s", null, new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), "https://datviettour.com/" },
                    { new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), "20 Trần Hưng Đạo, Hà Nội", "Dịch vụ du lịch chất lượng cao.", "Redtour", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(287), "info@redtour.com.vn", "https://th.bing.com/th/id/OIP.zD605q-X7zzIpJAgyfVvwQHaHa?pid=ImgDet&w=184&h=184&c=7&dpr=1.3", null, new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), "https://redtour.com.vn/" },
                    { new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), "90 Nguyễn Thị Minh Khai, Đà Nẵng", "Chuyên tour biển đảo Đà Nẵng.", "Danang Travel", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(275), "info@danangtravel.com", "https://th.bing.com/th/id/OIP.vj2L0nLe0ocGi4pxbLwnowHaHa?w=200&h=199&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), "https://danangtravel.com/" },
                    { new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), "25 Nguyễn Huệ, Quận 1, TP.HCM", "Lữ hành hàng đầu Việt Nam.", "Saigontourist", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(264), "contact@saigontourist.net", "https://icolor.vn/wp-content/uploads/2021/01/Tham-kh%E1%BA%A3o-Logo-c%C3%B4ng-ty-du-l%E1%BB%8Bch-Saigontourist-3.jpg", null, new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), "https://saigontourist.net/" },
                    { new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"), "66 Trần Phú, TP. Quy Nhơn", "Tour du lịch biển và văn hóa Quy Nhơn.", "Quy Nhơn Explorer", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(326), "contact@quynhonexplorer.com", "https://th.bing.com/th/id/OIP.lVVxjoYVel7RgNeu1hH2RgHaFr?rs=1&pid=ImgDetMain", null, new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), "https://quynhonexplorer.com/" },
                    { new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"), "14 Nguyễn Huệ, TP. Đà Lạt", "Tour du lịch khám phá Đà Lạt.", "Đà Lạt Tour", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(312), "info@dalattour.com", "https://images-platform.99static.com/OowUwWHMa4KA7v_azo1Bq_7ByCs=/6x0:1001x995/500x500/top/smart/99designs-contests-attachments/86/86578/attachment_86578583", null, new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), "https://dalattour.com/" },
                    { new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội", "Tour du lịch nội địa và quốc tế.", "Hanoitourist", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(267), "support@hanoitourist.com", "https://th.bing.com/th/id/OIP.DQh7E8nzGNx-fipB0stcygHaGf?w=190&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), "https://hanoitourist.com/" },
                    { new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), "03 Hai Bà Trưng, Hoàn Kiếm, Hà Nội.", "", "Công ty Cổ phần Vietravel", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "vtv.cholon@vietravel.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyblRzW2ET2uC9wdJBm6_PUq1zCiSi6SGJw&s", null, new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), "https://travel.com.vn/" }
                });

            migrationBuilder.InsertData(
                table: "TouristFacility",
                columns: new[] { "TouristFacilityId", "Address", "ContactInfor", "CreateDate", "Description", "EmailTouristFacility", "LogoURL", "TouristFacilityName", "UpdateTime", "UserId", "Website", "district_id", "district_name", "phone", "province_name", "ward_code", "ward_name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Xã Đàm Thủy, Huyện Trùng Khánh, Cao Bằng", "0206 388 8888", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(399), "Khu du lịch sinh thái kết hợp nông nghiệp tại vùng biên giới Thác Bản Giốc.", "contact@bangiocfarmtour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F2.webp?alt=media&token=401b4f70-d92e-4656-805d-f50712f67043", "Du Lịch Sinh Thái Thác Bản Giốc", null, new Guid("10000000-0000-0000-0000-000000000001"), "www.bangiocfarmtour.vn", 1976, "Huyện Mộc Châu", "0988888999", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Thôn Cát Cát, Xã San Sả Hồ, Sa Pa", "0214 666 7777", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(420), "Tour trải nghiệm nông nghiệp và văn hóa H'Mông tại bản Cát Cát.", "eco@sapa.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F3.jpg?alt=media&token=396747b2-3c0a-4e37-9d13-7f07dea2890f", "Sa Pa Eco Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000002"), "www.sapaecotour.vn", 1976, "Huyện Mộc Châu", "0911777555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Thôn Thái An, Xã Vĩnh Hải, Huyện Ninh Hải", "0259 333 4567", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(424), "Trải nghiệm hái nho, làm rượu vang và nghỉ dưỡng tại thung lũng nho.", "info@grapevalley.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F4.jpg?alt=media&token=25f62207-6552-4052-aca8-608b93335980", "Farm Du Lịch Grape Valley", null, new Guid("10000000-0000-0000-0000-000000000003"), "www.grapevalley.vn", 1976, "Huyện Mộc Châu", "0909000011", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Xóm Cầu Tre, Xã La Bằng, Huyện Đại Từ", "0208 123 4567", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(428), "Du lịch nông nghiệp kết hợp trải nghiệm hái chè, sao chè và thưởng thức tại chỗ.", "farm@daitu.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F5.jpg?alt=media&token=799ba94b-35db-4332-bd15-f16d52411fa1", "Nông Trại Chè Trải Nghiệm Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000004"), "www.daitu-teafarm.vn", 1976, "Huyện Mộc Châu", "0977000111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Xã Ea M’nang, Huyện Cư M’gar, Đắk Lắk", "0262 888 8899", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(436), "Tour trải nghiệm vườn cà phê, tham quan quy trình rang xay và cưỡi voi Buôn Đôn.", "visit@buondoncoffee.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F6.jpg?alt=media&token=f81fee5d-3e8e-4aa8-a25b-0526c1daab9d", "Buôn Đôn Coffee Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000005"), "www.buondoncoffee.vn", 1976, "Huyện Mộc Châu", "0918888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Xã Sà Phìn, Huyện Đồng Văn", "0219 366 6888", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(439), "Trải nghiệm cuộc sống vùng cao, làm nông, làm bánh truyền thống và trekking đèo đá.", "trek@hagiang.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F7.jpg?alt=media&token=3a5d4f25-f909-4d81-a4b3-0a7d3a945c26", "Hà Giang Farmstay & Trek", null, new Guid("10000000-0000-0000-0000-000000000006"), "www.hagiangfarmstay.vn", 1976, "Huyện Mộc Châu", "0988999111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Xã Trà Linh, Huyện Nam Trà My", "0235 322 3222", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(442), "Khám phá vườn sâm Ngọc Linh, trải nghiệm trồng sâm, thưởng thức dược liệu.", "info@tramyfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F8.jpg?alt=media&token=8d9dca9e-1aaf-43f6-bd36-d8d512972744", "Trà My Sâm Ngọc Linh Tour", null, new Guid("10000000-0000-0000-0000-000000000007"), "www.tramyfarmtour.vn", 1976, "Huyện Mộc Châu", "0966555777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Phường 7, Thành phố Đà Lạt", "0263 355 8888", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(452), "Du lịch trải nghiệm trồng dâu, làm rau thủy canh, check-in nông trại xanh.", "info@dalatorganic.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F9.jpg?alt=media&token=eb13f3b8-e307-4907-865b-27b5f25c34ab", "Đà Lạt Organic Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000008"), "www.dalatorganic.vn", 1976, "Huyện Mộc Châu", "0933222111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Xã Phan Thanh, Huyện Bắc Bình", "0252 355 9000", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(455), "Trải nghiệm hái nho, tham quan vườn thanh long sạch và picnic giữa đồng nắng gió Bình Thuận.", "hello@binhthuanfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F10.jpg?alt=media&token=0113dd93-8a2e-478d-9ac1-e165995e1936", "Farmstay Nho & Thanh Long Bắc Bình", null, new Guid("10000000-0000-0000-0000-000000000009"), "www.binhthuanfarm.vn", 1976, "Huyện Mộc Châu", "0933444555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Xã Nam Mẫu, Huyện Ba Bể", "0209 366 2333", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(458), "Trải nghiệm chèo thuyền, nông nghiệp sinh thái, ở nhà sàn truyền thống người Tày.", "contact@babeecotour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F11.jpg?alt=media&token=81df566c-b4ed-4591-acc0-f17238f14f21", "Ba Bể Lake Ecofarm Tour", null, new Guid("10000000-0000-0000-0000-000000000010"), "www.babeecotour.vn", 1976, "Huyện Mộc Châu", "0966001122", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Xã Tân Hưng, Huyện Tân Châu", "0276 366 7788", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(461), "Khám phá quy trình trồng rau hữu cơ, nuôi bò sữa, làm sữa chua và trồng nấm sạch.", "info@tayninhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F12.jpg?alt=media&token=0393caa4-5c9e-4bde-bf5b-b68712ec4469", "Trang Trại Nông Sản Sạch Tân Châu", null, new Guid("10000000-0000-0000-0000-000000000011"), "www.tayninhfarm.vn", 1976, "Huyện Mộc Châu", "0944111222", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Xã An Chấn, Huyện Tuy An", "0257 388 8888", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(464), "Trải nghiệm canh tác rau ven biển, tắm biển, đốt lửa trại và học làm nước mắm truyền thống.", "tour@phuyentour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F13.jpg?alt=media&token=9c9796b8-e39a-48d1-8863-0fc7142ae7b4", "Trải nghiệm Nông trại Biển & Rau Tuy An", null, new Guid("10000000-0000-0000-0000-000000000012"), "www.phuyentour.vn", 1976, "Huyện Mộc Châu", "0977222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Xã Mỹ Long Bắc, Huyện Càng Long", "0294 355 1122", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(468), "Khám phá quy trình sản xuất mắm, trồng cây ăn trái và sản phẩm nông sản sạch.", "contact@travinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F14.jpg?alt=media&token=843e14d6-3851-4315-bc98-6260f35d3d4e", "Trang Trại Nông Sản Sạch Càng Long", null, new Guid("10000000-0000-0000-0000-000000000013"), "www.travinhfarm.vn", 1976, "Huyện Mộc Châu", "0908222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Xã Mỹ Xuyên, Huyện Mỹ Xuyên", "0299 555 2333", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(472), "Trải nghiệm mô hình nông nghiệp hữu cơ, tham quan các cánh đồng lúa, vườn cây ăn trái.", "tour@soctrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F15.jpg?alt=media&token=7342e675-73c3-43d0-97cc-684082c6ee44", "Mỹ Xuyên Farmstay", null, new Guid("10000000-0000-0000-0000-000000000014"), "www.soctrangfarm.vn", 1976, "Huyện Mộc Châu", "0933112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Xã Vĩnh Tế, Huyện Châu Đốc", "0296 388 1133", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(475), "Trải nghiệm canh tác nông nghiệp tại đồng bưng, tham quan vườn trái cây đặc sản miền Tây.", "contact@angiangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F16.jpg?alt=media&token=9e2b8638-1acb-4191-9a20-b41aabf0e29f", "Trang Trại Châu Đốc", null, new Guid("10000000-0000-0000-0000-000000000015"), "www.angiangfarm.vn", 1976, "Huyện Mộc Châu", "0977445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Xã Nhơn Ái, Huyện Phong Điền", "0292 388 1222", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(478), "Trải nghiệm mô hình trồng cây trái, tham quan các vườn rau hữu cơ và chợ nổi Cần Thơ.", "info@canthoexplore.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F17.jpg?alt=media&token=69beecb6-461f-4481-899f-3674b48c06f4", "Cần Thơ Farmstay", null, new Guid("10000000-0000-0000-0000-000000000016"), "www.canthoexplore.vn", 1976, "Huyện Mộc Châu", "0939332111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Xã Cửa Dương, Huyện Phú Quốc", "0297 223 4455", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(481), "Tham quan mô hình nông nghiệp hữu cơ, vườn dưa lưới, vườn trái cây nhiệt đới.", "tour@phuquocfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F18.jpg?alt=media&token=3e95d7ab-1114-421e-bb7b-defe761897e8", "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, new Guid("10000000-0000-0000-0000-000000000017"), "www.phuquocfarm.vn", 1976, "Huyện Mộc Châu", "0909888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Xã Đồng Mai, TP. Hạ Long", "0203 356 7890", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(484), "Trải nghiệm mô hình trồng rau hữu cơ và nuôi trồng thủy sản, tham quan khu vườn cây ăn trái đặc sản.", "info@halongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F19.jpg?alt=media&token=e8f5ef36-21fa-426b-a36b-9f9c9e709591", "Trại Nông Sản Hạ Long", null, new Guid("10000000-0000-0000-0000-000000000018"), "www.halongfarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Xã An Thắng, Huyện An Lão", "0225 350 1000", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(487), "Khám phá mô hình trồng trọt và chăn nuôi, học hỏi cách trồng rau sạch và gia cầm.", "contact@anlaofarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F20.jpg?alt=media&token=c8f94cf0-425e-45b1-9745-f0ed7c51a609", "Trang Trại Nông Sản An Lão", null, new Guid("10000000-0000-0000-0000-000000000019"), "www.anlaofarm.vn", 1976, "Huyện Mộc Châu", "0932556789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Xã Phú Lạc, Huyện Đại Từ", "0208 382 5000", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(490), "Trải nghiệm các hoạt động nông nghiệp như trồng lúa, chăm sóc vườn rau và tham gia các hoạt động nông dân.", "tour@daitufarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F21.jpg?alt=media&token=0402e7c8-075d-4cb0-bbea-98efe121ede8", "Nông Trại Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000020"), "www.daitufarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Xã Nghi Phú, TP. Vinh", "0238 379 1111", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(494), "Khám phá các vườn cây ăn trái, trồng rau hữu cơ và tìm hiểu về sản phẩm nông sản của vùng đất xứ Nghệ.", "contact@vinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F22.jpg?alt=media&token=eb04cf86-f0c9-4301-977b-89e9cbd7d75e", "Trại Nông Sản Vinh", null, new Guid("10000000-0000-0000-0000-000000000021"), "www.vinhfarm.vn", 1976, "Huyện Mộc Châu", "0912233445", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Xã Sơn Lâm, Huyện Triệu Sơn", "0237 375 6789", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(497), "Tham gia vào các hoạt động nông nghiệp như thu hoạch rau, chăm sóc cây ăn trái, tham quan vườn thuốc nam.", "contact@trieusonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F23.jpg?alt=media&token=3855d2e9-4a16-4c6f-b5db-da2623520b5d", "Trang Trại Nông Sản Triệu Sơn", null, new Guid("10000000-0000-0000-0000-000000000022"), "www.trieusonfarm.vn", 1976, "Huyện Mộc Châu", "0988112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Xã Thạch Hưng, TP. Hà Tĩnh", "0239 354 5678", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(500), "Khám phá nông sản hữu cơ, tham gia các hoạt động làm vườn và trồng cây ăn quả.", "contact@hatinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F24.jpg?alt=media&token=c759c7e9-f707-4c22-afdd-13809209e5cf", "Trại Nông Sản Hà Tĩnh", null, new Guid("10000000-0000-0000-0000-000000000023"), "www.hatinhfarm.vn", 1976, "Huyện Mộc Châu", "0916889900", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Xã Quảng Phú, TP. Đồng Hới", "0232 382 7890", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(503), "Trải nghiệm nông nghiệp sinh thái với các mô hình trồng cây, chăm sóc động vật và tham quan các khu vườn.", "contact@donghoifarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F25.jpg?alt=media&token=fbb74270-5fe0-4a44-ba94-4b9a0ebd9a61", "Trang Trại Đồng Hới", null, new Guid("10000000-0000-0000-0000-000000000024"), "www.donghoifarm.vn", 1976, "Huyện Mộc Châu", "0977223344", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Xã Hải Lệ, TP. Đông Hà", "0233 350 5678", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(506), "Khám phá các mô hình trồng cây dược liệu và rau hữu cơ, tham gia các hoạt động chăm sóc động vật.", "contact@donghafarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F26.jpg?alt=media&token=1e91565d-c6ba-43f2-b73f-35c6710abcc5", "Trang Trại Nông Sản Đông Hà", null, new Guid("10000000-0000-0000-0000-000000000025"), "www.donghafarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Xã Phước Sơn, TP. Quy Nhơn", "0256 382 7890", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(509), "Tham gia vào các hoạt động trồng rau hữu cơ và chăm sóc vườn trái cây, tìm hiểu sản phẩm nông sản đặc trưng của Bình Định.", "contact@quynhonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F27.jpg?alt=media&token=a7f4dd9e-46f1-450e-850b-0733e35be659", "Trại Nông Sản Quy Nhơn", null, new Guid("10000000-0000-0000-0000-000000000026"), "www.quynhonfarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Xã Hòa Thịnh, TP. Tuy Hòa", "0257 355 6789", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(512), "Trải nghiệm các hoạt động trồng trọt, chăm sóc vườn cây ăn quả, tìm hiểu về các sản phẩm nông sản đặc biệt của Phú Yên.", "contact@tuyhoafarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F28.jpg?alt=media&token=7c964137-2b0f-4ed8-aea7-7393bd154599", "Trang Trại Nông Sản Tuy Hòa", null, new Guid("10000000-0000-0000-0000-000000000027"), "www.tuyhoafarm.vn", 1976, "Huyện Mộc Châu", "0972345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "Xã Vĩnh Thạnh, TP. Nha Trang", "0258 382 9000", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(515), "Khám phá các mô hình trồng cây ăn quả, rau hữu cơ, và các hoạt động du lịch nông nghiệp kết hợp nghỉ dưỡng.", "contact@nhatrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F29.jpg?alt=media&token=80ea2316-f380-48f7-bc74-7919f6d2e718", "Trại Nông Sản Nha Trang", null, new Guid("10000000-0000-0000-0000-000000000028"), "www.nhatrangfarm.vn", 1976, "Huyện Mộc Châu", "0916345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Xã Phước Hải, TP. Phan Rang-Tháp Chàm", "0259 382 1111", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(519), "Trải nghiệm du lịch nông nghiệp, tham quan các vườn cây ăn quả, mô hình trồng nho và sản xuất nông sản.", "contact@phanrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F30.jpg?alt=media&token=5c8bf85f-5ac6-4d67-bde7-20cdbe7ac7f7", "Trại Nông Sản Phan Rang", null, new Guid("10000000-0000-0000-0000-000000000029"), "www.phanrangfarm.vn", 1976, "Huyện Mộc Châu", "0934567890", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Xã Phú Hài, TP. Phan Thiết", "0252 382 5678", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(526), "Trải nghiệm các mô hình trồng cây nông sản và khám phá các sản phẩm đặc trưng của Bình Thuận như thanh long, dừa.", "contact@phanthietfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F31.jpg?alt=media&token=44480008-26be-4bef-96f2-4ebf5375dc35", "Trang Trại Nông Sản Phan Thiết", null, new Guid("10000000-0000-0000-0000-000000000030"), "www.phanthietfarm.vn", 1976, "Huyện Mộc Châu", "0982334455", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Xã An Thạnh, TP. Tân An", "0272 384 5000", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(545), "Khám phá các mô hình trồng cây, chăm sóc cây ăn trái, và tìm hiểu về sản phẩm nông sản của Long An.", "contact@tananfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F32.jpg?alt=media&token=bc7d9acf-b383-4306-b69c-e9bf9d52f0a5", "Trại Nông Sản Tân An", null, new Guid("10000000-0000-0000-0000-000000000031"), "www.tananfarm.vn", 1976, "Huyện Mộc Châu", "0932456789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Xã Phước Hòa, TP. Vĩnh Long", "0270 382 8888", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(548), "Trải nghiệm du lịch nông nghiệp tại vườn cây ăn trái, học hỏi kỹ thuật trồng rau sạch và các hoạt động sinh thái.", "contact@vinhlongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F33.jpg?alt=media&token=65103687-a722-4ba0-84f9-0b6eff272d30", "Trại Nông Sản Vĩnh Long", null, new Guid("10000000-0000-0000-0000-000000000032"), "www.vinhlongfarm.vn", 1976, "Huyện Mộc Châu", "0913445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), "Số 117 đường Hoàng Quốc Việt – TTNT Mộc Châu ( Ngã tư Vườn Đào )", "0946 166 538", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Là công ty trẻ tại Mộc Châu, tiên phong cung cấp những dịch vụ du lịch gắn liền với thiên nhiên, văn hóa các dân tộc Mộc Châu, Vân Hồ.\r\nHiện đang khai thác những tour du lịch khám phá nông nghiệp Mộc Châu, khám phá văn hóa đời sống các dân tộc và các chương trình du lịch thiện nguyện, cắm trại, teambuilding, thể thao, MICE…", "dulichmocchaumoc@gmail.com", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F1.png?alt=media&token=f86dba4c-f25c-4c65-adc9-c2e662b1deb5", "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, new Guid("a631bb94-66d8-44db-932b-532892d87754"), "www.mocchaumoc.com", 1976, "Huyện Mộc Châu", "0987654321", "Sơn La", "91295", "Phường 14" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000001") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000002") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000032") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000033") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000034") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000035") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000036") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000037") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000038") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000039") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000040") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000041") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000042") },
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000018") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000019") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000020") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000021") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000022") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000023") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000024") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000025") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000026") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000027") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000028") },
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
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f1") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f2") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1927), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1928), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"), "anhNv@gmail.com", "Nguyễn Văn Anh", true, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1918), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1921), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1933), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1934), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1930), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1931), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"), "BinhLeV@gmail.com", "Lê Văn Bình", true, 3, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1923), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1924), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
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
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Khách sạn trung tâm, giá hợp lý.", "Khách sạn Thành Đạt", "Số 707, Đường Lý Thường Kiệt, Quảng Ninh", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0896541237", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Khách sạn trung tâm, giá hợp lý.", "Khách sạn TherHouse", "38 Phan Đình Giót, TT. Mộc Châu, Mộc Châu, Sơn La", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Hostel%2Funnamed.webp?alt=media\\u0026token=76609c66-a696-4481-aa4f-d05fe8e15631\"]", "0966 124 194", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") }
                });

            migrationBuilder.InsertData(
                table: "AgriculturalTourPackage",
                columns: new[] { "TourId", "ChildTicketAge", "CreateDate", "Description", "Durations", "DurationsType", "EndTime", "Imgs", "PackageName", "PriceOfAdults", "PriceOfChildren", "Slot", "StartTime", "StatusActive", "TourCompanyId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(881), "Trải nghiệm cuộc sống nông dân tại vùng biên giới, từ gieo trồng, chăm sóc gia súc đến thu hoạch nông sản cùng người dân địa phương.", 1.0, 3, new DateTime(2024, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]", "Một Ngày Làm Nông Dân Vùng Biên", 1500000.0, 1200000.0, 15, new DateTime(2024, 4, 15, 7, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(886), "Tham gia vào hoạt động thu hoạch mùa vụ cùng người dân địa phương, từ thu hoạch đến sơ chế và thưởng thức sản phẩm tươi ngon tại chỗ.", 1.0, 3, new DateTime(2024, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]", "Trải Nghiệm Thu Hoạch Mùa Vụ", 1500000.0, 1200000.0, 20, new DateTime(2024, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(890), "Hành trình khám phá nét văn hóa độc đáo và hoạt động nông nghiệp truyền thống của đồng bào dân tộc Tày - Nùng, từ trải nghiệm trồng trọt đến thưởng thức ẩm thực và nghệ thuật dân gian.", 1.0, 3, new DateTime(2024, 5, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]", "Khám Phá Nông Nghiệp và Văn Hóa Địa Phương", 1500000.0, 1200000.0, 20, new DateTime(2024, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(895), "Trải nghiệm độc đáo kết hợp giữa học tập phương pháp canh tác hữu cơ và nghỉ dưỡng tại homestay sinh thái. Du khách được tham gia vào quy trình trồng trọt sạch và tận hưởng không gian yên bình của thiên nhiên.", 1.0, 3, new DateTime(2024, 5, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]", "Du Lịch Canh Tác Hữu Cơ Kết Hợp Nghỉ Dưỡng", 1500000.0, 1200000.0, 15, new DateTime(2024, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(900), "Trải nghiệm độc đáo về văn hóa nông nghiệp truyền thống của người H'Mông tại Cát Cát, từ canh tác trên ruộng bậc thang đến thu hái thuốc nam và nấu ăn truyền thống.", 1.0, 3, new DateTime(2024, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]", "Một Ngày Làm Nông Dân H'Mông", 1500000.0, 1200000.0, 12, new DateTime(2024, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(907), "Khám phá đời sống văn hóa độc đáo của người H'Mông tại bản Cát Cát, tìm hiểu về nông nghiệp hữu cơ và trải nghiệm làm nghề thủ công truyền thống.", 1.0, 3, new DateTime(2024, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]", "Hành Trình Khám Phá Bản Làng và Nông Nghiệp Hữu Cơ", 1500000.0, 1200000.0, 15, new DateTime(2024, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(842), "Hành trình trải nghiệm nông nghiệp độc đáo tại Mộc Châu, từ tham quan nông trại dâu tây, vắt sữa bò đến thu hoạch rau hữu cơ. Du khách sẽ được trực tiếp tham gia vào các hoạt động nông nghiệp và thưởng thức đặc sản địa phương.", 1.0, 3, new DateTime(2024, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\"]", "Khám Phá Nông Nghiệp Mộc Châu", 1500000.0, 1200000.0, 20, new DateTime(2024, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(862), "Trải nghiệm một ngày làm việc thực tế tại nông trại OCOP, từ chăm sóc vườn rau đến thu hoạch và đóng gói sản phẩm theo tiêu chuẩn.", 1.0, 3, new DateTime(2024, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", "Một Ngày Làm Nông Dân OCOP", 1500000.0, 1200000.0, 12, new DateTime(2024, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(855), "Trải nghiệm văn hóa trà truyền thống tại Mộc Châu, từ tham quan đồi chè, học cách hái và chế biến chè, đến thưởng thức các loại trà OCOP đặc sản.", 1.0, 3, new DateTime(2024, 3, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", "Tour Hái Chè và Thưởng Trà OCOP", 1500000.0, 1200000.0, 15, new DateTime(2024, 3, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(875), "Kết hợp du lịch với hoạt động thiện nguyện và bảo vệ môi trường, từ trồng cây xanh đến tham gia các hoạt động cộng đồng tại bản làng.", 1.0, 3, new DateTime(2024, 4, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", "Du Lịch Thiện Nguyện & Nông Nghiệp Xanh", 1500000.0, 1200000.0, 25, new DateTime(2024, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("9ee17d55-b451-496b-9fd5-8461756b0ab9"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1855), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1853), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1853), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("aa443ee0-7d8f-4fd8-b9d9-e1d41bad03ce"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1850), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1849), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1848), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
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
                    { new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), "Không đường, không chất bảo quản, giữ lạnh ở 4°C.", "Dairy Farm, Mộc Châu", "Từ 1 tuổi trở lên", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(764), "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F4.jpg?alt=media\\u0026token=cc2b259e-55e1-4ee8-bd6e-7f619a3ca9b9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F5.jpg?alt=media\\u0026token=b4c42af8-a554-496f-933f-ee72eaa99ad7\"]", "100% sữa bò tươi", "Trang trại bò sữa Mộc Châu", "Canxi, Vitamin D, Protein", "Mộc Châu, Sơn La", 45000.0, 6, "Sữa tươi thanh trùng Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "1L" },
                    { new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(682), "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media\\u0026token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media\\u0026token=bad36b93-8f59-4463-8622-b0a7ea89821e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media\\u0026token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media\\u0026token=7c347385-45bd-474f-9930-77dca305655c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media\\u0026token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media\\u0026token=d3542914-5791-4d36-95a6-071e554aa407\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media\\u0026token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 0, "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(742), "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media\\u0026token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media\\u0026token=13fdd758-187b-44b8-9b9f-e9fb47148524\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media\\u0026token=be498a71-dc12-42a0-bebd-844b732aa1c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media\\u0026token=41f13948-a8de-49ff-88d4-a37b46dd87b8\"]", "Tía tô, cỏ ngọt", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "150g" },
                    { new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(750), "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media\\u0026token=b855f4ab-4b51-43ea-af26-e0deb629f97c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media\\u0026token=15012cad-7f6f-4cae-842c-c1e8e35d0c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media\\u0026token=0576465d-964e-4ffc-93fa-54f410c761e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media\\u0026token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media\\u0026token=521f7498-9a95-424e-884b-72b611b6f0ee\"]", "Trầm hương, Bột Trầm Hương", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 6, "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 0, null, "1kg" },
                    { new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Trà túi lọc & lá trà", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(725), "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media\\u0026token=5218426e-19ff-4feb-b968-93e08e7f6c92\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media\\u0026token=65af2dec-b460-4f5c-8c4b-8c76b6581a83\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media\\u0026token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media\\u0026token=94412ff3-d1eb-427a-8114-3290d62edd31\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media\\u0026token=1cade255-31ff-4248-ac2f-0f2f8513b33c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media\\u0026token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media\\u0026token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media\\u0026token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53\"]", "Trà xanh, Khác", "Xưởng Mộc Việt", "Truyền thống", "Việt Nam", 80000.0, 1, "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null, null, "10 bông" },
                    { new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(702), "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media\\u0026token=1b2c7198-56da-46dc-bef8-c1371e4bbd16\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media\\u0026token=feac05a6-f278-4bae-85ab-4a9453decd2a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media\\u0026token=153f06d6-d1ee-4781-a17a-b43c0028fbea\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media\\u0026token=0cf39ab3-b794-4d99-90a6-4d4026b690d8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media\\u0026token=0f2875bb-7146-4a3d-8774-d449d78a925a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media\\u0026token=4ef86b59-4468-4e52-af69-5084c99281c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media\\u0026token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media\\u0026token=1c52bcc3-1800-4c86-a874-842c62dca2af\"]", "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU", "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 0, "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "750g" },
                    { new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(734), "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media\\u0026token=5e7d93e8-e10e-47e1-be82-573a9436bdca\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media\\u0026token=7b8fd32b-486b-4fec-bb89-ec59959708d0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media\\u0026token=d7b0593b-a8a7-44de-917a-35e3699f5cd1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media\\u0026token=daa304f2-2707-486e-862e-e39f5aff3c25\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media\\u0026token=e9b4469d-a2c9-458a-ba20-e2968a4db706\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media\\u0026token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce\"]", null, "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 1, "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "750ml" },
                    { new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.", "Mộc Châu Xanh, Mộc Châu", "Tất cả mọi người", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(776), "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F6.jpg?alt=media\\u0026token=2579c65f-9b67-42f3-a052-3c1fc19c509f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F7.jpg?alt=media\\u0026token=8532128f-6b27-4059-a04b-e912b62f0556\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F8.jpg?alt=media\\u0026token=d1f4592d-ea8d-42a2-b975-ef99493f8f33\"]", "100% rau cải ngọt hữu cơ", "Trang trại rau hữu cơ Mộc Châu Xanh", "Vitamin A, Vitamin C, Sắt", "Mộc Châu, Sơn La", 25000.0, 6, "Rau cải ngọt hữu cơ Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500g" },
                    { new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", "Người lớn", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(666), "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media\\u0026token=8df7ec0c-528c-4420-b9d8-1aa642cf458b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media\\u0026token=e4a624c3-296d-4553-812e-c17832510225\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media\\u0026token=b6600b96-94ef-473e-ba86-72a4f5568635\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media\\u0026token=2df35c4e-8b69-4210-80f3-58f6dee45ac5\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\"]", "Tinh bột nghệ, Mật ong nguyên chất", "Xưởng Mộc Việt", "Nghệ", "Việt Nam", 80000.0, 2, "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500ml" },
                    { new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.", "Bản Áng, Mộc Châu", "Từ 12 tuổi trở lên", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(781), "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F9.jpg?alt=media\\u0026token=fe337e6e-fe5f-43d7-8a94-622137e2dd3f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F10.jpg?alt=media\\u0026token=2d61b4e2-0451-467a-9ca8-ef26a6cb603f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F11.jpg?alt=media\\u0026token=28e3c536-92a5-4dd8-9dda-c70f3e8b34c0\"]", "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu", "Nhà hàng Truyền thống Bản Áng", "Protein, Vitamin C, Vitamin A", "Mộc Châu, Sơn La", 200000.0, 0, "Món ăn đặc sản Mộc Châu", null, 0, new Guid("10000000-0000-0000-0000-000000000001"), 1, null, "Một suất ăn" },
                    { new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), "Không chất bảo quản, đóng lọ thủy tinh cao cấp.", "Bản Áng, Mộc Châu, Sơn La", "Từ 3 tuổi trở lên", new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(758), "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F1.jpg?alt=media\\u0026token=b474731f-3c05-418e-ac71-9e7bd36f85d2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F2.jpg?alt=media\\u0026token=7b48babb-d847-4333-ad7f-332c2c051698\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F3.jpg?alt=media\\u0026token=1316b40a-1b2d-4160-a798-905976414bdc\"]", "Dâu tây tươi, đường mía, nước cốt chanh", "Hợp tác xã Nông sản Dâu Mộc Châu", "Vitamin C, Chất xơ", "Mộc Châu, Sơn La", 95000.0, 0, "Mứt dâu tây Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "250g" },
                    { new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(716), "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media\\u0026token=fb9ba94c-fdec-47fb-b782-f145d2b611e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media\\u0026token=4b849fd1-6be9-4fa5-846c-c1865071899d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media\\u0026token=d50897e6-af7d-47bd-bc4b-e8e196dd65af\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media\\u0026token=facf05b2-93fb-4519-b412-b73961492d1f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media\\u0026token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media\\u0026token=47195d9c-a6f1-4416-a67b-cae2ba719f10\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media\\u0026token=5a284068-ab8c-486e-a50a-407e1ed4489d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media\\u0026token=a0c04528-e4db-427c-984d-f1ef780fd838\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourGuide",
                columns: new[] { "GuideId", "Bio", "CreateDate", "ExpertiseArea", "Languages", "Rating", "TourCompanyId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Expert in eco-tourism with 5 years of experience.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(971), "Eco-farming, fruit orchards", "English, French", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Specialist in sustainable agriculture tours.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(976), "Tea plantations, organic farming", "English, Spanish", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(977), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Guided over 200 eco-tours with top reviews.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(983), "Mountain trekking, herbal farming", "English, Vietnamese", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Passionate about agritourism and cultural exchange.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(987), "Coffee plantations, farm stays", "English, German", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "10 years of experience in eco-tourism industry.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(989), "Rice farming, eco-tourism", "English, Chinese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "An expert in organic farming and sustainable tourism.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(992), "Tea plantations, eco-farms", "English, Korean", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(992), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Combining tourism and local culture for unique experiences.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(995), "Cultural farming, organic coffee", "English, Japanese", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bringing sustainable travel to the next level.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(998), "Tropical fruit farms, eco-friendly tours", "English, Thai", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(998), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Guiding farm tours with an educational approach.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1002), "Dairy farming, vineyard tours", "English, Portuguese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Committed to authentic rural tourism experiences.", new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1005), "Olive farming, agritourism", "English, Italian", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1006), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") }
                });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2078), "Tham gia gieo trồng rau hữu cơ, thu hoạch nông sản, học cách chăm sóc trâu bò, và dùng cơm trưa với người dân bản địa.", 1.0, 3, "Một ngày làm nông dân vùng biên", 1200000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2080), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa; tìm hiểu quy trình chế biến thực phẩm sạch tại trang trại.", 6.0, 2, "Trải nghiệm thu hoạch mùa vụ", 950000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2082), "Kết hợp hoạt động nông nghiệp với giao lưu văn hóa dân tộc Tày - Nùng, thưởng thức các món ăn truyền thống và xem múa hát dân gian.", 2.0, 3, "Khám phá nông nghiệp và văn hóa địa phương", 1800000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2085), "Tham gia làm vườn, chăm sóc cây trồng không hóa chất, nghỉ dưỡng tại homestay chuẩn sinh thái ngay chân núi.", 2.0, 3, "Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng", 2500000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2087), "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.", 1.0, 3, "Một ngày làm nông dân H'Mông", 1450000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2090), "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.", 8.0, 2, "Hành trình khám phá bản làng và nông nghiệp hữu cơ", 1650000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2095), "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.", 2.0, 3, "Farmstay Sa Pa 2N1Đ", 2700000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2098), "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.", 1.0, 3, "Chợ phiên & nông nghiệp vùng cao", 1100000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2063), "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.", 6.0, 2, "Khám phá nông nghiệp Mộc Châu", 3500000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2073), "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.", 1.0, 3, "Một ngày làm nông dân OCOP", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2069), "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.", 4.0, 2, "Tour hái chè và thưởng trà OCOP", 2800000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2075), "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.", 2.0, 3, "Du lịch thiện nguyện & nông nghiệp xanh", 4000000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"), "Chăm sóc vườn hoa và cây cảnh", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2307), "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F151.jpg?alt=media\\u0026token=637e2ba5-283d-406b-8604-e7a908ebab2d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F152.jpg?alt=media\\u0026token=e6bd1f38-1a76-4d4d-ada9-25da7f51686f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F153.jpg?alt=media\\u0026token=130839fb-7bbe-4186-bf90-ca1419a80582\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F154.jpg?alt=media\\u0026token=78e68037-8fcd-4fbc-a0d6-7ac9752e33bf\"]", "Vườn hoa du lịch – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"), "Tham quan đồi chè Mộc Châu", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2226), "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", "Đồi chè trái tim – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"), "Hoạt động từ thiện tại bản làng", 30.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2288), "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", "Bản làng vùng cao Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), "Tham quan nông trại dâu tây", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2169), "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F14.jpg?alt=media\\u0026token=19367ec0-3dd2-4349-abcf-fc17911ca4ec\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F15.jpg?alt=media\\u0026token=eebc5140-5778-4ab7-b128-7ec04c37f2b4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F16.jpg?alt=media\\u0026token=7d281318-7494-4c09-b7bb-8bf61c965fc0\"]", "Nông trại Dâu Mộc Châu – Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"), "Chế biến thực phẩm từ nông sản địa phương", 20.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2315), "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F161.jpg?alt=media\\u0026token=2d7d29c8-3636-405f-9567-2a4aaae97c30\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F162.jpg?alt=media\\u0026token=9ad86d97-f35d-468b-8937-d1c4d461b0c3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F163.jpg?alt=media\\u0026token=435f2187-da87-4cae-8b17-5f103f7b1f11\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F164.jpg?alt=media\\u0026token=1008643c-57d9-4b73-adee-a61dfa3a3a85\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F165.jpg?alt=media\\u0026token=be1854b6-921a-4b31-92b4-a8eb074729d0\"]", "Xưởng chế biến thực phẩm – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"), "Chăm sóc vườn rau hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2264), "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", "Vườn rau hữu cơ – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"), "Tham gia chế biến chè thủ công", 5.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2243), "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F71.jpg?alt=media\\u0026token=8c694cc7-240c-4eac-a670-a458de5a8964\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F72.jpg?alt=media\\u0026token=9d082c03-94b1-4bc2-941d-3d80077481cf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F73.jpg?alt=media\\u0026token=955ef861-00bc-479f-ae3f-083a78f72624\"]", "Xưởng chè OCOP Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"), "Trồng cây xanh tại khu vực du lịch", 20.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2297), "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F141.jpg?alt=media\\u0026token=17bafc4a-ca33-416e-8b02-4d5ed8708569\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F142.jpg?alt=media\\u0026token=59c221c3-f2a5-4065-9282-37bf5874be3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F143.jpg?alt=media\\u0026token=6ad7d043-ae31-4bb0-a41c-d5f0f9b70e87\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F144.jpg?alt=media\\u0026token=4f03a1ff-ae27-476f-9a83-c69225dd0c3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F145.jpg?alt=media\\u0026token=0c56159a-0c55-49cc-afe2-86c8de27db2f\"]", "Khu du lịch Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), "Vắt sữa bò tại trang trại", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2205), "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F21.jpg?alt=media\\u0026token=5a725c29-f7ed-4f52-89e0-94e0f768b8e3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F22.jpg?alt=media\\u0026token=244dc720-f725-42ed-bbf1-a28f3a59178d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F23.jpg?alt=media\\u0026token=1a44b12f-8bc0-48d6-b1bb-15a2cb7d3b61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F24.jpg?alt=media\\u0026token=ccea313e-1a38-438c-b47f-2603da9a003f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F25.jpg?alt=media\\u0026token=7667d7c8-ec34-444a-bfd6-254fa545febb\"]", "Trang trại bò sữa Dairy Farm", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000001"), "Gieo trồng rau hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2323), "Hướng dẫn kỹ thuật gieo hạt, làm đất và chăm sóc rau theo phương pháp hữu cơ tại nông trại vùng cao.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]", "Nông trại hữu cơ – xã biên giới", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000002"), "Thu hoạch nông sản", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2332), "Trải nghiệm thu hoạch rau củ quả đúng vụ, phân loại và sơ chế tại chỗ theo hướng dẫn của người dân bản địa.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F191.jpg?alt=media\\u0026token=1ae42618-5c61-40f9-af64-b673a2e8b6cc\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F192.jpg?alt=media\\u0026token=ec22f901-1f9b-4d62-8a9b-2efdb9c7a95a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F193.jpg?alt=media\\u0026token=ad98ddae-0d85-474d-a14e-a46cac5292da\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F194.jpg?alt=media\\u0026token=b33f2e48-75dd-4935-896a-e2bed0e81b8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F195.jpg?alt=media\\u0026token=68e9d11f-5627-4847-bee1-06d127911ba1\"]", "Ruộng nông sản – xã biên giới", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000003"), "Chăm sóc trâu bò", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2336), "Học cách tắm rửa, cho ăn và dắt trâu ra đồng cùng người dân – trải nghiệm đời sống chăn nuôi thực tế.", 0.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F201.jpg?alt=media\\u0026token=c8aa9368-60b3-4754-8e68-183ec49665a3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F202.jpg?alt=media\\u0026token=bdfa0975-acef-4887-b0bc-43140a5cb23b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F203.jpg?alt=media\\u0026token=7c780014-a798-4891-ad34-a76992d7b532\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F204.jpg?alt=media\\u0026token=aceb4ca4-7664-4fe6-a325-aa77566c78ec\"]", "Chuồng trại địa phương", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000004"), "Dùng cơm trưa với người dân bản địa", 0.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2345), "Thưởng thức bữa cơm dân dã tại nhà người dân với các món đặc sản vùng cao: măng xào, cá suối nướng, cơm lam...", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F211.jpg?alt=media\\u0026token=073d2ffd-c38c-42be-adcd-eeede14e7599\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F212.jpg?alt=media\\u0026token=823c928e-ca0d-4325-a4b7-b468d4186329\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F213.jpg?alt=media\\u0026token=61107119-364a-4a1e-acef-eb88ca4d893b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F214.jpg?alt=media\\u0026token=9df5e91b-7227-4286-8829-349125c4d5c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F215.jpg?alt=media\\u0026token=a8fcab98-514f-43d2-b773-d98fee53fcd3\"]", "Nhà sàn truyền thống", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000001"), "Thu hoạch mùa vụ", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2351), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa cùng với nông dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]", "Cánh đồng hợp tác xã biên giới", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000002"), "Sơ chế và bảo quản thực phẩm", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2356), "Học cách phân loại, sơ chế và bảo quản thực phẩm thu hoạch được bằng phương pháp thủ công và tự nhiên.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F231.jpg?alt=media\\u0026token=f97e225d-3650-420f-90a5-2de9e9e95cef\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F232.jpg?alt=media\\u0026token=ebbc29cf-f3db-4482-a703-40d22ef83721\"]", "Nhà sơ chế tại trang trại", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000003"), "Thưởng thức sản phẩm sạch tại chỗ", 5.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2364), "Dùng thử các món ăn chế biến từ chính nông sản vừa thu hoạch như ngô luộc, khoai nướng, rau luộc chấm muối vừng.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F241.jpg?alt=media\\u0026token=4463106d-794f-4fdf-a7d5-0d8480924e8c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F242.jpg?alt=media\\u0026token=0007ab7b-3e71-433b-b91e-2ebeba70c162\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F243.jpg?alt=media\\u0026token=b0b690e9-bdf5-439c-8ef4-28c268db4620\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F244.jpg?alt=media\\u0026token=3604d3cf-9fc5-473d-af7b-c5589c0a97ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F245.jpg?alt=media\\u0026token=9eaef8dc-1185-42d7-9cfd-2224b1ccec20\"]", "Khu vực ăn uống ngoài trời", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000004"), "Giao lưu văn nghệ và chia sẻ", 0.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2367), "Giao lưu với người dân bản địa, nghe chia sẻ về đời sống sản xuất nông nghiệp và văn hóa vùng cao.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F251.jpg?alt=media\\u0026token=81823c6d-9776-43f3-9ebf-de22ca576eaa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F252.jpg?alt=media\\u0026token=36bcc531-71a4-459d-965a-6622849ab584\"]", "Sân cộng đồng xã", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000001"), "Trồng rau trên ruộng bậc thang", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2420), "Trải nghiệm làm nông cùng người H'Mông: cuốc đất, gieo hạt và chăm sóc rau trên ruộng bậc thang.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]", "Ruộng bậc thang bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000002"), "Hái và phân loại thuốc nam", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2428), "Cùng người bản địa đi hái các loại cây thuốc nam đặc trưng vùng cao, học cách phân loại và sử dụng.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F351.jpg?alt=media\\u0026token=7f979d6c-7fd1-41fa-95dc-5b916eaaccb6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F352.jpg?alt=media\\u0026token=563f16cd-657a-47ae-bb8a-98a9e73c5e21\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F353.jpg?alt=media\\u0026token=f5b16d9a-5509-43cb-8390-a71fdb4ceded\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F354.jpg?alt=media\\u0026token=9b1add6f-51e5-4224-af5c-e50497f29c33\"]", "Khu rừng ven bản", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000003"), "Nấu ăn cùng người H'Mông", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2432), "Tham gia chuẩn bị bữa trưa với các món ăn truyền thống của người H'Mông, sử dụng nguyên liệu địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F361.jpg?alt=media\\u0026token=7bcb88d3-ed48-4d65-87ea-8e765f95eacd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F362.jpg?alt=media\\u0026token=3ddd92d0-24eb-4731-8916-fc6ce6cf3fd1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F363.jpg?alt=media\\u0026token=4fc8b20d-7bb7-4e4c-97f5-2f84c10bdeb9\"]", "Nhà truyền thống H'Mông, bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000004"), "Đi bộ khám phá bản Cát Cát", 20.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2440), "Hành trình đi bộ qua các con đường lát đá, tìm hiểu kiến trúc nhà truyền thống và đời sống người H'Mông.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]", "Bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000005"), "Tham quan mô hình nông nghiệp hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2444), "Tìm hiểu quy trình trồng rau sạch, dược liệu không hóa chất và chăm sóc vườn theo tiêu chuẩn hữu cơ.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F381.jpg?alt=media\\u0026token=424e6c80-6192-44f3-9493-4e9e11e83d94\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F382.jpg?alt=media\\u0026token=8f8c59b9-c916-4120-b569-5219537de2aa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F383.jpg?alt=media\\u0026token=d0758696-6d53-48de-b51d-51e2988571c8\"]", "Vườn hữu cơ bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000006"), "Trải nghiệm làm giấy thủ công", 20.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2449), "Tự tay chế tác giấy dó từ nguyên liệu tự nhiên, học cách in họa tiết dân tộc truyền thống.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F391.jpg?alt=media\\u0026token=3c9ee67a-b22c-4203-b072-5858308ebd84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F393.jpg?alt=media\\u0026token=a5be846e-f195-44fd-9d0e-02a5382cb5a9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F392.jpg?alt=media\\u0026token=27c17e64-db04-4907-bfd5-0d6e6b1c233e\"]", "Xưởng giấy thủ công trong bản", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000007"), "Nghỉ dưỡng tại homestay Mường Hoa", 30.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2456), "Thư giãn tại homestay trong thung lũng Mường Hoa với view ruộng bậc thang, tận hưởng không khí trong lành và yên tĩnh.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F401.jpg?alt=media\\u0026token=d9d59523-c02a-4195-8e28-56e0b2e4eee7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F402.jpg?alt=media\\u0026token=a48192a3-6c9e-4ecd-9eab-af6a15f5227b\"]", "Homestay Mường Hoa", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000008"), "Trải nghiệm thu hoạch và nấu ăn", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2461), "Tham gia thu hoạch rau củ tại vườn và cùng người bản địa nấu các món ăn truyền thống như thắng cố, lợn cắp nách, cá suối nướng.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F411.jpg?alt=media\\u0026token=1a9c47f9-1b2d-4b92-91f3-28b285573140\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F412.jpg?alt=media\\u0026token=f4987f55-a4f6-42e7-a1dc-7958db0b8559\"]", "Vườn rau & gian bếp homestay", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000009"), "Giao lưu văn nghệ bản địa", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2465), "Thưởng thức các tiết mục múa hát dân tộc, tham gia múa sạp, múa chuông và uống rượu ngô cùng người dân địa phương.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F421.jpg?alt=media\\u0026token=6d6aee32-1e25-4324-99ad-4f707c3d63d5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F422.jpg?alt=media\\u0026token=a81c9c91-10ec-4bf5-b6ad-d0f78222f6e6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F423.jpg?alt=media\\u0026token=cc1d5656-20e0-44c0-ad9f-c35602eceaf3\"]", "Sân sinh hoạt cộng đồng tại bản", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000010"), "Tham quan chợ phiên Sa Pa", 30.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2482), "Khám phá chợ phiên truyền thống với các gian hàng thổ cẩm, dược liệu, đặc sản vùng cao và giao lưu với người dân bản địa.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F431.jpg?alt=media\\u0026token=fedde1c2-82af-4101-96af-ac35b1247c05\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F432.jpg?alt=media\\u0026token=6b2b702f-d2f3-495e-bce4-b03768564e70\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F433.jpg?alt=media\\u0026token=76f636b3-f04a-4c67-a81c-e83203cf98b2\"]", "Chợ trung tâm Sa Pa", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000011"), "Trải nghiệm gieo trồng và thu hoạch", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2487), "Tham gia gieo hạt, chăm sóc rau theo phương pháp truyền thống của người dân tộc thiểu số và tự tay thu hoạch nông sản.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F441.jpg?alt=media\\u0026token=37827a0f-e7c0-4b0a-9c91-dcc11d611846\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F442.jpg?alt=media\\u0026token=0168cdd6-bbd6-4d1a-9b7a-11fa787bc27a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F443.jpg?alt=media\\u0026token=a7283cee-39ee-491b-810e-ee0683483411\"]", "Vườn rau bản Tả Phìn", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000012"), "Học nấu món ăn đặc sản vùng cao", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2491), "Hướng dẫn chế biến các món ăn đặc trưng của người H’Mông như thắng cố, cải mèo luộc chấm chẩm chéo và thịt trâu gác bếp.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F451.jpg?alt=media\\u0026token=2528b14d-5b04-46df-9276-1d8b759f8f00\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F452.jpg?alt=media\\u0026token=6461419d-900a-4753-aacf-ab7a487ce6a7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F453.jpg?alt=media\\u0026token=cc68f5d2-853d-4efe-a640-301d5f9ef61e\"]", "Bếp cộng đồng trong bản", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000001"), "Trải nghiệm trồng trọt địa phương", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2375), "Tham gia các công việc nông nghiệp truyền thống như trồng rau, làm đất, tưới tiêu cùng người dân.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]", "Cánh đồng bản Tày", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000002"), "Thưởng thức món ăn truyền thống", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2378), "Dùng bữa với các món ăn dân tộc như khẩu sli, thắng cố, lạp xưởng, và rượu ngô bản địa.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F271.jpg?alt=media\\u0026token=241821db-3226-4e34-a77e-e836f927b832\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F272.jpg?alt=media\\u0026token=3fd95b94-c080-48a1-a33c-26b124c01729\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F273.jpg?alt=media\\u0026token=9a6da2b9-6b90-4fb0-898e-d53d619661c4\"]", "Nhà sàn truyền thống", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000003"), "Giao lưu văn hóa dân gian", 5.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2382), "Tham gia đêm giao lưu văn nghệ với các tiết mục múa khèn, hát then, hát lượn đặc trưng dân tộc Tày - Nùng.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F281.jpg?alt=media\\u0026token=f04d5b05-7aaf-416d-97e6-2c822003f677\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F282.jpg?alt=media\\u0026token=305ac0e3-fd04-4970-a70d-47121c1bb920\"]", "Sân nhà văn hóa bản", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000004"), "Thăm quan làng nghề truyền thống", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2389), "Khám phá làng nghề làm hương, dệt thổ cẩm và thủ công mỹ nghệ bản địa.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F291.jpg?alt=media\\u0026token=359dcbca-21d9-4154-a7d0-5551d716bda1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F292.jpg?alt=media\\u0026token=8ed946de-f900-42a4-8680-1f3d874c5664\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F293.jpg?alt=media\\u0026token=cd51d4ba-d099-40ef-8f04-45c50b510f4d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F294.jpg?alt=media\\u0026token=57db7ac9-c488-4f98-afef-4cd8fa0099be\"]", "Làng nghề Tày - Nùng", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000001"), "Hướng dẫn canh tác hữu cơ", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2394), "Tham gia buổi giới thiệu quy trình trồng rau, hoa quả theo hướng hữu cơ không sử dụng thuốc trừ sâu hóa học.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]", "Trang trại sinh thái hữu cơ", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000002"), "Trải nghiệm làm vườn hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2399), "Tự tay gieo hạt, chăm sóc rau và thu hoạch sản phẩm sạch theo hướng dẫn của người dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F311.jpg?alt=media\\u0026token=c5d2e774-2892-4050-8e03-6da8b54ad1b5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F312.jpg?alt=media\\u0026token=2f38325a-17d8-463c-8cf7-6ac1a59d0df2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F314.jpg?alt=media\\u0026token=5b8079cb-fc25-46d1-90d8-919b1d17d017\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F315.jpg?alt=media\\u0026token=cad2491a-a26d-4c9d-a047-dec724e86aed\"]", "Vườn rau hữu cơ", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000003"), "Nghỉ dưỡng tại homestay sinh thái", 30.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2410), "Thư giãn tại homestay thân thiện với môi trường, sử dụng năng lượng tái tạo, có view rừng và núi.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F321.jpg?alt=media\\u0026token=cb1d9b94-1df8-43ff-9c40-2cb2db8e48c8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F322.jpg?alt=media\\u0026token=9ec5a1d9-fe89-43a2-98f4-adf67c778461\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F323.jpg?alt=media\\u0026token=189aea12-33a9-4033-92c9-3aea8de5c297\"]", "Homestay chân núi Pù Luông", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000004"), "Chế biến món ăn từ nông sản hữu cơ", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2415), "Học nấu các món ăn truyền thống từ nguyên liệu hữu cơ tự tay thu hoạch.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F331.jpg?alt=media\\u0026token=aeac9ff7-f16d-4843-9f8e-547cd5888511\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F332.jpg?alt=media\\u0026token=c6d546a9-22f0-47d0-b7f2-7b865d475026\"]", "Khu bếp homestay", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), "Tham quan và thu hoạch rau hữu cơ", 5.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2212), "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F31.jpg?alt=media\\u0026token=c76c7f97-077d-4e11-b851-4d14a5348e39\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F32.jpg?alt=media\\u0026token=1d3da6b4-2733-4281-bee0-e9a005d9e3bd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F33.jpg?alt=media\\u0026token=510e194a-cf09-476d-891e-d30976dbcf74\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F34.jpg?alt=media\\u0026token=cd2d6297-a97d-4119-b924-66f84e686091\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F35.jpg?alt=media\\u0026token=5dab756d-23a9-4df1-97a2-ff3b2afedad5\"]", "Trang trại rau hữu cơ Mộc Châu Xanh", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"), "Trải nghiệm hái chè", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2238), "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F61.jpg?alt=media\\u0026token=63b5b728-ea1f-4511-a780-d3c095a200bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F62.jpg?alt=media\\u0026token=c7184c0e-1262-4c7c-8124-d830c6077824\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F63.jpg?alt=media\\u0026token=70feba58-f759-40fa-a09a-afc6013a2a4c\"]", "Đồi chè Thanh Bình – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"), "Thưởng thức trà OCOP", 0.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2254), "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F81.jpg?alt=media\\u0026token=6afd1b86-7467-4378-872e-35653af5b8b1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F82.jpg?alt=media\\u0026token=70835076-bb28-4f0a-840d-8a417e6aed17\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F83.jpg?alt=media\\u0026token=68a06a61-f77e-44a6-80e7-5da69e44d21a\"]", "Không gian trà đạo Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"), "Tìm hiểu quy trình đóng gói sản phẩm OCOP", 5.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2283), "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F121.jpg?alt=media\\u0026token=9018f821-dd46-4bc6-aa56-0389aea2bf61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F122.jpg?alt=media\\u0026token=ad974591-aff7-48af-80e6-a6e7e975941c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F123.jpg?alt=media\\u0026token=7e9514a5-c205-468d-913e-49da8aa8b473\"]", "Xưởng sản xuất nông sản OCOP Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"), "Thu hoạch và chế biến nấm", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2276), "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F111.jpg?alt=media\\u0026token=720b5141-852a-42f7-9501-cd21845aea83\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F112.jpg?alt=media\\u0026token=071f3771-b293-4679-a2b8-9705b064e2ee\"]", "Trang trại nấm – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"), "Thu hoạch cà chua", 10.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2269), "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F102.jpg?alt=media\\u0026token=05c8e1fe-9719-4a40-ac8b-29240968deca\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F105.jpg?alt=media\\u0026token=6a6f785c-b2ff-4d18-a281-6b4fbdb24858\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F101.jpg?alt=media\\u0026token=543a6d27-d8c1-405e-8cc5-d514df96a517\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F103.jpg?alt=media\\u0026token=61052fcb-66f1-4b78-801c-7753c921eedd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F104.jpg?alt=media\\u0026token=d6fa2240-475b-4342-b38f-4ab3ff860c6c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F106.jpg?alt=media\\u0026token=04b992aa-add3-494d-afb6-163f295101dd\"]", "Vườn cà chua – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), "Dùng bữa trưa đặc sản Mộc Châu", 0.0, 1, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(2220), "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F41.jpg?alt=media\\u0026token=e217a4d7-e7f4-4b2a-98dd-0a7dd4dc2984\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F42.jpg?alt=media\\u0026token=149048cb-720f-478f-bcd1-422756adf1ac\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F43.jpg?alt=media\\u0026token=828ef767-521b-43a8-92c3-6611901f65e2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F44.jpg?alt=media\\u0026token=f69dd952-5c11-4080-ba90-2dbc7be04fe0\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F45.jpg?alt=media\\u0026token=815c61a0-c821-4208-ad95-0915e193fd9f\"]", "Nhà hàng Truyền thống Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("149c7f72-d29c-442c-9889-7175256dbc1d"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1807), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1805), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1803), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("16e9ebba-306c-49ea-b86b-81e7e416ecdb"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1841), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1840), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1840), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("2b8fcdf2-3cf1-40b9-b9b6-a9b9c18c4075"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1819), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1819), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1818), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("2dd46ff4-d6cb-4a47-9aa1-1d687e04ab27"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1831), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1830), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1830), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("56118732-e4b0-4d60-be90-85ff0beab35b"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1845), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1845), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1844), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8f032d07-4503-4e49-a8f4-730c0582e0f4"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1836), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1835), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1835), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a34c6001-a616-4849-a7fa-b9b6139dea75"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1814), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1813), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1813), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f62c16a5-9c3b-4c32-9d95-a72ac71533b8"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1826), new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1826), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 17, 54, 33, 910, DateTimeKind.Local).AddTicks(1825), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("039601de-3965-4e16-9251-60321fb88617"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1658), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("05f3a9f4-464b-472b-aa61-2e1c542010a0"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1624), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("0c80bf1a-236a-4cc7-b36d-4931f7dab20e"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1692), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("15833120-0114-4b36-a300-242f9f1f017c"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1059), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("1a389600-e95a-4b0c-a9c1-899f84c29916"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1414), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("1b63080f-bafb-4b76-ad68-1e37b8bb6bad"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1611), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("1e69962c-1e80-4c27-96c4-bd43dc99735c"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1376), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("2858d147-aae0-4f26-86ab-405bc87d2b2b"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1407), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("28f67d60-8301-4ffd-9459-60cd90c6540a"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1350), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("2ada330a-c652-4e64-85df-da1f9149a60e"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1444), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("32f216f8-01ed-4c08-a2be-194d311e7bc3"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1369), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("3750184b-0fc4-4947-94cd-2bcc3ec384e3"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1558), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("3b2115a4-c798-46d3-bace-03738ffc436e"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1583), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("3e6eff48-31ce-40a7-a0cc-c6dc735e9ce2"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1590), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("44867530-4697-4672-93b5-4ca8295b0180"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1686), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("46679281-5f6e-41be-aa4b-8adda9eeb098"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1457), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("4c7b949e-680d-4d64-b1fb-d607e1b514b0"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1437), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("669ca64b-5603-4c7b-8d10-1469d56a66de"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1604), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("66b9cf8a-9cd9-4ba3-b217-26924e6baf0e"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1652), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("7249f90b-b2cc-470c-b245-d90798ed0abb"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1667), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("80339546-0d47-4298-a509-9766796d43b4"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1046), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("817611f1-14d9-4e9c-a867-91bfc6e805b2"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1645), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("8c00a690-66ad-401a-8790-f8d5f7f33a69"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1570), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("a675eb74-9315-4864-bb86-498acf4dab64"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1551), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("a9ddf107-e88b-4aa3-a513-f6d094483052"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1450), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("b6c042e6-074e-426c-9212-ddd833edc890"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1617), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("ba9deb52-4d9c-4843-998d-2d8484a443fb"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1540), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("bc50d3f7-c770-4dfd-a63a-de3093a0abf3"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1420), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("bc9e5dd3-05c1-428f-8974-94dd5882134a"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1596), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("d88bd7d4-56d9-43e0-b1bb-b5f321977c17"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1052), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("dbc248dc-d61f-4a1a-adf5-2bba62b58e41"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1673), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("e3f35470-1ec3-4588-8b35-85898875f4fa"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1564), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("e849ce24-bf87-425a-a6a6-6ec0f204f77e"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1577), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f658267d-030f-48f4-ae78-6181f1320c25"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1639), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("fa9c64db-45c1-4a5a-a71d-3b804b9e0926"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1035), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("ffe6ee47-3840-4617-8f6c-79fb62c3ffd1"), null, new DateTime(2025, 4, 25, 10, 54, 33, 910, DateTimeKind.Utc).AddTicks(1679), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("64000000-0000-0000-0000-000000000002"), null, null, null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1079), "Tham quan và trải nghiệm tại trang trại bò sữa Dairy Farm", null, new DateTime(2025, 5, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, "Trải nghiệm tại trang trại bò sữa", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 3 },
                    { new Guid("64000000-0000-0000-0000-000000000003"), null, null, null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1083), "Tham quan và trải nghiệm tại trang trại rau hữu cơ Mộc Châu Xanh", null, new DateTime(2025, 5, 10, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khám phá vườn rau hữu cơ", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 4 },
                    { new Guid("64000000-0000-0000-0000-000000000004"), null, null, null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1059), "Xe 45 chỗ đón khách tại điểm hẹn và di chuyển đến Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 6, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển đến Mộc Châu", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 1 },
                    { new Guid("64000000-0000-0000-0000-000000000005"), null, null, null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1099), "Di chuyển giữa các điểm tham quan trong khu vực Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển giữa các điểm tham quan", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 6 },
                    { new Guid("64000000-0000-0000-0000-000000000006"), new Guid("10000000-0000-0000-0000-000000000011"), null, null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1086), "Nghỉ ngơi và dùng bữa trưa tại khách sạn 5 sao TherHouse, trung tâm Mộc Châu", null, new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nghỉ trưa tại khách sạn TherHouse", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[] { new Guid("64000000-0000-0000-0000-000000000001"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 25, 10, 54, 33, 914, DateTimeKind.Utc).AddTicks(1071), "Tham quan và trải nghiệm tại nông trại dâu tây Bản Áng", null, new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 15, 0, 0, DateTimeKind.Unspecified), 0, "Tham quan nông trại dâu tây", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), 2, null, 2 });

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
                name: "IX_AdminBalance_BookingId",
                table: "AdminBalance",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminBalance_OrderId",
                table: "AdminBalance",
                column: "OrderId");

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
                name: "IX_BookingTourDestination_BookingAgriculturalTourBookingId",
                table: "BookingTourDestination",
                column: "BookingAgriculturalTourBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourDestination_BookingId",
                table: "BookingTourDestination",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourDestination_TourDestinationId",
                table: "BookingTourDestination",
                column: "TourDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_ProductId",
                table: "Certification",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_TouristFacilityId",
                table: "Certification",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TourCompanyId",
                table: "Contract",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TouristFacilityId",
                table: "Contract",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_TourCompanyId",
                table: "Driver",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ProductId",
                table: "Feedback",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_TourId",
                table: "Feedback",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");

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
                name: "IX_ShipAddress_AccountId",
                table: "ShipAddress",
                column: "AccountId");

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

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalHistory_TourCompanyId",
                table: "WithdrawalHistory",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalHistory_TouristFacilityId",
                table: "WithdrawalHistory",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalRequest_UserId",
                table: "WithdrawalRequest",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "ActivityProduct");

            migrationBuilder.DropTable(
                name: "AdminBalance");

            migrationBuilder.DropTable(
                name: "AgriculturalTourPackageTourGuide");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "BookingTourDestination");

            migrationBuilder.DropTable(
                name: "Certification");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "OCOPSell");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "ShipAddress");

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
                name: "WithdrawalHistory");

            migrationBuilder.DropTable(
                name: "WithdrawalRequest");

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
