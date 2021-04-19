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
                var result = sut.Get(Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"));

                //Assert
                var expectedResult = assertContext.Cities.FirstOrDefault(c => c.Id == Guid.Parse("e99abf10-63e9-4212-9053-87cb1d80763e"));
                Assert.AreEqual(expectedResult.Name, result.Name);
                Assert.AreEqual(expectedResult.Id, result.Id);
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
                var result = sut.GetAll();

                //Assert
                // assert collection count
                // assert first entity
                // assert last entity
            }
        }
    }
}
