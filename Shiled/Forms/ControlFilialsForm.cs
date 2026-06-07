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
    public partial class ControlFilialsForm : Form
    {
        private DatabaseAdapter db;
        private Filial selectedFilial;
        public ControlFilialsForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter("localhost", "Shield_Company", "postgres", "1234");
            LoadFilials();
        }


        void LoadFilials()
        {
            var filials = db.GetAllFilials();
            dgvFilials.DataSource = filials;
            dgvFilials.Columns["ID_Filial"].HeaderText = "ID";
            dgvFilials.Columns["NameFilial"].HeaderText = "Название филиала";
            dgvFilials.Columns["Address"].HeaderText = "Адрес";
            dgvFilials.Columns["Phone"].HeaderText = "Телефон";
        }

        private void btnEditFilial_Click(object sender, EventArgs e)
        {
            if (dgvFilials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите филиал для редактирования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedFilial = (Filial)dgvFilials.SelectedRows[0].DataBoundItem;
            EditFilialForm editForm = new EditFilialForm(selectedFilial);


            if (editForm.ShowDialog() == DialogResult.OK)
            {
                var updatedFilial = editForm.GetFilial();
                updatedFilial.ID_Filial = selectedFilial.ID_Filial;

                if (db.UpdateFilial(updatedFilial))
                {
                    MessageBox.Show("Данные филиала обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFilials();
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении филиала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.ShowDialog();
            this.Close();
        }
    }
}
