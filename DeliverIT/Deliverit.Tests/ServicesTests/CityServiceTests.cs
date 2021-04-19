using Deliverit.Services;
using DeliverIT.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Deliverit.Tests
{
    [TestClass]
    public class CityServiceTests
    {
        [TestMethod]
        public void Get_By_Should_Return_Correct_Entity()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_By_Should_Return_Correct_Entity));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Cities.AddRange(Utils.GetCities());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CityService(assertContext);

                //Act
                var actualResult = sut.Get(Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"));

                //Assert
                var expectedResult = assertContext.Cities.FirstOrDefault(c => c.Id == Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"));
                Assert.AreEqual(expectedResult.Id, actualResult.Id);
                Assert.AreEqual(expectedResult.Name, actualResult.Name);
            }
        }

        [TestMethod]
        public void Get_Should_Return_All_Cities()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Cities));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Cities.AddRange(Utils.GetCities());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new CityService(assertContext);

                //Act
                var actualResult = sut.GetAll().ToList();
                int actualCitiesCount = actualResult.Count();
                var firstCityInActualList = actualResult.First();
                var lastCityInActualList = actualResult.Last();

                //Assert
                var expectedResult = assertContext.Cities.ToList();
                int expectedCitiesCount = expectedResult.Count();
                var firstCityInExpectedList = expectedResult.First();
                var lastCityInExpectedList = expectedResult.Last();

                Assert.AreEqual(expectedCitiesCount, actualCitiesCount);
                Assert.AreEqual(firstCityInExpectedList.Id, firstCityInActualList.Id);
                Assert.AreEqual(firstCityInExpectedList.Name, firstCityInActualList.Name);
                Assert.AreEqual(lastCityInExpectedList.Id, lastCityInActualList.Id);
                Assert.AreEqual(lastCityInExpectedList.Name, lastCityInActualList.Name);
            }
        }
    }
}
