using Deliverit.Services;
using Deliverit.Services.Contracts;
using Deliverit.Web.Helpers;
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
        private readonly IAuthEmployeeHelper authEmployeeHelper;

        public CustomersController(ICustomerService customerService, IAuthEmployeeHelper authEmployeeHelper)
        {
            this.customerService = customerService;
            this.authEmployeeHelper = authEmployeeHelper;
        }

        [HttpGet("{id}")] // TODO: If there's time, make it accessible only for the customer under that ID
        public IActionResult Get([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.customerService.Get(id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.customerService.GetAll());
        }

        [HttpGet("/count")]
        public IActionResult GetCount()
        {
            return this.Ok(this.customerService.GetCount());
        }

        [HttpPost("")] 
        public IActionResult Post([FromBody] Customer customer) // public part
        {
            var newCustomer = this.customerService.Create(customer);

            return this.Created("post", newCustomer);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Guid addressId) // Guid id, [FromBody] Customer customer
        {
            try
            {
                var customerToUpdate = this.customerService.Update(id, addressId);

                return this.Ok(customerToUpdate);
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

        [HttpGet("{id}/incoming")]
        public IActionResult GetIncomingParcels(Guid id)
        {
            return this.Ok(this.customerService.GetIncomingParcels(id));
        }

        [HttpGet("{id}/past")]
        public IActionResult GetPastParcels(Guid id)
        {
            return this.Ok(this.customerService.GetPastParcels(id));
        }

        [HttpGet("{key}/all")]
        public IActionResult GetByKeyWord(string key)
        {
            return this.Ok(this.customerService.GetByKeyWord(key));
        }

        [HttpGet("/multiple")] 
        public IActionResult GetByMultipleCriteria([FromQuery]CustomerFilter customerFilter) 
        {
            return this.Ok(this.customerService.GetByMultipleCriteria(customerFilter));
        }
    }
}

/*
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
 */
