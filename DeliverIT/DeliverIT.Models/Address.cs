using DeliverIT.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Address : IAddress
    {
        public Guid Id { get; set; }

        public string StreetName { get; set; }
        public Location Location { get; set; }

    }
}
