﻿using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface IEmployeeService
    {
        EmployeeDTO Get(Guid id);
        IEnumerable<EmployeeDTO> GetAll();
        Employee Create(Employee employee);
        Employee Update(Guid id, string streetName, string city);
        bool Delete(Guid id);
    }
}
