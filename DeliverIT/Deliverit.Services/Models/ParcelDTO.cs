using System;

namespace Deliverit.Services.Models
{
    public class ParcelDTO
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
    }
}
