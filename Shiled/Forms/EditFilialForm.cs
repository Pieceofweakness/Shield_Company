using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shiled.Forms
{
    public partial class EditFilialForm : Form
    {
        private Filial filial;
        private bool isEditMode;

        public EditFilialForm()
        {
            InitializeComponent();
            isEditMode = false;
        }

        public EditFilialForm(Filial existingFilial)
        {
            InitializeComponent();
            isEditMode = true;
            filial = existingFilial;
            txtName.Text = filial.NameFilial;
            txtAddress.Text = filial.Address;
            txtPhone.Text = filial.Phone;
        }

        public Filial GetFilial()
        {
            return new Filial
            {
                NameFilial = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название филиала!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Введите адрес филиала!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введите телефон филиала!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
