using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("1e1a78e1-46e1-4284-9136-67ac0be27a21"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("300035dd-4d1d-4bc3-a4c7-ea21e1381289"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3a5b0d5b-8b4d-4113-8ec2-3c90f6727b8e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6de07d5a-38e7-4365-91ad-93d595f4c637"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("707d5bf5-9052-46a4-ad5b-aefc766a7b5d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7c124a21-124f-472b-bbe5-eb5663675d94"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8843e9d2-5307-4157-a4bc-52f3b587d94c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("914633c0-b841-4dba-8866-ac9d8bbe5532"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bed30a6e-e707-4bfc-8e83-1f98923419e1"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("c65f07ee-8c64-4d3b-a03d-d78e608e7512"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("ccb48a74-8434-447b-a417-7b20bb81ab0b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fa6112d0-4f45-43b8-8ddb-e55ce47e6a34"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("2697eea4-ce00-4921-9ba3-a9f421c305b2"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("60c34cb8-5b3f-4a2a-906c-7a1eed782412"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("6ca36af5-8224-4400-84e8-e2de0f2e59b6"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8fa0b34a-c6cc-4ecd-9863-d174abb053f9"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("9b0b523e-80df-442c-8174-8ab97d36971b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ab12f5fc-fe45-42e3-9a15-6bb2834de5ab"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b2faba08-ebaf-49e3-9377-f8d6288fc655"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("cf34e09e-4f4e-4da3-817c-02361ea80de0"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e09e322e-6a32-4292-8a68-bfa93702687d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("eec80611-d60a-4814-9b8b-807607258754"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("06217287-1cd7-4c5c-a2e0-62bd729eb595"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("18d33e7d-619c-4d58-bea2-8bc3da603198"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("321f8ba7-f980-4c6f-9941-fd611ba2a07e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("38173ec4-82af-4cbb-8cf9-3c035c96ed05"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("403c6e98-1d5e-4c53-8fca-9e1cc9672477"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("460f4226-2f9c-417c-a5d4-4903f12ae822"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4f064e7e-bd01-4ef8-93a7-df64659e0242"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("590c6ff1-a639-4ea0-a6d9-66570194b248"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("66bb70d2-ea78-40d2-b1be-151b9f4cbd73"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("785c1f8d-ef50-469d-8682-00b29fac78b0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8733a67a-3a66-4d95-a4b6-233958a3a099"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9c5460ff-a745-4bc0-a544-1a5f50ecdd78"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9d18004c-096e-432e-adec-b4e5b0b9720d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a6735a7d-7992-4cef-8226-4eae5257bb34"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a7ac22bc-99fd-4cd7-a323-875912c7178a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b673cfa0-1e22-42ed-a776-fe581e847eae"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ba37856f-630c-44f4-8284-3fd46f5e79bc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bfc5cc4d-d1f8-4e72-bd69-f79699a02ba7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d93950de-e455-4428-bdd0-e264885beac3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("db97d214-d5e8-4c14-8d46-b2f190409981"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("de812519-1ece-4592-a3b5-2cdeb54d0fe3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f6ed25aa-b694-4b33-a671-6938808e13b3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fd234f82-9209-4f06-b990-d6f1be9329dd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fd9d5b7e-7747-4ad4-aad0-3f99c3c3c56a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0dc76072-ff50-48bb-8c1f-4322b9cd1fef"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3ee43e1a-65ef-4c02-b9bc-c3e7f3074937"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4248f0fb-a3fc-4f0e-b2b9-5075ba21da82"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("53e9f46c-47c3-4338-b002-748a6e53df60"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("54804e8d-8c7d-48ee-a541-c26c1fd2ad5c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5eda3cc8-b91d-4096-9395-4be4aa85f8dd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("79c3c8bb-397c-4d7b-a246-1077be304c77"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8f13f942-a4f7-4b8c-a5bf-48a116ce372a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("bbb4f3b3-26f2-4963-a90f-8e8397ec4637"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("d19c3538-69bc-4161-abff-e232cd18075e"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f3355915-5e88-4b5b-98fd-69612a5adf79"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f7deae56-316b-477b-a304-75874fca6435"));

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
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92bd9ace-4257-4ce3-b078-73e2c461dfbb", "AQAAAAIAAYagAAAAENPBX9BSCe3DKYA8pYqo+5yLe9DzoWQZWxjWZygmXzgx0w7KP+ffyb8g1tGYbqKrgg==", "c29f5670-7f56-45f4-b996-590b0d26dcf9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fd34876-a7a2-4c5c-9e34-af8a5222a292", "AQAAAAIAAYagAAAAEEzhGyvysHIxapF12ndUpDPNepa6B9M3jCrtmTMlyLbwfHuGIaYh/zJ8lVecMtPZ3Q==", "2c470780-3fb5-4fc8-9fef-9ef7987781a2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbc8e3d-0fd0-4c9e-aaf7-d4734b5458c6", "AQAAAAIAAYagAAAAEJcbpWx1AIy/FQbIwdXWlCr/a0VxiDv8BuCg2ewAjCdKHeE3/N7CM6EOZDLaAH+2Xw==", "24a1df97-0618-48b4-b4ef-4d25bc3ad731" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32656758-1829-40a2-965e-77a709cae650", "AQAAAAIAAYagAAAAEBmen3jv/z43mj+Nilb1FAuBw1TkDRI8dtCCuvrkqTlQJ1OJZzRUpT4WS2I2J+DfsQ==", "502c443c-c234-4d76-8638-880c983da3a5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68dc7e84-6d8d-4114-ad40-67546f5f09ef", "AQAAAAIAAYagAAAAEH1eSEHFpDD9OhpLvnw5tTSso+MQg8kg8anKvshN/zowcuGM0wqpHDXoh6Mfp3idGQ==", "c5d3eccf-1d06-4571-8904-5ce1ffe6eec0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9352cc-753f-4e91-b400-02e80c4f52ff", "AQAAAAIAAYagAAAAENWWt119K//zrxBNU1//hgLsuhKKQanMi8Vci7s3cFxEbJeeUyhun0mbGUxwWh4j5A==", "5ac3f17e-4d80-4355-8ab3-6d74b00f385e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b69a2ebd-d467-43e5-94f0-cc88af71e0ae", "AQAAAAIAAYagAAAAEMqfyxhC6Q426hPaj+X8+k3f4wX4FPo377P/UN7/pl7nXgd0TbJxM7VuQ8Aog6EVlA==", "928f27ab-8850-48a9-acf0-d501ed2744b5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1c48bbf-a2db-4516-8aa2-e5464341a6ae", "AQAAAAIAAYagAAAAEL15z6E+LKEsOYiO2TMdttBLwmNsWdeCq7DUBQXBZwFkaqH1kKfVIIlFMfasQN3+rA==", "14723424-c5cc-4dc3-82f7-95142a62b27f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92c08a49-96b9-4d8a-9f98-45f00a1ce0f2", "AQAAAAIAAYagAAAAEEf+QMSun6tPEbqHeov7lGRhn1gCElSTuHsagjYblhHdOo/HoFatwtoLV/VFiGeSww==", "77071ccd-c3d2-43ba-a959-7097d76513d7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "278b779a-88d3-42d4-85ea-c78c14843e6c", "AQAAAAIAAYagAAAAEBE9Q/pbeYzhk3xOUjTwNpM3EJBNWg1jA92fiThgj8qdUK9yvr/5Wfvxl1PsgK/XEQ==", "89b78d2e-d695-455f-8344-82ab258046b5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b78afe3-30ce-4853-b12d-981aba167551", "AQAAAAIAAYagAAAAECCPG6ok3xWvqcTJ+1Bpwa++TPr5txHFd3SerUsWX/8WGPKiWW0Kk47mVt6waGwCew==", "4a110237-9460-45e3-b690-b5805afb2507" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "027891ec-677e-44ac-8c37-350e3ed9b9b0", "AQAAAAIAAYagAAAAEF59kY/cq9nbkXezWdwKR9zQh/ZHiZr+ZvxdrccW4yC/LxX67LkzHQ5TkjKPkOHxJw==", "80c7f729-bed3-48a7-85af-0fa17d24c2e5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e90a5b-69a6-4890-b64e-a2f5f6bbfea2", "AQAAAAIAAYagAAAAEMXJVA8cvupI4rlndSwMUDaiyGu4Wg8RWwgcVH/ZBCSZNZs9qaockt5npr1TW0g7OA==", "da8c02b7-42d8-40f9-baa6-de62c2e32914" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1bb75b-e0c2-47b0-937f-ae10c9cff4bc", "AQAAAAIAAYagAAAAEI6uEGTE/Cjpj5+8Mi1NkcVeNmA+ZKU8F9yE223mKq8iZofGMDUsEC+RoxjFLXK7pg==", "802a57e8-0ea1-4ad5-ba30-958cef4a364c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6362d3c-52fe-47c9-b702-d993a6c3930f", "AQAAAAIAAYagAAAAEAWRShQa+vPH5FbwBUVTl02MqUBN4tHhnCawPm5CeEmko+XlVA4OcY7XzAPc7aBHGg==", "da9f47f3-21d8-423c-a71c-c41774aeafe0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c9870e4-cfbe-4f34-8fcf-147138725ad5", "AQAAAAIAAYagAAAAELy1PfJPI9r3A0kgVJPnRCnBoSD14Ui4SPAHTXlDb+FTrArZYu+fHOgQyIkMPLhPuQ==", "11c0b86d-6b2c-4c0e-9c76-a3d0cc8e9043" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f32d8e-2511-4280-b0b3-c6ff66873f39", "AQAAAAIAAYagAAAAEMilfNTBDS0qcEN1rSw3gGgL148KWgUuypK02+rJgKFx2ydG98MwqrsMrbIzkjMrIA==", "3a6f9545-0c27-4c14-af96-e34efae3c60c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27ccbf8e-36cc-42e0-b201-0b436c2f34b1", "AQAAAAIAAYagAAAAEEQMNahF/SsyWTvUa0AUDa7L2Jrsmg0HHeIE7WNNXpeRHkYwDeOjBbPRpNmu3QZvew==", "3b3bd30e-37b4-4ba6-9899-f77d49ab3ca9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd891dbb-265b-4d0f-b3e4-e176740fe8ef", "AQAAAAIAAYagAAAAEAe7BLsxO0kZLn83flvSHs+7Da0V4JZnI+m0lflms9/ovyf9xzjYjGNzP9b+2ZIN2A==", "3de6adca-5609-431a-9b00-77d40b2a9874" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb96958-68eb-421d-aee3-853c3687b1dd", "AQAAAAIAAYagAAAAEB/zgqIcteyjzzKg/n6/ahn/UcJHLmgdpZm1pxSGXaQUCGuu4hz9l8OaRabuhjFW7A==", "7ad9e1cd-15c0-48ae-9f00-4f2a1b812741" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9987fb48-5b3c-4ed6-875a-6ea1b25dcc9d", "AQAAAAIAAYagAAAAEAccmVwTVQXOYxwZPmuU8raNHvdYA7d747ewuEr0wQ6IoQjym8AUuu64i3MHsl3ovw==", "33d95092-a967-463f-ba21-7628ea6ca147" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4a4a463-4230-497b-b824-f64e7216dcea", "AQAAAAIAAYagAAAAEEx7e15U+ze28CF6cgKwym4uJJndgF7b6oxm7uRVFCcJTyLzh5YjB+7W4TPZmvhHIg==", "33f707f0-72d7-4384-a75d-fb0d9543b223" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d3ebba-62cb-4ed9-b937-c02bd9847da6", "AQAAAAIAAYagAAAAEOldZJ8tAyWou7fc6OkO79s27wO+dbmsAG/rH85BtwvocGECCgl9PsyHFhtYXUR7Dg==", "65bdad34-781f-4d8d-be5d-1108cecdd8bc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a7ddf73-eabc-4fe8-8bb7-5cd287e48a59", "AQAAAAIAAYagAAAAEK6PbhfygSbHfEgo/ymTy2daj+K3AIyGI1QVsyY5oG7ViM7njak+rlS5BLJk0R8Xpw==", "a9e1df69-7f6d-4924-91e9-b97d19e9dba4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf690dc8-f7a9-4a54-aa88-f66f0549d542", "AQAAAAIAAYagAAAAEI+P5iodAdU08mRyqKy7IzcTyHmWWrgMegSGdwRnM8UuN4+YrgcKZh72UINygM+H+g==", "f1582263-f9b8-471c-88ae-c99cff429f80" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06090f3-cc1b-47cd-a6b8-8fdf63b0ebc3", "AQAAAAIAAYagAAAAEJN/FdcnXok5wPZVjQY1ql4N3ZD6VSyYKEzUUiECDfwCXuw/qz2BTmn7aPM7VGTUYg==", "e5859283-d7ca-41cb-b354-779acde9c846" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0c8ef1-6bc3-473d-b564-ea566e66fac8", "AQAAAAIAAYagAAAAECTaHmG8/PA2xI/68V5Jheybcc/DNkY8K0kLRTMTLtLCsggxLifHQiznwJhG4aqDRw==", "827c6a9b-8f5b-4fee-9331-cc712a46f778" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd03858-4f25-42d6-969f-97f5b6f9b55d", "AQAAAAIAAYagAAAAEHNounw0VXz2tM5DOQ8+d3yUhK86G3nMD7tG/UnJKv+0Z2c3wuKT7MAOt/690RIZow==", "9b2f775b-f099-45dd-8250-32de7869a700" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31932a26-faac-4075-9e17-5991a837741e", "AQAAAAIAAYagAAAAEIE4KKO4qol6SYp7n1KV2MKZs+TdaUxP1FeVBZdCmXoCDLQWSt2BEQJieKCzcxtjxg==", "71f4ec20-8951-4a75-ae4f-911254715de9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f401c2c-a96c-498c-893f-a8c2f4ba3346", "AQAAAAIAAYagAAAAEOnYJvnLn/I5OX2tKNwBOtxY2/e9FnVqIOumh1DOZikQIVze0cNJQko9qu3RjG0gjw==", "758fc44f-d60d-40d5-83f5-6268ad042269" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fddd587-2085-4f86-b59b-a194123b8aba", "AQAAAAIAAYagAAAAEEwE5EZN4SZ3g8G6mDIACqDWlRZ/5WWxpHtUvXn2NrtWg4NczJCdYcLO2a5bKO+yUA==", "89cd92ce-ca87-4af1-9f6d-537bb7fe6554" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("25dc3b06-ae24-49b3-816b-e634a6bbab4a"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("2a62d7f9-c60f-40a1-b147-6386e491d58f"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("337250e5-9961-4585-ae9e-495db77af0cc"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("3d2b85cd-0efe-43d9-b2af-91e035f1a65b"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("5573aea8-c793-4d56-b73f-3e3e7aebfaf0"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("598d9a8c-9c0b-4b84-a682-a3b343577014"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("7ede014e-c11a-450f-9cf8-a1e192d03bca"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("95f741c0-2464-47d1-a091-0b3169d7c011"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("a35c6cf8-df05-4c0e-af34-0e7d0f5fc97e"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("af4042f3-1ad5-4207-9df4-8cb3217b44b3"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("b80b8064-5bfd-4b4b-a4d9-6b5e646cef22"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("fe54796e-2df3-4166-abf8-8ed74117a5d8"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0fe4b0cd-027a-423b-b3ac-e8751f45bac1"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7248), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7248), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7247), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("16e7c8a2-089d-4d0b-bce9-607ece8e7dcd"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7268), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7267), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7267), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("2078e5ae-1a96-491d-9143-dc215b768261"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7259), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7259), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7258), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("4a108d37-5479-4212-a86f-75cd63468616"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7263), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7263), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7262), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("6d341f4b-ba5f-4ae3-b28f-07775c22ea16"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7237), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7236), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7235), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("883655fa-6747-4de8-87a4-279492cffdab"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7244), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7243), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7242), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8b5d9417-62c3-4b7f-add6-815bb7bf3919"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7276), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7276), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7275), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2b8475d-075a-4145-a081-f22fcf713964"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7280), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7279), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7279), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("cf354efe-8af9-4aff-80a5-548d6478d94f"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7272), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7271), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7271), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ef36dfc9-b285-43cd-a641-45c542f101bc"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7283), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(7283), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("000ea569-9ebd-428c-aa22-5eab34e1aa95"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7017), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("0730f082-0466-40c3-82f7-c25ad942a862"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7132), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("134faddf-bba1-4f77-82d4-991cf4eb5a64"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6947), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("156d12e4-16e7-48aa-9272-4c5cfc6d7b3b"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7038), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("1972c32d-accb-475b-b813-f1b2e38ee1be"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7157), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1cc23439-00e8-4554-97db-6b97a0dea417"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6969), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("2463b1d9-2eda-47a8-be2c-1d4abccb8847"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7120), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("259f10fc-952c-4a6e-9455-3b2997376524"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7127), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("3109380c-f9b2-4771-8ca1-d552df4e81c7"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7163), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("3bb04f5f-890c-4f46-a622-eea4c540bbc5"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6941), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("4bdb2367-e1ba-4723-b927-cfef8515c937"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6975), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4f6a93d5-30f6-45c2-822a-94817fbce9d5"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7139), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("5f004190-5106-473b-99c7-d0c0d69b34ac"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7028), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("725f2db6-cb75-4516-b75d-f9ee766170ae"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6964), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("7657a899-2963-44a4-b725-9bd2003dd5ef"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7174), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("83b8f233-fbfd-470c-a130-10f6ccb81e68"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6935), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("8fd1b706-da49-40a8-a74a-d543cf13c0d1"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7022), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("ab06f95c-8746-4d05-a359-3145709b880b"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7145), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("aed9093a-80f5-44f6-a2bf-05b5e6891da7"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7169), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("b4dd84e7-de73-4087-8251-3f4287d87366"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(6924), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("dc11f167-efd7-44ad-859c-2fe5befd154c"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7005), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("e50b165b-d853-42f4-8b46-38ed7e1b9873"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7033), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("e5b1878a-d5d1-4ad8-a221-1c5365dd881c"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7152), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("ef5924fd-5605-43a5-be0d-0ceeea3957df"), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7010), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3077), new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3092), new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3099), new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3106), new DateTime(2025, 3, 27, 18, 8, 38, 438, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 17, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7341), new DateTime(2025, 3, 25, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 3, 27, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 22, 18, 8, 38, 434, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("15aadea3-17fb-45ad-8618-a8877841c615"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5571), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("55dadae4-5a1d-4815-9210-c0938816ba1b"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5557), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("965d33c1-3f99-4f26-a723-33357f8652b7"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5573), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("96ec0d38-c8ac-4f5d-995a-0d2295e11671"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5570), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("9a046349-2b57-4743-8210-482e3077582b"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5566), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("a99bfef8-f049-42c4-aa86-57b95965b264"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5555), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("b959862f-c4ea-4f83-b7c7-47beea59e615"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5558), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("bf682c62-5f42-449d-8317-394045c1d021"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5553), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("c9b0845f-4e86-481b-9507-e74ca6a5187a"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5563), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("e5d48329-48f0-4c10-ac25-254a04d1261a"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5560), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("f32dac3c-b899-4344-a0ab-5ddf58ecf14d"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5568), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("f905931f-73b4-4913-b2b9-f245f76a1cf4"), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5565), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5496), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5502), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5499), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 28, 1, 8, 38, 434, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("25dc3b06-ae24-49b3-816b-e634a6bbab4a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2a62d7f9-c60f-40a1-b147-6386e491d58f"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("337250e5-9961-4585-ae9e-495db77af0cc"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("3d2b85cd-0efe-43d9-b2af-91e035f1a65b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5573aea8-c793-4d56-b73f-3e3e7aebfaf0"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("598d9a8c-9c0b-4b84-a682-a3b343577014"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7ede014e-c11a-450f-9cf8-a1e192d03bca"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("95f741c0-2464-47d1-a091-0b3169d7c011"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("a35c6cf8-df05-4c0e-af34-0e7d0f5fc97e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("af4042f3-1ad5-4207-9df4-8cb3217b44b3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b80b8064-5bfd-4b4b-a4d9-6b5e646cef22"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fe54796e-2df3-4166-abf8-8ed74117a5d8"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("0fe4b0cd-027a-423b-b3ac-e8751f45bac1"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("16e7c8a2-089d-4d0b-bce9-607ece8e7dcd"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("2078e5ae-1a96-491d-9143-dc215b768261"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("4a108d37-5479-4212-a86f-75cd63468616"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("6d341f4b-ba5f-4ae3-b28f-07775c22ea16"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("883655fa-6747-4de8-87a4-279492cffdab"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8b5d9417-62c3-4b7f-add6-815bb7bf3919"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c2b8475d-075a-4145-a081-f22fcf713964"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("cf354efe-8af9-4aff-80a5-548d6478d94f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ef36dfc9-b285-43cd-a641-45c542f101bc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("000ea569-9ebd-428c-aa22-5eab34e1aa95"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0730f082-0466-40c3-82f7-c25ad942a862"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("134faddf-bba1-4f77-82d4-991cf4eb5a64"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("156d12e4-16e7-48aa-9272-4c5cfc6d7b3b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1972c32d-accb-475b-b813-f1b2e38ee1be"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1cc23439-00e8-4554-97db-6b97a0dea417"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2463b1d9-2eda-47a8-be2c-1d4abccb8847"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("259f10fc-952c-4a6e-9455-3b2997376524"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3109380c-f9b2-4771-8ca1-d552df4e81c7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3bb04f5f-890c-4f46-a622-eea4c540bbc5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4bdb2367-e1ba-4723-b927-cfef8515c937"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4f6a93d5-30f6-45c2-822a-94817fbce9d5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5f004190-5106-473b-99c7-d0c0d69b34ac"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("725f2db6-cb75-4516-b75d-f9ee766170ae"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7657a899-2963-44a4-b725-9bd2003dd5ef"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("83b8f233-fbfd-470c-a130-10f6ccb81e68"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8fd1b706-da49-40a8-a74a-d543cf13c0d1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ab06f95c-8746-4d05-a359-3145709b880b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("aed9093a-80f5-44f6-a2bf-05b5e6891da7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b4dd84e7-de73-4087-8251-3f4287d87366"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("dc11f167-efd7-44ad-859c-2fe5befd154c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e50b165b-d853-42f4-8b46-38ed7e1b9873"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e5b1878a-d5d1-4ad8-a221-1c5365dd881c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ef5924fd-5605-43a5-be0d-0ceeea3957df"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("15aadea3-17fb-45ad-8618-a8877841c615"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("55dadae4-5a1d-4815-9210-c0938816ba1b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("965d33c1-3f99-4f26-a723-33357f8652b7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("96ec0d38-c8ac-4f5d-995a-0d2295e11671"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("9a046349-2b57-4743-8210-482e3077582b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a99bfef8-f049-42c4-aa86-57b95965b264"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b959862f-c4ea-4f83-b7c7-47beea59e615"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("bf682c62-5f42-449d-8317-394045c1d021"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c9b0845f-4e86-481b-9507-e74ca6a5187a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e5d48329-48f0-4c10-ac25-254a04d1261a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f32dac3c-b899-4344-a0ab-5ddf58ecf14d"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f905931f-73b4-4913-b2b9-f245f76a1cf4"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5b49a91-2c96-44d8-80be-f26295f3652a", "AQAAAAIAAYagAAAAEAc0m4RfEf+L6VKrNvih54D2tlc6XuLg805dtWJ+LsBKuhUve4oupMNF4vCg8RMVpw==", "5c9891be-2a30-453b-b7bc-56b6a859e192" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee816c86-cf90-4261-be7d-872a6ac1d2f9", "AQAAAAIAAYagAAAAECnqg30ApnbQNS2cjDS5GNKBNBxpXPbwBfDr/eKnP2WhObnZM+nmRu5Gzq+x+cB3Wg==", "0b4a0ece-b823-4716-813c-62dd1784a426" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45dec6ca-4d02-4510-b025-922c0fa4ddbe", "AQAAAAIAAYagAAAAEM1aZl3FspaSubeD+iW6GdhFVQaija0/wTxlh2/vCsnDqoL+IqXOLf0cbqWNUaCfpg==", "2302def9-5d79-432c-9156-b5ba4dfec553" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c703dcd-049c-4e1c-b563-9c37819797a7", "AQAAAAIAAYagAAAAEMDUPvLRwHt/1Jpxtvxyy6ERwqsHdxCSqcMv7Q3z8RaFVucSIX1duUdsgrhvn4NJXw==", "95b475d6-2ff8-49a8-933b-b5a5cf15899e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "728eb393-17c1-4442-8b4c-14af27b7362e", "AQAAAAIAAYagAAAAEFODdjWSIpjzu71o/9UT2Om9cRQwTgmp7qndVZekZFLFYV/ir/P3VYP36+YR3E7lLQ==", "a2df70f6-47d5-4f3d-b1bf-ea07b13772ca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0766b305-859c-4c53-9785-6bdf3de51abb", "AQAAAAIAAYagAAAAEAEt51DYGxhFt2oLMro//67PpjK7JZ96YScmgBjWFVGMEZiI6xEOUHNWzLjQOxc5qQ==", "28cb44a9-4207-48af-94fa-7ff4ef962c21" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae4cd73-5e19-44d0-bdac-c8df20a5fcf5", "AQAAAAIAAYagAAAAEIP9h3bCuYvANQFJhlr1eAvRbWS0Hns9r2pRuLeL1AZoQvOxs1msd1prXC3C+O0C0Q==", "029ca52f-fafc-420b-9c63-9e41730cd7b3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17bbbb3-95f6-4adb-864c-6f6a778d902d", "AQAAAAIAAYagAAAAEGjEhk8zy2UAv5gJiwxYR6rTAp0gr9NCY9+sZDADylVhfoWtv8Q3tafGi0QBYo3AZw==", "e83ebd88-dfcd-4ebb-bebb-9b73c36ada96" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f46b8ca-40d3-408c-bb03-af13e6449f79", "AQAAAAIAAYagAAAAEJ0vbuAdu45RJ6DWC+4nG5aem4xwGk0Xemu6TJOWudpG6oJUdhm06sq6x+dEOLlfhA==", "52dc2ac6-83aa-44e4-ae74-c28f9ee8fbcc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6420d4b3-86d4-4a14-9ffc-ce7906c49f21", "AQAAAAIAAYagAAAAEOnqmMLIZ3DTVFrGnR/Ad9+RZf+THdzJV0V9vWuETwQtH6EG6pIz0JYNtwb5gqlwhg==", "6cbc5edc-1539-43c7-b719-821fab75102f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7a7cf62-5165-4961-b0bb-b8e309ff029b", "AQAAAAIAAYagAAAAEBPKnZJmn7ECSF1GxYLll6gNvkMODoQsozNTxn0y4oW0qDGQcB90iE5aM2r3VzUP3g==", "05b25a75-194a-44b3-8207-3e35676c9fc1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a97ffa-5ebd-4098-80b3-af544b645c01", "AQAAAAIAAYagAAAAEFjDm0oS/I4PLJXsOznqT3dxmAs2CMWl1MfUhBp5cz5aGrB/ZKEspUwAXnOwwKHcYw==", "a151b757-337a-4430-85ec-8ddc0ba123bd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb4c182-85ea-4104-9a96-1f040dcaaa7d", "AQAAAAIAAYagAAAAELiTXbkGZcYmfTUfbrBeCHscjSJi82qR/fsS1tNCuuxVBE5EruW+ZcGw//A/b5U7gg==", "8bac5605-1391-4cbd-ab0c-b3b4cf7d6c50" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83afc52b-ed8a-4320-bfc7-2871e7383eed", "AQAAAAIAAYagAAAAEFtBhukW936A1z5vYKZxfTKWHeo+NPexOPgYEGK+peNhtjDHPRZbic53draa1eVf4w==", "0e3c6029-0fc9-41d9-8593-331879c5d104" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215062f5-c8ec-41b8-8cf5-d92368d78d99", "AQAAAAIAAYagAAAAEB7O/BuSfqx5UkdmRl2W38+3CC38/KO2qyYlRbBJP9q3rM/TEu26ZASP+9ggEDH0iQ==", "f26f4a48-e48f-4726-828e-2901367299a9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bce8b4-f61b-4c26-8f5a-c7e296110f86", "AQAAAAIAAYagAAAAEEQdzscpiK6xbcHb9EDFLdy9pmnCcGPS0uWJZL1Fz/Z2Zo7YczZO2ImgfezEXkv5PQ==", "8035e46e-6b3a-46c3-87bc-cb273ea37263" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "096917fd-9cf9-4c70-ba07-24ab4888465f", "AQAAAAIAAYagAAAAENWGSGyQgJRBAx2qd5Swmk/OdXxSNGg1+6JeUSq5hYKUsvzWRWs7b4xhCpW1LRb1Aw==", "4b2e74b8-fc94-4fdf-8176-88de62d936e7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871046a8-be73-4f88-b0a0-443ba3447ed2", "AQAAAAIAAYagAAAAEHkBJNb3dSKfSY9RzN9BGaS/dUul8atBh+gW2OVGbAWHqzcWDPgQI+V855uA02JM/w==", "6362b47e-8ad0-452b-933d-9201862b3fab" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "937751a8-073a-45bb-b3c4-4b38efabbd8a", "AQAAAAIAAYagAAAAEBoMuaMkUzRcybyUzi0A481Ir/TdDl2bRwYQLwzBEHck1ItkV4Mb7G3CpF3pzZMctw==", "89744358-8ea8-4230-adc8-21d092bb7680" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f8bfe9a-63ee-4af6-886d-4dd1019016ac", "AQAAAAIAAYagAAAAEFhlLot7+bz16H0iJpogqJLhiG1comFDYLqxscTSyiQn2QQxIuDZ+SO1yEhNx2/o7A==", "7ca7c9e4-c6d0-4e23-b5fe-8c1af37a9aa3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4f74059-6aea-42dd-9512-3983bee86024", "AQAAAAIAAYagAAAAEDRUhqxgnnjVw0Leg+hw1exQbLS7Q1CaUVsAFV9MhcBnjUFfFKyvgAruXf+YIFQblA==", "0a62a5d9-da0c-4ef3-98c0-f80f6e59c2ab" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38d5f5ce-f971-4f58-96e7-cc235ace2336", "AQAAAAIAAYagAAAAEN8LYwu2Y8Y78QkZYO3AdwI0vwUfPBTH5XpOdXQYZ8EuI3+vE7ycj9MyxJjtwCaiYA==", "aeed220e-9ba6-408b-ac4e-c9b080d623c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c9c9c70-a9d0-4a66-b913-be08c1a810e5", "AQAAAAIAAYagAAAAEI4FO2iZ7UHnYcgQAJ6uN2yZ6yinBqPQoOCATE7ZKgEggScHA+7C/7U2gFWTWBveHg==", "1587a291-d767-4752-91ee-2a275ba40af0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34cd3d0b-f0fa-4d31-9c72-93defd18649f", "AQAAAAIAAYagAAAAECVq3tXOqly7s7uaXT7MU6vRUDmLVo9RjZ2ev9+ZWaByfiH0bmiB7Sy0zJOljobF9g==", "ba0f2150-f932-4719-b545-ca21628abd3d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ced3447-e110-4ede-b89d-1c277f925ecb", "AQAAAAIAAYagAAAAEMgoK4et4VhfdsuzC8c7aVdqHRtOa5yADge9jeevZXTHAtFhvXyfqzJYkemfWeZLbQ==", "71bba83e-2e99-4312-b9ad-5f1a4bccf494" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "195c53b3-8d7e-45fd-927e-c56d3f7ddd62", "AQAAAAIAAYagAAAAEMJHCKh+8OS6cTOcTimn7jCc8E5OeDFAjZRNwMwZybDIvJylMAbkxhdWi5bPPt+LlA==", "4a03ae34-a5ec-4795-a7c5-2ded82f825cc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ca4f62f-c5d7-4c5f-ab59-e08eb298a418", "AQAAAAIAAYagAAAAEHITv+bdH5CXRlvO3CacP0yVisYp2axWYmhHymrLZO+fCMMk4JW9d7UqzEFQy/+tPA==", "2a382427-8540-4fb1-8fd7-c00920e5aede" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f087e39a-9594-460f-bbb2-3bf92ebf3146", "AQAAAAIAAYagAAAAEE//UBA99yrvW7faze5rsM/kIsYihzsIM9MR/1KRyTqNAIzp8aj6f/TTG8c6CgRbRg==", "f85af4b6-6b56-45e4-8b36-821960abc901" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f3957fe-9e9c-4cb4-b01f-ad1d8f89be3b", "AQAAAAIAAYagAAAAEByWdrsDfbhH7CxkgGqcRPjqK0dy37giM9oxq6LD8UGTkyBG+eooB5XHrrgBtMtWsQ==", "28d5f33c-d047-4104-8b13-dd7a2d479606" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c59ab33-d2a0-4427-b534-8bf68f287bfd", "AQAAAAIAAYagAAAAEPWpfwt3c0ez/IHAUOYh/6Bg06AwGGnDPrU3iQVYnosLeEXu4LNIearWq1tAuyBiDQ==", "17efd5e7-b975-4663-9635-4fdf0d45a83a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669d5abc-e116-4e1e-9999-c5a50d6df0f9", "AQAAAAIAAYagAAAAEL68aNMiOZ7DrrzNOotgp7QcAZH+/lFqVRjTaKPO13g6dJcv+oZmeMNUD8dmzqE7nw==", "59706869-9f9e-4eaf-a719-66136d8a9778" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("1e1a78e1-46e1-4284-9136-67ac0be27a21"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("300035dd-4d1d-4bc3-a4c7-ea21e1381289"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("3a5b0d5b-8b4d-4113-8ec2-3c90f6727b8e"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("6de07d5a-38e7-4365-91ad-93d595f4c637"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("707d5bf5-9052-46a4-ad5b-aefc766a7b5d"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("7c124a21-124f-472b-bbe5-eb5663675d94"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("8843e9d2-5307-4157-a4bc-52f3b587d94c"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("914633c0-b841-4dba-8866-ac9d8bbe5532"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("bed30a6e-e707-4bfc-8e83-1f98923419e1"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("c65f07ee-8c64-4d3b-a03d-d78e608e7512"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("ccb48a74-8434-447b-a417-7b20bb81ab0b"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("fa6112d0-4f45-43b8-8ddb-e55ce47e6a34"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2697eea4-ce00-4921-9ba3-a9f421c305b2"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7265), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7265), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7264), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("60c34cb8-5b3f-4a2a-906c-7a1eed782412"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7282), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7281), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7281), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("6ca36af5-8224-4400-84e8-e2de0f2e59b6"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7261), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7260), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7260), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8fa0b34a-c6cc-4ecd-9863-d174abb053f9"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7284), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7283), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9b0b523e-80df-442c-8174-8ab97d36971b"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7250), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7249), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7248), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ab12f5fc-fe45-42e3-9a15-6bb2834de5ab"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7270), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7269), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7269), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b2faba08-ebaf-49e3-9377-f8d6288fc655"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7278), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7278), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7277), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("cf34e09e-4f4e-4da3-817c-02361ea80de0"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7244), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7243), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7242), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e09e322e-6a32-4292-8a68-bfa93702687d"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7255), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7254), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7254), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("eec80611-d60a-4814-9b8b-807607258754"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7274), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7273), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(7273), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("06217287-1cd7-4c5c-a2e0-62bd729eb595"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6888), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("18d33e7d-619c-4d58-bea2-8bc3da603198"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7154), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("321f8ba7-f980-4c6f-9941-fd611ba2a07e"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7089), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("38173ec4-82af-4cbb-8cf9-3c035c96ed05"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6882), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("403c6e98-1d5e-4c53-8fca-9e1cc9672477"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6998), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("460f4226-2f9c-417c-a5d4-4903f12ae822"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7144), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("4f064e7e-bd01-4ef8-93a7-df64659e0242"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6980), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("590c6ff1-a639-4ea0-a6d9-66570194b248"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7133), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("66bb70d2-ea78-40d2-b1be-151b9f4cbd73"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7126), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("785c1f8d-ef50-469d-8682-00b29fac78b0"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7119), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("8733a67a-3a66-4d95-a4b6-233958a3a099"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7149), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("9c5460ff-a745-4bc0-a544-1a5f50ecdd78"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6991), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("9d18004c-096e-432e-adec-b4e5b0b9720d"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7004), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a6735a7d-7992-4cef-8226-4eae5257bb34"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6974), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("a7ac22bc-99fd-4cd7-a323-875912c7178a"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6928), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("b673cfa0-1e22-42ed-a776-fe581e847eae"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7077), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("ba37856f-630c-44f4-8284-3fd46f5e79bc"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6874), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("bfc5cc4d-d1f8-4e72-bd69-f79699a02ba7"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7009), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("d93950de-e455-4428-bdd0-e264885beac3"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6934), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("db97d214-d5e8-4c14-8d46-b2f190409981"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6986), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("de812519-1ece-4592-a3b5-2cdeb54d0fe3"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7138), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f6ed25aa-b694-4b33-a671-6938808e13b3"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6899), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("fd234f82-9209-4f06-b990-d6f1be9329dd"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6940), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("fd9d5b7e-7747-4ad4-aad0-3f99c3c3c56a"), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7084), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3201), new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 3, 27, 15, 6, 24, 68, DateTimeKind.Utc).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 17, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 3, 25, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 3, 27, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"),
                column: "CreateDate",
                value: new DateTime(2025, 3, 22, 15, 6, 24, 65, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0dc76072-ff50-48bb-8c1f-4322b9cd1fef"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5062), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("3ee43e1a-65ef-4c02-b9bc-c3e7f3074937"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5058), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("4248f0fb-a3fc-4f0e-b2b9-5075ba21da82"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5075), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("53e9f46c-47c3-4338-b002-748a6e53df60"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5065), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("54804e8d-8c7d-48ee-a541-c26c1fd2ad5c"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5047), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("5eda3cc8-b91d-4096-9395-4be4aa85f8dd"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5055), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("79c3c8bb-397c-4d7b-a246-1077be304c77"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5069), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("8f13f942-a4f7-4b8c-a5bf-48a116ce372a"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5050), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("bbb4f3b3-26f2-4963-a90f-8e8397ec4637"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5071), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("d19c3538-69bc-4161-abff-e232cd18075e"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5077), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("f3355915-5e88-4b5b-98fd-69612a5adf79"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5067), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("f7deae56-316b-477b-a304-75874fca6435"), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5060), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4991), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4974), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5002), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4998), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4981), new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 3, 27, 22, 6, 24, 65, DateTimeKind.Local).AddTicks(4951));
        }
    }
}
