using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0fc57cf9-93ca-4e7f-869e-68f44df6640e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("1ecf5bf4-adbf-458f-8969-0407074cdab3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2c55632f-9892-43d0-a932-7f46b2dea623"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("392f57aa-f3b8-45b3-bb71-249f0292972b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("54b70e67-717e-436c-a7d0-3456e950fa6f"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6865d9c8-04d2-49bf-ba13-be7c7fe60774"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6bf560df-d80f-4726-9402-656c91328426"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("77e37193-c9c3-44a7-8469-c56160022a01"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8346cb77-8b9a-4a01-a904-11567b85b51b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c7899334-9773-49af-b550-1c342e5c2b30"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("db21751a-5940-43b7-aa85-2f9a972549f3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("dba73c96-908a-4a67-96c7-23ff4d9695a4"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("2a47ab42-ba8b-4280-b9b3-d542040ea5d1"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("2c76aaa7-df4b-40ce-8435-cc19ef3b2bed"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("4156796c-ece1-4f41-a23c-2f65486f75dc"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("4644c8af-a3df-4b6f-bfda-07e174d136e8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("655af6ed-b84a-4675-83e9-71e4daf6ba03"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("7147b240-dd78-4bf7-a37c-6618bab92580"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("752e11ee-dc1e-4eb7-a0b7-04c1f239e748"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("9c953098-9e2f-409f-bd06-a6a87d1fb2bb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("cfef9894-112a-43ce-9e23-d5e1c9a07a99"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d151f02a-9422-498b-b870-6e42c7737cae"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0133b1a4-c9b3-4cd4-9720-556058025f51"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("014078df-2a58-4345-8b78-a842a9b1c919"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0436ca5f-4927-4ca5-9766-00b87d0442a2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0c33fa27-6eff-4748-a44e-f9e7e34f97ff"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0c520f6d-66b7-4eb0-949b-1bd1bf4c8cc9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0efa6351-3285-4fb3-8bbc-f1109bbfece0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("13c7bda1-1dc6-41c6-927a-6fdb77961ac9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("14bcbf82-83fe-46a3-9a66-6299a29d7851"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2d8a9832-c764-437c-b7c5-68e2a83dea79"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3102931b-0e65-4b1b-adfa-11a1d7517b3d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("319ff1d6-f820-49b5-bb46-99dfab7c5933"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("31ac15df-f493-43d6-bbff-649abca5753f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3e755b9c-4c3d-461d-b2d4-c5c801a5761f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("46c32b18-4cb3-4d78-99a5-2da3cd5cd579"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5e346f65-efed-4bd1-a59d-d5ce2c36ba92"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5fdf59df-3b52-48a4-b78c-e85513822fe4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("699cb91c-5f91-4b76-a9bc-a1518cba93f6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6b39cf70-5dd0-418a-ad78-9a65092090a4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6f9a1c39-c14d-4e4f-a50f-135c85c98916"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("753889ea-1e23-45d3-92a6-2fcc0d16fd60"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("799bfe78-8d8b-49b3-a88e-5d8f4d263f98"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8b8724e6-880e-4e0d-b372-62c01f5bcaa7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8d7a9972-9a81-4106-946c-1a3374cede4a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("901c7060-e448-4c75-924f-c6a64d41f7a1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9238eeac-ba84-4f69-9a88-f917261281a0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a93cf402-2112-4e81-8d3e-706928ebb256"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("abbe2bd3-27a4-4255-a219-8d567b1bce0f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b8f87bff-9f98-4bf0-bfe9-5dd8980e1c18"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c140759b-2f84-4774-aa6e-53a24cc856cd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c4f40b9e-ca3c-46c3-8a74-9219782f7e2f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ca33f6da-8d6e-49eb-bd1b-0f01b5adf840"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d0a90dc5-365e-45c1-8758-e60465ea39fa"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("dd33dd58-fff3-4ccd-ac8d-9d527c0d4d69"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e6f2a772-f99e-4641-8279-a7d3986e719b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ed9070a0-a397-407c-a26e-670eaea5a5e2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f6dc9f1f-d432-4831-b967-bd67f0928997"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0719b637-bd9c-4ef8-8af8-c3dfebda7200"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("09667e73-ac88-4f40-98b9-d28a405a9670"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("58b6350c-7d2f-4dd0-b2f6-935c78ec5016"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5df345a7-e468-4e8f-83da-2ba74de0ab89"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6a43117a-8661-4a7f-a9ed-39d368e7f114"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("79d56aa2-71a1-4984-8f82-bb3a344087be"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7d216fe4-27f1-4e43-956a-2254f576d926"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7dbd3b90-11dd-4da1-b5d2-d61da66f5766"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8b1bb6d9-902a-4c3d-a81c-69c3bf37a0a4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("974a4e24-3274-4011-8677-fbd506767288"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("cbffe7c3-b9cd-4d1e-8321-d28dad47eae1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e02719db-38c3-48a3-87b4-3b94e8b56025"));

            migrationBuilder.RenameColumn(
                name: "NumberOfPeople",
                table: "BookingAgriculturalTour",
                newName: "NumberOfAdults");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "AgriculturalTourPackage",
                newName: "PriceOfChildren");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfChildren",
                table: "BookingAgriculturalTour",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChildTicketAge",
                table: "AgriculturalTourPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceOfAdults",
                table: "AgriculturalTourPackage",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62cd8e6a-32c7-4871-b4f4-9495d568220c", "AQAAAAIAAYagAAAAEG5ldhFdnwPuzxpjvQkAEmzSfZYhg0Y/5Ma2Mcb4qZzVK3631GbF5TxOL3FYidDnYQ==", "c317662a-4488-48f8-a58b-3d4b713b2b97" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb3bae9-3efb-4b8f-9242-1fe1aba1aff4", "AQAAAAIAAYagAAAAEECRMQC6jiTwbbTmeF8xzW2nL48XXkWwKJnYV5khwuuO276lQE2tq1q39EIAzXNgYw==", "a6a61ae5-ad7d-42ac-9341-6026c8e975da" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "148e8f2c-4267-4ece-91ae-e51a45510895", "AQAAAAIAAYagAAAAEOHHJincuZM7Q1RBJ9GfKLUo2BpX9+t2sCgLj4938pA335eV+WlVNq8aSNQoNppFJw==", "28e8b1b8-9af7-4e79-8243-0dc772ae4f97" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c61c39bb-3785-45aa-bbb0-6434f78ba4c4", "AQAAAAIAAYagAAAAECyHbwMezIoaKTYv3eWhKOuyHGdr22BcwfqYjVh7b5HQz/Ej7RklOHxwp0smsFaNIg==", "671b6473-e6e5-4d97-af01-b0fb489322c9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6219e8-595c-4940-8a08-abdfc3539ba1", "AQAAAAIAAYagAAAAEJexPKX1wJGqU7xYjJyHPO9BA6n4N0x4gi4Lu1SwL91ScgFcz5PueQszh/XjeerhyA==", "7f54703d-b75d-49d7-8e57-f595af9acac0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5669f381-e175-4291-bd6b-2d8cf5d28855", "AQAAAAIAAYagAAAAEKBpoE18ZofL40iHmSJyYhOqHijEiHETwSVPWLquHVt5lXT1NleKSwjnsMFfhRh6uw==", "e6756a4b-8240-4c93-a86a-a17146084740" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9471169f-c5f3-4bb6-86a1-652b76ef0fa4", "AQAAAAIAAYagAAAAEMkq3sUgtgOONhoVa+5qLcK4SMz11U1VU0GKyjY1nxQuYPwT0m04Nk9MeF6OCQn+XQ==", "a3f8aa4e-b9d7-4c28-bed8-67af39f44e9d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a754567a-001f-4f20-9f81-cea54e607777", "AQAAAAIAAYagAAAAEEtfYNR3WG/XitJLsnMBT0U4rguuZFn3+hKTD0m5e+p3xoTuBxWHLISFjlLl7QkPEg==", "a17a4078-75a3-4969-b28b-e933044d9493" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6584647-2e41-412c-b4d7-3a070137a764", "AQAAAAIAAYagAAAAEA0EV6EyXrO6j2gQbklwtYcXI+09To7aZKKMgkoS0hBMzV55MjgSCURXx/9mZ5lC5A==", "06b47a43-158f-424d-a11e-a3b98b48e05a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e8957f9-d2de-480f-ab1b-3d543712d8d3", "AQAAAAIAAYagAAAAELThjKwI3L/nAeec4lEC/3Wi966R1Uviu2X4yvscKJt5kHjxKXo3e2LD9+B6emcoNw==", "0dea7793-e0be-441c-89d7-8bef2c789a1b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "588bd3d3-14f8-4da7-bd99-991661b6c08e", "AQAAAAIAAYagAAAAENhmDWsoLrBxRd8gfIUed1SAzvMUf6tmVcqu5HyIhwnhOhiaZmtZpcvDTmZbe7tMDA==", "f63ecdd4-e234-4951-92bb-042c18940c3a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f967440d-4dda-41d6-a153-4538b72c5f1e", "AQAAAAIAAYagAAAAEMPdgEnFoNg5PGWKmizg3p0bXSxplMYL2mFWgydxOesZCyURquhOHb0bppvOTPHDow==", "3292dbd0-75b3-42c3-84eb-e61ca27982b7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d8c750-1586-4787-b29e-b5e3f2daf777", "AQAAAAIAAYagAAAAEAphan9paDqIwgQIwt2Oib+m5ikcH5ndsSwYLF9JvOGWHWjJH9xVQGAk32e+Q70QkQ==", "0858aa56-4c52-453e-85bc-40a2d4363f09" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b229f8dc-a0ca-4316-a8ff-a48ba40de6de", "AQAAAAIAAYagAAAAEI13NkwPHjdGRADlCr5Fx3gs+E+yTcuoQ8trhmhhaNSv4fG6UxQ8yFEjCl0kziJY1A==", "309f1088-286f-41ec-9dd6-137317a4bd25" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6717d5f-366f-4d93-923f-ca728eaaaff2", "AQAAAAIAAYagAAAAENA0dVbjc/6n4WVWXGCgLKRhcE2Zwm2uu7nej2MN3lVGwTL7lsgtEKdZvibxLmqVJw==", "c8bbb6a2-45ca-434a-b13d-93c04b4a54a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed2437a-09d0-48a1-b044-e8f92f9634f5", "AQAAAAIAAYagAAAAENi2xVZcKrl4tx+WfVcPgyEnBMKMoURouoGGEmjFs9p+H3WvEjc/cfYHInk1X+EP5Q==", "9a1afc3e-96cd-48c9-b00f-630d57ea683c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be06514f-a003-4586-8126-2701bebdf9eb", "AQAAAAIAAYagAAAAEJeRcXEl+2obfGs/78jtlXEDcUOSKDF79nePK29N4He/DwatTvIWwp21SMDVT6L0sg==", "bf42371e-f242-434b-8a76-d22fb1e0049d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa6055ad-5ed0-4e35-b4f4-45c2ac24be5a", "AQAAAAIAAYagAAAAEOzNSLVTHPrDl1YzBd22MJuGwXv5t0bx/XQ0CHe38oCPkYcYaZij4CC+uYOaUrtMYg==", "811bb5c5-270b-448f-b8ca-53f935b5fe46" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08d54f4-9c09-4b5a-8c9d-d794e6420670", "AQAAAAIAAYagAAAAEKun4xnYZJtQSPcoriSztoeZQp8ho+DS+AtvjHaQHPgCEI4ASpA7ORH7Qnc/kbb8rg==", "39199e07-85dd-47b9-9ce6-50678f65e4d2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3126a10d-2433-4290-9e4a-a1d6aff3c6c6", "AQAAAAIAAYagAAAAEIPDYOU1232iBygcZ8OoCUsHhWPIPELlQZmh+eqNGGfjl4+uTUwYQCi/fyR/rAK+Fw==", "601517bd-1386-4ee7-9e15-a048468fb9af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897ff568-1ddd-431c-a0c0-25004f4d1f14", "AQAAAAIAAYagAAAAEM4HBGb52nCPtSqui85n25gyHBzRSj+T4ShE1Bwwkp5qJ/pkWCNd9PnOyht+5m49yg==", "ef138d40-9b11-413d-9472-90f08aa39afb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba9971ef-8582-4f11-b9b6-5954fe74f044", "AQAAAAIAAYagAAAAEFtivFs/HEUo8uVFtn3QbzoetKJCICC2/h3qGJTHxior+iFffY1Kws5KMgjs6LW53g==", "665bf298-2e6e-4b34-a45e-79d3b4df3b64" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ad805a7-aaec-4302-adfa-ffedf8f73c9b", "AQAAAAIAAYagAAAAEP8U5LslzdpGnfX1O0ntqfTmtV7u1Z+EXQQGsF2Bo+WtZ1XgRO5eZadNE/xbc+udWA==", "728cad4f-ad2d-4312-b29d-0a37fe391c66" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1039ca02-41d6-44fa-a57f-5d52d23ddf3d", "AQAAAAIAAYagAAAAEKfJuRqAfUU8+9kgCSjxvg/pyzLwggNrumqYA/UkzBUdcH+pz46U3tejq8KcC7M3Pg==", "39fd7b12-bad6-40fc-ba95-373054f26fee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47a1d9d5-2b0a-46c3-b670-df6ba3e307bc", "AQAAAAIAAYagAAAAEOussuT6S+Cd1LBxrVhEyOncMMznmZ6SVd48hF6QAU5IQlvtR1Sdov8F0YdG69UYEA==", "ea12d408-3820-4ac8-8471-da06dff6e7b1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccbdaa43-7793-42fa-9068-5390fed5f19c", "AQAAAAIAAYagAAAAELG6DrLEuYexgCRceWyrT2jeuQhGJqzDJdo5xzRUphCKdI+0OFyQ+0oDBycfHqRmDQ==", "62db0807-acb2-4db0-98f0-be2bc9a46806" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8b2802-f871-4680-a007-5c0ea7c4b5a5", "AQAAAAIAAYagAAAAEKVPAAFtw/R78XgFUrKNxgdvk4aP7jPs7DDsV9oT+DxRFQfWoy5D8kkwMoVbeguVkg==", "3b45fa9c-08e2-42f9-b7c1-b2adeaf3985a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa6a87c1-7ea5-4fad-b0c1-798807a49626", "AQAAAAIAAYagAAAAEM/2OpJoVAokDxyTeD74+3oXl4z1ZJoQa5VdXpip+EgpLXGdTd205aD3kVtwIIYEtg==", "ab3f3b8c-0c3d-4511-a8ab-525d62da297f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b903460-213b-4270-bc5e-ea7ed871cabc", "AQAAAAIAAYagAAAAEBvKIYZHIKywf/CkDPNy2e00fyodUCrdYFO/uCgi8EtVYeg2URlo0ouxSXtue7N0Dw==", "03a3d8d7-46d8-4d72-a392-6d6562107152" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d95e4ad-c58d-45a2-b51c-e17875e5ea1a", "AQAAAAIAAYagAAAAEAZSZdOdNo4zNHMu9nrA4W7nzqWkWCDZsi/ysGgKqGS/WIKpXTxZ6IePI3mQR+lCqw==", "416ef676-7d21-4f83-bc33-9d480d793a19" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2653371c-e53c-45a8-8c5e-c900b6e24ce1", "AQAAAAIAAYagAAAAEOYZersyyBfvSBoyYagXXLOXw9mToevqyGvleyTODZi2uMBO7el0uPgW6geUADa4ew==", "a0579017-f75d-4ad4-9fb6-9afeab45fbc0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b459bd-d17b-4405-87eb-322ce56d4d05", "AQAAAAIAAYagAAAAEBF+Us2htDodOeKjW1nYl+MMNDliuWbTQw/gUyw/VgrvzvbvY2VdH8jAbo5xV825JQ==", "653022c0-3f96-489c-90d5-ce110b46b9ad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d795f0d8-579f-4ba5-bd80-dfd02413cc5f", "AQAAAAIAAYagAAAAEDMksb0Lu+clPA2Q87FJnc3+6zYsYffm9Mt/nG1mJnzOyrC/ngdebUPdKUqnttJ3dA==", "c9dca7f7-396b-429b-a3db-1acfca9ab098" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b471bb19-a51e-491b-9c03-ec1f3bd9a653", "AQAAAAIAAYagAAAAEM8LAQdAUJ+kspvWH/c3+Uzn62J0GhgrBQkGoeOO4p5Ssn62xHPDlKAa3a5GIVJbrw==", "a12cff6a-7e5c-42e2-8adc-9c754d701ea9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab982409-6fa3-4b9a-9a29-07941c6cdcf8", "AQAAAAIAAYagAAAAEGQuS39iZ1H+VVgBKbYgdrzS2KjMpbJ0r5PvBjpeme7vKi7PKdePDgpM0+h4Y+PQtQ==", "f1e00e96-8777-4e48-8714-2cc446c09ffa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3300097f-7d7a-49fa-a183-f24202d6158c", "AQAAAAIAAYagAAAAEAa1RCsf36l1xnmBgrSVQchbwmMkKjFaPFSHL7vyGMb59zisvxmbw2nFjyxDr6Vn8Q==", "284e375c-fa32-45c3-b869-7ea033fdfaeb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "695a0f78-52b2-469d-9fc1-0bfeae0c16e9", "AQAAAAIAAYagAAAAEOSTWaa3cSpQlKl/ybIfaFoUW2LP+CvZWiyF81CePLOeGW8voezHNqLM2SmU1NwJYA==", "c180b2c1-02d2-4785-a1a3-bed0e20066c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88492b0f-5e61-4cea-9857-75737b367797", "AQAAAAIAAYagAAAAELFqGMb4eHD4KBTh5FZovESfl7SuzFCTVN6kY6zdnZgGcNqupQMIXQX3Vh54MghPuA==", "4cabb0f1-80af-4f72-9fdb-ff7e175be9cf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "350304c0-33ed-433e-9963-89452cf45719", "AQAAAAIAAYagAAAAEGgK/LBEPoseZl2OqOF0MwHyT/Ab/QTnRppL4SgtBjbUnl/aPBm3kOup1uV1FnGW2g==", "5b7ee919-8ce7-4837-8863-efc06fac2157" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff4125c6-04be-4d20-a460-2f9650953f54", "AQAAAAIAAYagAAAAECFRba2XiJp0Nq0qFw6vPZrlsV4z+Fx+a0gh9rqHajx9zVpdWP6IOhO+6oC8Hva19w==", "86f631ae-f402-4325-b02c-72596c4b6e8a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a65caef-3c02-4e85-8a34-62b53d255b82", "AQAAAAIAAYagAAAAEA0J8IC/zH3eemBkFB+RieR0YGVLm4iMGfkPrGLJ87p+eF9QRRZlLwIzL/IauVqO3Q==", "900265e3-9eaf-4f0c-9ea8-6628d498a132" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f44e89b-cb63-4fc4-8e56-4d27dd3992d8", "AQAAAAIAAYagAAAAEOH3WwaUuufdkG6P+tLdZ011P8/nULgBPPC7PU8vcNzWBU+5gxlpogXKcxfWYF5jVQ==", "4e952bc0-bc4b-421c-b808-fe5bb4f13d9e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9f323b-85a3-4e2a-9139-503a0e10e3c0", "AQAAAAIAAYagAAAAEPPCe69sV59MlLISbEMJFFwLjE3i927uxqGLRqmGBjOjibUQ5ECPM2ZInHo20SJWzA==", "2ce0095b-91ab-4589-97ba-d4a424b341b6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfffe263-2ecb-4aa1-90bf-1ae34157b193", "AQAAAAIAAYagAAAAEIrnH7ocblhUikr/P4Buj/Jrjedd5xvJxyBMBwAgMnhvuwogGqihGpFkbxxtrWNnxw==", "91adf648-71c4-4eb6-8952-dd271d78089c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ddcbb7-a75e-45ef-aa39-db16c288f6e0", "AQAAAAIAAYagAAAAEOXXMWFR66E0CkqoiJqP8k66A5xJES8qzdEGyT3uxzlWPocrlBdI9OS1jPMHOqepUQ==", "96f218af-b773-43b2-bad2-71755389fb54" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72bc5957-134d-4a0f-946e-f1681a6aa9ed", "AQAAAAIAAYagAAAAEJK9dFk3iNM1eAigVqVd76Htd6a0JHS4XwAx3pNf7Ml68A3ghUkRaTzAjQtPb8PUOQ==", "527ed350-2025-44b5-88f1-fb7bb7c55f71" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86cfadc5-bf15-4b3e-8e89-c9ec9802baf2", "AQAAAAIAAYagAAAAEEkhBwi0BCwjXLzDGzMQIncH++QT3HGmxYXX5+K5+12iWZrvyORLsymvS+jATNES0w==", "ce2af446-432d-4512-bbf4-ab5f903375eb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15c9efe5-887e-4cce-9b8a-e7cfc839c24a", "AQAAAAIAAYagAAAAEJWtr+dePWRjNaGnvCLLNh0mej1mUkwnm6BHzsYNjtW+/OZ2gBCvakMI040LEtVh0A==", "238d1730-b39e-48ff-9a07-6712b3187763" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "670b3679-826b-4e88-86c8-385e74be3c23", "AQAAAAIAAYagAAAAEIsXJXCoDpxLxYwsfD0edmDy13dgNSHtWQ8gETRG/S+UOof3nqqQv9usr3VA4ua1Ww==", "f656dd08-27da-49c4-b951-f9582233baed" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606fd621-f37b-45e2-8e8e-d9fb140df1af", "AQAAAAIAAYagAAAAEFrqF5XKZjQJR6gZIr96SVbXSxY4NvLtrK2daEuszQaf9EUlfM9TsJrBc7vs9Gd59Q==", "6c398861-f8ad-4e26-a934-29399dcd844c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6246b60d-43f1-43c9-bd6e-265d50b2edb4", "AQAAAAIAAYagAAAAEIetD0SiT15OS49AoaMWomtij8Omg/Q8Nhdoaki7qu96LCdrXqgRQYj9/KY0Df4wJQ==", "fa8be899-b8c9-4daf-826f-e485a0b4f956" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74de33f7-5e45-4a80-a3cb-089919358a6f", "AQAAAAIAAYagAAAAEDvzVD4wxcdCdFZo4RwFXVRZji+hVDayWMMGVGKgHTqo2dDuBcdQjXDF4UMQkaklQA==", "bf8abdae-d56b-4b7b-b723-38a4fda258a6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80691c7d-fc05-40b3-91aa-137b2f0163bc", "AQAAAAIAAYagAAAAEOry7kx/9StaoN4+jkXZJYG0VSxnHUWz6ATECfY451U1jDo2a7D/pfioYTiLOdTeeg==", "ee94217e-1eb2-4d40-bd26-4d1fdb54e2ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e4a3ea0-4180-4a76-865d-5be694f094d7", "AQAAAAIAAYagAAAAENdZgUyo+SSh9Oyb6dMnyaok39LpP71MOnSgk4hyNZKMOiLur6l+ALmCJM9EvKFl1w==", "ec8e35d4-0291-46b6-88bb-7ee5ab131324" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa076b46-27fd-41fb-9e07-d63cd79e3ef4", "AQAAAAIAAYagAAAAEJmaQJqlCidTEPj5oW5Yso0WT5Kuk4fn0NqeVRRTBZhMfV0TIZh5QxZ6bfGmI63O0A==", "4cb84cba-4666-4a52-8533-09a1e5339837" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df55e035-6f4d-4e98-be28-f6bcc21985e8", "AQAAAAIAAYagAAAAECcRTQrP4Ssw9U2wa9Vc0WambB4oKwJwNI9phK9eM2UfGETOCRHGFdvevQfHnrcxxQ==", "7a8dd489-934e-477b-8121-881cbcab3825" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7bd4699-b2df-47eb-b3ac-2826b6bb8b5b", "AQAAAAIAAYagAAAAEMwnGyhOUrxKd0jV8ALgHGayI9jAspINf+qOGABCffi3HIu6MJ0YPahaNV+R3K+5NQ==", "1f20b4b4-3ce4-4384-a48c-63f8eda6f5f7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd40a71c-3e22-434d-9c12-bcae16312dbc", "AQAAAAIAAYagAAAAEDNTh1jYj7ntedepRVCo/rhg93givk0ubWRFXheS/eyLnLAquccn4+88uwd4hVJAHQ==", "f40e69bf-139c-426d-9023-ac55c8b8b1e3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49783e08-1bf9-41fd-be5a-f04d628e5ba9", "AQAAAAIAAYagAAAAEGKnkaBelQVi5Lc/hCQKFpVsE0F+JVKLYMzZulFKCQlXs5KyaAT9VK06VDP7Mayx5A==", "d6839c9b-b46f-452d-93ec-7dcda2fe4a68" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23941f34-3622-45d1-9397-3338b452be65", "AQAAAAIAAYagAAAAEOzMjylg1zga2lPY6unH0mIBuaq8UaLeDPfQFbCccjye1lrIWkcs26EukxK6inCA3w==", "42cbcb85-f37f-4fc5-806e-f5d7a8df17ea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "141a005f-7ed6-4d5c-8c56-2b5343c3a19a", "AQAAAAIAAYagAAAAEAHDxVkfuM1fGoXsIzzZL/lMoiymf0RemkphKYc7iJVClS88RJRUx7UwsC1oMEttVw==", "4a1ba3f8-b589-4d40-8e72-1181f6b5f6da" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8186f663-dc89-484d-ac7b-aa0724bc1042", "AQAAAAIAAYagAAAAELE4nG3CC2TOjkZu1G36mIVkDxfV0MBNik6VFfe2fLKlU8dIokImcoKp+5TD6Ma1tQ==", "efbcc838-c5aa-458c-bf9e-708212030ca2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c400d24-c45f-4d0c-a44c-7cc58ffa4888", "AQAAAAIAAYagAAAAEK65N4YwNz+r830YiBqLZPquoyttFDbb2zTCDEQ6JuiEQchURROyAopAAZfYjop+WQ==", "ad6b9015-24a1-4f42-b917-c176718c33c4" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2241), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2249), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2256), 1500000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2263), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2270), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2280), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2186), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2226), 1500000.0, 1200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2199), 1500000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                columns: new[] { "ChildTicketAge", "CreateDate", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { null, new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2235), 1500000.0, 1200000.0 });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("019760ba-dbbf-4250-aabd-a0bd8590d2b8"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("037ef427-9792-4118-bf6e-92eadf1b8fd0"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("077497e5-f7ea-4919-b637-6ac5f6ca89e6"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("199818e7-6e57-427d-b62f-2cbf8585e253"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("243095b2-4566-4e93-b879-05af76454a47"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("6f7ee619-e0d1-438b-bad6-954c623a896e"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("84660007-17ba-466c-82d7-e84665af96ca"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("9c929ca0-4764-4980-bb6c-1c41a222c747"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("b7dce607-3107-46bc-8169-9eb0c123bd1d"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("d40f8bc9-c679-4b1e-b373-bc1de1e39cbe"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("d6834a70-60a9-4407-9c84-2ef7c9a5438c"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("f53764a6-d8c5-4c34-9f8a-26f5d2fd4749"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("06b5d012-7b37-4220-84ef-6e5cfa449a85"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(256), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(255), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(255), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("07226ed8-f7b9-46b7-abc5-9ac25da1400a"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(273), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(272), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3354b3ca-1c0b-4a13-afc7-5c87744331a7"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(203), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(201), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(195), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("548a47f2-d890-4499-9e71-7c0469a8d3b3"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(237), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(237), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("62f0a319-73c8-445a-ac96-b92d9f720a49"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(265), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(264), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(264), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("87692bdb-8993-48f6-abbf-2d9155502a82"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(229), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(228), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(227), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ab7822e6-d3b3-4940-a3d0-95ae67d13333"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(282), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(281), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(280), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d493dd37-88ef-416c-a8ad-01aaf69adca0"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(247), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(246), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(246), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f2e2a1c2-36bd-4784-ad5d-ea481f378229"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(299), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(297), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(296), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f79aa301-3e45-45b5-99a1-934718d8c997"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(291), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(290), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("01852ecd-efe1-414c-b087-cbdec06f2f87"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9833), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("02c92036-a6d0-4370-9eb6-c3a285f1102f"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(9), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("16e541f2-8f5e-44d7-af70-91edd2af2ebc"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9901), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1b541707-7bbd-4235-b794-2d2e9f6a822b"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9868), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("20b29f16-2080-4e93-ad06-930cc1bf10da"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9923), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("254241ab-02e9-4f82-a3c4-089aeab79049"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9670), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("2687f384-576a-4d6f-a1e5-842268d28d45"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9943), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("2bef3923-dc48-414c-8fdb-18dd98965273"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9975), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("334126e0-a88d-4b1f-82db-4e1e4909ce03"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9748), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("3b06b84d-86ad-4e09-bc85-56324b234eab"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(72), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("49a10fc7-c2e2-497d-bcdd-bacfcfb488e7"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9878), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("5b6247e0-1f3f-4e72-ab13-92d89c89a24e"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9999), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("5b683eee-7fcd-4bca-9e19-b42ffce21984"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9630), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("5cd4e388-bc0d-400e-92de-7a9dfe0c0b51"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9713), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("6560231f-e9ba-4543-bdbc-fa99685fe42c"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9986), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("675ef149-9963-4868-874e-285a6739a2c4"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9693), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("827af279-88b0-4b61-819c-48d584192286"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8819), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("8b6e0f37-c02c-4800-a922-48b68a842a56"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(61), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("9bd78207-2ada-459b-b004-1e3f900b5038"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9912), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("9ecb75cc-1893-49dd-8b5e-7685fc3e341d"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(41), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("a75f6b5a-07b1-4775-bcb3-784295ce1665"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(20), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("ab235243-29db-4c9f-aec9-b6453b962970"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9563), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("ba122e7a-3e06-4a26-a85c-eb996ef80891"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9846), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("bbad5e96-8d7e-4268-8ee7-29203694f3b2"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9933), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("bd99ac01-2184-4075-a1aa-5a8f8cc8d886"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9682), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("d900dd6c-efa8-437f-b523-47869e0a6416"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9857), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("deecbcc5-7f8c-492d-b259-751c61fc61a7"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9888), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f0881a32-7e40-44f4-9e7a-abc58beaa79f"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9723), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("f0ffb237-a265-4527-bb2b-47c23f5c5a83"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8857), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("f2f3b2e0-1911-4c7e-b246-22a83a98233e"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8834), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("f3e4c3a2-b897-40f5-988b-a591bfe35a5b"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8846), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("f4e10851-b497-4d25-aee3-be611b7426ec"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9965), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("f7a31e2c-7fd3-43a3-b700-db5f83c351a4"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(30), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("f9976a47-e05a-4ba3-929a-51bdf3071e0d"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9611), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("faa2fb39-7136-42b1-81f8-ae851eda4384"), new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(51), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("ff19882a-f857-4480-bb6c-b6befa12c7de"), new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(9737), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 455, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2338), new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2359), new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2370), new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2380), new DateTime(2025, 4, 13, 8, 12, 6, 459, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 8, 12, 6, 456, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 455, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f87d8f9-a546-4f76-addf-19915fe75277"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(436), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("13ebe374-8566-4836-9d52-c7de5a0483bb"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(440), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("4853cb7f-16d9-4832-b83f-00cbdcab34f1"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(476), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("5fd5ff3b-c98c-4ca1-8e96-331d33b29012"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(444), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("7686a654-df77-4e00-b991-9f9b877504c5"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(467), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("7b429633-ac06-4a7b-a959-bf1a61557855"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(482), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("7c50d570-21da-4961-abfb-f5736354454e"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(447), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("7cb7e77b-54ab-4325-8804-9ef021824d2b"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(450), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("945f844f-d87f-4c3a-aa05-63c31bffe862"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(454), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("c5a45bc1-0c8d-47f7-85aa-a9f418e711e0"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(479), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("c5ed0625-36bc-4184-868f-5de1f348944b"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(470), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("f47d2ef7-6f59-4352-990e-969f5f36b7a0"), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(473), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(384), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(369), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(395), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(390), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(378), new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 13, 15, 12, 6, 456, DateTimeKind.Local).AddTicks(355));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("019760ba-dbbf-4250-aabd-a0bd8590d2b8"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("037ef427-9792-4118-bf6e-92eadf1b8fd0"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("077497e5-f7ea-4919-b637-6ac5f6ca89e6"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("199818e7-6e57-427d-b62f-2cbf8585e253"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("243095b2-4566-4e93-b879-05af76454a47"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6f7ee619-e0d1-438b-bad6-954c623a896e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("84660007-17ba-466c-82d7-e84665af96ca"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("9c929ca0-4764-4980-bb6c-1c41a222c747"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b7dce607-3107-46bc-8169-9eb0c123bd1d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d40f8bc9-c679-4b1e-b373-bc1de1e39cbe"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d6834a70-60a9-4407-9c84-2ef7c9a5438c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f53764a6-d8c5-4c34-9f8a-26f5d2fd4749"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("06b5d012-7b37-4220-84ef-6e5cfa449a85"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("07226ed8-f7b9-46b7-abc5-9ac25da1400a"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3354b3ca-1c0b-4a13-afc7-5c87744331a7"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("548a47f2-d890-4499-9e71-7c0469a8d3b3"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("62f0a319-73c8-445a-ac96-b92d9f720a49"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("87692bdb-8993-48f6-abbf-2d9155502a82"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ab7822e6-d3b3-4940-a3d0-95ae67d13333"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d493dd37-88ef-416c-a8ad-01aaf69adca0"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("f2e2a1c2-36bd-4784-ad5d-ea481f378229"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("f79aa301-3e45-45b5-99a1-934718d8c997"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("01852ecd-efe1-414c-b087-cbdec06f2f87"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("02c92036-a6d0-4370-9eb6-c3a285f1102f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("16e541f2-8f5e-44d7-af70-91edd2af2ebc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1b541707-7bbd-4235-b794-2d2e9f6a822b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("20b29f16-2080-4e93-ad06-930cc1bf10da"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("254241ab-02e9-4f82-a3c4-089aeab79049"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2687f384-576a-4d6f-a1e5-842268d28d45"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2bef3923-dc48-414c-8fdb-18dd98965273"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("334126e0-a88d-4b1f-82db-4e1e4909ce03"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3b06b84d-86ad-4e09-bc85-56324b234eab"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("49a10fc7-c2e2-497d-bcdd-bacfcfb488e7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5b6247e0-1f3f-4e72-ab13-92d89c89a24e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5b683eee-7fcd-4bca-9e19-b42ffce21984"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5cd4e388-bc0d-400e-92de-7a9dfe0c0b51"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6560231f-e9ba-4543-bdbc-fa99685fe42c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("675ef149-9963-4868-874e-285a6739a2c4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("827af279-88b0-4b61-819c-48d584192286"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8b6e0f37-c02c-4800-a922-48b68a842a56"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9bd78207-2ada-459b-b004-1e3f900b5038"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9ecb75cc-1893-49dd-8b5e-7685fc3e341d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a75f6b5a-07b1-4775-bcb3-784295ce1665"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ab235243-29db-4c9f-aec9-b6453b962970"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ba122e7a-3e06-4a26-a85c-eb996ef80891"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bbad5e96-8d7e-4268-8ee7-29203694f3b2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bd99ac01-2184-4075-a1aa-5a8f8cc8d886"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d900dd6c-efa8-437f-b523-47869e0a6416"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("deecbcc5-7f8c-492d-b259-751c61fc61a7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f0881a32-7e40-44f4-9e7a-abc58beaa79f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f0ffb237-a265-4527-bb2b-47c23f5c5a83"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f2f3b2e0-1911-4c7e-b246-22a83a98233e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f3e4c3a2-b897-40f5-988b-a591bfe35a5b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f4e10851-b497-4d25-aee3-be611b7426ec"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f7a31e2c-7fd3-43a3-b700-db5f83c351a4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f9976a47-e05a-4ba3-929a-51bdf3071e0d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("faa2fb39-7136-42b1-81f8-ae851eda4384"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ff19882a-f857-4480-bb6c-b6befa12c7de"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0f87d8f9-a546-4f76-addf-19915fe75277"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("13ebe374-8566-4836-9d52-c7de5a0483bb"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4853cb7f-16d9-4832-b83f-00cbdcab34f1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5fd5ff3b-c98c-4ca1-8e96-331d33b29012"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7686a654-df77-4e00-b991-9f9b877504c5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7b429633-ac06-4a7b-a959-bf1a61557855"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7c50d570-21da-4961-abfb-f5736354454e"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7cb7e77b-54ab-4325-8804-9ef021824d2b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("945f844f-d87f-4c3a-aa05-63c31bffe862"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c5a45bc1-0c8d-47f7-85aa-a9f418e711e0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c5ed0625-36bc-4184-868f-5de1f348944b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f47d2ef7-6f59-4352-990e-969f5f36b7a0"));

            migrationBuilder.DropColumn(
                name: "NumberOfChildren",
                table: "BookingAgriculturalTour");

            migrationBuilder.DropColumn(
                name: "ChildTicketAge",
                table: "AgriculturalTourPackage");

            migrationBuilder.DropColumn(
                name: "PriceOfAdults",
                table: "AgriculturalTourPackage");

            migrationBuilder.RenameColumn(
                name: "NumberOfAdults",
                table: "BookingAgriculturalTour",
                newName: "NumberOfPeople");

            migrationBuilder.RenameColumn(
                name: "PriceOfChildren",
                table: "AgriculturalTourPackage",
                newName: "Price");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64e07711-1f38-4c49-950e-1337a8b2cafe", "AQAAAAIAAYagAAAAEJhHwIYnLS5qW9wGGtyWfyaJfc7SVUsAPQlworpoVNNf9of5sLqXtWzGJqMqRI6gKw==", "839a7708-ba4f-49a3-b416-1bd7897aed72" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b9fafb-83d3-4710-b662-9861e89a6775", "AQAAAAIAAYagAAAAEEAAPcsKAy0aOgi6uYB6JoW6bBbSX01aWNBmFFTA6rBedeCjI3mcerySNd7nj1X4jQ==", "f2212114-cd39-4c19-b27f-d0bcab897e67" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03be34fe-6765-45bd-b5f3-a5427fcb8180", "AQAAAAIAAYagAAAAEM/QwMuNOZxGTzenc+/bAE9jdyh3XBww8NqUTVXtEld1e2gP9dbN7DBFPbf37TYW3A==", "fb862a29-76ec-4c96-80d9-922195fb4091" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "050f996e-0e98-4596-a838-cbf2e5849df1", "AQAAAAIAAYagAAAAEM52zGy/kpA0CVS2aFxLpoRXdqHxJ0StiwfylTZ0OXH9v5v1HK7+9pjYlXAyePz04Q==", "b675c120-8576-410b-8166-be2d512de932" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ea0ece1-ef56-4e7b-8dd6-145eee561a24", "AQAAAAIAAYagAAAAEJXkFo1eC6EiPZM2zXu9xrhXPBfupoH0WrQ3LspBjymCTObNi3diklLEa9oHDp4BUw==", "490d1d03-284c-4141-9b34-dd275f095447" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7efbe4db-5234-4a22-af3b-fe16236d9c08", "AQAAAAIAAYagAAAAEP0XHAWn28ZucOFh/v2TkO5gvTYDD93/oINmgxp0hJVMKYTbWMIMe5VpWr3v1waaQg==", "58b7c3c0-1a00-491a-94b4-4d98f0494570" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3b5bcf5-88b2-4bca-ac4b-c698f24d0b3b", "AQAAAAIAAYagAAAAEO9gzdxYWw0+VccXCu2sZSWkbMKruM3rVjHIt35HpIHUApwAIOAJIsp1i88LI16W2A==", "4d79c4ca-fa96-41a4-97ca-1a74f288d086" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cddd26f9-83d6-4975-8218-43d574e31668", "AQAAAAIAAYagAAAAENu6igbhivJtUVeV2enV3CmP+BTVWLRVm9bbeIGDryCrNgqpAQrhwIFP7ch3uvzDhQ==", "b7e288e2-4c3b-4cca-a2fd-ef753df33e37" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f91a7426-6a2c-44ed-8522-3389654c1ab6", "AQAAAAIAAYagAAAAELIlRa6sL8PZdD4krydHIA9uNvesA1eXKCWJsx8uMX+Pfon6EVUduSDCuL+kmmExqA==", "adcaa1c1-4757-4cb6-952b-a57431505c24" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f9ca706-11b5-4a98-9d86-08e823f63c9d", "AQAAAAIAAYagAAAAEMwIgih7LifGws9rXvfwHOrFklcqbdPUKSksCx3CdELTUzMWAE05zuC3OrNXWPbfdg==", "28b26864-a324-42d9-9796-f612d25c248b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "250a3849-1acc-4b7e-8534-7ca862cbba23", "AQAAAAIAAYagAAAAEMeEpjEC3t1kwyn/dP+lFBLRU1oyL1cYJ3EJbEHmBw8GCwpjJAGyN3KHXtJtG/5u1A==", "34060b7e-acfb-45f5-b43f-9210d135e519" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30e440b1-e414-4ef6-a3c9-af097dcc9720", "AQAAAAIAAYagAAAAEB/zza1g1/bhpoQ1HWic4deSIOU9tBTTs8vLYgFZDCyoSQXQsVZlvG/LDX16xwiqrg==", "e3e1893c-950c-43c3-a952-d323e266c6f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a07bc78b-d3a0-4f7f-8da2-322499e3a53a", "AQAAAAIAAYagAAAAEPrJEEHe4MptHCwR82tUSVjsZBFPr89OXxa8HGSCMifmlYG3CV/JbKcubZpXh7PQVg==", "16bb00d9-6399-4176-a46d-0689e9162cb6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f7f3a2c-ebed-4b1e-960d-d4b6010679ad", "AQAAAAIAAYagAAAAECPnqM8+pnw4kj5VhR2eXG/85zJzMgIDHqfBA3AINF2A5hqdr6ko+3ehmGUAmdmfEA==", "cffc2b3c-0b04-4292-b866-a3a80173ae51" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1129c34-2b0c-42f6-9d54-ff0c05a6e215", "AQAAAAIAAYagAAAAEFZAhDhXrQHXcAa40VlkjtrjQ6BJC83ccshEQBzlkM9HpYgseC2FhzZhBiEBRCE0Qw==", "bbafd038-0e3a-46eb-a721-7220763639bb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e9e25d1-63c9-4c06-a701-79dd65df5450", "AQAAAAIAAYagAAAAEK31coMoM++WpEWbu90HUT8Bill62M60tyb1B79ERBZuAX0EX90XNVnySvXwV9v2GQ==", "16498300-c6d1-4381-a349-99158a797f3e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0b4b871-274c-421f-82cf-3894c5f6abbd", "AQAAAAIAAYagAAAAELHEAKvXhEIxr5y7AAMTzKcnUnl9k8FwaVyxNVnAo/InwLCYkDzRmzD+hLp/RUVXyA==", "6f4fc74c-fe00-4aba-bcaa-b0ff157d6fea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58482313-95c5-45a1-a483-7a4bf1241fe0", "AQAAAAIAAYagAAAAEOWqPombrdejaOgBzLHUoDsGNPqLoCymtvBVXBitZ4rFG5bqOgRBImhDZkaOAKu3Ew==", "4ac088a5-cab4-4de1-bb2c-9d8e9b13a25e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa91d4dd-07ea-43a2-b7d3-37e2f54f6f62", "AQAAAAIAAYagAAAAEMd+KUuxKRi4EArYdc2knPDeZMN/b2AisarzJg32DoJZq6q5wli7VQulVpuh+aGKEQ==", "1537d6d1-1ce6-49b0-85a7-75fc1c62f82d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f404b7bc-e5c2-43e0-8fbe-0512eb91d9fe", "AQAAAAIAAYagAAAAECpNx/7Yd8iGbtxUAOZVTAj2ghMA8IsxWfR6645A/4x590R0Pq2Xja6FEa3v3jsGzw==", "e477f097-6fbb-4a0f-835c-00d1c4f29cb7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4679a411-da43-4193-b556-81fffae06d98", "AQAAAAIAAYagAAAAEGUOUudvRxqEMDW4hslWX8uAlV/Xq2xqv0AGREW55zAXZhdDgg5R5RXHY56mbf8ahA==", "e454e228-ef92-434f-ae0e-56f48ee6fd1d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b71663-7bb3-4bd6-bdf1-adf3d874c4b4", "AQAAAAIAAYagAAAAEPmU0oqo9KfzfcNBvH8dZ8B8u8pM1dSk+xv+UczNIHeaM2k9HhK4Pf9d5zW4mMGT0Q==", "fb7ba8ce-b95b-4294-b78f-ee9383ac0ee6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28269fc7-6f97-44a8-8260-27f331196b8b", "AQAAAAIAAYagAAAAEGz8uVgv0peYO11HK3UA/UdS/c8H2s0kLIoxOkqdueVnA/AJ2tLvioyIvLNFauuvXQ==", "433693bd-b766-4ec9-bbad-967a493951a3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb23f292-1b14-4e99-b1cb-a7c14d9bd3f1", "AQAAAAIAAYagAAAAEOme2u/xKX9I9fKBrL/wSUpKBeMpg2TEBTxk/tEoTMDlnhide2WzYB5AYBqipidecA==", "cc18ed80-6597-4392-a55c-be709db8fd10" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95458a60-1c2b-4574-bdd8-bbb3d31de779", "AQAAAAIAAYagAAAAEGYSwLT51A3CE9gHF1ABMpoxh7Pamn2K6A/FQjXFCFM0xO5ojx38Ho8jTSqbQ+SK0A==", "7fa583ed-fa4f-4248-b364-c0a4bf95eeba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fabc308f-63b4-4c82-bc1e-dc0b3a2427c4", "AQAAAAIAAYagAAAAEJf+QvOFdEbPJlTfCOFdzV9Z2Qp8/cffgUsdwu7l07AK8XUJDt/XmFIsbnCHuqrSmA==", "07cb605b-0634-4562-8ecd-f7c46a3dcd57" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab50882-41c9-4e74-9a59-eb5d7efddd2d", "AQAAAAIAAYagAAAAEGwMqLejmTwQOCQUGCtt0d6ZJPuEZ5EPTSEwj9l6vNjO9RXmJB0hNNxGHHpiFHfT7g==", "55dca363-cf52-47d8-91cd-19b05a68469f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2ea081a-df41-47e2-822e-72388f6e1554", "AQAAAAIAAYagAAAAEFB05IPO27/oeyUFOjIi6ONUJAS+/aN9IXU6WGZ0UWw9ZkBonzP4nXN/pfciRzADlw==", "748ca8a2-b44c-4363-a74b-bfd6c3499b5c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a47dd5d8-2b81-461c-8cf8-4b584450d803", "AQAAAAIAAYagAAAAEEakKabGNfNbGG5nNb8zZwEjl51xppSb24r343Ybjf8Lv40EoeSxUNcNedMwIYetZg==", "4c9e92f5-f4e9-4900-8a6b-02fb2c277948" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "266cb3ef-ea01-4ff5-865a-1a99b036ded6", "AQAAAAIAAYagAAAAEIz66uQkriPk95wl59LO9z9jmoI/3/b0kqYXIv0yRDsi9cL2FF6oVMy0CmciSggTCQ==", "0448f47e-ef0c-4484-951a-24caf9aaaba5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc74610-44ce-47d7-be0a-6d9de30991fb", "AQAAAAIAAYagAAAAEH6M+NTRNbxg5urpKkXlbR+nrhPrt35L61Dyf9f7eON9bPdCf/mlZZOwrPBWyUfqNg==", "86d30383-b370-4f20-9ee8-94b0110d61de" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d55111-721e-41d7-9706-af620da575a4", "AQAAAAIAAYagAAAAEIl4r2lEJFYA3GIHxzob4YFeLxrpCwPjTF5dFkceAVVnnbHHdyhhYMQrJmeAXFUBiw==", "b60fc714-0ace-4830-99b8-dfd5477de041" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aecd88d-e6b6-4d80-8b21-08bbd7cf403e", "AQAAAAIAAYagAAAAEDWpy5osUKBLeyFiISA0tOd3zDxZhdF4qfgX1UiCE2v7FV0WR5AnI+abAjq5/hTB4Q==", "9a841ed2-79c3-4fe3-ba66-52ab856935c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e092b996-1dfa-4977-99fe-e43dfd8e7fdd", "AQAAAAIAAYagAAAAEG3d+6PwnYFmIbFkT+232fe5A44LZBfU34ZjH6vBjEpcD83oED4C8LJvlPoVAiL8eg==", "fe4f688f-08a7-41f6-bfc1-bffcf4388a53" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5554d87-1a5d-4fc3-8c05-cec5d957c0bf", "AQAAAAIAAYagAAAAEFnkd7f7wZB5A8whKOeB3TCu8wl94GfOjxYShUjnhVw+++E8JsrC8XihtKgRdo8FZQ==", "b8ddf247-0e4e-4251-b208-30c9fb5d97d3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca451b4b-3674-4fe4-aa8b-7ee27521cccf", "AQAAAAIAAYagAAAAEAELhszkmXp7+vM7vk2I5Hh5hfQPMA3NLClvRWrd3z595mBtgtDhYZtzXp77/+qdHg==", "847df6e2-bafc-45d9-83f2-5119bacf4c1b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09e48245-5fa1-4a16-9416-c53d283d0e59", "AQAAAAIAAYagAAAAEM6WD9NT6KEoW5li2F8SJ0VJqaSQ885UbFoEdt79P2WWRj5fzfq0lxH0OCju1lE3IA==", "a8eceea4-fa48-42c9-98f3-e2e43f8a060a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cba91db-58fb-4413-aad6-291214eaa784", "AQAAAAIAAYagAAAAEOqRI72YhgdQfwQHXYJx9/OfrNXn903+oH9k4PRrpb+75DkbRiH+qMBH4bU/xb81DA==", "d7d4c96f-84b3-45ed-bf5b-633a7f4327b0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c8f711-73a7-47d3-848e-6a3f4029d508", "AQAAAAIAAYagAAAAEBBPs2XKk/uWJwzxOxO98dyy0EHa0x2izgSmOY84hxiEEa3Qr+U1jFoYjLVkpSo35Q==", "b6660ba7-4742-4f5a-9653-08c16f1a23d0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5cde4df-150f-45cc-95c6-00eca21a5017", "AQAAAAIAAYagAAAAED2Ukhv+Tmzn1rtVZZt08EY8g4hQPeOcLhzqhfxMjhp8RPMqFuPcn2ZMVXR/Kh/sng==", "782161dd-296e-46bd-9ec0-7a6cfc04b2f5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9184a642-2910-4e76-8738-037b4f8c277d", "AQAAAAIAAYagAAAAEJPs0OokInWFnuVTW28GVsK2WOxCXu7E3jK471Kzf/hRzQ0ChBS8Mi7swV2ub6sM3Q==", "feea4921-ca0e-42e3-a18e-3e017b197749" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc5f9500-8684-4220-bdb7-c520ee033729", "AQAAAAIAAYagAAAAEL2wu7uyFoboHsPEY8MxbBZud25RXM+6UrnSObJ50P1O8f3RQO0w0wKrMQqIt7w6jA==", "b642b346-7e9c-4270-b103-7bfa789e5f95" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac28de56-dac1-4420-b1dc-cbd3cfd52fad", "AQAAAAIAAYagAAAAEBJmJqi7npyXaSuIKKEy6lgUm/ApJRNbPM7CppG0ioD9zOkqupQNPsT+dJV69WpMmw==", "a95fb686-da91-4bb5-9b07-fcd7776aaf09" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e6bdead-c127-43b8-b6d4-4aeea24a61df", "AQAAAAIAAYagAAAAEAhPgRiw7GHAbwYKWKKMqdotTPWrk2cMpJS8GiShuPx4ZiBIX96dPWZRy2IZlGHUnQ==", "b1facbb4-1d07-4e0f-9116-717148d4c380" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf5f5ea5-6bd2-488e-ad7e-f782be26d3b1", "AQAAAAIAAYagAAAAEIHsM1n+refuTb2UhFxu7P8MdrFPK/7JqME95lyZaBeHZUnYzUEMy+6SQ8e9ZftznQ==", "1fe1d058-ec93-43f3-a413-e200c60477c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ccaec6-e754-4f89-bb07-354a90df5cae", "AQAAAAIAAYagAAAAEPp8gDL3C9r806N3E+Bg4CPPtW3wDBDyqgZ9D+ooIfVcHtR5QMeC0bY5tGdRgT6SRQ==", "8a47eb9a-be04-4bed-816f-b4d05fd7a038" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9100188-1929-4df7-ae2c-c24d177bacbd", "AQAAAAIAAYagAAAAELhn2JoDyWFbO1wwkyFfqp5ldqjpn14UX9IHZkZQCR1W0rdiTAHA/zUdV68INA1QaA==", "a597cc2e-a8cb-4ff4-ac0f-fa5aedce51ea" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af2b77d-5ad4-4822-bf84-9ee759cb2c8d", "AQAAAAIAAYagAAAAEPM+JUlsm9BDkxrlCwXjmA6to30ch0ampC4ISBG1ddv0wnb5EOb3+L9bwhY66W0esg==", "19712a6e-6a40-4cd8-b0d5-5cd2c603217e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa185bf7-b02f-4781-8d2f-cdafbc73e4b2", "AQAAAAIAAYagAAAAENYRRogGe72fdzG0+aNuYbLSd5Uann7IA/27wkWM+1QzOAgw+ZOmxh5LW11tubMiig==", "bfa24f29-4286-40b8-8a84-694aa3df2bfc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef38ecb5-512d-4876-a141-e107c233fe4f", "AQAAAAIAAYagAAAAEBTmcgtKWEFnnpysm9QICeJiD/PEIuzRcbsCflkNqYTAYdoM7qQB4uJjNVIRpAE+XA==", "a309e373-f542-4c8c-99ed-55207bc657f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5d4688e-9fcc-4bc0-94c9-71fefd1dd2e3", "AQAAAAIAAYagAAAAEJS+1OfG2HD1l+en3r8EwsuYZJhPgoPJePg1fJ9zpyLJih9yrIL0CoSSGyTy6ppiOw==", "cc523576-9b02-46fb-b76a-0d7a1e43a525" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4c5a71-d37b-4747-8b71-2d6f934ad9f3", "AQAAAAIAAYagAAAAEDRjIQqDEMO+6h7l6qaBubzuLnTB9OkAJUxpNFmadrY/thl2wm47dHGCJWj45zMgZA==", "1ff2b087-84be-48bc-a114-51caf2813451" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f8fb292-15df-43c4-a76e-834bd0fb0065", "AQAAAAIAAYagAAAAEGTo/347LbgZLezpPWdxp30R3SNbZFezzIvKwzLXaonZ4GCYsFrWcZF69SGpvw+WpQ==", "d8f0f67c-351b-4c2d-bb7e-1a3233e6a65f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5a577e2-bea5-4714-8432-b6f470cc994f", "AQAAAAIAAYagAAAAEHxLXiqPZ1b3S9XO+dIfkqCYPDFowkizVo+cxCURYGSGShq/u63unPZajL7LV3qH9Q==", "cd9b07f9-ba24-487f-b4a9-53a88b4ed6f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0a3076-1607-4fff-9957-0f62cc33c281", "AQAAAAIAAYagAAAAEPu9ZF3TietZBPKu3Pr7MrG5N+0YFxJdTqUmVq+Uf0LWm+F8uD7vhZNLVZCkXwHZdw==", "3027d9bc-5fc2-4b4e-bf93-196baa7f5089" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ecf8df-9c39-461d-a8e4-096c22cfb3df", "AQAAAAIAAYagAAAAELL8y0yq89woTty8yn30+EXCifQ0C8LFHxldvrGEJULIpihHM5St7VK/nqzGru2ILg==", "44e98804-b6f7-433c-996f-9c12f753a3f0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db9f11a-e4a7-4975-93d4-802433e2dba6", "AQAAAAIAAYagAAAAEGwFweLbl8muP8xweWDnp+lk9xlRBUwymQXji62ZLgzilkl+CFINdei3W4JjxlcU4w==", "86e93e48-e334-429f-b055-23e28752c944" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc57656c-2513-475f-8d53-84bbab7a5cb3", "AQAAAAIAAYagAAAAEFC8o5TIhYimFwvyzvV/5mHssAms8IRd++eSx0yiS13PweV4qQyf1lVoqS+GuBJWZQ==", "7617cda4-24d7-4943-b2b4-8152d1b57b0c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa8b2b99-b05d-49c5-bec5-cd442162907c", "AQAAAAIAAYagAAAAEIZdNGU1xYO7JKcMAfG15aXUirag6jnBC9RuqY1GIumYdWjdqGXF2EHywBwbYQfYqg==", "01e5faf6-0d7f-42f3-bfc2-e9cad063315d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83baca06-b2a6-4f62-856e-59201981b740", "AQAAAAIAAYagAAAAEOcgTwi2PRxto5UHwpTDNbpiqmEUVOOr13dqy5OoHVHmO4N0vuMj2zacjvurk46VJA==", "006616ab-397e-43ad-9b6c-6f57eec5ac27" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bddc68c-0a67-4efe-be6f-6927ae3283be", "AQAAAAIAAYagAAAAEKqFrw+ExiMipWDHkao7Zacc78lixLR3xazzSggPdKpQdnXMDTjmmo97+c586WKpkA==", "184dca57-6c76-4c2e-b405-1cfd3479f858" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1204147e-20ac-4613-bef5-299f9b5eaffa", "AQAAAAIAAYagAAAAEGTh6e2bUMzX/ICw8cf+geGmxy/kJ/qyQcv5m7LSaBfyvWiptqllNpLOEbAWgx1ZxA==", "ba31ca4c-e863-48fa-bafc-d83446034a6e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef47c669-bd74-48b5-afce-9351d1117bb1", "AQAAAAIAAYagAAAAEPn21/15sO2i/IpbPdNXuDOVs5JJ8HRm5755yY5JiiSIDUl67YE6PVkFWPDM0LeiwA==", "46e84ddb-8e5f-4488-b623-34a598944934" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4238), 1100000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4246), 850000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4259), 1500000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4265), 1300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4272), 1400000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4204), 1500000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4225), 950000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                columns: new[] { "CreateDate", "Price" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4232), 850000.0 });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0fc57cf9-93ca-4e7f-869e-68f44df6640e"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("1ecf5bf4-adbf-458f-8969-0407074cdab3"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("2c55632f-9892-43d0-a932-7f46b2dea623"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("392f57aa-f3b8-45b3-bb71-249f0292972b"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("54b70e67-717e-436c-a7d0-3456e950fa6f"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("6865d9c8-04d2-49bf-ba13-be7c7fe60774"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("6bf560df-d80f-4726-9402-656c91328426"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("77e37193-c9c3-44a7-8469-c56160022a01"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("8346cb77-8b9a-4a01-a904-11567b85b51b"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("c7899334-9773-49af-b550-1c342e5c2b30"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("db21751a-5940-43b7-aa85-2f9a972549f3"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("dba73c96-908a-4a67-96c7-23ff4d9695a4"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2a47ab42-ba8b-4280-b9b3-d542040ea5d1"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5867), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5866), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5865), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("2c76aaa7-df4b-40ce-8435-cc19ef3b2bed"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5848), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5847), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5846), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("4156796c-ece1-4f41-a23c-2f65486f75dc"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5858), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5857), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5856), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("4644c8af-a3df-4b6f-bfda-07e174d136e8"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5874), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5873), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5872), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("655af6ed-b84a-4675-83e9-71e4daf6ba03"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5921), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5919), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5918), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7147b240-dd78-4bf7-a37c-6618bab92580"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5908), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5907), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5906), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("752e11ee-dc1e-4eb7-a0b7-04c1f239e748"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5884), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5883), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5882), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9c953098-9e2f-409f-bd06-a6a87d1fb2bb"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5913), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5912), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("cfef9894-112a-43ce-9e23-d5e1c9a07a99"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5900), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5899), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5898), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d151f02a-9422-498b-b870-6e42c7737cae"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5892), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5891), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5890), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0133b1a4-c9b3-4cd4-9720-556058025f51"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5642), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("014078df-2a58-4345-8b78-a842a9b1c919"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5676), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("0436ca5f-4927-4ca5-9766-00b87d0442a2"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5451), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("0c33fa27-6eff-4748-a44e-f9e7e34f97ff"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5594), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("0c520f6d-66b7-4eb0-949b-1bd1bf4c8cc9"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5755), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("0efa6351-3285-4fb3-8bbc-f1109bbfece0"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5328), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("13c7bda1-1dc6-41c6-927a-6fdb77961ac9"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5603), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("14bcbf82-83fe-46a3-9a66-6299a29d7851"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5441), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("2d8a9832-c764-437c-b7c5-68e2a83dea79"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5695), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("3102931b-0e65-4b1b-adfa-11a1d7517b3d"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5656), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("319ff1d6-f820-49b5-bb46-99dfab7c5933"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5745), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("31ac15df-f493-43d6-bbff-649abca5753f"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5267), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("3e755b9c-4c3d-461d-b2d4-c5c801a5761f"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5736), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("46c32b18-4cb3-4d78-99a5-2da3cd5cd579"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5584), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("5e346f65-efed-4bd1-a59d-d5ce2c36ba92"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5406), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("5fdf59df-3b52-48a4-b78c-e85513822fe4"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5765), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("699cb91c-5f91-4b76-a9bc-a1518cba93f6"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5666), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("6b39cf70-5dd0-418a-ad78-9a65092090a4"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5421), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("6f9a1c39-c14d-4e4f-a50f-135c85c98916"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5383), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("753889ea-1e23-45d3-92a6-2fcc0d16fd60"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5723), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("799bfe78-8d8b-49b3-a88e-5d8f4d263f98"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5553), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("8b8724e6-880e-4e0d-b372-62c01f5bcaa7"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5613), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("8d7a9972-9a81-4106-946c-1a3374cede4a"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5704), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("901c7060-e448-4c75-924f-c6a64d41f7a1"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5278), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("9238eeac-ba84-4f69-9a88-f917261281a0"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5541), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a93cf402-2112-4e81-8d3e-706928ebb256"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5623), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("abbe2bd3-27a4-4255-a219-8d567b1bce0f"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5396), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("b8f87bff-9f98-4bf0-bfe9-5dd8980e1c18"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5685), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("c140759b-2f84-4774-aa6e-53a24cc856cd"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5574), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("c4f40b9e-ca3c-46c3-8a74-9219782f7e2f"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5714), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("ca33f6da-8d6e-49eb-bd1b-0f01b5adf840"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5340), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("d0a90dc5-365e-45c1-8758-e60465ea39fa"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5350), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("dd33dd58-fff3-4ccd-ac8d-9d527c0d4d69"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5432), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("e6f2a772-f99e-4641-8279-a7d3986e719b"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5252), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("ed9070a0-a397-407c-a26e-670eaea5a5e2"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5289), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("f6dc9f1f-d432-4831-b967-bd67f0928997"), new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(5633), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4382), new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4396), new DateTime(2025, 4, 9, 19, 49, 55, 498, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 19, 49, 55, 492, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0719b637-bd9c-4ef8-8af8-c3dfebda7200"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6075), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("09667e73-ac88-4f40-98b9-d28a405a9670"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6079), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("58b6350c-7d2f-4dd0-b2f6-935c78ec5016"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6116), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("5df345a7-e468-4e8f-83da-2ba74de0ab89"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6102), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("6a43117a-8661-4a7f-a9ed-39d368e7f114"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6097), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("79d56aa2-71a1-4984-8f82-bb3a344087be"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6091), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("7d216fe4-27f1-4e43-956a-2254f576d926"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6085), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("7dbd3b90-11dd-4da1-b5d2-d61da66f5766"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6094), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("8b1bb6d9-902a-4c3d-a81c-69c3bf37a0a4"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6105), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("974a4e24-3274-4011-8677-fbd506767288"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6088), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("cbffe7c3-b9cd-4d1e-8321-d28dad47eae1"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6099), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("e02719db-38c3-48a3-87b4-3b94e8b56025"), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6113), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6006), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5993), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6024), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6001), new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 10, 2, 49, 55, 492, DateTimeKind.Local).AddTicks(5981));
        }
    }
}
