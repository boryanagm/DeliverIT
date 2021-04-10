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

        //  Search by email (full or part of an email) (must) 
        Customer GetByEmail(string email);

        //  Search by first/last name (must)
        Customer GetByFirstName(string firstName);
        Customer GetByLastName(string lastName);

        //  Query customer’s incoming parcels (should)
        IEnumerable<Parcel> ListIncomingParcels();

        //  Search by multiple criteria (should)
        Customer GetByMultipleCriteria();

        //  Search all fields from one word (e.g., “john” will search in the email, first and last name fields) (could)
        Customer GetByKeyWord(string key);
    }
}
