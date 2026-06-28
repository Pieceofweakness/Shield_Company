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
    public partial class AddNewApplication : Form
    {
        public int ClientID;
        public string FullName;
        private DatabaseAdapter db;


        public AddNewApplication(int clientid, string fullname)
        {
            db = new DatabaseAdapter();
            InitializeComponent();
            ClientID = clientid;
            FullName = fullname;
            LoadComboBoxes();
            LoadTextBox();
        }



        public void LoadComboBoxes()
        {
            var filials = db.GetAllFilials();

            var displayList = filials.Select(c => new
            {
                ID = c.ID_Filial,
                Name = c.NameFilial,
                Address = c.Address,
                Phone = c.Phone
            }).ToList();

            cmbFilial.DataSource = displayList;
            cmbFilial.DisplayMember = "Name";
            cmbFilial.ValueMember = "ID";



            var insurances = db.GetAllInsuranceTypes();
            var display = insurances.Select(c => new
            {
                ID = c.ID_Insurance,
                Name = c.InsuranceName,
                Tariff = c.BaseTariff
            }).ToList();

            cmbType.DataSource = display;
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "ID";
        }


        public void LoadTextBox()
        {
            txtFIO.Text = FullName;
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            dynamic selectedInsurance = cmbType.SelectedItem;
            dynamic selectedFilial = cmbFilial.SelectedItem;


            var application = new Aplication
            {
                ID_Client = ClientID,
                ID_Insurance = selectedInsurance.ID,
                ID_Filial = selectedFilial.ID,
                InsuranceSum = decimal.Parse(txtSumma.Text),
                Discription = txtDiscription.Text.Trim(),
                Status = "Новая"
            };

            try
            {
                if (db.AddApplication(application))
                {
                    MessageBox.Show("Заявка успешно отправлена!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    ClientMainForm clientForm = new ClientMainForm(ClientID, FullName);
                    clientForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientMainForm clientForm = new ClientMainForm(ClientID, FullName);
            clientForm.ShowDialog();
            this.Close();
        }
    }
}
