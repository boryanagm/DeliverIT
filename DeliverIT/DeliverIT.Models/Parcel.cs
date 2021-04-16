using Deliverit.Models;
using Deliverit.Models.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    public class Parcel : Entity
    {
        [Range(1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public int Weight { get; set; }
    
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        [ForeignKey("Shipment")] // TODO: Make it not required?
        public Guid ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
    }
}
