using Deliverit.Services.Contracts;
using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverit.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DeliveritDbContext context;

        public EmployeeService(DeliveritDbContext context)
        {
            this.context = context;
        }
        public EmployeeDTO Get(Guid id) 
        {
            var dto = this.context.Employees
              .Select(e => new EmployeeDTO
              {
                  Id = e.Id,
                  FirstName = e.FirstName,
                  LastName = e.LastName,
                  Email = e.Email,
                  StreetName = e.Address.StreetName,
                  City = e.Address.City.Name,
                  Country = e.Address.City.Country.Name,
                  Parcels = e.Parcels.Select(p => p.Id).ToList()
              })
              .FirstOrDefault(e => e.Id == id)
              ?? throw new ArgumentNullException();

            return dto;
        }

        public IEnumerable<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            foreach (var employee in this.context.Employees
                .Include(e => e.Parcels)
                .Include(e => e.Address)
                  .ThenInclude(a => a.City)
                    .ThenInclude(c => c.Country))
            {
                var dto = new EmployeeDTO
                {
                    Id = employee.Id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    StreetName = employee.Address.StreetName,
                    City = employee.Address.City.Name,
                    Country = employee.Address.City.Country.Name,
                    Parcels = employee.Parcels.Select(p => p.Id).ToList()
                };
                employees.Add(dto);
            }

            return employees;
        }
        public Employee Create(Employee employee)
        {
            this.context.Employees.Add(employee);
            employee.CreatedOn = DateTime.UtcNow;
            this.context.SaveChanges();

            return employee;
        }
       
        public EmployeeDTO Update(Guid id, string streetName, string city)
        {
            var employeeToUpdate = this.context.Employees
               .Include(e => e.Parcels)
               .Include(e => e.Address)
                 .ThenInclude(a => a.City)
                   .ThenInclude(c => c.Country)
               .FirstOrDefault(e => e.Id == id)
               ?? throw new ArgumentNullException();

            var newCity = this.context.Cities.FirstOrDefault(c => c.Name == city);
            var newAddress = new Address
            {
                Id = new Guid(),
                CreatedOn = DateTime.UtcNow,
                City = newCity,
                StreetName = streetName
            };

            employeeToUpdate.Address = newAddress;
            this.context.SaveChanges();

            var dto = new EmployeeDTO
            {
                Id = employeeToUpdate.Id,
                FirstName = employeeToUpdate.FirstName,
                LastName = employeeToUpdate.LastName,
                Email = employeeToUpdate.Email,
                StreetName = employeeToUpdate.Address.StreetName,
                City = employeeToUpdate.Address.City.Name,
                Country = employeeToUpdate.Address.City.Country.Name,
                Parcels = employeeToUpdate.Parcels.Select(p => p.Id).ToList()
            };

            return dto;
        }
        public bool Delete(Guid id)
        {
            var employee = this.context.Employees
                .FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                employee.DeletedOn = DateTime.UtcNow;
                employee.IsDeleted = true;
                this.context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
