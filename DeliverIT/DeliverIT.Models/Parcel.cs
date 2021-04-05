using Deliverit.Models;
using Deliverit.Models.Abstract;
using System;


namespace DeliverIT.Models
{
    public class Parcel : Entity
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public Guid ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
    }
}
