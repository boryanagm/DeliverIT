using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverit.Services
{
    public class ParcelService : IParcelService
    {
        private readonly DeliveritDbContext context;

        public ParcelService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public ParcelDTO Get(Guid id)
        {
            var parcel = this.context.Parcels
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .FirstOrDefault(p => p.Id == id)
                ?? throw new ArgumentNullException();

            if (parcel.IsDeleted == true)
                throw new ArgumentException("A parcel with this ID doesn't exist.");

            var dto = new ParcelDTO
            {
                Id = parcel.Id,
                Weight = parcel.Weight,
                Category = parcel.Category.Name,
                CustomerName = parcel.Customer.FirstName + " " + parcel.Customer.LastName,
            };

            return dto;
        }

        public IEnumerable<ParcelDTO> GetAll()
        {
            List<ParcelDTO> parcels = new List<ParcelDTO>();

            foreach (var parcel in this.context.Parcels.Include(p => p.Category).Include(p => p.Customer))
            {
                if (parcel.IsDeleted == true)
                    continue;

                var parcelToDisplay = new ParcelDTO
                {
                    Id = parcel.Id,
                    Weight = parcel.Weight,
                    Category = parcel.Category.Name,
                    CustomerName = parcel.Customer.FirstName + " " + parcel.Customer.LastName,
                };
                parcels.Add(parcelToDisplay);
            }
            return parcels;
        }

        public ParcelDTO Create(CreateShipmentDTO shipment)
        {
            throw new NotImplementedException();
        }

        public ParcelDTO Update(Guid id, ParcelDTO shipment)
        {
            throw new NotImplementedException();
        }
    }
}
