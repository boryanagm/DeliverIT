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
        Customer Update(Guid id, Customer customer);
        bool Delete(Guid id);
        Customer GetByEmail(string email);
        Customer GetByFirstName(string firstName);
        Customer GetByLastName(string lastName);
        IEnumerable<Parcel> GetIncomingParcels(string email);
        Customer GetByMultipleCriteria();

        //  Search all fields from one word (e.g., “john” will search in the email, first and last name fields) (could)
        Customer GetByKeyWord(string key);
    }
}
