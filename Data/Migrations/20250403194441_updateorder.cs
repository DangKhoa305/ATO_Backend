using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class updatetorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("35cc7650-6067-4c75-9241-9268256fbc88"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("48245413-01e9-4258-82aa-dd71e761e6fe"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4a53c644-6d2c-41f6-abef-4d891b855c7a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4cbca988-40b8-4111-817e-b46c5b7ff9fd"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5e4ccb50-1a49-472c-939a-2eb6a5e46201"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5fc1f930-0032-47ec-9e02-27198cbadc20"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("612ca576-bfef-4885-9382-97fad39e27d0"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6af3667e-f6a2-48a1-8a50-a4505a582f33"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bf751dbe-7482-4c88-8574-08ad0df80914"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("cd32375c-adf0-46a3-80c5-d8d44c7509bf"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e7a57de7-a5f5-46e7-8acd-1e10c967cfa7"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f65cb57a-d399-48d2-a711-74590a7a9904"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("2b6c48b2-9d97-459a-8c81-712ca3536090"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("38ea57a4-d3cb-4237-b775-f14380a13e75"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("56d1574a-2af1-4ca8-b8cb-ccc18bd15694"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("7ad84bef-c83c-492b-a13c-e1f6b9189a4f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("86215e79-9282-44e2-a646-f5e2684886b0"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a2bfbe0d-ab62-4e4a-aa83-8c452d2d44ab"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d0c27318-9cfc-44fd-95dd-4ccffd9209bd"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e638903f-18cf-4e4c-a858-ee91a1699532"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("fa587fa1-6e8b-4aef-9e4e-9483967ef17b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ffe6b238-e3ca-4077-9863-4c4e3bb0d7c1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("02d77092-9493-4f62-acee-297d9c8f70cc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("05651942-0f18-446f-92b3-7c1820155e1d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1088fe36-ff33-456c-b81b-3ce3ccc5b4ee"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("12705449-5842-452d-ae96-d21dc3dfe1f5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1449344b-bf5c-426b-9684-9e209f6dc36b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("196020ca-c9ec-4cc5-9f20-035db3855b69"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1dbc528b-c147-48e1-94c7-6ecbea8bdc8a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("289fd745-6e32-4647-b001-aa837c7a0e7b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3ba251c9-4ef8-4b8a-9b7e-d03c1af1eb1c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("42f00944-e42a-4047-ba80-fa941af7e705"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("437bc87e-1f64-46b5-875f-443b8cad8e6f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4423d82c-02cd-474c-8c6d-03b6a973f312"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("464290ff-8893-4ae8-8afe-8123509c1def"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4a0b48b4-d1e7-41e8-bafa-34da304c2f75"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7d0f30c8-dd13-4fb1-b9de-3ec150ef9173"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8ec4f42f-536f-4e5a-b122-ccf566bfe287"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("aab608dd-21fe-4181-bb11-9b81bec24586"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c29d5275-2fbd-449e-886c-f1183a954df5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c5c3ab53-4595-40bc-be74-dd5ee67ff4dc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("caf98b2b-1b4b-4d69-b62e-2e296c05f0ff"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e151fe70-aa09-411d-b511-9675c596ea96"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e7e49ee4-a6f8-4cf3-b3c6-2ae85e89e889"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f0a1666d-0d56-4411-ace7-5b8449cbadff"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fd857589-81fd-4b03-9c64-c1ff55effa82"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0db1c983-88fe-42b9-a174-e1446e0a759b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("10c8cd12-1898-409c-aa39-729d59c7a0e7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1d16e81e-daba-4b21-9aa5-4aea894cafe2"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4b282109-aeb2-47cb-8bd8-592090e711df"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("528a2dbe-8445-491d-a6f6-f327ae072c65"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("833d0080-1495-4dee-8d2c-f767e5f607e6"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("86c90a1a-6d9a-4f80-a609-67cb6b12b0a8"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a045be7c-c517-4dac-a812-38d5214c9fcc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a943f4c4-dd74-408d-a672-6b5a12d85d5b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b03e26b8-9fd8-43d6-b10d-7adc892fda5c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f7de2917-582e-413d-adba-910014a94150"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f8f12f48-2b9d-49b4-8bd5-ff48fd7c5b33"));

            migrationBuilder.AddColumn<string>(
                name: "ShippingCode",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "989632f7-c53e-4374-8aee-d2215f1baf86", "AQAAAAIAAYagAAAAEEmjcA7tJIZeNL/qiBGKQGu/8HXxpBfZ8UM157u7nZMeO2A+VDfx6sSQvhnAjKzB4w==", "3540d0e3-562d-49d8-a8d2-e02e4287574c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3fb97be-b47b-4c1a-9784-f05bd37f9a49", "AQAAAAIAAYagAAAAEHKT5xH2sDSF73FUoqIRRAuPv6MuI8DA6+i+w/ErEymhJrqc67Sf+pJwFycjyWzywQ==", "e2ca9ee3-4baa-4aea-8faa-114c0a3b8e17" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0471c1-bda4-4704-8329-a22d31df9bfb", "AQAAAAIAAYagAAAAEKdBa5ON+3Aha64IMSd5YrRRtL8QunLwYnat3dx8bzjGZcwZDo7H5HFUKOqCzpHWPA==", "d78c6479-3ad9-49dd-b7e5-44286bcf54b9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdaeb143-3090-4c30-b09f-89ad9f344be1", "AQAAAAIAAYagAAAAEA4/uiQf/SyBpYHwuwo/DNxuFy60AMnwR/3mLIiiSebf+pKhSMxQalXxOg3d/xd/hQ==", "0248cfc8-3ea7-495a-aa2c-9b014b014546" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f058a31-e3d5-4498-abf8-053879a19978", "AQAAAAIAAYagAAAAEMGk+QZcOMfWmCO5J033mFb01Y9wEI+y5nBdbGtVQQoCaKb4HHqjl0KNWVeqatOrSA==", "5a452614-08dc-4fdc-97dd-f1c551092c40" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b626b12-475b-4a66-9bd7-c83bdfda6fac", "AQAAAAIAAYagAAAAEJ+Qd4aZKvSxLRNhoaXS1Z+7OIGG/0Nkk+jKJPOktDzQu5EqbbkEttz5SzO7Jt69aQ==", "7b6e6c66-3050-4a10-bdd0-a8ce9332eae7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5c3899b-5076-4458-ad47-b9f7394e9872", "AQAAAAIAAYagAAAAEAO6jb/63OEH51JdgyLpwCn3Gm9PnCRVdGUnFH16fNpemAjzQZ/gpVGWLBqvn+nVXg==", "8ddfe7f1-353e-4b08-9aaf-228683d6dbd3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b63661-cde0-41d3-9a0f-375ba037f2e0", "AQAAAAIAAYagAAAAEJGFMsClW7bvwTCtsPUnK0i/V05H/IapzBb6nuBANebKU/76N8kUmsWt/VzGm98W0A==", "f148a403-27f7-438f-bc69-b8f44287a107" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838a0f71-e1dd-4a8a-aa00-51b39cce0b9b", "AQAAAAIAAYagAAAAEPPoM2L2dE1g4bvu3rWssOa7aGd6SrdOnjC2ya4DuIwH555/Oq2JTqvjJxN3Uz27NA==", "f7e64658-9f22-45cf-82a5-8015994c6cda" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b2ae5ba-5caa-4e2e-b03e-acc61b33d70c", "AQAAAAIAAYagAAAAED5ZxTcerEnAbHxkI6Bs6guPt68tjMm2UDEcqo6T3N9tbOiAzxIxM37cKFpmwOzwMA==", "770a07df-a6dd-4030-8d6c-8a0aaeb5e8a3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd3ffc42-93ab-4149-b4a8-d40d338792fa", "AQAAAAIAAYagAAAAEI86kf2rQePFlpc/go6GFrB0TpE1VP248NOXRgAdJGSggA9jF4//D8L3QVpVTUFj4w==", "1004338f-afe5-4128-a913-b3266aa583c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37b0e1cd-2e64-4cb2-8026-c010cf4861b5", "AQAAAAIAAYagAAAAENIv9S/hHt1AhdBs9xQ2XUNYryMNSHHvCX1ONtOcd96fpn++CwI40VCGwBQWc8xI2g==", "17604328-89c4-47b7-85d7-2d09ca052f98" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b162c63-5162-4995-88c3-7761815b4248", "AQAAAAIAAYagAAAAENnyuXR1dfJclmPpKlZDiJFIasOiL0VpbDkC9mLEyTNHug0v60nVtIDpssbkNgU0WQ==", "00da99c9-c2f0-4b5f-be5d-c12f32fca191" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddd84e03-838b-464b-9983-69a7b6047a2d", "AQAAAAIAAYagAAAAEF+372Wglz7aAt5SIJgWcze7xtvBqc5y211GvlqEn1h0bMIUHzzhyjInNKMt0evLyw==", "2c87ce98-f32e-4215-a414-d531c1e50f04" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5060ca1a-869b-487b-bc99-308f8eeeb5ed", "AQAAAAIAAYagAAAAEKgNSp35C2H57GQJFcM+Oli7GfCCJjo84VwXJgiDIbaL3h0HByfplWzSGfXRFSjMJA==", "3e953c9f-f833-4ff5-9962-0978115fe975" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b91575c-9764-413b-a44b-6fc00839a3d1", "AQAAAAIAAYagAAAAELWd5j1oaUDCO/adQDQNiZOr7/gp5ubcMIeIILu5rffs50lf2pyhkyXNNkuWMkQvEQ==", "f25404d2-47dc-477c-b6ad-081ad21699a9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15cb2d9a-3611-45bd-b460-3168faf63553", "AQAAAAIAAYagAAAAECy2ELdvGfBWlG76eTXXEHLpoLzbB4yecekj3qVUCVvU0lUP7b+w/l/wLk9UT4t10g==", "f7d9234d-b6e5-4266-90d7-74af6fe6afc0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef45a72e-d792-491f-b465-9ec9479c5dac", "AQAAAAIAAYagAAAAEEUrUpMy7iqyzZ6wRX4O6SY5O+RE8O36DoNsQxyOTN2ShTsBXPxsaIcufLFoekClZg==", "8b45a9c3-020d-46d2-9bdb-e08ba1c21e9d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dce9f9b4-695d-4e1c-a024-b91efa4e6bc6", "AQAAAAIAAYagAAAAEPjynFHQgL7ltyZRCQaGqInU6/kV29fJNf8xMDTtUgC4pcRfToXieHL5skCF9e174Q==", "044472f1-6538-4517-9dbf-7876416a2f12" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2d0fe5-4770-4627-84d6-02ded2a5d21a", "AQAAAAIAAYagAAAAEOsonCyRCx131NhfuOcFo+Ef9hao3SZUBhb3yLd6iMhAhrrmv8Fc7SV6GoES3MuJfw==", "7d41d088-a347-440c-9694-4bed7df5b5ad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fd118c3-a234-44a3-8f36-8908bccdab57", "AQAAAAIAAYagAAAAEOGxsMAxwtz5FowlzWTdL2AnwPkEW0HBgR2Z/A7z2wwK9oUcPtiW9Yd0lKuM2jY6Vw==", "dfa996c5-d73c-4af0-97f2-f1da23151334" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c4fed8-caf4-472c-88ca-321b8e8a1888", "AQAAAAIAAYagAAAAEIEgtxjHYyYgsdh80sACBDsTMObA3niMlfBgo0/L3qMuzN3VaJJBKnqX4d5xilblsA==", "702170a5-4c6a-4f4c-a8f3-4a7b03ab3ef9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a902e4-cbc7-4695-afdb-267e81e65092", "AQAAAAIAAYagAAAAECvXi7z1U+qElotuyons1xclN1pYiXlhTwhF8pbWQxtJHatmYWrgKVKyEwPlRojb+A==", "d1f2844f-ea9a-4282-af78-0a9575052c32" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f671c6-a9f8-4212-851a-232115c0fff0", "AQAAAAIAAYagAAAAEERG4HjVy5nrqBUk4bTYTPImPn0x8nYD6szZG8NygJl47GIGk334RjpRYCrxDQXFkQ==", "28d4fdeb-473a-4b3a-acc7-5a923567d05a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3fdeb0b-9fbc-4fab-8bfe-40c53b5f6dee", "AQAAAAIAAYagAAAAEEpIqLaiTRk0mLVHRFVGzZ+7/E+6Xlm/ABOCiOvUQl8JP7SoxEj2MRM4n9sxvnT/Cg==", "8c867724-96e2-462c-9402-2592bd0fa9c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f5562c-bec9-4279-9066-b9220b59547e", "AQAAAAIAAYagAAAAEMbsQB1k8F50lIyw7HFkw9abLvahwSr5m9Wr/2+/QL0kMVKj0UWsyb1KCe1IrBh0cA==", "414b224d-9dc8-4ecf-8258-74d41e34fd3a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc39355e-d93d-404e-8d44-a2a4861ca8cd", "AQAAAAIAAYagAAAAEAkksaIijc/ZWXrGCyeqB0eOGwoe8eZCrrbkylVhABlCfF5eJVh4lFOSA6s3IBLjMQ==", "485efb7e-b87f-4ee8-91f2-b969befa726a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "508012fe-35ff-45d8-abc6-408d734becac", "AQAAAAIAAYagAAAAEHy854CkKTJ7JsjMfdzQGzT4QiyI1ayg/BmfJRtNksrMHNvnO3sb8Be7UBLNlItehA==", "3516d6e0-2447-4995-a775-464a765808d6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d34d7a-b786-4a86-b8ba-c413f189914e", "AQAAAAIAAYagAAAAEGuFO1U+SKRD9dvRMCY9rd/ALHiU49HK3GiZrVwlA3r7mOBgxJn30quf3kJ9GQ6rkA==", "1a9a990e-bdd3-4188-900e-6f64076af21f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea82e743-d632-4265-83cb-0d662c559c71", "AQAAAAIAAYagAAAAEFyKw6AggQ4SlVvNYRGzCcRErMPKmjpX/t81nZpHQrkdT73DN6VAYDYPoHyEXclVyg==", "66129263-eb8e-42fb-b4c0-f5e7cea27050" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c371ea-dc59-462c-9e65-088d64837182", "AQAAAAIAAYagAAAAEAmZsNzZb+CVixFe28i5hvA6UxfGTq8pAlqv0ykjZ6b3o91fT3foTw5di7nhCBk3Uw==", "a7732ec4-0b19-4397-9e14-13c307ad9557" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("07b1dafd-20e8-458c-b991-bb61e6b5215c"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("134252a1-de73-4036-b9d9-953e8df0aa69"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("256c4535-c59b-4710-a41e-0beae8d3530d"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("2b551024-b71d-4448-b321-27835f8f17ad"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("2c5666d0-3c96-4469-b1ba-5f15f9af8828"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("52dbc3d1-58cb-46b6-a559-321d6e164e44"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("5469b27d-f1d4-44d8-8acb-28076784140a"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("b74f7d3c-675d-4183-80af-13513c570b39"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("b7b8dce7-4f44-4ba3-a7b9-e524bcea7556"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("c5847ad9-963d-406e-a773-41f6fa45d6e7"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("c7713806-2f3f-46a3-a493-05cb83953099"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("d4a05741-4b58-4763-ba21-21d52a6d48f3"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1682096d-7905-45c7-81e7-aa5355e853dc"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6378), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6377), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6377), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("1a664808-0a87-4b9e-b064-af51ca01a807"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6416), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6415), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6415), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("24d72052-540f-4589-9a24-8bdd8acaa46f"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6393), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6392), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6392), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("6bf124fa-337e-4c51-8291-3b8db267123a"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6405), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6404), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6404), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8b59f74b-2e95-4b81-a172-30f052594c5e"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6411), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6410), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6410), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8ef66fef-fc61-44b2-8255-2d2d2be1b779"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6362), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6361), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6359), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("92b5a146-7f7c-4e1a-963a-c40beb351b8c"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6421), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6419), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6418), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b41c5ccf-0b7c-42ee-a9fb-1dc3392558c8"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6371), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6370), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6369), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("bbc59d17-921c-4bc1-a621-6870d8b2a395"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6399), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6398), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6398), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c99b5044-9a5b-4c1d-b36b-c706f492d814"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6387), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6386), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(6385), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("02497d17-3fc2-4764-8f2b-3b9c9055263f"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6029), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("02f2d584-7bf3-44f2-a75c-3b51229d2a9d"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6188), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("0e7ea838-44f6-4d55-b528-259518a9563d"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6140), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("216a55f9-2532-464f-bc8a-ecc3a68afc62"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5890), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("26267406-76bd-487c-a702-0580cd8f467e"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5909), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("33139133-1842-4675-8227-394eedd7e482"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5934), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("4212d059-30c1-4228-be70-880f1e24845f"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6021), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("426dc495-7443-4e39-9bad-3f88e26c2fea"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6165), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("4dfa0e9e-498d-4c91-93f2-81f0c0c57d12"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5942), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("5445dca7-d956-4760-950d-427f36cb283d"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6173), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("6702a61f-b0e8-45ad-9b2e-fb816e1029c0"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5877), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("6cb01f7b-e3a1-46b1-884a-168677981497"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5898), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("7b16d171-1e74-421c-a8e3-36185f0bb652"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5982), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("7eae9101-c2a9-4767-bc52-b7539f0a78a7"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5997), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("81313b59-eed4-499d-a6e3-8895d60b9056"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5950), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("951d8e10-f369-4f82-bbb7-dc846e4dbed9"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6156), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("9e15486b-4908-4468-b44b-406dcbb000b1"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6133), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("a5fd5a8e-0953-46fb-b738-59325c7524a3"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6195), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("b602d36d-1c99-408f-8a58-36f1011ee05f"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6203), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("bb1a53b9-3295-4042-9752-c50bc7ed9829"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6004), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("d7392a92-1527-45e0-bb55-37caec403fb0"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6122), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("e3bee148-995c-4384-b5a8-a33c706a285c"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6014), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("f314fb5d-9b44-473d-a411-0c9f1f477933"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5990), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("f8f7fc6e-936f-4a33-a9f5-fd7825ca0052"), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(6148), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 4, 3, 19, 44, 39, 732, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 24, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 4, 1, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7659), new DateTime(2025, 4, 3, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 29, 19, 44, 39, 727, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1532859a-c403-41a8-9340-9dccb64576d5"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5325), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("1a461fca-81b8-4fa9-9d3a-4886b30b32de"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5330), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("2801de3c-a44e-451c-8920-fa245ae0444b"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5316), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("31b890e4-0f3f-4814-8bda-41826a7bf9d0"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5311), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("3d964bd3-4ddb-4e98-bda4-943388963834"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5334), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("701a5afb-545b-43a5-b37d-a034989a5e64"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5338), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("85d95e13-9afb-4db5-97dd-0a1649bab80f"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5321), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("90aaa224-9a7c-492b-856a-98a6c9573ec4"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5318), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("a2215c05-d562-4606-b94c-1d7fcc27375f"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5323), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("abfd6546-cee3-452d-96bd-beef3bc7c9c9"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5332), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("e9c628c1-e37d-4990-b692-e17ea7a04ad1"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5314), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("faa500ca-0abd-4e86-b526-dd02cd9024fc"), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5336), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5254), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5230), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5262), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 2, 44, 39, 727, DateTimeKind.Local).AddTicks(5203));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("07b1dafd-20e8-458c-b991-bb61e6b5215c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("134252a1-de73-4036-b9d9-953e8df0aa69"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("256c4535-c59b-4710-a41e-0beae8d3530d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2b551024-b71d-4448-b321-27835f8f17ad"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2c5666d0-3c96-4469-b1ba-5f15f9af8828"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("52dbc3d1-58cb-46b6-a559-321d6e164e44"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5469b27d-f1d4-44d8-8acb-28076784140a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b74f7d3c-675d-4183-80af-13513c570b39"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b7b8dce7-4f44-4ba3-a7b9-e524bcea7556"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c5847ad9-963d-406e-a773-41f6fa45d6e7"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c7713806-2f3f-46a3-a493-05cb83953099"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d4a05741-4b58-4763-ba21-21d52a6d48f3"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("1682096d-7905-45c7-81e7-aa5355e853dc"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("1a664808-0a87-4b9e-b064-af51ca01a807"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("24d72052-540f-4589-9a24-8bdd8acaa46f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("6bf124fa-337e-4c51-8291-3b8db267123a"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8b59f74b-2e95-4b81-a172-30f052594c5e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8ef66fef-fc61-44b2-8255-2d2d2be1b779"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("92b5a146-7f7c-4e1a-963a-c40beb351b8c"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b41c5ccf-0b7c-42ee-a9fb-1dc3392558c8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("bbc59d17-921c-4bc1-a621-6870d8b2a395"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c99b5044-9a5b-4c1d-b36b-c706f492d814"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("02497d17-3fc2-4764-8f2b-3b9c9055263f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("02f2d584-7bf3-44f2-a75c-3b51229d2a9d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0e7ea838-44f6-4d55-b528-259518a9563d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("216a55f9-2532-464f-bc8a-ecc3a68afc62"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("26267406-76bd-487c-a702-0580cd8f467e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("33139133-1842-4675-8227-394eedd7e482"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4212d059-30c1-4228-be70-880f1e24845f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("426dc495-7443-4e39-9bad-3f88e26c2fea"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4dfa0e9e-498d-4c91-93f2-81f0c0c57d12"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5445dca7-d956-4760-950d-427f36cb283d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6702a61f-b0e8-45ad-9b2e-fb816e1029c0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6cb01f7b-e3a1-46b1-884a-168677981497"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7b16d171-1e74-421c-a8e3-36185f0bb652"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7eae9101-c2a9-4767-bc52-b7539f0a78a7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("81313b59-eed4-499d-a6e3-8895d60b9056"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("951d8e10-f369-4f82-bbb7-dc846e4dbed9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9e15486b-4908-4468-b44b-406dcbb000b1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a5fd5a8e-0953-46fb-b738-59325c7524a3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b602d36d-1c99-408f-8a58-36f1011ee05f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bb1a53b9-3295-4042-9752-c50bc7ed9829"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d7392a92-1527-45e0-bb55-37caec403fb0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e3bee148-995c-4384-b5a8-a33c706a285c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f314fb5d-9b44-473d-a411-0c9f1f477933"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f8f7fc6e-936f-4a33-a9f5-fd7825ca0052"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1532859a-c403-41a8-9340-9dccb64576d5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1a461fca-81b8-4fa9-9d3a-4886b30b32de"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("2801de3c-a44e-451c-8920-fa245ae0444b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("31b890e4-0f3f-4814-8bda-41826a7bf9d0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3d964bd3-4ddb-4e98-bda4-943388963834"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("701a5afb-545b-43a5-b37d-a034989a5e64"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("85d95e13-9afb-4db5-97dd-0a1649bab80f"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("90aaa224-9a7c-492b-856a-98a6c9573ec4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a2215c05-d562-4606-b94c-1d7fcc27375f"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("abfd6546-cee3-452d-96bd-beef3bc7c9c9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e9c628c1-e37d-4990-b692-e17ea7a04ad1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("faa500ca-0abd-4e86-b526-dd02cd9024fc"));

            migrationBuilder.DropColumn(
                name: "ShippingCode",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de149bd6-9903-4ffc-970f-74a18ff7faca", "AQAAAAIAAYagAAAAEIRGmA5bD+pCbrFJgEp+YpZwae73fH/BfcyvqzAI/jB8suuh7EEow0xKiujnhlobUQ==", "9e1c8fb9-6970-479f-8e5e-d852d09f9939" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "768c2948-da8c-42ba-af3a-e907ca4152f9", "AQAAAAIAAYagAAAAEFgURHln6K1yndoBIqsp8fK6K4Rt1IZSWfGkIeUZUycQCVpPNAiq+xjKSVdRwg4Ibw==", "52675b45-7b14-4c14-8842-48e2f5003db0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b091d45e-ed0e-401c-9e28-2780d0e51aca", "AQAAAAIAAYagAAAAEM5MXb/4q/ow+OB5OvRt8kGhotb3EL9jDoWKGH007p9MACZ0oOoeTeAoD8B/I5UBDQ==", "58f54bbf-75a2-446e-a2e3-99bfa69be0cb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee1ba617-e39c-4d7c-b10b-32786a8b58ef", "AQAAAAIAAYagAAAAED9baWw5Iz8QUkfueNT1r5kEuLE8WV5SFcetL3lnoa6hezFPYf3rTz3Ps1EUHQMVqA==", "bc374770-ad06-4c79-99af-68f5784be6aa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9442b860-a88d-4f80-9c0a-cb7d080bb100", "AQAAAAIAAYagAAAAEIEM+K6XkfdoPA2JAIDG8V4MediSgqoGUMANXVjI2Q73nqoCtos+HsgFjb9IqjL8nw==", "6d6f776b-f7b7-47cf-a30c-87f46f893bfb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc6aa23-583f-4696-a4c0-67b3ae9c19f2", "AQAAAAIAAYagAAAAEBZZUwr3inSttkEGj+PCperrEINl1shHaMG4/WecFV0fxqymlzmEwMrvHQ79fIMA5g==", "60ecc7bf-1e0d-4631-955f-e17354376bd2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a88aceea-6364-4d05-9889-827f1da34228", "AQAAAAIAAYagAAAAEMKvR62JJtQ+V8mjki3sgu9OVrW/0pSbz8195flvIEML5zScLxXe0Knr27C/WxdXHQ==", "3ab0b6ac-c33e-4985-92ea-7ebf2593616c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2419cd4a-9b0a-4763-ba5e-9e0dae72d757", "AQAAAAIAAYagAAAAEAj9E1n3MigNzOIu8XflMaxs1NJsNwPgTfDxN8sd9A78eh/bDnxe/gwfLS8xqJYlCg==", "39406f14-72b9-4ac4-8441-176e365d7ccb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fd88cda-b33b-42eb-9059-4f3d2ea8543c", "AQAAAAIAAYagAAAAEO+NXCfS268U3oETHv3WdUUIKFKbEI4k/n/QxdjiTf3bxuJCyQkwmlvAbBAxNv9FVg==", "1b3c8059-c62a-45dd-82f6-b484d6447a50" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93f1a0cf-7c50-41d2-8788-3eadc35cfcf7", "AQAAAAIAAYagAAAAEGz4cGHZdzxrb3SlMJr056ztFjOfduQFYZKtsyqIdIXikNtQ3XYVnbNVnaolUx8kiA==", "0f62d6f9-04f9-4b9b-b16b-c0721505d89d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86fa576b-02ee-4e68-a047-02718a7369fc", "AQAAAAIAAYagAAAAEPc3STRS11+rxVDgBwhSETYkmbhOGQr8jKhkzgqwh02tXjpOU5nrhbEhFHKRk6pGjA==", "a91ab901-c363-4eb2-82e3-61f62772d91e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1f7288-0d44-4bf4-a20f-9aaa1399902b", "AQAAAAIAAYagAAAAEK5mdf0oCZIXBsPHk82Sp5RcyFXEyQc4KL8AMpRaeij4Db4gbfihhZQ6F8vgzIO5WA==", "7cbf2ddc-c47a-42de-a348-50367ea0d3cc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac30db27-dd9f-4706-b62d-36183fb7eaf9", "AQAAAAIAAYagAAAAEKY9aKyuemtucXWHXzfmb6pUNLHAuQyUUMwFgeud2z/fufSgRrQucLBy2sdcKQ69Eg==", "61d34702-6ee1-457d-8d38-2f1e3be9c793" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d225db8b-3ce3-4ae2-b544-d42a3e94a78b", "AQAAAAIAAYagAAAAEDJrWqA2albTvNCFoLmhhWbEv/DiFrD91Bu2b8eYqYwtnNhfvyVjwLq8vYLhiEiSFw==", "04f5d1da-d86c-4559-bc54-2925beccaff5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1633867-4960-46e1-b89b-602a0c51264d", "AQAAAAIAAYagAAAAEGSPiL6L6uMoy0aOMAq0pAW1YAjStCcSYR6Ur8k4kgdNfkUqOzt+/00LQsfjbmvwpw==", "b60e8a74-dd9b-43cb-a729-7a1f32a6a8ef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daaa594a-8a29-4412-98ce-c6e81ab65bdb", "AQAAAAIAAYagAAAAEOEDc0YbWRQv2ujKLx9LsazaN0CLwWyCqEAUp1ZRy0ZDB3azejeN5BrY0rTwXMWdwA==", "1dee88d8-a58f-4efe-ac1a-3b6bda66797d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "370d3d78-8308-4f61-9b66-db4cebcbd483", "AQAAAAIAAYagAAAAECJyLXRGCz4N21/4D9nfUYwZzIfSDDD3rynFL9uFBca2/sZfLzXDTzBil5dikAwCtA==", "ae3ffa1e-5fe0-44fb-9620-8dc304aae5b9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fc78bf-7794-4281-b575-b7c3e93afeb7", "AQAAAAIAAYagAAAAEGkpBxF/kvprm+25ivIGkX3/L6vC752zdD0FrNFCxzfo0G5//jycbXNfLDrAfhJ++g==", "ee69cad1-6bf8-407a-8560-d5b81f23458f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46fb361a-9bf0-4383-855f-9825b1b19d5c", "AQAAAAIAAYagAAAAEKvYbmksLIcsTZSwj/PFOjm5lLzTfyi8EDg/Sdrao9V1BBxKIm4RQzkW7xbVb7SO8g==", "0cc8a3b8-6dcf-4ef7-80e2-978638695906" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "268d3609-c9dc-4a04-96a9-7ad495a9259f", "AQAAAAIAAYagAAAAEKFQL2Wr8rR/kaZ1Kw4TcSeIEPdbv4vaulbTd1BgxvdBzIuhS+TyBFsLkYDdmNc2SA==", "719fd446-dc81-4fad-b41d-226cdda262f7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "736eca64-cd56-431b-b0e0-1c5e2c1c610e", "AQAAAAIAAYagAAAAEER0/bzGrilU0ufaZ8OxtvcAXBRlhcNoSEOU85ra76S1znmDBojnoURydFZA4JBEuQ==", "a6846f00-ad91-496b-b3c4-3a57891c0ead" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a017a3-fdcb-4139-b422-e6cc24ba14ec", "AQAAAAIAAYagAAAAEGkwrhsR/AxR0TfH1DsD76BmBvdI41121D9OokfEtburwQ5H4YPIWUFosPmqrlg1lQ==", "61db2c26-43ae-4ca8-a00d-302fe5251f48" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a46b6a4-0c18-47de-b604-6ed43e57bb01", "AQAAAAIAAYagAAAAEOErPNgHuBDocn7iaIZtbIeYJko9n8AOYYL5/NevLQotBYnTxVp915qYOfKLYkkurw==", "6d313257-f28f-4f59-891b-4e71f8b1cf89" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e478507-0184-4eef-9410-6c71ef00dbae", "AQAAAAIAAYagAAAAEBKroTCcojzIQs/wvQX7wMi9VyNf88/7oOIJDQfzC7TDuyfs+Gx20UZB/2iJmcRrog==", "823a3691-cc4d-4d1b-8199-cec0a48e69b9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9af496e7-4025-49a4-863b-662a6c31f5e0", "AQAAAAIAAYagAAAAEEb93RQd5W//xVXxyVqudXvtqInZv6f7/K6nTyQIG/laLJkP79T+HcR16zHDBGatEQ==", "a7157d8e-f9ae-4470-9bed-3c0ccea49e67" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5d4e2d6-b65f-4ad4-8ebe-5b22cc53ac9c", "AQAAAAIAAYagAAAAEDPfLkFlJ/zBCIBCN1RaLHB+ADzjFynv7AejTvc11DCcUGBoo7dbmaWH3TwQ/pMxPQ==", "ab12a4b5-9528-4d9e-ada0-8d2ee0052a07" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "599417e0-5cec-4b8d-a96f-c657557bf27d", "AQAAAAIAAYagAAAAEORIKphpvBB8HyfHx4J69nsVuMfwPNGBj+1Pv3lYl3nS0wApSPQnDGQrJ5xIxN9Ljg==", "a061fea0-ed25-4c9b-ba30-a2082ea3aeb3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "030186c4-1faa-41d0-8af7-95db97b9d0ad", "AQAAAAIAAYagAAAAEDPF0rvyGJmgpTUyKcKRifh7Yx9saDOrvmiIYCVmyxBirshnSO8DoXnDjMHYg7xIjg==", "09f1923d-a537-4a51-931e-483f6e3d5c48" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48e48b80-a1bc-4698-8086-9dd56cf55563", "AQAAAAIAAYagAAAAEF9Vq7kUPiundD8fJPSQASgC6xEAuyV+qCQiumnck+Z9VyRYhP8h6nwaLaJa8RnWxQ==", "79f54e4c-33a1-4c6f-af25-a217e2fa6eca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b120d8d-8a02-4773-8f0d-e859961455f1", "AQAAAAIAAYagAAAAEKjDAq9fb9pU4SR8qBOtul72OTj3ckkRVOuTrNV8DhD6Kdhx4DAzsJaWSIbDNDkbxg==", "dbe6465c-61ba-4bd3-a188-a7f95ee4eea4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dfa6ef5-ff2a-40e5-a38b-46abb50f4b37", "AQAAAAIAAYagAAAAEGP7QIJ5GL6ii+VQKIopJKeUye/OWSJDohToGOdvFWa0su3X2zDviKpV/kz/LblOsQ==", "9c9c4a05-87f3-435a-8cf4-b679a1e0a745" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("35cc7650-6067-4c75-9241-9268256fbc88"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("48245413-01e9-4258-82aa-dd71e761e6fe"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("4a53c644-6d2c-41f6-abef-4d891b855c7a"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("4cbca988-40b8-4111-817e-b46c5b7ff9fd"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("5e4ccb50-1a49-472c-939a-2eb6a5e46201"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("5fc1f930-0032-47ec-9e02-27198cbadc20"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("612ca576-bfef-4885-9382-97fad39e27d0"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("6af3667e-f6a2-48a1-8a50-a4505a582f33"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("bf751dbe-7482-4c88-8574-08ad0df80914"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("cd32375c-adf0-46a3-80c5-d8d44c7509bf"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("e7a57de7-a5f5-46e7-8acd-1e10c967cfa7"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("f65cb57a-d399-48d2-a711-74590a7a9904"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2b6c48b2-9d97-459a-8c81-712ca3536090"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(316), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(315), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(314), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("38ea57a4-d3cb-4237-b775-f14380a13e75"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(328), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(327), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(326), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("56d1574a-2af1-4ca8-b8cb-ccc18bd15694"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(282), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(281), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(280), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7ad84bef-c83c-492b-a13c-e1f6b9189a4f"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(304), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(303), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(303), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("86215e79-9282-44e2-a646-f5e2684886b0"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(310), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(309), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(309), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a2bfbe0d-ab62-4e4a-aa83-8c452d2d44ab"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(288), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(288), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d0c27318-9cfc-44fd-95dd-4ccffd9209bd"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(298), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(297), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(296), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e638903f-18cf-4e4c-a858-ee91a1699532"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(333), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(332), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(331), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("fa587fa1-6e8b-4aef-9e4e-9483967ef17b"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(337), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(336), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(335), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ffe6b238-e3ca-4077-9863-4c4e3bb0d7c1"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(322), new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(321), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 4, 0, 52, 20, 946, DateTimeKind.Local).AddTicks(320), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("02d77092-9493-4f62-acee-297d9c8f70cc"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(214), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("05651942-0f18-446f-92b3-7c1820155e1d"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(35), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("1088fe36-ff33-456c-b81b-3ce3ccc5b4ee"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(174), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("12705449-5842-452d-ae96-d21dc3dfe1f5"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(206), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1449344b-bf5c-426b-9684-9e209f6dc36b"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(229), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("196020ca-c9ec-4cc5-9f20-035db3855b69"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(166), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("1dbc528b-c147-48e1-94c7-6ecbea8bdc8a"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(11), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("289fd745-6e32-4647-b001-aa837c7a0e7b"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(236), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("3ba251c9-4ef8-4b8a-9b7e-d03c1af1eb1c"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(46), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("42f00944-e42a-4047-ba80-fa941af7e705"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9873), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("437bc87e-1f64-46b5-875f-443b8cad8e6f"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(191), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("4423d82c-02cd-474c-8c6d-03b6a973f312"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9899), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("464290ff-8893-4ae8-8afe-8123509c1def"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9929), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("4a0b48b4-d1e7-41e8-bafa-34da304c2f75"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9856), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("7d0f30c8-dd13-4fb1-b9de-3ec150ef9173"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(66), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("8ec4f42f-536f-4e5a-b122-ccf566bfe287"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(182), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("aab608dd-21fe-4181-bb11-9b81bec24586"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9888), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("c29d5275-2fbd-449e-886c-f1183a954df5"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("c5c3ab53-4595-40bc-be74-dd5ee67ff4dc"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(199), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("caf98b2b-1b4b-4d69-b62e-2e296c05f0ff"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(21), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("e151fe70-aa09-411d-b511-9675c596ea96"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9952), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("e7e49ee4-a6f8-4cf3-b3c6-2ae85e89e889"), new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9941), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("f0a1666d-0d56-4411-ace7-5b8449cbadff"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(157), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("fd857589-81fd-4b03-9c64-c1ff55effa82"), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(56), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 945, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3240), new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3270), new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 4, 3, 17, 52, 20, 948, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 24, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(394), new DateTime(2025, 4, 1, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(382), new DateTime(2025, 4, 3, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 29, 17, 52, 20, 946, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0db1c983-88fe-42b9-a174-e1446e0a759b"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9383), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("10c8cd12-1898-409c-aa39-729d59c7a0e7"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9400), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("1d16e81e-daba-4b21-9aa5-4aea894cafe2"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9406), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("4b282109-aeb2-47cb-8bd8-592090e711df"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9380), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("528a2dbe-8445-491d-a6f6-f327ae072c65"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9412), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("833d0080-1495-4dee-8d2c-f767e5f607e6"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9397), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("86c90a1a-6d9a-4f80-a609-67cb6b12b0a8"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9386), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("a045be7c-c517-4dac-a812-38d5214c9fcc"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9376), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("a943f4c4-dd74-408d-a672-6b5a12d85d5b"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9409), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("b03e26b8-9fd8-43d6-b10d-7adc892fda5c"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9403), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("f7de2917-582e-413d-adba-910014a94150"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9392), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("f8f12f48-2b9d-49b4-8bd5-ff48fd7c5b33"), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9372), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9298), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9337), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9331), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9307), new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 4, 0, 52, 20, 945, DateTimeKind.Local).AddTicks(9127));
        }
    }
}
