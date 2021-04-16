using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
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

        public ParcelDTO Create(CreateParcelDTO parcel)
        {
            var shipment = this.context.Shipments
                .Include(s => s.Status)
                .FirstOrDefault(s => s.Id == parcel.ShipmentId);
            //if (shipment.Status.Name != "preparing")
            //  throw new ArgumentException("The shipment's status should be on Preparing when creating a parcel.");

            //            var warehouse = this.context.Warehouses
            //              .FirstOrDefault(w => w.Id == parcel.WarehouseId);

            var customer = this.context.Customers
                .FirstOrDefault(c => c.Id == parcel.CustomerId);
            var category = this.context.Category
                .FirstOrDefault(c => c.Name == parcel.CategoryName);
            var employee = this.context.Employees
                .FirstOrDefault(c => c.Id == parcel.EmployeeId);
            var newParcel = new Parcel
            {
                Weight = parcel.Weight,
                Category = category,
                Employee = employee,
                Customer = customer,
                Shipment = shipment
            };
            this.context.Parcels.Add(newParcel);
            this.context.SaveChanges();

            var parcelToDisplay = new ParcelDTO
            {
                Id = newParcel.Id,
                Weight = newParcel.Weight,
                Category = newParcel.Category.Name,
                CustomerName = newParcel.Customer.FirstName + " " + newParcel.Customer.LastName,
            };

            return parcelToDisplay;
        }

        public ParcelDTO Update(Guid id, ParcelDTO shipment)
        {
            throw new NotImplementedException();
        }
    }
}
