using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Contracts
{
    public interface IAddress
    {
        public Guid Id { get; }

        public string StreetName { get;}
        public Location Location { get; }
    }
}
