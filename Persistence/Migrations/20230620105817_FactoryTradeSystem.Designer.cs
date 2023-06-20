﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20230620105817_FactoryTradeSystem")]
    partial class FactoryTradeSystem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ApprovedByCustomer")
                        .HasColumnType("boolean")
                        .HasColumnName("ApprovedByCustomer");

                    b.Property<bool>("ApprovedByManufacturer")
                        .HasColumnType("boolean")
                        .HasColumnName("ApprovedByManufacturer");

                    b.Property<int>("CustomerFactoryId")
                        .HasColumnType("integer")
                        .HasColumnName("CustomerFactoryId");

                    b.Property<int>("CustomerWarehouseId")
                        .HasColumnType("integer")
                        .HasColumnName("CustomerWarehouseId");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DateOfOrder");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeliveryDate");

                    b.Property<DateTime?>("DepartureDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DepartureDate");

                    b.Property<DateTime?>("EstimatedDeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("EstimatedDeliveryDate");

                    b.Property<DateTime?>("EstimatedDepartureDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("EstimatedDepartureDate");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("boolean")
                        .HasColumnName("IsCanceled");

                    b.Property<int>("ManufacturerWarehouseId")
                        .HasColumnType("integer")
                        .HasColumnName("ManufacturerWarehouseId");

                    b.Property<int>("ManufacturingFactoryId")
                        .HasColumnType("integer")
                        .HasColumnName("ManufacturingFactoryId");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("ProductId");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CustomerFactoryId");

                    b.HasIndex("CustomerWarehouseId");

                    b.HasIndex("ManufacturerWarehouseId");

                    b.HasIndex("ManufacturingFactoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("Price");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric")
                        .HasColumnName("Volume");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("City");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<int>("FactoryId")
                        .HasColumnType("integer")
                        .HasColumnName("FactoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("Warehouses", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.WarehouseProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("ProductId");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("Quantity");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer")
                        .HasColumnName("WarehouseId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseProducts", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Factory", b =>
                {
                    b.HasBaseType("Core.Domain.Concrete.User");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.Property<bool>("IsCustomer")
                        .HasColumnType("boolean")
                        .HasColumnName("IsCustomer");

                    b.Property<bool>("IsSupplier")
                        .HasColumnType("boolean")
                        .HasColumnName("IsSupplier");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Phone");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("TaxNumber");

                    b.Property<double>("TradeGrade")
                        .HasColumnType("double precision")
                        .HasColumnName("TradeGrade");

                    b.ToTable("Factories", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Orders", b =>
                {
                    b.HasOne("Domain.Entities.Factory", "CustomerFactory")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerFactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Warehouse", "CustomerWarehouse")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Warehouse", "ManufacturerWarehouse")
                        .WithMany()
                        .HasForeignKey("ManufacturerWarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Factory", "ManufacturingFactory")
                        .WithMany()
                        .HasForeignKey("ManufacturingFactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("CustomerRequests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerFactory");

                    b.Navigation("CustomerWarehouse");

                    b.Navigation("ManufacturerWarehouse");

                    b.Navigation("ManufacturingFactory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.HasOne("Domain.Entities.Factory", "Factory")
                        .WithMany("Warehouses")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("Domain.Entities.WarehouseProducts", b =>
                {
                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("WarehouseProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("WarehouseProducts")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Domain.Entities.Factory", b =>
                {
                    b.HasOne("Core.Domain.Concrete.User", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.Factory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("CustomerRequests");

                    b.Navigation("WarehouseProducts");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("WarehouseProducts");
                });

            modelBuilder.Entity("Domain.Entities.Factory", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Warehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
