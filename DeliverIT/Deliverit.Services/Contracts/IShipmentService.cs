using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Contracts
{
    public interface IShipmentService
    {
        ShipmentDTO Get(Guid id);
        IEnumerable<ShipmentDTO> GetAll();
        Shipment Create(Shipment shipment);
        ShipmentDTO Update(Guid id, ShipmentDTO shipment);
        List<Shipment> ShipmentSearch(Guid Id);
        bool Delete(Guid id);
    }
}
