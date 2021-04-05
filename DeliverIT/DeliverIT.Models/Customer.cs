using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string LastName { get; set; }


        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Parcel> Parcels { get; set; }
    }
}
