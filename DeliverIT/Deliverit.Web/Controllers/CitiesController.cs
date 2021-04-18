using Deliverit.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService cityService;

        public CitiesController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return this.Ok(this.cityService.Get(id));
            }
            catch(Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.cityService.GetAll());
        }
    }
}
