using Deliverit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Contracts
{
    public interface ICountryService
    {
        Country Get(Guid id);
        IEnumerable<Country> GetAll();
    }
}
