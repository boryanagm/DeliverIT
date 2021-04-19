using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Deliverit.Web.Controllers
{
    /// <summary>
    /// Class ParcelController.
    /// Handles all parcel services.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelController : Controller
    {
        private readonly IParcelService parcelService;
        public ParcelController(IParcelService parcelService)
        {
            this.parcelService = parcelService;
        }

        /// <summary>
        /// Gets a parcel by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return this.Ok(this.parcelService.Get(id));
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }

        /// <summary>
        /// Gets all Parcels.
        /// </summary>
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return this.Ok(this.parcelService.GetAll());
        }

        /// <summary>
        /// Creates a parcel.
        /// </summary>
        /// <param name="parcel">The parcel.</param>
        [HttpPost("create/")]
        public IActionResult Post([FromQuery] CreateParcelDTO parcel)
        {
            try
            {
                var parcelToCreate = this.parcelService.Create(parcel);
                return this.Created("post", parcelToCreate);
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Updates a parcel by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parcel">The parcel.</param>
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

        /// <summary>
        /// Deletes a parcel by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var success = this.parcelService.Delete(id);

                if (success)
                {
                    return this.NoContent();
                }
                return this.Conflict();
            }
            catch (Exception)
            {
                return this.NotFound();
            }
        }

        /// <summary>
        /// Filters parcels by e-mail.
        /// </summary>
        /// <param name="email">The email.</param>
        [HttpGet("filter/email")]
        public IActionResult SearchByEmail([FromQuery] string email)
        {
            try
            {
                return this.Ok(this.parcelService.SearchByEmail(email));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by customer's first and last names.
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        [HttpGet("filter/name")]
        public IActionResult SearchByName([FromQuery] string firstname, string lastname)
        {
            try
            {
                return this.Ok(this.parcelService.SearchByName(firstname, lastname));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filter by incoming parcels.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpGet("filter/incoming")]
        public IActionResult SearchByIncomingShippment([FromQuery] Guid Id)
        {
            try
            {
                return this.Ok(this.parcelService.FindIncomingParcels(Id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters by warehouse Id.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpGet("filter/warehouse")]
        public IActionResult GetByWarehouse([FromQuery] Guid Id)
        {
            try
            {
                return this.Ok(this.parcelService.GetByWarehouse(Id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by customer Id.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpGet("filter/customer")]
        public IActionResult GetByCustomer([FromQuery] Guid Id)
        {
            try
            {
                return this.Ok(this.parcelService.GetByCustomer(Id));
            }
            catch(Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by weight.
        /// </summary>
        /// <param name="weight">The weight.</param>
        [HttpGet("filter/weight")]
        public IActionResult GetByWeight([FromQuery] int weight)
        {
            try
            {
                return this.Ok(this.parcelService.GetByWeight(weight));
            }
            catch(Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by category.
        /// </summary>
        /// <param name="category">The category.</param>    
        [HttpGet("filter/category")]
        public IActionResult GetByCategory([FromQuery] string category)
        {
            try
            {
                return this.Ok(this.parcelService.GetByCategory(category));
            }
            catch(Exception)
            {
                return this.Conflict();
            }
        }
    }
}
