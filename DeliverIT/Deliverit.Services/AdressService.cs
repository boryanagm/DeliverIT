using Deliverit.Services.Contracts;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services
{
    public class AdressService : IAddressService
    {
        private readonly DeliveritDbContext context;

        public AdressService(DeliveritDbContext context)
        {
            this.context = context;
        }
        public Address Create(Address address)
        {
            address.CreatedOn = DateTime.UtcNow;

            this.context.Addresses.Add(address);
            this.context.SaveChanges();

            return address;
        }
    }
}
