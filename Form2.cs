using dietapp.Controllers;
using dietapp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace dietapp
{
    public partial class InputData : Form
    {
        private readonly MakananController _controller = new MakananController();
        private int selectedId = -1;

        public InputData()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listView1.Items.Clear();
            var data = _controller.AmbilSemuaData();
            int i = 1;

            foreach (var item in data)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.Tag = item.Id;
                lvItem.SubItems.Add(item.Nama);
                lvItem.SubItems.Add(item.Kalori.ToString());
                lvItem.SubItems.Add(item.Tanggal.ToString("yyyy-MM-dd"));
                listView1.Items.Add(lvItem);
                i++;
            }

            HitungTotalKalori();
        }

        //private void LoadDataFromDatabase()
        //{
        //    listView1.Items.Clear();
        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "SELECT * FROM makanan";
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            int i = 1;
        //            while (reader.Read())
        //            {
        //                ListViewItem item = new ListViewItem(i.ToString());
        //                item.Tag = reader["id"];
        //                item.SubItems.Add(reader["makanan"].ToString());
        //                item.SubItems.Add(reader["kalori"].ToString());
        //                item.SubItems.Add(Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"));
        //                listView1.Items.Add(item);
        //                i++;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //    HitungTotalKalori();
        //}

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_kalori.Text, out int kalori) || string.IsNullOrWhiteSpace(textBox_makanan.Text))
            {
                MessageBox.Show("Data tidak valid.");
                return;
            }

            var makanan = new Makanan
            {
                Nama = textBox_makanan.Text,
                Kalori = kalori,
                Tanggal = tgl.Value
            };

            _controller.TambahData(makanan);
            MessageBox.Show("Data berhasil ditambahkan.");
            ClearInput();
            LoadData();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
                return;

            if (!int.TryParse(textBox_kalori.Text, out int kalori) || string.IsNullOrWhiteSpace(textBox_makanan.Text))
            {
                MessageBox.Show("Data tidak valid.");
                return;
            }

            var makanan = new Makanan
            {
                Id = selectedId,
                Nama = textBox_makanan.Text,
                Kalori = kalori,
                Tanggal = tgl.Value
            };

            _controller.PerbaruiData(makanan);
            MessageBox.Show("Data berhasil diperbarui.");
            ClearInput();
            LoadData();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
                return;

            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _controller.HapusData(selectedId);
                MessageBox.Show("Data dihapus.");
                ClearInput();
                LoadData();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                selectedId = Convert.ToInt32(selectedItem.Tag);
                textBox_makanan.Text = selectedItem.SubItems[1].Text;
                textBox_kalori.Text = selectedItem.SubItems[2].Text;
                tgl.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
            }
        }

        private void ClearInput()
        {
            textBox_makanan.Clear();
            textBox_kalori.Clear();
            tgl.Value = DateTime.Now;
            selectedId = -1;
        }

        private void HitungTotalKalori()
        {
            int total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += int.Parse(item.SubItems[2].Text);
            }

            textBox_total.Text = total.ToString();
            UpdateStatus(total);
        }

        private void UpdateStatus(int totalKalori)
        {
            if (totalKalori < 1500)
                textBox_status.Text = "Kurang";
            else if (totalKalori <= 2200)
                textBox_status.Text = "Cukup";
            else
                textBox_status.Text = "Berlebih";
        }

        private void InputData_Load(object sender, EventArgs e)
        {

        }

        private void textBox_makanan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
