using DeliverIT.Models;
using System;
using System.Collections.Generic;


namespace Deliverit.Models
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Shipment> Shipments { get; set; }
    }
}
