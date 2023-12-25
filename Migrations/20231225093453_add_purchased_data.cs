using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class add_purchased_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ce1511c-3897-4f29-8db7-a28db47c4346", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0daad90d-3bb9-46aa-8287-2767cbfd499a", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6697ba67-6c19-41f7-8b95-cf41018bb78f", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6697ba67-6c19-41f7-8b95-cf41018bb78f", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0daad90d-3bb9-46aa-8287-2767cbfd499a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6697ba67-6c19-41f7-8b95-cf41018bb78f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ce1511c-3897-4f29-8db7-a28db47c4346");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fa41992-5392-4a69-8a7b-255d015f750c", null, "Technician", "TECHNICIAN" },
                    { "5440f7ee-7588-4804-bd51-08da1284ed20", null, "Creator", "CREATOR" },
                    { "603993f2-5464-4462-8af0-2457fe35bd56", null, "Receiver", "RECEIVER" },
                    { "61076888-8f2b-45ac-b020-4480605724ca", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b6d3371-d2b6-4d3b-a91b-0d25576633d8", "AQAAAAIAAYagAAAAEDpRPpbX14/wd/r3IvKwplx1D9MmBRUgkTQGqRmnTflqDwbRxHlk7o+S5BSaQUEQMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d1b7742-3766-43e6-a8ff-5e2b47137818", "AQAAAAIAAYagAAAAEJ/CI4WHqJnoC1gJl5UD+jL2pme9ltyAFz+vIohSElZdJNKJ2c1k0XHoRAQJvPgO4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07c049cf-37d7-4733-a773-33850945011d", "AQAAAAIAAYagAAAAEDPrRSw5h0tlEMsBnQEopcPj973w5Pi1uh65chtZjJ1LQxjT81k99Hq8/3S+/s9Akg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e899b3a-cc69-4641-9892-ea1c2a3e518e", "AQAAAAIAAYagAAAAEDETfhP8lo987+jkBcqt7KfjaHBF/OsPUhFyvd42yB63pDVklXCOti3jh3ey+1kasA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c8598a5-5949-4555-8b79-ef3e43739c24", "AQAAAAIAAYagAAAAEOKiMRKOnorNkk4rLAZr1yUoE2Nj5MDGwvxCH2c3Gwzwm7Hf5W2ALWOK2EiMvDzI7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a34dd5a5-e629-4548-9e06-a443c138badd", "AQAAAAIAAYagAAAAEJGeyMYSn3vGGC2NYWph5fF7elZf7YDTqXKIj7m6Jn6kBjE34vIBS6sUy/B5xDrHMg==" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "LG" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 25, 16, 34, 52, 389, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 25, 16, 34, 52, 389, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 25, 16, 34, 52, 389, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.InsertData(
                table: "PurchasedProducts",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Price", "ProductName", "ProductSerial", "PurchaseOrderId", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 4, 6, 5, 3000000.0, "Ổ cứng HDD 500GB", "8890", 1, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 5, 5000000.0, "RAM DDR4 32GB", "8892", 2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 12, 7, 12000000.0, "Razer Kiyo Pro", "8893", 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 2, 6000000.0, "Màn hình Dell S2722DGM", "8894", 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RepairReasons",
                columns: new[] { "Id", "Reason" },
                values: new object[] { 5, "Khác" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "61076888-8f2b-45ac-b020-4480605724ca", "1" },
                    { "5440f7ee-7588-4804-bd51-08da1284ed20", "2" },
                    { "603993f2-5464-4462-8af0-2457fe35bd56", "3" },
                    { "603993f2-5464-4462-8af0-2457fe35bd56", "4" },
                    { "2fa41992-5392-4a69-8a7b-255d015f750c", "5" },
                    { "2fa41992-5392-4a69-8a7b-255d015f750c", "6" }
                });

            migrationBuilder.InsertData(
                table: "PurchasedProducts",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Price", "ProductName", "ProductSerial", "PurchaseOrderId", "WarrantyPeriod" },
                values: new object[] { 5, 1, 10, 8000000.0, "Màn hình LG UltraGear 27GN600-B", "8891", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61076888-8f2b-45ac-b020-4480605724ca", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5440f7ee-7588-4804-bd51-08da1284ed20", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "603993f2-5464-4462-8af0-2457fe35bd56", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "603993f2-5464-4462-8af0-2457fe35bd56", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2fa41992-5392-4a69-8a7b-255d015f750c", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2fa41992-5392-4a69-8a7b-255d015f750c", "6" });

            migrationBuilder.DeleteData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fa41992-5392-4a69-8a7b-255d015f750c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5440f7ee-7588-4804-bd51-08da1284ed20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "603993f2-5464-4462-8af0-2457fe35bd56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61076888-8f2b-45ac-b020-4480605724ca");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0daad90d-3bb9-46aa-8287-2767cbfd499a", null, "Creator", "CREATOR" },
                    { "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9", null, "Receiver", "RECEIVER" },
                    { "6697ba67-6c19-41f7-8b95-cf41018bb78f", null, "Technician", "TECHNICIAN" },
                    { "6ce1511c-3897-4f29-8db7-a28db47c4346", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b0787c0-6a32-4215-a274-53b693cedada", "AQAAAAIAAYagAAAAEKmHmkGye2w7Cjk6JtKusYdM8Hj4ZPXFstoTmuF0ZwT2z6c2NNkDFIN762mhb15ABg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b31e162c-a3c4-419d-bcc8-f628d1e22dc6", "AQAAAAIAAYagAAAAEFdpswKbXjlfWWPxyN5eY+3wkboCjVMv+aID4YrN01R6n3qUu7tvLFvNQFez9NlnFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "443c5ccc-b3c4-4faa-bf5d-260346a5abab", "AQAAAAIAAYagAAAAEAEorS3WAy17C6jEWaAxUlrSNKV5WYS1DnniRxNUnLGhopa0ejQa0kSift7uXiON1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f135d62c-3df5-4149-9e9e-e6e4105b57a1", "AQAAAAIAAYagAAAAEBh+yCRrazB/0wd73DmYrpD5fmOanUVGp7w508+tE/HfY3Uog2vfdC751oKA/bg/cQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c041bb7-4a6f-4389-a9af-f5674fd759d9", "AQAAAAIAAYagAAAAEG+aR4wmnZZU8Gu+CZAvuXTHJRrm3RAU+mAFmTZJYkWU5ByOJ9MCCuwiu6s0WcsBJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f702a88f-3d73-48a6-82db-ac1a5c4ecded", "AQAAAAIAAYagAAAAEOTmg3VL6tnE7NkX0iXMOwjZ47uzV2Ud+Tl3A/y98uZqKcOLmmtegQParaFzbeOuqQ==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 15, 32, 49, 390, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 15, 32, 49, 390, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 24, 15, 32, 49, 390, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6ce1511c-3897-4f29-8db7-a28db47c4346", "1" },
                    { "0daad90d-3bb9-46aa-8287-2767cbfd499a", "2" },
                    { "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9", "3" },
                    { "2bbd6ecc-d159-4b28-b6a8-9f654aca72c9", "4" },
                    { "6697ba67-6c19-41f7-8b95-cf41018bb78f", "5" },
                    { "6697ba67-6c19-41f7-8b95-cf41018bb78f", "6" }
                });
        }
    }
}
