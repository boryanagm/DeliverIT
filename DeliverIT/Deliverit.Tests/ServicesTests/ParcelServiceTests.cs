using Deliverit.Services;
using Deliverit.Services.Models;
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
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);

                //Act
                var actualResult = sut.GetAll();
                int actualParcelCount = actualResult.Count();

                //Assert
                var expectedResult = assertContext.Parcels.Count();

                Assert.AreEqual(expectedResult, actualParcelCount);
            }
        }

        [TestMethod]
        public void Create_Should_Add_Parcel()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Parcels));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Shipments.AddRange(Utils.GetShipments());
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.Categories.AddRange(Utils.GetCategories());
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid employeeId = new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d");
                Guid customerId = new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                var parcelToCreate = new CreateParcelDTO
                {
                    Weight = 2,
                    CategoryName = "Electronics",
                    EmployeeId = employeeId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act
                var assertResult = sut.Create(parcelToCreate);
                var expectedResult = parcelCount + 1;

                //Assert
                var actualParcelCount = assertContext.Parcels.Count();
                Assert.AreEqual(expectedResult, actualParcelCount);
            }
        }

        [TestMethod]
        public void Update_Should_Parcel()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Get_Should_Return_All_Parcels));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Shipments.AddRange(Utils.GetShipments());
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.Categories.AddRange(Utils.GetCategories());
                arrangeContext.Customers.AddRange(Utils.GetCustomers());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid employeeId = new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d");
                Guid customerId = new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                var parcelToCreate = new CreateParcelDTO
                {
                    Weight = 2,
                    CategoryName = "Electronics",
                    EmployeeId = employeeId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act
                var assertResult = sut.Create(parcelToCreate);
                var expectedResult = parcelCount + 1;

                //Assert
                var actualParcelCount = assertContext.Parcels.Count();
                Assert.AreEqual(expectedResult, actualParcelCount);
            }
        }
    }
}
