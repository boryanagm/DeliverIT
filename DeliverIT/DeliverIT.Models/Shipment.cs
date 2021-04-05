using Deliverit.Models.Abstract;
using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Shipment : Entity
    {
        public Guid Id { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Status Status { get; set; }

        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<Parcel> Parcels { get; set; } 
    }
}
