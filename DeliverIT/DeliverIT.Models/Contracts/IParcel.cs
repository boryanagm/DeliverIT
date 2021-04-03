using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Contracts
{
    public interface IParcel
    {
        public Guid Id { get; }
        public Customer Customer { get; }
        public Warehouse Warehouse { get;  }
        public int Weight { get; }
    }
}
