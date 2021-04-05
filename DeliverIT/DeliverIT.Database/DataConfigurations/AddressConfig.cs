using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Database.DataConfigurations
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.StreetName)
                   .HasMaxLength(50)
                   .IsRequired();

            // TODO: Not completed
                   
        }
    }
}
