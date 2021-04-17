using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface IEmployeeService
    {
        Employee GetByEmployeeEmail(string employeeEmail);
        Employee GetByAdminEmail(string adminEmail);
        EmployeeDTO Get(Guid id);
        IEnumerable<EmployeeDTO> GetAll();
        Employee Create(Employee employee);
        EmployeeDTO Update(Guid id, string streetName, string city);
        bool Delete(Guid id);
    }
}
