using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Contracts
{
    public interface ILocation
    {
        public Guid Id { get; }

        public string City { get; }
        public string Country { get;}
    }
}
