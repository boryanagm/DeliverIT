using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Contracts
{
    public interface IShipment
    {
        public Guid Id { get; }

        public DateTime DepartureDate { get;  }
        public DateTime ArrivalDate { get; }
        public Status Status { get; }
    }
}
