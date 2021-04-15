using Deliverit.Models;
using System;
using System.Text.Json.Serialization;

namespace Deliverit.Services.Models
{
    public class CreateShipmentDTO
    {
        public Guid WarehouseId { get; set; }
    }
}
