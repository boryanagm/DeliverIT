using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using Deliverit.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;

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
        private readonly IAuthEmployeeHelper authEmployeeHelper;
        private readonly IAuthCustomerHelper authCustomerHelper;
        public ShipmentController(IShipmentService shipmentService, IAuthEmployeeHelper authEmployeeHelper, IAuthCustomerHelper authCustomerHelper)
        {
            this.shipmentService = shipmentService;
            this.authEmployeeHelper = authEmployeeHelper;
            this.authCustomerHelper = authCustomerHelper;
        }

        /// <summary>
        /// Gets the a shipment by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpGet("{id}")]
        public IActionResult Get([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.shipmentService.Get(id));
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Gets all shipments.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet("")]
        public IActionResult GetAll([FromHeader] string authorizationEmail)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.shipmentService.GetAll());
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
        }

        /// <summary>
        /// Creates a shipment.
        /// </summary>
        /// <param name="shipment">The shipment.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost("create/")]
        public IActionResult Post([FromHeader] string authorizationEmail, [FromQuery] CreateShipmentDTO shipment)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var shipmentToCreate = this.shipmentService.Create(shipment);
                return this.Created("post", shipmentToCreate);
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deletes a shipment.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var success = this.shipmentService.Delete(id);

                if (success)
                {
                    return this.NoContent();
                }
                else
                {
                    return this.NotFound();
                }
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Updates a shipment.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="shipment">The shipment update data.</param>
        [HttpPut("update/{id}")]
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, [FromQuery] ShipmentDTO shipment)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var shipmentToUpdate = this.shipmentService.Update(id, shipment);
                return this.Ok(shipmentToUpdate);
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Filters the shipments by Warehouse.
        /// </summary>
        /// <param name="Id">The identifier of the warehouse.</param>
        [HttpGet("filter/warehouse")]
        public IActionResult FilterShipments([FromHeader] string authorizationEmail, [FromQuery] Guid Id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.shipmentService.SearchByWarehouse(Id));
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Filters shippments by customers.
        /// </summary>
        /// <param name="Id">The identifier of the customer.</param>
        [HttpGet("filter/customer")]
        public IActionResult FilterCustomers([FromHeader] string authorizationEmail, [FromQuery] Guid Id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.shipmentService.SearchByCustomer(Id));
            }
            catch (UnauthorizedAccessException)
            {
                return this.Forbid();
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }
    }
}
