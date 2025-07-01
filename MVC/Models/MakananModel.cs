using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dietapp.Models
{
    public class Makanan
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Kalori { get; set; }
        public DateTime Tanggal { get; set; }
    }

    public class MakananModel
    {


        private string connectionString = "server=localhost;user=root;password=;database=dietapp;";

        public List<Makanan> GetAll()
        {
            var list = new List<Makanan>();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM makanan", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Makanan
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nama = reader["makanan"].ToString(),
                        Kalori = Convert.ToInt32(reader["kalori"]),
                        Tanggal = Convert.ToDateTime(reader["tanggal"])
                    });
                }
            }
            return list;
        }

        public void Insert(Makanan makanan)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO makanan (makanan, kalori, tanggal) VALUES (@nama, @kalori, @tanggal)", conn);
                cmd.Parameters.AddWithValue("@nama", makanan.Nama);
                cmd.Parameters.AddWithValue("@kalori", makanan.Kalori);
                cmd.Parameters.AddWithValue("@tanggal", makanan.Tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Makanan makanan)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE makanan SET makanan=@nama, kalori=@kalori, tanggal=@tanggal WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", makanan.Id);
                cmd.Parameters.AddWithValue("@nama", makanan.Nama);
                cmd.Parameters.AddWithValue("@kalori", makanan.Kalori);
                cmd.Parameters.AddWithValue("@tanggal", makanan.Tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM makanan WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
