using Deliverit.Models.Abstract;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deliverit.Models
{
    /// <summary>
    /// Class Status.
    /// Configures the properties of a status.
    /// </summary>
    public class Status : Entity
    {
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string Name { get; set; }

        public ICollection<Shipment> Shipments { get; set; }
    }
}
