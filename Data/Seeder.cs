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
                }
            };
        }
    }
}
