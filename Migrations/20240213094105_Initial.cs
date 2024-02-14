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
                name: "WarrantyPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarrantyPolicies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
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
                name: "WarrantyPolicyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarrantyPolicyId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyPolicyTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarrantyPolicyTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WarrantyPolicyTasks_WarrantyPolicies_WarrantyPolicyId",
                        column: x => x.WarrantyPolicyId,
                        principalTable: "WarrantyPolicies",
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
                    { "009bcfb0-bcab-40c9-a759-bbb55562519e", null, "Creator", "CREATOR" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", null, "Receiver", "RECEIVER" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", null, "Technician", "TECHNICIAN" },
                    { "dd1bcdad-35e4-486e-ad63-19aca5e80e35", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "06030b66-424c-4f7d-9e25-a17a4a17dcc9", "User", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "NGUYỄN DUY KHÁNH", "AQAAAAIAAYagAAAAEGIAyXs0SMwJnHGrmygTmK8t5MQhpdilfrL7HFsc0A072ZFavsc1hGxXtVJLyHo25Q==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Duy Khánh" },
                    { "2", 0, "0554bdec-abaa-48a2-86b1-4c633d448f45", "User", "creator1@creator.com", true, false, null, "CREATOR1@CREATOR.COM", "NGUYỄN HOÀNG A", "AQAAAAIAAYagAAAAEONyZfgmtTLW4Evv19Be2SNzMh3uh7cqQDycwZE4wSIdPg5PeSRTOOmOIxHOsro3DA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Hoàng A" },
                    { "3", 0, "92fd44cb-4f04-495e-b2e9-dc4b5fb2d707", "User", "receiver1@receiver.com", true, false, null, "RECEIVER1@RECEIVER.COM", "NGUYỄN VĂN HOÀNG", "AQAAAAIAAYagAAAAECPnEH0pTCpayp/DElveZfTQ/kvgIMjEIT65yTJNJrVcyMzMvityB9E3GVpHJCV7Ow==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Văn Hoàng" },
                    { "4", 0, "e75d5485-4d6e-45f3-a491-6b7032fe2b4c", "User", "receiver2@receiver.com", true, false, null, "RECEIVER2@RECEIVER.COM", "NGUYỄN HOÀNG KHOA", "AQAAAAIAAYagAAAAEIGi/y76/1CTr3z5JHZg4+wcO0Vgn4ds1Z8kS6d7czrhctOvgFxjGzBuC17P+Mv3Dg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Hoàng Khoa" },
                    { "5", 0, "5e359824-3a2e-4e7c-b220-1a547e169a5b", "User", "tech1@tech.com", true, false, null, "TECH1@TECH.COM", "NGUYỄN DUY QUANG", "AQAAAAIAAYagAAAAEL8q2Mz2WlbnmetAaZaDluAiinejGI+OXemtgDx1S+67L26bXjVQ5QJ8dIf8jFEKPA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Duy Quang" },
                    { "6", 0, "a590615e-3d85-4da5-94f8-61c530783b96", "User", "tech2@tech.com", true, false, null, "TECH2@TECH.COM", "NGUYỄN THẾ HUY", "AQAAAAIAAYagAAAAEIebcVVn1ErGJ+qW6syhmswMW7bU9fvSaGbfc1j7hAOCX/xrTdIzqmXONavHlZT++Q==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Nguyễn Thế Huy" }
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
                    { 11, "Card màn hình" },
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
                    { 9, "AMD" },
                    { 10, "LG" }
                });

            migrationBuilder.InsertData(
                table: "RepairReasons",
                columns: new[] { "Id", "Reason" },
                values: new object[,]
                {
                    { 1, "Lỗi phần mềm" },
                    { 2, "Đổi mới" },
                    { 3, "Lỗi phần cứng" },
                    { 4, "Hỏng hóc, va đập" },
                    { 5, "Khác" }
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
                    { 1, "Vệ sinh sản phẩm", 100000.0 },
                    { 2, "Cài đặt phần mềm", 50000.0 },
                    { 3, "Sửa chữa phần mềm", 100000.0 },
                    { 4, "Thay thế linh kiện", 100000.0 },
                    { 5, "Đổi mới", 0.0 },
                    { 6, "Sửa chữa phần cứng", 200000.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dd1bcdad-35e4-486e-ad63-19aca5e80e35", "1" },
                    { "009bcfb0-bcab-40c9-a759-bbb55562519e", "2" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "3" },
                    { "a7d13cf3-9de4-4736-8bf2-d9fafcc1a232", "4" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "5" },
                    { "c896a667-3ea4-4b98-af9d-2545ea4b188c", "6" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4887), 1, 1200000.0 },
                    { 2, new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4907), 2, 1600000.0 },
                    { 3, new DateTime(2024, 2, 13, 16, 41, 4, 850, DateTimeKind.Local).AddTicks(4909), 3, 2400000.0 }
                });

            migrationBuilder.InsertData(
                table: "WarrantyPolicies",
                columns: new[] { "Id", "CategoryId", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Chính sách bảo hành của Màn hình" },
                    { 2, 2, "Chính sách bảo hành của Nguồn máy tính" },
                    { 3, 3, "Chính sách bảo hành của Mainboard" },
                    { 4, 4, "Chính sách bảo hành của Chuột" },
                    { 5, 5, "Chính sách bảo hành của Bàn phím" },
                    { 6, 6, "Chính sách bảo hành của Thiết bị lưu trữ, bộ nhớ" },
                    { 7, 7, "Chính sách bảo hành của Tai nghe" },
                    { 8, 8, "Chính sách bảo hành của CPU" },
                    { 9, 9, "Chính sách bảo hành của VGA" },
                    { 10, 10, "Chính sách bảo hành của Tản nhiệt" },
                    { 11, 11, "Chính sách bảo hành của Card màn hình" },
                    { 12, 12, "Chính sách bảo hành của Webcam" },
                    { 13, 13, "Chính sách bảo hành của PC" },
                    { 14, 14, "Chính sách bảo hành của Thiết bị ngoại vi" }
                });

            migrationBuilder.InsertData(
                table: "PurchasedProducts",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Price", "ProductName", "ProductSerial", "PurchaseOrderId", "WarrantyPeriod" },
                values: new object[,]
                {
                    { 1, 2, 1, 1500000.0, "Nguồn Corsair CX450M", "8887", 1, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 2, 6000000.0, "Màn hình Dell S2722DGM", "8888", 2, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12, 6, 4500000.0, "Logitech C920 HD Pro", "8889", 3, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 6, 5, 3000000.0, "Ổ cứng HDD 500GB", "8890", 1, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 10, 8000000.0, "Màn hình LG UltraGear 27GN600-B", "8891", 1, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 5, 5000000.0, "RAM DDR4 32GB", "8892", 2, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 12, 7, 12000000.0, "Razer Kiyo Pro", "8893", 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 2, 6000000.0, "Màn hình Dell S2722DGM", "8894", 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WarrantyPolicyTasks",
                columns: new[] { "Id", "TaskId", "WarrantyPolicyId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 6, 1 },
                    { 3, 4, 2 },
                    { 4, 6, 2 },
                    { 5, 4, 3 },
                    { 6, 6, 3 },
                    { 7, 4, 4 },
                    { 8, 5, 4 },
                    { 9, 6, 4 },
                    { 10, 4, 5 },
                    { 11, 5, 5 },
                    { 12, 6, 5 },
                    { 13, 4, 6 },
                    { 14, 5, 6 },
                    { 15, 4, 7 },
                    { 16, 5, 7 },
                    { 17, 5, 8 },
                    { 18, 4, 9 },
                    { 19, 5, 9 },
                    { 20, 4, 10 },
                    { 21, 6, 10 },
                    { 22, 4, 11 },
                    { 23, 5, 11 },
                    { 24, 6, 11 },
                    { 25, 5, 12 },
                    { 26, 6, 12 },
                    { 27, 4, 13 },
                    { 28, 6, 13 },
                    { 29, 4, 14 },
                    { 30, 5, 11 }
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

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicies_CategoryId",
                table: "WarrantyPolicies",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicyTasks_TaskId",
                table: "WarrantyPolicyTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyPolicyTasks_WarrantyPolicyId",
                table: "WarrantyPolicyTasks",
                column: "WarrantyPolicyId");
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
                name: "WarrantyPolicyTasks");

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
                name: "WarrantyPolicies");

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
