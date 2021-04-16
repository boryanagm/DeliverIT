using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Models
{
    public class ParcelDTO
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string CustomerName { get; set; }
    }
}
