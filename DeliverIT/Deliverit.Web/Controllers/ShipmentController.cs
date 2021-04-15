using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : Controller
    {
        private readonly IShipmentService shipmentService;

        public ShipmentController(IShipmentService shipmentService)
        {
            this.shipmentService = shipmentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.Ok(this.shipmentService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.shipmentService.GetAll());
        }

        [HttpPost("create/")]
        public IActionResult Post([FromQuery] CreateShipmentDTO shipment)
        {
            var shipmentToCreate = this.shipmentService.Create(shipment);

            return this.Created("post", shipmentToCreate);
        }


        [HttpDelete("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            var success = this.shipmentService.Delete(id);

            if (success)
            {
                return this.NoContent();
            }

            return this.NotFound();
        }

        [HttpPut("update/{id}")]
        public IActionResult Put(Guid id, [FromQuery] ShipmentDTO shipment)
        {
            try
            {
                var shipmentToUpdate = this.shipmentService.Update(id, shipment);

                return this.Ok(shipmentToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpGet("filter/warehouse")]
        public IActionResult FilterShipments([FromQuery] Guid Id)
        {
            return this.Ok(this.shipmentService.SearchByWarehouse(Id));
        }
        [HttpGet("filter/customer")]
        public IActionResult FilterCustomers([FromQuery] Guid Id)
        {
            return this.Ok(this.shipmentService.SearchByCustomer(Id));
        }
    }
}
