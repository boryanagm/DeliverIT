using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverIT.Models.Abstract
{
    public abstract class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

    }
}
