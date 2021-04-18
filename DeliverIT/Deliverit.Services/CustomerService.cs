using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Deliverit.Models.Authentication;
using Deliverit.Services.Mappers;

namespace Deliverit.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DeliveritDbContext context;

        public CustomerService(DeliveritDbContext context)
        {
            this.context = context;
        }

        public Customer GetByCustomerEmail(string customerEmail)
        {
           return this.context.Customers
                .FirstOrDefault(c => c.Email == customerEmail)
                ?? throw new ArgumentNullException();
        }

        public CustomerDTO Get(Guid id) 
        {
            var dto = this.context.Customers
               .Select(CustomerMapper.DTOSelector)
               .FirstOrDefault(c => c.Id == id)
               ?? throw new ArgumentNullException();

            return dto;
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (var customer in this.context.Customers
                .Include(c => c.Address)
                   .ThenInclude(a => a.City)
                      .ThenInclude(c => c.Country))
            {
                var dto = CustomerMapper.DTOSelector.Compile().Invoke(customer);
                customers.Add(dto);
            }
            return customers;
        }

        public int GetCount()
        {
            return this.context.Customers.Count();
        }

        public CustomerDTO Create(Customer customer)
        {
            this.context.Customers.Add(customer);
            customer.CreatedOn = DateTime.UtcNow;

            var customerRole = new CustomerRole()
            { 
               Id = Guid.NewGuid(),
               RoleId = Guid.Parse("2d598edd-793a-4324-ac29-c505a5c790a5"),
               CustomerId = customer.Id
            };

            this.context.SaveChanges();

            var dto = this.context.Customers
               .Select(CustomerMapper.DTOSelector)
               .FirstOrDefault(c => c.Id == customer.Id)
               ?? throw new ArgumentNullException();

            return dto;
        }

        public CustomerDTO Update(Guid id, Guid addressId) 
        {
            var customerToUpdate = this.context.Customers
                .FirstOrDefault(c => c.Id == id)
                ?? throw new ArgumentNullException();

            customerToUpdate.ModifiedOn = DateTime.UtcNow;
            customerToUpdate.AddressId = addressId;
            this.context.SaveChanges();

            customerToUpdate.Address = this.context.Addresses
               .Include(a => a.City)
                  .ThenInclude(c => c.Country)
               .FirstOrDefault(a => a.Id == addressId);

            var dto = CustomerMapper.DTOSelector.Compile().Invoke(customerToUpdate);

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
                .Select(CustomerMapper.DTOSelector)
                .ToList();

            return searchResult;
        }

        public List<ParcelDTO> GetIncomingParcels(Guid id) 
        {
            List<ParcelDTO> dto = this.context.Customers
                .Include(c => c.Parcels)
                   .ThenInclude(p => p.Shipment)
                     .ThenInclude(s => s.Status)
                .Include(c => c.Parcels)
                     .ThenInclude(c => c.Category)
                .FirstOrDefault(c => c.Id == id).Parcels
                .Where(p => p.Shipment.Status.Name == "on the way" || p.Shipment.Status.Name == "preparing")
                .Select(p => new ParcelDTO 
                {
                    Id = p.Id,
                    Weight = p.Weight,
                    Category = p.Category.Name,
                    CustomerFirstName = p.Customer.FirstName,
                    CustomerLastName = p.Customer.LastName
                })
                .ToList();

            return dto;
        }

        public List<ParcelDTO> GetPastParcels(Guid id)  
        {
            List<ParcelDTO> dto = this.context.Customers
                .Include(c => c.Parcels)
                   .ThenInclude(p => p.Shipment)
                     .ThenInclude(s => s.Status)
                .Include(c => c.Parcels)
                     .ThenInclude(c => c.Category)
                .FirstOrDefault(c => c.Id == id).Parcels
                .Where(p => p.Shipment.Status.Name == "completed" || p.Shipment.Status.Name == "canceled")
                 .Select(p => new ParcelDTO
                 {
                     Id = p.Id,
                     Weight = p.Weight,
                     Category = p.Category.Name,
                     CustomerFirstName = p.Customer.FirstName,
                     CustomerLastName = p.Customer.LastName
                 })
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

            var dto = CustomerMapper.DTOSelector.Compile().Invoke(customer);

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
