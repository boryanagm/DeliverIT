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
                CustomerFirstName = parcel.Customer.FirstName,
                CustomerLastName = parcel.Customer.LastName
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
                    CustomerFirstName = parcel.Customer.FirstName,
                    CustomerLastName = parcel.Customer.LastName
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
                Shipment = shipment,
                CreatedOn = DateTime.UtcNow
            };
            this.context.Parcels.Add(newParcel);
            this.context.SaveChanges();

            var parcelToDisplay = new ParcelDTO
            {
                Id = newParcel.Id,
                Weight = newParcel.Weight,
                Category = newParcel.Category.Name,
                CustomerFirstName = newParcel.Customer.FirstName,
                CustomerLastName = newParcel.Customer.LastName
            };

            return parcelToDisplay;
        }

        public ParcelDTO Update(Guid id, UpdateParcelDTO parcel)
        {
            var parcelToUpdate = this.context.Parcels
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (parcel.CustomerId != null)
            {
                var customer = this.context.Customers
                .FirstOrDefault(s => s.Id == parcel.CustomerId)
                ?? throw new ArgumentNullException();
                parcelToUpdate.Customer = customer;
            }

            if (parcel.CategoryId != null)
            {
                var category = this.context.Category
                .FirstOrDefault(s => s.Id == parcel.CategoryId)
                ?? throw new ArgumentNullException();
                parcelToUpdate.Category = category;
            }

            if (parcel.ShipmentId != null)
            {
                var shipment = this.context.Shipments
                .FirstOrDefault(s => s.Id == parcel.ShipmentId)
                ?? throw new ArgumentNullException();
                parcelToUpdate.Shipment = shipment;
            }

            if (parcel.Weight > 0)
                parcelToUpdate.Weight = parcel.Weight;

            var parcelToDisplay = new ParcelDTO
            {
                Id = parcelToUpdate.Id,
                Weight = parcelToUpdate.Weight,
                Category = parcelToUpdate.Category.Name,
                CustomerFirstName = parcelToUpdate.Customer.FirstName,
                CustomerLastName = parcelToUpdate.Customer.LastName
            };

            return parcelToDisplay;
        }
        public bool Delete(Guid id)
        {
            var parcel = this.context.Parcels
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (parcel.IsDeleted == true)
            {
                throw new ArgumentNullException("There is no shipment with this ID.");
            }

            parcel.IsDeleted = true;
            parcel.DeletedOn = DateTime.UtcNow;
            this.context.SaveChanges();
            return true;
        }

        public List<ParcelDTO> SearchByEmail(string email)
        {
            var customers = this.context.Customers
                .Include(c => c.Parcels)
                .ThenInclude(c => c.Category)
                .Where(s => s.Email.Contains(email))
                .ToList();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var customer in customers)
            {
                foreach (var parcel in customer.Parcels)
                {
                    var parcelToDisplay = new ParcelDTO
                    {
                        Id = parcel.Id,
                        Weight = parcel.Weight,
                        Category = parcel.Category.Name,
                        CustomerFirstName = parcel.Customer.FirstName,
                        CustomerLastName = parcel.Customer.LastName
                    };
                    parcelsToDisplay.Add(parcelToDisplay);
                }
            }
            return parcelsToDisplay;
        }

        public List<ParcelDTO> SearchByName(string firstname, string lastname)
        {
            List<Customer> customers = new List<Customer>();

            if (firstname != null && lastname == null)
            {
                customers = this.context.Customers
                   .Include(c => c.Parcels)
                   .ThenInclude(c => c.Category)
                   .Where(s => s.FirstName == firstname)
                   .ToList();
            }

            else if (firstname == null && lastname != null)
            {
                customers = this.context.Customers
                   .Include(c => c.Parcels)
                   .ThenInclude(c => c.Category)
                   .Where(s => s.LastName == lastname)
                   .ToList();
            }

            else
            {
                customers = this.context.Customers
                  .Include(c => c.Parcels)
                  .ThenInclude(c => c.Category)
                  .Where(s => s.LastName == lastname && s.FirstName == firstname)
                  .ToList();
            }

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var customer in customers)
            {
                foreach (var parcel in customer.Parcels)
                {
                    var parcelToDisplay = new ParcelDTO
                    {
                        Id = parcel.Id,
                        Weight = parcel.Weight,
                        Category = parcel.Category.Name,
                        CustomerFirstName = parcel.Customer.FirstName,
                        CustomerLastName = parcel.Customer.LastName
                    };
                    parcelsToDisplay.Add(parcelToDisplay);
                }
            }
            return parcelsToDisplay;
        }

        public List<ParcelDTO> FindIncomingParcels(Guid Id)
        {
            var customer = this.context.Customers
               .Include(c => c.Parcels)
               .ThenInclude(c => c.Shipment)
               .ThenInclude(c => c.Status)
               .Include(c => c.Parcels)
               .ThenInclude(c => c.Category)
               .FirstOrDefault(s => s.Id == Id)
               ?? throw new ArgumentNullException();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var parcel in customer.Parcels)
            {
                if (parcel.Shipment.Status.Name == "on the way")
                {
                    var parcelToDisplay = new ParcelDTO
                    {
                        Id = parcel.Id,
                        Weight = parcel.Weight,
                        Category = parcel.Category.Name,
                        CustomerFirstName = parcel.Customer.FirstName,
                        CustomerLastName = parcel.Customer.LastName
                    };
                    parcelsToDisplay.Add(parcelToDisplay);
                }
            }

            return parcelsToDisplay;
        }

        public List<ParcelDTO> GetByWarehouse(Guid id)
        {
            var parcels = this.context.Parcels
                .Include(p => p.Shipment)
                .ThenInclude(p => p.Warehouse)
                .Include(p=>p.Category)
                .Include(p=>p.Customer)
                .Where(p => p.Shipment.Warehouse.Id == id)
                .ToList();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var parcel in parcels)
            {
                if (parcel.IsDeleted == true)
                    continue;

                var parcelToDisplay = new ParcelDTO
                {
                    Id = parcel.Id,
                    Weight = parcel.Weight,
                    Category = parcel.Category.Name,
                    CustomerFirstName = parcel.Customer.FirstName,
                    CustomerLastName = parcel.Customer.LastName
                };
                parcelsToDisplay.Add(parcelToDisplay);
            }

            return parcelsToDisplay;
        }

        public List<ParcelDTO> GetByCustomer(Guid id)
        {
            var parcels = this.context.Parcels             
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .Where(p => p.Customer.Id == id)
                .ToList();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var parcel in parcels)
            {
                if (parcel.IsDeleted == true)
                    continue;

                var parcelToDisplay = new ParcelDTO
                {
                    Id = parcel.Id,
                    Weight = parcel.Weight,
                    Category = parcel.Category.Name,
                    CustomerFirstName = parcel.Customer.FirstName,
                    CustomerLastName = parcel.Customer.LastName
                };
                parcelsToDisplay.Add(parcelToDisplay);
            }

            return parcelsToDisplay;
        }

        public List<ParcelDTO> GetByWeight(int weight)
        {
            var parcels = this.context.Parcels
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .Where(p => p.Weight == weight)
                .ToList();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var parcel in parcels)
            {
                if (parcel.IsDeleted == true)
                    continue;

                var parcelToDisplay = new ParcelDTO
                {
                    Id = parcel.Id,
                    Weight = parcel.Weight,
                    Category = parcel.Category.Name,
                    CustomerFirstName = parcel.Customer.FirstName,
                    CustomerLastName = parcel.Customer.LastName
                };
                parcelsToDisplay.Add(parcelToDisplay);
            }

            return parcelsToDisplay;
        }

        public List<ParcelDTO> GetByCategory(string category)
        {
            var parcels = this.context.Parcels
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .Where(p => p.Category.Name == category)
                .ToList();

            List<ParcelDTO> parcelsToDisplay = new List<ParcelDTO>();
            foreach (var parcel in parcels)
            {
                if (parcel.IsDeleted == true)
                    continue;

                var parcelToDisplay = new ParcelDTO
                {
                    Id = parcel.Id,
                    Weight = parcel.Weight,
                    Category = parcel.Category.Name,
                    CustomerFirstName = parcel.Customer.FirstName,
                    CustomerLastName = parcel.Customer.LastName
                };
                parcelsToDisplay.Add(parcelToDisplay);
            }

            return parcelsToDisplay;
        }
    }
}
