using Deliverit.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Deliverit.Tests
{
    public class Utils
    {
        public static DbContextOptions<DeliveritDbContext> GetOptions(string databaseName)
        {
            return new DbContextOptionsBuilder<DeliveritDbContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;
        }

        public static DeliveritDbContext GetFakeDatabase(string databaseName)
        {
            var context = new DeliveritDbContext(GetOptions(databaseName));
            context.Addresses.AddRange(GetAddresses());
            context.Cities.AddRange(GetCities());




            // all the rest

            context.SaveChanges();

            return context;
        }

        public static ICollection<Address> GetAddresses()
        {
            return new List<Address>()
            {
                new Address()
                {
                   Id = Guid.Parse("36049406-10ba-499d-916b-063422046239"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Ramon Berenguer El Vell 1",
                   CityId = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e")
                },

                new Address()
                {
                   Id = Guid.Parse("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Zeughofstraße 20",
                   CityId = Guid.Parse("e422b2de-f54d-4a4e-9259-0f3f4033f93d")
                },

                new Address()
                {
                   Id = Guid.Parse("b1347388-583d-4324-870a-e487e61ef483"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Rue La Boetie 7",
                   CityId = Guid.Parse("7fdbb1a0-9f76-4b63-aab4-901c61591336")
                },

                new Address()
                {
                   Id = Guid.Parse("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Liepkalnio 117",
                   CityId = Guid.Parse("8bf95d78-e5ac-495d-ab67-14b60f644b70")
                },

                new Address()
                {
                   Id = Guid.Parse("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Gran Via De Les Corts Catalanes 105",
                   CityId = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e")
                },

                new Address()
                {
                   Id = Guid.Parse("da703902-00bc-47da-b950-4fa730494d4e"),
                   CreatedOn = DateTime.UtcNow,
                   StreetName = "Passatge De Bocabella 11",
                   CityId = Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e")
                }
            };
        }

        public static ICollection<City> GetCities()
        {
            return new List<City>()
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
        }
    }
}
