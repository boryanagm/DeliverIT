using Deliverit.Services.Contracts;
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

        public WarehousesController(IWarehouseService warehouseService)
        {
            this.warehouseService = warehouseService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.Ok(this.warehouseService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.warehouseService.GetAll());
        }

        [HttpPost("")]
        public IActionResult Post([FromQuery] Warehouse warehouse) 
        {
            var warehouseToUpdate = this.warehouseService.Create(warehouse);

            return this.Created("post", warehouseToUpdate);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, string streetName, string city)
        {
            try
            {
                var warehouseToUpdate = this.warehouseService.Update(id, streetName, city);

                return this.Ok(warehouseToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) // Or Try/Catch?
        {
            var success = this.warehouseService.Delete(id);

            if (success)
            {
                return this.NoContent();
            }

            return this.NotFound();
        }
    }
}
