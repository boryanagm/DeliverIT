using Deliverit.Services.Contracts;
using DeliverIT.Models;
using System;

namespace Deliverit.Web.Helpers
{
    public class AuthHelper : IAuthHelper
    {
        private readonly ICustomerService customerService;
        private readonly IEmployeeService employeeService;

        public AuthHelper(ICustomerService customerService, IEmployeeService employeeService)
        {
            this.customerService = customerService;
            this.employeeService = employeeService;
        }
        public Customer TryGetCustomer(string authorizationHeader)
        {
            try
            {
                return this.customerService.GetByCustomerEmail(authorizationHeader);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid email");
            }
        }
        public Employee TryGetEmployee(string authorizationHeader)
        {
            try
            {
                return this.employeeService.GetByEmployeeEmail(authorizationHeader);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid email");
            }
        }
    }
}
