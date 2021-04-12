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
                .FirstOrDefault(w => w.Id == id)
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
            throw new NotImplementedException();
        }

        public Shipment Create(Shipment shipment)
        {
            this.context.Shipments.Add(shipment);
            return shipment;
        }

        public bool Delete(Guid id)
        {
            var shipment = this.context.Shipments
              .FirstOrDefault(w => w.Id == id);

            if (shipment == null)
            {
                return false;
            }
            else
            {
                this.context.Shipments.Remove(shipment);
                return true;
            }
        }
        
    }
}
