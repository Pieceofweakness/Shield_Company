using Shiled;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shield.Tests.Helpers
{
    public class FakeDataBaseAdapter:IDatabaseAdapter
    {
        private List<Filial> _filials = new List<Filial>();
        private List<Agent> _agents = new List<Agent>();
        private List<Client> _clients = new List<Client>();
        private List<InsuranceType> _insuranceTypes = new List<InsuranceType>();
        private List<Contract> _contracts = new List<Contract>();
        private List<Aplication> _applications = new List<Aplication>();
        private List<Administrator> _admins = new List<Administrator>();

        private int _filialIdCounter = 1;
        private int _agentIdCounter = 1;
        private int _clientIdCounter = 1;
        private int _insuranceIdCounter = 1;
        private int _contractIdCounter = 1;
        private int _applicationIdCounter = 1;
        private int _adminIdCounter = 1;

        public FakeDataBaseAdapter()
        {
            SeedData();
        }


        private void SeedData()
        {
            _filials.Add(new Filial { ID_Filial = 1, NameFilial = "Центральный", Address = "г. Красноярск, ул. Мира, 1", Phone = "+7(391)111-11-11" });
            _filials.Add(new Filial { ID_Filial = 2, NameFilial = "Северный", Address = "г. Красноярск, ул. Северная, 15", Phone = "+7(391)222-22-22" });

            _admins.Add(new Administrator { ID_Admin = 1, FullName = "Администратор Системы", Phone = "+7(391)999-99-99", Login = "admin", Password = "admin123" });

            _agents.Add(new Agent
            {
                ID_Agent = 1,
                FullName = "Петров Александр Васильевич",
                ID_Filial = 1,
                Phone = "+7(999)111-11-11",
                Passport = "1234 567890",
                IsActive = true,
                Login = "agent1",
                Password = "agent123",
                FilialName = "Центральный"
            });
            _agents.Add(new Agent
            {
                ID_Agent = 2,
                FullName = "Сидорова Мария Ивановна",
                ID_Filial = 2,
                Phone = "+7(999)222-22-22",
                Passport = "5678 123456",
                IsActive = true,
                Login = "agent2",
                Password = "agent123",
                FilialName = "Северный"
            });

            _clients.Add(new Client
            {
                ID_Client = 1,
                FullName = "Иванов Иван Петрович",
                Passport = "1111 222233",
                Phone = "+7(999)333-33-33",
                Login = "client1",
                Password = "client123"
            });
            _clients.Add(new Client
            {
                ID_Client = 2,
                FullName = "Петрова Елена Сергеевна",
                Passport = "4444 555566",
                Phone = "+7(999)444-44-44",
                Login = "client2",
                Password = "client123"
            });

            _insuranceTypes.Add(new InsuranceType { ID_Insurance = 1, InsuranceName = "Автострахование", BaseTariff = 5.5m, Discription = "Страхование автомобилей" });
            _insuranceTypes.Add(new InsuranceType { ID_Insurance = 2, InsuranceName = "Имущественное страхование", BaseTariff = 3.0m, Discription = "Страхование домашнего имущества" });
            _insuranceTypes.Add(new InsuranceType { ID_Insurance = 3, InsuranceName = "ДМС", BaseTariff = 7.0m, Discription = "Добровольное медицинское страхование" });

            _contracts.Add(new Contract
            {
                ID_Contract = 1,
                ID_Client = 1,
                ID_Insurance = 1,
                ID_Filial = 1,
                ID_Agent = 1,
                InsuranceSum = 1000000m,
                Tariff = 5.5m,
                InsurancePayment = 55000m,
                DateStart = "2024-01-15",
                DateFinal = "2025-01-15",
                Discription = "Страхование автомобиля Toyota",
                IsActive = true,
                ClientName = "Иванов Иван Петрович",
                InsuranceName = "Автострахование",
                AgentName = "Петров Александр Васильевич",
                FilialName = "Центральный"
            });

            _contracts.Add(new Contract
            {
                ID_Contract = 2,
                ID_Client = 2,
                ID_Insurance = 2,
                ID_Filial = 2,
                ID_Agent = 2,
                InsuranceSum = 500000m,
                Tariff = 3.0m,
                InsurancePayment = 15000m,
                DateStart = "2024-02-01",
                DateFinal = "2025-02-01",
                Discription = "Страхование квартиры",
                IsActive = true,
                ClientName = "Петрова Елена Сергеевна",
                InsuranceName = "Имущественное страхование",
                AgentName = "Сидорова Мария Ивановна",
                FilialName = "Северный"
            });
            _applications.Add(new Aplication
            {
                ID_Application = 1,
                ID_Client = 1,
                ID_Insurance = 2,
                ID_Filial = 1,
                InsuranceSum = 300000m,
                Discription = "Хочу застраховать дачу",
                Status = "Новая",
                ClientName = "Иванов Иван Петрович",
                InsuranceName = "Имущественное страхование",
                FilialName = "Центральный",
                MonthlyPayment = 750m
            });

    }

        public User AuthenticateUser(string login, string password)
        {
            var admin = _admins.FirstOrDefault(a => a.Login == login && a.Password == password);
            if (admin != null)
            {
                return new User { Role = "Admin", UserId = admin.ID_Admin, FullName = admin.FullName };
            }

            var agent = _agents.FirstOrDefault(a => a.Login == login && a.Password == password && a.IsActive);
            if (agent != null)
            {
                return new User { Role = "Agent", UserId = agent.ID_Agent, FullName = agent.FullName, FilialId = agent.ID_Filial };
            }

            var client = _clients.FirstOrDefault(c => c.Login == login && c.Password == password);
            if (client != null)
            {
                return new User { Role = "Client", UserId = client.ID_Client, FullName = client.FullName };
            }

            return null;

        }

        public List<Filial> GetAllFilials() => _filials.ToList();
        public Filial GetFilialById(int id) => _filials.FirstOrDefault(f => f.ID_Filial == id);
        public bool AddFilial(Filial filial) { filial.ID_Filial = _filialIdCounter++; _filials.Add(filial); return true; }

        public bool UpdateFilial(Filial filial)
        {
            var existing = _filials.FirstOrDefault(f => f.ID_Filial == filial.ID_Filial);
            if (existing == null) return false;
            existing.NameFilial = filial.NameFilial;
            existing.Address = filial.Address;
            existing.Phone = filial.Phone;
            return true;
        }




        public List<Agent> GetAllAgents()
        {
            return _agents.ToList();
        }
        public List<Agent> GetAgentsByFilial(int filialId, bool includeInactive = false)
        {
            var agents = _agents.Where(a => a.ID_Filial == filialId);
            if (!includeInactive) agents = agents.Where(a => a.IsActive);
            return agents.ToList();
        }
        public Agent GetAgentById(int id) => _agents.FirstOrDefault(a => a.ID_Agent == id);
        public bool AddAgent(Agent agent) { agent.ID_Agent = _agentIdCounter++; _agents.Add(agent); return true; }
        public bool UpdateAgent(Agent agent)
        {
            var existing = _agents.FirstOrDefault(a => a.ID_Agent == agent.ID_Agent);
            if (existing == null) return false;
            existing.FullName = agent.FullName;
            existing.ID_Filial = agent.ID_Filial;
            existing.Phone = agent.Phone;
            existing.Passport = agent.Passport;
            existing.Login = agent.Login;
            existing.Password = agent.Password;
            return true;
        }
        public bool SetAgentActiveStatus(int agentId, bool isActive)
        {
            var agent = _agents.FirstOrDefault(a => a.ID_Agent == agentId);
            if (agent == null) return false;
            agent.IsActive = isActive;
            return true;
        }

        public List<Client> GetAllClients() => _clients.ToList();

        public Client GetClientById(int id) => _clients.FirstOrDefault(c => c.ID_Client == id);
        public bool AddClient(Client client) { client.ID_Client = _clientIdCounter++; _clients.Add(client); return true; }
        public bool UpdateClient(Client client)
        {
            var existing = _clients.FirstOrDefault(c => c.ID_Client == client.ID_Client);
            if (existing == null) return false;
            existing.FullName = client.FullName;
            existing.Passport = client.Passport;
            existing.Phone = client.Phone;
            existing.Login = client.Login;
            existing.Password = client.Password;
            return true;
        }


        public Client GetClientByUserId(int id)
        {
            return GetClientById(id);
        }

        public List<InsuranceType> GetAllInsuranceTypes() => _insuranceTypes.ToList();
        public InsuranceType GetInsuranceTypeById(int id) => _insuranceTypes.FirstOrDefault(i => i.ID_Insurance == id);

        public bool AddInsuranceType(InsuranceType insurance)
        {
            insurance.ID_Insurance = _insuranceIdCounter++;
            _insuranceTypes.Add(insurance);
            return true;
        }
        public bool UpdateInsuranceType(InsuranceType insurance)
        {
            var existing = _insuranceTypes.FirstOrDefault(i => i.ID_Insurance == insurance.ID_Insurance);
            if (existing == null) return false;
            existing.InsuranceName = insurance.InsuranceName;
            existing.BaseTariff = insurance.BaseTariff;
            existing.Discription = insurance.Discription;
            return true;
        }


        public List<Contract> GetAllContracts() => _contracts.ToList();
        public List<Contract> GetContractsByAgent(int agentId) => _contracts.Where(c => c.ID_Agent == agentId).ToList();
        public List<Contract> GetContractsByClient(int clientId) => _contracts.Where(c => c.ID_Client == clientId && c.IsActive).ToList();
        public List<Contract> GetContractsByFilial(int filialId, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var contracts = _contracts.Where(c => c.ID_Filial == filialId);
            if (dateFrom.HasValue) contracts = contracts.Where(c => DateTime.Parse(c.DateStart) >= dateFrom.Value);
            if (dateTo.HasValue) contracts = contracts.Where(c => DateTime.Parse(c.DateStart) <= dateTo.Value);
            return contracts.ToList();
        }
        public Contract GetContractById(int id) => _contracts.FirstOrDefault(c => c.ID_Contract == id);
        public bool AddContract(Contract contract) { contract.ID_Contract = _contractIdCounter++; _contracts.Add(contract); return true; }
        public bool CancelContract(int contractId)
        {
            var contract = _contracts.FirstOrDefault(c => c.ID_Contract == contractId);
            if (contract == null) return false;
            contract.IsActive = false;
            return true;
        }
        public decimal CalculateInsurancePayment(decimal insuranceSum, decimal tariff) => insuranceSum * (tariff / 100);


        public List<Aplication> GetAllApplications() => _applications.ToList();
        public List<Aplication> GetApplicationsByFilial(int filialId) => _applications.Where(a => a.ID_Filial == filialId && a.Status == "Новая").ToList();
        public List<Aplication> GetApplicationsByClient(int clientId) => _applications.Where(a => a.ID_Client == clientId).ToList();
        public Aplication GetApplicationById(int id) => _applications.FirstOrDefault(a => a.ID_Application == id);
        public bool AddApplication(Aplication application)
        {
            application.ID_Application = _applicationIdCounter++;
            application.Status = "Новая";
            _applications.Add(application);
            return true;
        }
        public bool UpdateApplicationStatus(int applicationId, string status)
        {
            var app = _applications.FirstOrDefault(a => a.ID_Application == applicationId);
            if (app == null) return false;
            app.Status = status;
            return true;
        }

        public bool TestConnection() => true;
        public int Execute(string sql, object param = null) => 1;
        public DataTable QueryTable(string sql, object param = null) => new DataTable();





    }
}
