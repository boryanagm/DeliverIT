using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Models
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Invalid country name.")]
        [Display(Name = "Country Name")]
        public string Name { get; set; }
    }
}
