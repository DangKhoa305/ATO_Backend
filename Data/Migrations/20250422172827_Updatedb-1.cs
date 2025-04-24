using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("20fb3ee5-beca-46b9-8e30-a8cf504fcfb5"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("25790f2a-222f-491d-a96e-a3073c2b4667"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("47ffbf01-78a2-4337-9491-e94a81dc112a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("58ceb7cd-44c0-4065-ba5e-208b0035df00"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5c67d9e8-f737-41eb-8b01-42dd843ff10b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("74926611-11cc-4e9a-af4f-01dc2dddb508"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8fe76eb8-28a6-40db-b901-4e3c26e67d0f"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("afb5e519-0cca-40b6-a22e-489abf892615"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b1648b95-b6ef-4f21-aba3-3c33733b7ddb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("eed690a3-1fea-4b2c-85a6-279d97b9e3a9"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f4499005-6f36-4cb0-b007-2df5ba444d20"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fc55162f-50da-459f-a749-070f59007ca1"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("06346025-69fc-4f3c-9187-72eec757e013"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("29b4c7ca-d29f-4644-ad57-2b4a1230b298"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("5fc94119-40e5-4148-8ae6-1c004d4049ae"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8a89a88a-62b6-4595-b5d1-570b038123cc"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("9872c06b-ed3c-41b1-95ad-094787c2d65a"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("9ce26423-e037-414a-863a-5aa05115cd1a"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a1a9b211-8b81-4ae6-a64d-9eee74e58969"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a6816ea6-f50a-4e08-b70b-285722440e4d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c1ef61ba-82b3-49e4-9dcf-a46f29ce5946"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d8e115ad-488e-4514-aea0-7a5a558429ee"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("009159ab-a31c-470c-85c7-8865b8e7bee7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0f0583f0-dbea-4e3f-b595-3c707359a862"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("12a4bd40-b49d-429e-8f7b-c32c5fb897f3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("13e659d7-8eec-42fd-81c8-378e892edf50"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2260ca02-6f4a-4964-8eb9-3ab88f3946ab"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("268cb74e-3f63-4896-b579-7af608bfa646"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2d4348f3-74e1-45c0-ac48-fa9e0fd9a6a0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("371c8769-2c53-4cb1-b1a2-d2d05f495eb9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3acd569a-59a8-4ced-888f-4cd41dcf5bb4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4930b830-1856-42df-97d8-2fa81cf40771"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4b0078b6-2140-43b2-99d2-11c6d19e12c4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4eaa8581-413a-4261-8a30-af0c6d7aadcc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("52efdf1d-eeff-48e6-b705-b7c72665630e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("56d60969-3b6a-41c9-8017-bf8a55b37393"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("57957ed9-103f-4dca-9e0b-7507d61bd688"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5c94b5e8-fb57-45ab-b0b9-011c08eb57bf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5e96cc45-1956-4b63-80b5-5ab8bc233263"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("65cc90ea-b48b-4e53-a4f2-0de66a416e64"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("728060aa-1c94-43d4-afda-417e78184cd6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7280dea8-cec3-4224-8b50-33b920bdda72"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7ac9445a-97a7-431c-b94f-c890fc812388"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8567e67c-425f-4988-ab41-219a18b9cc5f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8c8558b0-aedf-439e-80a9-52abc75b2e2d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9151a7ef-2d9e-4c1b-a341-643ccfba9b55"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("953f5062-3c7b-4e69-82fe-3abd67fe1f12"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("980e5c5a-d306-49bd-9f50-8606d678cbf2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9c95b1bf-d0e5-4674-a9ff-5ce615a8e99f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a9ea1b3b-3cce-4383-a628-66ab85ecfaaf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b3b2d48c-b5a8-4e14-8afb-8ab90712c96a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c11322f6-57d7-4133-bd62-e73677966278"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c9a87ced-f0ac-4b82-8d07-f8c1694b0a02"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d59a50ac-1f70-48eb-9359-ef565f7a01f2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d8920774-14ec-4a35-bc37-4f783c272497"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f1aeb1d3-f043-4bf0-a4ff-e7958a05ecd3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f3a9cac6-d117-42f3-962b-42ad6afc1ef3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fc1da91d-c79f-48da-afa4-ead54d207c1d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("048cf597-4ebc-4d68-af4d-c50126cf1a19"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("30b51142-e1b4-4c12-80ff-0c31b524c3dc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5620a29e-acc8-4137-9552-aff820f800b4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("61022523-1518-46ab-8428-e49d4dbd8fcf"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("711e0efc-a4c0-4191-9048-b77a5d0db204"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8ea941ee-5786-4c5e-b245-cdfc2c7ba846"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("903b6a11-f9ca-46d2-a4aa-06c618a42d56"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c49be7eb-4d75-4842-8cd3-638b8fc0c8db"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("d0690597-a92b-42d9-a503-621b5f6e898c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ef8203e6-23ee-422b-b26f-9d69ff19f861"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f0c79a18-987d-40db-97ef-32f1a9cfd8e5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ffe670ea-0e95-4942-bfa9-2e121fc4c811"));

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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94980751-a15f-4f49-bb78-9b20c598d11f", "AQAAAAIAAYagAAAAENLPWMNqYdFxwATnsYSgJwARLCUvZBbinlZyMqahZk4jDKGCsHyaXWJ0xuxwL9Rtlg==", "3e21667f-3947-4801-ae17-5b2ebe07b869" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6279930-d251-427d-b6c0-1baa3a55dacc", "AQAAAAIAAYagAAAAEP72FwsRk91xXWMdIRamjITu7PsBTUV9drHQ+ZwVz/XwYkMYlKpE6+bHo6fCaJpjkw==", "0c69a1cb-9529-43f4-aa87-c1a978845d16" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f15ec6-593f-40af-a3c6-8b7217682780", "AQAAAAIAAYagAAAAEDzUsuY3aii7MQ3SPv+brRrY03FS06FrxMf2N0Cwjlzr3FA3npupveTb9145EGSiyw==", "3e3ec83b-d825-40d8-87c6-13fb29ebd3bd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9676ff20-e2c1-4bf0-9a1d-15664c459432", "AQAAAAIAAYagAAAAECynOgO1ed6wszp9nTRsr7Qkkku5woiOmN5T1QbVUqP1iS2VC+QGaIpnN7k8DmRyHQ==", "c7fe57a3-3ca6-47d0-8295-e923bfa45923" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7e84a88-f3f1-4db7-b4f9-17e9672654cd", "AQAAAAIAAYagAAAAEDkTlR2IBgODpWNR/zyF7Lfsw3PvuzYHoEKAp+vQBhPgOzVw7cc5NO9r6tTcjJqgUA==", "c50c3226-a000-4c86-bb33-22db4e55615b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01a0daa-fc77-467c-8231-c126fa511ef1", "AQAAAAIAAYagAAAAELLnGWKBbNPYUYfhXyOPjCbWdVYl8Jdpm/JZAqbt2eb4IDzO9R8C/6URTqJePn6UxA==", "2e0443ee-3417-45d4-9152-adca22ff4bd7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71ddccf0-4866-48c0-9b51-3625a28b97ec", "AQAAAAIAAYagAAAAEKGA4jfg1KfwR1W4IqpzV0OjVGLuEcJEfW4bNBOX6wDn5shuYnRhEooTIUjmkkYnnw==", "06bd7b78-1d3f-49c1-86a0-f504dbe61b15" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9209f953-c77d-4306-9a2d-80f91da3162d", "AQAAAAIAAYagAAAAEEK9eG8EQi8DPdEV6LRubFyrGC9MU66DHIJsKOIPE96FbH3JDIc2DeMKRedkkDCdLA==", "d52e5342-d107-4d0d-a14d-d3cf2879e49e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5572a2e5-f12d-44da-9bf0-628de5ea75e7", "AQAAAAIAAYagAAAAENpMwS4UFmP8aefunJVhILAPtSjn+Owaxbp3lCqrRG/knBEI/0GwesM/TvZ2p1Q10Q==", "bce04ada-34f1-4bfa-b981-a5e88b72694e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9345649-3250-461c-9c88-278beec7c288", "AQAAAAIAAYagAAAAEAcq3cuw/SkgDNzHYs6AiresVkr21/Yt2KDA7TOm3rlkuJmoYfFOKAseF2vO0ggIlg==", "385e088b-a7a9-45bf-9953-e95b0a75fd6c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84ac558-0dd9-4b2c-b992-eac1d2a2d9eb", "AQAAAAIAAYagAAAAEHWz79BOyjJ/tU0+ygu74cv6E66+FInA5tSRwsl9JwlTp/VMmLB5J+RyUVkoKw1r5g==", "e61fa479-cd39-49f0-a030-12ee15b4ea01" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b6a6855-27fe-4e63-b874-584ff4e83d4f", "AQAAAAIAAYagAAAAEJ2xdD8fynhyLCClXfGxQgBtdEjEzUAHaQ8crHLrZ7gHrq95usVQS+z42m7AaglZpA==", "cf5645d7-4a4d-458a-a803-802cd4ae1f9e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae3e99cc-9c70-4cb2-9e96-51afd7e2c9ed", "AQAAAAIAAYagAAAAELkG17tEBRtCTtglfUQreSbVxQVx7kvr17FHwperU2o1mn3skHxksQb6+aOZsJYsUQ==", "93831dfd-1ff1-40fb-b921-706989539c96" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c8ff2f-65cb-4da7-87ea-2d86a11528ea", "AQAAAAIAAYagAAAAEAPCXPFlstXk9UMT5AnbdwUgasaA10GrTnJLG7bOrF9krB47rA0uvSxYorO7HuTDNw==", "e7ac82c0-d9ec-4e6c-9975-027960720677" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b54b942-b206-4a5c-b7e0-21b7f123994d", "AQAAAAIAAYagAAAAELuAr2eUPcEki5/dq3bkOHz1RZUlPf2sJ7Ir8hcCSPd3R5xtW4faGvG4sfjp9oXg6A==", "b1ff71ec-7396-4a18-a314-3f41a730cbd5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adee1954-9386-462f-a6ed-b48f5da9ea54", "AQAAAAIAAYagAAAAEAwTlTV9IaMeEJcOTrxXoZ2ddXyeF+J7kMckAAInWjAE6bhauXsCvhjKcKraonAt1g==", "c2b53ea4-a33a-42e9-83dd-ec51028353bf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e32e18-b46b-4b01-8ca5-e752231fbcaf", "AQAAAAIAAYagAAAAEPoE0VGAKhHBn9+Bl3YPKozJfVS9mx+2z4Rwv6jT8AvqNJ3dZuAHmK62l2230kFJFw==", "8fecb834-a314-4902-8f60-8f8dab496a16" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b8d4ec0-e2b7-46c9-8830-f5c0fcec5f6d", "AQAAAAIAAYagAAAAEDbz82XKbcwd5uTjSpQKZmG+/rhQ8SpMYJNt2jceC/ZB4SsCNxWHIwQ4iQ7CQxIeuQ==", "733860a3-1da0-471b-bd3c-3f8f6c9cb4be" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6e89b78-9632-4ed5-9f6f-83008fa59b24", "AQAAAAIAAYagAAAAEAHBQ4IA3qXIQsTJCz7iTZfrUARiGOB0KAQZJRdbg2NOGGW0WgdAW8IMXqTy14dKug==", "2e96f2ca-6f99-4ac0-a0e2-6f46d533bb31" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6b2b49f-8f39-4c92-a5da-86626c281d69", "AQAAAAIAAYagAAAAEFQlZHHCgWeJo1os54QaYcga9Ws7wuoj/Y8AR9yVMHLXDbEiep8d6c5T/MJs8Vv5jQ==", "f1928d8d-b263-4ba6-bfe6-9a41f98b7cc6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e72db29-6efc-4612-b6dc-5d8dc11d9694", "AQAAAAIAAYagAAAAELDNDx7GSVRAH3gv+1ylBzmZA5+IQX5L1jsOZU7qsu9fqDjPAI6/uTyBI23AwtbaOw==", "1b2b8ddb-8e96-4a84-8295-ccfb8831d40b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "632cb140-b3b3-47e3-8992-4f1a32694e83", "AQAAAAIAAYagAAAAEHu+Jnhq7qSm9JmcdK9lv6sNmomCyMtPO4YC9sK4qu1IVnkyCQxPLBMwkOgd6C1k7Q==", "34a97e85-019e-4640-b1f5-341bcc843a20" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8024f4c2-9d62-4a66-8fe8-ad9ae34bcb30", "AQAAAAIAAYagAAAAEMEEJtEfsG4R4+kzNXmnq2xSisYAR+Dwm1TDejlfcuiGIzLkmfVEntKWSUoUKkQeww==", "79a2a92c-756a-4794-b861-bafad59bfedb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f26efe-c152-4f03-a1da-d2c6fe2b559c", "AQAAAAIAAYagAAAAEDuaLaW4QlNTZtjHTNJ7f6FlS2teWX2uVdkNsf8DW1pRylarLGCw3uJG4ZnA5rEmvg==", "d4cbb753-a59b-4dcc-81d0-79e64f0bcba4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ff09e44-2074-40cd-80c1-dc82502f7735", "AQAAAAIAAYagAAAAEMgQPUO3/fA92rMyZWjxNtHRk6jvAkbwDrVzfeJY8am6sRTKMfkOaNdYddItTnM/oA==", "574b8c11-e66f-441a-9b05-173a1ebd465f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57769975-00dd-48ea-8694-b12ee2c46a2f", "AQAAAAIAAYagAAAAEHjmiJQRQrBqpgJFqYAzezhttvnAh8J5dgMAQNr6xoE41qP1ePGJQKud4hq9Zj7LwQ==", "438bd579-93ff-4947-954e-79f811c19c96" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8773e189-d28a-4a37-a5c4-ea687a3d0dc5", "AQAAAAIAAYagAAAAEGxLcWViZTdEtoo4pISQrWlEcKXbF/qsXurHZUUxhYSWpje9lwyv2VLnQN6jO4vyQA==", "c022ec57-be78-4a51-97bf-0da697bc17e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f3367a7-9e0e-4b6b-8219-af734a30847d", "AQAAAAIAAYagAAAAEPXdIAortOnEPeUzhNKIMMuQNJBL83d9Uk4jvEwm8UyjImyysYx4azTPWxo02wxudQ==", "79411bdc-6148-418d-916e-68ec45815a52" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0cbc767-e79d-4341-9f12-4510fed150eb", "AQAAAAIAAYagAAAAEIvSHyVXEGeS2Q2OYkxXz+aLIWzsua54hKfMi7q8MI6gWr9iVSKDKO4SinWLe5iB3w==", "2329eb42-7918-49e5-a3c2-b76838c2da4a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9484b3a-6d89-4ec3-bbb6-bd7ca552a639", "AQAAAAIAAYagAAAAECNs23VXXex3icrHeIWXUXOSe61YyuUWHYP395RBjdpPG/Y65B2nIa83aPCc8AwMOg==", "ffd4cf96-2506-4a0b-9c49-baf63a61e6d7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e014aab7-c5f7-4f42-a143-084b63d95fd4", "AQAAAAIAAYagAAAAECIpCA08btt1KELbP51CB1lgcvQFLoFrcJ9TfRkNZUWdUBopt0rVtxQ3Dm7HDF4M6w==", "c1e5daf7-2a5f-4f7b-9d3a-ba6afdcb8ac3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b5eb5ac-f451-4d5e-84ae-b63689a5da3a", "AQAAAAIAAYagAAAAEIDwIuHfuNvLOR4Gcc2R4JJMKluWggX54u6RO8Iu8GpT6aLEYjw3ClF5Stq0rxkxwA==", "3233f166-a6ce-47f8-8fca-a243c68d791b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "933e2480-bcc6-443f-bb3b-f1f041db0de5", "AQAAAAIAAYagAAAAEGhohGamDSIzLUsn4OtYvu9Nc7Vr92cYQeNQdcZlNpWRuJvx2efkAbR8Vai3xRuiGQ==", "820507f6-a610-4870-aece-d73646a9fba6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f3b779a-2721-4865-9e27-979d058bcb82", "AQAAAAIAAYagAAAAEAVJgoPWdrSIxva8HgIdesmGUWHijTqDUqW/3dTNrbpzdX8AM9UoIepOj/lBBiUmiw==", "e152a123-a07d-46e1-8ccb-c57b1cd90fcc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43024b2c-1b8d-4bff-9c8c-7887c4ca57f5", "AQAAAAIAAYagAAAAEEHMnxOTdnyRFyeP5sNuVwjy5ocErGDb741U+Hj9ZYPqW+uULdvoWF4peOWj1BHcRA==", "d6df5305-7846-4afc-b367-ce813585c0f7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "652dd70b-dd66-420a-bd22-6c1d116d92b0", "AQAAAAIAAYagAAAAEIDG5IN3gaZyXoOjyUuMnnVfXWxR8F8bm61RLCfT51tMfWxAPXSG9j6AdQYQ0PVZ/w==", "5fcf0558-e3d0-4414-bc02-58732474938a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06dd741b-eaed-486d-8837-3ef26cadd2ab", "AQAAAAIAAYagAAAAEAfz2TxYdgLAveKPaUFi2IkRBde91uM67kP3255jzzM9bRhs71QvVcA71GAVJzafrg==", "e32c8373-20b8-4d84-85e6-fbcc7f643a6d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72911d66-f4fd-4e61-80bd-97145f1981ef", "AQAAAAIAAYagAAAAEFTb32AO8j9VBJTh0wquR9j6XoTFwQcavZ2oAgiR9cBFhx3IHRvxuV9UVvoFk8Gd5Q==", "30849c77-cfdc-4aef-a105-5e2c6e95c711" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0956d9e9-8f6b-4e44-beb3-61aabef6def8", "AQAAAAIAAYagAAAAELQTiITvgU0LZ6cMcf9jecnZlInngf8kMgLl6wkN7tCAol5O4MxQT2VqtK2WPkGZJg==", "bd032c2b-e09f-401e-8771-c95cc8ebaff4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9151637f-71b0-4e9d-9f0e-1e9d8514e4af", "AQAAAAIAAYagAAAAEJ7Cy78wGtAg4tzHK1Aw8lKBj1Xhi6gaW9tHVrI71IaeMZw6IZ/snQt0b54Fy2Suzw==", "042f024b-ea5d-431a-af9c-3ae38e497811" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35a4417-bbca-4fc2-a0a2-0372e7665344", "AQAAAAIAAYagAAAAEAizyZu+YBvvq8+ffiIFI53A4eGsB4BFZMyd9aCahnFcKzbuyHRWuB8SnO7QLB3uIQ==", "68ae8e18-0cdd-49be-b669-ccf8c7179600" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f64b3465-142b-483c-8401-086a9a30bcc8", "AQAAAAIAAYagAAAAEOXGdqutcJehUk+RrtXKDGaseRL0oYgUIGITYW21h5vKCdiGuY8fgBGMi14Fb0Kmyg==", "72c936f7-9713-435c-ab11-04ab161b1387" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc2b5983-e02a-4796-96fe-9cf4a7d28d1c", "AQAAAAIAAYagAAAAEIn/MIEr9IGtKZ4PyOWLZjB7vcOBeFrp1IiIsidNtO+/0pT1aDwLNdP2v3NlrWcoAg==", "98acc92c-cee9-4dbe-9ab4-0231ad9817d9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5006a68-7c3c-4c15-9ca1-39dcb498d3cc", "AQAAAAIAAYagAAAAEDKSsdH8s2APzBZUcLILiE0DNqUu2RcFW6dJM7KeGvPL0bzZBroniaps2my8EyDaPQ==", "acbb0996-c640-4e15-be07-f44bf50bd916" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0603d0fc-b307-40bf-a71e-d00f1318d08c", "AQAAAAIAAYagAAAAEKRs+IWnHIqfgJ9eUfV1cMdwYqW2xlG1rGz+KBugLzP6bl95oWmXp1tTM99jaTwfuw==", "26062510-9cc9-47ce-800c-a03a2eea0a26" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c73d23b-693c-46d6-8ce9-dd092c5a614c", "AQAAAAIAAYagAAAAEGIovtjte81lTi+8YBaNyxqbT2ZUfM/HLX1Z+rg7qssTRO1wkn6yhhMUAsIpP3n5hQ==", "ae9c7365-623e-41c2-84f7-4647f8671aa6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f350c3c3-3dde-4aae-8fe3-fa9aaea394c5", "AQAAAAIAAYagAAAAEB15yq22iRkEQjFdM/wgi+xOi9nkATuW5eka9O26oHMMrb/w+WHIGp4wj0fi+e7uvA==", "4458de70-ac01-45e2-bb97-dd08438c5c31" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5832bb51-8178-424b-bdb2-f5f1ba34d41c", "AQAAAAIAAYagAAAAEF1JlTdMPo11BKAhJPz4mUTwrftlb4CNcKJchCXVwdrHzUhs13UaTgN6o6qe7wuOsw==", "08d0f86f-7a2a-43a1-b8c9-e85a48020946" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4670398-c726-4217-a370-145010c80a5a", "AQAAAAIAAYagAAAAELn6gd0kJ4De8Nb9R9HBj0sf0yd/0+axwO24rBJsWzNmSnvCWHshO1IOSM9Ifmy1kw==", "cb782543-4178-48fa-a976-cfe63bb9a123" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a955740-9aef-4575-9d86-14cb27685561", "AQAAAAIAAYagAAAAELR1ojEXFz5atcjTF0akiddIPWbe9jQSUOlCQGCjx7IRRygAz8pweMv4uvAavVsaoA==", "75d39fbd-80c2-40d4-a07a-b657a36a01f1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e34a8b1-c6f6-461c-9a15-564788a8fc48", "AQAAAAIAAYagAAAAEHw3Kd8f4ZaBazFnr0P2+asX4hPpT9a/6KK8LvbS5sVfgvfWTqI6d7o/2BSjQ7Qu1A==", "42196b50-4456-4dde-8e48-0b20a98b9929" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d88dbbd-f057-4695-8944-3e7cd87ff11b", "AQAAAAIAAYagAAAAEHbLFzrL9bDEJLZCOjIsahJtsltAOFtujZbCwhvDecP8p33u42tmT9osnSMdHHxxFw==", "547e6d3d-b7b3-4c31-a612-ac2d9dcd5f4a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c7db3b2-9f83-406e-8bd0-c99877221181", "AQAAAAIAAYagAAAAEPgIdbdNzjqrjeMMeuS5GE75DxTNQoybW/KqNOyH5h0XLFJpeDMtR4Xdm/BJ9SthOQ==", "8eb3cf36-2aec-4f81-8e19-62d0521a9955" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb2972d-caf7-4c9b-817c-ec6a98423a6f", "AQAAAAIAAYagAAAAELhDFkZWpn/j8MtEiSmL4HQnbvr7+o8QBfH0kxDCUL1tckDyVKYdzJR106O731awyg==", "b62c111b-e190-4956-981c-27428b74ba36" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b581ef6b-abab-44ee-ad2e-370113a906c1", "AQAAAAIAAYagAAAAED8cZ319uI1UggyOlcrjJPRWJsfPxh6kUeZ97355/9KB5NT9ZRDdpOE3p5WqVvl4cg==", "f87005fc-9970-4f2d-8257-935641b46fb8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1126b2db-191e-4a95-8e6d-01fd617b5cc6", "AQAAAAIAAYagAAAAEEnDPfFQGdSJvNtHP6sH1fl2Hf4S7DvSgCwY3jUjIheMjYjl04baiTiZGuJCNiRy1w==", "711e285a-62f4-4458-b514-1681860a1801" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e874bb21-e82c-49dc-92c1-923110de4086", "AQAAAAIAAYagAAAAEILvOI/ggdVme2lGSvQjMBHwmemLxLglOldnNKg7lWkAHwKW3q2iACMG2DlQlgVL5g==", "12a9b85b-951e-440f-810b-a0ee5fcda106" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d873a538-2823-41a8-bc2f-273010d20960", "AQAAAAIAAYagAAAAEIMVBfFa+oRvVHZWyQ5BD3rN6WXcbdmWkRFA0D4Vo8BkHybZ9PrNr3BPPfbXT7P7Ew==", "add16937-b1ab-46c9-8943-f987543dc0d2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf6ca17d-298b-492e-b8b8-f68c6c10b6cb", "AQAAAAIAAYagAAAAEM+mxNz7cddTiI5mp/JgiRw4C49CaTlNuwvad0jdD7Wdwa1UVOL/ZBwVRIABMVBYyg==", "a8c05fc3-f690-45a2-8a0f-0ce76c2c2b19" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee370b7-aab3-4ac8-91b3-52099678d865", "AQAAAAIAAYagAAAAEFSyp14+x6K1pqufJYGT6Hz9EMAKocogfhItAjDxLhWx2cMfPtyFxh4pTtEa7EKvhQ==", "5542995d-9a15-4fe0-ba4d-55a9b42917ef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d49470-fe9b-4541-be2f-0e9c186aafa0", "AQAAAAIAAYagAAAAECiJ0Xuimho7xtPQYH7KmqUsW/FJLbIim57tTuzKusY7T4bSsf9L2g+c4a0LoRtkvQ==", "6ae0506c-178b-4fd8-9fb6-d34fb85fa49e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d81b3a-35f2-49fa-8be6-f7b17868fce7", "AQAAAAIAAYagAAAAEBQsD3PotR9SXcMADSoSbWIFxk1iXmOPIWyiNEiGZd4XvyW/TD6tBidGW9HBKoD2TA==", "59aa00ee-91e1-4f28-80b7-893c63b8aa46" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8343c3a9-9fbe-4cab-9fd2-6ac363ae9132", "AQAAAAIAAYagAAAAELx5IoyMlIlRL8UYWsGMVByQMrJPQBkY4Iyz3bvOteE/ng7lU4lB30t1NEH9tsYoig==", "b22314cd-e958-46ea-b6bf-9b117f64f875" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02910133-63e5-4627-932d-dbd20bb234be", "AQAAAAIAAYagAAAAENwFvJgV9Qv8ayGB4i78Oo1tgPZgz8T1SjiCehZ75XJeiXLvKfcZn4aUz3xDKyIzbg==", "563c6ec1-4e61-4b2c-8048-f9265701c6f6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b25372f-cc38-4e09-92c5-17af103c0ba4", "AQAAAAIAAYagAAAAEMBV7b6eaAAZnzM/fScfaKPUQEeTm5VhvFL16YUOpQhLDdMZ4Qqc2BQTxIWEkqlTzw==", "c31799b2-59ba-4e77-a1ff-edf6b465de6d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7536c14-a6e3-4af1-8bfd-1e5722de1676", "AQAAAAIAAYagAAAAENgzqUCoFd3a9Ph4w8jyWqdOhkYA9j99WwGZcPs8gNstyvJyCNV/sMlyxwsJx77xkg==", "267c3d18-bd7a-4f8e-8dcc-70c1252c766f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "753ec9ca-5683-43ba-9eb5-19a1b2fd55d4", "AQAAAAIAAYagAAAAEAZ8YtQXP1f8XRL37duzIZ06xWdbf2CPEQUonLCtv9U1sWADa6NgD68gq0SzokKBZg==", "c532ec6f-59cb-456d-9446-0fc397d8cb34" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67401d13-84ad-4820-8007-cedaad9c125c", "AQAAAAIAAYagAAAAEO2PPqnli2k7Zh2BV1hrqjfAoM8MTfgAZEIJeJGzkpbVbdEvUdGh82wbDhc9zkyqNQ==", "57ae219f-aacc-4760-ab2a-2dd41476def2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9dc33d9-863a-47ee-9830-42f531b40379", "AQAAAAIAAYagAAAAEGgdNiKbAIzTrF+2ahcXmbK7HdCAah/3sE3ochQqEJuOhssF2bz4p1dTme1vWMx6LQ==", "f2e20b4b-b602-4c4f-b94f-41041072782c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed8bc3f8-4f2a-43ee-83de-0c1f553714e6", "AQAAAAIAAYagAAAAEKRNcCwL60l7/8fEDy2FfxaR5/ykcxWIz10eCgISIkfQ+Ktvv7gSPn4J7SKM7oPCjg==", "2f1f4cc5-8ff1-4296-9419-ad48302b7cd6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5680307-d8dd-496a-a921-f463fc868dbe", "AQAAAAIAAYagAAAAEPDMDdTSbyTtgoqMP/4br6G842y2MZlhAmm+nnmxMhmAI/kIAvsFv5oZnsPcy3lOIg==", "240091ef-fe2e-49f4-8f41-9e067fc08b59" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72dbbfbc-5936-46ca-b1cc-be04f407e692", "AQAAAAIAAYagAAAAEPgegY4y8epGxL719wuka9VCadRlTqb0W1n20N/yMR+MhvSue9jZ0Xkg0YrP3tIL/A==", "937ed9c7-29ec-4174-8dae-8ff81387a9ff" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec08b6b-9e71-44e3-b820-bfb614e3c23b", "AQAAAAIAAYagAAAAEOvgiCZbuPIbe8wbdNoHTx7jrX4WPIXxr9alG+jMALzDCTGIymaZCcEu1L3gjGspBg==", "661f18e4-cf30-40ec-9284-5c46fe284e59" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3dffe37-c4b6-428a-9234-87158fb5da46", "AQAAAAIAAYagAAAAEJAn4Yo/x350ce55jSuIbv2Cp8ZrK4vj3oVTRokqHNj/Y/12x0KxCqJcPnnqejp55g==", "ddcb023e-1c4a-4160-92c3-09071de8e012" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a082a81-0655-4e2b-82ca-62f7567ea540", "AQAAAAIAAYagAAAAEPgPJ/xIk7+ZJaxuSMWg45ykiZ1aAxaANb3L1WQTyZoPSGTr32O5D57rN8/abrvkXg==", "5c65cbe8-9fec-4359-900f-8c23461a508c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73bf295-350e-47ec-a9ae-e78757b4c2d7", "AQAAAAIAAYagAAAAEIV419ipfE+bFuajexuhJrQQC8OH7VxZ9itHgZZynEKGVDQy3UfR2N6ezbm5mAm+xQ==", "0507129f-98f8-4c6c-9c32-8b8c7709a46a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a649c90a-710c-411e-b157-3388b14ae1b7", "AQAAAAIAAYagAAAAECAP4X5fowE7EYbX8glMe4IFiGZmDq6fdSO3ogVnU92VE2UKiOhYN1swz4NObLoXtg==", "b8f36d7e-d413-4a9c-8ec5-4f4f8c441cd3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e20dbaa7-06c0-4654-9da7-e8325c1ad054", "AQAAAAIAAYagAAAAEOdG1Ss++ecZOGGgRQxNAAJdv6qwLKD3YZvOEuM08vJ0dtqIRO4V/fpMCMD2NbTpiQ==", "51eac737-e70b-40ba-b8fa-d0b4e9c760ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba49054c-3dab-4ca3-b6bd-6e99a9b4b6df", "AQAAAAIAAYagAAAAEPucw4bvMbtPxVXZWzL7y0ujYENRNv9NLLr5t0rmY3Fz9MGSPhK0x6yjnckOoFrAfg==", "de67a3e8-881a-49ea-b4ec-6296c7ec3e94" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306d284f-1cd5-4dc5-86e1-a20554edec30", "AQAAAAIAAYagAAAAEPPomJrmZmVDnlkdC9iCvyLUfmr+wWIyGipDJ+3nW4cvMQAMAODjbj4QrFmU91trvg==", "4c8d4e4e-0ba2-4f6a-8d0c-062e7bcb02ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edc3baf3-bc8c-4f4f-bb5e-78299e79a732", "AQAAAAIAAYagAAAAEBV7+6NrAkz8GgA6ES7FNtYOry54YMrO2KAx7lmZHxDF4X15Lk8wCvXaxvVu88p0Xw==", "a20ada41-a4eb-400b-bbd6-19eac18a6408" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a05285f4-f699-43f7-8591-149aa9a632fa", "AQAAAAIAAYagAAAAEFk44XCPbdnzdI2V457K84TeBhNTD9m8q3aGOlXZsWD3meJj2JUJa1xcSvCJQE2khw==", "4fb75167-c719-4a9e-a6f9-ea0a7aafdd59" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e055eba3-e7d1-436c-9fba-6a8296f9ca29", "AQAAAAIAAYagAAAAEPdCQN7x8JcNnrOMe/Ebp/egDrbOkVghfq35r1PSlhd5yQg5RtEFz4MEfw6k4fuJ0w==", "8737171d-bb5c-4247-b4c3-88a45a92133f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf1d486-3203-4f18-ba6d-33ae6a8849d9", "AQAAAAIAAYagAAAAEGJ9BvxYlc83XXa3FxVuWt0bhy/rd+ueOvE7kEDDqEX3nbQ0tTeUlUxmKocZkfr8RA==", "7b37a790-4c9d-4b3a-b4d2-1f7e0039488b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1706dc83-fe9b-4b51-a2e7-9e6ea62fa467", "AQAAAAIAAYagAAAAEFyh6ATS32Wwns9RTvf+benzVJA0Wed+aQ9xTb6LUNeLyo9xrsY1DiF3IQDTJxZ5RA==", "46eec9ff-0157-48df-ab7e-e997ad091ffc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ffe2384-5c10-473d-bc20-12e3a52a9e0e", "AQAAAAIAAYagAAAAEFj+qtZossHbAd/gs3YmfhOE/T/d9lR/GMQbyUCQbiyDnQhgSq+nct4NSuHND9sOOA==", "67857968-bfd7-462e-81af-8a515217fdcf" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("297155f5-7246-4d39-93b6-c3ba2137454c"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("3003c083-4e44-4a84-bb21-cd1e0b37cea2"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("55995dcb-7335-4036-add0-577315faeeb9"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("6b803e59-d340-4fc2-9190-3cb94aeceec6"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("7695be49-da96-491f-bd30-01e5b929067d"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("8be3a3a9-6a02-4f57-8357-4a10aa574604"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("a73d7e99-88e5-4928-b005-35a2fd51764d"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("c61d4432-5b1b-4156-93d0-5985d33ecc37"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("d958c54e-36a2-4fbf-96de-49d256ea46aa"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("dc4fa720-2bd6-48fe-a52d-b7b3ab1593df"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("e82631c1-9b14-4199-a585-f6077fbc999d"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("fd0e82c0-bfa9-4acc-8cf5-3a96fcd22845"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("3b738e5f-93fc-4997-875f-8dfbeb4280ae"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6433), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6433), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6432), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3d9514b6-a854-4851-a65b-f05300f79604"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6408), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6407), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6406), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("530f2b05-354b-47e9-a795-d37904a3d06f"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6415), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6415), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6414), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("53d9c233-1d41-462a-9dfb-bf27935708b8"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6395), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6394), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6393), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("661b112a-9198-4ba1-a6b9-6ea0e2d7f583"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6401), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6401), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6400), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7872c527-4dc4-41ab-a74e-3c33c057d077"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6387), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6386), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6386), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("af0fd0fe-ffe7-4cd5-9d66-84d2fe2d0f78"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6421), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6421), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6420), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b13166cf-d434-4201-a709-913222a8faab"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6443), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6442), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6441), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f36fb7b4-71f2-4478-b3a0-7fb4bb51f52e"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6438), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6438), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6437), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("fb97bd39-e086-47d8-abe0-3b06b1f10b01"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6427), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6427), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6426), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("01882b4d-39f7-42cb-a93a-d3c948b43c05"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6155), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("02f1380e-79dc-4396-b07b-e4cdb2474c04"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6064), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("05eead13-8fdb-4d44-8701-2e084276bf27"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6097), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("06aa1195-d3c8-4462-9354-c70731870574"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6298), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("07969ba4-c69a-4401-ad1d-2b5ef51fd50c"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5997), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("0ada0c95-7fc2-4a7f-84f2-d962496a5e4d"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6305), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("183ce8f7-1219-4585-9c22-ba52ee9c9151"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6180), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("1877964b-a6e6-4584-b948-cf76b9f226fa"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6194), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1f517f84-d46a-449d-8361-d33b8f845ef5"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5978), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("2a07a267-6bfc-4cd4-b7ea-eb46fceac72f"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6025), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("323d560e-e8c9-4901-8ee7-45d85a204525"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6083), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("35e32dc2-32d5-444a-89d2-368b984638f3"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6090), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("3cf5d828-db68-47dc-a9fb-4a6aa7ab9813"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6312), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("3d8b971f-b190-4b92-ba52-2498055a2630"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6173), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("4186e355-fab7-4387-9c68-c6a47a03a31f"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6033), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4495fca4-7c0d-4c62-9601-30bbcf299815"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6164), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("5271f524-e816-493d-86ac-bb1a180ac703"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6239), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("53c6e6cc-cda7-490d-a7e9-3003362a1fe8"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6275), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("5f059447-823c-417c-ba06-4f860b2261c6"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5986), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("7e64d8a3-0020-41af-95bd-bcd7bf2871a7"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5966), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("939f20d6-8d33-4957-8a52-3f7da2d7448b"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6017), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("a38294e1-645f-407b-80a2-9e920060c660"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6260), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("a49161cb-41f2-4172-ba32-d72e4863a2ac"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6267), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("ad4fe768-a5af-4b3a-bbfc-f93d1b8b130f"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6291), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("af70aaee-e08e-47b9-b4a8-3debd6f7ed7a"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6222), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("b5eca65d-e17e-42c2-93b0-483324de2ebf"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6105), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("b8dcc6ce-7eac-49ba-b572-f8ae548a849c"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6187), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("bac9ccf1-a8ed-4265-b79a-bdbd423da2dc"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6232), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("bbf7c5b3-bbcb-4558-91d2-8b7430bcfd74"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6282), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("c9298b28-7931-47b5-b213-f0b22776a51b"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6246), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("c995efde-35d6-4b8d-84e6-d9088f596dc0"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6201), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("dc81af59-8af4-4e42-b48b-e605c8f6035d"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6208), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("e14771d1-49b1-4f43-87dc-f34978b969eb"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6253), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("e90507c0-faf1-448b-9027-5e6c18135cb2"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6215), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("fd4edd12-8dce-4eb3-9694-0afc3e32bf40"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6055), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("ff3a3b16-173b-4651-9d28-27bd71c72be7"), null, new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6072), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 4, 22, 17, 28, 26, 274, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 17, 28, 26, 270, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("040f5491-c501-44d9-9c2c-6f75dd35fe5a"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6688), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("35b6c2b9-12ab-4c9e-8d60-6bc074ebcd0c"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6692), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("786802ae-9620-4f7d-81a0-08b91cc866da"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6683), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("789d83c3-1570-42cd-a825-ef1036c5c6b2"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6686), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("930c8c6b-cbdf-424b-85be-ef6ea2d4decd"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6706), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("a2a6a2ce-47f1-449d-9681-7abf8ec989ef"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6699), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("abb26135-8a4b-41f8-b0a2-4918a64e15fd"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6704), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("bd826fb9-4e05-4243-bea2-a6795e54e4dc"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6694), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("d8974acc-78fc-4005-9445-457cdb49711b"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6697), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("ed09d007-fc09-436f-9ff7-f352a6372d29"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6690), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("f15fd6a4-d6b0-41cc-b8d4-754906571e3f"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6673), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("fa574d3a-a222-4287-b7ef-7069f10dd6a5"), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6679), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6557), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6547), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6565), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6561), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6553), new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 0, 28, 26, 270, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TourCompanyId",
                table: "Contract",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TouristFacilityId",
                table: "Contract",
                column: "TouristFacilityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("297155f5-7246-4d39-93b6-c3ba2137454c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3003c083-4e44-4a84-bb21-cd1e0b37cea2"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("55995dcb-7335-4036-add0-577315faeeb9"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6b803e59-d340-4fc2-9190-3cb94aeceec6"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7695be49-da96-491f-bd30-01e5b929067d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8be3a3a9-6a02-4f57-8357-4a10aa574604"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("a73d7e99-88e5-4928-b005-35a2fd51764d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c61d4432-5b1b-4156-93d0-5985d33ecc37"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d958c54e-36a2-4fbf-96de-49d256ea46aa"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("dc4fa720-2bd6-48fe-a52d-b7b3ab1593df"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e82631c1-9b14-4199-a585-f6077fbc999d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fd0e82c0-bfa9-4acc-8cf5-3a96fcd22845"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3b738e5f-93fc-4997-875f-8dfbeb4280ae"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3d9514b6-a854-4851-a65b-f05300f79604"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("530f2b05-354b-47e9-a795-d37904a3d06f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("53d9c233-1d41-462a-9dfb-bf27935708b8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("661b112a-9198-4ba1-a6b9-6ea0e2d7f583"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("7872c527-4dc4-41ab-a74e-3c33c057d077"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("af0fd0fe-ffe7-4cd5-9d66-84d2fe2d0f78"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b13166cf-d434-4201-a709-913222a8faab"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("f36fb7b4-71f2-4478-b3a0-7fb4bb51f52e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("fb97bd39-e086-47d8-abe0-3b06b1f10b01"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("01882b4d-39f7-42cb-a93a-d3c948b43c05"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("02f1380e-79dc-4396-b07b-e4cdb2474c04"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("05eead13-8fdb-4d44-8701-2e084276bf27"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("06aa1195-d3c8-4462-9354-c70731870574"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("07969ba4-c69a-4401-ad1d-2b5ef51fd50c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0ada0c95-7fc2-4a7f-84f2-d962496a5e4d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("183ce8f7-1219-4585-9c22-ba52ee9c9151"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1877964b-a6e6-4584-b948-cf76b9f226fa"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1f517f84-d46a-449d-8361-d33b8f845ef5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2a07a267-6bfc-4cd4-b7ea-eb46fceac72f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("323d560e-e8c9-4901-8ee7-45d85a204525"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("35e32dc2-32d5-444a-89d2-368b984638f3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3cf5d828-db68-47dc-a9fb-4a6aa7ab9813"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3d8b971f-b190-4b92-ba52-2498055a2630"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4186e355-fab7-4387-9c68-c6a47a03a31f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4495fca4-7c0d-4c62-9601-30bbcf299815"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5271f524-e816-493d-86ac-bb1a180ac703"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("53c6e6cc-cda7-490d-a7e9-3003362a1fe8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5f059447-823c-417c-ba06-4f860b2261c6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7e64d8a3-0020-41af-95bd-bcd7bf2871a7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("939f20d6-8d33-4957-8a52-3f7da2d7448b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a38294e1-645f-407b-80a2-9e920060c660"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a49161cb-41f2-4172-ba32-d72e4863a2ac"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ad4fe768-a5af-4b3a-bbfc-f93d1b8b130f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("af70aaee-e08e-47b9-b4a8-3debd6f7ed7a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b5eca65d-e17e-42c2-93b0-483324de2ebf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b8dcc6ce-7eac-49ba-b572-f8ae548a849c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bac9ccf1-a8ed-4265-b79a-bdbd423da2dc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bbf7c5b3-bbcb-4558-91d2-8b7430bcfd74"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c9298b28-7931-47b5-b213-f0b22776a51b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c995efde-35d6-4b8d-84e6-d9088f596dc0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("dc81af59-8af4-4e42-b48b-e605c8f6035d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e14771d1-49b1-4f43-87dc-f34978b969eb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e90507c0-faf1-448b-9027-5e6c18135cb2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fd4edd12-8dce-4eb3-9694-0afc3e32bf40"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ff3a3b16-173b-4651-9d28-27bd71c72be7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("040f5491-c501-44d9-9c2c-6f75dd35fe5a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("35b6c2b9-12ab-4c9e-8d60-6bc074ebcd0c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("786802ae-9620-4f7d-81a0-08b91cc866da"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("789d83c3-1570-42cd-a825-ef1036c5c6b2"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("930c8c6b-cbdf-424b-85be-ef6ea2d4decd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a2a6a2ce-47f1-449d-9681-7abf8ec989ef"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("abb26135-8a4b-41f8-b0a2-4918a64e15fd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("bd826fb9-4e05-4243-bea2-a6795e54e4dc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("d8974acc-78fc-4005-9445-457cdb49711b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ed09d007-fc09-436f-9ff7-f352a6372d29"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f15fd6a4-d6b0-41cc-b8d4-754906571e3f"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("fa574d3a-a222-4287-b7ef-7069f10dd6a5"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b3c03c6-f5d2-4c86-9dbc-e03452f6fc16", "AQAAAAIAAYagAAAAEKtaehtxTVxayU0sN4tTuM4W2y96hI5ytNSMbad6c2TIYcrJr/YbrwVm2YqlmeDzAQ==", "ae9a4ae9-d95a-4908-bc26-a3f9a34e59d7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba4d7391-5e43-484a-8c01-4dcaf96499db", "AQAAAAIAAYagAAAAELhaZS6CsfW+wN6+ePsCW7wdvk54mpKipoyrrJkOXypOfEU2iAF6qpU/GdoyPxyBwg==", "03550851-8bb1-4a91-ad55-b7cf36134252" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "469d259a-01e3-493d-8a00-74c6e3bf63af", "AQAAAAIAAYagAAAAEABScmNCOMXdFmzzLm5nK2uiEqNqpY9Zl9+SBknlXe0CmymrDq8EF2VLSBQq1LkPZA==", "912ea1ae-9ca7-43f6-86d6-a7a8731788f5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76800296-b128-4a02-90d2-2cc243a8c161", "AQAAAAIAAYagAAAAEG7eDSvyy7BQcSQntAZMxKjV1SJijcDnA/ItetkpD0QTWlKjy0Hfrh+YSWV4B+tTeA==", "fa08128d-21c5-47bf-ba8a-6ba8f3a62723" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9fa620f-e46b-4c96-af77-d03860324dd3", "AQAAAAIAAYagAAAAELtfXM00afUNcqc1D//owkCVWoWhgtSX+RN5iAaqzW+spqjqVcB+S4I5w+3J35risQ==", "26770bd2-14e3-447a-ba10-9005b6893ab0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e2f28f-1fe7-4248-96c4-0399746e7e90", "AQAAAAIAAYagAAAAENHXxNrS2gvM/MhHd6EMTGcoU0IoIP3waDSFPu9uIjjgCCohTNR708BGWiW0jF6Vrw==", "fc40a2f1-dafa-432e-89b9-23a445806537" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "819586c0-c62c-4995-a8d6-d88be9e6a700", "AQAAAAIAAYagAAAAEHIt00g3eNnVS6h98shQNBk1po3zIX+cAbOgrlXj4nCbzdOmQ5lMR3WQRIowrypYXA==", "4a269d59-f3f2-4af1-9273-70b599028a80" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfa776b4-0c1f-43f4-8cde-1a2c1b91469c", "AQAAAAIAAYagAAAAEF9/pe9knt6mxWxlcG+BUbMPj9h7/u6ScTASbg6d/n2ihhX3pTBHARnJqSVWk590DQ==", "b19651ed-e728-43c4-ae0c-cb4af567ffb9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54bb5942-7a45-44d5-a81e-1cc220ca4494", "AQAAAAIAAYagAAAAEHmBJdm4IEq80vEpMjT8DsJKwW9K5nFPzitu0kG8tpzlcZ4NSbIlWPuvpmRow3Qb3A==", "d4d0851c-ed9a-481a-b381-c2035b370529" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ceab873-2b2b-445d-a72f-9b4bc1458902", "AQAAAAIAAYagAAAAEOsr6F0wMFpFUa0n9r3H+6bIk0ZhrWcVqNlLpr91gsycCz6uPKGiFtdysB5gDgOLRA==", "e5539003-22d0-40e5-8a5c-0eeb6e94f868" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b1bbb92-fbb5-40ad-9d97-9641a1395eda", "AQAAAAIAAYagAAAAEBFobV9pQrmKucjF1qFaAlEAxTrjJ14bQNZzB3MZsfg1xIjx5EhgVNVH/+u+nRdbwg==", "12ef11f1-7ada-40f9-aa5c-8db36c7db964" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e335002-ebdb-483e-a008-421c516087cd", "AQAAAAIAAYagAAAAEHHbfdWnimEQTVCCgIcelenAxRZ73FKjPgX0PdwR3uTll6Z+f694WqbMTqSK4tMizw==", "a7a2807a-a463-4aa5-a3c0-89adbd75eaa8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2092631b-b913-4df7-ad92-9e24c187ea53", "AQAAAAIAAYagAAAAEBp3e8445nnhhuudGzYy8jPvVF1Hq9cX5UGBQpeAMLu4dbUTDbZ5aZWLC2AuUVVeHw==", "41c877a3-7bc0-47c2-9689-c97b258d1419" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "145e3bfe-6b50-4026-8b74-83d1413aa456", "AQAAAAIAAYagAAAAELztokb9m9cPvyjhi7AIiZlg8xFOl32j5lMdWoRw0psTbwQInendUkxWqWJgNGbdmw==", "fb9c49b8-6272-48d4-9d3b-36bb612a190d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edd6ee91-f941-49f4-90c4-70f9b7256501", "AQAAAAIAAYagAAAAENRoZl6nfRImgoJhlB8YbuXnXHfHl3Ot/lvNwOCeShRw+P9gN6jJ7WewZNKUfXHPdA==", "143acdf5-701b-4a80-9f4c-18a23466847e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae80fcda-1ae0-402b-9c58-7b0e9b1a19bc", "AQAAAAIAAYagAAAAEB7pIxRGK6llx4e5bZ3zz8+UFhM7tPlBOxtMj/iQP6djNArBs5On6TpZESdemlWVKA==", "90c34adf-723d-4022-945f-97af0df3338e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "443fdc3b-cf0f-4b8f-8f72-33099e276401", "AQAAAAIAAYagAAAAEKDmFIz1k+t0XBJVuCpXQ2JhBO3rkgCNX368qNYomUokeGiP/Xc0eEZEvoYMRG4W4A==", "9c7996d2-e83a-441d-b5aa-b1dd71209f8e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f210cf61-8600-45c3-a963-420f3302cc6f", "AQAAAAIAAYagAAAAEGVNoK+8xWXxc+44rDgItmVKsol9oFeBrNj1s24byywtipuNM7DPg9oICSqvv9cHlA==", "0f8fc3fa-03ae-4586-b30d-24842eb3b396" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8e212c7-5228-4821-9ec0-e8071a882a9c", "AQAAAAIAAYagAAAAEG5UkTkERxOAMMjFaE7BtAHv2JhsWKVs/scHwNLEhHCI15XgD0pQNKsB9cVFak7iSQ==", "86486e58-773c-47a6-a2b7-5fa88dddd826" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebd7d345-b5c8-46d8-adcb-6d2a598d1a77", "AQAAAAIAAYagAAAAEE+RXbFmEJSSD1KNDrJvpGNh36PuKjL1qpGybVHUobBoVkGctA/qG8jSzsaWFcYnVg==", "dc757c4f-4613-452b-842c-95f2fba40593" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b48327b-feb6-4d73-ac82-a0f4a0dab7a7", "AQAAAAIAAYagAAAAEPkt5898xgxo6YU+n2b65wu+GfJ7lEpmEklPWT0kHsGGZ/amIGbI8tNb1Ujx9aZZuA==", "a0cdb5ea-dd2f-42d4-9702-9376ef7cd9b7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89331a9f-19b3-4bea-b95b-36cfe558d665", "AQAAAAIAAYagAAAAEEp6l0aIDLyte+icfhBafFL1SZtsyJ/Dg53xyJ0DUXU2g0pMv6pia0eACuI4pQdgVA==", "863ebb97-8beb-42dd-a4b5-2826da94173c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee1f631a-8eee-49f6-b889-1a75899594b7", "AQAAAAIAAYagAAAAEM3y71tV0gYWA/bNSOpThRVVNc2+spWqMo8UNEaQ+8t+zMQ2klUvkkHpEDUKKSfrew==", "3133c229-55a7-4a77-a860-52986cd5424d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c79ad30e-1827-470d-b08f-a3b036a9464a", "AQAAAAIAAYagAAAAEHoWBgqnfSDbfVe9SvNaG98Rs+Blfx1A+OvKezh9xYCTJnzrOfhMUx6XZaTgO4ofcQ==", "57f8c49e-ebe2-4cf9-b119-1ab156bfe938" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe6a008-161b-46f7-a517-8f9a35597074", "AQAAAAIAAYagAAAAEI9BuDlMX/W4RPFQQc5+aIx1l8WcZXroXFSVR/Zeq0giJMDAYPXOjJgyfat3phMeeg==", "256b0b54-0499-4fec-8768-1c47ce8e493a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "172183dc-fc9f-4d08-92d6-c83705f6e1ac", "AQAAAAIAAYagAAAAEBQwrZAjtORAzQCNyggYC8HjAuMZvL+Os5GFYw7VTXtKuCgBrqylp/NPD6byI7BkSw==", "30b011ed-fc32-422c-9df0-26a9ecdff398" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fc1a2b7-3484-4f8b-941e-63a845cbb78d", "AQAAAAIAAYagAAAAEHPsU42FY9hlOyAjvCXVTYHv08cVFxFHxgGnKdpJ2KWQtRikeLnlKK1N+6VHiRhIuw==", "ad138c00-c2ae-475e-a4d5-8bef50a74aae" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23296999-737b-4752-b488-8ba0e47b23c8", "AQAAAAIAAYagAAAAECR60n4XfJpgImyVjwJc8iONaoX3yV+nuyBmPdeUVDjz7pKACakk5Nk9FA0IJMW4Rw==", "715a308f-908d-479b-9da3-bf1db266e8b6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "770777cf-df7d-44bf-b9db-cc9ae46ad17c", "AQAAAAIAAYagAAAAEDEt4hDQr749WKcTzRfDFgZOF/j8giyjnhxWVM8zAraxZmq1GnhiHQE+4zc6cDKV6Q==", "1a9fbe49-aec9-4dff-b9c1-cf643e9d0558" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a93421b-dcd3-4862-9a17-ff74303055cd", "AQAAAAIAAYagAAAAEItFtPVYOxWDd6lkaiCdmgPn4v8W28ixicRUEEJ1B370wgfX5UAfbPvbaDeSdGGqJw==", "b3b4b6ec-175e-4393-aafd-4822ba21cb86" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1415b6f-bac6-431c-94e2-a369b9c4b9f9", "AQAAAAIAAYagAAAAEMXdbmXu8uxvgGAsXtMc7GruIwX8wXB7vpGoBHDRD5yPxqZRxs4ZpC0g3MaTjjjAgQ==", "5b85908c-797b-407a-83d5-bff3d97e692f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c530c770-df12-466f-a2f3-1fdfbf06774d", "AQAAAAIAAYagAAAAEBLTCnWLyMsIfgCB53ZYCRgopwGKTWtp5oBldibVsB9eiTlrI+Ijhra4xqqpVeptmg==", "8d21748d-de37-4a9a-a758-c9d2ce4536c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99decc82-a70a-4917-b205-aa313219e31c", "AQAAAAIAAYagAAAAEJKMSXWq36IlSQyz5xDVG8xHxTViXKBgIVf8Ozq4gijUaJC17Xf8oPYjaMuFgsB69w==", "a2bc2e9e-d4d3-4d3b-b4bc-399ad323b489" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f9fa579-3a64-4baf-9038-bb8b99c82554", "AQAAAAIAAYagAAAAELci5Zn35imz9YD8ZXyVrMd+87LP/5efY9qKMOwWcJxhfRs38SEGiVI4thIf0g66kA==", "57000a57-9af6-4cdd-a2d0-cf5eb0178634" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b82155-1c16-4127-909a-3758d0aca0a8", "AQAAAAIAAYagAAAAEDkzJngXpaRjZGK0jtDZ5ZDb1Q7HR6sTxOu+9nPF/QwYkcg64P4T+GJMhX3vKpIoow==", "a2abaf2f-11f8-4c57-8857-317a5bda659c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b83c803-b5e3-4247-a27d-a8d8a8bb3b86", "AQAAAAIAAYagAAAAEI2MZQDTcTpwGq4eIS/bZLwr0u8btGeWj1TI3Z3bRP+dwni/TnPJ5pdAlswCuFQ7tQ==", "f2e5ace4-5610-446f-bf97-1548af911df0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cad2e671-6945-483d-8c4d-6cf52c9fe28c", "AQAAAAIAAYagAAAAENn8haT7b2Dc8wWLWdPgIZiHRgHq1R9Wm19oiISWrlYQsN6IhRtavlQm+FHiQjFDWw==", "c3edf1ea-a8e0-41c5-b687-c42349a2b822" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b718dcd8-feb0-44b8-8f09-0ea9bf2df9b1", "AQAAAAIAAYagAAAAEKwnHSze1LEFSCNoEGfnaJPFN9Ej4CTiFE9JxbwqvLPmdm/L/R/gR4mMtPDJLdL/KQ==", "daf5dbf7-9f65-4e3e-a2fa-08eff1983a5e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84e495f6-af09-490a-bbcb-e0ab64f5e7a7", "AQAAAAIAAYagAAAAEGwAnQZ/5WHY/ibrQ5aY7XVf76F1/4QUq19d3oVqIfgRIL1ayguWC04q8GOJAN440g==", "eef6a476-ae59-418e-8a20-2455c9dda0f0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d08b609-9b0b-44e0-85b2-2e7d821b7e37", "AQAAAAIAAYagAAAAEC0VsrczutD6HTcHvsAJNxoWYocdAx02tYSfTEMPrN9IBSlmau0hoizNR5ojCdTcPw==", "905266ad-c15c-4243-9946-e40313eb78be" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa00674d-65f4-4eb5-9521-8af9f32efc29", "AQAAAAIAAYagAAAAEOPOAjmGRmu9GHDIF9bvsneAHSaEsXOlgjOJzp+kH+ybO4ybs1ZjiZge3e5dIfzfSg==", "fbf6e24a-b5de-490d-9f40-afc791b18b76" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25fdd13f-1327-4a61-b410-49ccf89e454c", "AQAAAAIAAYagAAAAEBuuwF1zS4CpE4NiPtGJvPIqjvzBM8Va45LXgpC8dTSsqrAPrc7elwVocHr0TfazMw==", "f3de5699-2664-4c19-b1ad-ffa56039f0c3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eeda654-17ae-4eea-99e7-3b663b021a36", "AQAAAAIAAYagAAAAEPVSo5vpYEYLqld7OHO+wwtrDk4458jfQXCh8Q2DdRr3COM2XUFeKSSOPM7U8yX4Vw==", "89958483-6eb7-4bbf-938b-5e2f6747cc87" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0ad63c-0c5f-4b89-a951-8bae43011ff8", "AQAAAAIAAYagAAAAEBBpWAV+HywgEwhmpg6YNbs3XzIDXk3GSooDJL3r0fBSbdHJ0Qp9njR2pxjcOgtvnQ==", "c8bc28b7-7c55-4150-b54f-807ccd4b2599" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e655e2-1f41-4fe8-807c-a4c237ac2ca7", "AQAAAAIAAYagAAAAEGfDSKfH4e5CCllx728BPVFIOXxNyUXTKrWJnRiJyxxSdmT91RLMenEtaJZj0Iiecw==", "73969dff-c9b0-41c8-8c1c-8223a5f160f6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b1e8db-3403-467d-a67d-127cfb98ade3", "AQAAAAIAAYagAAAAEAZYymiamvH3JwN28CNtbvWz418v+hU6ufrykB0STIMVKrfFTI1AouYEldf5TEidCw==", "80e91740-4d18-4a0b-8b0e-7218dea35d20" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b863a0-c790-4982-b435-611ee53e49a5", "AQAAAAIAAYagAAAAELhkNRh2JsmXpu2dmf4cNQVC0aSMB+Pf/LaOaIyQ0eCKiyb+Y/1asYn8u+4lug+9PQ==", "4419701f-9ea4-4264-aed1-08c0e20991f6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f26b847-6eb5-4ac4-b417-bb32c07653a1", "AQAAAAIAAYagAAAAEOvXhhTr5dSW54f53o9hXEHeizCtlLj5Ral0oK1ew8FPasJQQO/TjRXNYyOBjg/s+A==", "3e3d1d59-7df8-4841-9840-dff1c202424c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5b0bbab-01b8-4624-905f-d26d837ab115", "AQAAAAIAAYagAAAAELRu3YUFdRvOaGLjVkUupOYq7r4qIABMQG/dgdd5UVB+NdKlgs9MK4ri/bXFRVMt1w==", "2521e07e-f23f-42b4-bde7-c277e8a70474" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42412e05-42ad-4713-b92c-c0ea08d2db53", "AQAAAAIAAYagAAAAEDZ2OUWATAOHxT0pUGnN95Tdr/uKh+sQtH7iPIK24CD3jHAS0Oem8A1DMNVtBiqEoQ==", "0a974997-6a74-4c9c-b00b-d69e8b4df68c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef39c09e-414e-43e4-9519-4c7d2114bc5a", "AQAAAAIAAYagAAAAEODkfR4Y/KH18zOoB629XR4c3sxruUm7GdgaC8A9of/q01tHGS4MS6Yzvj0ynjxAmQ==", "e2bec7df-605f-4980-940f-d0d829ead51f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f408a2a0-f18a-4ca2-98f3-963b9e5c344f", "AQAAAAIAAYagAAAAEJ7vstD2FDyVgFEtbF5Ime4NGXPBtsS3iCngBsJnxOcdelYHyBzKaLV5tGLMxMEC5A==", "bc0a13d8-bc75-456b-a6ef-cca270ad20a5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84960d0b-9f98-4f0d-891c-e1d8b8685252", "AQAAAAIAAYagAAAAECx0Mocn9ZcEvcyrU2UG1XvIBGmETx4FJg7KWARZSoWtOOZamPr/7H1SR56EBKimrA==", "c358ecfb-ea4f-496a-b122-35dcb0af7687" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29c26ec-e669-4faf-bd55-39d61ff02c5b", "AQAAAAIAAYagAAAAECHFy1PPiOrpVV110Hvhmz6IOkdkYLn3Au+/9pLsWw+T7UscT0QnES7I2KxgvgHsag==", "611b6c25-5a1d-4293-beeb-f2cdc22dec4b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a595ec9-c9c9-4668-a28a-4bccc5623eea", "AQAAAAIAAYagAAAAEJ/wLKDApNE6QiOyDCw6LV9N5OZQbIe+SnP7UN/IH6CGqVOjUQBumoDDK8DOa7qhng==", "a2b81076-e4d7-41e7-8620-af6882911e2f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c6e5eea-1476-4dac-b2a0-2c88067a6d56", "AQAAAAIAAYagAAAAEEpJOJUU2WbidawpO0OGtFKyZI4g6Rw3zMMFBR1WLZZUM7T2t8kUIf5PzE8EXLM9oQ==", "c355b027-832e-4605-904c-23778a955e9b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "145c1b90-e0eb-4249-9989-3e1c5c7459e2", "AQAAAAIAAYagAAAAELmwNGn5W/URH3BFCXXPemI+aFHU97mScWrDPxUDoWfNo4zdTOYpDibFKFKAf1N/eg==", "83199a3a-3978-4dcd-9ca9-85b49af28c8a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97dbd20a-7022-40f4-8b98-2bb0c026ea7e", "AQAAAAIAAYagAAAAECKjeekgV9NOcYRZgjTe0q2u2D423FcwgfIaPvWqXxb/Gky2grj/Idkj7OeLIZ8Mtg==", "5de69c5b-2889-4fcb-bcc4-6c7ca1f4e721" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17f9883d-916d-4c87-938a-8fd147041134", "AQAAAAIAAYagAAAAEJlX6oQEtjCgnQvBUrJfndYQpYK9pRUEgZFMj/86kvPqmErVa9ne9HySJJl2LWd8vg==", "a1a0b53b-9ee0-4cea-b6e3-f0ebf1807b9c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "310df223-1d2e-4908-9105-ced0bb763f75", "AQAAAAIAAYagAAAAEEkqkzw50rv4hxAFD4CcTIK4sbhm4HzGqEX9Ru+4z6l4j9HfPqAZMXaSIjoKRZK5Sg==", "60bd0a50-1197-4f32-a174-513fa44af935" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3726f9c2-076a-4085-842a-da4b6751e847", "AQAAAAIAAYagAAAAELGSVDC3cb/U/4KpJ7lWLddjColTvcjO7g3zIbrxTxXj80QgEuyW0uLzdsURegJfxQ==", "61d4dcab-bcbc-45f9-ba10-33ead8e9fea8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c93863fd-19bd-418b-ae36-c68b3c56e5d7", "AQAAAAIAAYagAAAAEH5kyU5dQn8vDmmG4ROVZKt2CwWaQ/PMUBavSa6Ekf2ZZJ0tDHVYiu1Seyf2vAjIzA==", "ff7fa7ed-b960-4f0b-b8ea-cf3d39225350" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d6c0fbe-f328-4430-ad1b-f348df042e96", "AQAAAAIAAYagAAAAEG1KOFVVJcFfxgr9hryOs0Hdx/RmAoGmJpnbsAvnYvErliB76McX0FOoPknBmCDPQg==", "6f0d7ee3-3206-4e44-a955-8e2d77cd4c9e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a829f930-c978-4415-9660-1dfefe83958f", "AQAAAAIAAYagAAAAEF8I8U/rGagN4xU37E9dXaZ/+aav65Ci83x6a5vSTO5gPfJfbs+v6KgbNh7oLnN05A==", "59505fb2-30a9-46a6-b57a-d6419bd71bb7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d392d9-3551-4d26-a529-83c7d6b5638a", "AQAAAAIAAYagAAAAEIyb/DQF4zy3rAkUAsuWvzhUwyZvbq3zcZIP1AZD0WvdtWW/JK/+a+oRpiHsf82hWg==", "f2bab1b8-7662-46c6-884b-7702dbb30ec1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "759bf3f4-3e5c-4b58-9e01-82a37900bca4", "AQAAAAIAAYagAAAAEMEOxatX2JSoP4t0enc43po1tPZVQFR37ekNAycwKlvJ9lg0mWvA9HAO4rKZ1duU0Q==", "08f952ba-da8c-4042-8fe9-d6d0fd2f896e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94982b4b-fed3-4c5c-bd09-bc4e87574fa2", "AQAAAAIAAYagAAAAEF4FkYJs7VlQDFas/Ri5SIJRXSSLq0EuWx0Yh1ePcEJYBLqqddCIkNqibq+P9+mW3w==", "2877e8a6-d58f-4866-bb3d-3524d817c442" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9972f02-760e-4e7f-8f66-d19b59eecd56", "AQAAAAIAAYagAAAAEPpSJCh2Uuh2phZqnK1VHuMbegixRH5YuPhj1DJwophQJ6491aR+FiP1CDKoPKLkmw==", "82a3edb8-5d05-4cb2-996a-2fbac95f3a86" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a77e8ea4-b1d1-49e5-8402-80ab8bb7681a", "AQAAAAIAAYagAAAAECKXVKgTEivPGZZ2DHW35bwxcRZcQj21sJqWtqd7q3yO1lvNDisa7ZGyJctPaa8+cA==", "506affd3-d0c8-4efb-99b2-926f8f29a1bd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec6c99c1-9669-4be0-a09a-ed085f9cd428", "AQAAAAIAAYagAAAAEKzaw+N8hEhF/lHf56HGl1CC9VyWfGGrJAQLQviPHXMVcfQ/rZkS4pMI54w+EDmrtw==", "ba4e2964-16ca-43f2-81be-53902a8778a4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "849b3415-66a5-494e-b0d7-6a4e42e010fd", "AQAAAAIAAYagAAAAEI18xsgUbJAyg3AESlyCe66WHFGo3Wf2npbxhblgz0Y4lGTQaK8UQAEXKPjry2l+dQ==", "9ec83863-682b-42e5-b1c6-e30287115b4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d52fdad-1a08-488a-92e1-8e611c0de62a", "AQAAAAIAAYagAAAAEKt0+OsQR+Ihn/0kDX8wDxzE7Xy6YIG6yoRVvT4YaS2X9FgUkvnxxbNDM1zzsX4hXQ==", "aea2592b-38af-429b-b03d-e408328de9e6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3678f32-f8a9-4201-a62e-888e9a5b45dc", "AQAAAAIAAYagAAAAEJormetskKABoeIk402ph7ipO6DcUUHDSu+TIPzAhZdK0bl0nBw4ZobH4uAEjvxv8A==", "86f90f46-8cf4-400f-9301-4e4c77d8ab48" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bace046-b365-4402-91aa-bff6f7eede3b", "AQAAAAIAAYagAAAAEExuX09WA/THNd7nE+SXxaeKHhq1YXeIYe+iwMyoULQeFPFswo5iN4P/+guX6CkHVg==", "f769062f-5b38-4f0c-a886-d33f2462fc48" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4c1ac0-f18a-4cbd-a23b-b3f3faf9921e", "AQAAAAIAAYagAAAAEHhZeTpZ4aG5ZMOZMeB52dc3YI007b9GADjNgwPPwWmXaBY3HZ5ClQQQE2sUTv57TA==", "25d8c7c1-30b0-4fe6-9695-792d9ef21b21" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe06c09-e7a7-4a05-a089-e40c461f1658", "AQAAAAIAAYagAAAAEJUI+FzcX97o19FSCcE5t2GyBXo6M52o+fcmzxxFK6hIEBG5vhYdlilcHQV5EVboCA==", "ef5dd431-1825-4f8c-9ecc-12eab9499615" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eaf49cd-22ba-4f61-bad4-a44ea0099168", "AQAAAAIAAYagAAAAEFHVUM1/ULxQA85gH+W9G+HRNXpUOyAWgZxRXRFEUxjheqdDFvdfBWqqVdpVl2Exzg==", "cdf0b957-dc42-4847-be07-8d69c74bf7ae" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d9b10d-bab3-4fb4-9a1a-6e5e3eca1d3e", "AQAAAAIAAYagAAAAENSXiUukjTqO3yil03aIG/KlYqpXd+/mKWnsa6X1lRR4+VMAj2Xz8FoXB30UQFjECQ==", "34a73d07-cdb6-4c1d-8e7a-91c2743ead57" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8adecd58-cb05-4e31-bb22-8c25917c726e", "AQAAAAIAAYagAAAAEKV91v+6ajOyl94GtkCuvb+DDLy7d8Xp+w/ReFyc47VZ/+dAo4Cd7/vefFMEdgELWg==", "a3908391-d0cb-4cf1-8d6a-8469fc4aa193" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a96406-02ea-4de8-8519-5925175ef5e8", "AQAAAAIAAYagAAAAEAwvNBe0HMpHMBNMngqJfuLcf4Y/S0m5eOcdaRrmd93iQr5PZuNcX6ouBrjH/tdiyg==", "af4cbd1f-85d6-4dec-843b-b374837a2e2f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "257eaddd-adfd-454a-8959-cfefc4fcaf06", "AQAAAAIAAYagAAAAEJZUwRezTzEGmUkZtrORPlkFu1ExXddFocdCkMKFEQP+ht0c/sYRrnvisbmAnDDbmA==", "f7c64f0a-e463-4245-9551-72163f6409f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef1c850-a13a-4588-8550-0dd8eaada40f", "AQAAAAIAAYagAAAAEB9M6+8tmSvQg7b3uRX5vdhMTR43LJGUsKzLe1TAS9x7dDbQLQWu68+9DgZIEhM+sg==", "c62f6f48-1d88-4065-806e-51736e60a695" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d15c74-5b57-47cc-b46f-1fa0b9d05470", "AQAAAAIAAYagAAAAEHD/hzYN3WzlYz13eUbXhOHNLty042RNDEOum/hFn7TzSBMSXk7OytcRQkVI6ETzaw==", "6dfffcca-a437-4391-9997-09bc8db8a4e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61dda84e-a6a0-469a-8fc4-9fea7d099e87", "AQAAAAIAAYagAAAAEH95eJf5e6YoxyO6yrJ2olZDbmEZuTjG3sxTmbNIXVTNcC1d564fjupNtsfSlGxxcQ==", "16e112b7-ad4f-40ef-94f7-542430cc84ed" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc00e332-fc84-46eb-b730-06a25c78acc5", "AQAAAAIAAYagAAAAEFdIy2gdQA2H5APMTsJo/Yffv7HlDxw+83cSCJgy/D9ymVWOvz2OYu2JZ9gw012/Ig==", "c2441d60-7014-43d5-954b-abe21ecb05d2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffdbd8c6-b215-49e6-bb70-4360690cac12", "AQAAAAIAAYagAAAAEI7LyWXvBhTS6acF+ftqyeos6PNRfkwE2cCXAS2b/kCt0M5PYS/gR5viA5sfEFazpg==", "8e773877-9054-41b7-8966-672a3365126a" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 391, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("20fb3ee5-beca-46b9-8e30-a8cf504fcfb5"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("25790f2a-222f-491d-a96e-a3073c2b4667"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("47ffbf01-78a2-4337-9491-e94a81dc112a"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("58ceb7cd-44c0-4065-ba5e-208b0035df00"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("5c67d9e8-f737-41eb-8b01-42dd843ff10b"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("74926611-11cc-4e9a-af4f-01dc2dddb508"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("8fe76eb8-28a6-40db-b901-4e3c26e67d0f"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("afb5e519-0cca-40b6-a22e-489abf892615"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("b1648b95-b6ef-4f21-aba3-3c33733b7ddb"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("eed690a3-1fea-4b2c-85a6-279d97b9e3a9"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("f4499005-6f36-4cb0-b007-2df5ba444d20"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("fc55162f-50da-459f-a749-070f59007ca1"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("06346025-69fc-4f3c-9187-72eec757e013"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9558), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9556), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9555), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("29b4c7ca-d29f-4644-ad57-2b4a1230b298"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9489), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9488), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9487), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("5fc94119-40e5-4148-8ae6-1c004d4049ae"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9530), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9529), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9529), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8a89a88a-62b6-4595-b5d1-570b038123cc"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9542), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9541), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9541), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9872c06b-ed3c-41b1-95ad-094787c2d65a"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9536), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9535), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9535), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9ce26423-e037-414a-863a-5aa05115cd1a"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9521), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9521), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9520), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a1a9b211-8b81-4ae6-a64d-9eee74e58969"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9552), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9551), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9550), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a6816ea6-f50a-4e08-b70b-285722440e4d"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9513), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9512), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9512), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c1ef61ba-82b3-49e4-9dcf-a46f29ce5946"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9498), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9498), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9497), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d8e115ad-488e-4514-aea0-7a5a558429ee"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9505), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9504), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9504), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("009159ab-a31c-470c-85c7-8865b8e7bee7"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9230), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("0f0583f0-dbea-4e3f-b595-3c707359a862"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9239), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("12a4bd40-b49d-429e-8f7b-c32c5fb897f3"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9028), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("13e659d7-8eec-42fd-81c8-378e892edf50"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9320), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("2260ca02-6f4a-4964-8eb9-3ab88f3946ab"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9350), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("268cb74e-3f63-4896-b579-7af608bfa646"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8878), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("2d4348f3-74e1-45c0-ac48-fa9e0fd9a6a0"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8885), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("371c8769-2c53-4cb1-b1a2-d2d05f495eb9"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9309), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("3acd569a-59a8-4ced-888f-4cd41dcf5bb4"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8856), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("4930b830-1856-42df-97d8-2fa81cf40771"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8942), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4b0078b6-2140-43b2-99d2-11c6d19e12c4"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9248), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("4eaa8581-413a-4261-8a30-af0c6d7aadcc"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9153), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("52efdf1d-eeff-48e6-b705-b7c72665630e"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9280), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("56d60969-3b6a-41c9-8017-bf8a55b37393"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9179), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("57957ed9-103f-4dca-9e0b-7507d61bd688"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8998), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("5c94b5e8-fb57-45ab-b0b9-011c08eb57bf"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9209), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("5e96cc45-1956-4b63-80b5-5ab8bc233263"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9290), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("65cc90ea-b48b-4e53-a4f2-0de66a416e64"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9221), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("728060aa-1c94-43d4-afda-417e78184cd6"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8988), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("7280dea8-cec3-4224-8b50-33b920bdda72"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8870), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("7ac9445a-97a7-431c-b94f-c890fc812388"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9329), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("8567e67c-425f-4988-ab41-219a18b9cc5f"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9037), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("8c8558b0-aedf-439e-80a9-52abc75b2e2d"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9359), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("9151a7ef-2d9e-4c1b-a341-643ccfba9b55"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9047), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("953f5062-3c7b-4e69-82fe-3abd67fe1f12"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8931), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("980e5c5a-d306-49bd-9f50-8606d678cbf2"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9017), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("9c95b1bf-d0e5-4674-a9ff-5ce615a8e99f"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9260), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("a9ea1b3b-3cce-4383-a628-66ab85ecfaaf"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8920), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("b3b2d48c-b5a8-4e14-8afb-8ab90712c96a"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9341), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("c11322f6-57d7-4133-bd62-e73677966278"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9367), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("c9a87ced-f0ac-4b82-8d07-f8c1694b0a02"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9165), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("d59a50ac-1f70-48eb-9359-ef565f7a01f2"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8976), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("d8920774-14ec-4a35-bc37-4f783c272497"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9200), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f1aeb1d3-f043-4bf0-a4ff-e7958a05ecd3"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9300), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("f3a9cac6-d117-42f3-962b-42ad6afc1ef3"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9188), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("fc1da91d-c79f-48da-afa4-ead54d207c1d"), null, new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9269), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3707), new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3721), new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3729), new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3736), new DateTime(2025, 4, 18, 19, 30, 0, 395, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 18, 19, 30, 0, 390, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("048cf597-4ebc-4d68-af4d-c50126cf1a19"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9836), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("30b51142-e1b4-4c12-80ff-0c31b524c3dc"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9830), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("5620a29e-acc8-4137-9552-aff820f800b4"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9808), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("61022523-1518-46ab-8428-e49d4dbd8fcf"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9823), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("711e0efc-a4c0-4191-9048-b77a5d0db204"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9816), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("8ea941ee-5786-4c5e-b245-cdfc2c7ba846"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9828), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("903b6a11-f9ca-46d2-a4aa-06c618a42d56"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9805), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("c49be7eb-4d75-4842-8cd3-638b8fc0c8db"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9818), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("d0690597-a92b-42d9-a503-621b5f6e898c"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9834), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("ef8203e6-23ee-422b-b26f-9d69ff19f861"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9821), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("f0c79a18-987d-40db-97ef-32f1a9cfd8e5"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9813), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("ffe670ea-0e95-4942-bfa9-2e121fc4c811"), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9825), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9717), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9706), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9731), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9726), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9712), new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 19, 2, 30, 0, 390, DateTimeKind.Local).AddTicks(9695));
        }
    }
}
