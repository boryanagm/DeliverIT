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
            warehouse.CreatedOn = DateTime.UtcNow;

            this.context.Warehouses.Add(warehouse);
            this.context.SaveChanges();

            return warehouse;
        }

        public Warehouse Update(Guid id, Warehouse warehouse)
        {
            var warehouseToUpdate = this.context.Warehouses
                .FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentNullException();

            warehouseToUpdate.Address = warehouse.Address; // Or AddresId?
            warehouseToUpdate.ModifiedOn = DateTime.UtcNow;

            this.context.SaveChanges();

            return warehouse;
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
