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

            if (shipment.IsDeleted == true)
                throw new ArgumentException("A shipment with this ID doesn't exist.");

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
                if (shipment.IsDeleted == true)
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
            if (shipment.Status != "preparing" && shipment.Status != "on the way" && shipment.Status != "completed")
                throw new ArgumentException("The status is incorrect");

            var shipmentToUpdate = this.context.Shipments
                .Include(c => c.Status)
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (shipmentToUpdate.IsDeleted == true)
                throw new ArgumentException("A shipment with this ID doesn't exist.");

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

        public ShipmentDTO Create(CreateShipmentDTO shipment)
        {
            var warehouse = this.context.Warehouses
                .FirstOrDefault(w => w.Id == shipment.WarehouseId);
            var status = this.context.Status
               .FirstOrDefault(w => w.Name == "preparing");

            var newShipment = new Shipment
            {
                Status = status,
                Warehouse = warehouse
            };
            this.context.Shipments.Add(newShipment);
            this.context.SaveChanges();

            var shipmentToDisplay = new ShipmentDTO
            {
                Id = newShipment.Id,
                Status = newShipment.Status.Name,
                DepartureDate = newShipment.DepartureDate,
                ArrivalDate = newShipment.ArrivalDate
            };

            return shipmentToDisplay;
        }

        public bool Delete(Guid id)
        {
            var shipment = this.context.Shipments
                .FirstOrDefault(s => s.Id == id)
                ?? throw new ArgumentNullException();

            if (shipment.IsDeleted == true)
            {
                throw new ArgumentNullException("There is no shipment with this ID.");
            }

            shipment.IsDeleted = true;
            shipment.DeletedOn = DateTime.UtcNow;
            this.context.SaveChanges();
            return true;

        }

        public List<ShipmentDTO> SearchByWarehouse(Guid Id)
        {
            var warehouse = this.context.Warehouses
                .Include(w => w.Shipments)
                .FirstOrDefault(w => w.Id == Id);

            var shipments = this.context.Warehouses
                .Include(s => s.Shipments)
                .ThenInclude(s => s.Status)
                .Where(s => s.Id == warehouse.Id)
                .SelectMany(s => s.Shipments).ToList();
            var shipmentsToDisplay = new List<ShipmentDTO>();

            foreach (var shipment in shipments)
            {
                if (shipment.IsDeleted == true)
                    continue;

                var shipmentToDisplay = new ShipmentDTO
                {
                    Id = shipment.Id,
                    Status = shipment.Status.Name,
                    DepartureDate = shipment.DepartureDate,
                    ArrivalDate = shipment.ArrivalDate
                };
                shipmentsToDisplay.Add(shipmentToDisplay);
            }

            return shipmentsToDisplay;
        }
        public List<ShipmentDTO> SearchByCustomer(Guid Id)
        {
            var customer = this.context.Customers
                .FirstOrDefault(w => w.Id == Id);

            var shipments = this.context.Parcels
                .Where(s => s.CustomerId == customer.Id)
                .Select(s => s.ShipmentId).ToList();
            var shipmentsToDisplay = new List<ShipmentDTO>();

            foreach (var member in shipments)
            {
                var shipment = this.context.Shipments
                .Include(c => c.Status)
                .FirstOrDefault(s => s.Id == member)
                ?? throw new ArgumentNullException();

                if (shipment.IsDeleted == true)
                    continue;

                var shipmentToDisplay = new ShipmentDTO
                {
                    Id = shipment.Id,
                    Status = shipment.Status.Name,
                    DepartureDate = shipment.DepartureDate,
                    ArrivalDate = shipment.ArrivalDate
                };
                shipmentsToDisplay.Add(shipmentToDisplay);
            }

            return shipmentsToDisplay;
        }
    }
}
