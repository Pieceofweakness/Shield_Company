using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiled
{
    public class User
    {
        public string Role { get; set; } // "Admin", "Agent", "Client"
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int? FilialId { get; set; } // Для агента
    }
}
