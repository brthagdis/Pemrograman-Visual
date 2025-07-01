using dietapp.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace dietapp
{
    public partial class LoginForm : Form
    {
        private readonly AuthController _authController;
        public LoginForm()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Silakan isi username dan password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isLoginValid = _authController.Login(username, password);

                if (isLoginValid)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InputData formUtama = new InputData();
                    formUtama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
