using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public class Contract
    {
        public int ID_Contract { get; set; }
        public int ID_Client { get; set; }
        public int? ID_Insurance { get; set; }
        public int? ID_Filial { get; set; }
        public int? ID_Agent { get; set; }
        public decimal InsuranceSum { get; set; }
        public decimal Tariff { get; set; }
        public decimal InsurancePayment { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateFinal { get; set; }
        public string Discription { get; set; }
        public bool IsActive { get; set; }

        // Дополнительные поля для отображения
        public string ClientName { get; set; }
        public string InsuranceName { get; set; }
        public string AgentName { get; set; }
        public string FilialName { get; set; }
    }
}
