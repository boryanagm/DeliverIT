using Deliverit.Models.Abstract;
using DeliverIT.Models;
using System;
using System.Collections.Generic;


namespace Deliverit.Models
{
    public class City : Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
