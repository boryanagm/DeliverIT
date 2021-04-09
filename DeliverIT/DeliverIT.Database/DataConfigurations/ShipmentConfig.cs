﻿using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class ShipmentConfig : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.HasMany(s => s.Parcels)
                   .WithOne(p => p.Shipment)
                   .OnDelete(DeleteBehavior.Restrict);
        }




        /*
         Exercise with Fluent Api:

             builder.HasKey(s => s.Id);

             builder.Property(s => s.DepartureDate)
             builder.Property(s => s.ArrivalDate)
             builder.Property(s => s.Status)

             builder.HasOne(s => s.Warehouse)
                   .WithMany(w => w.Shipments)
                   .HasForeignKey(s => s.WarehouseId);
         */
    }
}
