using Deliverit.Models;
using System;
using System.Text.Json.Serialization;

namespace Deliverit.Services.Models
{
    public class CreateParcelDTO
    {
        public int Weight { get; set; }
        public string CategoryName { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ShipmentId { get; set; }
    }
}
