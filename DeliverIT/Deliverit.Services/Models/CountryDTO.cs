using System;

namespace Deliverit.Services.Models
{
    public class CountryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfCities { get; set; }
    }
}
