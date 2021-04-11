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
                    Id = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"),
                    CreatedOn = DateTime.UtcNow,
                    Name = "Barcelona",
                    CountryId = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754")
                },

                new City()
                {
                    Id = Guid.Parse("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                    CreatedOn = DateTime.UtcNow,
                    Name = "Berlin",
                    CountryId = Guid.Parse("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08")
                },

                new City()
                {
                   Id = Guid.Parse("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Paris",
                   CountryId = Guid.Parse("72ec653b-aeb1-42fc-bcd1-153f005b1cd4")
                },

                new City()
                {
                   Id = Guid.Parse("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Vilnius",
                   CountryId = Guid.Parse("c4b3bb07-585f-412b-9f5f-f423928015d4")
                }
            };
            modelBuilder.Entity<City>().HasData(cities);

            var countries = new List<Country>()
            {
                new Country()
                {
                   Id = Guid.Parse("2a84fe90-6605-4052-8a49-e7251af05754"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Spain"
                },

                new Country()
                {
                   Id = Guid.Parse("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Germany"
                },

                new Country()
                {
                   Id = Guid.Parse("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "France"
                },

                new Country ()
                {
                   Id = Guid.Parse("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Lithuania"
                }
            };
            modelBuilder.Entity<Country>().HasData(countries);

            var categories = new List<Category>()
            {
                new Category()
                { 
                   Id = Guid.Parse("1db0c76c-ab76-4105-be89-3af983f6f137"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Electronics"
                },

                new Category()
                { 
                   Id = Guid.Parse("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Clothing"
                },

                new Category()
                { 
                   Id = Guid.Parse("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Medical"
                },

                new Category()
                { 
                   Id = Guid.Parse("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                   CreatedOn = DateTime.UtcNow,
                   Name = "Books"
                }
            };
            modelBuilder.Entity<Category>().HasData(categories);
            // countries.First will give the country Id
        }
    }
}
