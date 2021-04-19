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
        private readonly IAuthCustomerHelper authCustomerHelper;

        public CustomersController(ICustomerService customerService, IAuthEmployeeHelper authEmployeeHelper, IAuthCustomerHelper authCustomerHelper)
        {
            this.customerService = customerService;
            this.authEmployeeHelper = authEmployeeHelper;
            this.authCustomerHelper = authCustomerHelper;
        }

        [HttpGet("{id}")] 
        public IActionResult Get([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var customer = this.authCustomerHelper.TryGetCustomer(authorizationEmail);

                if (customer.Id != id)
                {
                    return this.Forbid();
                }

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
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, Guid addressId) // TODO: The customer should be able to create new address and update it
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
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id)             // TODO: The customer should also be able to delete his/her profile
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

        [HttpGet("{id}/incoming")]                
        public IActionResult GetIncomingParcels([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var customer = this.authCustomerHelper.TryGetCustomer(authorizationEmail);

                if (customer.Id != id)
                {
                    return this.Forbid();
                }

                return this.Ok(this.customerService.GetIncomingParcels(id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpGet("{id}/past")]                    
        public IActionResult GetPastParcels([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var customer = this.authCustomerHelper.TryGetCustomer(authorizationEmail);

                if (customer.Id != id)
                {
                    return this.Forbid();
                }

                return this.Ok(this.customerService.GetPastParcels(id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
            
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
        public IActionResult GetByMultipleCriteria([FromHeader] string authorizationEmail, [FromQuery] CustomerFilter customerFilter)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.customerService.GetByMultipleCriteria(customerFilter));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }
    }
}