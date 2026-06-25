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
        public int AgentID;
        public AgentMainForm(int agentID)
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            AgentID = agentID;
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMyContracts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowContractsByAgent contractsByAgent = new ShowContractsByAgent(AgentID);
            contractsByAgent.ShowDialog();
            this.Close();
        }

        private void btnShowApplications_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
