using Deliverit.Services.Contracts;
using Deliverit.Web.Helpers;
using DeliverIT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private readonly IAuthEmployeeHelper authEmployeeHelper;

        public EmployeesController(IEmployeeService employeeService, IAuthEmployeeHelper authEmployeeHelper)
        {
            this.employeeService = employeeService;
            this.authEmployeeHelper = authEmployeeHelper;
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                return this.Ok(this.employeeService.Get(id));
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
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                return this.Ok(this.employeeService.GetAll());
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpPost("")]
        public IActionResult Post([FromHeader] string authorizationEmail, [FromBody] Employee employee)
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                var employeeToUpdate = this.employeeService.Create(employee);
                return this.Created("post", employeeToUpdate);
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, Guid addressId) 
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                var employeeToUpdate = this.employeeService.Update(id, addressId);
                return this.Ok(employeeToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                var success = this.employeeService.Delete(id);

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

        [HttpPost("{id}/restore")] // Not working
        public IActionResult Restore([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var admin = this.authEmployeeHelper.TryGetAdmin(authorizationEmail);
                var employeeToRestore = this.employeeService.Restore(id);
                return this.Created("post", employeeToRestore);
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }
    }
}
