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
                keyValue: new Guid("1a92b086-854b-4dda-b9f0-c8dc7673ba3c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4b4bcaa0-28ea-490b-b72a-ee7edaac141f"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("651d185f-2f5b-4f38-a049-0004c4b3f49b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8a288284-9c19-4678-8992-a7f304d657a8"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("909d22f0-5d09-486f-9db4-593fa44b4830"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("9b45d882-47f1-491d-aad8-064678b761bb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b446f5b2-7129-4622-99c1-9cfb275daef9"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bb06cccb-ecbd-417a-8c64-091c8c6de0e4"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d1e57789-a119-477f-b0e7-2ca8f9f1c035"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e7019fb1-1632-4a23-9cc4-879a0c531e01"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fa86db16-9b28-4131-82ff-af41f283b191"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fc51c193-0bb4-4208-a43c-97cdafb329d3"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("1d9efd15-9147-426e-8105-bd8007af1f2d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3281ec32-01fb-4e5b-9199-acad5418a500"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("34086e48-8544-4db3-8f41-00bd096e808b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("47a33192-f794-4ae3-9edf-f5a1b6ef25c2"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("59be8ac0-198e-46d0-b3b6-219da0b46528"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("624a2f35-9027-4621-a71f-9745472247fb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8246b278-d495-470e-aa39-b509ecb57f01"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("85da839f-dc8b-4821-a991-e635ffc8a8a1"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a91a077b-079b-4e67-8006-bbe82812d0f4"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e7551df2-2a27-46d9-9c3d-67ef17f349c8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0053d4ea-c514-498f-9506-9c826773c21c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("132d31f9-622b-4459-ae39-2b95fadb739c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("18304b9a-1fee-40f6-8b3a-83d53d25e86e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1f5fc607-7341-4060-8ec7-14eb7dc565e0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2c29ca9f-2698-4342-95b6-499b1185df73"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2f375fd1-531f-4376-ad27-9e54656a0ae3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3ba64c12-62e1-4917-b174-64a0e3a44e4b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3d732db2-6ed7-4adb-9983-c6c9ec661833"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3f6b459d-a8a0-4395-a326-f76aef9bc0ff"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("465d4bc6-c22f-44ed-8e70-35eb373fb3db"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("474c0b87-ffa0-4e1a-b493-0e3c8e59b1b4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4af801fd-e032-4390-b426-ee9d61073027"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("540f8443-62cb-48d1-b46a-2386197b54b8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5a9662fd-6364-488a-8efe-69cf20ea7d30"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5edc6596-c7df-4548-8992-ac7787ab07e1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("72f5675d-0535-463f-bdfd-820ed8f7c798"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("761c6901-07df-488a-bb1b-cf94b184b518"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("80e48782-9e90-4bef-a7b3-928fb796700c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("82b9d6d5-ba69-4bdd-a888-c939407e18a8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("86383bcf-8d76-456f-b500-4b9c7ec009c4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8d0272c1-bc01-4f65-b4ee-d1bfd10b1e1e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9a9ba7fa-dd8a-40d9-9b57-aeeaff6e2864"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ac0b5154-7f00-4fc0-b28c-37f514bcf2ab"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("cf6a8b22-a798-4bd3-bc7e-d84f2f5446b5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("09e000ab-c012-4425-aae3-f37494ff7340"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("22d05b91-7515-428d-9968-eb95546e7ec4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("29857ed2-0291-444a-9d2a-d20b12a6e29b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("29c87374-19b3-46fb-841c-6a63f3e36ad0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3f5500d6-db08-458d-b2c7-51221b25f092"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5e527cba-ac13-4308-9928-b952bde4f2b2"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7c80dc2a-0943-4681-8b05-2463f29d7cb9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("7e3320a4-6da0-4c52-9803-ec47dfa47f32"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8fee14e6-e5b9-47c7-8707-e4d99f5d4d18"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b61512ca-e48c-4ece-afba-45ac12bcd828"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c3759e3b-376c-4bd5-97d4-57149c0ada21"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ea62e038-44eb-47a6-8fc1-5ebd89542d1a"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d871899c-f0b1-4cca-92c7-6b91fa6f5086", "AQAAAAIAAYagAAAAEFrh9LQ8caV5qp67HW8cD7h/j6Q5fPHIyf4FjZ1eJtBu+1MYqHNluJXCPdWiKRjQBA==", "a2e58e94-8595-4688-8a79-e5aac61f954b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ada608eb-b08a-4f9f-948a-f9b06a0253f0", "AQAAAAIAAYagAAAAEBUI2eTxpA+0VzFpXSxDYtqaXQOJ0NnQrUfWjlJRAUG6nf5J1ZDOU+QZRtur/GyMUQ==", "3fc6bb27-a00b-4060-b2c4-d47632d2c133" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47cab061-1e33-45e6-b4a7-5913186ccb7d", "AQAAAAIAAYagAAAAELHnLw6TRFacoCat5UKZYa7/4HnHPe5T+NFuNyKbeYHLyoTggQ3dcX9uVcTt1LlwjA==", "be00b3e3-b518-4855-b2d5-e179e3755e71" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c51061-695e-4d8e-a771-ef9bdea977fc", "AQAAAAIAAYagAAAAELiswReo4XGu/hxbBtlm1f3CKINpgd32kilUJUlKsdaJIRNTresrKTuySORLr/fYkQ==", "890af06a-1604-4dfd-aabb-879b2682ae31" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d73b16-a1bc-4799-a0f4-808646635510", "AQAAAAIAAYagAAAAEAHHwIpwHgUqVngKXsmf9qyyoja4Pz5CkJ2vq5LGPcIEJDIL1SKpeZtat6oU5YCd+A==", "b7bce468-466b-429c-871d-56d3451789aa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adf758d9-e825-4fd7-af91-92e3182d44ab", "AQAAAAIAAYagAAAAENfaxZ1+3qIW6eygKijWh5tVRLemJxhO24Baj6sytOWMr5BWOgvWaAZzwwW6lRKcaQ==", "698a031c-3d62-4f74-9156-f1db1a3c2007" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f46821-90d0-4f61-882c-f4303d02cb21", "AQAAAAIAAYagAAAAEBEIYVKyIsvqK8xllnlH9S8IgeNYo3R9ZSKiM4T+zJBNXQtcPbfc5h/7Y8ok9B4RRg==", "e4b3698d-4e2b-4954-8b05-c64812093d68" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "329b9621-c39a-4079-a1c0-855567c8ffb2", "AQAAAAIAAYagAAAAEA5iHGc1tstcG2Ui5phFIZLYECkqkEHK6ptuHLcWOg52K6dfRWGNGvHhrDGgMsp4Nw==", "91ecc83a-fa3e-49be-86d7-2839fe709951" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d98c6fa-8836-4f66-af3e-318ceb9fae72", "AQAAAAIAAYagAAAAEGMo4UECn0qTLyBFiJyQEOACC37Ly+AP3yhIEglAsu94XhO837E145jaY6u7Podj4w==", "31c5d64c-e351-4f56-8ac8-787fa3b8e7d9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ab8f385-df2f-4d47-b0d1-17fa2bfa0f30", "AQAAAAIAAYagAAAAEGkAcJNjzekx0YbknNAVbIGNch2Yif9W4CA7ne6338VqtbFfNpbAd83kOKYQ+Kr6LQ==", "acadd66a-0961-45ff-86d0-27110a101c0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c75bf6-c43f-47de-b925-be6cd7d9d64a", "AQAAAAIAAYagAAAAEHCGdyAbta6/mnPvyvlzExUtlOm80JqZjWz7Fr9cLEmAd0mdPrlxT5gFJVQrcICdPA==", "bcd790f2-aebf-445f-9543-d4b19e3a840b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf8bfff1-7b20-4df6-b2c4-97c5b1744fd1", "AQAAAAIAAYagAAAAEDj5kyLDjDxIRU2Gca6DunfAlsXdREAJ7gio/Qd5lgkCAz7XPGp/dwmpaXXK9aM1LA==", "b03a6991-abf5-44c1-935b-32061a0e5787" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "763a0a9e-5fb3-4c35-91d5-6927100ea4e0", "AQAAAAIAAYagAAAAEE+82IVuJE3L47ybgD8e0gk7MgMe9DRrebQus2jdxhDHFXMv1q3E0D+hbQGCwHucFA==", "673ca00f-8f32-42d4-9d46-74ea83de7d1d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f204ce-8895-4736-9c35-aadcf9f922d4", "AQAAAAIAAYagAAAAEJfat8kOFG2+PPXib4ZS5E2kXtDeoqjDf+eM9uBAEhL5QPYW/EevvUNHocdPwFvVRA==", "57d5bd28-7fc1-4ac9-b3b8-2919d61454b8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb65e156-80d0-4e11-9717-785f177362eb", "AQAAAAIAAYagAAAAEPAcwurFryiYD/JDh49BM5zpgVAnrIzBv+uf43hW0PF3Mdz+u3Rc39V2Qd30nzZ7Tw==", "df54bb6f-c76a-40db-ad94-ca98e8e10dfd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b727636-f9d2-4d0e-b6c5-eab965985528", "AQAAAAIAAYagAAAAEC+FJ+dNjup0IcNeKYyGV4a6Zue5gFQg2Tz3jMActeKnCWlcvUDlzzQjbZzgpP0e+g==", "f0f868c1-ba4b-4777-bc9a-2d5faea43a5d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06f09251-9853-4f72-ac54-4f96720a2fc9", "AQAAAAIAAYagAAAAEDW66FLTClshldVrBqUUh9F6dNvLsw123OIfLBHp9arL3wy8VwL8DCiM0MlTsrB17Q==", "e429c330-7543-4835-8d85-fa2e14cecc7d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a866e1-c0b0-4327-9a81-c99b26185776", "AQAAAAIAAYagAAAAEDLFjkwy1390ZZgXYXdtENHOC6baiWsmPJAZ085aSrjnonAGrtzJmBDsU/MRA1dihg==", "11ff803a-63a9-49fd-9853-64a389f4f0f1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02d1f78a-3b84-439d-b5ca-908486779677", "AQAAAAIAAYagAAAAEGNg9fVSy6aBjd0lpTMi/PP9ZsSXOMQRFxN3FY99IOQueQbErX8eHw3mZeDExOSajA==", "aa3db3bb-8c03-4bc6-b879-bb8f215e1bd7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "310ddbb6-5cd5-4148-84df-4ab46d2f0ee6", "AQAAAAIAAYagAAAAEIEzVoj/JhJgtTSxkh/8ARqw6luxblvrHhID1QdsqSSNzUvznyz8Ak0FmqXg3KJwbQ==", "fe49bc72-4655-4e83-a743-2b013ddeef31" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be52a415-93e3-4df8-adab-c71878a37840", "AQAAAAIAAYagAAAAEI8TUQAe/Xx2A5k7Ew5+U2kfFwmGCDOC/BBU+g0TXFdR8XbsqAGpy11bmGdoYbw1vg==", "d795dcde-c9b2-41a8-83f5-929a8adf147f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d951202-3a08-4347-8cd0-46f0fec1dbaa", "AQAAAAIAAYagAAAAEKgxT4/fhoHNMwtjP57HoJp0VYf1K9liU/OP8oHh/wXE6/13A7xgB1fDbeSfPNSRGA==", "89c99a13-c226-49e1-9c0c-f8d41ad0c2e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcb8ca00-4686-4555-87fd-62b9b6d0a652", "AQAAAAIAAYagAAAAEL8XnxmDN5yWFQl0UM3u9pfmiXz/VEcMNxDoknA4hrSe9inqcEeCUZ3xjd+yyJbfDA==", "4957bc2e-dc4a-46ac-8a21-47f70870fa4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c44693c-e109-485e-ad5b-79e3957adae5", "AQAAAAIAAYagAAAAEBpIsxYqsqNgvv8sPZimr+DUqt4HBcDNl3FuwieP30q9JPpmhtX3imeRccA3NNnMQw==", "b4df880f-01cf-4ab4-b5a8-a86fb0d328a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71c32d4-c165-450b-a6d1-cb06adabae7d", "AQAAAAIAAYagAAAAEAU4Y8XNK6gbeD3E1p173bGKxqnM5IKe8JF+rWJVCK1fO57KmVJCZR6GB6ytg7U7ug==", "0252936a-cdcd-43f4-a3ee-e691e5230d8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68eaee40-e7b2-4a46-b4d9-679781d32ac3", "AQAAAAIAAYagAAAAEMnVYOa8kBMHijv6uLwyzfEEK1Yi1YbRZPg7OjjCzbDtW9DLeJiaZqWsOGoVvAxKhg==", "3b4aade7-b983-4fc1-b79f-3a52e5c173ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d4f350c-4c96-4640-8f78-5da30af7d51d", "AQAAAAIAAYagAAAAEFUNiRCv8VuJr0D0V5YbEt+8MAVG07gow6lPehq5CxXieiunKmr4ZLSudPgY4R8AlQ==", "8184b9ad-d56f-4649-bfc2-8703ca9a16f8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68dd7522-94cd-40b8-b038-cd680376a420", "AQAAAAIAAYagAAAAED0OJtH9QLfO0bSZrBen2BMaMPRETfnHjJiQkbWaJAa7jzuioPTZV1gQxv5KYCZLog==", "f727ce77-e044-4a86-ad56-0852df34f94f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbfe3b79-4ce7-4735-a843-76a5020063d0", "AQAAAAIAAYagAAAAEBma09D1M9TliCLrY4BMUBg+hWsMcdMYdHMoqol4BkE86HvBCdH1St8hKNqWO0//jw==", "4d480a83-1f90-4b1c-9514-c767ea396f59" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439622ec-8a39-4d1f-a42b-59539870f06f", "AQAAAAIAAYagAAAAEHjQJ4cEDVWT20wBbQQJ93LR3uACUSh2sNtCP8zmK/qZCpZW0+lm19sJmnrYGskmhg==", "023cda25-f4f9-4864-81e5-ed10790bed5b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4623113-a499-4fee-8c62-7d6f63f1d964", "AQAAAAIAAYagAAAAEM01FkqfCXstkC3fVPdnJaXLwBo8x1CLHK/PK4YVRoxpkS8Yq1iwoXXiNmKcpW3D9w==", "fc55c75f-a5cb-4afd-ae42-47585180adcc" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("2bd6c9f9-1a3b-4479-9352-6105f086eeb1"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("34b04293-30f6-4797-b805-6aa4cae36f5a"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("3728f404-5afa-49c0-8083-9379e2bed7bd"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("4722f50c-9616-4c39-b852-65de67eaf6ff"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("70766350-5c2f-4b0a-8085-3dcfd2150f3d"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("94318eaa-ccd1-4aeb-b357-fdd2d9893d65"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("96f5e1e4-bc9c-4062-8b4d-09ac5605ece5"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("a295d26b-4cfc-4086-83ff-cb794316eb90"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("c7324c25-cd9f-4d48-9e08-43ba2aae74c7"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("d32d1a69-16cf-4051-aa1f-f6643e9211df"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("d5782112-979a-4302-9eae-35a8834e66ce"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("df6b813a-eebe-4d7e-9528-e7538dae270f"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("02d4916e-73ce-44e5-bb21-12427e605ed8"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4301), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4300), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4300), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("084b154d-11c2-46e8-b2df-d4c2195c946e"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4271), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4270), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4269), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("63ce3da6-2722-44f4-9c17-390ca8a77473"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4295), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4295), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4294), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("6f1dbebb-f034-4c7d-a540-92f03e8c50e8"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4308), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4307), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("783e974a-ed57-4dd9-a776-94924c175e23"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4314), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4313), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4312), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("924e7337-c86a-447a-ace4-936464786976"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4289), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4289), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4288), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ab4bd758-af83-4a56-9326-140d4b476ebb"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4283), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4283), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4282), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d1a2a0b2-add0-4c99-93bb-0d11456a680e"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4240), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4230), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ed19c01d-bbf8-499e-8616-d9f0f26be63e"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4319), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4317), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4317), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f7224ce9-4f8d-40f6-aabd-67d515c5675a"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4277), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4276), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(4276), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("092f90dd-5669-4d2f-9564-6a16338ca71c"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4018), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("147c655c-b670-484f-9298-a5adb3d521c9"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4073), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("165150f3-327a-4617-9a56-eb4245010962"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3778), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("2832663b-7c0f-4d9c-926e-abbaeb7c4197"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4042), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("332f7e0f-10a6-48e7-8913-666698cb7336"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4026), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("3cbf247a-a471-4e70-b2a2-570026d29914"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3824), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("42dd14a2-cb4c-485c-8e67-190d3ac7af16"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4006), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("50bfd817-7b84-42f7-9e5e-dd615937ada2"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3841), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("60c010c5-41d9-4e1f-a258-a743f33c8096"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4034), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("6a6eb1b5-3fae-4034-aeb3-5cbc4a96cde3"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3900), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("6fc5977c-a284-48e5-9c12-f6c4547b5c5c"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4082), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("7788d14a-10ba-42f0-9ead-f02e5edeaaa8"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3765), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("888979ad-b85c-410a-b226-7a0d69e9e45e"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3795), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("919095f1-a1af-4cbb-ac8d-42170e2e0a73"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3908), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("985b4fbc-660c-4d17-8a2e-1324121c03c4"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3932), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("9e964021-c2db-45c6-a2bb-9d78b0fa56f3"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3883), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("a358de4f-3db4-451c-936c-7bd8f72ca497"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3924), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("b039721d-b3ee-42f0-b8c4-9b31f9063add"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3892), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("b5900194-a6cb-4319-bc52-d4832d9c637a"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4050), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("be92994d-811c-4745-abfc-1b920314286b"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3833), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("ca0e45f0-765f-40af-bdc7-12031295ea5b"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4065), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("ca200f81-57b3-4252-9dd4-88c78c3dddbe"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3916), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("ceab7141-e378-40be-8e9f-6f19668f9a4b"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(3787), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("e6d14389-7531-4098-b319-53e81f541d56"), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4057), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 158, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), null, null, null, new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5630), "Mô tả khách sạn.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khách sạn", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), null, 0, null, 3 },
                    { new Guid("10000000-0000-0000-0000-000000000002"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5641), "Khởi hành từ bến cảng nổi tiếng của Hạ Long.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Cảng Tuần Châu", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), 2, null, 2 },
                    { new Guid("10000000-0000-0000-0000-000000000004"), null, null, null, null, new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5614), "Mô tả lái xe", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lái xe", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), null, 2, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5521), new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5546), new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5554), new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5564), new DateTime(2025, 4, 6, 17, 56, 25, 163, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4413), new DateTime(2025, 4, 4, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4398), new DateTime(2025, 4, 6, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 1, 17, 56, 25, 159, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("361246d2-6e2e-498e-85be-1ab9d8ee5e65"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(153), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("3ac24e46-be6c-447c-9019-dbfff492b08d"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(150), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("52097999-1837-4339-8339-8cc12bd3786c"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(174), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("647541b7-ac44-4f8c-9762-717452b46f1e"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(167), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("761e6621-aaf0-4a31-8e5c-fc96b43b2b3d"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(171), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("79340588-5ffe-499b-bb11-d765b14a427c"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(160), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("8e4930fe-7afd-4173-a027-e6bc95cb0245"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(180), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("a3cd8ede-73d8-485f-8fb2-cfd2e44f0bf9"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(155), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("d2a11530-3368-456b-81ae-e53dee1c8217"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(164), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("dd548a3b-278e-4171-9b92-6c2b2440274a"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(169), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("f666b921-3136-45e6-a640-1c4657335e76"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(162), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("fde1b356-9363-476b-a21e-7295982d7ab5"), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(176), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(90), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(72), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(94), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 0, 56, 25, 159, DateTimeKind.Local).AddTicks(48));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2bd6c9f9-1a3b-4479-9352-6105f086eeb1"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("34b04293-30f6-4797-b805-6aa4cae36f5a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3728f404-5afa-49c0-8083-9379e2bed7bd"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4722f50c-9616-4c39-b852-65de67eaf6ff"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("70766350-5c2f-4b0a-8085-3dcfd2150f3d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("94318eaa-ccd1-4aeb-b357-fdd2d9893d65"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("96f5e1e4-bc9c-4062-8b4d-09ac5605ece5"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("a295d26b-4cfc-4086-83ff-cb794316eb90"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c7324c25-cd9f-4d48-9e08-43ba2aae74c7"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d32d1a69-16cf-4051-aa1f-f6643e9211df"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d5782112-979a-4302-9eae-35a8834e66ce"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("df6b813a-eebe-4d7e-9528-e7538dae270f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("02d4916e-73ce-44e5-bb21-12427e605ed8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("084b154d-11c2-46e8-b2df-d4c2195c946e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("63ce3da6-2722-44f4-9c17-390ca8a77473"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("6f1dbebb-f034-4c7d-a540-92f03e8c50e8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("783e974a-ed57-4dd9-a776-94924c175e23"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("924e7337-c86a-447a-ace4-936464786976"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ab4bd758-af83-4a56-9326-140d4b476ebb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d1a2a0b2-add0-4c99-93bb-0d11456a680e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ed19c01d-bbf8-499e-8616-d9f0f26be63e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("f7224ce9-4f8d-40f6-aabd-67d515c5675a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("092f90dd-5669-4d2f-9564-6a16338ca71c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("147c655c-b670-484f-9298-a5adb3d521c9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("165150f3-327a-4617-9a56-eb4245010962"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2832663b-7c0f-4d9c-926e-abbaeb7c4197"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("332f7e0f-10a6-48e7-8913-666698cb7336"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3cbf247a-a471-4e70-b2a2-570026d29914"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("42dd14a2-cb4c-485c-8e67-190d3ac7af16"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("50bfd817-7b84-42f7-9e5e-dd615937ada2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("60c010c5-41d9-4e1f-a258-a743f33c8096"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6a6eb1b5-3fae-4034-aeb3-5cbc4a96cde3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6fc5977c-a284-48e5-9c12-f6c4547b5c5c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7788d14a-10ba-42f0-9ead-f02e5edeaaa8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("888979ad-b85c-410a-b226-7a0d69e9e45e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("919095f1-a1af-4cbb-ac8d-42170e2e0a73"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("985b4fbc-660c-4d17-8a2e-1324121c03c4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9e964021-c2db-45c6-a2bb-9d78b0fa56f3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a358de4f-3db4-451c-936c-7bd8f72ca497"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b039721d-b3ee-42f0-b8c4-9b31f9063add"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b5900194-a6cb-4319-bc52-d4832d9c637a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("be92994d-811c-4745-abfc-1b920314286b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ca0e45f0-765f-40af-bdc7-12031295ea5b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ca200f81-57b3-4252-9dd4-88c78c3dddbe"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ceab7141-e378-40be-8e9f-6f19668f9a4b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e6d14389-7531-4098-b319-53e81f541d56"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("361246d2-6e2e-498e-85be-1ab9d8ee5e65"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3ac24e46-be6c-447c-9019-dbfff492b08d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("52097999-1837-4339-8339-8cc12bd3786c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("647541b7-ac44-4f8c-9762-717452b46f1e"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("761e6621-aaf0-4a31-8e5c-fc96b43b2b3d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("79340588-5ffe-499b-bb11-d765b14a427c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8e4930fe-7afd-4173-a027-e6bc95cb0245"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a3cd8ede-73d8-485f-8fb2-cfd2e44f0bf9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("d2a11530-3368-456b-81ae-e53dee1c8217"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("dd548a3b-278e-4171-9b92-6c2b2440274a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f666b921-3136-45e6-a640-1c4657335e76"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("fde1b356-9363-476b-a21e-7295982d7ab5"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "173be822-ebea-4450-bdac-abe80caff680", "AQAAAAIAAYagAAAAEMGwW+j7B4Q9LQYGwZb/RC6kw287RIo0H48UbgHP4iqpXU8O1rgQqZ+NDL33udyAGw==", "fa744afa-2c7d-4873-81ac-9b4ca0d36f32" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78723d35-9938-473f-8dfd-ba30cd10768c", "AQAAAAIAAYagAAAAEDWoBK9mrVzI0W2/ZRty8/PUnbLvEFdKNwvfkQRfw3T6w9QjChChEk83u5J8oiOX0g==", "f3142731-ec1d-4974-bd8b-84aaf338914a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5991262-3229-4401-90e3-008bc04c8b5d", "AQAAAAIAAYagAAAAEIctrHH8fpfPATsdbyOKYVbzGRLuN4rTlBGWM6jWm++uln9UclVPyPd5KAsxTLtStw==", "ff4f8030-0a6b-466a-88c7-4f80b76ed095" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17967978-5e10-4617-9ceb-ea71ce4b9ff4", "AQAAAAIAAYagAAAAENa0VZhceKdGvGn4NVvOZxi0AH1azhfCbskxYtlIdxbHO7E40kpxMxXGExtrvOut1w==", "98a2c910-de9b-449a-b941-2548a3b18dd6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f737ec97-e748-4dd6-85d3-3d165ab9362b", "AQAAAAIAAYagAAAAEKSqoKfKMRtFgoDS1t1RCJi3CyTA4feQcSLufFyYASzWhG2kndlCbEQe+ycPCfVYzQ==", "53f96886-150d-4f43-8a60-d3ebb0b2663d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8916772d-c45d-4108-b436-af3abef07098", "AQAAAAIAAYagAAAAEE55u9tIbNhqjBHmXavTr6dGSKDqSnBeAy79GbBxgM1xvJNgTO2Gq8B8tfD272eBpg==", "298a10f1-fa67-4a5a-9620-81569cfed0da" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f246e0fe-397c-4d47-8c4e-73e9a7cc5a04", "AQAAAAIAAYagAAAAEFVA12TcTWNsiv0Dc5WxG88M3/yYIYDIXI0ryCr9NguQPM44delee+vAVpuSZX821g==", "d92d40de-ec12-4277-8654-caa1ca1c119b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d1b16a6-d020-4dc8-8e4a-725096c4d06b", "AQAAAAIAAYagAAAAEAITUxNZV0zw3GcFDuzTQzoaeHQtNIDIAJ2Px/eNyMtRcsFCV33v+ra0NmBW5WIXig==", "5b5f67c9-7d1e-47cb-ac73-a011e114d6fd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ba9787-c051-439a-b7b3-1b92f5392517", "AQAAAAIAAYagAAAAEInkZtelF797PdrkIylY89bvI76L3ldCRmWWeYG1i1C75NnCnls03U17O/xzHI+UHA==", "449c1ff2-43e7-4d2b-ba80-239c738d48c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8c81651-20c8-4585-919b-bc5317364598", "AQAAAAIAAYagAAAAEJQJzbjLl8Vbq8Qv/DVGXWLRpRzGmSy35PgzynsZxDHG9Bf8/UECcjy5ahlrmfMnFQ==", "5461991b-6621-4b1b-a40c-057a6e19731d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea1c5414-372a-4bed-a32b-6d4918f828cb", "AQAAAAIAAYagAAAAEE4gUQqZmiQTCG6yk8jIUFXEX+hLOt2xLNZjtzRTVewQxMEBCBcPxMZmip5HgZ12zQ==", "7514754f-94aa-40da-ba69-520b52a8f503" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d487fb8-b10c-4b2e-911a-6e58dd09f3a9", "AQAAAAIAAYagAAAAEPVA8g8DRUOn3osJ+hJ3BpBvGHLVISBohNwJVAp5kxRJfbvbuyFtG1Vw47TxycCwvA==", "91e7cb41-f3ff-4756-aa4a-2285a7b0b471" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db49cff2-4235-48d4-93b8-46708f758de2", "AQAAAAIAAYagAAAAEHK/F5hdvwW1+d4Dlb/nCB4OKRqf7L97PFUnN/pziOtRkhIp/YfBHhrhlL1+fzXZCA==", "1f3a97b8-58d9-4e91-97dd-7c082f524307" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11bdb5ea-0418-42d6-8078-0e5a0072499a", "AQAAAAIAAYagAAAAEEQfvExhT3W4MH69Vk2+fhsUumUUzaWomFw2vaP0DBGZFQkOOk6a/2f0L3mthRJhTA==", "7bac27bf-8de1-4e4f-ac22-2cab6117fca3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8f6f2d-762d-4840-994d-7586e1f7c27c", "AQAAAAIAAYagAAAAEHlxJXaBmAk8li74VZHmfWSg0sd6dl1WJKZ1zMIrTjiOjtEWDjryJXpd3pWB9pcbTA==", "29d88921-9fc1-414e-ab3a-c0a0fab9a52e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "366803ce-998e-4bef-9456-fd4021bfaad7", "AQAAAAIAAYagAAAAEKENL4PQFbERs3oIf8jkm7llul27WcNp4JfDAEvmPbBMMTZIhgjFkrMKw9VJ5S6wfg==", "d8e33d5d-b3f1-465d-8f20-bd51c9ac4d4a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81cfe9dd-13dc-4dbf-b68f-3cd6387cb3f1", "AQAAAAIAAYagAAAAEA4uxI8lFbN777IxvAqIUMLYahVH9edXFlL2JmkJ8LkPdQVQDeJRH3Xyr7hRkMDstg==", "9425e8e5-6a45-422b-8b09-bcca19e31931" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80e60fb6-b64d-493c-9c57-d7771019ae2f", "AQAAAAIAAYagAAAAEPwxKXGhoU3hzr2PUrbUtWbRikuxH9WqIdqHFvSW2DvHgvY642v7uI2xsKgsgtvDag==", "fdabecff-6d4e-4aea-aba9-34bd4893bbce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839c352e-17b0-400b-ac77-b522fa1c64e1", "AQAAAAIAAYagAAAAEL5G/74RLO8yhxckz2BcM9MzGZyrhzBkSkQBWkqY5FaA1wizk5ztPepv88VF6gJqtw==", "3b706ea4-f0f5-413f-96fe-5163a3b5f1dc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bad10bd4-94a7-4e87-a904-523d867886a8", "AQAAAAIAAYagAAAAELNyDRlgFsuPC6Z3cPAtWfcPj4gQu87w0EUfaI5YkFxMVjZxoJi5geW5swRleCoEdQ==", "879d704a-f22a-4e3a-8cf7-5083f608b25f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2db38c3-d2cc-4a42-8586-60b9358b5eab", "AQAAAAIAAYagAAAAEFGc7UVnpoX2XuhON4haZ1DbvUVQ8WHbZmYvPNfGH4mGU2av7D3s8/sXb6GnDAM0cg==", "4bd7eb65-a0d5-4f79-b2b9-2a0888a4e79e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d921bf28-7643-4b41-a4d7-f6574b29ad99", "AQAAAAIAAYagAAAAEOWEpzAXr2eB6RoidN3o0f98SyXxpKIiETTMGsWamtS55t0phHR+2z2Y7U6ItXNHDw==", "aa240f34-6cef-4dc7-bbb3-96f773355659" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52e462b8-27cc-4d79-910c-08cd4da0e0b2", "AQAAAAIAAYagAAAAENZsmUYm3UEeR/+U/4h6fBinPZAnM3PbvToWiv3+74uzExUAp+lXdEuhiDLRy0521w==", "5beaf66e-305a-4f5b-9e6e-271e1e0a7c58" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "757a78ca-3b0e-430a-91b1-a24183625972", "AQAAAAIAAYagAAAAEImimm4FlbQ0IwX7c87AD6I8unJK9iEYciZeqRO+QyJvIAvJ/fcOdlhy/IVqhdLfyA==", "bc8983c5-e533-46f6-ae11-7350ba780316" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5264751c-2ac7-43fb-922f-8baf03668317", "AQAAAAIAAYagAAAAEAUYivk0gGbrfXlr+xmW+o9VvGWXdyxi9phxbSOMzRCBSmtp9XL4YfpaQs5qWlupiA==", "b58303ab-2437-47e3-ae76-b11ddb780882" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e30e58c0-749d-432a-8b5d-aced6f8c5ae9", "AQAAAAIAAYagAAAAEIvH7tBZUywCjWLms15hgecsdRVyGWxpWilF13xNhNi9jiZh9rtNcOhSh8GIbywHZA==", "d8e00974-6a78-42ce-935b-251160853af2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74b3e239-13b9-4714-bc8a-a08f013b89d4", "AQAAAAIAAYagAAAAENUIth7v3KRzKh5c6OEvZYoPnAV7375oRu+BATbFl4TwaoxHiI6OJpghLU5VzOrajA==", "290160cd-b686-4530-bcbe-d04db7da98ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b403897d-39ab-498d-a374-bfe2c9fe8ad8", "AQAAAAIAAYagAAAAEO2jo0SWboTvBmI3cJlwCK49I0KLAzwRVXeznCgREC68qATqNKLl97gh4sYCb4RLrA==", "1946e1e3-cede-4387-b307-0f2815b46f42" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5c44168-9757-4eb9-ad47-6023f6c08db1", "AQAAAAIAAYagAAAAEN3viPLqyPx8htpzlJqNyp/c4E10neyzDcg9+SjHYi3qA6817DkPHcwBfRXoAcOWgw==", "f4fe190b-d6e3-4dc9-9fd9-2a6e044ea957" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ae477da-cd65-4245-a3c4-7945bf4caf12", "AQAAAAIAAYagAAAAEH3BxZiqMsWj2m7F2C1vnlLsiiZGK7+fzwi0t9pXfWIno0hrwfwgZBkY6cSWZjsytw==", "b741a8e9-f323-41ac-9e7f-67dc847441d1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a4d4be-70a5-464f-bb06-a6a7202b437a", "AQAAAAIAAYagAAAAENuGXau+ZhW2wzhU0tzoGGCVonjqEFbtawWBQEZmbA/pflMjzcMezmUp9FVQd2yh9A==", "9b73e10f-f8b8-42e7-b7a2-9164abaf4e0a" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6648));

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
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1d9efd15-9147-426e-8105-bd8007af1f2d"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4943), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4941), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4940), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3281ec32-01fb-4e5b-9199-acad5418a500"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4971), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4970), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4969), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("34086e48-8544-4db3-8f41-00bd096e808b"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4983), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4982), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4980), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("47a33192-f794-4ae3-9edf-f5a1b6ef25c2"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4930), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4928), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4927), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("59be8ac0-198e-46d0-b3b6-219da0b46528"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4901), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4899), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("624a2f35-9027-4621-a71f-9745472247fb"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(5004), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(5000), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4999), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8246b278-d495-470e-aa39-b509ecb57f01"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4886), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4884), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4882), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("85da839f-dc8b-4821-a991-e635ffc8a8a1"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4959), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4957), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4956), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a91a077b-079b-4e67-8006-bbe82812d0f4"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4994), new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4992), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(4991), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 79, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 78, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6812), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6851), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6868), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6887), new DateTime(2025, 4, 6, 15, 35, 17, 87, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5231), new DateTime(2025, 4, 4, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5204), new DateTime(2025, 4, 6, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 1, 15, 35, 17, 79, DateTimeKind.Utc).AddTicks(5214));

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

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8447), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8410), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8465), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8456), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8427), new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 6, 22, 35, 17, 78, DateTimeKind.Local).AddTicks(8366));
        }
    }
}
