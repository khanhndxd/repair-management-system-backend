using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace repair_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerProducts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RepairedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceivedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiveAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiveType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    RepairTypeId = table.Column<int>(type: "int", nullable: false),
                    RepairReasonId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairOrders_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepairOrders_AspNetUsers_ReceivedById",
                        column: x => x.ReceivedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepairOrders_AspNetUsers_RepairedById",
                        column: x => x.RepairedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepairOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairOrders_RepairReasons_RepairReasonId",
                        column: x => x.RepairReasonId,
                        principalTable: "RepairReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairOrders_RepairTypes_RepairTypeId",
                        column: x => x.RepairTypeId,
                        principalTable: "RepairTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairOrders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairOrders_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchasedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProductSerial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedProducts_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairAccessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false),
                    AccessoryId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairAccessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairAccessories_Accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "Accessories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepairAccessories_RepairOrders_RepairOrderId",
                        column: x => x.RepairOrderId,
                        principalTable: "RepairOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepairCustomerProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerProductId = table.Column<int>(type: "int", nullable: false),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCustomerProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairCustomerProducts_CustomerProducts_CustomerProductId",
                        column: x => x.CustomerProductId,
                        principalTable: "CustomerProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepairCustomerProducts_RepairOrders_RepairOrderId",
                        column: x => x.RepairOrderId,
                        principalTable: "RepairOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepairLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairLogs_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairLogs_RepairOrders_RepairOrderId",
                        column: x => x.RepairOrderId,
                        principalTable: "RepairOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairTasks_RepairOrders_RepairOrderId",
                        column: x => x.RepairOrderId,
                        principalTable: "RepairOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepairTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepairProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false),
                    PurchasedProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairProducts_PurchasedProducts_PurchasedProductId",
                        column: x => x.PurchasedProductId,
                        principalTable: "PurchasedProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepairProducts_RepairOrders_RepairOrderId",
                        column: x => x.RepairOrderId,
                        principalTable: "RepairOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Price", "Unit" },
                values: new object[,]
                {
                    { 1, "RAM DDR4 8GB", 1000000.0, "Thanh" },
                    { 2, "RAM DDR4 16GB", 3000000.0, "Thanh" },
                    { 3, "RAM DDR4 32GB", 5000000.0, "Thanh" },
                    { 4, "Ổ cứng HDD 250GB", 1500000.0, "Chiếc" },
                    { 5, "Ổ cứng HDD 500GB", 3000000.0, "Chiếc" },
                    { 6, "Ổ cứng HDD 1TB", 6000000.0, "Chiếc" },
                    { 7, "Ổ cứng SSD 120GB", 3000000.0, "Chiếc" },
                    { 8, "Ổ cứng SSD 240GB", 6000000.0, "Chiếc" },
                    { 9, "Ổ cứng SSD 500GB", 12000000.0, "Chiếc" },
                    { 10, "Nguồn Corsair CX450M", 1500000.0, "Chiếc" },
                    { 11, "Nguồn Antec VP550", 2000000.0, "Chiếc" },
                    { 12, "Nguồn Seasonic Focus GX-550", 2500000.0, "Chiếc" },
                    { 13, "Nguồn Gigabyte P650B", 3000000.0, "Chiếc" },
                    { 14, "Nguồn EVGA SuperNOVA GA650", 3500000.0, "Chiếc" },
                    { 15, "Màn hình Acer Nitro VG240Y", 4000000.0, "Chiếc" },
                    { 16, "Màn hình ASUS TUF Gaming VG24VQ", 5000000.0, "Chiếc" },
                    { 17, "Màn hình Dell S2722DGM", 6000000.0, "Chiếc" },
                    { 18, "Màn hình Samsung Odyssey G32T550", 7000000.0, "Chiếc" },
                    { 19, "Màn hình LG UltraGear 27GN600-B", 8000000.0, "Chiếc" },
                    { 20, "Logitech C920 HD Pro", 4500000.0, "Chiếc" },
                    { 21, "Logitech Brio 4K", 9000000.0, "Chiếc" },
                    { 22, "Razer Kiyo Pro", 12000000.0, "Chiếc" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4035ce5c-4731-4fb2-af49-ff433db651aa", null, "Technician", null },
                    { "57e5fe0c-273b-4920-a9c7-67a5acf08c40", null, "Admin", null },
                    { "e0202692-4be9-4182-a2fd-3034055d0447", null, "Staff", null },
                    { "f4d30968-d935-4128-985c-83642a5cc959", null, "Techlead", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "b0578801-243c-4b7b-837f-aaa065ee54af", "User", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "NGUYỄN DUY KHÁNH", "AQAAAAIAAYagAAAAEK3wP8iKQR+xlAIaXoVb+M83Tv/fkUoaNGdzM9HDcUB3chCrKsiwho5SGik5nC0jfg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Duy Khánh" },
                    { "2", 0, "415dd5b1-2c3a-4f39-acd7-698ad9fb760f", "User", "staff1@staff.com", true, false, null, "STAFF1@STAFF.COM", "NGUYỄN HOÀNG A", "AQAAAAIAAYagAAAAEC4oWLf2CdkOOKOTz1+GyOcKyDTD4h6AJSkGbZL461qeNcRb+AgVsbUFmmAP18L1ug==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Hoàng A" },
                    { "3", 0, "9c608353-aaa0-4281-957a-e8b23488da59", "User", "lead1@lead.com", true, false, null, "LEAD1@LEAD.COM", "NGUYỄN VĂN HOÀNG", "AQAAAAIAAYagAAAAEJCp+k7Bf/OinBjYS70wyE+HKTr3VqozTQQAOhPxLTYl5mSJkSJpLF1anOGN3ymEDw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Văn Hoàng" },
                    { "4", 0, "495163f0-4ed8-475a-812e-21a61ba13e13", "User", "tech1@tech.com", true, false, null, "TECH1@TECH.COM", "NGUYỄN DUY QUANG", "AQAAAAIAAYagAAAAEGx/TEY4OHLe7NKp/Z4giTkZ2CLAjgzLUUYVVpIf33DnbaFzL+VvjlaIo3qi4fyLeA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Duy Quang" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Màn hình" },
                    { 2, "Nguồn máy tính" },
                    { 3, "Mainboard" },
                    { 4, "Chuột" },
                    { 5, "Bàn phím" },
                    { 6, "Thiết bị lưu trữ, bộ nhớ" },
                    { 7, "Tai nghe" },
                    { 8, "CPU" },
                    { 9, "VGA" },
                    { 10, "Tản nhiệt" },
                    { 11, "Ergonomic" },
                    { 12, "Webcam" },
                    { 13, "PC" },
                    { 14, "Thiết bị ngoại vi" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Note", "Phone" },
                values: new object[,]
                {
                    { 1, "97 HAO NAM, P.O CHO DUA, DONG DA, HA NOI", "nguyenvana@gmail.com", "Nguyễn Văn A", "", "0123456789" },
                    { 2, "30 HANG BONG, HANG GAI, HOAN KIEM, HA NOI", "daovanb@gmail.com", "Đào Văn B", "", "9485769278" },
                    { 3, "6 NGACH 371/9 KIM MA, BA DINH, HA NOI", "nguyenmanhc@gmail.com", "Nguyễn Mạnh C", "", "0293847562" },
                    { 4, "SO 48 LE DAI HANH, HA BA TRUNG, HA NOI", "buivand@gmail.com", "Bùi Văn D", "", "0192845924" },
                    { 5, "110 NGUYEN NGOC NAI, KHUONG MAI, T.XUAN, HN", "phamvane@gmail.com", "Phạm Văn E", "", "0495867284" },
                    { 6, "65B HAI BA TRUNG, HOAN KIEM, HA NOI", "nguyenhuyg@gmail.com", "Nguyễn Huy G", "", "0394857624" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Corsair" },
                    { 2, "Dell" },
                    { 3, "Acer" },
                    { 4, "ASUS" },
                    { 5, "Kingston" },
                    { 6, "Logitech" },
                    { 7, "Razer" },
                    { 8, "Intel" },
                    { 9, "AMD" }
                });

            migrationBuilder.InsertData(
                table: "RepairReasons",
                columns: new[] { "Id", "Reason" },
                values: new object[,]
                {
                    { 1, "Sản phẩm lỗi" },
                    { 2, "Đổi mới" },
                    { 3, "Giao nhầm sản phẩm cho khách" }
                });

            migrationBuilder.InsertData(
                table: "RepairTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bảo hành" },
                    { 2, "Sửa chữa" },
                    { 3, "Đổi mới" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chờ xử lý" },
                    { 2, "Đã tiếp nhận" },
                    { 3, "Đang sửa chữa" },
                    { 4, "Đã chuyển sản phẩm về hãng" },
                    { 5, "Đã nhận sản phẩm từ hãng" },
                    { 6, "Đã sửa xong" },
                    { 7, "Đã hủy" },
                    { 8, "Đã hoàn thành" },
                    { 9, "Đã trả hàng" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Vệ sinh máy tính", 100000.0 },
                    { 2, "Cài lại win", 200000.0 },
                    { 3, "Cài đặt phần mềm", 50000.0 },
                    { 4, "Sửa chữa phần mềm", 100000.0 },
                    { 5, "Bảo dưỡng định kỳ", 100000.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "57e5fe0c-273b-4920-a9c7-67a5acf08c40", "1" },
                    { "e0202692-4be9-4182-a2fd-3034055d0447", "2" },
                    { "f4d30968-d935-4128-985c-83642a5cc959", "3" },
                    { "4035ce5c-4731-4fb2-af49-ff433db651aa", "4" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7885), 1, 1200000.0 },
                    { 2, new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7897), 2, 1600000.0 },
                    { 3, new DateTime(2023, 12, 3, 17, 25, 16, 620, DateTimeKind.Local).AddTicks(7897), 3, 2400000.0 }
                });

            migrationBuilder.InsertData(
                table: "PurchasedProducts",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Price", "ProductName", "ProductSerial", "PurchaseOrderId", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 1, 2, 1, 1500000.0, "Nguồn Corsair CX450M", "8887", 1, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 2, 6000000.0, "Màn hình Dell S2722DGM", "8888", 2, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12, 6, 4500000.0, "Logitech C920 HD Pro", "8889", 3, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_CategoryId",
                table: "PurchasedProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_ManufacturerId",
                table: "PurchasedProducts",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedProducts_PurchaseOrderId",
                table: "PurchasedProducts",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CustomerId",
                table: "PurchaseOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairAccessories_AccessoryId",
                table: "RepairAccessories",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairAccessories_RepairOrderId",
                table: "RepairAccessories",
                column: "RepairOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairCustomerProducts_CustomerProductId",
                table: "RepairCustomerProducts",
                column: "CustomerProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairCustomerProducts_RepairOrderId",
                table: "RepairCustomerProducts",
                column: "RepairOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairLogs_CreatedById",
                table: "RepairLogs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RepairLogs_RepairOrderId",
                table: "RepairLogs",
                column: "RepairOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_CreatedById",
                table: "RepairOrders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_CustomerId",
                table: "RepairOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_ReceivedById",
                table: "RepairOrders",
                column: "ReceivedById");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_RepairedById",
                table: "RepairOrders",
                column: "RepairedById");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_RepairReasonId",
                table: "RepairOrders",
                column: "RepairReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_RepairTypeId",
                table: "RepairOrders",
                column: "RepairTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_StatusId",
                table: "RepairOrders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_TaskId",
                table: "RepairOrders",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairProducts_PurchasedProductId",
                table: "RepairProducts",
                column: "PurchasedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairProducts_RepairOrderId",
                table: "RepairProducts",
                column: "RepairOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairTasks_RepairOrderId",
                table: "RepairTasks",
                column: "RepairOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairTasks_TaskId",
                table: "RepairTasks",
                column: "TaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RepairAccessories");

            migrationBuilder.DropTable(
                name: "RepairCustomerProducts");

            migrationBuilder.DropTable(
                name: "RepairLogs");

            migrationBuilder.DropTable(
                name: "RepairProducts");

            migrationBuilder.DropTable(
                name: "RepairTasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "CustomerProducts");

            migrationBuilder.DropTable(
                name: "PurchasedProducts");

            migrationBuilder.DropTable(
                name: "RepairOrders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RepairReasons");

            migrationBuilder.DropTable(
                name: "RepairTypes");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
