using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiled.Forms
{
    public partial class AgentMainForm : Form
    {
        private DatabaseAdapter db;
        public AgentMainForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter("localhost", "Shield_Company", "postgres", "1234");
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {

        }
    }
}
