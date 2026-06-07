using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public class Client
    {
        public int ID_Client { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public DateTime? BornDate { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
