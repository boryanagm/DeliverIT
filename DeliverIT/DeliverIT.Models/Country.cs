using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Models
{
    public class Country : Entity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } 
    }
}
