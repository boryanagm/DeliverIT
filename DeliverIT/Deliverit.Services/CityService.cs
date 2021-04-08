using Deliverit.Models;
using Deliverit.Services.Contracts;
using DeliverIT.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverit.Services
{
    public class CityService : ICityService
    {
        private readonly DeliveritDbContext context;

        public CityService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public City Get(Guid id)
        {
            var city = this.context.Cities
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            return city;
        }

        public IEnumerable<City> GetAll()
        {
            var cities = this.context.Cities;

            return cities;
        }
    }
}
