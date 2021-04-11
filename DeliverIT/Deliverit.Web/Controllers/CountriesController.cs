using Deliverit.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Controllers
{
    namespace Deliverit.Web.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CountriesController : ControllerBase
        {
            private readonly ICountryService countryService;

            public CountriesController(ICountryService countryService)
            {
                this.countryService = countryService;
            }

            [HttpGet("{id}")]
            public IActionResult Get(Guid id)
            {
                return this.Ok(this.countryService.Get(id));
            }

            [HttpGet("")]
            public IActionResult GetAll()
            {
                return this.Ok(this.countryService.GetAll());
            }
        }
    }
}
