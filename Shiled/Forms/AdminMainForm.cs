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
    public partial class AdminMainForm : Form
    {
        private DatabaseAdapter db;
        public AdminMainForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlAgentsForm controlAgentsForm = new ControlAgentsForm();
            controlAgentsForm.ShowDialog();
            this.Close();
        }

        private void btnFilials_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlFilialsForm controlFilialsForm = new ControlFilialsForm();
            controlFilialsForm.ShowDialog();
            this.Close();
        }

        private void btnInsurances_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlInsurancesTypes controlInsurancesTypes = new ControlInsurancesTypes();
            controlInsurancesTypes.ShowDialog();
            this.Close();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllContracts showAllContracts = new ShowAllContracts();
            showAllContracts.ShowDialog();
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
