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
    public partial class ControlAgentsForm : Form
    {
        private DatabaseAdapter db;
        private Agent selectedAgent;

        public ControlAgentsForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter();
            LoadAgents();
        }


        public void LoadAgents()
        {
            var agents = db.GetAllAgents();

            var displayList = agents.Select(a => new
            {
                N = a.ID_Agent,
                ФИО = a.FullName,
                Телефон = a.Phone,
                Филиал = a.FilialName ?? "Не указан",
                Активность = a.IsActive ? "Да" : "Нет"
            }).ToList();

            dgvAgents.DataSource = displayList;


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
