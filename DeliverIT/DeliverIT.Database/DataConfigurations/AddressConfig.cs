using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasMany(a => a.Customers)
                   .WithOne(c => c.Address)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Warehouse)
                   .WithOne(w => w.Address)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }



    /*
     Exercise with Fluent Api:

            builder.HasKey(a => a.Id);

            builder.Property(a => a.StreetName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne(a => a.City)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(c => c.Id);

            builder.HasOne(a => a.Warehouse)
                   .WithOne(w => w.Address)
                   .HasForeignKey<Warehouse>(a => a.AddressId); 
     */
}
