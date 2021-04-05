using Deliverit.Models;
using Deliverit.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverIT.Models
{
    public class Shipment : Entity
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [DataType(DataType.Date)] // TODO: Should be past DepartureDate
        public DateTime ArrivalDate { get; set; }


        [ForeignKey("Status")]
        public Guid StatusId { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<Parcel> Parcels { get; set; } 
    }
}
