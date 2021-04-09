using DeliverIT.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface IWarehouseService
    {
        Warehouse Get(Guid id);
        IEnumerable<Warehouse> GetAll();
        Warehouse Create(Warehouse warehouse);
        Warehouse Update(Guid id, Warehouse warehouse);
        bool Delete(Guid id);
    }
}
