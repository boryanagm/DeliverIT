using Deliverit.Models.Abstract;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deliverit.Models
{
    public class City : Entity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
