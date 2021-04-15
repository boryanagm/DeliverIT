using System;

namespace Deliverit.Services.Models
{
    public class ShipmentDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfCities { get; set; }
    }
}
