using DeliverIT.Models.Contracts;
using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Shipment : IShipment
    {
        public Guid Id { get; set; }

        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public Status Status { get; set; }

    }
}
