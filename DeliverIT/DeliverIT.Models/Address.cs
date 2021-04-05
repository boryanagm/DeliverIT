using Deliverit.Models;
using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;


namespace DeliverIT.Models
{
    public class Address : Entity
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
