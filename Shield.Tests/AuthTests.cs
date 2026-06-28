using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shield.Tests.Helpers;

namespace Shield.Tests
{
    [TestClass]
    public class AuthTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void AuthenticateUser_Admin_ShouldReturnAdminRole()
        {
            // Act
            var user = _db.AuthenticateUser("admin", "admin123");

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual("Admin", user.Role);
            Assert.AreEqual("Администратор Системы", user.FullName);
        }

        [TestMethod]
        public void AuthenticateUser_Agent_ShouldReturnAgentRole()
        {
            // Act
            var user = _db.AuthenticateUser("agent1", "agent123");

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual("Agent", user.Role);
            Assert.AreEqual("Петров Александр Васильевич", user.FullName);
            Assert.AreEqual(1, user.FilialId);
        }

        [TestMethod]
        public void AuthenticateUser_Client_ShouldReturnClientRole()
        {
            // Act
            var user = _db.AuthenticateUser("client1", "client123");

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual("Client", user.Role);
            Assert.AreEqual("Иванов Иван Петрович", user.FullName);
        }

        [TestMethod]
        public void AuthenticateUser_InvalidCredentials_ShouldReturnNull()
        {
            // Act
            var user = _db.AuthenticateUser("wrong", "wrong");

            // Assert
            Assert.IsNull(user);
        }

        [TestMethod]
        public void AuthenticateUser_InactiveAgent_ShouldReturnNull()
        {
            // Arrange
            _db.SetAgentActiveStatus(1, false);

            // Act
            var user = _db.AuthenticateUser("agent1", "agent123");

            // Assert
            Assert.IsNull(user);
        }
    }
}
