using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiled.Forms
{
    public partial class LoginForm : Form
    {
        private DatabaseAdapter db;
        public LoginForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.ToString();
            string password = txtPassword.Text.ToString();

            var user = db.AuthenticateUser(login, password);
            if (user != null)
            {
                MessageBox.Show($"Добро пожаловать, {user.FullName}! Роль: {user.Role}");
                this.Hide();
                if (user.Role == "Admin")
                {
                    AdminMainForm adminForm = new AdminMainForm();
                    adminForm.ShowDialog();
                }
                else if (user.Role == "Agent")
                {
                    AgentMainForm agentForm = new AgentMainForm(user.UserId, user.FilialId);
                    agentForm.ShowDialog();
                }
                else if (user.Role == "Client")
                {
                    ClientMainForm clientForm = new ClientMainForm(user.UserId, user.FullName);
                    clientForm.ShowDialog();
                }

                this.Close();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
