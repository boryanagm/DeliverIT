using Deliverit.Models.Abstract;
using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Warehouse : Entity
    {
        public Guid Id { get; set; }
        public Categories Category { get; set; }

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Shipment> Shipments { get; set; }

        public ICollection<Parcel> Parcels { get; set; } 
    }
}
