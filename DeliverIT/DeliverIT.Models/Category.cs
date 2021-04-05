using DeliverIT.Models;
using System;
using System.Collections.Generic;


namespace Deliverit.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Parcel> Parcels { get; set; }
    }
}
