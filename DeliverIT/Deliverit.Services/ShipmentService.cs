using Deliverit.Services.Contracts;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverit.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly DeliveritDbContext context;

        public ShipmentService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public Shipment Get(Guid id)
        {
            var shipment = this.context.Shipments
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            return shipment;
        }

        public IEnumerable<Shipment> GetAll()
        {
            var shipments = this.context.Shipments;

            return shipments;
        }

        public Shipment Update(Guid id, Shipment shipment)
        {
            var shipmentToUpdate = this.context.Shipments
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (shipmentToUpdate.Status != shipment.Status)
            {
                shipmentToUpdate.Status = shipment.Status;
                shipmentToUpdate.ModifiedOn = DateTime.UtcNow;
                this.context.SaveChanges();
            }

            return shipment;
        }

        public Shipment Create(Shipment shipment)
        {
            this.context.Shipments.Add(shipment);
            this.context.SaveChanges();
            return shipment;
        }

        public bool Delete(Guid id)
        {
            var shipment = this.context.Shipments
              .FirstOrDefault(s => s.Id == id);

            if (shipment == null)
            {
                return false;
            }
            else
            {
                shipment.IsDeleted = true;
                shipment.DeletedOn = DateTime.UtcNow;
                this.context.SaveChanges();
                return true;
            }
        }

        public List<ICollection<Shipment>> ShipmentSearch(Warehouse warehouse)
        {
            var shipments = this.context.Warehouses.Where(s => s.Id == warehouse.Id).Select(s => s.Shipments).ToList();
            return shipments;
        }
    }
}
