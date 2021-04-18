using Deliverit.Database.Seed;
using Deliverit.Models;
using Deliverit.Models.Abstract;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DeliverIT.Database
{
    /// <summary>
    /// Class DeliveritDBContext.
    /// Sets up and creates the base with a code first approach.
    /// </summary>
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
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
