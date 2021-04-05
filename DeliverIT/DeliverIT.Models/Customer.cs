using System;
using System.Collections.Generic;


namespace DeliverIT.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Parcel> Parcels { get; set; }
    }
}
