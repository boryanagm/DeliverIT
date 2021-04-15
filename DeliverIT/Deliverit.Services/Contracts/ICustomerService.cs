﻿using Deliverit.Services.Models;
using DeliverIT.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface ICustomerService
    {
        Customer Get(Guid id);
        IEnumerable<Customer> GetAll();
        Customer Create(Customer customer);
        Customer Update(Guid id, string streetName, string city); // Guid id, Customer customer
        bool Delete(Guid id);
        List<ParcelDTO> GetIncomingParcels(Guid id);
        List<CustomerDTO> GetByMultipleCriteria(CustomerFilter customerFilter);  
        Customer GetByKeyWord(string key);
    }
}
