using DeliverIT.Models;
using System;

namespace Deliverit.Models.Authentication
{
    public class CustomerRole
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
