using DeliverIT.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models
{
    public class Parcel : IParcel
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Warehouse Warehouse { get; set; }
        public int Weight { get; set; }


    }
}
