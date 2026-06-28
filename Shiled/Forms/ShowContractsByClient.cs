using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ShowContractsByClient : Form
    {
        public int ClientID;
        public string FullName;
        private DatabaseAdapter db;
        public ShowContractsByClient(int clientID, string fullName)
        {
            db = new DatabaseAdapter();
            ClientID = clientID;
            FullName = fullName;
            InitializeComponent();
            LoadContracts();
        }



        public void LoadContracts()
        {
            var contracts = db.GetContractsByClient(ClientID);

            var display = contracts.Select(c => new
            {
                N = c.ID_Contract,
                Агент = c.AgentName,
                Вид_страхования = c.InsuranceName,
                Страховая_сумма = c.InsuranceSum,
                Платеж = c.InsurancePayment

            }).ToList();

            dgvContracts.DataSource = display;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientMainForm clientForm = new ClientMainForm(ClientID, FullName);
            clientForm.ShowDialog();
            this.Close();
        }
    }
}
