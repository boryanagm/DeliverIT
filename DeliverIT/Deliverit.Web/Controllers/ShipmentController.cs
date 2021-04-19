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
    /// <summary>
    /// Class ShipmentController.
    /// Handles all shipment services.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : Controller
    {
        private readonly IShipmentService shipmentService;

        public ShipmentController(IShipmentService shipmentService)
        {
            this.shipmentService = shipmentService;
        }

        /// <summary>
        /// Gets the a shipment by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return this.Ok(this.shipmentService.Get(id));
            }
            catch(Exception)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Gets all shipments.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.shipmentService.GetAll());
        }

        /// <summary>
        /// Creates a shipment.
        /// </summary>
        /// <param name="shipment">The shipment.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost("create/")]
        public IActionResult Post([FromQuery] CreateShipmentDTO shipment)
        {
            try
            {
                var shipmentToCreate = this.shipmentService.Create(shipment);
                return this.Created("post", shipmentToCreate);
            }
            catch(Exception)
            {
                return Conflict();
            }     
        }


        /// <summary>
        /// Deletes a shipment.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var success = this.shipmentService.Delete(id);

                if (success)
                {
                    return this.NoContent();
                }
                return this.NotFound();
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }

        /// <summary>
        /// Updates a shipment.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="shipment">The shipment update data.</param>
        [HttpPut("update/{id}")]
        public IActionResult Put(Guid id, [FromQuery] ShipmentDTO shipment)
        {
            try
            {
                var shipmentToUpdate = this.shipmentService.Update(id, shipment);
                return this.Ok(shipmentToUpdate);
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }


        /// <summary>
        /// Filters the shipments by Warehouse.
        /// </summary>
        /// <param name="Id">The identifier of the warehouse.</param>
        [HttpGet("filter/warehouse")]
        public IActionResult FilterShipments([FromQuery] Guid Id)
        {
            try
            {
                return this.Ok(this.shipmentService.SearchByWarehouse(Id));
            }
            catch(Exception)
            {
                return Conflict();
            }
        }


        /// <summary>
        /// Filters shippments by customers.
        /// </summary>
        /// <param name="Id">The identifier of the customer.</param>
        [HttpGet("filter/customer")]
        public IActionResult FilterCustomers([FromQuery] Guid Id)
        {
            try
            {
                return this.Ok(this.shipmentService.SearchByCustomer(Id));
            }
            catch(Exception)
            {
                return NotFound();
            }
        }
    }
}
