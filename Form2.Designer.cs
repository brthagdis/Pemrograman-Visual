namespace dietapp
{
    partial class InputData
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox_makanan = new TextBox();
            textBox_kalori = new TextBox();
            tgl = new DateTimePicker();
            textBox_total = new TextBox();
            textBox_status = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_save = new Button();
            button_history = new Button();
            button_bmi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label_makanan = new Label();
            label_kalori = new Label();
            label_total = new Label();
            label_status = new Label();

            SuspendLayout();
            // 
            // textBox_makanan
            // 
            textBox_makanan.Location = new Point(100, 12);
            textBox_makanan.Name = "textBox_makanan";
            textBox_makanan.Size = new Size(200, 23);
            textBox_makanan.TabIndex = 0;
            textBox_makanan.TextChanged += textBox_makanan_TextChanged;
            // 
            // textBox_kalori
            // 
            textBox_kalori.Location = new Point(100, 38);
            textBox_kalori.Name = "textBox_kalori";
            textBox_kalori.Size = new Size(200, 23);
            textBox_kalori.TabIndex = 1;
            // 
            // tgl
            // 
            tgl.Location = new Point(12, 70);
            tgl.Name = "tgl";
            tgl.TabIndex = 2;
            // 
            // textBox_total
            // 
            textBox_total.Location = new Point(100, 280);
            textBox_total.Name = "textBox_total";
            textBox_total.ReadOnly = true;
            textBox_total.TabIndex = 3;
            // 
            // textBox_status
            // 
            textBox_status.Location = new Point(100, 310);
            textBox_status.Name = "textBox_status";
            textBox_status.ReadOnly = true;
            textBox_status.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 116);
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 150);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Name = "columnHeader1";
            columnHeader1.Text = "No";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Name = "columnHeader2";
            columnHeader2.Text = "Nama Makanan";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Name = "columnHeader3";
            columnHeader3.Text = "Kalori";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Name = "columnHeader4";
            columnHeader4.Text = "Tanggal";
            columnHeader4.Width = 100;
            // 
            // button_add
            // 
            button_add.Location = new Point(160, 360);
            button_add.Name = "button_add";
            button_add.TabIndex = 6;
            button_add.Text = "Tambah";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(260, 360);
            button_update.Name = "button_update";
            button_update.TabIndex = 7;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(360, 360);
            button_delete.Name = "button_delete";
            button_delete.TabIndex = 8;
            button_delete.Text = "Hapus";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(360, 395);
            button_save.Name = "button_save";
            button_save.TabIndex = 10;
            button_save.Text = "Simpan";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button_history
            // 
            button_history.Location = new Point(160, 395);
            button_history.Name = "button_history";
            button_history.TabIndex = 11;
            button_history.Text = "History";
            button_history.UseVisualStyleBackColor = true;
            // 
            // button_bmi
            // 
            button_bmi.Location = new Point(260, 395);
            button_bmi.Name = "button_bmi";
            button_bmi.TabIndex = 12;
            button_bmi.Text = "BMI";
            button_bmi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label_makanan
            // 
            label_makanan.Location = new Point(12, 15);
            label_makanan.Name = "label_makanan";
            label_makanan.Size = new Size(80, 15);
            label_makanan.TabIndex = 0;
            label_makanan.Text = "Makanan";
            // 
            // label_kalori
            // 
            label_kalori.Location = new Point(12, 41);
            label_kalori.Name = "label_kalori";
            label_kalori.Size = new Size(80, 15);
            label_kalori.TabIndex = 1;
            label_kalori.Text = "Kalori";


            label_total.Location = new Point(12, 285);
            label_total.Name = "label_total";
            label_total.Size = new Size(80, 15);
            label_total.TabIndex = 0;
            label_total.Text = "Total Kalori";
            // 
            // label_kalori
            // 
            label_status.Location = new Point(12, 315);
            label_status.Name = "label_status";
            label_status.Size = new Size(80, 15);
            label_status.TabIndex = 1;
            label_status.Text = "Status Kalori";
            // 
            // InputData
            // 
            ClientSize = new Size(626, 433);
            Controls.Add(label_makanan);
            Controls.Add(label_kalori);
            Controls.Add(label_total);
            Controls.Add(label_status);
            Controls.Add(button_bmi);
            Controls.Add(button_history);
            Controls.Add(button_save);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(listView1);
            Controls.Add(textBox_status);
            Controls.Add(textBox_total);
            Controls.Add(tgl);
            Controls.Add(textBox_kalori);
            Controls.Add(textBox_makanan);
            Name = "InputData";
            Text = "Input Data Makanan";
            Load += InputData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_makanan;
        private System.Windows.Forms.TextBox textBox_kalori;
        private System.Windows.Forms.DateTimePicker tgl;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Button button_bmi;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_makanan;  // Tambahan deklarasi
        private System.Windows.Forms.Label label_kalori;   // Tambahan deklarasi
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_status;
    }
}
