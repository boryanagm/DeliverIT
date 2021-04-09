using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class ParcelConfig : IEntityTypeConfiguration<Parcel>
    {
        public void Configure(EntityTypeBuilder<Parcel> builder)
        {
            builder.HasOne(p => p.Warehouse)
                   .WithMany(w => w.Parcels)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Shipment)
                   .WithMany(s => s.Parcels)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }


    /*
     Exercise with Fluent Api:

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Weight)
                   .IsRequired();

            builder.HasOne(p => p.Customer)
                   .WithMany(c => c.Parcels)
                   .HasForeignKey(p => p.CustomerId);

            builder.HasOne(p => p.Employee)
                   .WithMany(e => e.Parcels)
                   .HasForeignKey(p => p.EmployeeId);

            builder.HasOne(p => p.Warehouse)
                   .WithMany(w => w.Parcels)
                   .HasForeignKey(p => p.WarehouseId);

            builder.HasOne(p => p.Shipment)
                   .WithMany(s => s.Parcels)
                   .HasForeignKey(p => p.ShipmentId);
     */
}
