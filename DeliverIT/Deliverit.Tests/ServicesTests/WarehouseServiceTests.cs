using Deliverit.Services;
using DeliverIT.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Deliverit.Tests.ServicesTests
{
    [TestClass]
    public class WarehouseServiceTests
    {
        [TestMethod]
        public void Get_By_Should_Return_Correct_Entity()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_By_Should_Return_Correct_Entity));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Warehouses.AddRange(Utils.GetWarehouses());
                arrangeContext.Addresses.AddRange(Utils.GetAddresses());
                arrangeContext.Cities.AddRange(Utils.GetCities());
                arrangeContext.Countries.AddRange(Utils.GetCountries());

                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new WarehouseService(assertContext);

                //Act
                var actualResult = sut.Get(Guid.Parse("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"));

                //Assert
                var expectedResult = assertContext.Warehouses.FirstOrDefault(w => w.Id == Guid.Parse("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"));
                Assert.AreEqual(expectedResult.Id, actualResult.Id);
                Assert.AreEqual(expectedResult.Address.StreetName, actualResult.StreetName);
                Assert.AreEqual(expectedResult.Address.City.Name, actualResult.City);
                Assert.AreEqual(expectedResult.Address.City.Country.Name, actualResult.Country);
            }
        }
    }
}
