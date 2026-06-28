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
        public int? FilialID;
        public AgentMainForm(int agentID, int? filialID)
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            AgentID = agentID;
            FilialID = filialID;
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMyContracts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowContractsByAgent contractsByAgent = new ShowContractsByAgent(AgentID, FilialID);
            contractsByAgent.ShowDialog();
            this.Close();
        }

        private void btnShowApplications_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIewApplications vIewApplications = new VIewApplications(AgentID, FilialID);
            vIewApplications.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }
    }
}
