using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(c => c.Address)
                   .WithMany(a => a.Customers)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }



    /*
     Exercise with Fluent Api:

            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
                   .HasMaxLength(35)
                   .IsRequired();

            builder.Property(c => c.LastName)
                   .HasMaxLength(35)
                   .IsRequired();

            builder.HasOne(c => c.Address)
                   .WithMany(a => a.Customers)
                   .HasForeignKey(c => c.AddressId);
     */
}
