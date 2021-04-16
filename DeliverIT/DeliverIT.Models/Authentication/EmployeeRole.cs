using DeliverIT.Models;
using System;

namespace Deliverit.Models.Authentication
{
    public class EmployeeRole
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
