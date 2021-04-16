using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Models
{
    public class UpdateParcelDTO
    {
        public int Weight { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ShipmentId { get; set; }
    }
}
