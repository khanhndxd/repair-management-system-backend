using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Change_warranty_period : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25a0a65a-8c26-48d0-a990-8f845133592d", null, "Technician", "TECHNICIAN" },
                    { "2bb5d1d4-2691-4ab9-8246-fcbee6a621a9", null, "Admin", "ADMIN" },
                    { "2eeba6aa-e5c9-4b12-a639-46f582f3192b", null, "Creator", "CREATOR" },
                    { "60b35331-6835-471f-9d37-feed300af77e", null, "Receiver", "RECEIVER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdb007f8-66df-4a5d-bb6b-395935317fa7", "AQAAAAIAAYagAAAAELyE7tJTC++1oqse5WepZIG5C19iaIz96PvwN5oXPLzl6QkgIgUSZlTh9ClvzXDJKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1641f3c4-7d2f-415c-ba0e-0db34b726b78", "AQAAAAIAAYagAAAAEEPd1F3lMPrhGah2n2KsAjFTtnZOUEhnP2aiAgaSCKh43Sv1qvWvjKyY/vAGbFT2Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "592ed803-faf0-4fd5-a2ca-d94f8185623e", "AQAAAAIAAYagAAAAEAw3Zc148CDD0mdMpghvazziN0h/MkrwM1lJ0+KT1691kFbYgZr8y9M7FCWRUcHbFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7780921-2bc4-44db-a44a-b158865c7ac2", "AQAAAAIAAYagAAAAEJfasoro3EDlFyNoKOXru8OJl4k8FjJ8S5E1iIqPdZffAuktXhPJW91aHMbsd1iU2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1706df11-d5a8-447d-be71-6d444edb9181", "AQAAAAIAAYagAAAAENFTKEIMMST29LEt0kOY5gqX07Ydg13EGpGzLuasmn5obRSuculcZa/pt5oY7cZ5Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2641c23e-5c35-4583-872e-0404312727af", "AQAAAAIAAYagAAAAEHD/QNYS3aBWyO9ovd1wA7foHm4GW25nVSCVeoPaiqug2J+DIUnj2SBK9XX9BA5mEA==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 53, 8, 163, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 53, 8, 163, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 53, 8, 163, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2bb5d1d4-2691-4ab9-8246-fcbee6a621a9", "1" },
                    { "2eeba6aa-e5c9-4b12-a639-46f582f3192b", "2" },
                    { "60b35331-6835-471f-9d37-feed300af77e", "3" },
                    { "60b35331-6835-471f-9d37-feed300af77e", "4" },
                    { "25a0a65a-8c26-48d0-a990-8f845133592d", "5" },
                    { "25a0a65a-8c26-48d0-a990-8f845133592d", "6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bb5d1d4-2691-4ab9-8246-fcbee6a621a9", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eeba6aa-e5c9-4b12-a639-46f582f3192b", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60b35331-6835-471f-9d37-feed300af77e", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60b35331-6835-471f-9d37-feed300af77e", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25a0a65a-8c26-48d0-a990-8f845133592d", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25a0a65a-8c26-48d0-a990-8f845133592d", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25a0a65a-8c26-48d0-a990-8f845133592d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5d1d4-2691-4ab9-8246-fcbee6a621a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eeba6aa-e5c9-4b12-a639-46f582f3192b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60b35331-6835-471f-9d37-feed300af77e");

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

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 5,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
