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
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "f825d818-1f27-43e2-abde-692c2b4ba4fb", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAEOkNDV7EaIP3597/v6ldG8c21t2mAG3DBmEwWJcRKi9UrU7y6ixvF4a2kDLZ2+5B/g==", null, false, "73224761-b5a3-4e97-be58-0df5a4c6b76e", false, "TourismCompanies", true },
                    { new Guid("10000000-0000-0000-0000-000000000001"), 0, null, "2b984ee8-74cc-42bd-b621-0f7a5da1205a", null, "bangiocfarmtour@gmail.com", true, "Du Lịch Sinh Thái Thác Bản Giốc", null, false, null, "bangiocfarmtour@GMAIL.COM", "bangiocfarmtour", "AQAAAAIAAYagAAAAEOueUKPQZJC1ex5lFj329vV7jxPEsqKR2KesTMi48cuwFJkiZ+mhpX4fDiQHDRmqhA==", null, false, "ae69ec35-9222-40c4-a655-1ec1b11f04b4", false, "bangiocfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 0, null, "1cecf9de-70e9-4d04-9f7a-000f426c6099", null, "sapa@gmail.com", true, "Sa Pa Eco Farm Tour", null, false, null, "sapa@GMAIL.COM", "sapa", "AQAAAAIAAYagAAAAEB0591L2Cs3ruxwzQn8sg83JbxjNmBdDVRtJFWY9k1mKbfC4kKZ4vz6rT/4e1HZlHg==", null, false, "bddc1363-112e-4ca1-9f04-1d54d426572d", false, "sapa", true },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 0, null, "a8fb09a7-82b3-4c5a-a6d5-b0b9ac90e373", null, "grapevalley@gmail.com", true, "Farm Du Lịch Grape Valley", null, false, null, "grapevalley@GMAIL.COM", "grapevalley", "AQAAAAIAAYagAAAAEI7KTbHXSU3x8u/6ZbYRhj+afZrXDmwCrePJrUozdOnsVFzd56fsX2nOHA28ayBCHQ==", null, false, "7451c552-db07-4e72-ba81-ca91dbf2e0c5", false, "grapevalley", true },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 0, null, "a265951f-2129-4b01-95b0-e20c286dd5ae", null, "daitu@gmail.com", true, "Nông Trại Chè Trải Nghiệm Đại Từ", null, false, null, "daitu@GMAIL.COM", "daitu", "AQAAAAIAAYagAAAAECDfjq/NT+PyPbQwSmuzGE8jdMSSCIU5Z6tzN7yqVOYWfZVeKbBgj/20HAIQOQUgwA==", null, false, "c9a0834a-d711-4bd8-ac74-4edbc3d8f749", false, "daitu", true },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 0, null, "cb99b9f8-177e-4f6d-a115-b6e68189b61b", null, "buondoncoffee@gmail.com", true, "Buôn Đôn Coffee Farm Tour", null, false, null, "buondoncoffee@GMAIL.COM", "buondoncoffee", "AQAAAAIAAYagAAAAEKVG7r1IDWIK24EHrGfyUTMbQYT7gQWrANr+o7WgUm1FwlCcvNVgnJuDk1Nm6q/taw==", null, false, "07abffc7-17bb-4bb6-b35a-90fc72cf6094", false, "buondoncoffee", true },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 0, null, "eb8c4439-17f3-4fec-a4d8-d0c3d7e72d16", null, "hagiang@gmail.com", true, "Hà Giang Farmstay & Trek", null, false, null, "hagiang@GMAIL.COM", "hagiang", "AQAAAAIAAYagAAAAEGBsUJRJwyX3mtLULLXaAikQCPSC34XS8WfNtr3jXuGQ+6aIbgeel2l3EAwLHkfugw==", null, false, "810a9767-a4bd-4a3c-a0cb-d10daae362cf", false, "hagiang", true },
                    { new Guid("10000000-0000-0000-0000-000000000007"), 0, null, "f3bc26ad-8f3e-4102-92f3-745cbc0c14c1", null, "tramyfarmtour@gmail.com", true, "Trà My Sâm Ngọc Linh Tour", null, false, null, "tramyfarmtour@GMAIL.COM", "tramyfarmtour", "AQAAAAIAAYagAAAAEC4g3fkyrRQjBu7UX8vGTKerWY3sAGVn07kDOzjGlVspRNnT1o8kz2T32Ebp35Kh6g==", null, false, "73ff2f15-2b83-4934-bed7-06714323ff77", false, "tramyfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000008"), 0, null, "14485c5d-6951-48d8-859d-231964ba37c7", null, "dalatorganic@gmail.com", true, "Đà Lạt Organic Farm Tour", null, false, null, "dalatorganic@GMAIL.COM", "dalatorganic", "AQAAAAIAAYagAAAAEK4x6vGfkMudEIPM19eLpgYuvEeb8iQm83a7qFxLiQ9AUqomIXMhUKdEjkCVd9W/QQ==", null, false, "37b0fac9-dc85-47af-a414-4ee0ff8a3191", false, "dalatorganic", true },
                    { new Guid("10000000-0000-0000-0000-000000000009"), 0, null, "79ecb76a-3c46-453c-ad7f-6c7c01a49813", null, "binhthuanfarm@gmail.com", true, "Farmstay Nho & Thanh Long Bắc Bình", null, false, null, "binhthuanfarm@GMAIL.COM", "binhthuanfarm", "AQAAAAIAAYagAAAAEI/dS2/v/Zhodw08qDCg5memaNeH1E91vMIphFlf2gzcpTmi0lMmXN8m0VvL57WA7A==", null, false, "4debd69d-b67b-4af2-b956-2583678e1f58", false, "binhthuanfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000010"), 0, null, "86476a91-812a-4efe-80e8-4de6280e2404", null, "babeecotour@gmail.com", true, "Ba Bể Lake Ecofarm Tour", null, false, null, "babeecotour@GMAIL.COM", "babeecotour", "AQAAAAIAAYagAAAAEDuMb05s0R37PqsXWL8Qxyb/qKqQzQQ6fjcS+PG9//7bBuIr09NKaACgat1Vf1rapg==", null, false, "7ab05e6d-f6c5-4fcf-9cc0-b1ccf777bf61", false, "babeecotour", true },
                    { new Guid("10000000-0000-0000-0000-000000000011"), 0, null, "f73e5122-cd17-495b-b9d4-cfbc56093c8d", null, "tayninhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Tân Châu", null, false, null, "tayninhfarm@GMAIL.COM", "tayninhfarm", "AQAAAAIAAYagAAAAELLdawDmDcsBx5lkkiqlteoE7GmhnF1JM5PVBmShV+DbtDX/rRN+6uRpH/SXn/sc2A==", null, false, "09bb20a3-99f2-49b2-973d-e49a17e2e134", false, "tayninhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000012"), 0, null, "f3462eb1-74e9-4c24-8754-f64a4f80a6e5", null, "phuyentour@gmail.com", true, "Trải nghiệm Nông trại Biển & Rau Tuy An", null, false, null, "phuyentour@GMAIL.COM", "phuyentour", "AQAAAAIAAYagAAAAEI54uHqBRPxkmixQkcYKPzWRRf5YOJYU9uCDqiJdBD0y++nVLNrhmJyXxPYkU6Hx4A==", null, false, "948929b8-f745-4b32-92af-945c05828f5b", false, "phuyentour", true },
                    { new Guid("10000000-0000-0000-0000-000000000013"), 0, null, "83905a41-37f3-4021-ac7a-d65d9363414f", null, "travinhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Càng Long", null, false, null, "travinhfarm@GMAIL.COM", "travinhfarm", "AQAAAAIAAYagAAAAED0ol5+xm9enL9MdCRgC7zgLgZFadkZlwYym1IvDGv5YTLkico8y/AltgV33yfoLog==", null, false, "130eb2f5-db16-44ac-a84a-0ea12cd642db", false, "travinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000014"), 0, null, "b95ae0c2-fc4b-4564-b319-80d190c20859", null, "soctrangfarm@gmail.com", true, "Mỹ Xuyên Farmstay", null, false, null, "soctrangfarm@GMAIL.COM", "soctrangfarm", "AQAAAAIAAYagAAAAEKVKcwaQXRJvG1yvh5/Nwq7iIqYbNnE1JORrGBig3Xpsaj/PhwzMaeP8yf+YNms4ng==", null, false, "3f2ddfbc-b0a3-4607-bb65-98dffa11f4f7", false, "soctrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000015"), 0, null, "4af55c6c-abe1-44b3-b166-f3420b7d7bdd", null, "angiangfarm@gmail.com", true, "Trang Trại Châu Đốc", null, false, null, "angiangfarm@GMAIL.COM", "angiangfarm", "AQAAAAIAAYagAAAAEAtRQ6mkE+hQ1xl4Xye9heYw8pNDcU3vrwhE4Pe3nhjUoN1V+o/h6HJ6RcXrEitmww==", null, false, "be6c78e1-004d-47ae-b8be-148dd28d8f29", false, "angiangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000016"), 0, null, "56fc1680-62ea-430c-bc40-27b00e7d84c5", null, "canthoexplore@gmail.com", true, "Cần Thơ Farmstay", null, false, null, "canthoexplore@GMAIL.COM", "canthoexplore", "AQAAAAIAAYagAAAAEIx3m0PGczk1ybkfer4ZqmUrc+RKgin7RkPB/y5at9ZIBRTeCHUAGiDVqsVhPiLTuw==", null, false, "3b064882-4dce-4e1f-b27f-5443f213677c", false, "canthoexplore", true },
                    { new Guid("10000000-0000-0000-0000-000000000017"), 0, null, "a317c745-480e-4436-96db-65862d4f24dd", null, "phuquocfarm@gmail.com", true, "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, false, null, "phuquocfarm@GMAIL.COM", "phuquocfarm", "AQAAAAIAAYagAAAAEJGSY97k6EfCX9pXIIRIuxW53ca60SxVYfXzHFGgKW8jjh9n9JgijaqA6CVqBep6vA==", null, false, "f3b459cb-1dea-41ed-8f92-67e482d1e602", false, "phuquocfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000018"), 0, null, "4ed647df-0cca-408f-83e3-e3d6038df55e", null, "halongfarm@gmail.com", true, "Trại Nông Sản Hạ Long", null, false, null, "halongfarm@GMAIL.COM", "halongfarm", "AQAAAAIAAYagAAAAEMjSk3TbwZPIprmadAxjHHvwFTtJMuW4vKrAFCNZy2xj6TBePQ9Ej3x9S59g3J8K6g==", null, false, "7e533653-ff33-4fee-b618-d2d0a5b47812", false, "halongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000019"), 0, null, "d4b5cfe6-7994-4f73-a1c8-36aaf4b584df", null, "anlaofarm@gmail.com", true, "Trang Trại Nông Sản An Lão", null, false, null, "anlaofarm@GMAIL.COM", "anlaofarm", "AQAAAAIAAYagAAAAEFrDTxyU11soUWGCN92RV8WJR9MDTT8AQ3t/NL3OuysjD6GBpA/yV7uUlSYWYOnxmw==", null, false, "2a6dfb3f-66d2-40f1-bbee-26cc4e0e8e46", false, "anlaofarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000020"), 0, null, "79dacb68-6be4-4b8b-b518-fd24a58e085f", null, "daitufarm@gmail.com", true, "Nông Trại Đại Từ", null, false, null, "daitufarm@GMAIL.COM", "daitufarm", "AQAAAAIAAYagAAAAEHslSGvg9ssgdjW9/6ArrRhxbEWcL5LNDTuTCawhGSYmORowthO7ipK+H30FH3T4Kg==", null, false, "204c0f0b-46df-4771-8de0-23da351b0197", false, "daitufarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000021"), 0, null, "02c9de36-b475-4aa4-bb53-4bd92816a8e9", null, "vinhfarm@gmail.com", true, "Trại Nông Sản Vinh", null, false, null, "vinhfarm@GMAIL.COM", "vinhfarm", "AQAAAAIAAYagAAAAEK/Y+C0uMw7kmka7kKgXA3Y7XN7HuaeC+HUWGinoQlMqFK+VSUH5d09wQPF5M19ANg==", null, false, "7007311e-480d-45fa-8247-a71e803d30ed", false, "vinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000022"), 0, null, "17c3ef12-8287-403b-b57f-9c4831f26a9f", null, "trieusonfarm@gmail.com", true, "Trang Trại Nông Sản Triệu Sơn", null, false, null, "trieusonfarm@GMAIL.COM", "trieusonfarm", "AQAAAAIAAYagAAAAEKjJP/FKd79RW2Mvx1NihCUOqDE+Wa5kcr/M+Sy2QnTEoBnutcp4hlPMAbDO1C38Iw==", null, false, "6af04dc1-edd5-419a-ae79-864506192f81", false, "trieusonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000023"), 0, null, "8d098faf-fb74-4b1f-b2c6-7052df480e31", null, "hatinhfarm@gmail.com", true, "Trại Nông Sản Hà Tĩnh", null, false, null, "hatinhfarm@GMAIL.COM", "hatinhfarm", "AQAAAAIAAYagAAAAEJM/9M3L6voi3h+ViTEG9qkfd5DDSwvQNzc+qgmeztkMq0IzwMoAdDxcacsx4r44XA==", null, false, "4a145467-d6de-4d9f-ba90-a231d9399276", false, "hatinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000024"), 0, null, "7b5e3c56-6840-4c0e-8d91-8b10b409c759", null, "donghoifarm@gmail.com", true, "Trang Trại Đồng Hới", null, false, null, "donghoifarm@GMAIL.COM", "donghoifarm", "AQAAAAIAAYagAAAAEI6FYERp+lqatVhcQcbSpQW1UgQnuYmOQdEwbj4Sz1q3YnRoo9zgc0TsYFjPAUMbpQ==", null, false, "02d4f24c-ed97-4228-9e40-fc10e8cf3996", false, "donghoifarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000025"), 0, null, "15512e8b-da5b-4bbe-80df-3b3b98de1a44", null, "donghafarm@gmail.com", true, "Trang Trại Nông Sản Đông Hà", null, false, null, "donghafarm@GMAIL.COM", "donghafarm", "AQAAAAIAAYagAAAAECdvPKqbsJKCIyr4YkJuL3xT7K39kf5EjKqlP6LoOmhbN2w3iFcbo6Wqjadh2Jl0jQ==", null, false, "98fae3df-5639-41ff-9019-f684bc540cc1", false, "donghafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000026"), 0, null, "f8f37d80-9399-424f-8b26-b1c34b19b8af", null, "quynhonfarm@gmail.com", true, "Trại Nông Sản Quy Nhơn", null, false, null, "quynhonfarm@GMAIL.COM", "quynhonfarm", "AQAAAAIAAYagAAAAEBlUzL/o1o7sSv814SfbOeyRIQSRQDWRnfRRAOoy0LOtusiJoclexA3wdlDd8C3Bfg==", null, false, "7a859a49-4ca3-4089-82ff-2bd640d8c55c", false, "quynhonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000027"), 0, null, "94e19009-d422-4e24-aafe-b5eb8561afc7", null, "tuyhoafarm@gmail.com", true, "Trang Trại Nông Sản Tuy Hòa", null, false, null, "tuyhoafarm@GMAIL.COM", "tuyhoafarm", "AQAAAAIAAYagAAAAEEShOCRFkrzkdqDCHscaUadlLsavCka8C3nAZ53oKcRTOwxpBwfPaTeFa+oLPiW7lQ==", null, false, "efe09c6a-5ea2-4d43-9f12-387cbb9bd1f6", false, "tuyhoafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000028"), 0, null, "52c2334e-7086-4a4e-bd7b-922b484ed179", null, "nhatrangfarm@gmail.com", true, "Trại Nông Sản Nha Trang", null, false, null, "nhatrangfarm@GMAIL.COM", "nhatrangfarm", "AQAAAAIAAYagAAAAEBLfMB7yEWet3jFwl81D80l2tQVbncjIj8pBL5f3C++e18GKuJ8ItesfLYT7YEfVzQ==", null, false, "46a27004-a63a-4eac-a724-e239a41fcee2", false, "nhatrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000029"), 0, null, "502d78ab-54bb-4231-b074-daa2ed4257b2", null, "phanrangfarm@gmail.com", true, "Trại Nông Sản Phan Rang", null, false, null, "phanrangfarm@GMAIL.COM", "phanrangfarm", "AQAAAAIAAYagAAAAEHMaAMqj+ZjERL0MmqV0BUh4vzFUXW+Rg3sUhVP08WQibdw3NSXj2pKZmTgcRdhX/Q==", null, false, "89a8c241-3fa4-4bfe-a8cb-5a2c078cb1c7", false, "phanrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000030"), 0, null, "0f14f9eb-24fc-4c6f-a7cb-ecf558f3b376", null, "phanthietfarm@gmail.com", true, "Trang Trại Nông Sản Phan Thiết", null, false, null, "phanthietfarm@GMAIL.COM", "phanthietfarm", "AQAAAAIAAYagAAAAEJIh07FSr3jz4Khf9EWqnAUs7gfWJ++iJCff7mk+sLwUyUg+UHepieqB7EH6ZXqQ0g==", null, false, "6fa02cbd-824b-4ab1-9ac8-547179ed4e58", false, "phanthietfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000031"), 0, null, "8a534658-137f-4270-914a-f88f3f7a7adc", null, "tananfarm@gmail.com", true, "Trại Nông Sản Tân An", null, false, null, "tananfarm@GMAIL.COM", "tananfarm", "AQAAAAIAAYagAAAAEPQpiSxfdejk4FPMapw9HOw3FsuRycyJkNIubkTaWtypjo8Ql/Awj529cGyjOgvQPg==", null, false, "17996396-8fb0-4e2f-9451-a51ce89cce92", false, "tananfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000032"), 0, null, "2d6019bd-0940-445d-ad3b-e506aa9602dd", null, "vinhlongfarm@gmail.com", true, "Trại Nông Sản Vĩnh Long", null, false, null, "vinhlongfarm@GMAIL.COM", "nhavinhlongfarmtrangfarm", "AQAAAAIAAYagAAAAEJAYiHtrUGr1WxCvuLzsE4xlwJsWlQ9dcWdJt/KkL4rx6Qg+IsGNmOh81FWppdVInQ==", null, false, "b59c9e1f-b665-41c4-91c4-6c32078d67d3", false, "vinhlongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000033"), 0, null, "f3c09a7c-8414-4622-9ac6-37fa50255002", null, "contact@vinpearlresort.com", true, "CÔNG TY TNHH VINPEARL RESORT & SPA", null, false, null, "CONTACT@VINPEARLRESORT.COM", "VINPEARLRESORT", "AQAAAAIAAYagAAAAEB6DTdqtKUtCHKmP9rrWneWmsOiHCTRwm4al+u6HtggnA7PDjqeT6K/MtPklu5aEvQ==", null, false, "d5c59c1b-4596-4a66-8648-43c5aaefc81a", false, "VinpearlResort", true },
                    { new Guid("10000000-0000-0000-0000-000000000034"), 0, null, "1658b7cf-2f18-497b-94a4-2535eac2e666", null, "info@muongthanhhotel.com", true, "TẬP ĐOÀN KHÁCH SẠN MƯỜNG THANH", null, false, null, "INFO@MUONGTHANHHOTEL.COM", "MUONGTHANHHOTEL", "AQAAAAIAAYagAAAAEKaegk5NP2a5r2v9aGrNN/Ru8qnLEN3WF6i0aXekHftDrO9yZnAd88VxbiwiTPbA8Q==", null, false, "ec7c85af-f40f-45a8-a44e-ac784132d8cc", false, "MuongThanhHotel", true },
                    { new Guid("10000000-0000-0000-0000-000000000035"), 0, null, "0b2f0660-350a-411b-8850-cd48205b5eac", null, "reservation@intercontinental.com", true, "KHÁCH SẠN INTERCONTINENTAL HANOI WESTLAKE", null, false, null, "RESERVATION@INTERCONTINENTAL.COM", "INTERCONHANOI", "AQAAAAIAAYagAAAAEBmBS5+J4XsPdpp5YiQ4TxvBCXRXkVx01FgZReK8k9esWcmdH9huW28jpSRwVORKAQ==", null, false, "39411878-a042-431e-8315-ef896e0efd65", false, "InterConHanoi", true },
                    { new Guid("10000000-0000-0000-0000-000000000036"), 0, null, "aafa2215-d73a-4c28-a79d-70f630fef902", null, "info@sofitellegend.com", true, "KHÁCH SẠN SOFITEL LEGEND METROPOLE HÀ NỘI", null, false, null, "INFO@SOFITELLEGEND.COM", "SOFITELLEGEND", "AQAAAAIAAYagAAAAEGVMdwhmJE4FP323ZkbqMNo7ggqvo2a9lejX7iv8oizYGqQC/p7DPIW2YD1lmfrjWw==", null, false, "d5d80662-19b7-4064-8502-e33cbab9c623", false, "SofitelLegend", true },
                    { new Guid("10000000-0000-0000-0000-000000000037"), 0, null, "a8c982f8-d431-4efd-a0cf-aa9eee28c441", null, "reservation@furamadanang.com", true, "CÔNG TY TNHH FURAMA RESORT ĐÀ NẴNG", null, false, null, "RESERVATION@FURAMADANANG.COM", "FURAMADANANG", "AQAAAAIAAYagAAAAEGHyv/5URHgZSy86uPzprG3PsjryxXU+IDvHIWKGXDi39ilpiAaKfYM3+1tKG1O1Lg==", null, false, "56c15a58-8fb7-4d11-9ec2-35be59fd57ac", false, "FuramaDanang", true },
                    { new Guid("10000000-0000-0000-0000-000000000038"), 0, null, "9a2786ae-a80c-4b45-9181-eba7390a7b0a", null, "spa@anantara.com", true, "CÔNG TY TNHH ANANTARA QUY NHƠN VILLAS", null, false, null, "SPA@ANANTARA.COM", "ANANTARASPA", "AQAAAAIAAYagAAAAEKppd1X3/yTvR/DYMw65VzhJi+bvSDLtVDl980tdr9XAgv8yjkNHbmmF63ZmuZH0jw==", null, false, "27cae92a-257c-47c9-a47a-e1b16b6758dc", false, "AnantaraSpa", true },
                    { new Guid("10000000-0000-0000-0000-000000000039"), 0, null, "a6b9413b-ec0b-41f2-9ffb-9fcaeda0f13b", null, "resort@amanoi.com", true, "CÔNG TY TNHH AMANOI RESORT NINH THUẬN", null, false, null, "RESORT@AMANOI.COM", "AMANOISPA", "AQAAAAIAAYagAAAAECKHhERI2amfHEWg9aE3DRZGUOKFL58xioaCUUvR8vgwOiWSaGiKnIZGOJrXtnA4lw==", null, false, "b7ed3d25-f96e-48d2-acfd-36b019b0f8b3", false, "Amanoispa", true },
                    { new Guid("10000000-0000-0000-0000-000000000040"), 0, null, "6585eb1a-d439-4fa0-8a11-0dd6a9105d70", null, "contact@sixsenses.com", true, "CÔNG TY TNHH SIX SENSES CÔN ĐẢO", null, false, null, "CONTACT@SIXSENSES.COM", "SIXSENSESCON", "AQAAAAIAAYagAAAAEFXWyKWOPTWdPlLjnP8+9GSejBmSisQt0gyM8wxlOOrOYUB4QaTqJLOscYjZ9D9upw==", null, false, "f96e14f8-f229-4110-832b-a80d32de7b05", false, "SixSensesCon", true },
                    { new Guid("10000000-0000-0000-0000-000000000041"), 0, null, "1f3161ca-f692-4787-9543-8d5687a6e178", null, "langco@banyantree.com", true, "CÔNG TY TNHH BANYAN TREE LĂNG CÔ", null, false, null, "LANGCO@BANYANTREE.COM", "BANYANTREE", "AQAAAAIAAYagAAAAEGTfR+d/ZWvANk6b2IJpDCskrMaKalEYlrCJs0WdK6p4ZmMXDiKf/kSBBSS2Q592aA==", null, false, "6c4ff3b0-bad8-4281-9dc8-6783aba5561f", false, "BanyanTree", true },
                    { new Guid("10000000-0000-0000-0000-000000000042"), 0, null, "6cb4e1eb-60c6-4b60-af8a-a82d3532837b", null, "saigon@hyatt.com", true, "CÔNG TY TNHH PARK HYATT SÀI GÒN", null, false, null, "SAIGON@HYATT.COM", "PARKHYATT", "AQAAAAIAAYagAAAAEIBNFBN+BG1JBYkM5u/URfKYV61InPadTjwKeG/EBOwvRFYZLDY3PhiRz8WrKTbr8A==", null, false, "79ab4f23-234b-4859-bc31-47b996837347", false, "ParkHyatt", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "948b8fac-6183-4c01-8ace-dc971d4a8860", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEMZQ5mwaDmXxxgFo2a12HI0J/xURjl09y2ifEyaBSk0iIZCHZN+1Sxxb5yXODzJyvQ==", null, false, "355d2238-aac2-48ed-afce-f23dd6d92d17", false, "ContentModerators", true },
                    { new Guid("20000000-0000-0000-0000-000000000018"), 0, null, "085b3e46-5bfd-4c40-9d68-d4665662cc59", null, "contact@gmail.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@GMAIL.COM", "QUYNHONEXPLORER", "AQAAAAIAAYagAAAAEA4vbyLed7u49yuKoX8gZdQKSdLKYbkREEtNK1VDwRs1eJrzvcyX1t+5jQVjJ3ADbA==", null, false, "b0a83479-eecf-46c3-b8f0-83129e89eac3", false, "quynhonexplorer", true },
                    { new Guid("20000000-0000-0000-0000-000000000019"), 0, null, "0064cf97-d0ca-49e0-87af-d5eb8895b7c1", null, "contact@hoianheritage.com", true, "Hoi An Heritage Tours", null, false, null, "CONTACT@HOIANHERITAGE.COM", "HOIANHERITAGEACCOUNT", "AQAAAAIAAYagAAAAEK4ybpPLN7kmmVBaxzWauD1H913uaYHJuX757M+v4VhjFOf4PPQusnRxh/xawcsCLw==", null, false, "903e610b-d15f-4a1a-82a4-cf999ff6d2ff", false, "hoianheritage", true },
                    { new Guid("20000000-0000-0000-0000-000000000020"), 0, null, "57e52080-598b-47a2-b373-31ca4d8046e9", null, "info@danangdiscovery.com", true, "Da Nang Discovery Travel", null, false, null, "INFO@DANANGDISCOVERY.COM", "DANANGDISCOVERYACCOUNT", "AQAAAAIAAYagAAAAEMupH8LyYoAZVfiaNT2rbwvJWe785WnP1nRcQes+9ErTltWzCtACpItom5wVWfbzVA==", null, false, "20721bfc-9472-4e7d-bd01-50747b0387ed", false, "DaNangDiscoveryAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000021"), 0, null, "bd61752f-1794-439a-9308-39f13654055f", null, "contact@hueimperial.com", true, "Hue Imperial Adventures", null, false, null, "CONTACT@HUEIMPERIAL.COM", "HUEIMPERIALACCOUNT", "AQAAAAIAAYagAAAAEMCuDrbhcygn+g0DgoO1saCjfckPgR2qJpsYBMsxyd6qbRE3Q0J1veo7vazKkjqBow==", null, false, "73734590-7cb0-4567-beab-ee5cd3adaf06", false, "HueImperialAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000022"), 0, null, "1da4799f-3429-482c-bba5-1153657663fc", null, "info@nhatrangbay.com", true, "Nha Trang Bay Tours", null, false, null, "INFO@NHATRANGBAY.COM", "NHATRANGBAYACCOUNT", "AQAAAAIAAYagAAAAEGs2rpqjTzuQqlXGtbIu/yNmUIAVOrhMvdG/YHaWQ78NjMOiKpI8C1Z4p8cFSFabjg==", null, false, "6a127336-058b-421e-b22c-86c0ad5e9377", false, "NhaTrangBayAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000023"), 0, null, "645db775-f3aa-4b08-8cb2-795acc9c944f", null, "booking@halongcruise.com", true, "Ha Long Cruise Experience", null, false, null, "BOOKING@HALONGCRUISE.COM", "HALONGCRUISEACCOUNT", "AQAAAAIAAYagAAAAEGEX38IpqCCPDkmiWoax6Quc0IEwei+NUKXASCQEtizHdRQkG/6f3xYiBogNnx0jKw==", null, false, "47937f47-eb10-4a04-ac56-dde4382693dc", false, "HaLongCruiseAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000024"), 0, null, "40f20af2-b255-4699-9c55-d76d88f2fe20", null, "contact@sapahighland.com", true, "Sapa Highland Adventures", null, false, null, "CONTACT@SAPAHIGHLAND.COM", "SAPAHIGHLANDACCOUNT", "AQAAAAIAAYagAAAAEGw6GKR4Gcj1xMMYLOILoceEOZTXMtALGWVFvZYWg69b+HQiIntQTLbb8V57buNDHQ==", null, false, "f060341d-34ad-48b6-9adc-22c57cc9783e", false, "SapaHighlandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000025"), 0, null, "c105156d-ba24-49b0-9f53-e8b0630f5bae", null, "info@mekongdelta.com", true, "Mekong Delta Explorers", null, false, null, "INFO@MEKONGDELTA.COM", "MEKONGDELTAACCOUNT", "AQAAAAIAAYagAAAAEO/xT0e7zi9/yrdxmGbFbCNi4Wqm3j1iBRjUEbv5ht0nFTNjE82EaSUjEJ6ZFGhfuw==", null, false, "a5e40d01-6a65-48f6-9e7d-8d9cc26940bd", false, "MekongDeltaAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000026"), 0, null, "7f36d9e4-5f26-4636-9085-b4d99ee5bb09", null, "contact@phuquocisland.com", true, "Phu Quoc Island Tours", null, false, null, "CONTACT@PHUQUOCISLAND.COM", "PHUQUOCISLANDACCOUNT", "AQAAAAIAAYagAAAAEMBDiZS82LBQ76T7+eeIsxLvahCA565MCwcONy0xLyPjOnUwR+GaPTQ6oriiUSdP+A==", null, false, "d00cb836-af9e-4fea-934d-51f2e235db74", false, "PhuQuocIslandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000027"), 0, null, "966d6a91-690f-4fc8-868c-b20d28654955", null, "info@dalateco.com", true, "Da Lat Eco Tourism", null, false, null, "INFO@DALATECO.COM", "DALATECOACCOUNT", "AQAAAAIAAYagAAAAEMKJDa09PhI2edWhdxr/88aGtvZAvY5AAO5oWCyOadmZBwIaGHiCJpPT7htaN8Ed2A==", null, false, "dad9cd65-24e6-4753-a6d2-2aacb30e0162", false, "DaLatEcoAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000028"), 0, null, "0191a366-884d-4d87-b349-980c60c64f43", null, "booking@condaotours.com", true, "Con Dao Heritage Tours", null, false, null, "BOOKING@CONDAOTOURS.COM", "CONDAOACCOUNT", "AQAAAAIAAYagAAAAEG6Ksj7lVFabnaNPA0V5d1TyE51N69ymiMPMPB7jNe3njPs1kv8nhV50e3oFhJZXaw==", null, false, "f284df4b-79df-44bd-8919-774478e4ca05", false, "ConDaoAccount", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0, "https://example.com/avatar1.jpg", "6076c8b7-8944-4d5d-9cd5-bf93030b7af0", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", true, "John Doe", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEPHct7P91ufpvMkxZenOF+cRRgxtT4RiAtagl+yP8Q1wGqunz9InhXeabnX6U2M8uw==", null, false, "7393d7e7-b26d-4e0f-8837-7119f0ab9a01", false, "JohnDoe", true },
                    { new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), 0, null, "e765af9b-87f9-4eef-81b0-9a0a9b293c0d", null, "contact@bambotravel.com", true, "Bamboo Travel", null, false, null, "CONTACT@BAMBOOTRAVEL.COM", "BAMBOOTRAVELACCOUNT", "AQAAAAIAAYagAAAAEGW2VfSh4+B3KM3Yffn2tl2aZMzD75LDS9CCvMbjQwZcLRXlMhViDkGAn+dHH9paRA==", null, false, "8bfba5c5-5cba-4def-92b5-ccbffa8b805f", false, "BambooTravelAccount", true },
                    { new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), 0, null, "bc4de08a-de12-4409-9eb9-8b6426274c58", null, "info@phuongnamtravel.com", true, "Phương Nam Travel", null, false, null, "INFO@PHUONGNAMTRAVEL.COM", "PHUONGNAMTRAVELACCOUNT", "AQAAAAIAAYagAAAAEJAdzoj/I7WFXNbGGXcunAvoosXenOeSIrB0Jn9E0YnieAQjnHaO7Vii0/B8qtfDNQ==", null, false, "25f8e1c7-8c8d-48cf-abc9-49dd6a690a67", false, "PhuongNamTravelAccount", true },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0, "https://example.com/avatar2.jpg", "8b1884b2-fc7e-4bd0-ba64-2d1b11a3d0b4", new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmawatson@example.com", true, "Emma Watson", false, false, null, "EMMAWATSON@EXAMPLE.COM", "EMMAWATSON", "AQAAAAIAAYagAAAAEP0AZw3v22XqvjMVjzY3sAtwsTHmwLN13G20JAhFhOFn+6F1V+Hpm97zn1/xBcv4mA==", null, false, "c79da329-3f88-473b-83a7-bbacd7988566", false, "EmmaWatson", true },
                    { new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), 0, null, "54a0bb7d-7c71-424f-b322-633c0847e698", null, "support@nhatrangholiday.com", true, "Nha Trang Holiday", null, false, null, "SUPPORT@NHATRANGHOLIDAY.COM", "NHATRANGHOLIDAYACCOUNT", "AQAAAAIAAYagAAAAEGNO1Ara+1Pd1hKlj+buf752DMWUwPNfhk67cC7dNynyj86dLpg2r7gzU5PlPCte6Q==", null, false, "7f962d01-45d8-4ae3-9f17-dafd3de24391", false, "NhaTrangHolidayAccount", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "867ff498-e457-4e64-8e42-4101b03f0ef6", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAEKitF+0GIs+ODFxFQLasiEC2QuWN0VZMklAFgsujkFr2hgtoI/KnVzonJvc3WUuORQ==", null, false, "8b89d84f-e4fd-42dd-bbb2-8737cd6c6344", false, "TourGuides", true },
                    { new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), 0, null, "a0d09e74-4c4b-4edc-a839-907efd280d9b", null, "support@hanoitourist.com", true, "Hanoitourist", null, false, null, "SUPPORT@HANOITOURIST.COM", "HANOITOURISTACCOUNT", "AQAAAAIAAYagAAAAEE4uxmTmm5P6L+zUZSxvzFK/oYEvSlHQZeQe/6nXaN1ck3iMQ5JoDTwueMccGiqUhw==", null, false, "6cfb6f00-ae59-40c9-8bd3-680ccda3ed97", false, "HanoitouristAccount", true },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 0, "https://example.com/avatar3.jpg", "8fb4f243-a4e2-4b74-8af3-9922516dec09", new DateTime(1985, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelbrown@example.com", true, "Michael Brown", true, false, null, "MICHAELBROWN@EXAMPLE.COM", "MICHAELBROWN", "AQAAAAIAAYagAAAAEOLqHQlLCKeoS2dufp/2RO9EObOA2n3y3g5/rAionFeZX1ukBFdC5L0Ivor80gap/g==", null, false, "bf9ed877-b457-40ac-9774-5b2edff61f24", false, "MichaelBrown", true },
                    { new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), 0, null, "5013c4b0-6e78-4920-a331-99be6ee560f1", null, "contact@phanthiettours.com", true, "Phan Thiết Tours", null, false, null, "CONTACT@PHANTHIETTOURS.COM", "PHANTHIETTOURSACCOUNT", "AQAAAAIAAYagAAAAEHVoQ5CKkKUNdEYVnQPSUvKs5WY4z4MCV/C8AruuEsUXJkEz/PSOyfF7r4riZ/Bt7A==", null, false, "b74c7531-78d0-434d-a3a4-053ff96d0490", false, "PhanThietToursAccount", true },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), 0, "https://example.com/avatar8.jpg", "7d6a2002-794a-49d1-a5cb-c77bd7d5f054", new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", true, false, null, "DANIEL.MARTINEZ@EXAMPLE.COM", "DANIELMARTINEZ", "AQAAAAIAAYagAAAAEKkYaaruWcnHQ90xeDpRFoikdEQRYZQhN7zUz9SvlrWUXEt7jEBI/lJ1iV+eHzwY2w==", null, false, "8723c8bd-a916-4171-af97-3884a77aee92", false, "DanielMartinez", true },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 0, "https://example.com/avatar4.jpg", "1b1fe6ba-90f7-4cda-8253-8de2fe297757", new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophialee@example.com", true, "Sophia Lee", false, false, null, "SOPHIALEE@EXAMPLE.COM", "SOPHIALEE", "AQAAAAIAAYagAAAAEEiWAjaUiOSKpIYp54988P08Y+91mqoMM8gIQ2kgl/UkXp/PMkN1miywS3+cT1S2Lg==", null, false, "d31a3694-a1c4-4d2f-b570-a8f58354ea97", false, "SophiaLee", true },
                    { new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), 0, null, "478a7d49-4af6-4653-b244-6ccf1abfafb5", null, "info@redtour.com.vn", true, "Redtour", null, false, null, "INFO@REDTOUR.COM.VN", "REDTOURACCOUNT", "AQAAAAIAAYagAAAAECuW24KLtZnASdveqTZLqYiMFcvG/YKeMXA3NXjgLHMhytLSN1x1MyFWMn6zbwhuRA==", null, false, "2641bfed-721b-4ca3-b96a-587ddb8b6927", false, "RedtourAccount", true },
                    { new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), 0, "https://example.com/avatar9.jpg", "426acb76-a72f-4fbf-94bc-964af6d4e8a0", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilyclark@example.com", true, "Emily Clark", false, false, null, "EMILYCLARK@EXAMPLE.COM", "EMILYCLARK", "AQAAAAIAAYagAAAAEN2AWBwHmQ8niFrGZ4ezjyHWcP8fN7RdJ+TQbqKyu6S7vqdrFyv1WhTkwP6qGXsNfw==", null, false, "9e66c10c-8a16-41fb-a4a1-f5fad7753186", false, "EmilyClark", true },
                    { new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), 0, null, "767753c8-75a5-423b-b3d5-8e6f4c31f12d", null, "contact@quynhonexplorer.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@QUYNHONEXPLORER.COM", "QUYNHONEXPLORERACCOUNT", "AQAAAAIAAYagAAAAEKOH53snksSgqhDoMjYirJsLsB9EGLzL6SKvJ3hPpo6nUUjHCgTZjtGTp7I2lb2m/A==", null, false, "6c3419c2-f10f-4d16-8e8a-4ac605dfe04f", false, "QuyNhonExplorerAccount", true },
                    { new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), 0, null, "319dcb5a-61c3-4423-bbd5-85eb6f1ed9b8", null, "contact@datviettour.com", true, "Đất Việt Tour", null, false, null, "CONTACT@DATVIETTOUR.COM", "DATVIETTOURACCOUNT", "AQAAAAIAAYagAAAAEOVuBVYnnF2e8++87/l/skhrRANzILcGYWY6XhDAQ0S0ae2DoFxn8D/8pkIu+b+0Tg==", null, false, "1a09cc94-45a1-48a3-8105-c1ad7ab3ff79", false, "DatVietTourAccount", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "bce61f65-fa2f-4b91-970a-48638b9d208a", null, "thutt170727@gmail.com", true, "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAENOx+rPViek+RJ+ep1RAgIxmocYb6OLReHlkM9sSF4IVS1lr8/9eeWdR27F3C2sufA==", null, false, "67e88747-eb61-488c-83ce-24a321a9cf3f", false, "ATFO", true },
                    { new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), 0, null, "759816c4-8293-47f3-9f3d-849da3ad44e4", null, "contact@vietsuntravel.com", true, "VietSun Travel", null, false, null, "CONTACT@VIETSUNTRAVEL.COM", "VIETSUNTRAVELACCOUNT", "AQAAAAIAAYagAAAAEGDS0Rl/dTVRNiVP+JoASZa6qq2eHUKeMzTqs8NRm5iyCdWaHej0vGcLImUf3UoLeA==", null, false, "cefd6772-848e-4ec5-86f2-f787f618cb78", false, "VietSunTravelAccount", true },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "https://example.com/avatar5.jpg", "02ddcd5e-d6f5-4c69-a229-8146718d6a1f", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", true, "David Johnson", true, false, null, "DAVIDJOHNSON@EXAMPLE.COM", "DAVIDJOHNSON", "AQAAAAIAAYagAAAAEDyZWR6Dbva52+FiSIHvgldAi1wX5NMTs8bQOvVaNpKY6TAd35DB631+RaFHUfgL+w==", null, false, "22458b82-9f3b-4e87-b888-f3c4f2e1b42f", false, "DavidJohnson", true },
                    { new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), 0, null, "3af3e9c7-9bf1-4561-adb0-d4b2136c2a8d", null, "contact@havatravel.com", true, "Havatravel", null, false, null, "CONTACT@HAVATRAVEL.COM", "HAVATRAVELACCOUNT", "AQAAAAIAAYagAAAAEBZ7/bPl4P+IYP8ZUwmt/Vw6cUrByOaLpLhL4M/5HlAZpAbhi1PIP9M52SyyPEn3pQ==", null, false, "6a5f1768-2119-47b7-9362-4e4cd06bb1ef", false, "HavatravelAccount", true },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "5082c809-3432-4a2f-b2c9-6960649c3d96", null, "thutt170727@gmail.com", true, "Administrator", null, false, null, "THUTT170727@GMAIL.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAEFF6IluEDQuSlfKwNz1L4CTyvT9Ce1COtJ3zm4wy4yWAliB/EAW8LEOGlhE14nhOMw==", null, false, "1d2f21bb-ee62-4f37-8ed8-71c8297a2cbb", false, "Administrator", true },
                    { new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), 0, null, "89f1f856-ffa1-44f8-bff4-d783ce4b0ab8", null, "info@vungtautravel.com", true, "Vũng Tàu Travel", null, false, null, "INFO@VUNGTAUTRAVEL.COM", "VUNGTAUTRAVELACCOUNT", "AQAAAAIAAYagAAAAELjZweKV/mufwSqsYRPREGMNuQgqCxF22MYQ+xBtO7XftewNRvOZtyz8HKrY3uU2Lw==", null, false, "cbf88fd0-a88a-4a47-849c-ee0eb0a73aa7", false, "VungTauTravelAccount", true },
                    { new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), 0, null, "cd2f3c0b-b645-4972-94dc-42530ef25579", null, "info@dalattour.com", true, "Đà Lạt Tour", null, false, null, "INFO@DALATOUR.COM", "DALATTOURACCOUNT", "AQAAAAIAAYagAAAAEJSphqJ2cMcETV4kufXkZkeCgzydF4ngicJGdS5YWVBZO+p0RcFV6LjFi/v9bpWkhA==", null, false, "a2b7587f-d6c3-425d-8239-87d18bf68f2e", false, "DalatTourAccount", true },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0, "https://example.com/avatar6.jpg", "b1df3350-5972-410e-953c-6ed0e298ae91", new DateTime(1987, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "liamnguyen@example.com", true, "Liam Nguyen", true, false, null, "LIAMNGUYEN@EXAMPLE.COM", "LIAMNGUYEN", "AQAAAAIAAYagAAAAEAUBTssUj9nf4dq1YRhzutkYvdRVL3f8HqBYTSFL/aM65KFEqu+bBQmor844fK6yOA==", null, false, "7bdf8ce3-fd8b-4de9-9564-e561786ee22d", false, "LiamNguyen", true },
                    { new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), 0, null, "f82d26c6-a117-4d3d-9ae2-cf26b9f8be59", null, "info@danangtravel.com", true, "Danang Travel", null, false, null, "INFO@DANANGTRAVEL.COM", "DANANGTRAVELACCOUNT", "AQAAAAIAAYagAAAAELxLCLBjl9LCwYjJaU5/uz4KlLaJqmEICFhVw1YWdo7qDpf8QWj2ehGeb04+Xx9m8A==", null, false, "b3e30737-b9f5-4f15-ad8c-868809d5be47", false, "DanangTravelAccount", true },
                    { new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), 0, null, "dc187dce-f284-4524-9717-e19f0f8812d2", null, "contact@saigontourist.net", true, "Saigontourist", null, false, null, "CONTACT@SAIGONTOURIST.NET", "SAIGONTOURISTACCOUNT", "AQAAAAIAAYagAAAAEHOOP3ynOwy/BWTjaRY+/btb7CAByHDYod/EHe1eMdmReAORzG6d5o0VPWlhVpwZvA==", null, false, "506031d1-d5f9-416c-a3c2-2e9ff281792a", false, "SaigontouristAccount", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "7f10b929-cf41-4703-aaea-86ce37e71098", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAEAA/nHX8FoqUdC+zI2BVdj3JohshrBHCUWqNAVFciPJQ+gg/iIxYuaVJHGkjH8RfgQ==", null, false, "56ff54a1-aab2-4bbf-83e6-e4f91124fada", false, "Tourists", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f1"), 0, null, "b730a296-8989-4b0a-bdd3-4078ad9c4c63", null, "thuylinh@fpt.edu.vn", true, "Thùy Linh", null, false, null, "THUYLINH@FPT.EDU.VN", "THUYLINH", "AQAAAAIAAYagAAAAEIBwJAO3LoUUc2CZf6mwifGdHt56Yl+81IAauWTXohYMQA4AVqwj7HbHnm+/phBaOg==", null, false, "ec0dcf85-6484-4a29-84dd-cd5b8c886107", false, "thuylinh", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f2"), 0, null, "af363234-45c9-4361-b0ba-661c60eaf247", null, "hoaithu@fpt.edu.vn", true, "Hoài Thu", null, false, null, "HOAITHU@FPT.EDU.VN", "HOAITHU", "AQAAAAIAAYagAAAAEBcWJiNYWkTZkzKDcPudrnKQkkg0iwKuqTN0rzOmiGDme+NLO6v7d4OQ1fvG0ScwcA==", null, false, "5b981c6d-bdf8-4ec9-b13a-867179160538", false, "hoaithu", true },
                    { new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), 0, null, "81dafec7-fa88-4b09-a9c8-1dff4f807255", null, "support@dulichtoday.com", true, "Dulich Today", null, false, null, "SUPPORT@DULICHTODAY.COM", "DULICHTODAYACCOUNT", "AQAAAAIAAYagAAAAEPNcjIhqKYVOv/4nyThpCOiI7jgFTDirDHO5LeCj5ZRSog+Fnlmi3AgaNnSXv3Y/TQ==", null, false, "f70cfe65-27d9-4755-9588-3b4c5d72e7fd", false, "DulichTodayAccount", true },
                    { new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), 0, null, "38f6c93f-5122-4bf0-806a-0cfc0961daaf", null, "info@fiditour.com", true, "Fiditour", null, false, null, "INFO@FIDITOUR.COM", "FIDITOURACCOUNT", "AQAAAAIAAYagAAAAEHKRPemsVs/FdbHLAsRsGZtNxEywRJdDWC2PJ6/SwkrqLOlijeMXsDo8ExaY5HO3Jg==", null, false, "7e93d43a-4cfc-4838-b62a-640ef6c6f281", false, "FiditourAccount", true },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 0, "https://example.com/avatar7.jpg", "98820b89-1623-451a-b21f-47620fa02668", new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviakim@example.com", true, "Olivia Kim", false, false, null, "OLIVIAKIM@EXAMPLE.COM", "OLIVIAKIM", "AQAAAAIAAYagAAAAEGd47w7YE68rjPEHrOHk4ho/REAxeyiN8pDUr1jfSB9ZDJABMzXmn33aJ9u98OBYeA==", null, false, "2fa50f0f-46f1-4c3d-9e02-e293a75a17fd", false, "OliviaKim", true }
                });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0072d380-4f99-46c8-b6f2-7be93bc53b3a"), "Phương Nam Travel", "0011001489398", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6939), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("016d7748-42b2-4230-a700-5c736168cc3e"), "Mỹ Xuyên Farmstay", "0011005903350", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6861), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null },
                    { new Guid("14f4fb4b-6a43-498a-8bfb-ec3866c130a7"), "Bamboo Travel", "0011007911713", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6935), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("18628404-2bbf-4f10-acf9-3b31301c5b8a"), "Farmstay Nho & Thanh Long Bắc Bình", "0011007900375", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6838), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("1be62f53-f419-45fa-88a2-2aeeec49b8c0"), "Phan Thiết Tours", "0011009993094", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7008), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("20de6d95-ff3e-418c-b6b6-da62133e04b0"), "Saigontourist", "0011008495278", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6919), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("2280711a-8b03-4aed-8f06-4d6b92d0bad0"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011005410742", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6795), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("32435250-38b2-44ca-9864-b4e09a2553bf"), "Đất Việt Tour", "0011001707159", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6941), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null },
                    { new Guid("36453bd9-3838-464f-a681-25111dd8087e"), "Havatravel", "0011009854633", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6950), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("379592d7-e268-4a30-9586-79213bffc692"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011002161903", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6856), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null },
                    { new Guid("44f2fd4b-5630-4222-8867-7a2ecada4fdb"), "Sa Pa Eco Farm Tour", "0011008532816", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6813), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("64827ff7-ff83-49d8-92e5-4258ebbde41e"), "Vũng Tàu Travel", "0011004636258", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6954), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null },
                    { new Guid("75ceeae6-5e21-40b8-9a14-e5302550a8c5"), "Hà Giang Farmstay & Trek", "0011009746881", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6828), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("7bd7a3d1-472f-43c0-8ac5-ffdc728e43f0"), "Dulichtoday", "0011009291851", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6947), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("816ae885-b47b-451e-b692-546ceb003694"), "Trang Trại Nông Sản Sạch Tân Châu", "0011007159559", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6852), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("96e82fb8-342d-4ccc-8245-f9454b797bf4"), "Trang Trại Châu Đốc", "0011005197989", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6865), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("9c74748b-d4aa-41eb-99ec-8223ee358e14"), "Hanoitourist", "0011002805697", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6924), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("a7a293a2-22c4-4717-8a37-754dd96593d3"), "Nha Trang Holiday", "0011009516165", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7000), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("b310666d-f9ab-4016-8006-f0a3d93432f7"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011009964186", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6657), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("b3d98eeb-a124-4ab4-8ab8-9a47254b104a"), "Công ty Cổ phần Vietravel", "0011001214520", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6915), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("b65f6e9b-f14a-4076-9bcb-5dc1bfecdd7b"), "Trà My Sâm Ngọc Linh Tour", "0011003394126", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6833), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("be993198-082b-408c-a081-8dc4c48d29bd"), "Redtour", "0011007138275", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6944), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("c30a9685-f4c5-4c09-b35a-6494704676fa"), "Danang Travel", "0011001155789", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6930), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("ca5d19dd-35ca-43eb-98b9-3586c48fa006"), "Fiditour", "0011004529357", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6926), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("cb8a44a0-563d-40a2-804a-e48cc22cc0ea"), "Đà Lạt Organic Farm Tour", "0011007571764", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6835), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("ce174474-763a-4250-9244-c1d000ef6116"), "Farm Du Lịch Grape Valley", "0011009109788", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6816), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("da0d2a63-8bd9-42d9-90b1-cbc013f227bd"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011008560173", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6822), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("e114c9c7-d9aa-40c6-b944-5c79ab17d205"), "Ba Bể Lake Ecofarm Tour", "0011004229143", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6843), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null },
                    { new Guid("e74ce0cd-1498-436c-a052-4d675b07971f"), "Trang Trại Nông Sản Sạch Càng Long", "0011004275884", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6859), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("f1707220-90a5-4e7e-9a94-859a7bf44f7e"), "Buôn Đôn Coffee Farm Tour", "0011009257738", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6825), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("f3b14b93-9b98-423b-9e6b-2208cfe786c0"), "VietSun Travel", "0011004478079", "Vietcombank", "Hanoi Branch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(6932), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null }
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
                    { 1, "SmtpServer", 0, "smtp.gmail.com", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6815), null },
                    { 2, "Port", 0, "587", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6820), null },
                    { 3, "Email", 0, "thangnvse151059@fpt.edu.vn", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6821), null },
                    { 4, "AppPassword", 0, "sllgcjfbkpgcwnmp", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6822), null },
                    { 5, "TmnCode", 1, "7S4BSWDD", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6823), null },
                    { 6, "HashSecret", 1, "RC7QASGETNFSP0EDKUE4IT7X6VRKM4NJ", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6824), null },
                    { 7, "Url", 1, "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6825), null },
                    { 8, "Command", 1, "pay", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6826), null },
                    { 9, "CurrCode", 1, "VND", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6827), null },
                    { 10, "Version", 1, "2.1.0", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6828), null },
                    { 11, "Locale", 1, "vn", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6829), null },
                    { 12, "PaymentBackReturnUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6830), null },
                    { 13, "BookingUrl", 1, "https://localhost:5001/api/tourist/book-tour/return_book", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6831), null },
                    { 14, "OrderUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6832), null }
                });

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("004ac8b1-2aff-4db9-8e8d-b65863810386"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8202), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("0866c3b6-15f3-4884-af55-4557538ddef4"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8213), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("243216f5-2f85-4d42-b715-a5cf75b134da"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8205), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("38fd48aa-da8f-4e78-a43d-a124e27de26a"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8216), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("4232f31c-5d61-4170-937c-796dc8840b2e"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8218), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("7f6b1a96-e0df-45a1-97dc-ed2e79a3a693"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8209), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("87cc206b-71d3-40b9-aad2-cc07d9e6fd52"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8198), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("ac9c4c46-8ad1-436f-967b-31472baa578a"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8210), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("c64bdafc-d2a9-4cc7-a087-c0c244edeb77"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8207), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("c64ee710-92fa-4d7f-9905-aad31504ed15"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8211), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("dd9d2d25-5aeb-4f92-86fe-33062de8acc1"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8195), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("e5487b96-13b3-444a-8439-e13850ca6f41"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8204), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8141), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8139), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("d549690a-59da-4c91-8179-7ba2102800e2"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8134), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("169e14fb-638a-4f9d-9594-0cd3abbfd06e"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("436f8710-1f64-4d1a-9352-f376f4ff00ba"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("4c8c61af-49e6-4a49-8513-388463959f37"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("5da49260-df2d-437f-a30a-cba517763278"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("649e3073-8bac-4b06-a9c2-7ae049f70215"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("8bfcbfce-ccf1-43f1-8ec9-3bae5b4ed819"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("a8787941-0849-49f0-83e8-70af6b8854e2"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("ad7e9193-c23d-4d55-b915-a74e70e314d3"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("ad9b2ee5-6d1d-4e99-ac52-c36de02c2b85"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("c39bf8b0-a651-4e21-85e4-8ad5a9fbfb2f"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("d6b3a906-2e12-4a29-aa64-09863086a735"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("fbe2e8d2-4bed-41d3-a687-31a713f98952"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null }
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
                    { new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), "120 Phan Chu Trinh, TP.Huế", "Công ty du lịch chuyên nghiệp tại Huế.", "Havatravel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6910), "contact@havatravel.com", "https://img.freepik.com/premium-vector/tours-travel-logo-with-airplane-passing-blue-world_101890-71.jpg?w=2000", null, new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), "https://havatravel.com/" },
                    { new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), "45 Điện Biên Phủ, Quận 3, TP.HCM", "Chuyên tour du lịch nội địa và quốc tế.", "VietSun Travel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6893), "contact@vietsuntravel.com", "https://th.bing.com/th/id/OIP.nwXDxpVx9hsOdW9efOtlRAHaDq?w=334&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), "https://vietsuntravel.com/" },
                    { new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), "15 Phạm Ngũ Lão, Quận 1, TP.HCM", "Dịch vụ du lịch cao cấp.", "Bamboo Travel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6896), "contact@bambotravel.com", "https://th.bing.com/th/id/OIP.8nxVZ-RcEPQMdis_Yg4TWAHaHa?w=180&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), "https://bambotravel.com/" },
                    { new Guid("22275542-0625-47be-a503-2f13b7576e9b"), "23 Lê Lợi, TP. Phan Thiết", "Chuyên tour khám phá biển và cát trắng.", "Phan Thiết Tours", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6919), "contact@phanthiettours.com", "https://th.bing.com/th/id/OIP.KBj43NwwtJw5Ht71M6ts8gHaF7?rs=1&pid=ImgDetMain", null, new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), "https://phanthiettours.com/" },
                    { new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), "50 Nguyễn Trãi, TP. Vũng Tàu", "Tour du lịch biển chất lượng cao.", "Vũng Tàu Travel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6913), "info@vungtautravel.com", "https://mir-s3-cdn-cf.behance.net/project_modules/1400/2cf01f84467867.5d5da886617be.jpg", null, new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), "https://vungtautravel.com/" },
                    { new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), "90 Nguyễn Văn Linh, Đà Nẵng", "Thông tin và tổ chức tour du lịch.", "Dulichtoday", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6907), "support@dulichtoday.com", "https://png.pngtree.com/png-clipart/20200722/original/pngtree-travel-and-tour-logo-png-image_5051851.jpg", null, new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), "https://dulichtoday.com/" },
                    { new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), "75 Hùng Vương, TP. Nha Trang", "Dịch vụ đặt tour du lịch biển chuyên nghiệp.", "Nha Trang Holiday", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6916), "support@nhatrangholiday.com", "https://th.bing.com/th/id/OIP.inoQUXN-Y4DfWTpe5-ec-gHaFJ?w=241&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), "https://nhatrangholiday.com/" },
                    { new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), "15 Lê Lợi, Quận 1, TP.HCM", "Tour trọn gói, uy tín.", "Fiditour", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6889), "info@fiditour.com", "https://th.bing.com/th/id/OIP.kzYdv7-VmS2zRF7qZaOyvwAAAA?w=212&h=212&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), "https://fiditour.com/" },
                    { new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), "99 Hoàng Diệu, Ba Đình, Hà Nội", "Du lịch chất lượng, giá rẻ.", "Phương Nam Travel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6899), "info@phuongnamtravel.com", "https://th.bing.com/th/id/OIP.p6Shq1r_4g--m-4Q8nIUfgHaHa?rs=1&pid=ImgDetMain", null, new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), "https://phuongnamtravel.com/" },
                    { new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), "10 Lê Thánh Tôn, Quận 1, TP.HCM", "Chuyên tổ chức tour du lịch trong và ngoài nước.", "Đất Việt Tour", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6902), "contact@datviettour.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMJbyGoIQYOyNFDh34TrlaOOozlKmiTefzoQ&s", null, new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), "https://datviettour.com/" },
                    { new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), "20 Trần Hưng Đạo, Hà Nội", "Dịch vụ du lịch chất lượng cao.", "Redtour", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6905), "info@redtour.com.vn", "https://th.bing.com/th/id/OIP.zD605q-X7zzIpJAgyfVvwQHaHa?pid=ImgDet&w=184&h=184&c=7&dpr=1.3", null, new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), "https://redtour.com.vn/" },
                    { new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), "90 Nguyễn Thị Minh Khai, Đà Nẵng", "Chuyên tour biển đảo Đà Nẵng.", "Danang Travel", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6891), "info@danangtravel.com", "https://th.bing.com/th/id/OIP.vj2L0nLe0ocGi4pxbLwnowHaHa?w=200&h=199&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), "https://danangtravel.com/" },
                    { new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), "25 Nguyễn Huệ, Quận 1, TP.HCM", "Lữ hành hàng đầu Việt Nam.", "Saigontourist", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6883), "contact@saigontourist.net", "https://icolor.vn/wp-content/uploads/2021/01/Tham-kh%E1%BA%A3o-Logo-c%C3%B4ng-ty-du-l%E1%BB%8Bch-Saigontourist-3.jpg", null, new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), "https://saigontourist.net/" },
                    { new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"), "66 Trần Phú, TP. Quy Nhơn", "Tour du lịch biển và văn hóa Quy Nhơn.", "Quy Nhơn Explorer", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6934), "contact@quynhonexplorer.com", "https://th.bing.com/th/id/OIP.lVVxjoYVel7RgNeu1hH2RgHaFr?rs=1&pid=ImgDetMain", null, new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), "https://quynhonexplorer.com/" },
                    { new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"), "14 Nguyễn Huệ, TP. Đà Lạt", "Tour du lịch khám phá Đà Lạt.", "Đà Lạt Tour", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6921), "info@dalattour.com", "https://images-platform.99static.com/OowUwWHMa4KA7v_azo1Bq_7ByCs=/6x0:1001x995/500x500/top/smart/99designs-contests-attachments/86/86578/attachment_86578583", null, new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), "https://dalattour.com/" },
                    { new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội", "Tour du lịch nội địa và quốc tế.", "Hanoitourist", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(6886), "support@hanoitourist.com", "https://th.bing.com/th/id/OIP.DQh7E8nzGNx-fipB0stcygHaGf?w=190&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), "https://hanoitourist.com/" },
                    { new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), "03 Hai Bà Trưng, Hoàn Kiếm, Hà Nội.", "", "Công ty Cổ phần Vietravel", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "vtv.cholon@vietravel.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyblRzW2ET2uC9wdJBm6_PUq1zCiSi6SGJw&s", null, new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), "https://travel.com.vn/" }
                });

            migrationBuilder.InsertData(
                table: "TouristFacility",
                columns: new[] { "TouristFacilityId", "Address", "ContactInfor", "CreateDate", "Description", "EmailTouristFacility", "LogoURL", "TouristFacilityName", "UpdateTime", "UserId", "Website", "district_id", "district_name", "phone", "province_name", "ward_code", "ward_name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Xã Đàm Thủy, Huyện Trùng Khánh, Cao Bằng", "0206 388 8888", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7035), "Khu du lịch sinh thái kết hợp nông nghiệp tại vùng biên giới Thác Bản Giốc.", "contact@bangiocfarmtour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F2.webp?alt=media&token=401b4f70-d92e-4656-805d-f50712f67043", "Du Lịch Sinh Thái Thác Bản Giốc", null, new Guid("10000000-0000-0000-0000-000000000001"), "www.bangiocfarmtour.vn", 1976, "Huyện Mộc Châu", "0988888999", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Thôn Cát Cát, Xã San Sả Hồ, Sa Pa", "0214 666 7777", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7060), "Tour trải nghiệm nông nghiệp và văn hóa H'Mông tại bản Cát Cát.", "eco@sapa.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F3.jpg?alt=media&token=396747b2-3c0a-4e37-9d13-7f07dea2890f", "Sa Pa Eco Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000002"), "www.sapaecotour.vn", 1976, "Huyện Mộc Châu", "0911777555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Thôn Thái An, Xã Vĩnh Hải, Huyện Ninh Hải", "0259 333 4567", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7063), "Trải nghiệm hái nho, làm rượu vang và nghỉ dưỡng tại thung lũng nho.", "info@grapevalley.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F4.jpg?alt=media&token=25f62207-6552-4052-aca8-608b93335980", "Farm Du Lịch Grape Valley", null, new Guid("10000000-0000-0000-0000-000000000003"), "www.grapevalley.vn", 1976, "Huyện Mộc Châu", "0909000011", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Xóm Cầu Tre, Xã La Bằng, Huyện Đại Từ", "0208 123 4567", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7065), "Du lịch nông nghiệp kết hợp trải nghiệm hái chè, sao chè và thưởng thức tại chỗ.", "farm@daitu.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F5.jpg?alt=media&token=799ba94b-35db-4332-bd15-f16d52411fa1", "Nông Trại Chè Trải Nghiệm Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000004"), "www.daitu-teafarm.vn", 1976, "Huyện Mộc Châu", "0977000111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Xã Ea M’nang, Huyện Cư M’gar, Đắk Lắk", "0262 888 8899", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7069), "Tour trải nghiệm vườn cà phê, tham quan quy trình rang xay và cưỡi voi Buôn Đôn.", "visit@buondoncoffee.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F6.jpg?alt=media&token=f81fee5d-3e8e-4aa8-a25b-0526c1daab9d", "Buôn Đôn Coffee Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000005"), "www.buondoncoffee.vn", 1976, "Huyện Mộc Châu", "0918888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Xã Sà Phìn, Huyện Đồng Văn", "0219 366 6888", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7072), "Trải nghiệm cuộc sống vùng cao, làm nông, làm bánh truyền thống và trekking đèo đá.", "trek@hagiang.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F7.jpg?alt=media&token=3a5d4f25-f909-4d81-a4b3-0a7d3a945c26", "Hà Giang Farmstay & Trek", null, new Guid("10000000-0000-0000-0000-000000000006"), "www.hagiangfarmstay.vn", 1976, "Huyện Mộc Châu", "0988999111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Xã Trà Linh, Huyện Nam Trà My", "0235 322 3222", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7075), "Khám phá vườn sâm Ngọc Linh, trải nghiệm trồng sâm, thưởng thức dược liệu.", "info@tramyfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F8.jpg?alt=media&token=8d9dca9e-1aaf-43f6-bd36-d8d512972744", "Trà My Sâm Ngọc Linh Tour", null, new Guid("10000000-0000-0000-0000-000000000007"), "www.tramyfarmtour.vn", 1976, "Huyện Mộc Châu", "0966555777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Phường 7, Thành phố Đà Lạt", "0263 355 8888", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7078), "Du lịch trải nghiệm trồng dâu, làm rau thủy canh, check-in nông trại xanh.", "info@dalatorganic.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F9.jpg?alt=media&token=eb13f3b8-e307-4907-865b-27b5f25c34ab", "Đà Lạt Organic Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000008"), "www.dalatorganic.vn", 1976, "Huyện Mộc Châu", "0933222111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Xã Phan Thanh, Huyện Bắc Bình", "0252 355 9000", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7082), "Trải nghiệm hái nho, tham quan vườn thanh long sạch và picnic giữa đồng nắng gió Bình Thuận.", "hello@binhthuanfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F10.jpg?alt=media&token=0113dd93-8a2e-478d-9ac1-e165995e1936", "Farmstay Nho & Thanh Long Bắc Bình", null, new Guid("10000000-0000-0000-0000-000000000009"), "www.binhthuanfarm.vn", 1976, "Huyện Mộc Châu", "0933444555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Xã Nam Mẫu, Huyện Ba Bể", "0209 366 2333", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7084), "Trải nghiệm chèo thuyền, nông nghiệp sinh thái, ở nhà sàn truyền thống người Tày.", "contact@babeecotour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F11.jpg?alt=media&token=81df566c-b4ed-4591-acc0-f17238f14f21", "Ba Bể Lake Ecofarm Tour", null, new Guid("10000000-0000-0000-0000-000000000010"), "www.babeecotour.vn", 1976, "Huyện Mộc Châu", "0966001122", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Xã Tân Hưng, Huyện Tân Châu", "0276 366 7788", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7087), "Khám phá quy trình trồng rau hữu cơ, nuôi bò sữa, làm sữa chua và trồng nấm sạch.", "info@tayninhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F12.jpg?alt=media&token=0393caa4-5c9e-4bde-bf5b-b68712ec4469", "Trang Trại Nông Sản Sạch Tân Châu", null, new Guid("10000000-0000-0000-0000-000000000011"), "www.tayninhfarm.vn", 1976, "Huyện Mộc Châu", "0944111222", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Xã An Chấn, Huyện Tuy An", "0257 388 8888", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7091), "Trải nghiệm canh tác rau ven biển, tắm biển, đốt lửa trại và học làm nước mắm truyền thống.", "tour@phuyentour.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F13.jpg?alt=media&token=9c9796b8-e39a-48d1-8863-0fc7142ae7b4", "Trải nghiệm Nông trại Biển & Rau Tuy An", null, new Guid("10000000-0000-0000-0000-000000000012"), "www.phuyentour.vn", 1976, "Huyện Mộc Châu", "0977222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Xã Mỹ Long Bắc, Huyện Càng Long", "0294 355 1122", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7095), "Khám phá quy trình sản xuất mắm, trồng cây ăn trái và sản phẩm nông sản sạch.", "contact@travinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F14.jpg?alt=media&token=843e14d6-3851-4315-bc98-6260f35d3d4e", "Trang Trại Nông Sản Sạch Càng Long", null, new Guid("10000000-0000-0000-0000-000000000013"), "www.travinhfarm.vn", 1976, "Huyện Mộc Châu", "0908222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Xã Mỹ Xuyên, Huyện Mỹ Xuyên", "0299 555 2333", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7098), "Trải nghiệm mô hình nông nghiệp hữu cơ, tham quan các cánh đồng lúa, vườn cây ăn trái.", "tour@soctrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F15.jpg?alt=media&token=7342e675-73c3-43d0-97cc-684082c6ee44", "Mỹ Xuyên Farmstay", null, new Guid("10000000-0000-0000-0000-000000000014"), "www.soctrangfarm.vn", 1976, "Huyện Mộc Châu", "0933112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Xã Vĩnh Tế, Huyện Châu Đốc", "0296 388 1133", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7100), "Trải nghiệm canh tác nông nghiệp tại đồng bưng, tham quan vườn trái cây đặc sản miền Tây.", "contact@angiangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F16.jpg?alt=media&token=9e2b8638-1acb-4191-9a20-b41aabf0e29f", "Trang Trại Châu Đốc", null, new Guid("10000000-0000-0000-0000-000000000015"), "www.angiangfarm.vn", 1976, "Huyện Mộc Châu", "0977445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Xã Nhơn Ái, Huyện Phong Điền", "0292 388 1222", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7104), "Trải nghiệm mô hình trồng cây trái, tham quan các vườn rau hữu cơ và chợ nổi Cần Thơ.", "info@canthoexplore.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F17.jpg?alt=media&token=69beecb6-461f-4481-899f-3674b48c06f4", "Cần Thơ Farmstay", null, new Guid("10000000-0000-0000-0000-000000000016"), "www.canthoexplore.vn", 1976, "Huyện Mộc Châu", "0939332111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Xã Cửa Dương, Huyện Phú Quốc", "0297 223 4455", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7107), "Tham quan mô hình nông nghiệp hữu cơ, vườn dưa lưới, vườn trái cây nhiệt đới.", "tour@phuquocfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F18.jpg?alt=media&token=3e95d7ab-1114-421e-bb7b-defe761897e8", "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, new Guid("10000000-0000-0000-0000-000000000017"), "www.phuquocfarm.vn", 1976, "Huyện Mộc Châu", "0909888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Xã Đồng Mai, TP. Hạ Long", "0203 356 7890", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7112), "Trải nghiệm mô hình trồng rau hữu cơ và nuôi trồng thủy sản, tham quan khu vườn cây ăn trái đặc sản.", "info@halongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F19.jpg?alt=media&token=e8f5ef36-21fa-426b-a36b-9f9c9e709591", "Trại Nông Sản Hạ Long", null, new Guid("10000000-0000-0000-0000-000000000018"), "www.halongfarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Xã An Thắng, Huyện An Lão", "0225 350 1000", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7115), "Khám phá mô hình trồng trọt và chăn nuôi, học hỏi cách trồng rau sạch và gia cầm.", "contact@anlaofarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F20.jpg?alt=media&token=c8f94cf0-425e-45b1-9745-f0ed7c51a609", "Trang Trại Nông Sản An Lão", null, new Guid("10000000-0000-0000-0000-000000000019"), "www.anlaofarm.vn", 1976, "Huyện Mộc Châu", "0932556789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Xã Phú Lạc, Huyện Đại Từ", "0208 382 5000", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7117), "Trải nghiệm các hoạt động nông nghiệp như trồng lúa, chăm sóc vườn rau và tham gia các hoạt động nông dân.", "tour@daitufarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F21.jpg?alt=media&token=0402e7c8-075d-4cb0-bbea-98efe121ede8", "Nông Trại Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000020"), "www.daitufarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Xã Nghi Phú, TP. Vinh", "0238 379 1111", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7120), "Khám phá các vườn cây ăn trái, trồng rau hữu cơ và tìm hiểu về sản phẩm nông sản của vùng đất xứ Nghệ.", "contact@vinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F22.jpg?alt=media&token=eb04cf86-f0c9-4301-977b-89e9cbd7d75e", "Trại Nông Sản Vinh", null, new Guid("10000000-0000-0000-0000-000000000021"), "www.vinhfarm.vn", 1976, "Huyện Mộc Châu", "0912233445", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Xã Sơn Lâm, Huyện Triệu Sơn", "0237 375 6789", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7124), "Tham gia vào các hoạt động nông nghiệp như thu hoạch rau, chăm sóc cây ăn trái, tham quan vườn thuốc nam.", "contact@trieusonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F23.jpg?alt=media&token=3855d2e9-4a16-4c6f-b5db-da2623520b5d", "Trang Trại Nông Sản Triệu Sơn", null, new Guid("10000000-0000-0000-0000-000000000022"), "www.trieusonfarm.vn", 1976, "Huyện Mộc Châu", "0988112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Xã Thạch Hưng, TP. Hà Tĩnh", "0239 354 5678", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7126), "Khám phá nông sản hữu cơ, tham gia các hoạt động làm vườn và trồng cây ăn quả.", "contact@hatinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F24.jpg?alt=media&token=c759c7e9-f707-4c22-afdd-13809209e5cf", "Trại Nông Sản Hà Tĩnh", null, new Guid("10000000-0000-0000-0000-000000000023"), "www.hatinhfarm.vn", 1976, "Huyện Mộc Châu", "0916889900", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Xã Quảng Phú, TP. Đồng Hới", "0232 382 7890", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7130), "Trải nghiệm nông nghiệp sinh thái với các mô hình trồng cây, chăm sóc động vật và tham quan các khu vườn.", "contact@donghoifarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F25.jpg?alt=media&token=fbb74270-5fe0-4a44-ba94-4b9a0ebd9a61", "Trang Trại Đồng Hới", null, new Guid("10000000-0000-0000-0000-000000000024"), "www.donghoifarm.vn", 1976, "Huyện Mộc Châu", "0977223344", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Xã Hải Lệ, TP. Đông Hà", "0233 350 5678", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7133), "Khám phá các mô hình trồng cây dược liệu và rau hữu cơ, tham gia các hoạt động chăm sóc động vật.", "contact@donghafarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F26.jpg?alt=media&token=1e91565d-c6ba-43f2-b73f-35c6710abcc5", "Trang Trại Nông Sản Đông Hà", null, new Guid("10000000-0000-0000-0000-000000000025"), "www.donghafarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Xã Phước Sơn, TP. Quy Nhơn", "0256 382 7890", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7136), "Tham gia vào các hoạt động trồng rau hữu cơ và chăm sóc vườn trái cây, tìm hiểu sản phẩm nông sản đặc trưng của Bình Định.", "contact@quynhonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F27.jpg?alt=media&token=a7f4dd9e-46f1-450e-850b-0733e35be659", "Trại Nông Sản Quy Nhơn", null, new Guid("10000000-0000-0000-0000-000000000026"), "www.quynhonfarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Xã Hòa Thịnh, TP. Tuy Hòa", "0257 355 6789", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7138), "Trải nghiệm các hoạt động trồng trọt, chăm sóc vườn cây ăn quả, tìm hiểu về các sản phẩm nông sản đặc biệt của Phú Yên.", "contact@tuyhoafarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F28.jpg?alt=media&token=7c964137-2b0f-4ed8-aea7-7393bd154599", "Trang Trại Nông Sản Tuy Hòa", null, new Guid("10000000-0000-0000-0000-000000000027"), "www.tuyhoafarm.vn", 1976, "Huyện Mộc Châu", "0972345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "Xã Vĩnh Thạnh, TP. Nha Trang", "0258 382 9000", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7141), "Khám phá các mô hình trồng cây ăn quả, rau hữu cơ, và các hoạt động du lịch nông nghiệp kết hợp nghỉ dưỡng.", "contact@nhatrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F29.jpg?alt=media&token=80ea2316-f380-48f7-bc74-7919f6d2e718", "Trại Nông Sản Nha Trang", null, new Guid("10000000-0000-0000-0000-000000000028"), "www.nhatrangfarm.vn", 1976, "Huyện Mộc Châu", "0916345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Xã Phước Hải, TP. Phan Rang-Tháp Chàm", "0259 382 1111", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7144), "Trải nghiệm du lịch nông nghiệp, tham quan các vườn cây ăn quả, mô hình trồng nho và sản xuất nông sản.", "contact@phanrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F30.jpg?alt=media&token=5c8bf85f-5ac6-4d67-bde7-20cdbe7ac7f7", "Trại Nông Sản Phan Rang", null, new Guid("10000000-0000-0000-0000-000000000029"), "www.phanrangfarm.vn", 1976, "Huyện Mộc Châu", "0934567890", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Xã Phú Hài, TP. Phan Thiết", "0252 382 5678", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7152), "Trải nghiệm các mô hình trồng cây nông sản và khám phá các sản phẩm đặc trưng của Bình Thuận như thanh long, dừa.", "contact@phanthietfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F31.jpg?alt=media&token=44480008-26be-4bef-96f2-4ebf5375dc35", "Trang Trại Nông Sản Phan Thiết", null, new Guid("10000000-0000-0000-0000-000000000030"), "www.phanthietfarm.vn", 1976, "Huyện Mộc Châu", "0982334455", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Xã An Thạnh, TP. Tân An", "0272 384 5000", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7177), "Khám phá các mô hình trồng cây, chăm sóc cây ăn trái, và tìm hiểu về sản phẩm nông sản của Long An.", "contact@tananfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F32.jpg?alt=media&token=bc7d9acf-b383-4306-b69c-e9bf9d52f0a5", "Trại Nông Sản Tân An", null, new Guid("10000000-0000-0000-0000-000000000031"), "www.tananfarm.vn", 1976, "Huyện Mộc Châu", "0932456789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Xã Phước Hòa, TP. Vĩnh Long", "0270 382 8888", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7180), "Trải nghiệm du lịch nông nghiệp tại vườn cây ăn trái, học hỏi kỹ thuật trồng rau sạch và các hoạt động sinh thái.", "contact@vinhlongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/TouristFacility%2F33.jpg?alt=media&token=65103687-a722-4ba0-84f9-0b6eff272d30", "Trại Nông Sản Vĩnh Long", null, new Guid("10000000-0000-0000-0000-000000000032"), "www.vinhlongfarm.vn", 1976, "Huyện Mộc Châu", "0913445566", "Sơn La", "91295", "Phường 14" },
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
                    { new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8150), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8151), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"), "anhNv@gmail.com", "Nguyễn Văn Anh", true, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8143), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8144), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8156), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8157), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8153), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8154), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"), "BinhLeV@gmail.com", "Lê Văn Bình", true, 3, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8146), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8147), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
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
                    { new Guid("20000000-0000-0000-0000-000000000001"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5767), "Trải nghiệm cuộc sống nông dân tại vùng biên giới, từ gieo trồng, chăm sóc gia súc đến thu hoạch nông sản cùng người dân địa phương.", 1.0, 3, new DateTime(2024, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]", "Một Ngày Làm Nông Dân Vùng Biên", 1500000.0, 1200000.0, 15, new DateTime(2024, 4, 15, 7, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5771), "Tham gia vào hoạt động thu hoạch mùa vụ cùng người dân địa phương, từ thu hoạch đến sơ chế và thưởng thức sản phẩm tươi ngon tại chỗ.", 1.0, 3, new DateTime(2024, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]", "Trải Nghiệm Thu Hoạch Mùa Vụ", 1500000.0, 1200000.0, 20, new DateTime(2024, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5776), "Hành trình khám phá nét văn hóa độc đáo và hoạt động nông nghiệp truyền thống của đồng bào dân tộc Tày - Nùng, từ trải nghiệm trồng trọt đến thưởng thức ẩm thực và nghệ thuật dân gian.", 1.0, 3, new DateTime(2024, 5, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]", "Khám Phá Nông Nghiệp và Văn Hóa Địa Phương", 1500000.0, 1200000.0, 20, new DateTime(2024, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5780), "Trải nghiệm độc đáo kết hợp giữa học tập phương pháp canh tác hữu cơ và nghỉ dưỡng tại homestay sinh thái. Du khách được tham gia vào quy trình trồng trọt sạch và tận hưởng không gian yên bình của thiên nhiên.", 1.0, 3, new DateTime(2024, 5, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]", "Du Lịch Canh Tác Hữu Cơ Kết Hợp Nghỉ Dưỡng", 1500000.0, 1200000.0, 15, new DateTime(2024, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5784), "Trải nghiệm độc đáo về văn hóa nông nghiệp truyền thống của người H'Mông tại Cát Cát, từ canh tác trên ruộng bậc thang đến thu hái thuốc nam và nấu ăn truyền thống.", 1.0, 3, new DateTime(2024, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]", "Một Ngày Làm Nông Dân H'Mông", 1500000.0, 1200000.0, 12, new DateTime(2024, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5789), "Khám phá đời sống văn hóa độc đáo của người H'Mông tại bản Cát Cát, tìm hiểu về nông nghiệp hữu cơ và trải nghiệm làm nghề thủ công truyền thống.", 1.0, 3, new DateTime(2024, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]", "Hành Trình Khám Phá Bản Làng và Nông Nghiệp Hữu Cơ", 1500000.0, 1200000.0, 15, new DateTime(2024, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5744), "Hành trình trải nghiệm nông nghiệp độc đáo tại Mộc Châu, từ tham quan nông trại dâu tây, vắt sữa bò đến thu hoạch rau hữu cơ. Du khách sẽ được trực tiếp tham gia vào các hoạt động nông nghiệp và thưởng thức đặc sản địa phương.", 1.0, 3, new DateTime(2024, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\"]", "Khám Phá Nông Nghiệp Mộc Châu", 1500000.0, 1200000.0, 20, new DateTime(2024, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5758), "Trải nghiệm một ngày làm việc thực tế tại nông trại OCOP, từ chăm sóc vườn rau đến thu hoạch và đóng gói sản phẩm theo tiêu chuẩn.", 1.0, 3, new DateTime(2024, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", "Một Ngày Làm Nông Dân OCOP", 1500000.0, 1200000.0, 12, new DateTime(2024, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5752), "Trải nghiệm văn hóa trà truyền thống tại Mộc Châu, từ tham quan đồi chè, học cách hái và chế biến chè, đến thưởng thức các loại trà OCOP đặc sản.", 1.0, 3, new DateTime(2024, 3, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", "Tour Hái Chè và Thưởng Trà OCOP", 1500000.0, 1200000.0, 15, new DateTime(2024, 3, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5763), "Kết hợp du lịch với hoạt động thiện nguyện và bảo vệ môi trường, từ trồng cây xanh đến tham gia các hoạt động cộng đồng tại bản làng.", 1.0, 3, new DateTime(2024, 4, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", "Du Lịch Thiện Nguyện & Nông Nghiệp Xanh", 1500000.0, 1200000.0, 25, new DateTime(2024, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("3106b037-3f0d-4940-a84c-a5466d4472a9"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8085), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8084), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8084), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c8578caf-d5e3-43de-a006-2f33c37854aa"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8081), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8081), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8080), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractId", "ContractContent", "CreateDate", "DiscountRate", "EndDate", "RequestReSignContract", "SignedDate", "SigningStatus", "StartDate", "Status", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("05d17e15-69b5-4348-8841-30aef1c04cee"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7269), 0.01m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7268), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7268), null, null, new Guid("10000000-0000-0000-0000-000000000003"), null },
                    { new Guid("10445a29-1aef-4b99-833e-f282f9f716ea"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7223), 0.02m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7222), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7221), null, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), null, null },
                    { new Guid("13c45669-1d1a-44bc-add3-206c49c06aa9"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7263), 0.01m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7262), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7262), null, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("14541887-305f-46c4-8b4c-5f37de53a05a"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7334), 0.01m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7332), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7332), null, null, new Guid("10000000-0000-0000-0000-000000000015"), null },
                    { new Guid("1ec095c4-dc78-4951-810d-68cd59aa120f"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7327), 0.05m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7294), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7294), null, null, new Guid("10000000-0000-0000-0000-000000000014"), null },
                    { new Guid("220585c3-1c2d-4496-b4cb-6ab43e71b624"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7275), 0.04m, new DateTime(2027, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7274), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7274), null, null, new Guid("10000000-0000-0000-0000-000000000006"), null },
                    { new Guid("27d25176-2649-41ed-8ede-ee12097ba0ee"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7266), 0.03m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7265), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7265), null, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("2c0d6c52-c3e7-4f97-805e-19cd156f0b1c"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7238), 0.05m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7237), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7236), null, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), null, null },
                    { new Guid("3da19553-3d81-47f0-96df-193874ac483f"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7228), 0.04m, new DateTime(2027, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7227), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7227), null, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), null, null },
                    { new Guid("4bd1e45c-4cf1-4161-8b81-982cf6159a4b"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7290), 0.04m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7290), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7289), null, null, new Guid("10000000-0000-0000-0000-000000000012"), null },
                    { new Guid("59789175-9ec5-4110-9329-fd7502b5b89e"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7249), 0.01m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7248), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7248), null, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), null, null },
                    { new Guid("6dd50532-238f-45ef-a3f6-17aaca9512f7"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7215), 0.01m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7214), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7214), null, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), null, null },
                    { new Guid("75caebaf-0c4a-4862-a02a-7fc9746477e3"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7244), 0.02m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7243), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7243), null, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), null, null },
                    { new Guid("7f2298c8-c486-4be4-9bcf-d6b775293ab8"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7235), 0.02m, new DateTime(2028, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7234), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7233), null, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), null, null },
                    { new Guid("7f4bba83-f1e1-4cc1-b62c-f98c9b53538d"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7242), 0.05m, new DateTime(2028, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7241), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7241), null, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), null, null },
                    { new Guid("8970382e-6be4-4e3d-87fc-ddfaae1f5d38"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7258), 0.01m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7256), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7255), null, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8e620ac2-d324-4fdd-86e3-ca762845fec2"), "Hợp đồng đại lý du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7273), 0.01m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7272), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7272), null, null, new Guid("10000000-0000-0000-0000-000000000005"), null },
                    { new Guid("9406f89a-622a-42ec-98ca-61440391459e"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7288), 0.02m, new DateTime(2026, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7287), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7287), null, null, new Guid("10000000-0000-0000-0000-000000000011"), null },
                    { new Guid("989343ad-becf-472c-bfb4-2df818592f56"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7277), 0.02m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7276), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7276), null, null, new Guid("10000000-0000-0000-0000-000000000007"), null },
                    { new Guid("a3baa754-7886-46e6-ab5a-ba1650a13479"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7218), 0.03m, new DateTime(2028, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7217), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7217), null, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), null, null },
                    { new Guid("a590e1bf-9fcf-428b-8308-92c91bb1b351"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7286), 0.04m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7285), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7285), null, null, new Guid("10000000-0000-0000-0000-000000000010"), null },
                    { new Guid("cab7023a-95a9-404a-921a-b41ff0ba338e"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7284), 0.03m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7283), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7282), null, null, new Guid("10000000-0000-0000-0000-000000000009"), null },
                    { new Guid("cc9d42ef-4e3c-413c-a21b-7df737bf4471"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7240), 0.05m, new DateTime(2027, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7239), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7239), null, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), null, null },
                    { new Guid("da65c1d8-af81-4651-aa03-9c2b951bb740"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7220), 0.02m, new DateTime(2028, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7219), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7219), null, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), null, null },
                    { new Guid("e6c77e79-216d-41bf-9ca6-2fcb9eceee30"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7226), 0.02m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7225), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7225), null, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), null, null },
                    { new Guid("e726f656-b25c-4266-9948-b767d08ec967"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7293), 0.03m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7292), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7291), null, null, new Guid("10000000-0000-0000-0000-000000000013"), null },
                    { new Guid("e90e291f-dfa6-4dc5-8919-db6d5c332088"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7232), 0.04m, new DateTime(2027, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7231), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7231), null, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), null, null },
                    { new Guid("f391ba82-9bac-4b6c-a51a-1ecad390e7f1"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7204), 0.02m, new DateTime(2029, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7162), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7160), null, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, null },
                    { new Guid("f81ffee8-6c5d-4a1b-8777-1be64ebab984"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7247), 0.04m, new DateTime(2028, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7246), null, null, 1, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7245), null, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), null, null },
                    { new Guid("fabeb175-9119-4f45-8fbf-4f19df46716e"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7271), 0.05m, new DateTime(2030, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7270), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7270), null, null, new Guid("10000000-0000-0000-0000-000000000004"), null },
                    { new Guid("ff418ab2-97f5-4495-824c-d51ae82b8bf8"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7281), 0.02m, new DateTime(2027, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7280), null, null, 0, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(7280), null, null, new Guid("10000000-0000-0000-0000-000000000008"), null }
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
                    { new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), "Không đường, không chất bảo quản, giữ lạnh ở 4°C.", "Dairy Farm, Mộc Châu", "Từ 1 tuổi trở lên", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7326), "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F4.jpg?alt=media\\u0026token=cc2b259e-55e1-4ee8-bd6e-7f619a3ca9b9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F5.jpg?alt=media\\u0026token=b4c42af8-a554-496f-933f-ee72eaa99ad7\"]", "100% sữa bò tươi", "Trang trại bò sữa Mộc Châu", "Canxi, Vitamin D, Protein", "Mộc Châu, Sơn La", 45000.0, 6, "Sữa tươi thanh trùng Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "1L" },
                    { new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7275), "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media\\u0026token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media\\u0026token=bad36b93-8f59-4463-8622-b0a7ea89821e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media\\u0026token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media\\u0026token=7c347385-45bd-474f-9930-77dca305655c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media\\u0026token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media\\u0026token=d3542914-5791-4d36-95a6-071e554aa407\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media\\u0026token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 0, "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7310), "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media\\u0026token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media\\u0026token=13fdd758-187b-44b8-9b9f-e9fb47148524\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media\\u0026token=be498a71-dc12-42a0-bebd-844b732aa1c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media\\u0026token=41f13948-a8de-49ff-88d4-a37b46dd87b8\"]", "Tía tô, cỏ ngọt", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "150g" },
                    { new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7316), "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media\\u0026token=b855f4ab-4b51-43ea-af26-e0deb629f97c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media\\u0026token=15012cad-7f6f-4cae-842c-c1e8e35d0c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media\\u0026token=0576465d-964e-4ffc-93fa-54f410c761e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media\\u0026token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media\\u0026token=521f7498-9a95-424e-884b-72b611b6f0ee\"]", "Trầm hương, Bột Trầm Hương", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 6, "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 0, null, "1kg" },
                    { new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Trà túi lọc & lá trà", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7299), "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media\\u0026token=5218426e-19ff-4feb-b968-93e08e7f6c92\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media\\u0026token=65af2dec-b460-4f5c-8c4b-8c76b6581a83\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media\\u0026token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media\\u0026token=94412ff3-d1eb-427a-8114-3290d62edd31\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media\\u0026token=1cade255-31ff-4248-ac2f-0f2f8513b33c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media\\u0026token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media\\u0026token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media\\u0026token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53\"]", "Trà xanh, Khác", "Xưởng Mộc Việt", "Truyền thống", "Việt Nam", 80000.0, 1, "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null, null, "10 bông" },
                    { new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7286), "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media\\u0026token=1b2c7198-56da-46dc-bef8-c1371e4bbd16\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media\\u0026token=feac05a6-f278-4bae-85ab-4a9453decd2a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media\\u0026token=153f06d6-d1ee-4781-a17a-b43c0028fbea\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media\\u0026token=0cf39ab3-b794-4d99-90a6-4d4026b690d8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media\\u0026token=0f2875bb-7146-4a3d-8774-d449d78a925a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media\\u0026token=4ef86b59-4468-4e52-af69-5084c99281c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media\\u0026token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media\\u0026token=1c52bcc3-1800-4c86-a874-842c62dca2af\"]", "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU", "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 0, "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "750g" },
                    { new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7305), "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media\\u0026token=5e7d93e8-e10e-47e1-be82-573a9436bdca\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media\\u0026token=7b8fd32b-486b-4fec-bb89-ec59959708d0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media\\u0026token=d7b0593b-a8a7-44de-917a-35e3699f5cd1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media\\u0026token=daa304f2-2707-486e-862e-e39f5aff3c25\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media\\u0026token=e9b4469d-a2c9-458a-ba20-e2968a4db706\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media\\u0026token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce\"]", null, "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 1, "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "750ml" },
                    { new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.", "Mộc Châu Xanh, Mộc Châu", "Tất cả mọi người", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7331), "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F6.jpg?alt=media\\u0026token=2579c65f-9b67-42f3-a052-3c1fc19c509f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F7.jpg?alt=media\\u0026token=8532128f-6b27-4059-a04b-e912b62f0556\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F8.jpg?alt=media\\u0026token=d1f4592d-ea8d-42a2-b975-ef99493f8f33\"]", "100% rau cải ngọt hữu cơ", "Trang trại rau hữu cơ Mộc Châu Xanh", "Vitamin A, Vitamin C, Sắt", "Mộc Châu, Sơn La", 25000.0, 6, "Rau cải ngọt hữu cơ Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500g" },
                    { new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", "Người lớn", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7266), "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media\\u0026token=8df7ec0c-528c-4420-b9d8-1aa642cf458b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media\\u0026token=e4a624c3-296d-4553-812e-c17832510225\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media\\u0026token=b6600b96-94ef-473e-ba86-72a4f5568635\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media\\u0026token=2df35c4e-8b69-4210-80f3-58f6dee45ac5\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\"]", "Tinh bột nghệ, Mật ong nguyên chất", "Xưởng Mộc Việt", "Nghệ", "Việt Nam", 80000.0, 2, "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500ml" },
                    { new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.", "Bản Áng, Mộc Châu", "Từ 12 tuổi trở lên", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7336), "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F9.jpg?alt=media\\u0026token=fe337e6e-fe5f-43d7-8a94-622137e2dd3f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F10.jpg?alt=media\\u0026token=2d61b4e2-0451-467a-9ca8-ef26a6cb603f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F11.jpg?alt=media\\u0026token=28e3c536-92a5-4dd8-9dda-c70f3e8b34c0\"]", "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu", "Nhà hàng Truyền thống Bản Áng", "Protein, Vitamin C, Vitamin A", "Mộc Châu, Sơn La", 200000.0, 0, "Món ăn đặc sản Mộc Châu", null, 0, new Guid("10000000-0000-0000-0000-000000000001"), 1, null, "Một suất ăn" },
                    { new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), "Không chất bảo quản, đóng lọ thủy tinh cao cấp.", "Bản Áng, Mộc Châu, Sơn La", "Từ 3 tuổi trở lên", new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7322), "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F1.jpg?alt=media\\u0026token=b474731f-3c05-418e-ac71-9e7bd36f85d2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F2.jpg?alt=media\\u0026token=7b48babb-d847-4333-ad7f-332c2c051698\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F3.jpg?alt=media\\u0026token=1316b40a-1b2d-4160-a798-905976414bdc\"]", "Dâu tây tươi, đường mía, nước cốt chanh", "Hợp tác xã Nông sản Dâu Mộc Châu", "Vitamin C, Chất xơ", "Mộc Châu, Sơn La", 95000.0, 0, "Mứt dâu tây Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "250g" },
                    { new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(7292), "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media\\u0026token=fb9ba94c-fdec-47fb-b782-f145d2b611e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media\\u0026token=4b849fd1-6be9-4fa5-846c-c1865071899d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media\\u0026token=d50897e6-af7d-47bd-bc4b-e8e196dd65af\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media\\u0026token=facf05b2-93fb-4519-b412-b73961492d1f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media\\u0026token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media\\u0026token=47195d9c-a6f1-4416-a67b-cae2ba719f10\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media\\u0026token=5a284068-ab8c-486e-a50a-407e1ed4489d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media\\u0026token=a0c04528-e4db-427c-984d-f1ef780fd838\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourGuide",
                columns: new[] { "GuideId", "Bio", "CreateDate", "ExpertiseArea", "Languages", "Rating", "TourCompanyId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Expert in eco-tourism with 5 years of experience.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5854), "Eco-farming, fruit orchards", "English, French", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Specialist in sustainable agriculture tours.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5859), "Tea plantations, organic farming", "English, Spanish", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5859), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Guided over 200 eco-tours with top reviews.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5864), "Mountain trekking, herbal farming", "English, Vietnamese", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Passionate about agritourism and cultural exchange.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5866), "Coffee plantations, farm stays", "English, German", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "10 years of experience in eco-tourism industry.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5868), "Rice farming, eco-tourism", "English, Chinese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "An expert in organic farming and sustainable tourism.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5871), "Tea plantations, eco-farms", "English, Korean", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5871), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Combining tourism and local culture for unique experiences.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5874), "Cultural farming, organic coffee", "English, Japanese", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bringing sustainable travel to the next level.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5877), "Tropical fruit farms, eco-friendly tours", "English, Thai", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5877), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Guiding farm tours with an educational approach.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5881), "Dairy farming, vineyard tours", "English, Portuguese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Committed to authentic rural tourism experiences.", new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5884), "Olive farming, agritourism", "English, Italian", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5884), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") }
                });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8281), "Tham gia gieo trồng rau hữu cơ, thu hoạch nông sản, học cách chăm sóc trâu bò, và dùng cơm trưa với người dân bản địa.", 1.0, 3, "Một ngày làm nông dân vùng biên", 1200000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8284), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa; tìm hiểu quy trình chế biến thực phẩm sạch tại trang trại.", 6.0, 2, "Trải nghiệm thu hoạch mùa vụ", 950000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8286), "Kết hợp hoạt động nông nghiệp với giao lưu văn hóa dân tộc Tày - Nùng, thưởng thức các món ăn truyền thống và xem múa hát dân gian.", 2.0, 3, "Khám phá nông nghiệp và văn hóa địa phương", 1800000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8288), "Tham gia làm vườn, chăm sóc cây trồng không hóa chất, nghỉ dưỡng tại homestay chuẩn sinh thái ngay chân núi.", 2.0, 3, "Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng", 2500000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8290), "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.", 1.0, 3, "Một ngày làm nông dân H'Mông", 1450000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8293), "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.", 8.0, 2, "Hành trình khám phá bản làng và nông nghiệp hữu cơ", 1650000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8299), "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.", 2.0, 3, "Farmstay Sa Pa 2N1Đ", 2700000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8303), "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.", 1.0, 3, "Chợ phiên & nông nghiệp vùng cao", 1100000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8268), "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.", 6.0, 2, "Khám phá nông nghiệp Mộc Châu", 3500000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8274), "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.", 1.0, 3, "Một ngày làm nông dân OCOP", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8271), "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.", 4.0, 2, "Tour hái chè và thưởng trà OCOP", 2800000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8278), "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.", 2.0, 3, "Du lịch thiện nguyện & nông nghiệp xanh", 4000000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"), "Chăm sóc vườn hoa và cây cảnh", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8473), "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F151.jpg?alt=media\\u0026token=637e2ba5-283d-406b-8604-e7a908ebab2d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F152.jpg?alt=media\\u0026token=e6bd1f38-1a76-4d4d-ada9-25da7f51686f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F153.jpg?alt=media\\u0026token=130839fb-7bbe-4186-bf90-ca1419a80582\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F154.jpg?alt=media\\u0026token=78e68037-8fcd-4fbc-a0d6-7ac9752e33bf\"]", "Vườn hoa du lịch – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"), "Tham quan đồi chè Mộc Châu", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8415), "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", "Đồi chè trái tim – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"), "Hoạt động từ thiện tại bản làng", 30.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8465), "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", "Bản làng vùng cao Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), "Tham quan nông trại dâu tây", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8381), "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F14.jpg?alt=media\\u0026token=19367ec0-3dd2-4349-abcf-fc17911ca4ec\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F15.jpg?alt=media\\u0026token=eebc5140-5778-4ab7-b128-7ec04c37f2b4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F16.jpg?alt=media\\u0026token=7d281318-7494-4c09-b7bb-8bf61c965fc0\"]", "Nông trại Dâu Mộc Châu – Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"), "Chế biến thực phẩm từ nông sản địa phương", 20.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8477), "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F161.jpg?alt=media\\u0026token=2d7d29c8-3636-405f-9567-2a4aaae97c30\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F162.jpg?alt=media\\u0026token=9ad86d97-f35d-468b-8937-d1c4d461b0c3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F163.jpg?alt=media\\u0026token=435f2187-da87-4cae-8b17-5f103f7b1f11\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F164.jpg?alt=media\\u0026token=1008643c-57d9-4b73-adee-a61dfa3a3a85\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F165.jpg?alt=media\\u0026token=be1854b6-921a-4b31-92b4-a8eb074729d0\"]", "Xưởng chế biến thực phẩm – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"), "Chăm sóc vườn rau hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8447), "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", "Vườn rau hữu cơ – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"), "Tham gia chế biến chè thủ công", 5.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8432), "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F71.jpg?alt=media\\u0026token=8c694cc7-240c-4eac-a670-a458de5a8964\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F72.jpg?alt=media\\u0026token=9d082c03-94b1-4bc2-941d-3d80077481cf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F73.jpg?alt=media\\u0026token=955ef861-00bc-479f-ae3f-083a78f72624\"]", "Xưởng chè OCOP Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"), "Trồng cây xanh tại khu vực du lịch", 20.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8469), "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F141.jpg?alt=media\\u0026token=17bafc4a-ca33-416e-8b02-4d5ed8708569\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F142.jpg?alt=media\\u0026token=59c221c3-f2a5-4065-9282-37bf5874be3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F143.jpg?alt=media\\u0026token=6ad7d043-ae31-4bb0-a41c-d5f0f9b70e87\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F144.jpg?alt=media\\u0026token=4f03a1ff-ae27-476f-9a83-c69225dd0c3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F145.jpg?alt=media\\u0026token=0c56159a-0c55-49cc-afe2-86c8de27db2f\"]", "Khu du lịch Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), "Vắt sữa bò tại trang trại", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8401), "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F21.jpg?alt=media\\u0026token=5a725c29-f7ed-4f52-89e0-94e0f768b8e3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F22.jpg?alt=media\\u0026token=244dc720-f725-42ed-bbf1-a28f3a59178d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F23.jpg?alt=media\\u0026token=1a44b12f-8bc0-48d6-b1bb-15a2cb7d3b61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F24.jpg?alt=media\\u0026token=ccea313e-1a38-438c-b47f-2603da9a003f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F25.jpg?alt=media\\u0026token=7667d7c8-ec34-444a-bfd6-254fa545febb\"]", "Trang trại bò sữa Dairy Farm", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000001"), "Gieo trồng rau hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8481), "Hướng dẫn kỹ thuật gieo hạt, làm đất và chăm sóc rau theo phương pháp hữu cơ tại nông trại vùng cao.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]", "Nông trại hữu cơ – xã biên giới", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000002"), "Thu hoạch nông sản", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8485), "Trải nghiệm thu hoạch rau củ quả đúng vụ, phân loại và sơ chế tại chỗ theo hướng dẫn của người dân bản địa.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F191.jpg?alt=media\\u0026token=1ae42618-5c61-40f9-af64-b673a2e8b6cc\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F192.jpg?alt=media\\u0026token=ec22f901-1f9b-4d62-8a9b-2efdb9c7a95a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F193.jpg?alt=media\\u0026token=ad98ddae-0d85-474d-a14e-a46cac5292da\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F194.jpg?alt=media\\u0026token=b33f2e48-75dd-4935-896a-e2bed0e81b8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F195.jpg?alt=media\\u0026token=68e9d11f-5627-4847-bee1-06d127911ba1\"]", "Ruộng nông sản – xã biên giới", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000003"), "Chăm sóc trâu bò", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8489), "Học cách tắm rửa, cho ăn và dắt trâu ra đồng cùng người dân – trải nghiệm đời sống chăn nuôi thực tế.", 0.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F201.jpg?alt=media\\u0026token=c8aa9368-60b3-4754-8e68-183ec49665a3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F202.jpg?alt=media\\u0026token=bdfa0975-acef-4887-b0bc-43140a5cb23b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F203.jpg?alt=media\\u0026token=7c780014-a798-4891-ad34-a76992d7b532\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F204.jpg?alt=media\\u0026token=aceb4ca4-7664-4fe6-a325-aa77566c78ec\"]", "Chuồng trại địa phương", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000004"), "Dùng cơm trưa với người dân bản địa", 0.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8494), "Thưởng thức bữa cơm dân dã tại nhà người dân với các món đặc sản vùng cao: măng xào, cá suối nướng, cơm lam...", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F211.jpg?alt=media\\u0026token=073d2ffd-c38c-42be-adcd-eeede14e7599\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F212.jpg?alt=media\\u0026token=823c928e-ca0d-4325-a4b7-b468d4186329\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F213.jpg?alt=media\\u0026token=61107119-364a-4a1e-acef-eb88ca4d893b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F214.jpg?alt=media\\u0026token=9df5e91b-7227-4286-8829-349125c4d5c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F215.jpg?alt=media\\u0026token=a8fcab98-514f-43d2-b773-d98fee53fcd3\"]", "Nhà sàn truyền thống", new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000001"), "Thu hoạch mùa vụ", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8498), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa cùng với nông dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]", "Cánh đồng hợp tác xã biên giới", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000002"), "Sơ chế và bảo quản thực phẩm", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8502), "Học cách phân loại, sơ chế và bảo quản thực phẩm thu hoạch được bằng phương pháp thủ công và tự nhiên.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F231.jpg?alt=media\\u0026token=f97e225d-3650-420f-90a5-2de9e9e95cef\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F232.jpg?alt=media\\u0026token=ebbc29cf-f3db-4482-a703-40d22ef83721\"]", "Nhà sơ chế tại trang trại", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000003"), "Thưởng thức sản phẩm sạch tại chỗ", 5.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8508), "Dùng thử các món ăn chế biến từ chính nông sản vừa thu hoạch như ngô luộc, khoai nướng, rau luộc chấm muối vừng.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F241.jpg?alt=media\\u0026token=4463106d-794f-4fdf-a7d5-0d8480924e8c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F242.jpg?alt=media\\u0026token=0007ab7b-3e71-433b-b91e-2ebeba70c162\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F243.jpg?alt=media\\u0026token=b0b690e9-bdf5-439c-8ef4-28c268db4620\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F244.jpg?alt=media\\u0026token=3604d3cf-9fc5-473d-af7b-c5589c0a97ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F245.jpg?alt=media\\u0026token=9eaef8dc-1185-42d7-9cfd-2224b1ccec20\"]", "Khu vực ăn uống ngoài trời", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000004"), "Giao lưu văn nghệ và chia sẻ", 0.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8511), "Giao lưu với người dân bản địa, nghe chia sẻ về đời sống sản xuất nông nghiệp và văn hóa vùng cao.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F251.jpg?alt=media\\u0026token=81823c6d-9776-43f3-9ebf-de22ca576eaa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F252.jpg?alt=media\\u0026token=36bcc531-71a4-459d-965a-6622849ab584\"]", "Sân cộng đồng xã", new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000001"), "Trồng rau trên ruộng bậc thang", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8554), "Trải nghiệm làm nông cùng người H'Mông: cuốc đất, gieo hạt và chăm sóc rau trên ruộng bậc thang.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]", "Ruộng bậc thang bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000002"), "Hái và phân loại thuốc nam", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8559), "Cùng người bản địa đi hái các loại cây thuốc nam đặc trưng vùng cao, học cách phân loại và sử dụng.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F351.jpg?alt=media\\u0026token=7f979d6c-7fd1-41fa-95dc-5b916eaaccb6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F352.jpg?alt=media\\u0026token=563f16cd-657a-47ae-bb8a-98a9e73c5e21\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F353.jpg?alt=media\\u0026token=f5b16d9a-5509-43cb-8390-a71fdb4ceded\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F354.jpg?alt=media\\u0026token=9b1add6f-51e5-4224-af5c-e50497f29c33\"]", "Khu rừng ven bản", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000003"), "Nấu ăn cùng người H'Mông", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8563), "Tham gia chuẩn bị bữa trưa với các món ăn truyền thống của người H'Mông, sử dụng nguyên liệu địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F361.jpg?alt=media\\u0026token=7bcb88d3-ed48-4d65-87ea-8e765f95eacd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F362.jpg?alt=media\\u0026token=3ddd92d0-24eb-4731-8916-fc6ce6cf3fd1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F363.jpg?alt=media\\u0026token=4fc8b20d-7bb7-4e4c-97f5-2f84c10bdeb9\"]", "Nhà truyền thống H'Mông, bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000004"), "Đi bộ khám phá bản Cát Cát", 20.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8568), "Hành trình đi bộ qua các con đường lát đá, tìm hiểu kiến trúc nhà truyền thống và đời sống người H'Mông.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]", "Bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000005"), "Tham quan mô hình nông nghiệp hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8571), "Tìm hiểu quy trình trồng rau sạch, dược liệu không hóa chất và chăm sóc vườn theo tiêu chuẩn hữu cơ.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F381.jpg?alt=media\\u0026token=424e6c80-6192-44f3-9493-4e9e11e83d94\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F382.jpg?alt=media\\u0026token=8f8c59b9-c916-4120-b569-5219537de2aa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F383.jpg?alt=media\\u0026token=d0758696-6d53-48de-b51d-51e2988571c8\"]", "Vườn hữu cơ bản Cát Cát", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000006"), "Trải nghiệm làm giấy thủ công", 20.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8577), "Tự tay chế tác giấy dó từ nguyên liệu tự nhiên, học cách in họa tiết dân tộc truyền thống.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F391.jpg?alt=media\\u0026token=3c9ee67a-b22c-4203-b072-5858308ebd84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F393.jpg?alt=media\\u0026token=a5be846e-f195-44fd-9d0e-02a5382cb5a9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F392.jpg?alt=media\\u0026token=27c17e64-db04-4907-bfd5-0d6e6b1c233e\"]", "Xưởng giấy thủ công trong bản", new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000007"), "Nghỉ dưỡng tại homestay Mường Hoa", 30.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8582), "Thư giãn tại homestay trong thung lũng Mường Hoa với view ruộng bậc thang, tận hưởng không khí trong lành và yên tĩnh.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F401.jpg?alt=media\\u0026token=d9d59523-c02a-4195-8e28-56e0b2e4eee7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F402.jpg?alt=media\\u0026token=a48192a3-6c9e-4ecd-9eab-af6a15f5227b\"]", "Homestay Mường Hoa", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000008"), "Trải nghiệm thu hoạch và nấu ăn", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8585), "Tham gia thu hoạch rau củ tại vườn và cùng người bản địa nấu các món ăn truyền thống như thắng cố, lợn cắp nách, cá suối nướng.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F411.jpg?alt=media\\u0026token=1a9c47f9-1b2d-4b92-91f3-28b285573140\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F412.jpg?alt=media\\u0026token=f4987f55-a4f6-42e7-a1dc-7958db0b8559\"]", "Vườn rau & gian bếp homestay", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000009"), "Giao lưu văn nghệ bản địa", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8590), "Thưởng thức các tiết mục múa hát dân tộc, tham gia múa sạp, múa chuông và uống rượu ngô cùng người dân địa phương.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F421.jpg?alt=media\\u0026token=6d6aee32-1e25-4324-99ad-4f707c3d63d5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F422.jpg?alt=media\\u0026token=a81c9c91-10ec-4bf5-b6ad-d0f78222f6e6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F423.jpg?alt=media\\u0026token=cc1d5656-20e0-44c0-ad9f-c35602eceaf3\"]", "Sân sinh hoạt cộng đồng tại bản", new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000010"), "Tham quan chợ phiên Sa Pa", 30.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8597), "Khám phá chợ phiên truyền thống với các gian hàng thổ cẩm, dược liệu, đặc sản vùng cao và giao lưu với người dân bản địa.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F431.jpg?alt=media\\u0026token=fedde1c2-82af-4101-96af-ac35b1247c05\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F432.jpg?alt=media\\u0026token=6b2b702f-d2f3-495e-bce4-b03768564e70\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F433.jpg?alt=media\\u0026token=76f636b3-f04a-4c67-a81c-e83203cf98b2\"]", "Chợ trung tâm Sa Pa", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000011"), "Trải nghiệm gieo trồng và thu hoạch", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8602), "Tham gia gieo hạt, chăm sóc rau theo phương pháp truyền thống của người dân tộc thiểu số và tự tay thu hoạch nông sản.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F441.jpg?alt=media\\u0026token=37827a0f-e7c0-4b0a-9c91-dcc11d611846\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F442.jpg?alt=media\\u0026token=0168cdd6-bbd6-4d1a-9b7a-11fa787bc27a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F443.jpg?alt=media\\u0026token=a7283cee-39ee-491b-810e-ee0683483411\"]", "Vườn rau bản Tả Phìn", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000012"), "Học nấu món ăn đặc sản vùng cao", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8607), "Hướng dẫn chế biến các món ăn đặc trưng của người H’Mông như thắng cố, cải mèo luộc chấm chẩm chéo và thịt trâu gác bếp.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F451.jpg?alt=media\\u0026token=2528b14d-5b04-46df-9276-1d8b759f8f00\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F452.jpg?alt=media\\u0026token=6461419d-900a-4753-aacf-ab7a487ce6a7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F453.jpg?alt=media\\u0026token=cc68f5d2-853d-4efe-a640-301d5f9ef61e\"]", "Bếp cộng đồng trong bản", new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000001"), "Trải nghiệm trồng trọt địa phương", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8517), "Tham gia các công việc nông nghiệp truyền thống như trồng rau, làm đất, tưới tiêu cùng người dân.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]", "Cánh đồng bản Tày", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000002"), "Thưởng thức món ăn truyền thống", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8521), "Dùng bữa với các món ăn dân tộc như khẩu sli, thắng cố, lạp xưởng, và rượu ngô bản địa.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F271.jpg?alt=media\\u0026token=241821db-3226-4e34-a77e-e836f927b832\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F272.jpg?alt=media\\u0026token=3fd95b94-c080-48a1-a33c-26b124c01729\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F273.jpg?alt=media\\u0026token=9a6da2b9-6b90-4fb0-898e-d53d619661c4\"]", "Nhà sàn truyền thống", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000003"), "Giao lưu văn hóa dân gian", 5.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8524), "Tham gia đêm giao lưu văn nghệ với các tiết mục múa khèn, hát then, hát lượn đặc trưng dân tộc Tày - Nùng.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F281.jpg?alt=media\\u0026token=f04d5b05-7aaf-416d-97e6-2c822003f677\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F282.jpg?alt=media\\u0026token=305ac0e3-fd04-4970-a70d-47121c1bb920\"]", "Sân nhà văn hóa bản", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000004"), "Thăm quan làng nghề truyền thống", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8530), "Khám phá làng nghề làm hương, dệt thổ cẩm và thủ công mỹ nghệ bản địa.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F291.jpg?alt=media\\u0026token=359dcbca-21d9-4154-a7d0-5551d716bda1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F292.jpg?alt=media\\u0026token=8ed946de-f900-42a4-8680-1f3d874c5664\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F293.jpg?alt=media\\u0026token=cd51d4ba-d099-40ef-8f04-45c50b510f4d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F294.jpg?alt=media\\u0026token=57db7ac9-c488-4f98-afef-4cd8fa0099be\"]", "Làng nghề Tày - Nùng", new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000001"), "Hướng dẫn canh tác hữu cơ", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8534), "Tham gia buổi giới thiệu quy trình trồng rau, hoa quả theo hướng hữu cơ không sử dụng thuốc trừ sâu hóa học.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]", "Trang trại sinh thái hữu cơ", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000002"), "Trải nghiệm làm vườn hữu cơ", 15.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8539), "Tự tay gieo hạt, chăm sóc rau và thu hoạch sản phẩm sạch theo hướng dẫn của người dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F311.jpg?alt=media\\u0026token=c5d2e774-2892-4050-8e03-6da8b54ad1b5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F312.jpg?alt=media\\u0026token=2f38325a-17d8-463c-8cf7-6ac1a59d0df2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F314.jpg?alt=media\\u0026token=5b8079cb-fc25-46d1-90d8-919b1d17d017\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F315.jpg?alt=media\\u0026token=cad2491a-a26d-4c9d-a047-dec724e86aed\"]", "Vườn rau hữu cơ", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000003"), "Nghỉ dưỡng tại homestay sinh thái", 30.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8543), "Thư giãn tại homestay thân thiện với môi trường, sử dụng năng lượng tái tạo, có view rừng và núi.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F321.jpg?alt=media\\u0026token=cb1d9b94-1df8-43ff-9c40-2cb2db8e48c8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F322.jpg?alt=media\\u0026token=9ec5a1d9-fe89-43a2-98f4-adf67c778461\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F323.jpg?alt=media\\u0026token=189aea12-33a9-4033-92c9-3aea8de5c297\"]", "Homestay chân núi Pù Luông", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000004"), "Chế biến món ăn từ nông sản hữu cơ", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8546), "Học nấu các món ăn truyền thống từ nguyên liệu hữu cơ tự tay thu hoạch.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F331.jpg?alt=media\\u0026token=aeac9ff7-f16d-4843-9f8e-547cd5888511\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F332.jpg?alt=media\\u0026token=c6d546a9-22f0-47d0-b7f2-7b865d475026\"]", "Khu bếp homestay", new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), "Tham quan và thu hoạch rau hữu cơ", 5.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8405), "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F31.jpg?alt=media\\u0026token=c76c7f97-077d-4e11-b851-4d14a5348e39\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F32.jpg?alt=media\\u0026token=1d3da6b4-2733-4281-bee0-e9a005d9e3bd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F33.jpg?alt=media\\u0026token=510e194a-cf09-476d-891e-d30976dbcf74\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F34.jpg?alt=media\\u0026token=cd2d6297-a97d-4119-b924-66f84e686091\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F35.jpg?alt=media\\u0026token=5dab756d-23a9-4df1-97a2-ff3b2afedad5\"]", "Trang trại rau hữu cơ Mộc Châu Xanh", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"), "Trải nghiệm hái chè", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8427), "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F61.jpg?alt=media\\u0026token=63b5b728-ea1f-4511-a780-d3c095a200bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F62.jpg?alt=media\\u0026token=c7184c0e-1262-4c7c-8124-d830c6077824\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F63.jpg?alt=media\\u0026token=70feba58-f759-40fa-a09a-afc6013a2a4c\"]", "Đồi chè Thanh Bình – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"), "Thưởng thức trà OCOP", 0.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8441), "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F81.jpg?alt=media\\u0026token=6afd1b86-7467-4378-872e-35653af5b8b1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F82.jpg?alt=media\\u0026token=70835076-bb28-4f0a-840d-8a417e6aed17\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F83.jpg?alt=media\\u0026token=68a06a61-f77e-44a6-80e7-5da69e44d21a\"]", "Không gian trà đạo Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"), "Tìm hiểu quy trình đóng gói sản phẩm OCOP", 5.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8460), "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F121.jpg?alt=media\\u0026token=9018f821-dd46-4bc6-aa56-0389aea2bf61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F122.jpg?alt=media\\u0026token=ad974591-aff7-48af-80e6-a6e7e975941c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F123.jpg?alt=media\\u0026token=7e9514a5-c205-468d-913e-49da8aa8b473\"]", "Xưởng sản xuất nông sản OCOP Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"), "Thu hoạch và chế biến nấm", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8456), "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F111.jpg?alt=media\\u0026token=720b5141-852a-42f7-9501-cd21845aea83\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F112.jpg?alt=media\\u0026token=071f3771-b293-4679-a2b8-9705b064e2ee\"]", "Trang trại nấm – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"), "Thu hoạch cà chua", 10.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8452), "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F102.jpg?alt=media\\u0026token=05c8e1fe-9719-4a40-ac8b-29240968deca\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F105.jpg?alt=media\\u0026token=6a6f785c-b2ff-4d18-a281-6b4fbdb24858\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F101.jpg?alt=media\\u0026token=543a6d27-d8c1-405e-8cc5-d514df96a517\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F103.jpg?alt=media\\u0026token=61052fcb-66f1-4b78-801c-7753c921eedd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F104.jpg?alt=media\\u0026token=d6fa2240-475b-4342-b38f-4ab3ff860c6c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F106.jpg?alt=media\\u0026token=04b992aa-add3-494d-afb6-163f295101dd\"]", "Vườn cà chua – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), "Dùng bữa trưa đặc sản Mộc Châu", 0.0, 1, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(8411), "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F41.jpg?alt=media\\u0026token=e217a4d7-e7f4-4b2a-98dd-0a7dd4dc2984\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F42.jpg?alt=media\\u0026token=149048cb-720f-478f-bcd1-422756adf1ac\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F43.jpg?alt=media\\u0026token=828ef767-521b-43a8-92c3-6611901f65e2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F44.jpg?alt=media\\u0026token=f69dd952-5c11-4080-ba90-2dbc7be04fe0\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F45.jpg?alt=media\\u0026token=815c61a0-c821-4208-ad95-0915e193fd9f\"]", "Nhà hàng Truyền thống Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("44ef4a7f-926f-49dc-a7b7-03bbdc0758e3"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8063), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8063), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("454ea4c5-4677-4cae-b035-7ed77eba7ed0"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8027), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8026), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8025), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("4ef8708a-6029-4ede-bae2-799132794e8e"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8052), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8051), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7e209ad2-30aa-46bd-94a7-fb36d1e76af0"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8077), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8077), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8076), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8effb4f9-4ac9-4f04-89b1-2185b77648ad"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8073), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8072), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8072), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("927bbd01-c2eb-4b66-b576-c83fd00cff97"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8047), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8046), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b23125f3-496f-47c1-be1f-3388da6ed78d"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8057), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8056), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8056), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("bfa099cc-7d65-4725-a626-9e08ffc5aa3a"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8068), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 25, 23, 25, 57, 860, DateTimeKind.Local).AddTicks(8067), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("008ea4b0-6ccf-41f6-9f4e-75b472a09c6d"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7897), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("0594039f-c407-4f4a-9de8-60a7443bff78"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7590), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("0d715287-51e2-48c2-8a36-6f5e0431d894"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7865), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("0dab0789-901e-47a1-b22a-f541110132dd"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7596), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("11bef573-1707-4fdb-aeca-b5a58c012480"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7633), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("11d68960-539a-4514-9f66-46b4c2ffe901"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7838), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1732d360-5b5e-4c82-9410-3f5ba6df16af"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7645), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("187015fc-4704-4cb0-bb47-403c9e8531a3"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7602), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("1fc182c0-f631-4b50-8df1-872f90d8e2e9"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7851), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("20d83382-cc1c-454b-b3ab-7d7fa7ce015b"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7715), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("2d4adb1c-2e44-440a-a191-108c7e15f57f"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7578), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("2dfb9594-c66c-4f40-be9f-5dfd07b48112"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7727), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("2fe177bc-78c6-4007-a9c1-d7ffcbbdc293"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7690), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4409d6e4-7c49-486a-8345-1d5caf9cbb47"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7826), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("447e6497-51d4-4f6b-be63-6047b5277195"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7939), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("660215bd-9332-493d-b71b-85899f24300f"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7844), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("7cd385a8-588c-4fed-9b84-995491d804f0"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7832), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("7f7073f2-3bf7-461f-9c26-f69fc94f983d"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7922), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("8418d171-739c-42d9-a134-ecb26d2fb239"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7820), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("97106401-ac44-4432-8e2d-b922ac7d536b"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7930), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("993af983-1286-4393-8f0a-53c84b38ff83"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7804), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("9ed04152-b832-4168-bc7c-efa0f06370f7"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7626), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("a54fbb3e-9b8f-4243-b22d-9b057647fbed"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7721), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a6300c06-f069-471f-bacb-a78068732f60"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7891), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("acefc6b1-1d07-4291-b646-7af44a9595ff"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("bc4c44fd-cf85-457b-834c-8b353d92f8ab"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7903), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("c351523b-e56f-4d02-b346-1daecaf850b3"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7885), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("c5085e20-aa88-44bb-b829-6980aa6e4b8b"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7682), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("ca301b8b-fe00-4926-884b-7ad6c57114c9"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("d465c091-bcdf-47ba-9a70-026586e8e9ab"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7873), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("dd9b61d0-9f02-469e-b583-69eb5ecc1f1a"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7914), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("e16b0863-e1e0-4560-bcc8-3d916328ac6b"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7946), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("e2fa6e04-bdc4-4eda-a5fe-6190f88644ea"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7709), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("f701197c-20f5-4ff2-acd5-b1941967bb4b"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7954), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("f73afa41-e670-4d41-abea-e79335c7a419"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7812), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("fc67e314-de05-4f72-9c63-512852be17fd"), null, new DateTime(2025, 4, 25, 16, 25, 57, 860, DateTimeKind.Utc).AddTicks(7879), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("64000000-0000-0000-0000-000000000002"), null, null, null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5952), "Tham quan và trải nghiệm tại trang trại bò sữa Dairy Farm", null, new DateTime(2025, 5, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, "Trải nghiệm tại trang trại bò sữa", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 3 },
                    { new Guid("64000000-0000-0000-0000-000000000003"), null, null, null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5956), "Tham quan và trải nghiệm tại trang trại rau hữu cơ Mộc Châu Xanh", null, new DateTime(2025, 5, 10, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khám phá vườn rau hữu cơ", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 4 },
                    { new Guid("64000000-0000-0000-0000-000000000004"), null, null, null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5936), "Xe 45 chỗ đón khách tại điểm hẹn và di chuyển đến Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 6, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển đến Mộc Châu", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 1 },
                    { new Guid("64000000-0000-0000-0000-000000000005"), null, null, null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5990), "Di chuyển giữa các điểm tham quan trong khu vực Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển giữa các điểm tham quan", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 6 },
                    { new Guid("64000000-0000-0000-0000-000000000006"), new Guid("10000000-0000-0000-0000-000000000011"), null, null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5977), "Nghỉ ngơi và dùng bữa trưa tại khách sạn 5 sao TherHouse, trung tâm Mộc Châu", null, new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nghỉ trưa tại khách sạn TherHouse", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null, 5 }
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
                values: new object[] { new Guid("64000000-0000-0000-0000-000000000001"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 25, 16, 25, 57, 864, DateTimeKind.Utc).AddTicks(5946), "Tham quan và trải nghiệm tại nông trại dâu tây Bản Áng", null, new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 15, 0, 0, DateTimeKind.Unspecified), 0, "Tham quan nông trại dâu tây", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), 2, null, 2 });

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
