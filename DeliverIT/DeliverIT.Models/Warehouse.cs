using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    public class Warehouse : Entity
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Shipment> Shipments { get; set; }

        public ICollection<Parcel> Parcels { get; set; } 
    }
}
