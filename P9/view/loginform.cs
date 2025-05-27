using System;
using System.Windows.Forms;
using dietapp.Models;
using dietapp.Controllers;

namespace dietapp.Views
{
    public partial class LoginForm : Form
    {
        private LoginController loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            if (loginController.Login(user))
            {
                MessageBox.Show("Login berhasil");
                this.Hide();
                new InputDataForm().Show();
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
        }
    }
}
