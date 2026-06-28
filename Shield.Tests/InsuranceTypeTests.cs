using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class InsuranceTypeTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllInsuranceTypes_ShouldReturnInsuranceTypesList()
        {
            // Act
            var types = _db.GetAllInsuranceTypes();

            // Assert
            Assert.IsNotNull(types);
            Assert.AreEqual(3, types.Count);
        }

        [TestMethod]
        public void GetInsuranceTypeById_ShouldReturnCorrectType()
        {
            // Act
            var type = _db.GetInsuranceTypeById(1);

            // Assert
            Assert.IsNotNull(type);
            Assert.AreEqual("Автострахование", type.InsuranceName);
            Assert.AreEqual(5.5m, type.BaseTariff);
        }

        [TestMethod]
        public void GetInsuranceTypeById_InvalidId_ShouldReturnNull()
        {
            // Act
            var type = _db.GetInsuranceTypeById(999);

            // Assert
            Assert.IsNull(type);
        }

        [TestMethod]
        public void AddInsuranceType_ShouldAddNewType()
        {
            // Arrange
            var type = new InsuranceType
            {
                InsuranceName = "Страхование путешествий",
                BaseTariff = 4.0m,
                Discription = "Страхование туристов"
            };

            // Act
            bool result = _db.AddInsuranceType(type);
            var types = _db.GetAllInsuranceTypes();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(4, types.Count);
            Assert.AreEqual("Страхование путешествий", types.Last().InsuranceName);
        }

        [TestMethod]
        public void UpdateInsuranceType_ShouldUpdateExistingType()
        {
            // Arrange
            var type = _db.GetInsuranceTypeById(1);
            type.InsuranceName = "Обновленное страхование";
            type.BaseTariff = 6.0m;

            // Act
            bool result = _db.UpdateInsuranceType(type);
            var updated = _db.GetInsuranceTypeById(1);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Обновленное страхование", updated.InsuranceName);
            Assert.AreEqual(6.0m, updated.BaseTariff);
        }





    }
}
