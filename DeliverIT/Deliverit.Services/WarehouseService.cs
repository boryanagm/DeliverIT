using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverit.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DeliveritDbContext context;

        public WarehouseService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public WarehouseDTO Get(Guid id)
        {
            var dto = this.context.Warehouses
                .Select(w => new WarehouseDTO
                {
                    Id = w.Id,
                    StreetName = w.Address.StreetName,
                    City = w.Address.City.Name,
                    Country = w.Address.City.Country.Name
                })
                .FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentNullException();

            return dto;
        }

        public IEnumerable<WarehouseDTO> GetAll()
        {
            List<WarehouseDTO> warehouses = new List<WarehouseDTO>();

            foreach (var warehouse in this.context.Warehouses.Include(w => w.Address).ThenInclude(a => a.City).ThenInclude(c => c.Country))
            {
                var dto = new WarehouseDTO
                {
                    Id = warehouse.Id,
                    StreetName = warehouse.Address.StreetName,
                    City = warehouse.Address.City.Name,
                    Country = warehouse.Address.City.Country.Name
                };
                warehouses.Add(dto);
            }
            return warehouses;
        }

        public Warehouse Create(Warehouse warehouse)
        {
            this.context.Warehouses.Add(warehouse);
            warehouse.CreatedOn = DateTime.UtcNow;
            this.context.SaveChanges();

            return warehouse;
        }

        public WarehouseDTO Update(Guid id, Guid addressId)
        {
            var warehouseToUpdate = this.context.Warehouses
                .FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentNullException();
           
            warehouseToUpdate.ModifiedOn = DateTime.UtcNow;
            warehouseToUpdate.AddressId = addressId;
            this.context.SaveChanges();

            warehouseToUpdate.Address = this.context.Addresses
                .Include(a => a.City)
                   .ThenInclude(c => c.Country)
                .FirstOrDefault(a => a.Id == addressId);

            var dto = new WarehouseDTO
            { 
               Id = warehouseToUpdate.Id,
               StreetName = warehouseToUpdate.Address.StreetName,
               City = warehouseToUpdate.Address.City.Name,
               Country = warehouseToUpdate.Address.City.Country.Name
            };
            return dto;
        }

        public bool Delete(Guid id)
        {
            var warehouse = this.context.Warehouses
                .FirstOrDefault(w => w.Id == id);

            if (warehouse != null)
            {
                warehouse.DeletedOn = DateTime.UtcNow;
                warehouse.IsDeleted = true;           
                this.context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
