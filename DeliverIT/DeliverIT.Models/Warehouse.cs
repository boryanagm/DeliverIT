using DeliverIT.Models.Contracts;
using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Warehouse : IWarehouse
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public Categories Category { get; set; }
        public Shipment Shipment { get; set; }
    }
}
