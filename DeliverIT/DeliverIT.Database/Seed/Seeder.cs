using Deliverit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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
                    CreatedOn = DateTime.Now,
                    Id = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"),
                    Name = "Barcelona",
                    CountryId = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754")
                },

                new City()
                {
                    CreatedOn = DateTime.Now,
                    Id = Guid.Parse("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                    Name = "Berlin",
                    CountryId = Guid.Parse("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08")
                },

                new City()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                   Name = "Paris",
                   CountryId = Guid.Parse("72ec653b-aeb1-42fc-bcd1-153f005b1cd4")
                },

                new City()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                   Name = "Vilnius",
                   CountryId = Guid.Parse("c4b3bb07-585f-412b-9f5f-f423928015d4")
                }
            };
            modelBuilder.Entity<City>().HasData(cities);

            var countries = new List<Country>()
            {
                new Country()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754"),
                   Name = "Spain"
                },

                new Country()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                   Name = "Germany"
                },

                new Country()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                   Name = "France"
                },

                new Country ()
                {
                   CreatedOn = DateTime.Now,
                   Id = Guid.Parse("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                   Name = "Lithuania"
                }
            };
            modelBuilder.Entity<Country>().HasData(countries);

            // countries.First will give the country Id
        }
    }
}
