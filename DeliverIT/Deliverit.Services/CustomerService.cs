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

                this.context.Customers.Remove(customer);
                this.context.SaveChanges();
                // Or soft delete?

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
            throw new NotImplementedException();
        }

        public IEnumerable<Parcel> GetIncomingParcels()
        {
            throw new NotImplementedException();
        }

        
    }
}
