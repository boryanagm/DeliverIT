using DeliverIT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Contracts
{
    public interface IWarehouse
    {
        public Guid Id { get; }
        public Address Address { get;  }
        public Categories Category { get;  }
        public Shipment Shipment { get;  }
    }
}
