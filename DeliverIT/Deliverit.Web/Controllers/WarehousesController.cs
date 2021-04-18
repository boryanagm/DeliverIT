using Deliverit.Services.Contracts;
using Deliverit.Web.Helpers;
using DeliverIT.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        private readonly IWarehouseService warehouseService;
        private readonly IAuthEmployeeHelper authEmployeeHelper;

        public WarehousesController(IWarehouseService warehouseService, IAuthEmployeeHelper authEmployeeHelper) 
        {
            this.warehouseService = warehouseService;
            this.authEmployeeHelper = authEmployeeHelper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) // public part
        {
            return this.Ok(this.warehouseService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()     // public part
        {
            return this.Ok(this.warehouseService.GetAll());
        }

        [HttpPost("")]
        public IActionResult Post([FromHeader] string authorizationEmail, [FromBody] Warehouse warehouse) 
        {
            var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
            var warehouseToUpdate = this.warehouseService.Create(warehouse);

            return this.Created("post", warehouseToUpdate);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, Guid addressId) 
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var warehouseToUpdate = this.warehouseService.Update(id, addressId);

                return this.Ok(warehouseToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")] // admin only
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id) 
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                var success = this.warehouseService.Delete(id);

                if (success)
                {
                    return this.NoContent();
                }
                else
                {
                    return this.NotFound();
                }
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }
    }
}
