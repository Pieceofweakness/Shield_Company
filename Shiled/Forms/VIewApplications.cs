using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiled.Forms
{
    public partial class VIewApplications : Form
    {
        public int AgentID;
        private DatabaseAdapter db;
        public int FilialID;
        public VIewApplications(int agentID, int? filialID)
        {
            InitializeComponent();
            AgentID = agentID;
            db = new DatabaseAdapter();
            FilialID = Convert.ToInt32(filialID);
            LoadApplications();
        }


        public void LoadApplications()
        {
            var applications = db.GetApplicationsByFilial(FilialID);

            var display = applications.Select(c => new
            {
                Клиент = c.ClientName,
                Вид_страхования = c.InsuranceName,
                Страховая_сумма = c.InsuranceSum,
                Описание = c.Discription,
                Статус = c.Status
            }).ToList();

            dgvApplications.DataSource = display;

            ConfigurateCollumns();


        }

        public void ConfigurateCollumns()
        {
            dgvApplications.Columns["Клиент"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvApplications.Columns["Вид_страхования"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvApplications.Columns["Страховая_сумма"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvApplications.Columns["Описание"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvApplications.Columns["Статус"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentMainForm agentMainForm = new AgentMainForm(AgentID, FilialID);
            agentMainForm.ShowDialog();
            this.Close();
        }
    }
}
