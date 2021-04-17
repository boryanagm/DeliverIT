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

        [HttpPost("create/")]
        public IActionResult Post([FromQuery] CreateParcelDTO parcel)
        {
            var parcelToCreate = this.parcelService.Create(parcel);

            return this.Created("post", parcelToCreate);
        }

        [HttpPut("update/{id}")]
        public IActionResult Put(Guid id, [FromQuery] UpdateParcelDTO parcel)
        {
            try
            {
                var parcelToUpdate = this.parcelService.Update(id, parcel);

                return this.Ok(parcelToUpdate);
            }
            catch (ArgumentNullException)
            {
                return this.Conflict();
            }
        }

        [HttpGet("filter/email")]
        public IActionResult SearchByEmail([FromQuery] string email)
        {
            return this.Ok(this.parcelService.SearchByEmail(email));
        }

        [HttpGet("filter/name")]
        public IActionResult SearchByName([FromQuery] string firstname, string lastname)
        {
            return this.Ok(this.parcelService.SearchByName(firstname, lastname));
        }

        [HttpGet("filter/incoming")]
        public IActionResult SearchByIncomingShippment([FromQuery] Guid Id)
        {
            return this.Ok(this.parcelService.FindIncomingParcels(Id));
        }

        [HttpGet("filter/warehouse")]
        public IActionResult GetByWarehouse([FromQuery] Guid Id)
        {
            return this.Ok(this.parcelService.GetByWarehouse(Id));
        }
        [HttpGet("filter/customer")]
        public IActionResult GetByCustomer([FromQuery] Guid Id)
        {
            return this.Ok(this.parcelService.GetByCustomer(Id));
        }



    }
}
