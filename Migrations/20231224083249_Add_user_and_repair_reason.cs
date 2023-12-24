using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Add_user_and_repair_reason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f678273-e39a-40f6-924b-2e2d1ba2a392", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2952c29-c0f2-4837-8409-c48e574a1954", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24b17cc8-44a8-4d55-9a94-7ba39fedc768");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28ed9c30-8f1d-40ae-8ffe-675b323153f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f678273-e39a-40f6-924b-2e2d1ba2a392");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2952c29-c0f2-4837-8409-c48e574a1954");

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "f135d62c-3df5-4149-9e9e-e6e4105b57a1", "receiver2@receiver.com", "RECEIVER2@RECEIVER.COM", "NGUYỄN HOÀNG KHOA", "AQAAAAIAAYagAAAAEBh+yCRrazB/0wd73DmYrpD5fmOanUVGp7w508+tE/HfY3Uog2vfdC751oKA/bg/cQ==", "Nguyễn Hoàng Khoa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "7c041bb7-4a6f-4389-a9af-f5674fd759d9", "User", "tech1@tech.com", true, false, null, "TECH1@TECH.COM", "NGUYỄN DUY QUANG", "AQAAAAIAAYagAAAAEG+aR4wmnZZU8Gu+CZAvuXTHJRrm3RAU+mAFmTZJYkWU5ByOJ9MCCuwiu6s0WcsBJg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Duy Quang" },
                    { "6", 0, "f702a88f-3d73-48a6-82db-ac1a5c4ecded", "User", "tech2@tech.com", true, false, null, "TECH2@TECH.COM", "NGUYỄN THẾ HUY", "AQAAAAIAAYagAAAAEOTmg3VL6tnE7NkX0iXMOwjZ47uzV2Ud+Tl3A/y98uZqKcOLmmtegQParaFzbeOuqQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Thế Huy" }
                });

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

            migrationBuilder.UpdateData(
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reason",
                value: "Lỗi phần mềm");

            migrationBuilder.UpdateData(
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Reason",
                value: "Lỗi phần cứng");

            migrationBuilder.InsertData(
                table: "RepairReasons",
                columns: new[] { "Id", "Reason" },
                values: new object[] { 4, "Hỏng hóc, va đập" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 200000.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", null, "Creator", "CREATOR" },
                    { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", null, "Receiver", "RECEIVER" },
                    { "6f678273-e39a-40f6-924b-2e2d1ba2a392", null, "Admin", "ADMIN" },
                    { "d2952c29-c0f2-4837-8409-c48e574a1954", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91236f40-4910-4640-a486-e898144bfd1c", "AQAAAAIAAYagAAAAED1gLNLbQ31S7EvHmBEWkcvF5u8/yIfsea0GQ26Xw3fDkhHmMi1SSseP2+xuvvs3GQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fd61d17-8ee9-487a-b8bd-77a8f8a65c73", "AQAAAAIAAYagAAAAEIpdiHiBzcRtwcUbbVy8ZZl1nDmIF6PedPKYVr3pqShHdQ3LkU2lwwhqoSVSVOttng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "974d8667-65a7-468c-ac4e-193ec5a86e5f", "AQAAAAIAAYagAAAAENKK/sYumtAJThHCDZRUtUb1tzrTObh7v0vklpLLo1eymPeVB8LKahf1LI0SEkNPdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "2e876c55-ccb8-41f3-b624-3c394afc347f", "tech1@tech.com", "TECH1@TECH.COM", "NGUYỄN DUY QUANG", "AQAAAAIAAYagAAAAEL8VHvXT6i8AYCrf1MeEb9e/gm/5hg0y07cCJbbEamoqR/WlSUh0ZeuENF0SqjGz4Q==", "Nguyễn Duy Quang" });

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "PurchaseOrders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 17, 11, 35, 29, 940, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reason",
                value: "Sản phẩm lỗi");

            migrationBuilder.UpdateData(
                table: "RepairReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Reason",
                value: "Giao nhầm sản phẩm cho khách");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f678273-e39a-40f6-924b-2e2d1ba2a392", "1" },
                    { "24b17cc8-44a8-4d55-9a94-7ba39fedc768", "2" },
                    { "28ed9c30-8f1d-40ae-8ffe-675b323153f2", "3" },
                    { "d2952c29-c0f2-4837-8409-c48e574a1954", "4" }
                });
        }
    }
}
