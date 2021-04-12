using Deliverit.Services.Contracts;
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

        [HttpPost("")]
        public IActionResult Post([FromBody] Shipment shipment)
        {
            var shipmentToCreate = this.shipmentService.Create(shipment);

            return this.Created("post", shipmentToCreate);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) 
        {
            var success = this.shipmentService.Delete(id);

            if (success)
            {
                return this.NoContent();
            }

            return this.NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Shipment shipment)
        {
            try
            {
                var shipmentToUpdate = this.shipmentService.Update(id, shipment);

                return this.Ok(shipment);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }
    }
}
