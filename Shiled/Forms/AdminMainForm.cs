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
    public partial class AdminMainForm : Form
    {
        private DatabaseAdapter db;
        public AdminMainForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter("localhost", "Shield_Company", "postgres", "1234");
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {

        }

        private void btnFilials_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlFilialsForm controlFilialsForm = new ControlFilialsForm();
            controlFilialsForm.ShowDialog();
            this.Close();
        }
    }
}
