using Deliverit.Services.Contracts;
using DeliverIT.Database;
using DeliverIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverit.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DeliveritDbContext context;

        public EmployeeService(DeliveritDbContext context)
        {
            this.context = context;
        }
        public Employee Get(Guid id)
        {
            var employee = this.context.Employees
                .FirstOrDefault(e => e.Id == id)
                ?? throw new ArgumentNullException();

            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = this.context.Employees;
            return employees;
        }
        public Employee Create(Employee employee)
        {
            employee.CreatedOn = DateTime.UtcNow;

            this.context.Employees.Add(employee);
            this.context.SaveChanges();

            return employee;
        }
       
        public Employee Update(Guid id, string streetName, string city)
        {
            var employeeToUpdate = this.context.Employees
               .FirstOrDefault(e => e.Id == id)
               ?? throw new ArgumentNullException();

            employeeToUpdate.Address.StreetName = streetName;
            employeeToUpdate.Address.City = this.context.Cities
                .FirstOrDefault(c => c.Name == city); // Throw exception if city doesn't exist?

            this.context.SaveChanges();

            return employeeToUpdate;
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
