using Deliverit.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Contracts
{
    public interface IParcelService
    {
        ParcelDTO Get(Guid id);
        IEnumerable<ParcelDTO> GetAll();
        ParcelDTO Create(CreateShipmentDTO shipment);
        ParcelDTO Update(Guid id, ParcelDTO shipment);
    }
}
