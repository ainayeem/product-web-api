using ECom.Persistence.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Persistence.Data
{
    public class EComDbContext : DbContext
    {
        public EComDbContext(DbContextOptions<EComDbContext> dbContextoptions) : base(dbContextoptions)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }


        //--
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "summer t-shirt", SearchEngineFriendlyName = "summer-t-shirt-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 2, Name = "summer pant", SearchEngineFriendlyName = "summer-pant-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 3, Name = "summer shirt", SearchEngineFriendlyName = "summer-shirt-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 4, Name = "winter t-shirt", SearchEngineFriendlyName = "winter-t-shirt-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 5, Name = "winter shirt", SearchEngineFriendlyName = "winter-shirt-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 6, Name = "spring jacket", SearchEngineFriendlyName = "spring-jacket-female", CreatedOn = DateTime.UtcNow },
                new Product { Id = 7, Name = "autumn scarf", SearchEngineFriendlyName = "autumn-scarf-unisex", CreatedOn = DateTime.UtcNow },
                new Product { Id = 8, Name = "summer dress", SearchEngineFriendlyName = "summer-dress-female", CreatedOn = DateTime.UtcNow },
                new Product { Id = 9, Name = "winter coat", SearchEngineFriendlyName = "winter-coat-female", CreatedOn = DateTime.UtcNow },
                new Product { Id = 10, Name = "spring skirt", SearchEngineFriendlyName = "spring-skirt-female", CreatedOn = DateTime.UtcNow },
                new Product { Id = 11, Name = "autumn sweater", SearchEngineFriendlyName = "autumn-sweater-male", CreatedOn = DateTime.UtcNow },
                new Product { Id = 12, Name = "winter boots", SearchEngineFriendlyName = "winter-boots-unisex", CreatedOn = DateTime.UtcNow },
                new Product { Id = 13, Name = "spring hat", SearchEngineFriendlyName = "spring-hat-unisex", CreatedOn = DateTime.UtcNow },
                new Product { Id = 14, Name = "summer sandals", SearchEngineFriendlyName = "summer-sandals-female", CreatedOn = DateTime.UtcNow },
                new Product { Id = 15, Name = "autumn jacket", SearchEngineFriendlyName = "autumn-jacket-male", CreatedOn = DateTime.UtcNow }
            );

            // Seed Variants
            modelBuilder.Entity<Variant>().HasData(
                new Variant { Id = 1, ProductId = 1, Color = "red", Size = "small" },
                new Variant { Id = 2, ProductId = 1, Color = "blue", Size = "medium" },
                new Variant { Id = 3, ProductId = 2, Color = "green", Size = "large" },
                new Variant { Id = 4, ProductId = 3, Color = "yellow", Size = "small" },
                new Variant { Id = 5, ProductId = 4, Color = "black", Size = "medium" },
                new Variant { Id = 6, ProductId = 5, Color = "white", Size = "large" },
                new Variant { Id = 7, ProductId = 6, Color = "pink", Size = "small" },
                new Variant { Id = 8, ProductId = 7, Color = "brown", Size = "one size" },
                new Variant { Id = 9, ProductId = 8, Color = "orange", Size = "medium" },
                new Variant { Id = 10, ProductId = 9, Color = "gray", Size = "large" },
                new Variant { Id = 11, ProductId = 10, Color = "purple", Size = "small" },
                new Variant { Id = 12, ProductId = 11, Color = "maroon", Size = "medium" },
                new Variant { Id = 13, ProductId = 12, Color = "black", Size = "large" },
                new Variant { Id = 14, ProductId = 13, Color = "white", Size = "one size" },
                new Variant { Id = 15, ProductId = 14, Color = "blue", Size = "small" },
                new Variant { Id = 16, ProductId = 15, Color = "green", Size = "medium" }
            );

            // Seed Warehouses
            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { Id = 1, Name = "dhaka warehouse", Location = "dhaka" },
                new Warehouse { Id = 2, Name = "chittagong warehouse", Location = "chittagong" },
                new Warehouse { Id = 3, Name = "khulna warehouse", Location = "khulna" },
                new Warehouse { Id = 4, Name = "rajshahi warehouse", Location = "rajshahi" }
            );

            // Seed Stocks
            modelBuilder.Entity<Stock>().HasData(
                new Stock { Id = 1, VariantId = 1, WarehouseId = 1, Quantity = 10 },
                new Stock { Id = 2, VariantId = 2, WarehouseId = 1, Quantity = 5 },
                new Stock { Id = 3, VariantId = 3, WarehouseId = 2, Quantity = 20 },
                new Stock { Id = 4, VariantId = 4, WarehouseId = 2, Quantity = 15 },
                new Stock { Id = 5, VariantId = 5, WarehouseId = 3, Quantity = 25 },
                new Stock { Id = 6, VariantId = 6, WarehouseId = 3, Quantity = 30 },
                new Stock { Id = 7, VariantId = 7, WarehouseId = 1, Quantity = 12 },
                new Stock { Id = 8, VariantId = 8, WarehouseId = 1, Quantity = 7 },
                new Stock { Id = 9, VariantId = 9, WarehouseId = 2, Quantity = 22 },
                new Stock { Id = 10, VariantId = 10, WarehouseId = 2, Quantity = 18 },
                new Stock { Id = 11, VariantId = 11, WarehouseId = 3, Quantity = 30 },
                new Stock { Id = 12, VariantId = 12, WarehouseId = 3, Quantity = 40 },
                new Stock { Id = 13, VariantId = 13, WarehouseId = 1, Quantity = 50 },
                new Stock { Id = 14, VariantId = 14, WarehouseId = 2, Quantity = 10 },
                new Stock { Id = 15, VariantId = 15, WarehouseId = 3, Quantity = 60 },
                new Stock { Id = 16, VariantId = 16, WarehouseId = 1, Quantity = 0 }
            );
        }



    }
    
}
