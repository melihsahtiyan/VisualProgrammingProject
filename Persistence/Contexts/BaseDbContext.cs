using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseProducts> WarehouseProducts { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WarehouseProducts>(e =>
            {
                e.ToTable("WarehouseProducts");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.WarehouseId).HasColumnName("WarehouseId");
                e.Property(x => x.ProductId).HasColumnName("ProductId");
                e.Property(x => x.Quantity).HasColumnName("Quantity");
                e.HasOne(x => x.Warehouse).WithMany(x => x.WarehouseProducts).HasForeignKey(x => x.WarehouseId);
                e.HasOne(x => x.Product).WithMany(x => x.WarehouseProducts).HasForeignKey(x => x.ProductId);
            });

            modelBuilder.Entity<Orders>(e =>
            {
                e.ToTable("Orders");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.CustomerFactoryId).HasColumnName("CustomerFactoryId");    
                e.Property(x => x.ManufacturingFactoryId).HasColumnName("ManufacturingFactoryId");
                e.Property(x => x.ProductId).HasColumnName("ProductId");
                e.Property(x => x.Quantity).HasColumnName("Quantity");
                e.Property(x => x.DateOfOrder).HasColumnName("DateOfOrder");
                e.Property(x => x.EstimatedDeliveryDate).HasColumnName("EstimatedDeliveryDate");
                e.Property(x => x.DeliveryDate).HasColumnName("DeliveryDate");
                e.Property(x => x.EstimatedDepartureDate).HasColumnName("EstimatedDepartureDate");
                e.Property(x => x.DepartureDate).HasColumnName("DepartureDate");
                e.Property(x => x.ApprovedByCustomer).HasColumnName("ApprovedByCustomer");
                e.Property(x => x.ApprovedByManufacturer).HasColumnName("ApprovedByManufacturer");
                e.Property(x => x.IsCanceled).HasColumnName("IsCanceled");
                e.Property(x => x.ManufacturerWarehouseId).HasColumnName("ManufacturerWarehouseId");
                e.Property(x => x.CustomerWarehouseId).HasColumnName("CustomerWarehouseId");
                e.HasOne(x => x.CustomerFactory).WithMany(x => x.Orders)
                    .HasForeignKey(x => x.CustomerFactoryId);
                e.HasOne(x => x.CustomerWarehouse).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerWarehouseId);
                e.HasOne(x => x.Product).WithMany(x => x.CustomerRequests).HasForeignKey(x => x.ProductId);
            });

            modelBuilder.Entity<Factory>(e =>
            {
                e.ToTable("Factories");
                e.HasBaseType<User>();
                e.Property(x => x.Phone).HasColumnName("Phone");
                e.Property(x => x.TaxNumber).HasColumnName("TaxNumber");
                e.Property(x => x.Country).HasColumnName("Country");
                e.Property(x => x.IsCustomer).HasColumnName("IsCustomer");
                e.Property(x => x.IsSupplier).HasColumnName("IsSupplier");
                e.Property(x => x.TradeGrade).HasColumnName("TradeGrade");
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("Users");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Email).HasColumnName("Email");
                e.Property(x => x.PasswordHash).HasColumnName("PasswordHash");
                e.Property(x => x.PasswordSalt).HasColumnName("PasswordSalt");
                e.Property(x => x.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<Product>(e =>
            {
                e.ToTable("Products");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Price).HasColumnName("Price");
                e.Property(p => p.Weight).HasColumnName("Weight");
                e.Property(p => p.Volume).HasColumnName("Volume");
                e.Property(x => x.Description).HasColumnName("Description");
            });

            modelBuilder.Entity<Warehouse>(e =>
            {
                e.ToTable("Warehouses");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Address).HasColumnName("Address");
                e.Property(w => w.City).HasColumnName("City");
                e.Property(x => x.Phone).HasColumnName("Phone");
                e.Property(x => x.Email).HasColumnName("Email");
                e.Property(x => x.FactoryId).HasColumnName("FactoryId");
                e.HasOne(x => x.Factory).WithMany(x => x.Warehouses).HasForeignKey(x => x.FactoryId);
            });

            base.OnModelCreating(modelBuilder);
        }

    }

}
