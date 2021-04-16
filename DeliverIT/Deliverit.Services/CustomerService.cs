using Deliverit.Services.Contracts;
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


        public CustomerDTO Get(Guid id) 
        {
            var dto = this.context.Customers
               .Select(c => new CustomerDTO
               {
                   Id = c.Id,
                   FirstName = c.FirstName,
                   LastName = c.LastName,
                   Email = c.Email
               })
               .FirstOrDefault(c => c.Id == id)
               ?? throw new ArgumentNullException();

            return dto;
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (var customer in this.context.Customers)
            {
                var dto = new CustomerDTO
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email
                };
                customers.Add(dto);
            }
            return customers;
        }

        public int GetCount()
        {
            return this.context.Customers.Count();
        }

        public Customer Create(Customer customer)
        {
            this.context.Customers.Add(customer);
            customer.CreatedOn = DateTime.UtcNow;
            this.context.SaveChanges();

            return customer;
        }

        public CustomerDTO Update(Guid id, string streetName, string city) 
        {
            var customerToUpdate = this.context.Customers
                .Include(c => c.Address)
                  .ThenInclude(a => a.City)
                    .ThenInclude(c => c.Country)
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            var newCity = this.context.Cities.FirstOrDefault(c => c.Name == city);
            var newAddress = new Address 
            { 
                Id = new Guid(), 
                CreatedOn = DateTime.UtcNow, 
                City = newCity, 
                StreetName = streetName
            };

            customerToUpdate.Address = newAddress;
            this.context.SaveChanges();

            var dto = new CustomerDTO
            { 
               Id = customerToUpdate.Id,
               FirstName = customerToUpdate.FirstName,
               LastName = customerToUpdate.LastName,
               Email = customerToUpdate.Email,
               StreetName = customerToUpdate.Address.StreetName,
               City = customerToUpdate.Address.City.Name,
               Country = customerToUpdate.Address.City.Country.Name
            };

            return dto;
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

        public List<CustomerDTO> GetByMultipleCriteria(CustomerFilter customerFilter)  
        {
            var searchResult = this.context.Customers
                .Where(c => c.FirstName == customerFilter.FirstName
                || c.LastName == customerFilter.LastName
                || c.Email.Contains(customerFilter.Email))
                .Select(c => new CustomerDTO 
                {
                   Id = c.Id,
                   FirstName = c.FirstName,
                   LastName = c.LastName, 
                   Email = c.Email,
                   StreetName = c.Address.StreetName,
                   City = c.Address.City.Name,
                   Country = c.Address.City.Country.Name
                })
                .ToList();

            return searchResult;
        }

        public List<ParcelDTO> GetIncomingParcels(Guid id) // TODO: Method to check past parcels!!!!!!!!!
        {
            List<ParcelDTO> dto = this.context.Customers
                .Include(c => c.Parcels)
                   .ThenInclude(p => p.Shipment)
                     .ThenInclude(s => s.Status)
                .FirstOrDefault(c => c.Id == id).Parcels
                .Where(p => p.Shipment.Status.Name == "on the way" || p.Shipment.Status.Name == "preparing")
                .Select(c => new ParcelDTO { Id = c.Id })
                .ToList();

            return dto;
        }

        public CustomerDTO GetByKeyWord(string key)
        {
            var customer = this.context.Customers
                .Include(c => c.Address)
                  .ThenInclude(a => a.City)
                    .ThenInclude(c => c.Country)
                .FirstOrDefault(c => c.FirstName == key
                || c.LastName == key
                || c.Email == key);

            var dto = new CustomerDTO
            { 
               Id = customer.Id,
               FirstName = customer.FirstName,
               LastName = customer.LastName,
               Email = customer.Email,
               StreetName = customer.Address.StreetName,
               City = customer.Address.City.Name,
               Country = customer.Address.City.Country.Name
            };

            return dto;
        }
    }
}
/*
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
 */
