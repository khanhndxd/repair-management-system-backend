﻿using Microsoft.AspNetCore.Identity;

namespace repair_management_backend.Data
{
    public static class Seeder
    {
        public static void SeedUsersWithRoles(ModelBuilder modelBuilder)
        {
            var roles = new List<IdentityRole>
        {
            new IdentityRole("Admin"),
            new IdentityRole("Staff")
        };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            var hasher = new PasswordHasher<User>();
            var users = new List<User>()
            {
                new User
                {
                    Id = "1",
                    UserName = "Nguyễn Duy Khánh",
                    NormalizedUserName = "NGUYỄN DUY KHÁNH",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty
                },
                new User
                {
                    Id = "2",
                    UserName = "Nguyễn Hoàng A",
                    NormalizedUserName = "NGUYỄN HOÀNG A",
                    Email = "staff1@staff.com",
                    NormalizedEmail = "STAFF1@STAFF.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            // Seed UserRoles
            var userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string> { UserId = users[0].Id, RoleId = roles.First(r => r.Name == "Admin").Id });
            userRoles.Add(new IdentityUserRole<string> { UserId = users[1].Id, RoleId = roles.First(r => r.Name == "Staff").Id });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
        public static List<Customer> GetCustomerSeedingData()
        {
            return new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Name = "Nguyễn Văn A",
                    Address = "97 HAO NAM, P.O CHO DUA, DONG DA, HA NOI",
                    Email = "nguyenvana@gmail.com",
                    Phone = "0123456789"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Đào Văn B",
                    Address = "30 HANG BONG, HANG GAI, HOAN KIEM, HA NOI",
                    Email = "daovanb@gmail.com",
                    Phone = "9485769278"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Nguyễn Mạnh C",
                    Address = "6 NGACH 371/9 KIM MA, BA DINH, HA NOI",
                    Email = "nguyenmanhc@gmail.com",
                    Phone = "0293847562"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Bùi Văn D",
                    Address = "SO 48 LE DAI HANH, HA BA TRUNG, HA NOI",
                    Email = "buivand@gmail.com",
                    Phone = "0192845924"
                },
                new Customer
                {
                    Id = 5,
                    Name = "Phạm Văn E",
                    Address = "110 NGUYEN NGOC NAI, KHUONG MAI, T.XUAN, HN",
                    Email = "phamvane@gmail.com",
                    Phone = "0495867284"
                },
                new Customer
                {
                    Id = 6,
                    Name = "Nguyễn Huy G",
                    Address = "65B HAI BA TRUNG, HOAN KIEM, HA NOI",
                    Email = "nguyenhuyg@gmail.com",
                    Phone = "0394857624"
                }
            };
        }
        public static List<PurchaseOrder> GetPurchaseOrderSeedingData()
        {
            return new List<PurchaseOrder>()
            {
                new PurchaseOrder { Id = 1, CustomerId = 1, Total = 1200000.0, CreatedAt = DateTime.Now },
                new PurchaseOrder { Id = 2, CustomerId = 2, Total = 1600000.0, CreatedAt = DateTime.Now },
                new PurchaseOrder { Id = 3, CustomerId = 3, Total = 2400000.0, CreatedAt = DateTime.Now },
            };
        }
        public static List<Manufacturer> GetManufacturersSeedingData()
        {
            return new List<Manufacturer>()
            { 
                new Manufacturer { Id = 1, Name = "Corsair"},
                new Manufacturer { Id = 2, Name = "Dell"},
                new Manufacturer { Id = 3, Name = "Acer"},
                new Manufacturer { Id = 4, Name = "ASUS"},
                new Manufacturer { Id = 5, Name = "Kingston"},
                new Manufacturer { Id = 6, Name = "Logitech"},
                new Manufacturer { Id = 7, Name = "Razer"},
                new Manufacturer { Id = 8, Name = "Intel"},
                new Manufacturer { Id = 9, Name = "AMD"},
            };
        }
        public static List<Category> GetCategoriesSeedingData()
        {
            return new List<Category>()
            {
                new Category { Id = 1, Name = "Màn hình"},
                new Category { Id = 2, Name = "Nguồn máy tính"},
                new Category { Id = 3, Name = "Mainboard" },
                new Category { Id = 4, Name = "Chuột" },
                new Category { Id = 5, Name = "Bàn phím"},
                new Category { Id = 6, Name = "Thiết bị lưu trữ, bộ nhớ" },
                new Category { Id = 7, Name = "Tai nghe" },
                new Category { Id = 8, Name = "CPU" },
                new Category { Id = 9, Name = "VGA" },
                new Category { Id = 10, Name = "Tản nhiệt" },
                new Category { Id = 11, Name = "Ergonomic" },
                new Category { Id = 12, Name = "Webcam" },
                new Category { Id = 13, Name = "PC" },
                new Category { Id = 14, Name = "Thiết bị ngoại vi" },
            };
        }
        public static List<PurchasedProduct> GetPurchasedProductsSeedingData()
        {
            return new List<PurchasedProduct>()
            {
                new PurchasedProduct { Id = 1, ProductName = "Nguồn Corsair CX450M", PurchaseOrderId = 1, ProductSerial = "8887", CategoryId = 2, ManufacturerId = 1, WarrantyPeriod = DateTime.Parse("2023-12-31"), Price = 1500000 },
                new PurchasedProduct { Id = 2, ProductName = "Màn hình Dell S2722DGM", PurchaseOrderId = 2, ProductSerial = "8888", CategoryId = 1, ManufacturerId = 2, WarrantyPeriod = DateTime.Parse("2023-12-31"), Price = 6000000 },
                new PurchasedProduct { Id = 3, ProductName = "Logitech C920 HD Pro", PurchaseOrderId = 3, ProductSerial = "8889", CategoryId = 12, ManufacturerId = 6, WarrantyPeriod = DateTime.Parse("2023-12-31"), Price = 4500000 }
            };
        }
        public static List<Status> GetStatusSeedingData()
        {
            return new List<Status>()
            {
                new Status { Id = 1, Name = "Chờ xử lý" },
                new Status { Id = 2, Name = "Đã tiếp nhận" },
                new Status { Id = 3, Name = "Đang sửa chữa" },
                new Status { Id = 4, Name = "Đã chuyển sản phẩm về hãng" },
                new Status { Id = 5, Name = "Đã nhận sản phẩm từ hãng" },
                new Status { Id = 6, Name = "Đã sửa xong" },
                new Status { Id = 7, Name = "Đã hủy" },
                new Status { Id = 8, Name = "Đã hoàn thành" },
                new Status { Id = 9, Name = "Đã trả hàng" },
            };
        }
        public static List<RepairType> GetRepairTypeSeedingData()
        {
            return new List<RepairType>()
            {
                new RepairType { Id = 1, Name = "Bảo hành" },
                new RepairType { Id = 2, Name = "Sửa chữa" },
            };
        }
        public static List<RepairReason> GetRepairReasonSeedingData()
        {
            return new List<RepairReason>()
            {
                new RepairReason { Id = 1, Reason = "Sản phẩm lỗi"},
                new RepairReason{ Id = 2, Reason = "Đổi mới" },
                new RepairReason { Id = 3, Reason = "Giao nhầm sản phẩm cho khách"}
            };
        }
        public static List<Models.Task> GetTaskSeedingData()
        {
            return new List<Models.Task>()
            {
                new Models.Task { Id = 1, Name = "Vệ sinh máy tính", Price = 100000.0 },
                new Models.Task { Id = 2, Name = "Cài lại win", Price = 200000.0 },
                new Models.Task { Id = 3, Name = "Cài đặt phần mềm", Price = 50000.0 },
                new Models.Task { Id = 4, Name = "Sửa chữa phần mềm", Price = 100000.0 },
                new Models.Task { Id = 5, Name = "Bảo dưỡng định kỳ", Price = 100000.0 },
            };
        }
        public static List<Accessory> GetAccessorySeedingData()
        {
            return new List<Accessory>()
            {
                new Accessory { Id = 1, Name = "RAM DDR4 8GB", Price = 1000000, Unit = "Thanh" },
                new Accessory { Id = 2, Name = "RAM DDR4 16GB", Price = 3000000, Unit = "Thanh"},
                new Accessory { Id = 3, Name = "RAM DDR4 32GB", Price = 5000000, Unit = "Thanh" },
                new Accessory { Id = 4, Name = "Ổ cứng HDD 250GB", Price = 1500000, Unit = "Chiếc" },
                new Accessory { Id = 5, Name = "Ổ cứng HDD 500GB", Price = 3000000, Unit = "Chiếc" },
                new Accessory { Id = 6, Name = "Ổ cứng HDD 1TB", Price = 6000000, Unit = "Chiếc" },
                new Accessory { Id = 7, Name = "Ổ cứng SSD 120GB", Price = 3000000, Unit = "Chiếc" },
                new Accessory { Id = 8, Name = "Ổ cứng SSD 240GB", Price = 6000000, Unit = "Chiếc" },
                new Accessory { Id = 9, Name = "Ổ cứng SSD 500GB", Price = 12000000, Unit = "Chiếc" },
                new Accessory { Id = 10, Name = "Nguồn Corsair CX450M", Price = 1500000, Unit = "Chiếc" },
                new Accessory { Id = 11, Name = "Nguồn Antec VP550", Price = 2000000, Unit = "Chiếc" },
                new Accessory { Id = 12, Name = "Nguồn Seasonic Focus GX-550", Price = 2500000, Unit = "Chiếc" },
                new Accessory { Id = 13, Name = "Nguồn Gigabyte P650B", Price = 3000000, Unit = "Chiếc" },
                new Accessory { Id = 14, Name = "Nguồn EVGA SuperNOVA GA650", Price = 3500000, Unit = "Chiếc" },
                new Accessory { Id = 15, Name = "Màn hình Acer Nitro VG240Y", Price = 4000000, Unit = "Chiếc" },
                new Accessory { Id = 16, Name = "Màn hình ASUS TUF Gaming VG24VQ", Price = 5000000, Unit = "Chiếc" },
                new Accessory { Id = 17, Name = "Màn hình Dell S2722DGM", Price = 6000000, Unit = "Chiếc" },
                new Accessory { Id = 18, Name = "Màn hình Samsung Odyssey G32T550", Price = 7000000, Unit = "Chiếc" },
                new Accessory { Id = 19, Name = "Màn hình LG UltraGear 27GN600-B", Price = 8000000, Unit = "Chiếc" },
                new Accessory { Id = 20, Name = "Logitech C920 HD Pro", Price = 4500000, Unit = "Chiếc" },
                new Accessory { Id = 21, Name = "Logitech Brio 4K", Price = 9000000, Unit = "Chiếc" },
                new Accessory { Id = 22, Name = "Razer Kiyo Pro", Price = 12000000, Unit = "Chiếc" },
            };
        }
    }
}
