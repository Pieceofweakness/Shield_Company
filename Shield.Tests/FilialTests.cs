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
    public class FilialTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllFilials_ShouldReturnFilialsList()
        {
            // Act
            var filials = _db.GetAllFilials();

            // Assert
            Assert.IsNotNull(filials);
            Assert.AreEqual(2, filials.Count);
        }

        [TestMethod]
        public void GetFilialById_ShouldReturnCorrectFilial()
        {
            // Act
            var filial = _db.GetFilialById(1);

            // Assert
            Assert.IsNotNull(filial);
            Assert.AreEqual("Центральный", filial.NameFilial);
            Assert.AreEqual("г. Красноярск, ул. Мира, 1", filial.Address);
        }

        [TestMethod]
        public void GetFilialById_InvalidId_ShouldReturnNull()
        {
            // Act
            var filial = _db.GetFilialById(999);

            // Assert
            Assert.IsNull(filial);
        }

        [TestMethod]
        public void AddFilial_ShouldAddNewFilial()
        {
            // Arrange
            var filial = new Filial
            {
                NameFilial = "Новый филиал",
                Address = "г. Красноярск, ул. Новая, 10",
                Phone = "+7(391)888-88-88"
            };

            // Act
            bool result = _db.AddFilial(filial);
            var filials = _db.GetAllFilials();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(3, filials.Count);
            Assert.AreEqual("Новый филиал", filials.Last().NameFilial);
        }





    }
}
