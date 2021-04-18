﻿using Deliverit.Services.Contracts;
using Deliverit.Services.Mappers;
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
                .Select(WarehouseMapper.DTOSelector)
                .FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentNullException();

            return dto;
        }

        public IEnumerable<WarehouseDTO> GetAll()
        {
            List<WarehouseDTO> warehouses = new List<WarehouseDTO>();

            foreach (var warehouse in this.context.Warehouses
                .Include(w => w.Address)
                   .ThenInclude(a => a.City)
                      .ThenInclude(c => c.Country))
            {
                var dto = WarehouseMapper.DTOSelector.Compile().Invoke(warehouse);
                warehouses.Add(dto);
            }
            return warehouses;
        }

        public WarehouseDTO Create(Warehouse warehouse)
        {
            this.context.Warehouses.Add(warehouse);
            warehouse.CreatedOn = DateTime.UtcNow;

            this.context.SaveChanges();

            var dto = this.context.Warehouses
                 .Select(WarehouseMapper.DTOSelector)
                 .FirstOrDefault(w => w.Id == warehouse.Id)
                 ?? throw new ArgumentNullException();

            return dto;
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

            var dto = WarehouseMapper.DTOSelector.Compile().Invoke(warehouseToUpdate);

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
