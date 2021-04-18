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

        /// <summary>Gets the specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>City.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public City Get(Guid id)
        {
            var city = this.context.Cities
                .Where(c => c.IsDeleted == false)
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            return city;
        }

        /// <summary>Gets all.</summary>
        /// <returns>IEnumerable&lt;City&gt;.</returns>
        public IEnumerable<City> GetAll()
        {
            var cities = this.context.Cities; //.Where(c => c.IsDeleted == false)
            return cities;
        }
    }
}
