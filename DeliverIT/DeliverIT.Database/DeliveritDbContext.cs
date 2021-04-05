using Deliverit.Models;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=DeliveritDatabase; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We can set relations here
            base.OnModelCreating(modelBuilder);
        }
    }
}
