using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    public class Warehouse : Entity
    {
        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Shipment> Shipments { get; set; }

    }
}
