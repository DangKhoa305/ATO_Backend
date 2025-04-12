using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityProduct_Activity_ActivitiesActivityId",
                table: "ActivityProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ActivityProduct_Product_ProductsProductId",
                table: "ActivityProduct");

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("07f8e501-ae29-48d3-a983-08b1b757301b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("12615c27-2391-4714-a85e-64475c33fc8d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("232d69ea-1aef-42d8-a08c-51cd9d94e588"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("24c832c0-83ce-46ce-ba3e-bd2e7fae92d4"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("29a92204-85f1-4c93-9373-89f8a6a2a591"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("502b33f1-09e5-4b21-9fb4-ded3a5b4856d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8ea40f21-511b-49fd-bebd-6c8074965d23"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("a53f5cbc-a16c-4a97-9c73-e2defcf30985"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bd5afa0a-6bcf-45bf-942c-168407ae9837"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d3765c00-245d-4a2a-9fa3-64285bbac538"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("ec051ea0-3b67-40dd-a24e-a90a95c5d0cc"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f6aa5882-be0f-4a21-9674-dce641bbc00d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("00ff3aa6-eaff-4869-b65c-14804aff4714"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("08771ee5-9066-456d-9fd2-6fa96f5d12a5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2a9c1bda-ecc4-4e52-8fa6-922c0193fb5f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("307b65f8-ea88-4970-9f61-3857c23b75be"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("48b06cef-447b-4409-b925-02f2ad190dff"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("496a77f1-1c6a-478f-92b0-f3936ff053bd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4fe1a015-1a21-4cbf-8696-a76f0c2606c1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6abb167f-cbab-43ae-b849-09fbea00e1cc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("725ba712-5139-4bf8-9d30-ff5ecb31052c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("74e37f65-73d4-4179-b844-5245786e6edf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("84285e50-10f7-4cde-8353-d868b52098dc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8c6551fe-d485-434d-af96-2fc463119306"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9a5e998f-7fa1-44c4-83c4-b5f9ba97a0cc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("aa79af20-5394-490d-82d4-f45ac2f5b293"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ae9d6733-03ed-4712-99c9-262aa3c3f204"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b951b51c-918b-492a-a328-18b4a78d7b9f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b98763fa-da7d-49e6-8a8a-56335b57c4a5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bfed24a1-d6e1-4974-b22e-68485ca60d5b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d0c3533e-3841-46cc-aa72-4404314ebb8b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("de0cac50-f829-46dd-99eb-24273b03df72"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e9ee5e0c-9c44-4b81-9d35-5e2d424b19bf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f2684353-c19c-4474-b5ba-e097b7b876ad"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f52d4512-bf0d-4735-8f28-86fb8e67ebeb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f57c1428-b9ed-4e03-ac3d-5bb62bb764f1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("08581122-9e4d-4c4f-9a57-b1347d736e32"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1e0f3bb0-e805-42dc-ae89-378035bb9c99"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("307187c3-2195-4bcf-b7e6-12d36f1b762c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("32c622bf-05b6-4268-ba62-5d58a26f0cb8"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("461e92cb-5273-4496-b28b-3547c73e14a0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4c9b964b-98ee-4180-8a28-4f90b2ce163c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("50cd5410-032a-4d72-8aee-1d499bfed1a6"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("59d29b53-0ca7-4467-a18a-86128d44e7ce"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("85065e15-60a9-4178-b009-4b94c5226ef9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8e053405-a030-4db2-8fdf-2abe2722bf4c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ce14d6c9-499a-48dc-9418-fcd851f35154"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ef035f07-2843-445a-8bbf-ee3aa742bf5e"));

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "ActivityProduct",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ActivitiesActivityId",
                table: "ActivityProduct",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivityProduct_ProductsProductId",
                table: "ActivityProduct",
                newName: "IX_ActivityProduct_ProductId");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eab0465a-299d-4291-871e-86433ab85e91", "AQAAAAIAAYagAAAAEIJYRgK3TgJiK+/JUm950yYSjzFXdEG9641EzjbRiJiSIWe6dyU8iLyK7iviQwpE3g==", "36b8fa74-bbf1-489c-b301-ed63e60fe6cd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf27c27-f144-4828-9a86-0bacb13507ad", "AQAAAAIAAYagAAAAEEOTYou+3c1wmw1BCSYApicsDo7HwH3uOfjZ4XF+LJkkNtWPrqZFhnCNKFuB5N2W2A==", "ceb67b31-08c4-4f25-8089-826513a6a21f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41e9cb29-e4a0-494d-99f0-34a704a610de", "AQAAAAIAAYagAAAAEH70miImhEvAv4DI2nJi85p4Fjiy2G9GL+quAj6ncsMBPmc/epSZJQtST41MgX0f3A==", "f624a4c9-56a9-4ffe-8f3f-ac7db2cc6cf4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f516e6fd-cb3c-49b5-b1bd-b6d8a6371fcd", "AQAAAAIAAYagAAAAECcGWq4iXLJcQ2dNrHi1Ekyy9p0foZi3V4ODARNUdZCg3GCnjTGr3q4vv5YovqmAvA==", "938a0aa0-d5da-409a-8cfc-fd47cce61bdf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a82f898-2eb3-40e4-94e0-ed240072bdf0", "AQAAAAIAAYagAAAAEP6D20VSVke1KfOZHfNlAfx84ZsPZKtiGxsu4GaYTDuxp9GgcibpOZ83z3QVgzYbTA==", "cac77c82-0427-4b25-9b1e-35b5dfdb7840" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a94193ff-5b0e-4c24-aadb-c5ccbb353625", "AQAAAAIAAYagAAAAEBgR63XRG2nUeiUsJlRHYJGMGJXOrYxtia7unID7a272oeiTL+LHzcXE9jjo1ITNpg==", "ae6f29d8-fae0-43a4-8333-ac3ea2fba4c6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1c9b7ba-be20-4463-8460-89e55e250241", "AQAAAAIAAYagAAAAEDBWMN/Eyx8BHD6FlJcVHgky+Ik4iQzT9A53C7VSeRYs3MtLDkOZFkFqGL8+2eVxNg==", "4aa4e12e-2664-4b6e-9c98-d97f62964da0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30fef7de-a2a9-4e88-b994-c7a9103523d3", "AQAAAAIAAYagAAAAEKjYoYWV70gi3B4CvBym2jBakuTFzwhsNGLIh8gTTmUkXOgzZri6AJxkuxjy/5gHUQ==", "ea58994c-4aec-4fd8-b2c2-6ab8ed425266" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63dde0ed-328f-4d23-917c-3306a66bf466", "AQAAAAIAAYagAAAAECkXcg6pXOWWy2RHFfULP6EqsloT8qS5HYrLP039v0f1dRpuEys721ePPfmxeZkZMA==", "fc31fc01-8a8c-4ad7-8a9c-0f9273bd3a29" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "382e5f6f-4350-4981-bc8c-d1ea13ecb678", "AQAAAAIAAYagAAAAEPNn2AyUOMSKMtQFwWMfGUHnH7FnLp2gvhIM49W7eVC87kEEu56LSJwDF7oxaAaQhA==", "660e919d-b03b-4a0a-a85a-2535e8b7c6c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a9c629-de67-4c37-800f-7364133ffa2b", "AQAAAAIAAYagAAAAEEUsJ5i8S9k0H7n9GMgUrz3LNmw9Lj58saq7gCi462Vpr3i0p+tMPub/UX2tJ/qNxg==", "ce88b238-dec6-4399-a552-98e98ebab93a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74470794-17a4-4ba4-af7d-218f89f450ef", "AQAAAAIAAYagAAAAEF59ZysvbzjNZC3MiYEDFctoyhjQhpfmq570+UCgQQQoMk+9thbY7Eeuk/xdEZWRAg==", "bed5a7d0-163f-45cb-bad1-0fa9c733f623" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5f67eda-da16-4a55-8fd9-e59ecba36476", "AQAAAAIAAYagAAAAEFd+Lu41TX+JhJAjHYBrrkktof/Th55P6hqThI0XT0Y2uTzMtDG65w33IgcaypEs3w==", "9c623ce1-5458-4958-b37c-106c86379ef8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c99fa5eb-3271-4610-a8f6-13962200107e", "AQAAAAIAAYagAAAAEEYlBum3KSVkTUG4Y/W5hspozR5Xqy/7W0QlTKLZN5nmYuHDrf+yhbaSckoeCoeAjw==", "2cf77ccd-55ad-4054-9b35-28ae17a9b3e3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb78e364-2bf5-40b8-ac8b-f69ddc0ad1fe", "AQAAAAIAAYagAAAAEIym6yHMcK1iytX5nlmUSkGLX8HopJvkWH+RRP59lWbneBFdWBKkFKWKXY41Q0f/Wg==", "c4814698-258c-41d2-931f-4b967857b27a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f7c5eb-6d40-4203-ac22-2e0da9447cb2", "AQAAAAIAAYagAAAAEKO7QNNDuu3rJ0M+n98b01uzcg43kiR34nE3vw2F9lVene+HvKeMkG9WvWwy6jmENA==", "455671cf-02f0-47e5-99ad-9c6e118c622b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0207ab3-ab46-403a-bb9e-8212bd371fce", "AQAAAAIAAYagAAAAEPjs197ugaBLcu/mDKtMj3Nw/9KG78pwuWv7R/xtzM4GpcgUDGSdsNsjtwXW2WMUMQ==", "70e7888e-1c65-4080-acac-ceb53bc36f28" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3615caeb-4031-4d14-95bc-b200d053cdb0", "AQAAAAIAAYagAAAAEBq1EXvtTVOKlTTzYA+Ff1KinzqT/9TQXavgrisDapcviU5toXelrFSU7zijRp9EXw==", "3fbf3d5a-3277-424a-898e-b4801dbab003" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6076d6a-a129-4e65-9b3a-88db317ccae8", "AQAAAAIAAYagAAAAELTQyvxL2h328NB2wfXzp2Nkmp91S8obuB/vs+O1+bZv+qTqCNDCFy0fHRMFdnhvjw==", "7f68fe55-5670-4f15-a30a-2ed1a2470ff1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72caec20-76a6-485f-bca1-9c37698470c8", "AQAAAAIAAYagAAAAEAIPMAyObsgl4vyzQ7A0qa2A3zzrq/kfWwAUY4xGFyFLFaHN5dpvTDiJgJXkKB8Mww==", "8894465a-8a69-4163-912e-6584ebdf992f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07206fcd-2ebd-4c07-b067-c322568cb9c8", "AQAAAAIAAYagAAAAEKN/lW6gf92RNKt0NiHvGK/D5qFg6jVBNxFjQVchXz0UXHxsRgRbD7TNhOnMElji4w==", "f89b4798-05e7-4b40-87a4-9f28ff83e044" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8802961b-fed1-48ec-8b8c-003a9e380ccf", "AQAAAAIAAYagAAAAECaRkAzXjEbSzsMsV9JkpMbCJB6oTP1F9/HXLJJrMjr1JbLRXYtUOnI3resBpQF7Ag==", "db53c1a0-03e7-4e9a-b3c6-128a2a29d697" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c982062-438a-40e5-9ef7-927e382a7fa0", "AQAAAAIAAYagAAAAEIJGfdBrkhLpdh1FJY8Lsawy+/ZVlqUlYWzQ38Q3KS5diSzOrccLNwrGuDaI6UId7w==", "cc6e8469-1d85-4c2b-849c-74596c5d5b72" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4426f232-9fe5-4474-bef3-42e676d1e058", "AQAAAAIAAYagAAAAEOktC7nh1WMmX3KqUaPPSKqG0cUWS26YSwmGS0Bvj3zlaKJsVAgDc6JQydwHYIDEhA==", "5f4a06b3-6569-44c9-bee5-3c5235d5adba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4a7fa5c-549f-4f7d-bb68-c380350e303e", "AQAAAAIAAYagAAAAEImChgH9nzTjjuSGwpBWnebGafUT1PYGzgajOcWReqoOckE8RknDhs1jC2japfTrCA==", "a2f2b51b-70c6-4527-a394-71566658f164" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7f1c45d-a3a6-44de-b7c9-92e86a78d07b", "AQAAAAIAAYagAAAAEMeQ92paRqsTDGe/KLtGJOn5yBn7o7v1yhztrXssAPXmRMFk1Gb0hApqf+m/EMIpVw==", "cda00310-bcaf-4304-af10-9897f231e47b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8071ac45-c7f8-4f56-b95c-dfa9ab2f37f1", "AQAAAAIAAYagAAAAEKI6SrNhRGnqNOGlCoEda8eI2KW2aQn9PNiJg9mPWFnCn9oC3NnA3jQH9OUD/Okmjg==", "6283b86f-5274-45dc-ad61-c63f67db1768" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fbf414b-858e-4dec-9fc5-9ff7c10a8bf5", "AQAAAAIAAYagAAAAEO9sFFQ5qTlqUfa3tRs9yzMeNSLu6uTafXb6hKE65Wz+So8ETpt2skAcyJw47EzPAQ==", "5fbb2865-8ee0-4145-b0e2-5e7e5dac522b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71d2c6fb-3fde-48c5-92a0-951d5cde6864", "AQAAAAIAAYagAAAAECARE6bJyl5mTr2RxRAOvMmzlK++2ZUMIN7zuwkNTnruB09cZh5+4w9btQg3oG1O4w==", "0f09b0c0-e3c5-4c7f-8ab0-b0dad3ddf270" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f7f68b-c55d-4548-9b15-c5699d26a97c", "AQAAAAIAAYagAAAAELgfbP8wDPB43cDC5Pz6bRRgj1/FTB+d6j5v/DdjcBoBYgMB+6Q+BqIs6DINGIfgoQ==", "03549c46-7968-491d-9ea3-dfd3b66493b3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f09908c-84aa-47a8-97d8-253e1fbb15a6", "AQAAAAIAAYagAAAAEFdhUUEwklBT4HJo9EaCGATZpH9WWBpxiYPbHI5hMP9b/K5ZcwY209NoptQvOuM0AQ==", "47c5efcd-e584-499b-8f36-1090bea02512" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f95ed9-2fb0-46c6-8cd0-2d86ae18ad27", "AQAAAAIAAYagAAAAECf+Dt49Lr5UG1P06uDRA3/fSVakglL3vR/KVsa7drDgPiDroGJLDor77OVHlUsK9Q==", "f6cfa869-3641-4e9f-9f1f-bee68f42926a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a8788c6-74b5-4c7a-9678-b1935dea9df7", "AQAAAAIAAYagAAAAEK5s/tI466WDQg/LEVhFU07ELv0D5uMq6f/g94RBNK6OtwAzCZYSuUPcgP8iWCt3mw==", "00844d1f-e587-48f6-b538-b81fc24f3c3b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0926822-423b-4251-8884-15192ebe8c91", "AQAAAAIAAYagAAAAEPW8DBDGO0NU+buzsrCPhA9Tm5gTgCHdPTI136+3j1vaUrzxKX1Q7QGX9Yx9THM8pg==", "7222c85f-1d4d-4e18-83c1-2ccf757d44f9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7bbbdd-a688-4136-8770-0f6906a114c6", "AQAAAAIAAYagAAAAEG/b7zEeuAbzqais778LusKus5iWOm2edFfszovW0W/kcPy+C2mX4othQYcLdruWBA==", "21c2b4f1-b230-46a7-8278-f6490897e892" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e350bfb0-768e-489a-bb4c-bc747abf4516", "AQAAAAIAAYagAAAAEKEzLu+tDaXMkzE+SxwiQmzWqwLZe6CwbIvg99rsMuqEIz8wNZV6HBaGaiQGOCjqOQ==", "9c1cd7bf-1462-479d-aa93-814d2a79866b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0f960b-328c-47c2-a974-002038f205cf", "AQAAAAIAAYagAAAAEESs/7FjdgDAEXm5CKWSgX31M4e62517aL6kFpgjapLFLAJQGrZW7n7/MVizp8S/JQ==", "1f2d1f2b-d9cc-4889-a1c7-50da190db152" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47182623-964e-48e4-acf8-3a0db4b79f59", "AQAAAAIAAYagAAAAEHoL/dKnDMmZKXcrtw7eDy8tpKop98rvvHHbvggvcgO/Yzy4LTozKJspCTYHi/V7+g==", "b07911dc-e92d-45af-8fe2-8fc1bce2cedd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92f01048-8fd2-4116-aede-785d786a4d10", "AQAAAAIAAYagAAAAEJ0HYiM25MZ4LPZcsv52ybhfaKtR/1AWj7dIOCyf1/J75HSYVyQxRs+j1PwCYmOBXw==", "ec7c0149-0955-46da-b32e-331e86c1341f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a037ea-0b86-41f3-b138-6c9c3c2e4fdf", "AQAAAAIAAYagAAAAEJdZgkzfMFh5SwA5pN4yFPuNaqi0DC1TtzbrVHJwaGPX6ohFZpjc+ywbIcLflvmQUQ==", "688a213f-ef8b-46b5-affb-c879f2051920" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0afc37c7-875f-4601-9128-045ffc64e983", "AQAAAAIAAYagAAAAECMQqvrrSRNSx4xgtPQTDTjWMiYrp+o8E5RZHAbhXksOzidvGp5neJdtGppky+YV2Q==", "2ef5eaa4-29a0-48bd-9d4e-0246f990b875" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98f578b5-9d3f-4a2a-bb9f-ff92a5edcd64", "AQAAAAIAAYagAAAAEGS6iOVxPuCxM/5JFZRm9BHDyyK4coHPKGFfzFaKpL/l7bsph5s1Rz9CtWntdbOmgA==", "43d9b5e7-637d-4ee1-949b-0265ed79d65a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4167eae1-9d1b-45c9-83d1-344a85fdcd08", "AQAAAAIAAYagAAAAEDoF3QrCp2Q4QJRXFFtrywysRGyzzCdCZVBN+OX6OzB0kmpNoKJweZRkCNJQzwnYcA==", "7d1b57ef-be74-42e5-956a-3d349707f50d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9af03434-9b9b-41ce-be4d-dfa5cbafe43b", "AQAAAAIAAYagAAAAELrHZVy2HjAk+65yIzLFbLvnq1y+VqEG8IFEty9RJhqWEbTYibUJYtJoQrCmGG1XbQ==", "6560ff18-144d-4e3d-8fea-ac56a5ca6663" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af4aad0-1828-475e-9b57-f87cba0fc8e8", "AQAAAAIAAYagAAAAEPTHLOJbRwHsNXIcvAq61UEDshzH2uaU+JaORMtwTj9QjHNEd5z1K/ZKuABuEZcVQg==", "204a637e-6123-4109-9ec8-586e023a3e48" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e8e5109-98a5-45dc-beb3-60ef619c701d", "AQAAAAIAAYagAAAAEI0TmVxPZ9R157pemwUU11cRnSkdhByPcH5FFU6P3V1gG2EJnGd8ZmN4hkOYIT/Q0A==", "56c6e202-425f-4d87-90a1-3071a59c7d38" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f64c2f30-02ec-4e09-bea9-79062ca17ab9", "AQAAAAIAAYagAAAAENoij35WOxWQEk1EjtjfDVokvyQgv/Q3mUovTNZDU5cFsr07hCb7PRbD13ktJhTIGQ==", "0e6b5a21-3978-4644-b15e-055a2f7f931f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16baf67e-a229-425b-96e3-14f6ce60b511", "AQAAAAIAAYagAAAAEMs8nuQGEhSCKPRmIOjTHNyj+YubH9fdVJI+GQsipPsk+95Uxtkl9we4H4DUaZZfmA==", "7fb10558-91d9-4229-8e1b-13a4ff2e2af5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7f76e01-bde3-4067-b2d6-a4da718f8ce8", "AQAAAAIAAYagAAAAEM0ij7FqUGtxq3IC6A/d68ImUmBoS0cPrQ1RkVOvmHRyWLhU2UAp175qKgjYJdYAzw==", "a6508cca-5229-407b-9038-4b8bec558d9d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18717c34-8afe-4855-a38a-024c44ea127b", "AQAAAAIAAYagAAAAEFH9aA+oiMyrltPtb7HKou2zn1JvezYOf0q+E6oAl9F3uekF4COEViQ8ByFzZILtcw==", "a066b074-89c2-42f4-9f9a-00bf73259427" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0ec606-fe75-4a8b-9c29-696f7948e704", "AQAAAAIAAYagAAAAEMYs2Fx0SBClvO0tRj8w0xuBYUZN2OAq0IHRMvHM5oI7ybW3G5f6k5wDUly2i7me3w==", "e4d42310-d002-4d15-a384-c80868855dd8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36f8a3c5-fc5b-4a59-b250-7f7d0145c2ee", "AQAAAAIAAYagAAAAEJkDtX8BX1rKd1ZuenkKfZuyW9cgmuaHGYojkHrIZY7sYvY0z+u0fKESSpkpKlzdrA==", "4074ad2c-bc8e-41ba-87da-4a9ac8274f38" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8fbf337-047b-46f1-a519-1c02b9f9f8c1", "AQAAAAIAAYagAAAAECh3Swt4QtbWR9QSI/p4K5+AvSAbbMx5kIoqkndeSowv7xfmMcY8Imj3oMKzUbLjUA==", "9b5647ee-64b0-4820-a0a5-6079655329e3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f23e3e-c6fa-4c01-8ee7-81c55fa99beb", "AQAAAAIAAYagAAAAEOa/xM8d6s33xVhqs4wsbavdskNDOCyykaTcvknEfQsTbPREFppxLUhsSNU4Watu6w==", "fc7e1639-7fcb-4c1d-a8b2-4d8ffb25e1ba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81037f14-8b8c-433f-bc5b-80bd9f5e2773", "AQAAAAIAAYagAAAAEHBAJ5VJHdcr05V0Q7qQQWflgbed2Pnc3CRwNDY1EsjmLpvG0FD5sbKqVsCQ/qxgbw==", "614f44a5-be84-4d27-a9e0-0f3da8b575a3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94899fff-9bf2-4d62-8cad-dc01dc79852a", "AQAAAAIAAYagAAAAECDU0T0dhANfOz2ABSj/PooAKMDP9v0jVQUVHyz5+fp5o/5BQw2/Z62WSMs5bCk4HA==", "391972c0-65f3-4be2-86f8-72ae70556695" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c59923d5-fb16-4134-a6da-96c58f327e69", "AQAAAAIAAYagAAAAEJDfzuNEk9HUrYOx7A3LrBDFiPF+aa9Tp64pn/vZLkTezoasiztJpJu2wVRG6Q4D7Q==", "b641b378-b1a2-4998-bda8-9d8f0aa079a2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6de5ae9-2da9-4a21-ba1d-fd194cc34873", "AQAAAAIAAYagAAAAEOhqpAHfgiVXfNcOq+9PVaE2915jyOCVtAt6WCU95JBnXEc8mffujcq0I+yhETa7VQ==", "38096caa-3c55-428d-b4a5-4bbee79f0182" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "337a00c9-31ef-4852-ae19-fe9223a04dd0", "AQAAAAIAAYagAAAAEJqQTB2IvKECY0VMdm/8898KXsTfUlKQUIaPacd+RTT1eFzBGYp3kY7ojCdDOuiyhg==", "e57aaf02-d4d8-4000-9bdd-f46515b4c739" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b103e7-641b-4163-9e59-24d32b078904", "AQAAAAIAAYagAAAAENAL0dHIVzLK08PaRpAIMIBVyqf9bUsKEyvVPtovih/Fxm1SAQWBzT2DJ02o4SbDlw==", "a41c145e-4af0-4e3a-a40c-1bc186248b03" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6057809-811f-43bc-9704-04c5a45a3974", "AQAAAAIAAYagAAAAEDhO9HM0yWDrHUe4P+5pMoIHgjxUJ9QMJb00wkZs20x/gq8LJW9oNzrHLIAZofc4Vw==", "083766b5-4464-43d0-8a11-76dbee689b29" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d9e889-be8f-4c39-b4d9-86b4bf2e3e13", "AQAAAAIAAYagAAAAEL+njLQwplKpPtamNZJ6w0XEcNdvS09Y78rTCsanw7WZLlkr0mVmyUDFF3OrwXyPmw==", "a52eeb6f-b078-48cb-a018-c875a06ac41e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b0558c-da1a-48e5-8edc-1930efcdeb03", "AQAAAAIAAYagAAAAEMQ9GF3SMPguKJp4XkIfhzmmBFHBnTCdLz45658+VA2p64BV2y2P4fZEA3AjDoojOw==", "0cdec18f-5235-4f31-bdab-ed009ff3e4c3" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") }
                });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0a680bb3-e710-4bfd-bfc5-8047ad384525"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("1de932b3-c53a-4663-8fe4-f76a7ab17ea2"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("3e317bdd-d15e-4cd4-af12-39025a0d75aa"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("4438e239-0921-4c05-8bc5-4619cc4fb0f9"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("47231f77-4e48-42c2-9c68-6e37d57750be"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("6f57ab06-fbc1-4a32-ad08-4266836effac"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("7a28fa15-5196-44d2-bb93-4c82bb2110a5"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("7fdf9f00-8d5e-4b1b-b55e-dda6d5f1118b"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("88302a61-9685-4495-a739-1e8a234da440"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("be6e3fc5-60b2-469f-9aba-3412920c2879"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("c0cbb0ec-6eab-4c98-adcf-d12b821258e1"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("cf332b96-a28e-46ae-99e7-8645424ea369"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("085b25e4-debb-4950-ab2b-49fa20b815c1"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7985), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("0a907406-5284-4b27-b4ee-f21a6de4acf3"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8049), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("0db0c3b0-5502-4e6e-a7dc-bad3ff1493b1"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8201), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("10c7f17f-f0c9-4e3e-a324-79986147e756"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8163), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("146ec859-f838-4e0f-a841-8d12ac2ae0dd"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8037), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("16b5895a-67c5-45c1-9db2-c31b75227830"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8001), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("19e53037-7b5f-4113-95fa-76f856429f33"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7940), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("2641f794-0492-4b52-9907-67a2552b7cf2"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8179), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("2f387565-d2a7-48f7-8d30-130ecc0b2f36"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7994), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("3bb73c3b-1991-4f87-bc3e-06e420fa9bf7"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8074), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("53267199-deff-408a-a3e9-3d0b4042b3aa"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8022), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("680759bb-1877-40a3-b0e6-fdb46f490cc8"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7965), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("6b054065-9949-4293-af2c-e7129fad4b11"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8059), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("74dfbd2a-03ba-4639-8596-6be24e07b20d"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8131), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("7754f8fe-6e57-4845-bc29-44ee84ce0651"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8194), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("7efa2685-a3bd-4287-b93e-df8307776e86"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8148), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("83e0b676-62d3-49fd-b1b6-ba83ac9c71e7"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8140), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("a8035376-20bb-465b-9bba-07c1770e8057"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8172), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("b51a44a9-5725-47c3-b54b-6414c1b4941f"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7928), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("b6f9d019-5e35-4eee-aada-00961a44436f"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8155), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("c0f2b898-a6f4-4f1d-af05-7dbf65912487"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8066), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("cd3ed0aa-e682-487c-954e-376ac4d67bc7"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7948), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("cd749dbd-59f5-43ae-bd13-eec6fd482417"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8030), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("d7d68ebc-ebd3-47e1-b1bb-c908722ecd08"), new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8187), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3545), new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3560), new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3568), new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3576), new DateTime(2025, 4, 8, 17, 5, 20, 172, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 5, 20, 168, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f6e0e00-576c-40db-9f93-7c66ae7bc272"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8416), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("2654174b-1a5d-4152-b1c7-22fbc21c20b2"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8440), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("273377be-78cd-43cf-b9ed-6ee4ee577bcb"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8438), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("48a1ca69-64e5-4e33-9fa8-86ce893f86cd"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8443), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("5105ad0b-a410-4ac1-8749-48d3d6efc8d7"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8434), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("583ede61-b8b7-48d1-aeda-c14fffa1dd5d"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8421), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("5a40ee58-3dab-4dd3-8dee-a6ede09d26a8"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8436), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("5faec699-3776-4827-8e1a-539c0129dfe9"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8427), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("6ed5c34a-c8f2-46e2-ba69-cd6d8f49b21d"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8425), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("9b1a6095-5c35-41e6-840e-15c98a866698"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8431), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("ca47f87f-d5a0-4851-97af-279269f626e6"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8419), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("e3069e29-d39d-410e-a652-fc54dbe974d2"), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8429), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8293), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8282), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8302), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8298), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8289), new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 5, 20, 168, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityProduct_Activity_ActivityId",
                table: "ActivityProduct",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityProduct_Product_ProductId",
                table: "ActivityProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityProduct_Activity_ActivityId",
                table: "ActivityProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ActivityProduct_Product_ProductId",
                table: "ActivityProduct");

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") });

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0a680bb3-e710-4bfd-bfc5-8047ad384525"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("1de932b3-c53a-4663-8fe4-f76a7ab17ea2"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3e317bdd-d15e-4cd4-af12-39025a0d75aa"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4438e239-0921-4c05-8bc5-4619cc4fb0f9"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("47231f77-4e48-42c2-9c68-6e37d57750be"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6f57ab06-fbc1-4a32-ad08-4266836effac"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7a28fa15-5196-44d2-bb93-4c82bb2110a5"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7fdf9f00-8d5e-4b1b-b55e-dda6d5f1118b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("88302a61-9685-4495-a739-1e8a234da440"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("be6e3fc5-60b2-469f-9aba-3412920c2879"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c0cbb0ec-6eab-4c98-adcf-d12b821258e1"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("cf332b96-a28e-46ae-99e7-8645424ea369"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("085b25e4-debb-4950-ab2b-49fa20b815c1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0a907406-5284-4b27-b4ee-f21a6de4acf3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0db0c3b0-5502-4e6e-a7dc-bad3ff1493b1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("10c7f17f-f0c9-4e3e-a324-79986147e756"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("146ec859-f838-4e0f-a841-8d12ac2ae0dd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("16b5895a-67c5-45c1-9db2-c31b75227830"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("19e53037-7b5f-4113-95fa-76f856429f33"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2641f794-0492-4b52-9907-67a2552b7cf2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2f387565-d2a7-48f7-8d30-130ecc0b2f36"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3bb73c3b-1991-4f87-bc3e-06e420fa9bf7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("53267199-deff-408a-a3e9-3d0b4042b3aa"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("680759bb-1877-40a3-b0e6-fdb46f490cc8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6b054065-9949-4293-af2c-e7129fad4b11"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("74dfbd2a-03ba-4639-8596-6be24e07b20d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7754f8fe-6e57-4845-bc29-44ee84ce0651"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7efa2685-a3bd-4287-b93e-df8307776e86"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("83e0b676-62d3-49fd-b1b6-ba83ac9c71e7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a8035376-20bb-465b-9bba-07c1770e8057"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b51a44a9-5725-47c3-b54b-6414c1b4941f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b6f9d019-5e35-4eee-aada-00961a44436f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c0f2b898-a6f4-4f1d-af05-7dbf65912487"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("cd3ed0aa-e682-487c-954e-376ac4d67bc7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("cd749dbd-59f5-43ae-bd13-eec6fd482417"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d7d68ebc-ebd3-47e1-b1bb-c908722ecd08"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0f6e0e00-576c-40db-9f93-7c66ae7bc272"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("2654174b-1a5d-4152-b1c7-22fbc21c20b2"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("273377be-78cd-43cf-b9ed-6ee4ee577bcb"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("48a1ca69-64e5-4e33-9fa8-86ce893f86cd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5105ad0b-a410-4ac1-8749-48d3d6efc8d7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("583ede61-b8b7-48d1-aeda-c14fffa1dd5d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5a40ee58-3dab-4dd3-8dee-a6ede09d26a8"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5faec699-3776-4827-8e1a-539c0129dfe9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6ed5c34a-c8f2-46e2-ba69-cd6d8f49b21d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("9b1a6095-5c35-41e6-840e-15c98a866698"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ca47f87f-d5a0-4851-97af-279269f626e6"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e3069e29-d39d-410e-a652-fc54dbe974d2"));

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ActivityProduct",
                newName: "ProductsProductId");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "ActivityProduct",
                newName: "ActivitiesActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivityProduct_ProductId",
                table: "ActivityProduct",
                newName: "IX_ActivityProduct_ProductsProductId");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa9fc1dd-3966-44f8-a254-95e5326bd173", "AQAAAAIAAYagAAAAEA5Wd7zKCEwvabW0fxxLjtjc8cQkOVxIWM5ODP70DhDFZI8GLCgDfePhQd2qC/5K0w==", "3fa0162f-eb00-4c0d-91fe-a09635facb80" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44a7d6c6-960e-43a4-9d30-313ccdc01e14", "AQAAAAIAAYagAAAAEPzL1xKe8ZuQlQvhfSug2tvRHOvwk0xz+0kzqhTZhMJa9A1ZX1ExMf9OI5Ke0rzCzA==", "c99bf50f-70a0-4a69-8c87-9a969cbd0597" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0f5dacb-b306-4b2b-9d23-21852eccf71f", "AQAAAAIAAYagAAAAEKIMObD5oQh6Uhmnyzmi9ZRgw0OdMdJFfJXYQMbGQyoqZMHWVUg762fBupCazBPJfw==", "d0461f5b-8726-47ff-9a97-4c30f12d7849" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef8c8fba-eb63-4fe2-a42c-7787c4945994", "AQAAAAIAAYagAAAAEAUUU6vuQIsimzWIth4G32iByRnTb5LABP8zbv44knuABNxfUM1ULv7Xe0nW6uketg==", "1ddb3162-5745-43ea-885d-711cf2fd8554" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dfc93bb-ee6f-452c-8ed0-13dcb344abae", "AQAAAAIAAYagAAAAEGuKNJD9XbbARNggXXlT6PY+wB8dC1wjO3M2qDVT8C5KnqaHywXQIhDRD9DufdDb6g==", "aee5710f-85e1-4987-8275-35da949628a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58c66f68-8581-476f-98bf-26836855c40a", "AQAAAAIAAYagAAAAEIUUoILSvZ7bqp72jtFkVvLN/Dl6lbG9xK7YE9ZEa59enJN9KnCH3Q/wC2woWYWCmA==", "fdc9c858-20e5-4722-b060-3c95993db346" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47154911-068f-4876-b259-bdbec63b4f5f", "AQAAAAIAAYagAAAAEI0ZiB4PEBrg7pxIDo3PARqukeG78W1kWaLXFFFtPez26AkR5wRiYKWHWQkko1Z9Sg==", "bb8ec262-3fb1-4d41-abc3-bff8432dcd03" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38521cac-f91c-4dfa-89bf-1aa1480a9e8a", "AQAAAAIAAYagAAAAEGTOWfK+O2zNu/Db9mzHHwHWrutNHg8e3mMfd/MIm4qORGwPxN0eJDlygMVNAI8YOA==", "e6d01320-30e3-4af1-8b4a-25f1c9b8f624" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36b680a-46ff-4c84-a478-34966f85c3e7", "AQAAAAIAAYagAAAAEHGp/LvKL+xAx+9qBhUdaA8aMrAfdvUROLvUy9eBhzQ6hcVRw/44q/np9IZbdHqUqQ==", "10db1bdb-985f-4008-940c-87447a8c522d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7430aeef-4f01-4c0d-b5dc-c0812e94ddad", "AQAAAAIAAYagAAAAENg2QJJ4Nnomd7FNxFwBZg6MjzWvgPDt3+Mwojm2dm2Z7eR4VIgAExrCU0+k+DAvSA==", "8e18e14d-8f67-4154-822a-7b3c826d7cdf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2499c3b-ca82-4921-b061-d5fcb1ac87cc", "AQAAAAIAAYagAAAAEB5BfViK5mpmm4pU0LN5MrpOrJLFmnsU8SFab/UDX2SFGVGGY6KRF8wqcWsUdqHxQw==", "da5c5324-6088-47fc-8967-17967313bfef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c5c837-5a7f-487f-b6fb-1dc0d38907f6", "AQAAAAIAAYagAAAAEGK9OaNVC68UrbyIQTO7r8V583rbDkSV22TOjuqlempPKDnriYxMcR6kBxiQ5SPGKw==", "83a9d027-1c01-4bb9-b97b-6bdd1a9c8b84" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dae3cd64-9734-40ea-b024-10f60fddcf01", "AQAAAAIAAYagAAAAEJtLnPZp0qA6avn0JIDRHeO8LeX8i+8DIEmd98yelTCJz56kUqd8jZOvVwV4A8Tlng==", "83daee8f-775d-46aa-8d04-51f7a63f2b26" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6357b16-27e2-40e5-9e7c-6c7d0a69fcca", "AQAAAAIAAYagAAAAEEAFRhVNylzVr9SCuYSDUCRE3eb+fjLK+bY/bhaKmq/P710yRNBf+ucqw6a7szKBeg==", "4864e1b0-4260-46dc-9679-18a9d57fa121" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7c72a7-d64a-4355-bf5e-f8b9f8f75c1f", "AQAAAAIAAYagAAAAEIgIvfaDwyEGzX8dZ/Md4Z0B+fahMkYTcBs4Na5dZL2RzDkAmhNaUphNaN+SWCajiw==", "954e0857-0c51-47b9-9d94-a61b0fc89dc6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a7f9e6-af50-4ff0-bb70-f49ea5fb7877", "AQAAAAIAAYagAAAAEM9DhyDxZShU8Y1wra14h23fJyh6tUzx6nSOSuQhpbY1MvhFe5ISuvsjo6sJFSsT2Q==", "81398051-84b4-4963-bfde-39e2d35b6f5e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86a6d9e7-64b3-4388-a43c-4d30cbc727c6", "AQAAAAIAAYagAAAAEMv78AOCUzcjYMtfDpw/nZAOdezdpruQaYKnD52OcGz/vIH+JrASTthkd0QU0u1tYg==", "e8c0a6c2-a935-4071-b6db-0655bb84dc1c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "944f33c3-1445-475d-8214-d6adb3772735", "AQAAAAIAAYagAAAAEEMlJx5Djfc/81T2oSPVBm4P/LtgFP5o7y1h+XOHgtQtuySc7At8WTgIFJteGi+RSA==", "7682202e-7465-4289-a450-88870c6f125c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f103a533-cc68-45c3-aaa6-fdeafcb96297", "AQAAAAIAAYagAAAAEIIlHCLzdHMGlwOIrGU5Ze4nbFOVU+U8UsB9oQ0HR81EdOI3/e1sjo46Z1uXlpJxIg==", "2d3cd581-bdf1-42cb-aa0a-d160e961e3c0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07098ca4-3bbc-484f-9f7f-193f82473e35", "AQAAAAIAAYagAAAAEN6bkH/XoApVdtE9hAzxFcZSw1TZFFbZxj7lCrvfVEvFjbQ46WLwa/b4RX/RqLDbaQ==", "3b5ec1ae-f03e-4429-8001-90a328916dc2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f119f76f-03a0-4248-8b8a-ca070ed5732b", "AQAAAAIAAYagAAAAEMZdEe+YIUK7LTLkJLDAZsM5FlgB/aUfrhLRq7/OeA6mqD52TnW/Ev6oFb4/chqnrg==", "9cc67f4e-9641-4769-8973-55b10243e663" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fbc6a87-aa9f-4e39-b591-209b16fa8c4e", "AQAAAAIAAYagAAAAEDtIaD/NOy5MqntGBiwcAsFOFhQpB1lUgIHI5hDBqqwNgSZ/83Texs594iBoj/Mfcg==", "aa32f5be-9572-40ea-ba62-147003ac7c0c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9cfb1dc-d435-4571-a360-3350ed51d5f1", "AQAAAAIAAYagAAAAEIhaUt5rwXuYDJTOJjDbkw+ldEHPBb+8noc0UPe2CcsGeh1LV87JqElVRaOuzWbwfA==", "96f0e11c-a986-438d-a48b-67424daef83d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ef5aff-a535-4096-8088-9a1f976c93ab", "AQAAAAIAAYagAAAAEE4113fnfglb4ia/PyxbcRXOCIkRLdS9VMuCLJajmlMxXoZF/fb4QwETCN7efMcebQ==", "f668e32f-3ab1-45b9-9586-b4dbefbe108d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38233d14-3ed2-4c8b-baea-4687d853a295", "AQAAAAIAAYagAAAAEPmo5EYkFaSYaLUZXUE8Qw8ZKxuVE5D5UAUz1uoC6Vg6CEEckce4BFgTgdXm+rlKcA==", "ea205a1e-8f37-42b1-bcb9-5f43f6271e84" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b798c62-4313-4545-b48e-5a23e8a269bd", "AQAAAAIAAYagAAAAEONPt7tLI33Z/GHyCr4oeAE7jRZVVAtGMcwtVntZmLNaB+JIt7pg5P8ioLvffLz7SQ==", "8dbfc8c1-90d0-4d0b-ad7e-426b486643fa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "760ab47c-5d81-42e8-8676-1fa1ac06793f", "AQAAAAIAAYagAAAAEBa51XZdnmiI41+HnKzpnBOPL05Jh4ZnCUbEWdpm2u9q/5/SCbStF7LNPVNLwJ/53Q==", "a46a4198-b89f-480d-a3f4-62fc4cf738ab" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9433a2c-330a-4930-8664-429b60e8d5cf", "AQAAAAIAAYagAAAAEJx7WtTN4JACMhg8b09lGCXz/gENZD2PWcDVkHncuRRcuPRGDX3K5rb+MYmQ9Rmt1g==", "eb966fd4-23db-49c7-abe0-db5d1bb56bfc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8140ce3-9ab5-42f8-bf83-b4f507b192c9", "AQAAAAIAAYagAAAAENNdsGivBLA5Ged3C6W2MQKUeqVvzVyg2/f0FV97MFZmAzueZFQrsjNG6t5TLNlegg==", "12b84503-de1f-4ddd-9aee-67378db3b9be" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "323b0997-da3c-42a1-9f77-7b126b9d4a06", "AQAAAAIAAYagAAAAELdSfmCwSUQByXPRn1JbeB+vNAjTXIjOVFDEX67zFSt3GUR0rIQdBilurcI16ND07g==", "fd8e79d8-2b52-4ecb-a945-76dec9f65543" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "222b124c-90f7-4128-8d78-22ef74f4140f", "AQAAAAIAAYagAAAAEHuXFjSoDp0yHs7tdp91FVOUHf6YVFmeKYlEw+7n91MXfYUZLdyMUbLQ762WJwSvHw==", "05b84056-caf7-4389-97af-d1c61faae759" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b073b8bd-462b-476d-a5f7-628712174b78", "AQAAAAIAAYagAAAAEPKxEEe+ZmNCHjZHgZaeacAsn7BxtZ2UsO5Ob6yVQKq33Cz+8Gpm7jCjVi4u6yuLEg==", "d0b037b0-a5be-43a2-9fa8-2a23ca64cd7a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bed6aeb-fe60-44be-8d3e-4d34b0d8562b", "AQAAAAIAAYagAAAAEDyEPzfz52XEsmr7lUrPhRaqfLJnn+BWUg/yjb1BRKWJl6LR4QLTo/8czoRpS0oztQ==", "c4320781-d929-4b95-b6ff-561d7a497bf4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63335b85-ce8c-474c-9774-eef508a2718a", "AQAAAAIAAYagAAAAEJxsBGDnk7eZ1NWSm7y/pyrkhmOaOklhzzRcudbUNmV4gmcJ7EgxV/AA8TfM5oUI5Q==", "6a71b9b9-3a60-44e4-82eb-b097458835fc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "111bbc1f-e22d-4995-a054-42ac64ec3531", "AQAAAAIAAYagAAAAECjnW/Lr5Py1/22s5FJxtCMbbF96jt0ejOmbWCMLQKFt0LpeIg3gJAgxg3+gTXz9pg==", "28370090-b224-4f38-8d2d-82a0f4ebc684" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c3fdae1-d34e-40e0-b3e6-cf7aedc972e4", "AQAAAAIAAYagAAAAEM2n59GARDFKA1oSLyMRcoj/VoiCJUjr/mmduP4ro2lXrDjdD+KfBuYYn7h2bd8riw==", "ab03c5ff-ec46-4ca1-8c4d-3f1ad01bb71c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01aec857-224c-4e55-9767-c901bb968cff", "AQAAAAIAAYagAAAAEAEKSDeIdqatGwkxyrNAsBjcOwWdXDnxKPe/pP7LZX8pAlOIJ7US/ujP7Y1QaD32NQ==", "e322665d-6c51-412c-ba5a-7b34eaaec776" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbd1f799-1c16-4625-a327-064101d8a8e3", "AQAAAAIAAYagAAAAEFGZ+CtPU5HmflunZrQdi4UATOVgx8ajTqHtoDTlwGqNq5cVLL+k09kGBv7KoWPW8A==", "da74e9d2-5f58-4480-bb75-28867fb67854" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7606c5f5-c00a-438d-955e-3915423a6e5e", "AQAAAAIAAYagAAAAEH2a/w6Wslht8C+DDYII38Q+8QyQAVPQ6FFp5y+Tg5LnydpYSaVHTzu1v8ltPwfMCQ==", "312c6e1d-e0f3-4b23-931f-2a8acd5c3159" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf7db9e8-b17a-46f3-b5da-6c075597b2de", "AQAAAAIAAYagAAAAEDbU8ZMm5jJxkQRCXXtK4soZgXKWzVc9vlCTvfBC/btD2CLAbE7r8bXn8N/LwOn4eA==", "9f215f3e-0202-4458-b3d8-eda9d518eddb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90680d8c-73f3-40b8-ac5e-8147dcdb8602", "AQAAAAIAAYagAAAAEPS4SIhkgk/H5/q9eEL0qFKj71yKlVawHejRozpoBX0/xw7hd6dqC7nnF6v6pabgBg==", "91ccc53a-f72b-4ca6-b0a8-d8a11f40a4a8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae99f7f-b8ae-4a9a-b49f-b1b63f9774fc", "AQAAAAIAAYagAAAAELYIFvvZx8uRrGj+VmNaWam8wG54ZdM8bdvVbxJMa9zxAFK7Vuda2MCSkdm+m0cjHQ==", "896f5257-6fff-4c26-ad1a-c19beb10b149" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21eb3af-5424-4fc2-831f-81f76f9b42c0", "AQAAAAIAAYagAAAAEPzYRylJB7aw8md0NYIIZbMHWHbTPO4Sjo3IFCziGBZn+V/X98no8t5g9eA4qw25og==", "014a2249-ee50-4947-a05c-6bcb4583c55a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5fbffde-96f3-40d7-b90e-0cdde77fd122", "AQAAAAIAAYagAAAAELPQTW4S4H6gACGl9qUpsL0LgawWBd1JTci9og/pP7Z6IEkh36DzmVutaE3iITMLpw==", "9ec52fea-0666-40d8-b858-d5a5d06a205c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8386e84c-3439-4ed0-9423-7c843b5d4533", "AQAAAAIAAYagAAAAECglsGbKS488qZReKUV51L9Tlp7krHfn+ollNK8W5Rk67G/7znYg+XhR4j9BBwJJMQ==", "9bfcea92-ffb7-4336-a919-d13063b68678" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033bd85a-4085-4380-aa5d-9541bb22b862", "AQAAAAIAAYagAAAAEHtxONPSH0RpedTYnFXCQ8HUMtvVOvMoiFYcY9gTBTx/mIGxLv7+1zLuJ3JPfO9VFA==", "d5e4c8e7-e96d-4691-a1b9-c16e173385a1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c099dce-fdb0-44d4-8903-05aa3ebb0a59", "AQAAAAIAAYagAAAAEBB6o0oEf5uWhzRpiIYf6tkFdKZR0IPgW6I822cezU++RGdVlDqj7Pon0fxHyLfUUw==", "e1c568b6-8271-45a9-b76d-7a12293d157a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd698b56-5a4f-41e4-ba0e-e4fe301d5dd0", "AQAAAAIAAYagAAAAEOMcHgeCScjijzVI7bke37cU68+BRaZEZFkOpdr9EfctHBnXc5KsxddyFqpWPMj/Zg==", "653b50e3-2b92-4317-8812-d76b96567285" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2f8154-54a4-46ac-9a8c-186ed46599f6", "AQAAAAIAAYagAAAAEKxqzZPM1Nw15w1dcQemfvUccc/c56DWG+IoG6hXTLSnhvZhFFuQh3L98RqaiXeM6Q==", "75f159c7-32e4-46ac-9dda-4eae10972e25" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f26cbec-3b97-4ab1-95fc-f795b422d0bf", "AQAAAAIAAYagAAAAEL+tTi22LegE7/91/cY4qMcm4KxCCRAvNsMUEq5xInR5YGh2NcMhF2PAycmqpI+BQA==", "a0fc5446-4756-44ce-a03d-055bd6c731f9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6bfadf5-f327-47ac-a805-e530f74de157", "AQAAAAIAAYagAAAAEANA1vtXBTZraKxsoAvWGnu11oF3Kr+cqJIgeh4qX9yHdde7EXgNQd/aTLNPe4OXmw==", "0a5b53ce-a9aa-48c0-ad3e-7207908f0ee7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8924fc73-b872-4296-b7bd-87972934b991", "AQAAAAIAAYagAAAAEK507fjPW4vhG5voyFII1aabQDhQVjp71W9/Zqky2W7Zzj7zcCT1s5l8J2LtYqX5Sw==", "454dfd3f-9f72-4cf0-80cc-eb6c63355c83" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a25a18-f1ce-468e-bfdf-edf5f359fd69", "AQAAAAIAAYagAAAAEBNnEfZOCiDjRD9wj6z6+hACQWJ/eW4FEJin+70F2Zr50Zn2Wpd0cL/Xz9LhNeIH0g==", "f575fdbd-de17-4dc0-9a6b-d37e435e7b51" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24de9803-f28b-4b5c-84d5-3b16f2137857", "AQAAAAIAAYagAAAAELZWQWq0+Pzma9VZe+TZX+oaaU8TjA6tzbwhshShI5kBdcSx/0N14yjeVR/uTXyn0Q==", "c7b4f2fe-a6f4-4ea1-8edc-092bc3592c5e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6359e880-8468-417e-95dd-386efde111cd", "AQAAAAIAAYagAAAAEE/GbE1/hfAf8tToR7rKr8iFMrlSw3fgWrOvkL8dtJsN3hbULDfz3FSzDqjhBLs2Eg==", "3cd58765-9f27-4b0b-be46-d540b259e36d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38121403-d882-460d-a2dc-19e15cb35633", "AQAAAAIAAYagAAAAEPw5a/pp1RhexfROql+blBpzBWYALzjSuX3plAQgDXeANWli+rOQHU2kJ90t09aRCQ==", "aef22179-f69a-496b-9c4c-ea9bb75e3b99" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f66ddf-ecd4-449f-8e63-3db6d8c755c1", "AQAAAAIAAYagAAAAEH8CM1e75CwO2oDlozbS62e63uWgXMNnm0D1v52P3cPj3zwvA+GLe+Gll948ZW//GQ==", "644c3259-2c67-4419-8534-5fef856fac87" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24663c42-d6e2-4301-a2a6-b7987dfcb2ce", "AQAAAAIAAYagAAAAEBK/YJrqE+dnBwvlqRIp9bissdyquT3yn4C8Ukc0xM/YxUaAM3J3GhZ4pYGMT+GpsA==", "794478ae-21cc-446d-857a-6c4543a199b2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6fb448-2a9f-4225-993f-d14980f23163", "AQAAAAIAAYagAAAAEBFsKBKOZcFjBgLRjMtPYaq2C0m49kKaZ9GTGHgKcpl9Qs12HwzNcmN1k7jMCcJR1A==", "beb19bbb-7199-4cf5-a1b8-075bf37f63c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57a93b13-9566-4c7d-b9ee-4c675c271013", "AQAAAAIAAYagAAAAEKJwy2h8eX9egoZPfR99M2vrQ0zuDKwdKjMcvg9IhY7ZcoFlIYCzWVGpnrNW2mCoog==", "e8f04d7c-916b-4704-86dc-d9cf3bf1b3f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707d2e77-bdcd-434f-a099-4ec57aea497f", "AQAAAAIAAYagAAAAEE0woO21QPOxw4Al0/I2oHMyGaXLJ/WQ6sm78fIM4t2ydan4Y/EBkRrxLcq1BV9nDw==", "aa1d650c-388d-4dbf-a9ac-d30da27a77ce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb226a18-51d4-48c6-a765-2e3e4fe4340b", "AQAAAAIAAYagAAAAEIZ6qudDKtPuRY5wct/GY1PNlWwjojtI567DWLtKNX4pXiH+MwP5j0CkMwiVx+Bu2A==", "64ee0613-c5d4-46d0-bf1c-5809242d1e26" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe2d312c-ef7b-4b06-b9ee-74ab6a34f791", "AQAAAAIAAYagAAAAEIhpsVKaawDazq7n1p5xV/owdMiD01FronV/7+UJaidtkegxKsCWovvhGOq8pVQ6rw==", "5b41084c-153c-4d93-a2da-3e52be42929a" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("07f8e501-ae29-48d3-a983-08b1b757301b"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("12615c27-2391-4714-a85e-64475c33fc8d"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("232d69ea-1aef-42d8-a08c-51cd9d94e588"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("24c832c0-83ce-46ce-ba3e-bd2e7fae92d4"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("29a92204-85f1-4c93-9373-89f8a6a2a591"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("502b33f1-09e5-4b21-9fb4-ded3a5b4856d"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("8ea40f21-511b-49fd-bebd-6c8074965d23"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("a53f5cbc-a16c-4a97-9c73-e2defcf30985"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("bd5afa0a-6bcf-45bf-942c-168407ae9837"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("d3765c00-245d-4a2a-9fa3-64285bbac538"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("ec051ea0-3b67-40dd-a24e-a90a95c5d0cc"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("f6aa5882-be0f-4a21-9674-dce641bbc00d"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("00ff3aa6-eaff-4869-b65c-14804aff4714"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6527), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("08771ee5-9066-456d-9fd2-6fa96f5d12a5"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5668), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("2a9c1bda-ecc4-4e52-8fa6-922c0193fb5f"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6765), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("307b65f8-ea88-4970-9f61-3857c23b75be"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6581), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("48b06cef-447b-4409-b925-02f2ad190dff"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6748), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("496a77f1-1c6a-478f-92b0-f3936ff053bd"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6772), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("4fe1a015-1a21-4cbf-8696-a76f0c2606c1"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6566), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("6abb167f-cbab-43ae-b849-09fbea00e1cc"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5646), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("725ba712-5139-4bf8-9d30-ff5ecb31052c"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6620), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("74e37f65-73d4-4179-b844-5245786e6edf"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5602), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("84285e50-10f7-4cde-8353-d868b52098dc"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6612), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("8c6551fe-d485-434d-af96-2fc463119306"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6700), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("9a5e998f-7fa1-44c4-83c4-b5f9ba97a0cc"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6499), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("aa79af20-5394-490d-82d4-f45ac2f5b293"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6535), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("ae9d6733-03ed-4712-99c9-262aa3c3f204"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6574), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("b951b51c-918b-492a-a328-18b4a78d7b9f"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6725), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("b98763fa-da7d-49e6-8a8a-56335b57c4a5"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6710), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("bfed24a1-d6e1-4974-b22e-68485ca60d5b"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6630), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("d0c3533e-3841-46cc-aa72-4404314ebb8b"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6605), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("de0cac50-f829-46dd-99eb-24273b03df72"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6740), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("e9ee5e0c-9c44-4b81-9d35-5e2d424b19bf"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5623), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("f2684353-c19c-4474-b5ba-e097b7b876ad"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6717), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("f52d4512-bf0d-4735-8f28-86fb8e67ebeb"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6733), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f57c1428-b9ed-4e03-ac3d-5bb62bb764f1"), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(6757), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 17, 4, 18, 637, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("08581122-9e4d-4c4f-9a57-b1347d736e32"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7088), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("1e0f3bb0-e805-42dc-ae89-378035bb9c99"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7090), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("307187c3-2195-4bcf-b7e6-12d36f1b762c"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7071), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("32c622bf-05b6-4268-ba62-5d58a26f0cb8"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7092), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("461e92cb-5273-4496-b28b-3547c73e14a0"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7079), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("4c9b964b-98ee-4180-8a28-4f90b2ce163c"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7084), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("50cd5410-032a-4d72-8aee-1d499bfed1a6"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7073), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("59d29b53-0ca7-4467-a18a-86128d44e7ce"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7082), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("85065e15-60a9-4178-b009-4b94c5226ef9"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7086), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("8e053405-a030-4db2-8fdf-2abe2722bf4c"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7065), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("ce14d6c9-499a-48dc-9418-fcd851f35154"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7068), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("ef035f07-2843-445a-8bbf-ee3aa742bf5e"), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(7075), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 9, 0, 4, 18, 637, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityProduct_Activity_ActivitiesActivityId",
                table: "ActivityProduct",
                column: "ActivitiesActivityId",
                principalTable: "Activity",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityProduct_Product_ProductsProductId",
                table: "ActivityProduct",
                column: "ProductsProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
