using Deliverit.Services.Contracts;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverit.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DeliveritDbContext context;

        public CustomerService(DeliveritDbContext context)
        {
            this.context = context;
        }


        public Customer Get(Guid id)
        {
            var customer = this.context.Customers
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = this.context.Customers;
            return customers;
        }

        public Customer Create(Customer customer)
        {
            customer.CreatedOn = DateTime.UtcNow;

            this.context.Customers.Add(customer);
            this.context.SaveChanges();

            return customer;
        }

        public Customer Update(Guid id, Customer customer)
        {
            var customerToUpdate = this.context.Customers
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;
            customerToUpdate.AddressId = customer.AddressId; // Or Address?
            customer.ModifiedOn = DateTime.UtcNow;

            this.context.SaveChanges();

            return customer;
        }
        public bool Delete(Guid id)
        {
            var customer = this.context.Customers
                 .FirstOrDefault(c => c.Id == id);

            if (customer != null)
            {
                customer.DeletedOn = DateTime.UtcNow;
                customer.IsDeleted = true;          
                this.context.SaveChanges();

                return true;
            }

            return false;
        }

        public Customer GetByEmail(string email)
        {
            var customer = this.context.Customers
                .FirstOrDefault(c => c.Email == email);

            return customer;
        }

        public Customer GetByFirstName(string firstName)
        {
            var customer = this.context.Customers
                .FirstOrDefault(c => c.FirstName == firstName);

            return customer;
        }

        public Customer GetByLastName(string lastName)
        {
            var customer = this.context.Customers
                 .FirstOrDefault(c => c.LastName == lastName);

            return customer;
        }

        public Customer GetByMultipleCriteria()
        {
            var results = this.context.Customers
                .Where(c => Search.FirstName == null || c.FirstName.Contains(Search.FirstName) 
                && Search.LastName == null || c.LastName.Contains(Search.LastName) 
                && Search.Email == null || c.Email.Contains(Search.Email)).FirstOrDefault();

            return results;
        }

        public IEnumerable<Parcel> GetIncomingParcels(string email)
        {
            var customer = this.context.Customers
                .FirstOrDefault(c => c.Email == email);

            return customer.Parcels;
        }

        public Customer GetByKeyWord(string key)
        {
            var customer = this.context.Customers
                .FirstOrDefault(c => c.FirstName == key
                || c.LastName == key
                || c.Email == key);

            return customer;
        }
    }
}
