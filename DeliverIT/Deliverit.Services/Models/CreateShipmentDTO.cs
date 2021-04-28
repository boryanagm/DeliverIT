﻿using System;

namespace Deliverit.Services.Models
{
    /// <summary>
    /// Class CityDTO.
    /// A data transfer object mapping out a Shipment to create.
    /// </summary>
    public class CreateShipmentDTO
    {
        public Guid WarehouseId { get; set; }
    }
}
