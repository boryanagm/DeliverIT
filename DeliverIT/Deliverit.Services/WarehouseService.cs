using Deliverit.Services.Contracts;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverit.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DeliveritDbContext context;

        public WarehouseService(DeliveritDbContext context)
        {
            this.context = context;
        }


        public Warehouse Get(Guid id)
        {
            var warehouse = this.context.Warehouses
                .FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentNullException();

            return warehouse;
        }

        public IEnumerable<Warehouse> GetAll()
        {
            var warehouses = this.context.Warehouses;
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
