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
    public class ClientTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllClients_ShouldReturnClientsList()
        {
            // Act
            var clients = _db.GetAllClients();

            // Assert
            Assert.IsNotNull(clients);
            Assert.AreEqual(2, clients.Count);
        }

        [TestMethod]
        public void GetClientById_ShouldReturnCorrectClient()
        {
            // Act
            var client = _db.GetClientById(1);

            // Assert
            Assert.IsNotNull(client);
            Assert.AreEqual("Иванов Иван Петрович", client.FullName);
            Assert.AreEqual("1111 222233", client.Passport);
        }

        [TestMethod]
        public void GetClientById_InvalidId_ShouldReturnNull()
        {
            // Act
            var client = _db.GetClientById(999);

            // Assert
            Assert.IsNull(client);
        }

        [TestMethod]
        public void AddClient_ShouldAddNewClient()
        {
            // Arrange
            var client = new Client
            {
                FullName = "Новый Клиент",
                Passport = "8888 888888",
                Phone = "+7(999)666-66-66",
                Login = "newclient",
                Password = "client123"
            };

            // Act
            bool result = _db.AddClient(client);
            var clients = _db.GetAllClients();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(3, clients.Count);
        }

        [TestMethod]
        public void UpdateClient_ShouldUpdateExistingClient()
        {
            // Arrange
            var client = _db.GetClientById(1);
            client.FullName = "Обновленный Клиент";
            client.Phone = "+7(999)111-11-11";

            // Act
            bool result = _db.UpdateClient(client);
            var updated = _db.GetClientById(1);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Обновленный Клиент", updated.FullName);
            Assert.AreEqual("+7(999)111-11-11", updated.Phone);
        }




    }
}
