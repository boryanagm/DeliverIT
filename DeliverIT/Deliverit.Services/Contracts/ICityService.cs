using Deliverit.Models;
using System;
using System.Collections.Generic;

namespace Deliverit.Services.Contracts
{
    public interface ICityService
    {
        City Get(Guid id);
        IEnumerable<City> GetAll();
    }
}
