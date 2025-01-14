﻿// <auto-generated />
using System;
using ECom.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECom.Persistence.Migrations
{
    [DbContext(typeof(EComDbContext))]
    [Migration("20240515083823_date more stock change")]
    partial class datemorestockchange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ECom.Persistence.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SearchEngineFriendlyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1852),
                            Name = "Summer T-Shirt",
                            SearchEngineFriendlyName = "summer-t-shirt-male"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1856),
                            Name = "Summer Pant",
                            SearchEngineFriendlyName = "summer-pant-male"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1857),
                            Name = "Summer Shirt",
                            SearchEngineFriendlyName = "summer-shirt-male"
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1858),
                            Name = "Winter T-Shirt",
                            SearchEngineFriendlyName = "winter-t-shirt-male"
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1859),
                            Name = "Winter Shirt",
                            SearchEngineFriendlyName = "winter-shirt-male"
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1860),
                            Name = "Spring Jacket",
                            SearchEngineFriendlyName = "spring-jacket-female"
                        },
                        new
                        {
                            Id = 7,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1863),
                            Name = "Autumn Scarf",
                            SearchEngineFriendlyName = "autumn-scarf-unisex"
                        },
                        new
                        {
                            Id = 8,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1864),
                            Name = "Summer Dress",
                            SearchEngineFriendlyName = "summer-dress-female"
                        },
                        new
                        {
                            Id = 9,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865),
                            Name = "Winter Coat",
                            SearchEngineFriendlyName = "winter-coat-female"
                        },
                        new
                        {
                            Id = 10,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1865),
                            Name = "Spring Skirt",
                            SearchEngineFriendlyName = "spring-skirt-female"
                        },
                        new
                        {
                            Id = 11,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1866),
                            Name = "Autumn Sweater",
                            SearchEngineFriendlyName = "autumn-sweater-male"
                        },
                        new
                        {
                            Id = 12,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1867),
                            Name = "Winter Boots",
                            SearchEngineFriendlyName = "winter-boots-unisex"
                        },
                        new
                        {
                            Id = 13,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1868),
                            Name = "Spring Hat",
                            SearchEngineFriendlyName = "spring-hat-unisex"
                        },
                        new
                        {
                            Id = 14,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1869),
                            Name = "Summer Sandals",
                            SearchEngineFriendlyName = "summer-sandals-female"
                        },
                        new
                        {
                            Id = 15,
                            CreatedOn = new DateTime(2024, 5, 15, 8, 38, 22, 370, DateTimeKind.Utc).AddTicks(1870),
                            Name = "Autumn Jacket",
                            SearchEngineFriendlyName = "autumn-jacket-male"
                        });
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("VariantId")
                        .HasColumnType("integer");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VariantId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Quantity = 10,
                            VariantId = 1,
                            WarehouseId = 1
                        },
                        new
                        {
                            Id = 2,
                            Quantity = 5,
                            VariantId = 2,
                            WarehouseId = 1
                        },
                        new
                        {
                            Id = 3,
                            Quantity = 20,
                            VariantId = 3,
                            WarehouseId = 2
                        },
                        new
                        {
                            Id = 4,
                            Quantity = 15,
                            VariantId = 4,
                            WarehouseId = 2
                        },
                        new
                        {
                            Id = 5,
                            Quantity = 25,
                            VariantId = 5,
                            WarehouseId = 3
                        },
                        new
                        {
                            Id = 6,
                            Quantity = 30,
                            VariantId = 6,
                            WarehouseId = 3
                        },
                        new
                        {
                            Id = 7,
                            Quantity = 12,
                            VariantId = 7,
                            WarehouseId = 1
                        },
                        new
                        {
                            Id = 8,
                            Quantity = 7,
                            VariantId = 8,
                            WarehouseId = 1
                        },
                        new
                        {
                            Id = 9,
                            Quantity = 22,
                            VariantId = 9,
                            WarehouseId = 2
                        },
                        new
                        {
                            Id = 10,
                            Quantity = 18,
                            VariantId = 10,
                            WarehouseId = 2
                        },
                        new
                        {
                            Id = 11,
                            Quantity = 30,
                            VariantId = 11,
                            WarehouseId = 3
                        },
                        new
                        {
                            Id = 12,
                            Quantity = 40,
                            VariantId = 12,
                            WarehouseId = 3
                        },
                        new
                        {
                            Id = 13,
                            Quantity = 50,
                            VariantId = 13,
                            WarehouseId = 1
                        },
                        new
                        {
                            Id = 14,
                            Quantity = 10,
                            VariantId = 14,
                            WarehouseId = 2
                        },
                        new
                        {
                            Id = 15,
                            Quantity = 60,
                            VariantId = 15,
                            WarehouseId = 3
                        },
                        new
                        {
                            Id = 16,
                            Quantity = 0,
                            VariantId = 16,
                            WarehouseId = 1
                        });
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Variants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Red",
                            ProductId = 1,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue",
                            ProductId = 1,
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Green",
                            ProductId = 2,
                            Size = "Large"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Yellow",
                            ProductId = 3,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Black",
                            ProductId = 4,
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 6,
                            Color = "White",
                            ProductId = 5,
                            Size = "Large"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Pink",
                            ProductId = 6,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 8,
                            Color = "Brown",
                            ProductId = 7,
                            Size = "One Size"
                        },
                        new
                        {
                            Id = 9,
                            Color = "Orange",
                            ProductId = 8,
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 10,
                            Color = "Gray",
                            ProductId = 9,
                            Size = "Large"
                        },
                        new
                        {
                            Id = 11,
                            Color = "Purple",
                            ProductId = 10,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 12,
                            Color = "Maroon",
                            ProductId = 11,
                            Size = "Medium"
                        },
                        new
                        {
                            Id = 13,
                            Color = "Black",
                            ProductId = 12,
                            Size = "Large"
                        },
                        new
                        {
                            Id = 14,
                            Color = "White",
                            ProductId = 13,
                            Size = "One Size"
                        },
                        new
                        {
                            Id = 15,
                            Color = "Blue",
                            ProductId = 14,
                            Size = "Small"
                        },
                        new
                        {
                            Id = 16,
                            Color = "Green",
                            ProductId = 15,
                            Size = "Medium"
                        });
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Dhaka",
                            Name = "Dhaka Warehouse"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Chittagong",
                            Name = "Chittagong Warehouse"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Khulna",
                            Name = "Khulna Warehouse"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Rajshahi",
                            Name = "Rajshahi Warehouse"
                        });
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Stock", b =>
                {
                    b.HasOne("ECom.Persistence.Domain.Variant", "Variant")
                        .WithMany("Stocks")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECom.Persistence.Domain.Warehouse", "Warehouse")
                        .WithMany("Stocks")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Variant", b =>
                {
                    b.HasOne("ECom.Persistence.Domain.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Variant", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("ECom.Persistence.Domain.Warehouse", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
