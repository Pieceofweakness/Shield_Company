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
    public partial class ShowAllContracts : Form
    {
        private DatabaseAdapter db;
        public ShowAllContracts()
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            LoadContracts();

        }

        public void LoadContracts()
        {
            var contracts = db.GetAllContracts();

            dgvContracts.DataSource = contracts;

            var displayList = contracts.Select(c => new
            {
                N = c.ID_Contract,
                Клиент = c.ClientName,
                Вид = c.InsuranceName,
                Сумма = c.InsuranceSum,
                Период = $"{c.DateStart:dd.MM.yyyy} - {c.DateFinal:dd.MM.yyyy}",
                Платеж = c.InsurancePayment,
                Агент = c.AgentName,
                Активность = c.IsActive ? "Да" : "Нет"
            }).ToList();

            dgvContracts.DataSource = displayList;

            ConfigureCollumns();


        }

        public void ConfigureCollumns()
        {
            dgvContracts.Columns["N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Клиент"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Вид"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Сумма"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Период"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Платеж"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Агент"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContracts.Columns["Активность"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.ShowDialog();
            this.Close();
        }
    }
}
