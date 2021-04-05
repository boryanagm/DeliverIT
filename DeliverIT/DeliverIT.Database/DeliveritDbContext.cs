using Deliverit.Models;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace DeliverIT.Database
{
    public class DeliveritDbContext : DbContext
    {
        public DeliveritDbContext()
        {
        }

        public DeliveritDbContext(DbContextOptions<DeliveritDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=DeliveritDatabase; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We can set relations here
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Warehouse>()
                        .HasMany(w => w.Parcels)
                        .WithOne(p => p.Warehouse)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Parcel>()
                       .HasOne(p => p.Warehouse)
                       .WithMany(w => w.Parcels)
                       .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
