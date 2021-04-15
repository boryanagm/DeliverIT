using System;

namespace Deliverit.Services.Models
{
    public class WarehouseDTO
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
