using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
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

            CityDTO dto = new CityDTO();

            dto.Id = city.Id;
            dto.Name = city.Name;

            return dto;
        }

        public IEnumerable<City> GetAll()
        {
            var cities = this.context.Cities; //.Where(c => c.IsDeleted == false)
            return cities;
        }
    }
}
