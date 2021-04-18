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
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.customerService.Get(id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpGet("")]
        public IActionResult GetAll([FromHeader] string authorizationEmail)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.customerService.GetAll());
            }
            catch (Exception)
            {
                return this.Conflict();
            }
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
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, Guid addressId)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var customerToUpdate = this.customerService.Update(id, addressId);

                return this.Ok(customerToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id) // TODO: The customer should also be able to delete his/her profile
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                var success = this.customerService.Delete(id);

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

        [HttpGet("{id}/incoming")]                // TODO: Make it visible only for the customer under that ID
        public IActionResult GetIncomingParcels(Guid id)
        {
            return this.Ok(this.customerService.GetIncomingParcels(id));
        }

        [HttpGet("{id}/past")]                    // TODO: Make it visible only for the customer under that ID
        public IActionResult GetPastParcels(Guid id)
        {
            return this.Ok(this.customerService.GetPastParcels(id));
        }

        [HttpGet("{key}/all")]
        public IActionResult GetByKeyWord([FromHeader] string authorizationEmail, string key)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.customerService.GetByKeyWord(key));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpGet("/multiple")]
        public IActionResult GetByMultipleCriteria([FromQuery] CustomerFilter customerFilter)
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
