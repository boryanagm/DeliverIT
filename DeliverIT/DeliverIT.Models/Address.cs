using Deliverit.Models;
using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    /// <summary>
    /// Class Address.
    /// Configures the properties of an address.
    /// </summary>
    public class Address : Entity
    {

        [StringLength(100, MinimumLength = 1, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string StreetName { get; set; }

        [ForeignKey("City")]
        public Guid CityId { get; set; }
        public City City { get; set; }

        public ICollection<Warehouse> Warehouses { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
