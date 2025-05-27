using MySql.Data.MySqlClient;
using dietapp.Models;
using System;
using System.Collections.Generic;

namespace dietapp.Controllers
{
    public class MakananController
    {
        private string connStr = "server=localhost;user=root;password=;database=dietapp;";

        public List<Makanan> GetAll()
        {
            var list = new List<Makanan>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM makanan";
                var cmd = new MySqlCommand(query, conn);
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

        public void Insert(Makanan m)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO makanan (makanan, kalori, tanggal) VALUES (@makanan, @kalori, @tanggal)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makanan", m.Nama);
                cmd.Parameters.AddWithValue("@kalori", m.Kalori);
                cmd.Parameters.AddWithValue("@tanggal", m.Tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Makanan m)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE makanan SET makanan=@makanan, kalori=@kalori, tanggal=@tanggal WHERE id=@id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@makanan", m.Nama);
                cmd.Parameters.AddWithValue("@kalori", m.Kalori);
                cmd.Parameters.AddWithValue("@tanggal", m.Tanggal);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM makanan WHERE id=@id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
