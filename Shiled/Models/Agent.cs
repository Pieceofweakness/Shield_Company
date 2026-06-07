using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public class Agent
    {
        public int ID_Agent { get; set; }
        public string FullName { get; set; }
        public int? ID_Filial { get; set; }
        public string Phone { get; set; }
        public DateTime? BornDate { get; set; }
        public string Passport { get; set; }
        public bool IsActive { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // Для отображения названия филиала
        public string FilialName { get; set; }
    }
}
