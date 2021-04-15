using Deliverit.Database.Seed;
using Deliverit.Models;
using Deliverit.Models.Abstract;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
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
            base.OnConfiguring(optionsBuilder);
            //if (!optionsBuilder.IsConfigured)
            //{
            //    base.OnConfiguring(optionsBuilder);
            //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=DeliveritDatabase; Trusted_Connection=True");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Reflection
        }
    }




    /*
     Just in case something goes wrong and we need to use the Cascade deletion restriction logic here:

           modelBuilder.Entity<Warehouse>()
                        .HasMany(w => w.Parcels)
                        .WithOne(p => p.Warehouse)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Parcel>()
                       .HasOne(p => p.Warehouse)
                       .WithMany(w => w.Parcels)
                       .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Address>()
                        .HasMany(a => a.Customers)
                        .WithOne(c => c.Address)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                        .HasOne(c => c.Address)
                        .WithMany(a => a.Customers)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Parcel>()
                        .HasOne(p => p.Shipment)
                        .WithMany(s => s.Parcels)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Shipment>()
                        .HasMany(s => s.Parcels)
                        .WithOne(p => p.Shipment)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Warehouse>()
                        .HasOne(w => w.Address)
                        .WithOne(a => a.Warehouse)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Address>()
                        .HasOne(a => a.Warehouse)
                        .WithOne(w => w.Address)
                        .OnDelete(DeleteBehavior.Restrict);
     */
}
