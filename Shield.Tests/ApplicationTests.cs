using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shield;
using Shield.Tests.Helpers;
using Shiled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shield.Tests
{
    [TestClass]
    public class ApplicationTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllApplications_ShouldReturnApplicationsList()
        {
            // Act
            var apps = _db.GetAllApplications();

            // Assert
            Assert.IsNotNull(apps);
            Assert.AreEqual(1, apps.Count);
        }

        [TestMethod]
        public void GetApplicationsByFilial_ShouldReturnApplicationsForFilial()
        {
            // Act
            var apps = _db.GetApplicationsByFilial(1);

            // Assert
            Assert.IsNotNull(apps);
            Assert.AreEqual(1, apps.Count);
            Assert.AreEqual("Новая", apps[0].Status);
        }

        [TestMethod]
        public void GetApplicationsByClient_ShouldReturnApplicationsForClient()
        {
            // Act
            var apps = _db.GetApplicationsByClient(1);

            // Assert
            Assert.IsNotNull(apps);
            Assert.AreEqual(1, apps.Count);
            Assert.AreEqual("Иванов Иван Петрович", apps[0].ClientName);
        }

        [TestMethod]
        public void GetApplicationById_ShouldReturnCorrectApplication()
        {
            // Act
            var app = _db.GetApplicationById(1);

            // Assert
            Assert.IsNotNull(app);
            Assert.AreEqual(1, app.ID_Client);
            Assert.AreEqual(300000m, app.InsuranceSum);
            Assert.AreEqual("Новая", app.Status);
        }

        [TestMethod]
        public void GetApplicationById_InvalidId_ShouldReturnNull()
        {
            // Act
            var app = _db.GetApplicationById(999);

            // Assert
            Assert.IsNull(app);
        }

        [TestMethod]
        public void AddApplication_ShouldAddNewApplication()
        {
            // Arrange
            var app = new Aplication
            {
                ID_Client = 1,
                ID_Insurance = 1,
                ID_Filial = 1,
                InsuranceSum = 1000000m,
                Discription = "Новая заявка на автострахование"
            };

            // Act
            bool result = _db.AddApplication(app);
            var apps = _db.GetAllApplications();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(2, apps.Count);
            Assert.AreEqual("Новая", apps.Last().Status);
        }

        [TestMethod]
        public void UpdateApplicationStatus_ShouldUpdateStatus()
        {
            // Act
            bool result = _db.UpdateApplicationStatus(1, "Принята");
            var app = _db.GetApplicationById(1);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Принята", app.Status);
        }

        [TestMethod]
        public void UpdateApplicationStatus_InvalidId_ShouldReturnFalse()
        {
            // Act
            bool result = _db.UpdateApplicationStatus(999, "Принята");

            // Assert
            Assert.IsFalse(result);
        }
    }
}
