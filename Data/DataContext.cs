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
        public DbSet<User> Users { get; set; }
    }
}
