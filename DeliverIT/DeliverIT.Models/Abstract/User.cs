using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Abstract
{
    public abstract class User : Entity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid AddressId { get; set; }

        public Address Address { get; set; }

        public ICollection<Parcel> Parcels { get; set; }
    }
}
