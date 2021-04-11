using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasMany(w => w.Parcels)
                   .WithOne(p => p.Warehouse)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(w => w.Address)
                   .WithOne(a => a.Warehouse)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }



    /*
     Exercise with Fluent Api:

            builder.HasKey(w => w.Id);

            builder.Property(w => w.Category)

            builder.HasOne(w => w.Address)
                   .WithOne(a => a.Warehouse)
                   .HasForeignKey<Address>(w => w.Warehouse);
     */
}
