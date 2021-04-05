using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deliverit.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(35, MinimumLength = 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string Name { get; set; }

        public ICollection<Parcel> Parcels { get; set; }
    }
}
