using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shiled
{
    public class DatabaseAdapter: IDatabaseAdapter
    {
        private readonly string connectionString = $"Host=localhost;Port=5432;Database=Shield_Company;Username=postgres;Password=1234";

        public DatabaseAdapter()
        {
        }



        private IDbConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable QueryTable(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var result = conn.Query(sql, param);
                DataTable table = new DataTable();

                if (result.Any())
                {
                    var firstRow = (IDictionary<string, object>)result.First();
                    foreach (var prop in firstRow.Keys)
                        table.Columns.Add(prop);

                    foreach (IDictionary<string, object> row in result)
                        table.Rows.Add(row.Values.ToArray());
                }
                return table;
            }
        }

        public int Execute(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Execute(sql, param);
            }
        }
        // ---------------------- Авторизация ----------------------

        public User AuthenticateUser(string login, string password)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Проверяем среди администраторов
                var admin = conn.QueryFirstOrDefault<Administrator>(
                    "SELECT * FROM Administrators WHERE Login = @login AND Password = @password",
                    new { login, password });

                if (admin != null)
                {
                    return new User
                    {
                        Role = "Admin",
                        UserId = admin.ID_Admin,
                        FullName = admin.FullName
                    };
                }

                // Проверяем среди агентов
                var agent = conn.QueryFirstOrDefault<Agent>(
                    "SELECT * FROM Agents WHERE Login = @login AND Password = @password",
                    new { login, password });

                if (agent != null)
                {
                    return new User
                    {
                        Role = "Agent",
                        UserId = agent.ID_Agent,
                        FullName = agent.FullName,
                        FilialId = agent.ID_Filial
                    };
                }

                // Проверяем среди клиентов
                var client = conn.QueryFirstOrDefault<Client>(
                    "SELECT * FROM Clients WHERE Login = @login AND Password = @password",
                    new { login, password });

                if (client != null)
                {
                    return new User
                    {
                        Role = "Client",
                        UserId = client.ID_Client,
                        FullName = client.FullName
                    };
                }

                return null;
            }
        }
        // ---------------------- Филиалы ----------------------

        public List<Filial> GetAllFilials()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<Filial>("SELECT * FROM Filials ORDER BY ID_Filial").ToList();
            }
        }

        public Filial GetFilialById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.QueryFirstOrDefault<Filial>(
                    "SELECT * FROM Filials WHERE ID_Filial = @id", new { id });
            }
        }

        public bool AddFilial(Filial filial)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Filials (NameFilial, Address, Phone) 
                    VALUES (@NameFilial, @Address, @Phone)";
                return conn.Execute(sql, filial) > 0;
            }
        }

        public bool UpdateFilial(Filial filial)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE Filials SET 
                        NameFilial = @NameFilial, 
                        Address = @Address, 
                        Phone = @Phone 
                    WHERE ID_Filial = @ID_Filial";
                return conn.Execute(sql, filial) > 0;
            }
        }
        // ---------------------- Агенты ----------------------

        public List<Agent> GetAllAgents()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, f.NameFilial as FilialName 
                    FROM Agents a
                    LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial";

                

                sql += " ORDER BY a.ID_Agent";

                return conn.Query<Agent>(sql).ToList();
            }
        }

        public List<Agent> GetAgentsByFilial(int filialId, bool includeInactive = false)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, f.NameFilial as FilialName 
                    FROM Agents a
                    LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial
                    WHERE a.ID_Filial = @filialId";

                if (!includeInactive)
                    sql += " AND a.IsActive = TRUE";

                return conn.Query<Agent>(sql, new { filialId }).ToList();
            }
        }

        public Agent GetAgentById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.QueryFirstOrDefault<Agent>(
                    @"SELECT a.*, f.NameFilial as FilialName 
                      FROM Agents a
                      LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial
                      WHERE a.ID_Agent = @id", new { id });
            }
        }

        public bool AddAgent(Agent agent)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Agents (FullName, ID_Filial, Phone, BornDate, Passport, IsActive, Login, Password) 
                    VALUES (@FullName, @ID_Filial, @Phone, @BornDate, @Passport, @IsActive, @Login, @Password)";
                return conn.Execute(sql, agent) > 0;
            }
        }

        public bool UpdateAgent(Agent agent)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE Agents SET 
                        FullName = @FullName, 
                        ID_Filial = @ID_Filial, 
                        Phone = @Phone, 
                        BornDate = @BornDate, 
                        Passport = @Passport,
                        Login = @Login,
                        Password = @Password
                    WHERE ID_Agent = @ID_Agent";
                return conn.Execute(sql, agent) > 0;
            }
        }

        public bool SetAgentActiveStatus(int agentId, bool isActive)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Execute(
                    "UPDATE Agents SET IsActive = @isActive WHERE ID_Agent = @agentId",
                    new { agentId, isActive }) > 0;
            }
        }
        // ---------------------- Клиенты ----------------------

        public List<Client> GetAllClients()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<Client>("SELECT * FROM Clients ORDER BY ID_Client").ToList();
            }
        }

        public Client GetClientById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.QueryFirstOrDefault<Client>(
                    "SELECT * FROM Clients WHERE ID_Client = @id", new { id });
            }
        }

        public Client GetClientByUserId(int userId)
        {
            return GetClientById(userId);
        }

        public bool AddClient(Client client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Clients (FullName, Passport, BornDate, Phone, Login, Password) 
                    VALUES (@FullName, @Passport, @BornDate, @Phone, @Login, @Password)";
                return conn.Execute(sql, client) > 0;
            }
        }

        public bool UpdateClient(Client client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE Clients SET 
                        FullName = @FullName, 
                        Passport = @Passport, 
                        BornDate = @BornDate, 
                        Phone = @Phone,
                        Login = @Login,
                        Password = @Password
                    WHERE ID_Client = @ID_Client";
                return conn.Execute(sql, client) > 0;
            }
        }
        // ---------------------- Виды страхования ----------------------

        public List<InsuranceType> GetAllInsuranceTypes()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<InsuranceType>("SELECT * FROM Insurance ORDER BY ID_Insurance").ToList();
            }
        }

        public InsuranceType GetInsuranceTypeById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.QueryFirstOrDefault<InsuranceType>(
                    "SELECT * FROM Insurance WHERE ID_Insurance = @id", new { id });
            }
        }

        public bool AddInsuranceType(InsuranceType insuranceType)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Insurance (InsuranceName, BaseTariff, Discription) 
                    VALUES (@InsuranceName, @BaseTariff, @Discription)";
                return conn.Execute(sql, insuranceType) > 0;
            }
        }

        public bool UpdateInsuranceType(InsuranceType insuranceType)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE Insurance SET 
                        InsuranceName = @InsuranceName, 
                        BaseTariff = @BaseTariff, 
                        Discription = @Discription 
                    WHERE ID_Insurance = @ID_Insurance";
                return conn.Execute(sql, insuranceType) > 0;
            }
        }
        // ---------------------- Договоры ----------------------

        public List<Contract> GetAllContracts()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                c.ID_Contract,
                c.ID_Client,
                c.ID_Insurance,
                c.ID_Filial,
                c.ID_Agent,
                c.InsuranceSum,
                c.Tariff,
                c.InsurancePayment,
                c.DateStart::text as DateStart,      
                c.DateFinal::text as DateFinal,      
                c.Discription,
                c.IsActive,
                cl.FullName as ClientName,
                i.InsuranceName,
                a.FullName as AgentName,
                f.NameFilial as FilialName
            FROM Contracts c
            LEFT JOIN Clients cl ON c.ID_Client = cl.ID_Client
            LEFT JOIN Insurance i ON c.ID_Insurance = i.ID_Insurance
            LEFT JOIN Agents a ON c.ID_Agent = a.ID_Agent
            LEFT JOIN Filials f ON c.ID_Filial = f.ID_Filial
            ORDER BY c.ID_Contract DESC";
                return conn.Query<Contract>(sql).ToList();
            }
        }

        public List<Contract> GetContractsByAgent(int agentId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                c.ID_Contract,
                c.ID_Client,
                c.ID_Insurance,
                c.ID_Filial,
                c.ID_Agent,
                c.InsuranceSum,
                c.Tariff,
                c.InsurancePayment,
                c.DateStart::text as DateStart,      
                c.DateFinal::text as DateFinal,      
                c.Discription,
                c.IsActive,
                cl.FullName as ClientName,
                i.InsuranceName,
                f.NameFilial as FilialName
                FROM Contracts c
                LEFT JOIN Clients cl ON c.ID_Client = cl.ID_Client
                LEFT JOIN Insurance i ON c.ID_Insurance = i.ID_Insurance
                LEFT JOIN Filials f ON c.ID_Filial = f.ID_Filial
                WHERE c.ID_Agent = @agentId";

                sql += " ORDER BY c.ID_Contract DESC";

                return conn.Query<Contract>(sql, new {agentId   }).ToList();
            }
        }

        public List<Contract> GetContractsByClient(int clientId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                c.ID_Contract,
                c.ID_Client,
                c.ID_Insurance,
                c.ID_Filial,
                c.ID_Agent,
                c.InsuranceSum,
                c.Tariff,
                c.InsurancePayment,
                c.DateStart::text as DateStart,      
                c.DateFinal::text as DateFinal,      
                c.Discription,
                c.IsActive,
                i.InsuranceName,
                a.FullName as AgentName,
                f.NameFilial as FilialName,
                f.Phone as phonefilial
            FROM Contracts c
            LEFT JOIN Insurance i ON c.ID_Insurance = i.ID_Insurance
            LEFT JOIN Agents a ON c.ID_Agent = a.ID_Agent
            LEFT JOIN Filials f ON c.ID_Filial = f.ID_Filial
            WHERE c.ID_Client = @clientId AND c.IsActive = TRUE
            ORDER BY c.ID_Contract DESC";
                return conn.Query<Contract>(sql, new { clientId }).ToList();
            }
        }

        public List<Contract> GetContractsByFilial(int filialId, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT c.*, 
                           cl.FullName as ClientName,
                           i.InsuranceName,
                           a.FullName as AgentName
                    FROM Contracts c
                    LEFT JOIN Clients cl ON c.ID_Client = cl.ID_Client
                    LEFT JOIN Insurance i ON c.ID_Insurance = i.ID_Insurance
                    LEFT JOIN Agents a ON c.ID_Agent = a.ID_Agent
                    WHERE c.ID_Filial = @filialId";

                if (dateFrom.HasValue)
                    sql += " AND c.DateStart >= @dateFrom";
                if (dateTo.HasValue)
                    sql += " AND c.DateStart <= @dateTo";

                sql += " ORDER BY c.ID_Contract DESC";

                return conn.Query<Contract>(sql, new { filialId, dateFrom, dateTo }).ToList();
            }
        }

        public Contract GetContractById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT c.*, 
                           cl.FullName as ClientName,
                           i.InsuranceName,
                           a.FullName as AgentName,
                           f.NameFilial as FilialName
                    FROM Contracts c
                    LEFT JOIN Clients cl ON c.ID_Client = cl.ID_Client
                    LEFT JOIN Insurance i ON c.ID_Insurance = i.ID_Insurance
                    LEFT JOIN Agents a ON c.ID_Agent = a.ID_Agent
                    LEFT JOIN Filials f ON c.ID_Filial = f.ID_Filial
                    WHERE c.ID_Contract = @id";
                return conn.QueryFirstOrDefault<Contract>(sql, new { id });
            }
        }

        public bool AddContract(Contract contract)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Contracts 
                    (ID_Client, ID_Insurance, ID_Filial, ID_Agent, InsuranceSum, Tariff, InsurancePayment, DateStart, DateFinal, Discription, IsActive) 
                    VALUES 
                    (@ID_Client, @ID_Insurance, @ID_Filial, @ID_Agent, @InsuranceSum, @Tariff, @InsurancePayment, @DateStart, @DateFinal, @Discription, @IsActive)";
                return conn.Execute(sql, contract) > 0;
            }
        }

        public bool CancelContract(int contractId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Execute(
                    "UPDATE Contracts SET IsActive = FALSE WHERE ID_Contract = @contractId",
                    new { contractId }) > 0;
            }
        }
        public decimal CalculateInsurancePayment(decimal insuranceSum, decimal tariff)
        {
            return insuranceSum * (tariff / 100);
        }
        // ---------------------- Заявки ----------------------

        public List<Aplication> GetAllApplications()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, 
                           cl.FullName as ClientName,
                           i.InsuranceName,
                           i.BaseTariff,
                           f.NameFilial as FilialName,
                           (a.InsuranceSum * i.BaseTariff / 100) as MonthlyPayment
                    FROM Applications a
                    LEFT JOIN Clients cl ON a.ID_Client = cl.ID_Client
                    LEFT JOIN Insurance i ON a.ID_Insurance = i.ID_Insurance
                    LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial
                    ORDER BY a.ID_Application DESC";
                return conn.Query<Aplication>(sql).ToList();
            }
        }

        public List<Aplication> GetApplicationsByFilial(int filialId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, 
                           cl.FullName as ClientName,
                           cl.Phone as Phone,
                           i.InsuranceName,
                           i.BaseTariff,
                           (a.InsuranceSum * i.BaseTariff / 100) as MonthlyPayment
                    FROM Applications a
                    LEFT JOIN Clients cl ON a.ID_Client = cl.ID_Client
                    LEFT JOIN Insurance i ON a.ID_Insurance = i.ID_Insurance
                    WHERE a.ID_Filial = @filialId
                    ORDER BY a.ID_Application DESC";
                return conn.Query<Aplication>(sql, new { filialId }).ToList();
            }
        }

        public List<Aplication> GetApplicationsByClient(int clientId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, 
                           i.InsuranceName,
                           f.NameFilial as FilialName,
                           (a.InsuranceSum * i.BaseTariff / 100) as MonthlyPayment
                    FROM Applications a
                    LEFT JOIN Insurance i ON a.ID_Insurance = i.ID_Insurance
                    LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial
                    WHERE a.ID_Client = @clientId
                    ORDER BY a.ID_Application DESC";
                return conn.Query<Aplication>(sql, new { clientId }).ToList();
            }
        }

        public Aplication GetApplicationById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.*, 
                           cl.FullName as ClientName,
                           i.InsuranceName,
                           f.NameFilial as FilialName
                    FROM Applications a
                    LEFT JOIN Clients cl ON a.ID_Client = cl.ID_Client
                    LEFT JOIN Insurance i ON a.ID_Insurance = i.ID_Insurance
                    LEFT JOIN Filials f ON a.ID_Filial = f.ID_Filial
                    WHERE a.ID_Application = @id";
                return conn.QueryFirstOrDefault<Aplication>(sql, new { id });
            }
        }

        public bool AddApplication(Aplication application)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Applications (ID_Client, ID_Insurance, ID_Filial, InsuranceSum, Discription, Status) 
                    VALUES (@ID_Client, @ID_Insurance, @ID_Filial, @InsuranceSum, @Discription, 'Новая')";
                return conn.Execute(sql, application) > 0;
            }
        }

        public bool UpdateApplicationStatus(int applicationId, string status)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Execute(
                    "UPDATE Applications SET Status = @status WHERE ID_Application = @applicationId",
                    new { applicationId, status }) > 0;
            }
        }























    }
}
