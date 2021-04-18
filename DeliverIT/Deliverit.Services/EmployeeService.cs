﻿using Deliverit.Models.Authentication;
using Deliverit.Services.Contracts;
using Deliverit.Services.Extension_Methods;
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
        public Employee GetByEmployeeEmail(string employeeEmail)
        {
            return this.context.Employees
                 .FirstOrDefault(e => e.Email == employeeEmail)
                 ?? throw new ArgumentNullException();
        }

        public Employee GetByAdminEmail(string adminEmail)
        {
            var employeeRole = this.context.Employees
                  .Include(e => e.Roles)
                     .ThenInclude(r => r.Role)
                  .FirstOrDefault(e => e.Email == adminEmail && e.Roles.Any(r => r.Role.Name == "Admin"))
                  ?? throw new ArgumentNullException();

            return employeeRole;
        }

        public EmployeeDTO Get(Guid id)
        {
            //var dto = this.context.Employees
            //       .Select(e => e.ToEmployeeDTO())
            //       .FirstOrDefault(e => e.Id == id)
            //       ?? throw new ArgumentNullException();

            var dto = this.context.Employees
               //.Include(e => e.Parcels)
               // .Include(e => e.Address)
               //   .ThenInclude(a => a.City)
               //     .ThenInclude(c => c.Country)
              .Select(EmployeeMapper.DTOSelector)
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

                var dto = EmployeeMapper.DTOSelector.Compile().Invoke(employee);     // Also works EmployeeMapper.DTOSelector.Compile()(employee);
                                                                                     // Compile() is needed because of Expression<Func<>>  
                                                                                     // Check with: var dto = employee.ToEmployeeDTO(); - not working

                employees.Add(dto);
            }

            return employees;
        }
        public EmployeeDTO Create(Employee employee)
        {
            this.context.Employees.Add(employee);
            employee.CreatedOn = DateTime.UtcNow;

            var employeeRole = new EmployeeRole()
            {
                Id = Guid.NewGuid(),
                RoleId = Guid.Parse("275a10a1-e965-460e-a965-e1fe2453e916"),
                EmployeeId = employee.Id
            };

            this.context.SaveChanges();

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
              .FirstOrDefault(c => c.Id == employee.Id)
              ?? throw new ArgumentNullException();

            return dto;
        }

        public EmployeeDTO Update(Guid id, Guid addressId)
        {
            var employeeToUpdate = this.context.Employees
               .Include(e => e.Parcels)
               .FirstOrDefault(e => e.Id == id)
               ?? throw new ArgumentNullException();

            employeeToUpdate.ModifiedOn = DateTime.UtcNow;
            employeeToUpdate.AddressId = addressId;
            this.context.SaveChanges();

            employeeToUpdate.Address = this.context.Addresses
               .Include(a => a.City)
                  .ThenInclude(c => c.Country)
               .FirstOrDefault(a => a.Id == addressId);

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

        public EmployeeDTO Restore(Guid id) 
        {
            var employeeToRestore = this.context.Employees
                .IgnoreQueryFilters()
                .FirstOrDefault(e => e.Id == id); 

            employeeToRestore.IsDeleted = false;
            this.context.SaveChanges();

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
              .FirstOrDefault(c => c.Id == employeeToRestore.Id)
              ?? throw new ArgumentNullException();

            return dto;
        }
    }
}
