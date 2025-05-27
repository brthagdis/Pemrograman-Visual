using MySql.Data.MySqlClient;
using dietapp.Models;
using System.Windows.Forms;

namespace dietapp.Controllers
{
    public class LoginController
    {
        private string connStr = "server=localhost;user=root;password=;database=dietapp;";

        public bool Login(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
