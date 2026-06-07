using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public class Aplication
    {
        public int ID_Application { get; set; }
        public int ID_Client { get; set; }
        public int? ID_Insurance { get; set; }
        public int? ID_Filial { get; set; }
        public decimal InsuranceSum { get; set; }
        public string Discription { get; set; }
        public string Status { get; set; }

        // Дополнительные поля для отображения
        public string ClientName { get; set; }
        public string InsuranceName { get; set; }
        public string FilialName { get; set; }
        public decimal MonthlyPayment { get; set; } // Ежемесячный платеж
    }
}
