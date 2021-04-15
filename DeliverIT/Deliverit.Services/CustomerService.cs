﻿using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            //Customer customer = this.context.Customers
            //    .Include(c => c.FirstName)
            //    .Include(c => c.LastName)
            //    .FirstOrDefault(c => c.Id == id);

            //CustomerDTO dto = new CustomerDTO();
            //dto.FirstName = customer.FirstName;
            //dto.LastName = customer.LastName;

            //return dto;
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

        public Customer Update(Guid id, string streetName, string city) 
        {
            var customerToUpdate = this.context.Customers
                .Include(c => c.Address)
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            var newCity = this.context.Cities.FirstOrDefault(c => c.Name == city);
            var newAddress = new Address { Id = new Guid(), CreatedOn = DateTime.UtcNow, City = newCity, StreetName = streetName };

            customerToUpdate.Address = newAddress;
            this.context.SaveChanges();

            return customerToUpdate;
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

        public List<CustomerDTO> GetByMultipleCriteria(CustomerFilter customerFilter)  
        {
            var searchResult = this.context.Customers
                .Where(c => customerFilter.FirstName == null || c.FirstName.Contains(customerFilter.FirstName) 
                && customerFilter.LastName == null || c.LastName.Contains(customerFilter.LastName) 
                && customerFilter.Email == null || c.Email.Contains(customerFilter.Email))
                .Select(c => new CustomerDTO 
                {
                   Id = c.Id,
                   FirstName = c.FirstName,
                   LastName = c.LastName, 
                   Email = c.Email
                })
                .ToList();

            return searchResult;
        }

        public List<ParcelDTO> GetIncomingParcels(Guid id) 
        {
            List<ParcelDTO> dto = this.context.Customers
                .Include(c => c.Parcels)
                .FirstOrDefault(c => c.Id == id).Parcels
                .Select(c => new ParcelDTO { Id = c.Id })
                .ToList();

            return dto;
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
