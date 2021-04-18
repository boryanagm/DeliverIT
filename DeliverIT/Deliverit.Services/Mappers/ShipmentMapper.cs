using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Linq.Expressions;

namespace Deliverit.Services.Mappers
{
    public static class ShipmentMapper
    {
        public static Expression<Func<Shipment, ShipmentDTO>> DTOSelector = s =>
           new ShipmentDTO
           {
               Id = s.Id,
               Status = s.Status.Name,
               DepartureDate = s.DepartureDate,
               ArrivalDate = s.ArrivalDate
           };
    }
}
