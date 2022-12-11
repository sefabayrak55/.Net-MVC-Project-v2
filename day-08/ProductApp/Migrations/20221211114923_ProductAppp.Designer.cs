﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.EFCore;

#nullable disable

namespace ProductApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221211114923_ProductAppp")]
    partial class ProductAppp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Computer"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Electronic"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Smart Phones"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("AtCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("...");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/images/products/default.jpg");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AtCreated = new DateTime(2022, 12, 11, 14, 49, 23, 340, DateTimeKind.Local).AddTicks(7740),
                            CategoryId = 1,
                            Description = "HP Laptop Touch your Dreams",
                            ImageUrl = "/images/products/1.jpg",
                            Price = 15000m,
                            ProductName = "HP Z Book"
                        },
                        new
                        {
                            Id = 2,
                            AtCreated = new DateTime(2022, 12, 11, 14, 49, 23, 340, DateTimeKind.Local).AddTicks(7763),
                            CategoryId = 2,
                            Description = "Airpods for your ears",
                            ImageUrl = "/images/products/2.jpg",
                            Price = 5000m,
                            ProductName = "AirPods"
                        },
                        new
                        {
                            Id = 3,
                            AtCreated = new DateTime(2022, 12, 11, 14, 49, 23, 340, DateTimeKind.Local).AddTicks(7883),
                            CategoryId = 3,
                            Price = 7000m,
                            ProductName = "Samsun Galaxy Note FE"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
