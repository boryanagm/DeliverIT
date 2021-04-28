using Deliverit.Services.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface IShipmentService
    {
        ShipmentDTO Get(Guid id);
        IEnumerable<ShipmentDTO> GetAll();
        ShipmentDTO Create(CreateShipmentDTO shipment);
        ShipmentDTO Update(Guid id, ShipmentDTO shipment);
        List<ShipmentDTO> SearchByWarehouse(Guid Id);
        List<ShipmentDTO> SearchByCustomer(Guid Id);
        bool Delete(Guid id);
    }
}
