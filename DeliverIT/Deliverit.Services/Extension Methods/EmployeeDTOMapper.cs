using Deliverit.Services.Models;
using DeliverIT.Database;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Deliverit.Services.Extension_Methods
{
    public static class EmployeeDTOMapper
    {
        public static EmployeeDTO MapEmployeeDTO(this Employee employee)
        {
            return  new EmployeeDTO()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                StreetName = employee.Address.StreetName,
                City = employee.Address.City.Name,
                Country = employee.Address.City.Country.Name,
                Parcels = employee.Parcels.Select(p => p.Id).ToList()
            };
        }
    }
}
