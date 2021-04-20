using Deliverit.Services;
using Deliverit.Services.Models;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
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
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid categoryId = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137");
                Guid customerId = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                Guid parcelId = new Guid("198457ae-236c-4592-90af-3ca2302a8737");
                var parcelToUpdate = new UpdateParcelDTO
                {
                    Weight = 2,
                    CategoryId = categoryId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act
                var assertResult = sut.Update(parcelId, parcelToUpdate);

                //Assert
                var actualParcel = assertContext.Parcels.FirstOrDefault(p => p.Id == parcelId);
                Assert.AreEqual(actualParcel.Weight, parcelToUpdate.Weight);
                Assert.AreEqual(actualParcel.Shipment.Id, shipmentId);
            }
        }

        [TestMethod]
        public void Update_Should_Throw_When_Customer_Invalid()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Update_Should_Throw_When_Customer_Invalid));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid categoryId = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137");
                Guid customerId = new Guid("5a1206fe-fca4-4347-b1ea-118c55e17331");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                Guid parcelId = new Guid("198457ae-236c-4592-90af-3ca2302a8737");
                var parcelToUpdate = new UpdateParcelDTO
                {
                    Weight = 2,
                    CategoryId = categoryId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => sut.Update(parcelId, parcelToUpdate));
            }
        }
        [TestMethod]
        public void Update_Should_Throw_When_Category_Invalid()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Update_Should_Throw_When_Category_Invalid));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid categoryId = new Guid("12b0c76c-ab76-4105-be89-3af983f6f137");
                Guid customerId = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                Guid parcelId = new Guid("198457ae-236c-4592-90af-3ca2302a8737");
                var parcelToUpdate = new UpdateParcelDTO
                {
                    Weight = 2,
                    CategoryId = categoryId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => sut.Update(parcelId, parcelToUpdate));
            }
        }
        [TestMethod]
        public void Update_Should_Throw_When_Shipment_Invalid()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Update_Should_Throw_When_Shipment_Invalid));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {

                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid categoryId = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137");
                Guid customerId = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331");
                Guid shipmentId = new Guid("1e465c59-4866-4905-bdbd-943a26f59fdd");
                Guid parcelId = new Guid("198457ae-236c-4592-90af-3ca2302a8737");
                var parcelToUpdate = new UpdateParcelDTO
                {
                    Weight = 2,
                    CategoryId = categoryId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => sut.Update(parcelId, parcelToUpdate));
            }
        }
        [TestMethod]
        public void Update_Should_Throw_When_Parcel_Invalid()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Update_Should_Throw_When_Shipment_Invalid));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {

                var sut = new ParcelService(assertContext);
                var parcelCount = assertContext.Parcels.Count();
                Guid categoryId = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137");
                Guid customerId = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331");
                Guid shipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd");
                Guid parcelId = new Guid("195457ae-236c-4592-90af-3ca2302a8737");
                var parcelToUpdate = new UpdateParcelDTO
                {
                    Weight = 2,
                    CategoryId = categoryId,
                    CustomerId = customerId,
                    ShipmentId = shipmentId
                };

                //Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => sut.Update(parcelId, parcelToUpdate));
            }
        }
        [TestMethod]
        public void Delete_Should_Parcel()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Delete_Should_Parcel));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);

                Guid parcelId = new Guid("198457ae-236c-4592-90af-3ca2302a8737");

                //Act
                var assertResult = sut.Delete(parcelId);

                //Assert
                var resultParcel = assertContext.Parcels
                .IgnoreQueryFilters()
                .FirstOrDefault(e => e.Id == parcelId);

                Assert.AreEqual(resultParcel.IsDeleted, true);

            }
        }
        [TestMethod]
        public void Delete_Should_Throw_When_Invalid_Parcel()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Delete_Should_Throw_When_Invalid_Parcel));

            using (var arrangeContext = new DeliveritDbContext(options))
            {
                arrangeContext.Parcels.AddRange(Utils.GetParcels());
                arrangeContext.SaveChanges();
            }

            using (var assertContext = new DeliveritDbContext(options))
            {
                var sut = new ParcelService(assertContext);

                Guid parcelId = new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d");

                //Act & Assert
                Assert.ThrowsException<ArgumentNullException>(() => sut.Delete(parcelId));
            }
        }
        [TestMethod]
        public void Search_By_Email_Should()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Search_By_Email_Should));

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
                string email = "lukas.petr@gmail.com";
                var assertResult = sut.SearchByEmail(email);

                //Assert
                var actualResult = assertContext.Customers.Include(c => c.Parcels)
                .ThenInclude(c => c.Category)
                .Where(s => s.Email.Contains(email))
                .ToList();
                Assert.AreEqual(actualResult.Count, assertResult.Count);
            }
        }

        [TestMethod]
        public void Search_By_Name_Should()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Search_By_Name_Should));

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
                string firstName = "Lukas";
                string lastName = "Petrauskas";
                var assertResult = sut.SearchByName(firstName, lastName);

                //Assert
                var actualResult = assertContext.Customers.Include(c => c.Parcels)
                .ThenInclude(c => c.Category)
                .Where(s => s.LastName == lastName && s.FirstName == firstName)
                .ToList();
                Assert.AreEqual(actualResult.Count, assertResult.Count);
            }
        }
        [TestMethod]
        public void Search_By_Name_Should_When_Only_FirstName()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Search_By_Name_Should_When_Only_FirstName));

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
                string firstName = "Lukas";
                string lastName = null;
                var assertResult = sut.SearchByName(firstName, lastName);

                //Assert
                var actualResult = assertContext.Customers.Include(c => c.Parcels)
                .ThenInclude(c => c.Category)
                .Where(s => s.FirstName == firstName)
                .ToList();
                Assert.AreEqual(actualResult.Count, assertResult.Count);
            }
        }
        [TestMethod]
        public void Search_By_Name_Should_When_Only_LastName()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Search_By_Name_Should_When_Only_LastName));

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
                string firstName = null;
                string lastName = "Petrauskas";
                var assertResult = sut.SearchByName(firstName, lastName);

                //Assert
                var actualResult = assertContext.Customers.Include(c => c.Parcels)
                .ThenInclude(c => c.Category)
                .Where(s => s.LastName == lastName)
                .ToList();
                Assert.AreEqual(actualResult.Count, assertResult.Count);
            }
        }
    }
}

