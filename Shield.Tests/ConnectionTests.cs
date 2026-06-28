using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shield.Tests.Helpers;

namespace Shield.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void TestConnection_ShouldReturnTrue()
        {
            // Arrange
            var db = new FakeDataBaseAdapter();

            // Act
            bool result = db.TestConnection();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
