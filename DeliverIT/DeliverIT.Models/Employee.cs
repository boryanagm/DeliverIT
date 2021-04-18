using Deliverit.Models.Abstract;
using Deliverit.Models.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    /// <summary>
    /// Class Employee.
    /// Configures the properties of an employee.
    /// </summary>
    public class Employee : Entity
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Not a valid email address.")]
        [Required]
        public string Email { get; set; }

        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Parcel> Parcels { get; set; }
        public ICollection<EmployeeRole> Roles { get; set; }
    }
}
