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
    public partial class ShowContractsByAgent : Form
    {
        private DatabaseAdapter db;
        private Contract selectedContract;
        public int AgentID;

        public ShowContractsByAgent(int agentid)
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            
            AgentID = agentid;

            LoadContracts();

        }


        public void LoadContracts()
        {
            var contracts = db.GetContractsByAgent(AgentID);


            var displayList = contracts.Select(c => new
            {
                N = c.ID_Contract,
                Клиент = c.ClientName,
                Вид = c.InsuranceName,
                Сумма = c.InsuranceSum,
                Период = $"{c.DateStart:dd.MM.yyyy} - {c.DateFinal:dd.MM.yyyy}",
                Платеж = c.InsurancePayment,
                Активность = c.IsActive ? "Да" : "Нет"
            }).ToList();

            dgvContractsByAgent.DataSource = displayList;

            ConfigureCollumns();


        }

        public void ConfigureCollumns()
        {
            dgvContractsByAgent.Columns["N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Клиент"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Вид"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Сумма"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Период"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Платеж"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContractsByAgent.Columns["Активность"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentMainForm agentMainForm = new AgentMainForm(AgentID);
            agentMainForm.ShowDialog();
            this.Close();
        }

        private void btnDelContract_Click(object sender, EventArgs e)
        {

        }
    }
}
