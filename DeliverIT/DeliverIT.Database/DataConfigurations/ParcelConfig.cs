using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class ParcelConfig// : IEntityTypeConfiguration<Parcel>
    {
        //public void Configure(EntityTypeBuilder<Parcel> builder)
        //{
        //    builder.HasKey(p => p.Id);

        //    //builder.Property(p => p.Weight)
        //    //       .IsRequired();


        //    // Customer
        //    builder.HasOne(p => p.Customer)
        //           .WithMany(c => c.Parcels)
        //           .HasForeignKey(p => p.CustomerId);

        //    // Employee
        //    builder.HasOne(p => p.Employee)
        //           .WithMany(e => e.Parcels)
        //           .HasForeignKey(p => p.EmployeeId);

        //    // Warehouse
        //    builder.HasOne(p => p.Warehouse)
        //           .WithMany(w => w.Parcels)
        //           .HasForeignKey(p => p.WarehouseId);

        //    // Shipment
        //    builder.HasOne(p => p.Shipment)
        //           .WithMany(s => s.Parcels)
        //           .HasForeignKey(p => p.ShipmentId);
        //}
    }
}
