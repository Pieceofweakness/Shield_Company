using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public interface IDatabaseAdapter
    {
        // Тестирование подключения
        bool TestConnection();

        // Выполнение запросов
        DataTable QueryTable(string sql, object param = null);
        int Execute(string sql, object param = null);

        // Авторизация
        User AuthenticateUser(string login, string password);

        // ---------- Управление филиалами ----------
        List<Filial> GetAllFilials();
        Filial GetFilialById(int id);
        bool AddFilial(Filial filial);
        bool UpdateFilial(Filial filial);
        // ---------- Управление агентами ----------
        List<Agent> GetAllAgents(bool includeInactive = false);
        List<Agent> GetAgentsByFilial(int filialId, bool includeInactive = false);
        Agent GetAgentById(int id);
        bool AddAgent(Agent agent);
        bool UpdateAgent(Agent agent);
        bool SetAgentActiveStatus(int agentId, bool isActive);
        // ---------- Управление клиентами ----------
        List<Client> GetAllClients();
        Client GetClientById(int id);
        Client GetClientByUserId(int userId);
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        // ---------- Управление видами страхования ----------
        List<InsuranceType> GetAllInsuranceTypes();
        InsuranceType GetInsuranceTypeById(int id);
        bool AddInsuranceType(InsuranceType insuranceType);
        bool UpdateInsuranceType(InsuranceType insuranceType);

        // ---------- Управление договорами ----------
        List<Contract> GetAllContracts();
        List<Contract> GetContractsByAgent(int agentId, DateTime? dateFrom = null, DateTime? dateTo = null);
        List<Contract> GetContractsByClient(int clientId);
        List<Contract> GetContractsByFilial(int filialId, DateTime? dateFrom = null, DateTime? dateTo = null);
        Contract GetContractById(int id);
        bool AddContract(Contract contract);
        bool CancelContract(int contractId);
        decimal CalculateInsurancePayment(decimal insuranceSum, decimal tariff);
        // ---------- Управление заявками ----------
        List<Aplication> GetAllApplications();
        List<Aplication> GetApplicationsByFilial(int filialId);
        List<Aplication> GetApplicationsByClient(int clientId);
        Aplication GetApplicationById(int id);
        bool AddApplication(Aplication application);
        bool UpdateApplicationStatus(int applicationId, string status);





    }
}
