using Deliverit.Services;
using DeliverIT.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace Deliverit.Tests
{
    [TestClass]
    public class ParcelServiceTests
    {
        [TestMethod]
        public void Get_By_Should_Return_Correct_Parcel()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_By_Should_Return_Correct_Parcel));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.Categories.AddRange(Utils.GetCategories());
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);

                //Act
                var actualResult = sut.Get(Guid.Parse("198457ae-236c-4592-90af-3ca2302a8737"));

                //Assert
                var expectedResult = assertContext.Parcels.FirstOrDefault(c => c.Id == Guid.Parse("198457ae-236c-4592-90af-3ca2302a8737"));
                Assert.AreEqual(expectedResult.Id, actualResult.Id);
                Assert.AreEqual(expectedResult.Weight, actualResult.Weight);
            }
        }

        [TestMethod]
        public void Throw_When_Parcel_NotFound()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Throw_When_Parcel_NotFound));

            //Act & Assert
            using (var context = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(context);

                Assert.ThrowsException<ArgumentNullException>(() => sut.Get(Guid.Parse("37637c27-cdc5-4f87-8854-9a6e5e43b8cd")));
            }
        }

        [TestMethod]
        public void Get_Should_Return_All_Parcels()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Parcels));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.Categories.AddRange(Utils.GetCategories());
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);

                //Act
                var actualResult = sut.GetAll();
                int actualParcelCount = actualResult.Count();

                //Assert
                var expectedResult = assertContext.Countries;
                int expectedParcelCount = expectedResult.Count();

                Assert.AreEqual(expectedParcelCount, actualParcelCount);
            }
        }
    }
}
