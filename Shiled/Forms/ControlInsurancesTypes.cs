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
    public partial class ControlInsurancesTypes : Form
    {
        private DatabaseAdapter db;
        private InsuranceType selectedInsuranceType;



        public ControlInsurancesTypes()
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            LoadInsurancesTypes();

        }

        public void LoadInsurancesTypes()
        {
            var insuranceTypes = db.GetAllInsuranceTypes();

            dgvInsurancesTypes.DataSource = insuranceTypes;

            dgvInsurancesTypes.Columns["id_insurance"].HeaderText = "N";
            dgvInsurancesTypes.Columns["insurancename"].HeaderText = "Название";
            dgvInsurancesTypes.Columns["insurancename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvInsurancesTypes.Columns["basetariff"].HeaderText = "Тариф, %";
            dgvInsurancesTypes.Columns["basetariff"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvInsurancesTypes.Columns["discription"].HeaderText = "Описание";
            dgvInsurancesTypes.Columns["discription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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
