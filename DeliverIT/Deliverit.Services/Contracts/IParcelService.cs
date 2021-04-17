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
        ParcelDTO Create(CreateParcelDTO parcel);
        ParcelDTO Update(Guid id, UpdateParcelDTO parcel);
        List<ParcelDTO> SearchByEmail(string email);
        List<ParcelDTO> SearchByName(string firstname, string lastname);
        List<ParcelDTO> FindIncomingParcels(Guid Id);
        List<ParcelDTO> GetByWarehouse(Guid Id);
        List<ParcelDTO> GetByCustomer(Guid id);
    }
}
