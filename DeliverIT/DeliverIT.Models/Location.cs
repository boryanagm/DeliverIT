using DeliverIT.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Location : ILocation
    {
        public Guid Id { get; set; }

        public string City { get; set; }
        public string Country { get; set; }


    }
}
