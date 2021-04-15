using Deliverit.Models;
using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverit.Services
{
    public class CountryService : ICountryService
    {
        private readonly DeliveritDbContext context;

        public CountryService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public CountryDTO Get(Guid id)
        {
            var country = this.context.Countries
                .Include(c=> c.Cities)
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            var dto = new CountryDTO
            {
                Id = country.Id,
                Name = country.Name,
                NumberOfCities = country.Cities.Count(),
            };

            return dto;
        }

        public IEnumerable<CountryDTO> GetAll()
        {
            List<CountryDTO> countries = new List<CountryDTO>();
            foreach(var country in this.context.Countries.Include(c=>c.Cities))
            {
                CountryDTO countryToAdd = new CountryDTO
                {
                    Id = country.Id,
                    Name = country.Name,
                    NumberOfCities = country.Cities.Count()                 
                };
                countries.Add(countryToAdd);
            }
            return countries;
        }
    }
}
