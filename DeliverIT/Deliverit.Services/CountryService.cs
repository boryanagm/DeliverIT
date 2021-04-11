using Deliverit.Models;
using Deliverit.Services.Contracts;
using DeliverIT.Database;
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

        public Country Get(Guid id)
        {
            var country = this.context.Countries
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            return country;
        }

        public IEnumerable<Country> GetAll()
        {
            var countries = this.context.Countries;

            return countries;
        }
    }
}
