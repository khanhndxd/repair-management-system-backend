namespace repair_management_backend.Data
{
    public static class Seeder
    {
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
                new PurchaseOrder { Id = 4, CustomerId = 4, Total = 3500000.0, CreatedAt = DateTime.Now },
                new PurchaseOrder { Id = 5, CustomerId = 5, Total = 1900000.0, CreatedAt = DateTime.Now },
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
                new Models.Task { Id = 1, Name = "Bảo dưỡng định kỳ", Price = 100000.0 },
            };
        }
        public static List<Accessory> GetAccessorySeedingData()
        {
            return new List<Accessory>()
            {
                new Accessory { Id = 1, Name = "RAM DDR4 8GB", Price = 1000000 },
                new Accessory { Id = 2, Name = "RAM DDR4 16GB", Price = 3000000 },
                new Accessory { Id = 3, Name = "RAM DDR4 32GB", Price = 5000000 },
                new Accessory { Id = 4, Name = "Ổ cứng HDD 250GB", Price = 1500000 },
                new Accessory { Id = 5, Name = "Ổ cứng HDD 500GB", Price = 3000000 },
                new Accessory { Id = 6, Name = "Ổ cứng HDD 1TB", Price = 6000000 },
                new Accessory { Id = 7, Name = "Ổ cứng SSD 120GB", Price = 3000000 },
                new Accessory { Id = 8, Name = "Ổ cứng SSD 240GB", Price = 6000000 },
                new Accessory { Id = 9, Name = "Ổ cứng SSD 500GB", Price = 12000000 },
                new Accessory { Id = 10, Name = "Nguồn Corsair CX450M", Price = 1500000 },
                new Accessory { Id = 11, Name = "Nguồn Antec VP550", Price = 2000000 },
                new Accessory { Id = 12, Name = "Nguồn Seasonic Focus GX-550", Price = 2500000 },
                new Accessory { Id = 13, Name = "Nguồn Gigabyte P650B", Price = 3000000 },
                new Accessory { Id = 14, Name = "Nguồn EVGA SuperNOVA GA650", Price = 3500000 },
                new Accessory { Id = 15, Name = "Màn hình Acer Nitro VG240Y", Price = 4000000 },
                new Accessory { Id = 16, Name = "Màn hình ASUS TUF Gaming VG24VQ", Price = 5000000 },
                new Accessory { Id = 17, Name = "Màn hình Dell S2722DGM", Price = 6000000 },
                new Accessory { Id = 18, Name = "Màn hình Samsung Odyssey G32T550", Price = 7000000 },
                new Accessory { Id = 19, Name = "Màn hình LG UltraGear 27GN600-B", Price = 8000000 },
            };
        }
    }
}
