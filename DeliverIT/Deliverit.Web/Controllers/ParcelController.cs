﻿using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using Deliverit.Web.Helpers;
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
        private readonly IAuthEmployeeHelper authEmployeeHelper;
        private readonly IAuthCustomerHelper authCustomerHelper;
        public ParcelController(IParcelService parcelService, IAuthEmployeeHelper authEmployeeHelper, IAuthCustomerHelper authCustomerHelper)
        {
            this.parcelService = parcelService;
            this.authEmployeeHelper = authEmployeeHelper;
            this.authCustomerHelper = authCustomerHelper;
        }

        /// <summary>
        /// Gets a parcel by Id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpGet("{id}")]
        public IActionResult Get([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult Post([FromHeader] string authorizationEmail, [FromQuery] CreateParcelDTO parcel)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult Put([FromHeader] string authorizationEmail, Guid id, [FromQuery] UpdateParcelDTO parcel)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult Delete([FromHeader] string authorizationEmail, Guid id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult SearchByEmail([FromHeader] string authorizationEmail, [FromQuery] string email)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult SearchByName([FromHeader] string authorizationEmail, [FromQuery] string firstname, string lastname)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult SearchByIncomingShippment([FromHeader] string authorizationEmail, [FromQuery] Guid Id)
        {
            try
            {
                var customer = this.authCustomerHelper.TryGetCustomer(authorizationEmail);
                if (customer.Id == Id)
                    return this.Ok(this.parcelService.FindIncomingParcels(Id));
                else
                    return this.NotFound();
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
        public IActionResult GetByWarehouse([FromHeader] string authorizationEmail, [FromQuery] Guid Id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
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
        public IActionResult GetByCustomer([FromHeader] string authorizationEmail, [FromQuery] Guid Id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.parcelService.GetByCustomer(Id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by weight.
        /// </summary>
        /// <param name="weight">The weight.</param>
        [HttpGet("filter/weight")]
        public IActionResult GetByWeight([FromHeader] string authorizationEmail, [FromQuery] int weight)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.parcelService.GetByWeight(weight));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by category.
        /// </summary>
        /// <param name="category">The category.</param>    
        [HttpGet("filter/category")]
        public IActionResult GetByCategory([FromHeader] string authorizationEmail, [FromQuery] string category)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.parcelService.GetByCategory(category));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Filters parcels by category and Id.
        /// </summary>
        /// <param name="category">The category.</param>    
        [HttpGet("filter/multiplecriteria")]
        public IActionResult GetByMultipleCriteria([FromHeader] string authorizationEmail, [FromQuery] string category, [FromQuery] Guid Id)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.parcelService.GetByMultipleCriteria(category, Id));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }

        /// <summary>
        /// Sorts by weight or arrival date.
        /// </summary>
        /// <param name="category">The category.</param>    
        [HttpGet("filter/weightordate")]
        public IActionResult SortByWeightOrDate([FromHeader] string authorizationEmail, [FromQuery] string criteria)
        {
            try
            {
                var employee = this.authEmployeeHelper.TryGetEmployee(authorizationEmail);
                return this.Ok(this.parcelService.SortByWeightOrArrivalDate(criteria));
            }
            catch (Exception)
            {
                return this.Conflict();
            }
        }
    }
}
