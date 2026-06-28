using Microsoft.Extensions.Logging;
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
    public partial class ClientMainForm : Form
    {
        public int ClientID;
        public string FullName;


        public ClientMainForm(int clientID, string fullName)
        {
            InitializeComponent();
            ClientID = clientID;
            FullName = fullName;
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewApplication addNewApplication = new AddNewApplication(ClientID, FullName);
            addNewApplication.ShowDialog();
            this.Close();
        }

        private void btnMyContracts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowContractsByClient showContractsByClient = new ShowContractsByClient(ClientID, FullName);
            showContractsByClient.ShowDialog();
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
