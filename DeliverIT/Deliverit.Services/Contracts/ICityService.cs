using Deliverit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Services.Contracts
{
    public interface ICityService
    {
        City Get(Guid id);
        IEnumerable<City> GetAll();
    }
}
