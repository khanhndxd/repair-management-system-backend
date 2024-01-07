using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Change_warranty_period_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4012e043-2de7-4931-9f36-762b7be3875b", null, "Admin", "ADMIN" },
                    { "4c4e83f8-e74a-4217-b07f-741f70ac81bc", null, "Creator", "CREATOR" },
                    { "83d43110-29df-4d66-8b78-70873cdb5311", null, "Technician", "TECHNICIAN" },
                    { "a5840369-f4a3-4a58-8b7c-d97d1b2181bd", null, "Receiver", "RECEIVER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6aa3f0af-6a94-46a4-af62-8dc4354e0985", "AQAAAAIAAYagAAAAEB/whwWcXih5ekbIms6yX3TXOYxGvGuOGNTIu8qY4mG8jgEKyJ+9pzbKP3Wf2d1+Mg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e518dd95-caf8-4492-b0ba-afbeac53e49b", "AQAAAAIAAYagAAAAEEH51/tynt6wiDs21XmdfcrwZCQ70TIbIFWE9EHsDWpVmpGorDL1GvDhqaYfFe0R/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c359d0a-7780-4eee-8a7a-cf30aeee1b05", "AQAAAAIAAYagAAAAECrFDG1G+4vt/+fCyF0htC2N0CRsWnAbQQ1lGooJABZUYDsqcxIDh52DdK8PDDcdWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e763d4b0-6efb-4894-9ffa-6e79ffac53a5", "AQAAAAIAAYagAAAAEO2Vb/Asj7vMpp7EtaobzXoJ5QHRMCi6EXxPLx0qqBTyG9RFL/KJaVTHIISCRsTuLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "625d5df9-e074-4d9b-ac32-fec919a83a41", "AQAAAAIAAYagAAAAEBzR9dISVryHpgBaXUO2YzRnqC/lGwwgS8Fu3n2xD7KbIrBxR1VPDj4OpfCAgS5I0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77058ca3-3986-417d-a566-4f59140d0173", "AQAAAAIAAYagAAAAEPxGyiD45S8oCJ+Fx8cY2Np0T2e8Y56X3oSulIhIaj6Hmc9Kg2zRjE0YgDV6uZEwXg==" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 55, 3, 200, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 55, 3, 200, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 7, 18, 55, 3, 200, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "PurchasedProducts",
                keyColumn: "Id",
                keyValue: 6,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4012e043-2de7-4931-9f36-762b7be3875b", "1" },
                    { "4c4e83f8-e74a-4217-b07f-741f70ac81bc", "2" },
                    { "a5840369-f4a3-4a58-8b7c-d97d1b2181bd", "3" },
                    { "a5840369-f4a3-4a58-8b7c-d97d1b2181bd", "4" },
                    { "83d43110-29df-4d66-8b78-70873cdb5311", "5" },
                    { "83d43110-29df-4d66-8b78-70873cdb5311", "6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4012e043-2de7-4931-9f36-762b7be3875b", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c4e83f8-e74a-4217-b07f-741f70ac81bc", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5840369-f4a3-4a58-8b7c-d97d1b2181bd", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5840369-f4a3-4a58-8b7c-d97d1b2181bd", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83d43110-29df-4d66-8b78-70873cdb5311", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83d43110-29df-4d66-8b78-70873cdb5311", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4012e043-2de7-4931-9f36-762b7be3875b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4e83f8-e74a-4217-b07f-741f70ac81bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83d43110-29df-4d66-8b78-70873cdb5311");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5840369-f4a3-4a58-8b7c-d97d1b2181bd");

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
                keyValue: 6,
                column: "WarrantyPeriod",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
