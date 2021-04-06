using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deliverit.Models
{
    public class Country : Entity
    {

        [StringLength(55, MinimumLength = 4, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } 
    }
}
