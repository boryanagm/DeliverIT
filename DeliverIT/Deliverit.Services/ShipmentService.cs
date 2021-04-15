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
    public class ShipmentService : IShipmentService
    {
        private readonly DeliveritDbContext context;

        public ShipmentService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public ShipmentDTO Get(Guid id)
        {
            var shipment = this.context.Shipments
                .Include(c => c.Status)
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            var dto = new ShipmentDTO
            {
                Id = shipment.Id,
                Status = shipment.Status.Name,
                DepartureDate = shipment.DepartureDate,
                ArrivalDate = shipment.ArrivalDate
            };
            return dto;
        }

        public IEnumerable<ShipmentDTO> GetAll()
        {
            List<ShipmentDTO> shipments = new List<ShipmentDTO>();

            foreach (var shipment in this.context.Shipments.Include(c => c.Status))
            {
                if(shipment.IsDeleted==true)               
                    continue;
                
                var shipmentToDisplay = new ShipmentDTO
                {
                    Id = shipment.Id,
                    Status = shipment.Status.Name,
                    DepartureDate = shipment.DepartureDate,
                    ArrivalDate = shipment.ArrivalDate
                };
                shipments.Add(shipmentToDisplay);
            }
            return shipments;
        }

        public ShipmentDTO Update(Guid id, ShipmentDTO shipment)
        {
            shipment.Status.ToLower();
            if(shipment.Status != "preparing" && shipment.Status != "on the way" && shipment.Status != "completed")            
                throw new ArgumentException("The status is incorrect");           

            var shipmentToUpdate = this.context.Shipments
                .Include(c=>c.Status)
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (shipmentToUpdate.Status.Name != shipment.Status)
            {
                shipmentToUpdate.Status.Name = shipment.Status;
                shipmentToUpdate.ModifiedOn = DateTime.UtcNow;
                this.context.SaveChanges();
            }

            var shipmentToDisplay = new ShipmentDTO
            {
                Id = shipmentToUpdate.Id,
                Status = shipmentToUpdate.Status.Name,
                DepartureDate = shipmentToUpdate.DepartureDate,
                ArrivalDate = shipmentToUpdate.ArrivalDate
            };

            return shipmentToDisplay;
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

        public List<Shipment> ShipmentSearch(Guid Id)
        {
            var warehouse = this.context.Warehouses.FirstOrDefault(w => w.Id == Id);

            var shipments = this.context.Warehouses
                .Include(s => s.Shipments)
                .Where(s => s.Id == warehouse.Id)
                .SelectMany(s => s.Shipments).ToList();

            return shipments;
        }
    }
}
