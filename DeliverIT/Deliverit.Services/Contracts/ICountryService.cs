using Deliverit.Services.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface ICountryService
    {
        CountryDTO Get(Guid id);
        IEnumerable<CountryDTO> GetAll();
    }
}
