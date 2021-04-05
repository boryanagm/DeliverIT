using Deliverit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Database.DataConfigurations
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .HasMaxLength(35)
                   .IsRequired();

            builder.HasOne(city => city.Country)
                   .WithMany(country => country.Cities)
                   .HasForeignKey(country => country.Id);
        }
    }
}
