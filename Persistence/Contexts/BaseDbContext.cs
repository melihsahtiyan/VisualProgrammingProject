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
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerRequests> CustomerRequests { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseProducts> WarehouseProducts { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
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

            modelBuilder.Entity<CustomerRequests>(e =>
            {
                e.ToTable("CustomerRequests");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.CustomerFactoryId).HasColumnName("CustomerFactoryId");
                e.Property(x => x.ProductId).HasColumnName("ProductId");
                e.Property(x => x.Quantity).HasColumnName("Quantity");
                e.Property(x => x.Date).HasColumnName("Date");
                e.HasOne(x => x.CustomerFactory).WithMany(x => x.CustomerRequests)
                    .HasForeignKey(x => x.CustomerFactoryId);
                e.HasOne(x => x.Product).WithMany(x => x.CustomerRequests).HasForeignKey(x => x.ProductId);
            });

            modelBuilder.Entity<Factory>(e =>
            {
                e.ToTable("Factories");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Address).HasColumnName("Address");
                e.Property(x => x.Phone).HasColumnName("Phone");
                e.Property(x => x.Email).HasColumnName("Email");
                e.Property(x => x.IsCustomer).HasColumnName("IsCustomer");
                e.Property(x => x.IsSupplier).HasColumnName("IsSupplier");
            });

            modelBuilder.Entity<Product>(e =>
            {
                e.ToTable("Products");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Price).HasColumnName("Price");
                e.Property(x => x.Description).HasColumnName("Description");
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("Users");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.FirstName).HasColumnName("FirstName");
                e.Property(x => x.LastName).HasColumnName("LastName");
                e.Property(x => x.Email).HasColumnName("Email");
                e.Property(x => x.PasswordHash).HasColumnName("PasswordHash");
                e.Property(x => x.PasswordSalt).HasColumnName("PasswordSalt");
                e.Property(x => x.Status).HasColumnName("Status");
            });

            modelBuilder.Entity<UserOperationClaim>(e =>
            {
                e.ToTable("UserOperationClaims");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.UserId).HasColumnName("UserId");
                e.Property(x => x.OperationClaimId).HasColumnName("OperationClaimId");
                e.HasOne(x => x.User).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.UserId);
                e.HasOne(x => x.OperationClaim).WithMany(x => x.UserOperationClaims)
                    .HasForeignKey(x => x.OperationClaimId);
            });

            modelBuilder.Entity<OperationClaim>(e =>
            {
                e.ToTable("OperationClaims");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.OperationClaimName).HasColumnName("OperationClaimName");
            });

            modelBuilder.Entity<Warehouse>(e =>
            {
                e.ToTable("Warehouses");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id");
                e.Property(x => x.Name).HasColumnName("Name");
                e.Property(x => x.Address).HasColumnName("Address");
                e.Property(x => x.Phone).HasColumnName("Phone");
                e.Property(x => x.Email).HasColumnName("Email");
                e.Property(x => x.FactoryId).HasColumnName("FactoryId");
                e.HasOne(x => x.Factory).WithMany(x => x.Warehouses).HasForeignKey(x => x.FactoryId);
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
