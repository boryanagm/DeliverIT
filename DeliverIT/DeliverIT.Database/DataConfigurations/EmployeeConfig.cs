using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Deliverit.Database.DataConfigurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                   .HasMaxLength(35)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .HasMaxLength(35)
                   .IsRequired();

            builder.HasOne(e => e.Address)
                   .WithMany(a => a.Employees)
                   .HasForeignKey(e => e.AddressId);

            // TODO: Should I describe the relation with Parcels?
        }
    }
}
