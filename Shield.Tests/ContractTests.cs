using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shield.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shield;

namespace Shield.Tests
{
    [TestClass]
    public class ContractTests
    {
        private FakeDataBaseAdapter _db;

        [TestInitialize]
        public void Setup()
        {
            _db = new FakeDataBaseAdapter();
        }

        [TestMethod]
        public void GetAllContracts_ShouldReturnContractsList()
        {
            // Act
            var contracts = _db.GetAllContracts();

            // Assert
            Assert.IsNotNull(contracts);
            Assert.AreEqual(2, contracts.Count);
        }

        [TestMethod]
        public void GetContractsByAgent_ShouldReturnContractsForAgent()
        {
            // Act
            var contracts = _db.GetContractsByAgent(1);

            // Assert
            Assert.IsNotNull(contracts);
            Assert.AreEqual(1, contracts.Count);
            Assert.AreEqual("Иванов Иван Петрович", contracts[0].ClientName);
        }

        [TestMethod]
        public void GetContractsByClient_ShouldReturnContractsForClient()
        {
            // Act
            var contracts = _db.GetContractsByClient(1);

            // Assert
            Assert.IsNotNull(contracts);
            Assert.AreEqual(1, contracts.Count);
            Assert.AreEqual("Автострахование", contracts[0].InsuranceName);
        }

        [TestMethod]
        public void GetContractsByFilial_ShouldReturnContractsForFilial()
        {
            // Act
            var contracts = _db.GetContractsByFilial(1);

            // Assert
            Assert.IsNotNull(contracts);
            Assert.AreEqual(1, contracts.Count);
            Assert.AreEqual("Центральный", contracts[0].FilialName);
        }

        [TestMethod]
        public void GetContractById_ShouldReturnCorrectContract()
        {
            // Act
            var contract = _db.GetContractById(1);

            // Assert
            Assert.IsNotNull(contract);
            Assert.AreEqual(1000000m, contract.InsuranceSum);
            Assert.AreEqual(55000m, contract.InsurancePayment);
            Assert.IsTrue(contract.IsActive);
        }

        [TestMethod]
        public void GetContractById_InvalidId_ShouldReturnNull()
        {
            // Act
            var contract = _db.GetContractById(999);

            // Assert
            Assert.IsNull(contract);
        }

        [TestMethod]
        public void AddContract_ShouldAddNewContract()
        {
            // Arrange
            var contract = new Shiled.Contract
            {
                ID_Client = 1,
                ID_Insurance = 2,
                ID_Filial = 1,
                ID_Agent = 1,
                InsuranceSum = 200000m,
                Tariff = 3.0m,
                InsurancePayment = 6000m,
                DateStart = "2024-03-01",
                DateFinal = "2025-03-01",
                Discription = "Новый договор",
                IsActive = true
            };

            // Act
            bool result = _db.AddContract(contract);
            var contracts = _db.GetAllContracts();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(3, contracts.Count);
        }

        [TestMethod]
        public void CancelContract_ShouldSetIsActiveToFalse()
        {
            // Act
            bool result = _db.CancelContract(1);
            var canceled = _db.GetContractById(1);

            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(canceled.IsActive);
        }

        [TestMethod]
        public void CalculateInsurancePayment_ShouldReturnCorrectPayment()
        {
            // Arrange
            decimal insuranceSum = 1000000m;
            decimal tariff = 5.5m;
            decimal expected = 55000m;

            // Act
            decimal result = _db.CalculateInsurancePayment(insuranceSum, tariff);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
