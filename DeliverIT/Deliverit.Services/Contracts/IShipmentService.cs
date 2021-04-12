using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Contracts
{
    public interface IShipmentService
    {
        Shipment Get(Guid id);
        IEnumerable<Shipment> GetAll();
        Shipment Create(Shipment shipment);
        Shipment Update(Guid id, Shipment shipment);
        bool Delete(Guid id);
    }
}
