﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace repair_management_backend.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RepairOrder>()
                .HasOne(ro => ro.CreatedBy)
                .WithMany(u => u.CreatedOrders)
                .HasForeignKey(ro => ro.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RepairOrder>()
                .HasOne(ro => ro.RepairedBy)
                .WithMany(u => u.RepairedOrders)
                .HasForeignKey(ro => ro.RepairedById)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RepairOrder>()
                .HasOne(ro => ro.ReceivedBy)
                .WithMany(u => u.ReceivedOrders)
                .HasForeignKey(ro => ro.ReceivedById)
                .OnDelete(DeleteBehavior.Restrict);

            // seed users và roles
            Seeder.SeedUsersWithRoles(modelBuilder);

            // lấy dữ liệu seeding
            var customers = Seeder.GetCustomerSeedingData();
            var purchaseOrders = Seeder.GetPurchaseOrderSeedingData();
            var statuses = Seeder.GetStatusSeedingData();
            var repairTypes = Seeder.GetRepairTypeSeedingData();
            var repairReasons = Seeder.GetRepairReasonSeedingData();
            var tasks = Seeder.GetTaskSeedingData();
            var accessories = Seeder.GetAccessorySeedingData();
            var categories = Seeder.GetCategoriesSeedingData();
            var manufacturers = Seeder.GetManufacturersSeedingData();
            var purchasedProducts = Seeder.GetPurchasedProductsSeedingData();
            var warrantyPolicies = Seeder.GetWarrantyPolicySeedingData();
            var warrantyPolicyTasks = Seeder.GetWarrantyPolicyTaskSeedingData();

            // đồ dữ liệu seeding vào bảng
            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<PurchaseOrder>().HasData(purchaseOrders);
            modelBuilder.Entity<Status>().HasData(statuses);
            modelBuilder.Entity<RepairType>().HasData(repairTypes);
            modelBuilder.Entity<RepairReason>().HasData(repairReasons);
            modelBuilder.Entity<Models.Task>().HasData(tasks);
            modelBuilder.Entity<Accessory>().HasData(accessories);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Manufacturer>().HasData(manufacturers);
            modelBuilder.Entity<PurchasedProduct>().HasData(purchasedProducts);
            modelBuilder.Entity<WarrantyPolicy>().HasData(warrantyPolicies);
            modelBuilder.Entity<WarrantyPolicyTask>().HasData(warrantyPolicyTasks);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<PurchasedProduct> PurchasedProducts { get; set; }
        public DbSet<RepairProduct> RepairProducts { get; set; }
        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<RepairAccessory> RepairAccessories { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<RepairType> RepairTypes { get; set; }
        public DbSet<RepairReason> RepairReasons { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<RepairTask> RepairTasks { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<RepairCustomerProduct> RepairCustomerProducts { get; set; }
        public DbSet<RepairLog> RepairLogs { get; set; }
        public DbSet<WarrantyPolicy> WarrantyPolicies { get; set; }
        public DbSet<WarrantyPolicyTask> WarrantyPolicyTasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
