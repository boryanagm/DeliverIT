using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface IWarehouseService
    {
        WarehouseDTO Get(Guid id);
        IEnumerable<WarehouseDTO> GetAll();
        Warehouse Create(Warehouse warehouse);
        Warehouse Update(Guid id, Warehouse warehouse);
        bool Delete(Guid id);
    }
}
