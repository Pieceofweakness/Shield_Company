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
    public class AgentTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllAgents_ShouldReturnAllAgents()
        {
            // Act
            var agents = _db.GetAllAgents();

            // Assert
            Assert.IsNotNull(agents);
            Assert.AreEqual(2, agents.Count);
        }
        [TestMethod]
        public void GetAgentsByFilial_ShouldReturnAgentsForSpecificFilial()
        {
            // Act
            var agents = _db.GetAgentsByFilial(1);

            // Assert
            Assert.IsNotNull(agents);
            Assert.AreEqual(1, agents.Count);
            Assert.AreEqual("Петров Александр Васильевич", agents[0].FullName);
        }

        [TestMethod]
        public void GetAgentById_ShouldReturnCorrectAgent()
        {
            // Act
            var agent = _db.GetAgentById(1);

            // Assert
            Assert.IsNotNull(agent);
            Assert.AreEqual("Петров Александр Васильевич", agent.FullName);
            Assert.AreEqual(1, agent.ID_Filial);
            Assert.IsTrue(agent.IsActive);
        }

        [TestMethod]
        public void GetAgentById_InvalidId_ShouldReturnNull()
        {
            // Act
            var agent = _db.GetAgentById(999);

            // Assert
            Assert.IsNull(agent);
        }

        [TestMethod]
        public void AddAgent_ShouldAddNewAgent()
        {
            // Arrange
            var agent = new Agent
            {
                FullName = "Новый Агент",
                ID_Filial = 1,
                Phone = "+7(999)555-55-55",
                Passport = "9999 999999",
                Login = "newagent",
                Password = "newpass",
                IsActive = true
            };

            // Act
            bool result = _db.AddAgent(agent);
            var agents = _db.GetAllAgents();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(3, agents.Count);
        }

        [TestMethod]
        public void UpdateAgent_ShouldUpdateExistingAgent()
        {
            // Arrange
            var agent = _db.GetAgentById(1);
            agent.FullName = "Обновленный Агент";
            agent.Phone = "+7(999)000-00-00";

            // Act
            bool result = _db.UpdateAgent(agent);
            var updated = _db.GetAgentById(1);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Обновленный Агент", updated.FullName);
            Assert.AreEqual("+7(999)000-00-00", updated.Phone);
        }

        [TestMethod]
        public void SetAgentActiveStatus_ShouldChangeStatus()
        {
            // Act
            bool result1 = _db.SetAgentActiveStatus(1, false);
            var deactivated = _db.GetAgentById(1);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(deactivated.IsActive);

            // Act
            bool result2 = _db.SetAgentActiveStatus(1, true);
            var reactivated = _db.GetAgentById(1);

            // Assert
            Assert.IsTrue(result2);
            Assert.IsTrue(reactivated.IsActive);
        }





    }
}
