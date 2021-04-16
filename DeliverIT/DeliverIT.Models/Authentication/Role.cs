using System;
using System.Collections.Generic;

namespace Deliverit.Models.Authentication
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CustomerRole> CustomerRoles { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }

    }
}
