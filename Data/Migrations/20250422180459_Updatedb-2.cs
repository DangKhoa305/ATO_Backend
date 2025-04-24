using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "RequestReSignContract",
                table: "Contract",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8c3546b-246b-43ec-bb26-3f8c646df79a", "AQAAAAIAAYagAAAAEP8h6NSmnFY1HsWFsun60LfIwITN49IjgRNLlVTF5X4RtfmDUuWzxZ+Yiq4WWOzjPA==", "9eace141-5918-413f-a7f3-72a95bf3f4e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e307951-9859-4d9b-a47a-6ed331cb02b6", "AQAAAAIAAYagAAAAEAD9FNtRLW3InuEIDErvXGnA3sRMOp4OVk32TaHietcV85p0BAexADCx9dFMxIv2rA==", "3f19ca1d-59d1-4a5e-b6b8-bc0089ee235d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b97d9090-14bd-4e15-ac99-d0c8c6daedaf", "AQAAAAIAAYagAAAAECQg7gr7JfP25nZwWuNISuecmQfSa/1C4MehEZ94R3TLZZsIdauUyKPAGdUXo3t1xQ==", "229081a5-0022-4bb6-9ea1-4b00c1a66004" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0319e083-31b7-4606-b478-a0e8e1c99069", "AQAAAAIAAYagAAAAEGV83+j+3uqu0z7lVii4xPV7rfphBF3hkmHWkDdWjgWq+IyZANgWp+DO8FOe3rHK+w==", "fa4cbb58-3b16-49d7-9424-428109f24601" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e3c2a12-2914-4f9b-9e96-e713d5361ee9", "AQAAAAIAAYagAAAAEA4Jbjp72EKxW9kwQoutGkJMLv7B70327jjcuGRqNFmVTbOxDBdK8EJJVngIUbdjQg==", "3d4d81a6-4ea8-4049-9357-4d6bf18d21b3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2186718b-92e1-4c24-8594-d27f593331f5", "AQAAAAIAAYagAAAAEE7yhQ/sEEr0X0oGPQytAqIiDotLtQa9EOeG0YiB5GVFkKggvg7+uA2yNW21QaBqxA==", "1222fec4-0bdb-45bb-bd16-e1abf8e4cb49" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25a1b24f-edf1-49e5-a187-f79e3a461eb0", "AQAAAAIAAYagAAAAEE0E/Vd3nTgbUROOiD8c6tUhMaSW65/28WA+6NsoYGlf79AkYiBBO+PJfdagBHnJXA==", "af509043-66ad-4fd0-987e-dac35f148bf0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3246571d-9860-4665-81d1-bc79fb5c3374", "AQAAAAIAAYagAAAAEN55+p7sQfg2X5mt9RiqKX3RM/toNJ4rhc1hEZ3ArybDtscCqJ1rEcL8xFtv24FftA==", "f30dedc3-fa80-4d31-be81-6afd623bda1f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a7bc965-8d48-4313-b60f-26e9f28b493a", "AQAAAAIAAYagAAAAEDljY6EQaiFjvbtyzHvnmA2coRwKNdACc9sVCY2DvIjTmyopik4RZU/F0S7lbJ3dGg==", "fcba52f2-9116-4d10-82e3-75f1dd5784ca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bf38280-75cb-4f8c-a8c6-4c6be44e89d8", "AQAAAAIAAYagAAAAEM4otHVZEVaYUxiyJP/bdBqu8gpT/q+QuyLTSmxo6bqeqxnurH5dl8IH0l2a0MvU0A==", "aad3e50b-49fb-417a-955e-dd52a6de509c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7834615e-5c61-4d62-8dff-eecd856c22ce", "AQAAAAIAAYagAAAAEF8SD2AEQ3xHkf8ewt179S/Owm4BnwSLJz7aQ67Q2M3h/3Y1cF0uZ/HHsDjEL00+Pg==", "9d38e723-b028-46e6-84a9-01cc1bf6c47d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f443ad9-bae1-4485-ae80-e87dad7a0059", "AQAAAAIAAYagAAAAEHZhkB4regblbuBWuViU+VZh2v915ZJIfSCh130f8dM2m1/h+7MPzW2u8bGYB2xZXQ==", "329bc0a2-d092-46d7-bb4a-068cfcd97383" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a19389-2773-402c-aa81-f0026e0d9ec3", "AQAAAAIAAYagAAAAECwIW5HxsjwZpN+DR9Xb7vvkC0NX3YGURwZ2HZ5mXMnicRCYfxux7ozMR4nnjqZJcw==", "4e9aaeda-fd81-4f23-bfeb-fe46a7ed0249" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e31ea58-a9e7-4fbd-ba19-9ba45f4ea615", "AQAAAAIAAYagAAAAEB8iPjKxlQLvcC8UqwHfn6kTjSRremzpoXuZbEuOe6c8lGrrTKn/jedMVupFEOqL0Q==", "9ab97a36-7edd-47f0-97ff-fe3c5546e6d8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceb155d7-0390-4b43-9136-643d39d713cb", "AQAAAAIAAYagAAAAEHAR3aDP8yMgY6MKZUCThxr9k1uYTs6CfoyGmejnOJJAdvvvpE9JsBBkF64HfF6Phw==", "ff293c91-a141-4cc5-b123-5f3b435a3026" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4167510-8c1f-4864-bb8b-1f9a79c9f4e3", "AQAAAAIAAYagAAAAEGAcJpqKbkGsNccGjeO+6G65dBXlrWSlkzP2NhCh7o+kiRfR4oI3XFTfLf5IbEjh1w==", "42f3236f-25c3-4601-8000-c7254d1dda5d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2d0b58c-7114-4814-a19f-7d4bbac99560", "AQAAAAIAAYagAAAAEGzCqXeGt6b7/u6YbU6CZjNevH0CHZlly/NG++6mWoK2ZTmdmx1rRVng4CPAXjk26Q==", "634383fb-be11-4ec8-9278-2a9c3e7f25ad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4286b04-b1f9-4905-9a60-c25fb6e74deb", "AQAAAAIAAYagAAAAEFGtAL9oV1Z8PWFYS/N4HNbKZU8qdupAz3Q+2YHLg18xzuo4qEbT0RUf2dM8OIBOTw==", "ea49062a-ef87-4dab-9dce-75de6f2203de" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15e80dd9-14be-4352-8135-af5df6d613de", "AQAAAAIAAYagAAAAEKzDRm3YCYkle6rYx2/FkhIb3SmGEOKRLEk+Lsqy/TJZeUTO4WpdN6qkxSwWj9sUNA==", "ad1da4e2-9457-4c24-bcb6-1b1da388bbad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38152056-1d9e-47c2-8cd0-723a62f61102", "AQAAAAIAAYagAAAAEOfRU6eRsWkr/AB26LI9NhfLaOKoJEkdqyn5gtU3pLrJSm/5N15nU8oBrCtdttbaQg==", "f1e84d27-7407-4df9-aa40-7c551ad78f95" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23ea6501-a6ee-4448-be25-d5dc5a25965c", "AQAAAAIAAYagAAAAEHmGNfymz0KT0vy6+spgtAl38lr61YXGRuSwoRTtsxKIvq8FE6aBVL4kkQ0lQOravg==", "7354e169-1668-4d5f-a2fb-1962bb5686f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f7b80ec-7f87-4041-a478-881d8fd3e340", "AQAAAAIAAYagAAAAEMZZs3j5946k2HS3EQxhOn+D2lhi4PBQhKUN3sVcApsQMeoI25qb8frGLOEqiRgC1Q==", "3232025e-2a58-4cd7-9e34-1c7bde784b5f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f19cfbd-8c16-49cb-821f-54b0a075d432", "AQAAAAIAAYagAAAAEFI2Pg1gN5ZLyBCwPau10zFnJpEM5udsFH5L/r+Xl2a4Na2DZ07M79NfIU2PaIo4vw==", "356e506c-371c-4d15-b738-adc6be2db658" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e59b76-4216-4a96-bce6-18c7a37f176b", "AQAAAAIAAYagAAAAEGgIbqMdmR/GvREXLY1LcaVpJj/5Sb14jjqdem+dSRGff96P8J8CNnE3hVhQlpKL7A==", "bc233ff9-977d-4d0b-a972-5cddf2e0432b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f953f498-0906-462b-8ef7-6f01505d54b0", "AQAAAAIAAYagAAAAEI7BvKIlTWP+NdRByIXRRFNhoxeCHbyIbDh+mGwg+8COVbGF0sIjQDTUh+8wD/lSeQ==", "fdf78a12-86d2-4c4f-9c25-032d9e3f98f8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a33d39b-56f4-47a2-b896-ed12d295e0d5", "AQAAAAIAAYagAAAAEFcAVQ7tlYi/Uehc7UMAr3jOmx0ermJgQuucAstFqpRY9FaLUVCHxD5RuvN5A4FYpQ==", "9c9e2826-650c-4438-90d0-3ec43f503417" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30d141a4-dac6-4759-b254-246744d73179", "AQAAAAIAAYagAAAAEOjE1Xgn+ydiBUsxVpCnPbohhxXRohKotrCj6yHG+3PWyPb/Yc/QWtw6qChCSeo3Tw==", "7e7e8c28-baa6-40ee-a262-ee007ed28164" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f72b47-7534-460d-b8ed-02377cab550d", "AQAAAAIAAYagAAAAEKVZ0pOyXdTlgWNadw3os0xDxR3t7ckF8SzxN+svVoHxtWhWO7KK9KHhALZOHsFCvw==", "b6e8eaa7-7037-4f5b-a79b-d6be7b075153" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cdc9545-4f3d-4ae3-9a50-25cb71222c51", "AQAAAAIAAYagAAAAEEyhP7BsBp+hdyt2S9uME9pOyYLIfb9hnsptPVlBVEyznxTMg+ZS74Y8HiLPa/QbVg==", "560495d2-1c56-4ed6-ba8f-3812ebcc3cf1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dabb4f1-1572-406b-9e03-2812948b948c", "AQAAAAIAAYagAAAAEE5f8BvUVAOSp+umvusZdm974GlkDjN3taAEzwvqAW1wvA8FLpgL1JOxA3CpEdef5w==", "4ab158be-5b70-42f5-85dc-fc447fed5d0d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63789607-8fd6-4f8d-80d3-aed154949c21", "AQAAAAIAAYagAAAAENlTMdOyUTcQbQkwa2gBBLexvquxLnfmSwxqdJrHd9+pYsieLJ9YBdAFoWW5MQEPnQ==", "312d7e3b-3771-43ab-864d-82db46485776" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db32d974-0665-4e9d-bd25-b955483b6420", "AQAAAAIAAYagAAAAEKkdBA6pkBx34oYrGy62Fdf4UAp/UA3w9HWCLSjYEZk7Ck5PMlqrWg87zGXWImJYmA==", "e8282bbb-542c-4aaf-ae90-35304f487332" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87a2b2fc-8c0a-4d93-9345-21c46dddfca4", "AQAAAAIAAYagAAAAEOeUWlNzsZpsSev/u6Mjib733cb3qe0PtzGcByLfr8sUV/BTUHG0QWTZcanWKEIMlw==", "7f3256b7-7f49-4aa8-8ecc-cd221ba20e76" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e56bf6b-361e-43dd-b552-0f73db6c8abf", "AQAAAAIAAYagAAAAEODeCEA0/drvH2PXywunpqokdSlm8uVJeg/DWbmikosh43fmrjpdPXhTHPxA7DiXjA==", "b7fcef71-018d-4a37-b818-0fb264e8eaad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65ee1f46-c7a3-4026-89b4-72ae30f04e56", "AQAAAAIAAYagAAAAENNtHTJw9T4EQRZh4Rcr86sFCRajQ3FkPreAwtJBdjs5qeO4Jz6AcKYFd9cj2F+/Gw==", "f7706dce-cae8-4d22-8dcd-e58ea1a96d8e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf9b8b3-49c9-4bd0-87e1-65973b3f585d", "AQAAAAIAAYagAAAAEP9JLVVg6+jJW93dxQsMxTUDsGF+hrKCn+qanSxZwiS6jCZUf0wumWupr7NnPnQ5eA==", "8b263a4b-75c8-4006-a53f-8b9e4a78e21c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13fd4557-850d-4fcc-ae66-7ac2262fb1f6", "AQAAAAIAAYagAAAAEClTqQ/yEYoIfL7HKNvtxUDkI79owJUC/V+HHbbmvlDvw7BsjJN3YzGM46XkNtVOgw==", "4b402c7b-91f8-4d68-ac24-df224915b750" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b388cb-c76d-477f-9da2-4025f8531bd4", "AQAAAAIAAYagAAAAEA6myf8dizyz/672IePa813i4CKP1wi9UNK0bonA8+RCIxME79+1vTOenSMKfAde4g==", "95debd61-5647-4dcf-bf64-c82a0d1af35f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c98b52ea-cb29-473f-9424-16a0d03be4a7", "AQAAAAIAAYagAAAAEDsecaLSRbROjhBMVzle7k1btDqlFUdDGYsIJRLaBqu7IYR0EFfhKQC+if/X1xmAWw==", "f244fa88-0613-473a-a4b9-6bce45a24941" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e5e48d1-670c-46b5-8811-85893d45b8db", "AQAAAAIAAYagAAAAEHn09QzBERVaUx8lC2goQl7i6D/rB0+ollSQI8OwxrBdDb9qPXUmSAqydZx0ht5bAA==", "6e076ff1-0781-4818-98e6-f6ad06e73783" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb2a4a8-fa40-43f2-ba0e-cfbb0f7b6e52", "AQAAAAIAAYagAAAAEAs2WxZczjq0FYBhptmSB6m+h//K/vziTIgQxG0roikSJF/n3SgGeoXs+SIcl6VfLw==", "c098030a-8861-41e5-88ef-362f66a76685" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbab69ed-0160-428a-9df1-5280217dd0c7", "AQAAAAIAAYagAAAAEMQeegvp3cb7cUTWqvBjg6CzOneK+YRN9bPp6W+VAjbdLsTKLpQ7mfv1Whq4fnBsqg==", "45bd5e7c-4658-4e11-89ef-954cf845d005" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58dd5fb-65e8-431f-8432-4c99de713118", "AQAAAAIAAYagAAAAEHgmH0S6/l7LDERAT0bIpKIrWIR3/KGQmt8BfVdCex0NjNtKJbYZyQT3fgX2pVdRmg==", "e4118b0a-33d1-424f-bdfd-cfccc95af8d8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd70e713-b07d-41c3-a357-882e97e54a13", "AQAAAAIAAYagAAAAEMb5XK1/58eU3womlPd2bRF874Ui7XO1EANLVenfKfnmOPEayQ90KYNhwXE97HYg6g==", "079982b3-daec-4a64-8b02-0d1d34c178c9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10dde6f3-3299-46ad-9cb2-752a34bbd031", "AQAAAAIAAYagAAAAEBKNqRu6NLvu4SOfKWO+ThBWzXFFm4Oh8MXorCbnRL6AYtTAUANWF8wOzCtsM52zIA==", "748751bf-a954-4ca0-bf29-cdda5080b488" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "505b6a2c-9d5a-4080-9e72-be7a2b89a369", "AQAAAAIAAYagAAAAEGoPe302Bx0JZqh6srLOjMDeNeX5LJIj3NCsKuUhUpGbm96QIlL8WncBJxcaWV6xnA==", "0eaa5d47-e79e-470e-acc6-0321d0dd7660" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e17328-27fb-4770-9264-c09d220151e8", "AQAAAAIAAYagAAAAEIcM8+K0FKxLEeuCbzcDPp59u1K66/Qg+PbA3H6xiiXwmzA7AwP8icoIFFBo2mpY2A==", "21f2145b-bf83-45a2-805f-36298a549473" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d595501-1919-4599-a434-ed51b9e59952", "AQAAAAIAAYagAAAAEMyeaCWqguzyGBIXU9qlfga4qxwlBwxKh1zJ7PN3wzPLeP6ZQldMohcdXcJQ8rF5Ng==", "2dc27e0f-a062-42c8-a5e6-819a55d746dc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a6850f-d0c7-4155-a84f-5f25f5cf1935", "AQAAAAIAAYagAAAAECWJJVJhw1pcfLrp+Tgtx8RyD3c6eVKICNqk96IHQeskA9sClzooepA/TCgYyard1Q==", "5b55c44c-6df6-45ac-962a-a392db796637" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8381d04a-dbf6-4a6d-9a87-901dbe6d198e", "AQAAAAIAAYagAAAAEMfpqHoqGm4rPYNugCVFbS+H6hsOu54c11OL9ldnWmGzhQB4dqE0rzBq1nmrguUOzA==", "158ba68e-3aae-4838-935c-75cf645a6d6c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1addea10-2e6f-4995-8caa-062f5b26909b", "AQAAAAIAAYagAAAAELNs6z9OaZgvSqAticqBSJq+p6erYuWwRR2vw45xuic4judBebcG08CXoqXndh8kyQ==", "a95ac2d9-ab2a-4700-9905-d3b8500dc467" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9670cf4-cd2d-4452-bff9-f0656dbe48f6", "AQAAAAIAAYagAAAAEAIKFPhpN3CM459t9U36y4gXXTlndBz+6iW4Onh1qcdVYbgHeCn07BK3nn0a68nv6w==", "810f7809-9bdb-4a29-a349-cc2bdaad56e3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f20fbef3-efcd-4170-afeb-17d885df6f38", "AQAAAAIAAYagAAAAEPUjHj7pQCf1VUgeU/k6zlvY2XxmeK9+tA/M5dpUiEczxn01CRKZUoZ8peIOzGh3zA==", "c7fb8a55-20ef-4e88-81b6-f909c4dff87a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f044e87-0b3c-4582-9f5b-394c9d6c9a49", "AQAAAAIAAYagAAAAEL1pjpvxzC+gu4CQRgnW4zQIymtOUJCwq1mJ6lVzLstqTF8is9eQbUIplHKnxlThZg==", "b55508ec-7aa5-4582-84e9-7825456b68ef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f87edfb-f9f0-4a1b-897e-9c502ec890b7", "AQAAAAIAAYagAAAAEFTFadQi59XifYaQfngprBStisGSIiZSahR+TzuMIeC/Os4a3w7mA6GgMgGg9FMFtw==", "53e76604-33ef-419e-bb0e-48524f93059b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "917db8e9-59fe-445c-8ef6-051988b13a9f", "AQAAAAIAAYagAAAAEOHRL695ZU08+W7Ar1kxheHc2VqNN7SkZxh3nI/iDNzHy31AoEAbLdTz3ggn7823zg==", "7beffab1-b4fb-45d0-b2d6-4cb8cc22eeff" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c4d8f7-ee5e-4579-a753-8320a52795e8", "AQAAAAIAAYagAAAAEAIi7UqKPsMJxN5ABmaYgVX/yyO9HKA3NXCe0RgZ15pmsyoWQCXWYIydtXoLCOqwlw==", "ecf76d4f-0acc-46ee-8b07-248dfe98a05b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01ef7c21-deb1-437c-a112-149eac83f18f", "AQAAAAIAAYagAAAAEH8BwoRTvKVvq24HiE+LxHoqV1PYnVjdfRKN2rYoX2Q/fMTu4qvsIJoXFMKC7j5FgA==", "38735635-dcd9-4270-a520-05f749b52c02" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4343e6ce-6364-457e-b4db-9fb35c18e7e9", "AQAAAAIAAYagAAAAEO0bFDofxQUFqWEAWkTl3fTS7y8ABcFQYWSmEBRjjMrbw0hsw2UgsrCMoIk+nHqpIg==", "804439fa-3e4b-4933-89bb-14272319b0c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b20f30a-9a75-4674-85f4-2c22b9cd8f40", "AQAAAAIAAYagAAAAEBR4JG9XREYg0HiaeIsd9PcZt2mMaA4Nt8wWCFwZQtz5PcFHYkRrPvvXBmD8OB14OA==", "9d585dc5-da57-4502-ba14-eb742677c35e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5460855-d97d-4b13-b050-aa11eb17ec4c", "AQAAAAIAAYagAAAAEC0HqNQulzHf2toqgL7ZNgaYr7nuGp6rDf2udJ50bBSHUtJHl9/SsVzLcHdYmemsQA==", "767fea75-ce97-44e3-90c7-68b93442136a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e2fa243-8271-483a-8b0f-2502ffa77bdd", "AQAAAAIAAYagAAAAECKU+GmQK4Jg+XHTroDyI4WoAklmvNkIFWTjSsh1Ypa1OHFQ6HLj799Y6yxhTpxX5w==", "2bb77fa6-a817-4cfa-98b6-0b7d43a659c0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cf438c-b37c-4be4-b85d-f3be0d45cfcd", "AQAAAAIAAYagAAAAEFd63GydNT6IkpN5SvhqWqQpZAbpeRfCO8ajH7UGgzqfJF+KxQ3EI8Br8MYaQ6S/SQ==", "c263f91c-80ae-429a-ba10-3478da7fb014" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e14b305f-36ed-4198-8144-b1f1c38dd498", "AQAAAAIAAYagAAAAEOycqEEvhz0K1ZaMBvW/lzJClww7t+I0PRsnZNTMP0f9Y9599vRIxw+XGWgXQoeMmA==", "92b877af-6286-4028-a80f-81e1e56336a4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "305f94c9-e587-4284-aeef-fefe37eb9162", "AQAAAAIAAYagAAAAEFxBv8gPI4VznTTe/uiQeLKlJVLoWk1G5BTt6Mu8GUQrJ0rFYja5yVcWK9GYV2QKJQ==", "89762db9-55c4-40bc-a0d9-d24362ddc1e4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42612d99-cda5-4ec4-9c8a-1e0c444b7d3e", "AQAAAAIAAYagAAAAEC8Jae5rhfeHo02W89qi0hrmmCabJuXQtT1MsnMIfKY/5CKs7sxUfIUMrcgT+h8icQ==", "af99f6db-a320-4a8e-9a87-ed81a889a4e9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faee51be-998e-4f90-9f80-80803543cf24", "AQAAAAIAAYagAAAAEE2112mdvlU16BVwUbTyfXPtafb9Pgcs7gp8OIOuG499ycc7p4tE9Hava686cg+BsQ==", "ec32f371-dbb2-4f02-85f9-0ed6bf5adc78" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "518dab74-efc2-4494-90ec-5aa81c08b059", "AQAAAAIAAYagAAAAEOOhE0BF5eujf7B5QJBSerrOrNzVRGychF0/4VAjSmDQ4/2eNDG0kzbSP0s1NziqGQ==", "a318ca5c-f053-4ba7-8e72-1410cd4cc6dd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb9094a-64cc-4594-ad18-38d20a45a351", "AQAAAAIAAYagAAAAEAm5oRA3/h6+YfaWUIa1mxhxeVeSUmk6cbTL+xMYkhbiDfvrO5v/zxYQwmQRQLVOzA==", "d953ea55-3889-40e0-9e63-af501a2a63c5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6785cdc7-9833-4d0d-862b-a97d7c11dc1a", "AQAAAAIAAYagAAAAEG5aUrqZiKleN6mpSf/97vYK1+Snh5qK0sehFejaqXqzVLA5EXAx/VKYPsLSdeBSwg==", "6c21cc1f-ae75-4bb7-8d5e-ce7ef7fb804d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46cfbcf7-20f8-440f-a649-736b086adbc7", "AQAAAAIAAYagAAAAEKIiiEcwsnpEAQ1KU3QLMw0gXeqoyn4NsP9m7n1ITkbpbcLVp8kWQeGOGsFLQqQ9TQ==", "f99744f4-c520-4abb-ae1a-4f8ba2ca7dd8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6957c8-4e14-4e7b-822b-55d55673b2c1", "AQAAAAIAAYagAAAAEClFKYEO6cqqvyrpuARXngLWDJV0Y/XQBd8sOzM4xLUVIUIQkIt4F6PdH/EMEGeQuA==", "29e1a213-7603-4fb7-8cc5-85fb19cc91a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef03422d-8936-48e0-be7b-43fd2f0ce607", "AQAAAAIAAYagAAAAEM/+IyF++6wI+LxOrPgl/dBIr9jbFTK0tkMTOQfiNglkFGlkLKuP8u8/atkbmYwPQw==", "8f9075c5-b5c3-4f27-8566-dfe3c163eaa3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6cbafee-3776-41e4-8520-623c19dff31a", "AQAAAAIAAYagAAAAENYsU9WQubncVScqff2CyiAROpDRb4By8+VQ4l7TxbTer4vtzkxOx6dNgw02RSaY8w==", "0263652b-e624-4588-8d8a-3094f3f75b9d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6117151-2588-43c1-aaa9-c3061ff2f224", "AQAAAAIAAYagAAAAEFlFOpGJz2hbzZdCMJ7m4WrA1pA4U0zUlwXvSBHb1MlGqnGnngRsnVcEk67IEX5L6A==", "a22912ec-2789-4df0-95b0-e331b75df23b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab3ac2d-9c38-4772-a7a4-98a2ef1f30dc", "AQAAAAIAAYagAAAAEGoqhJNB2d0E9EgKEf38JFjSdOX/n11EuVz4+HKEk+ka+D3jhKPVnNBA5PwTqvB4gw==", "2729a2e9-3bab-4364-80e4-380851465414" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98126c2-55c5-4b38-ba4e-b011a6800043", "AQAAAAIAAYagAAAAEFOutl57sXd/SoDED/XyFfWORZC21Q+HnF8NwzIAxfXjHmr5dsXe5zg6xS4TwmfRPQ==", "075bcac5-a0ae-423e-a5b0-604ba15fe30b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4c3ed7-f9c5-4549-89d6-397a3712d1ef", "AQAAAAIAAYagAAAAEEAcHAbwPoBSgxTIGceU2rNvKoMcGh2kZqqOw8Unx26niitp2LCLpxaP8n7kpsBPug==", "caa91c7a-91c7-4af6-9eb0-a32a26c3cae7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c486cf1-69ff-4b87-95ce-56140c39471c", "AQAAAAIAAYagAAAAEIfz2Gnj6Lb0BkQ+or3dFEyOUsqABDXMiDvm3ZfVPWjqOybryN1OepcjzMBi6GwGJg==", "3c9da74f-5fa8-4923-b773-0e099073b137" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e7f0b7a-359a-4be8-97d9-bb5ad5eafbad", "AQAAAAIAAYagAAAAEP+jdJldX9VSOVXmX34nkDLSBVFfGeslY0oQqZARh9ASfXzWZzkxvzxWtcJhsy7WnA==", "5d0e1b96-3ef5-4b21-8313-3b2c5a1332e5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2951abff-9a42-4350-9727-d8d3d71d48c9", "AQAAAAIAAYagAAAAELjlDi+CZGSPmSa7OaVPTsRzk3q0NMCdsHYlx7ItExZAiDyvk8JbPZqMpxK4VxzJNQ==", "a52e8a17-2e15-4fda-a8aa-1812039280b6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5789dbff-5aa9-4294-8147-6351d4115e96", "AQAAAAIAAYagAAAAEFYa4DYUhlGfqd3Ic/5PNHXivZi1suPARkbK+XcoEluHscrL5AECPY9H+JiGVCpr4w==", "8d79f59e-341f-44e1-942a-84a10df96efb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85a3555d-6013-4334-9c54-1848a256b621", "AQAAAAIAAYagAAAAEGTPIh6IqdLM8ZfurR4vaSUTXHiDsHx3R2nicX0/WsADw8JvT4fEW2pwvFgwQDhilQ==", "778dda18-5939-4e3e-976f-76a820cca2c3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a3420ea-3559-4bed-a4dc-bdc64082491c", "AQAAAAIAAYagAAAAEBDJWZB0eTE2rNsWjCg5H44BEoPJO6UP8ugmG3n8NiybmavaVeLJC5f0xqlOLZgrnw==", "7d0a61af-05ca-434e-9a21-5bec12105b85" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f097cd8b-cbdd-4181-9883-1820a68f7ed7", "AQAAAAIAAYagAAAAEPaQlkL9Jb9Zosfhnk/lkDMCahDGOGxfLr8asHS7AE4S2bHwDc4Dpb3d44/KpKucRw==", "941f6764-52be-4d8d-96d3-f311ffd4cdf7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4776c9d-6fd2-430f-ba23-8f3187d0cec1", "AQAAAAIAAYagAAAAECCE+IGYEi6TPWwhqm+SNN23fGXIhlayQLWqILMJ9o602xM995p4dWcPJabhBGADRw==", "b23f4910-b957-403f-aa25-ae9c06d6f67f" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("06356c4c-0c40-484a-82aa-ee8e9f8f7f08"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("0f5a0d26-1048-47e4-be66-478eb418e1f1"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("25018f80-186e-444c-858c-ae2f049b64eb"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("278353ca-8eb5-4817-8cf6-91cb430da151"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("28a7ec6f-ad51-4cd8-89f5-fb651874d212"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("3891db68-8b83-49e6-a886-feea0a46a1bb"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("4fa14654-7e8c-4a15-b55f-dc40e8fc4d8e"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("76474916-ee1c-40d3-a037-273cec6c2d25"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("7713f0d2-448d-4c2e-8f40-47d2de675bd0"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("928fdc37-9dc7-4716-9f94-bc6bb2433a1a"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("e6be422c-a012-4783-935a-b94a092cfe70"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("f2d90b4b-49b1-4503-a330-440d2a1f03db"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0dce921a-532c-4237-a9c8-d1327315cd10"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8538), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8537), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8537), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("24976d6c-bab5-4ad4-b415-45e853d0c13d"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8498), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8497), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8490), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("25b4ed73-702b-4262-ae72-7b9b3446681b"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8561), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8560), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8559), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("40e90be4-6efc-4fc7-b673-d9d30fc878eb"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8526), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8525), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8525), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("5800186a-43a0-43aa-99fb-21d5561784b6"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8544), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8543), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8543), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("66b5e325-cd20-4883-8bd5-ffcc99ee2062"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8513), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8512), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8511), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9c92c652-b98f-4767-80a3-60419418c902"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8520), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8519), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8518), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a4a0c014-6cee-482b-a90a-d208eceb9fe8"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8550), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8549), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8549), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ba842720-85a0-4c92-afee-f4c5132b9e0b"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8568), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8566), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8566), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("cbbed425-e4c4-465b-8405-00e16def0411"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8532), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8531), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8531), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1080e432-f9ef-49a7-ab53-afadd33f3917"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3873), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("182513f5-3adc-4cbd-ad16-e56b7f23c1b6"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4252), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("202cb15d-c0b1-4452-a947-076ae09bbb9a"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4274), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("21460b8d-3bdc-4159-a520-b8c75a826207"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4259), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("2f11b920-5127-44d8-82b3-a4b15b06fc3f"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3964), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("3a8a476e-667c-41a3-9c4f-a7f80a491981"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4195), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("42399c56-e749-4ab2-9c48-a15e10bf342f"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3971), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("436d4fcd-d5da-428b-afed-95625c09be19"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3956), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4feafd4f-14fd-4fff-b6f2-1758f9277520"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4153), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("547730f1-07c2-4d42-aa20-2161fb29e6cc"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4211), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("547a840e-7449-477e-af36-3e075d250cc9"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3910), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("5d78e5b6-840b-4140-bc53-4227d3f66d5a"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4170), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("5e1f1d43-c8aa-4901-9400-80bb6b3b0b2f"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4188), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("65159972-d1ba-45b0-bfcf-071bf8c2e526"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4145), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("8c2be389-d2d2-469b-b586-5dea57e343c7"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3882), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("8f47d979-954d-49f1-b7a7-c6a18c3f801d"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3991), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("94ded6f2-1a16-4810-bf31-abb214849d17"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3930), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("94f2a89f-a2d6-4c8c-89ba-b1343de65fd5"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4297), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("95d909e8-876f-45e9-a284-09cf2dc4fd56"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3922), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("a069bd87-8ed6-46e6-83f7-21e018f9fc73"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4008), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a13cc1d7-8e51-4d2d-a1f6-f89a1995309f"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4242), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null },
                    { new Guid("b103d3ed-17ab-4894-8825-72d07cf94d8c"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4267), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 100000.0, 1000.0, null },
                    { new Guid("b13d006a-069f-49aa-9738-f4128852f40d"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3998), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("b8071add-20e5-42ab-8d0b-6ad0fdb41fcb"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4162), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("c38c9c88-8297-455d-8fa1-857e8e6236a3"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3983), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("c675e972-4276-4828-a1e2-1fb819b71a4a"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4138), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("d1a7f50d-64fc-44b6-919b-0d4a9260d4fa"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3848), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("d990a0a7-e931-453d-bce7-e40e5dbd458b"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4227), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("e356d5f9-88cb-4515-a80a-c16060e0219a"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4119), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("e42175cf-20b5-4749-806f-c72613931149"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4289), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("eae68dba-6768-4204-95ab-bd7debe0e406"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4180), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("ec00fad6-9738-441f-9c94-11db2ac57442"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3865), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("ec973213-706c-4e25-b895-58828ac4cb78"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4282), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 100000.0, 1000.0, null },
                    { new Guid("f007ab53-cb8d-4b44-8ff6-6340319a6f50"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4130), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("f3cddd26-b203-4dec-83cc-8c94bc46af3f"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4203), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 100000.0, 1000.0, null },
                    { new Guid("fc69e157-a1ad-4b6b-a4ba-1f826030fa75"), null, new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(4235), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3545), new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3566), new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3574), new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3586), new DateTime(2025, 4, 22, 18, 4, 57, 914, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 22, 18, 4, 57, 909, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("226baaf7-147b-46a0-ace6-26ee7c22282f"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8823), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("414efc95-f7ed-4924-89ee-cf54159f4181"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8799), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("5ae52db2-90a0-47ae-9e98-e355a9827db8"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8794), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("6ac837d1-1845-4e4d-a7c1-ac142d665538"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8819), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("6b79c73f-7d3c-42f5-ae9e-780478e74284"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8813), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("90a97a62-5e47-4e19-a87c-f6c5c8ed08d7"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8792), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("9ce0383e-978b-4778-a1be-c3cc3250bc27"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8817), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("a04b3a63-8b31-466b-9e75-34513d5e301d"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8821), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("abd07f91-a8eb-4af7-83b2-73cf0475a21a"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8825), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("bec647d1-10e3-43cf-9cbf-389de276a7a1"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8797), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("c111461e-6ab9-48b3-b25e-f06e03253cb4"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8786), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("eae67eb5-19e5-4f63-ba67-16013eead373"), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8790), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8732), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8728), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8720), new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 23, 1, 4, 57, 909, DateTimeKind.Local).AddTicks(8704));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("06356c4c-0c40-484a-82aa-ee8e9f8f7f08"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0f5a0d26-1048-47e4-be66-478eb418e1f1"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("25018f80-186e-444c-858c-ae2f049b64eb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("278353ca-8eb5-4817-8cf6-91cb430da151"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("28a7ec6f-ad51-4cd8-89f5-fb651874d212"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3891db68-8b83-49e6-a886-feea0a46a1bb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4fa14654-7e8c-4a15-b55f-dc40e8fc4d8e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("76474916-ee1c-40d3-a037-273cec6c2d25"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7713f0d2-448d-4c2e-8f40-47d2de675bd0"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("928fdc37-9dc7-4716-9f94-bc6bb2433a1a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e6be422c-a012-4783-935a-b94a092cfe70"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f2d90b4b-49b1-4503-a330-440d2a1f03db"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("0dce921a-532c-4237-a9c8-d1327315cd10"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("24976d6c-bab5-4ad4-b415-45e853d0c13d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("25b4ed73-702b-4262-ae72-7b9b3446681b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("40e90be4-6efc-4fc7-b673-d9d30fc878eb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("5800186a-43a0-43aa-99fb-21d5561784b6"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("66b5e325-cd20-4883-8bd5-ffcc99ee2062"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("9c92c652-b98f-4767-80a3-60419418c902"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a4a0c014-6cee-482b-a90a-d208eceb9fe8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ba842720-85a0-4c92-afee-f4c5132b9e0b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("cbbed425-e4c4-465b-8405-00e16def0411"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1080e432-f9ef-49a7-ab53-afadd33f3917"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("182513f5-3adc-4cbd-ad16-e56b7f23c1b6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("202cb15d-c0b1-4452-a947-076ae09bbb9a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("21460b8d-3bdc-4159-a520-b8c75a826207"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2f11b920-5127-44d8-82b3-a4b15b06fc3f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3a8a476e-667c-41a3-9c4f-a7f80a491981"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("42399c56-e749-4ab2-9c48-a15e10bf342f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("436d4fcd-d5da-428b-afed-95625c09be19"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4feafd4f-14fd-4fff-b6f2-1758f9277520"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("547730f1-07c2-4d42-aa20-2161fb29e6cc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("547a840e-7449-477e-af36-3e075d250cc9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5d78e5b6-840b-4140-bc53-4227d3f66d5a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5e1f1d43-c8aa-4901-9400-80bb6b3b0b2f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("65159972-d1ba-45b0-bfcf-071bf8c2e526"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8c2be389-d2d2-469b-b586-5dea57e343c7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8f47d979-954d-49f1-b7a7-c6a18c3f801d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("94ded6f2-1a16-4810-bf31-abb214849d17"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("94f2a89f-a2d6-4c8c-89ba-b1343de65fd5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("95d909e8-876f-45e9-a284-09cf2dc4fd56"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a069bd87-8ed6-46e6-83f7-21e018f9fc73"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a13cc1d7-8e51-4d2d-a1f6-f89a1995309f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b103d3ed-17ab-4894-8825-72d07cf94d8c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b13d006a-069f-49aa-9738-f4128852f40d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b8071add-20e5-42ab-8d0b-6ad0fdb41fcb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c38c9c88-8297-455d-8fa1-857e8e6236a3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c675e972-4276-4828-a1e2-1fb819b71a4a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d1a7f50d-64fc-44b6-919b-0d4a9260d4fa"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d990a0a7-e931-453d-bce7-e40e5dbd458b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e356d5f9-88cb-4515-a80a-c16060e0219a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e42175cf-20b5-4749-806f-c72613931149"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("eae68dba-6768-4204-95ab-bd7debe0e406"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ec00fad6-9738-441f-9c94-11db2ac57442"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ec973213-706c-4e25-b895-58828ac4cb78"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f007ab53-cb8d-4b44-8ff6-6340319a6f50"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f3cddd26-b203-4dec-83cc-8c94bc46af3f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fc69e157-a1ad-4b6b-a4ba-1f826030fa75"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("226baaf7-147b-46a0-ace6-26ee7c22282f"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("414efc95-f7ed-4924-89ee-cf54159f4181"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5ae52db2-90a0-47ae-9e98-e355a9827db8"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6ac837d1-1845-4e4d-a7c1-ac142d665538"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6b79c73f-7d3c-42f5-ae9e-780478e74284"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("90a97a62-5e47-4e19-a87c-f6c5c8ed08d7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("9ce0383e-978b-4778-a1be-c3cc3250bc27"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a04b3a63-8b31-466b-9e75-34513d5e301d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("abd07f91-a8eb-4af7-83b2-73cf0475a21a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("bec647d1-10e3-43cf-9cbf-389de276a7a1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c111461e-6ab9-48b3-b25e-f06e03253cb4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("eae67eb5-19e5-4f63-ba67-16013eead373"));

            migrationBuilder.DropColumn(
                name: "RequestReSignContract",
                table: "Contract");

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
        }
    }
}
