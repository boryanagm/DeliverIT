﻿using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;


namespace Deliverit.Models
{
    public class Country : Entity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } 
    }
}
