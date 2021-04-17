using Deliverit.Services.Contracts;
using Deliverit.Web.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService cityService;
        private readonly IAuthEmployeeHelper autHelper;

        public CitiesController(ICityService cityService, IAuthEmployeeHelper autHelper)
        {
            this.cityService = cityService;
            this.autHelper = autHelper;
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
