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
    public partial class LoginForm : Form
    {
        private DatabaseAdapter db;
        public LoginForm()
        {
            InitializeComponent();
            db = new DatabaseAdapter("localhost", "Shield_Company", "postgres", "1234");

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
                    AgentMainForm agentForm = new AgentMainForm();
                    agentForm.ShowDialog();
                }
                //else if (user.Role == "Client")
                //{
                //    ClientForm clientForm = new ClientForm();
                //    clientForm.ShowDialog();
                //}

                this.Close();
            }


        }
    }
}
