using Deliverit.Services;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Deliverit.Tests.ServicesTests
{
    [TestClass]
    public class WarehouseServiceTests
    {
        [TestMethod]
        public void Get_By_Should_Return_Correct_Warehouse()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_By_Should_Return_Correct_Warehouse));

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
                var expectedResult = assertContext.Warehouses
                    .Include(w => w.Address)
                       .ThenInclude(a => a.City)
                          .ThenInclude(c => c.Country)
                    .FirstOrDefault(w => w.Id == Guid.Parse("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"));

                Assert.AreEqual(expectedResult.Id, actualResult.Id);
                Assert.AreEqual(expectedResult.Address.StreetName, actualResult.StreetName);
                Assert.AreEqual(expectedResult.Address.City.Name, actualResult.City);
                Assert.AreEqual(expectedResult.Address.City.Country.Name, actualResult.Country);
            }
        }

        [TestMethod]
        public void Throw_When_Warehouse_NotFound()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Throw_When_Warehouse_NotFound));

            //Act & Assert
            using (var context = new DeliveritDbContext(options))
            {
                var sut = new WarehouseService(context);

                Assert.ThrowsException<ArgumentNullException>(() => sut.Get(Guid.Parse("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba")));
            }
        }

        [TestMethod]
        public void Get_Should_Return_All_Warehouses()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Warehouses));

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
                var actualResult = sut.GetAll().ToList();
                int actualWarehousesCount = actualResult.Count();
                var firstWarehouseInActualList = actualResult.FirstOrDefault();
                var lastWarehouseInActualList = actualResult.Last();

                //Assert
                var expectedResult = assertContext.Warehouses.ToList();
                int expectedWarehousesCount = expectedResult.Count();
                var firstWarehouseInExpectedList = expectedResult.FirstOrDefault();
                var lastWarehouseInExpectedList = expectedResult.Last();

                Assert.AreEqual(expectedWarehousesCount, actualWarehousesCount);
                Assert.AreEqual(firstWarehouseInExpectedList.Id, firstWarehouseInActualList.Id);
                Assert.AreEqual(firstWarehouseInExpectedList.Address.StreetName, firstWarehouseInActualList.StreetName);
                Assert.AreEqual(lastWarehouseInExpectedList.Address.City.Name, lastWarehouseInActualList.City);
                Assert.AreEqual(lastWarehouseInExpectedList.Address.City.Country.Name, lastWarehouseInActualList.Country);
            }
        }
    }
}
