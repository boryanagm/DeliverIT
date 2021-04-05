using Deliverit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deliverit.Database.DataConfigurations
{
    public class CountryConfig// : IEntityTypeConfiguration<Country>
    {
        //public void Configure(EntityTypeBuilder<Country> builder)
        //{
        //    builder.HasKey(c => c.Id);

        //    builder.Property(c => c.Name)
        //           .HasMaxLength(35)
        //           .IsRequired();

        //    // TODO: Should I describe the relation with Cities?
        //}
    }
}
