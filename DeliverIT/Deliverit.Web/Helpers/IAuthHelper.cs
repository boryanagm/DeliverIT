using DeliverIT.Models;

namespace Deliverit.Web.Helpers
{
    public interface IAuthHelper
    {
        Customer TryGetCustomer(string authorizationHeader);
        Employee TryGetEmployee(string authorizationHeader);
    }
}
