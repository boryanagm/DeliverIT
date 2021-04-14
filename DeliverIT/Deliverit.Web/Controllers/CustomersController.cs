using Deliverit.Services;
using Deliverit.Services.Contracts;
using DeliverIT.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.Ok(this.customerService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.customerService.GetAll());
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Customer customer)
        {
            var customerToUpdate = this.customerService.Create(customer);

            return this.Created("post", customerToUpdate);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Customer customer)
        {
            try
            {
                var customerToUpdate = this.customerService.Update(id, customer);

                return this.Ok(customer);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) // Or Try/Catch?
        {
            var success = this.customerService.Delete(id);

            if (success)
            {
                return this.NoContent();
            }

            return this.NotFound();
        }

        [HttpGet("{email}/email")]
        public IActionResult GetByEmail(string email)
        {
            return this.Ok(this.customerService.GetByEmail(email));
        }

        [HttpGet("{firstName}/firstname")]
        public IActionResult GetByFirstname(string firstName)
        {
            return this.Ok(this.customerService.GetByFirstName(firstName));
        }

        [HttpGet("{lastName}/lastname")]
        public IActionResult GetByLastName(string lastName)
        {
            return this.Ok(this.customerService.GetByLastName(lastName));
        }

        [HttpGet("{id}/parcels")]
        public IActionResult GetIncomingParcels(Guid id)
        {
            return this.Ok(this.customerService.GetIncomingParcels(id));
        }

        [HttpGet("{key}/all")]
        public IActionResult GetByKeyWord(string key)
        {
            return this.Ok(this.customerService.GetByKeyWord(key));
        }

        [HttpGet("/multiple")] // TODO: Not working
        public IActionResult GetByMultipleCriteria([FromQuery]CustomerFilter customerFilter) 
        {
            return this.Ok(this.customerService.GetByMultipleCriteria(customerFilter));
        }
    }
}
