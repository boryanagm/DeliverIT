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
            return this.Ok(this.cityService.Get(id));
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.cityService.GetAll());
        }
    }
}
