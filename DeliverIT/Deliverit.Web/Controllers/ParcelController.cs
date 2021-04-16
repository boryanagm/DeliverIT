using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliverit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelController : Controller
    {
        private readonly IParcelService parcelService;

        public ParcelController(IParcelService parcelService)
        {
            this.parcelService = parcelService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.Ok(this.parcelService.Get(id));
        }
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.parcelService.GetAll());
        }
    }
}
