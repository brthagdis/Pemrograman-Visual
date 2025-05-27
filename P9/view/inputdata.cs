using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dietapp.Controllers;
using dietapp.Models;

namespace dietapp.Views
{
    public partial class InputDataForm : Form
    {
        private MakananController controller = new MakananController();
        private int selectedIndex = -1;
        private List<Makanan> makananList = new List<Makanan>();

        public InputDataForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listView1.Items.Clear();
            makananList = controller.GetAll();
            int i = 1;
            foreach (var m in makananList)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.Tag = m.Id;
                item.SubItems.Add(m.Nama);
                item.SubItems.Add(m.Kalori.ToString());
                item.SubItems.Add(m.Tanggal.ToString("yyyy-MM-dd"));
                listView1.Items.Add(item);
                i++;
            }
            HitungTotalKalori();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_kalori.Text, out int kalori) || string.IsNullOrEmpty(textBox_makanan.Text))
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

            controller.Insert(makanan);
            LoadData();
            ClearInput();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || !int.TryParse(textBox_kalori.Text, out int kalori)) return;

            var id = (int)listView1.Items[selectedIndex].Tag;
            var makanan = new Makanan
            {
                Id = id,
                Nama = textBox_makanan.Text,
                Kalori = kalori,
                Tanggal = tgl.Value
            };

            controller.Update(makanan);
            LoadData();
            ClearInput();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0) return;

            int id = (int)listView1.Items[selectedIndex].Tag;
            if (MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.Delete(id);
                LoadData();
                ClearInput();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedIndex = listView1.SelectedItems[0].Index;
                var selected = makananList[selectedIndex];
                textBox_makanan.Text = selected.Nama;
                textBox_kalori.Text = selected.Kalori.ToString();
                tgl.Value = selected.Tanggal;
            }
        }

        private void HitungTotalKalori()
        {
            int total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += int.Parse(item.SubItems[2].Text);
            }

            textBox_total.Text = total.ToString();
            textBox_status.Text = total < 1500 ? "Kurang" :
                                  total <= 2200 ? "Cukup" : "Berlebih";
        }

        private void ClearInput()
        {
            textBox_makanan.Clear();
            textBox_kalori.Clear();
            tgl.Value = DateTime.Now;
            selectedIndex = -1;
        }
    }
}
