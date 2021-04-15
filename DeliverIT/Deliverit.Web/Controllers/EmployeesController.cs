using Deliverit.Services.Contracts;
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

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.Ok(this.employeeService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.employeeService.GetAll());
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Employee employee)
        {
            var employeeToUpdate = this.employeeService.Create(employee);

            return this.Created("post", employeeToUpdate);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromHeader] string streetName, string city) // Guid id, [FromBody] Employee employee
        {
            try
            {
                var employeeToUpdate = this.employeeService.Update(id, streetName, city);

                return this.Ok(employeeToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) // Or Try/Catch?
        {
            var success = this.employeeService.Delete(id);

            if (success)
            {
                return this.NoContent();
            }

            return this.NotFound();
        }
    }
}
