using Deliverit.Services;
using DeliverIT.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverit.Tests.ServicesTests
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void Should_Return_Customer_If_AuthorizationEmail_IsCorrect()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Should_Return_Customer_If_AuthorizationEmail_IsCorrect));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Customers.AddRange(Utils.GetCustomers());

                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(assertContext);

                //Act
                var actualResult = sut.GetByCustomerEmail("isabelle.huppert@gmail.com");

                //Assert
                var expectedResult = assertContext.Customers.FirstOrDefault(c => c.Email == "isabelle.huppert@gmail.com");

                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}
