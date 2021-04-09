using Deliverit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Database.Seed
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var cities = new List<City>()
            {
                new City()
                {
                    Id = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"),
                    Name = "Barcelona",
                    CountryId = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754")
                }
            };
            modelBuilder.Entity<City>().HasData(cities);

            var countries = new List<Country>()
            {
                new Country()
                {
                   Id = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754"),
                   Name = "Spain"
                }
            };
            modelBuilder.Entity<Country>().HasData(countries);

            // countries.First will give the country Id
        }
    }
}
