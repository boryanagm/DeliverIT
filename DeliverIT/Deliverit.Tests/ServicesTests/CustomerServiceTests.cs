using Deliverit.Services;
using DeliverIT.Database;
using DeliverIT.Models;
using Microsoft.EntityFrameworkCore;
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

        [TestMethod]
        public void Should_Throw_Expception_When_Customer_NotFound()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Should_Throw_Expception_When_Customer_NotFound));

            //Act & Assert
            using (var context = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(context);

                Assert.ThrowsException<ArgumentNullException>(() => sut.GetByCustomerEmail("notfound@abv.bg"));
            }
        }

        [TestMethod]
        public void Get_By_Should_Return_Correct_Customer()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_By_Should_Return_Correct_Customer));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.Addresses.AddRange(Utils.GetAddresses());
                arrangeContext.Cities.AddRange(Utils.GetCities());
                arrangeContext.Countries.AddRange(Utils.GetCountries());

                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(assertContext);

                //Act
                var actualResult = sut.Get(Guid.Parse("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"));

                //Assert
                var expectedResult = assertContext.Customers
                    .Include(c => c.Address)
                       .ThenInclude(a => a.City)
                          .ThenInclude(c => c.Country)
                    .FirstOrDefault(w => w.Id == Guid.Parse("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"));

                Assert.AreEqual(expectedResult.Id, actualResult.Id);
                Assert.AreEqual(expectedResult.FirstName, actualResult.FirstName);
                Assert.AreEqual(expectedResult.LastName, actualResult.LastName);
                Assert.AreEqual(expectedResult.Email, actualResult.Email);
                Assert.AreEqual(expectedResult.Address.StreetName, actualResult.StreetName);
                Assert.AreEqual(expectedResult.Address.City.Name, actualResult.City);
                Assert.AreEqual(expectedResult.Address.City.Country.Name, actualResult.Country);
            }
        }

        [TestMethod]
        public void Throw_When_Customer_NotFound()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Throw_When_Customer_NotFound));

            //Act & Assert
            using (var context = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(context);

                Assert.ThrowsException<ArgumentNullException>(() => sut.Get(Guid.Parse("e6d2c0f7-cffb-4155-8a13-5976136cd4db")));
            }
        }

        [TestMethod]
        public void Get_Should_Return_All_Customers()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Customers));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.Addresses.AddRange(Utils.GetAddresses());
                arrangeContext.Cities.AddRange(Utils.GetCities());
                arrangeContext.Countries.AddRange(Utils.GetCountries());

                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(assertContext);

                //Act
                var actualResult = sut.GetAll().ToList();
                int actualCustomersCount = actualResult.Count();
                var firstCustomerInActualList = actualResult.FirstOrDefault();
                var lastCustomerInActualList = actualResult.Last();

                //Assert
                var expectedResult = assertContext.Customers.ToList();
                int expectedCustomersCount = expectedResult.Count();
                var firstCustomerInExpectedList = expectedResult.FirstOrDefault();
                var lastCustomerInExpectedList = expectedResult.Last();

                Assert.AreEqual(expectedCustomersCount, actualCustomersCount);
                Assert.AreEqual(firstCustomerInExpectedList.Id, firstCustomerInActualList.Id);
                Assert.AreEqual(firstCustomerInExpectedList.FirstName, firstCustomerInActualList.FirstName);
                Assert.AreEqual(lastCustomerInExpectedList.Id, lastCustomerInActualList.Id);
                Assert.AreEqual(lastCustomerInExpectedList.FirstName, lastCustomerInActualList.FirstName);
            }
        }

        [TestMethod]
        public void Should_Return_CustomersCount()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Should_Return_CustomersCount));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(assertContext);

                //Act
                var actualResult = sut.GetCount();

                //Assert
                var expectedResult = assertContext.Customers.Count();
                
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [TestMethod]
        public void Should_Create_New_Customer()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Should_Create_New_Customer));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CustomerService(assertContext);

                //Act
                var customerToCreate = new Customer()
                {
                    Id = Guid.Parse("ed15cc44-60a9-476d-9ad7-f694a6eb1aef"),
                    FirstName = "Enrique",
                    LastName = "Pastor",
                    Email = "enriquete@gmail.com",
                    AddressId = Guid.Parse("da703902-00bc-47da-b950-4fa730494d4e")
                };

                int customersCount = assertContext.Customers.Count();
                var createdCustomer = sut.Create(customerToCreate);

                //Assert
                int expectedCustomersCount = customersCount + 1;
                int actualCustomersCount = assertContext.Customers.Count();

                Assert.AreEqual(expectedCustomersCount, actualCustomersCount);
            }
        }
    }
}
