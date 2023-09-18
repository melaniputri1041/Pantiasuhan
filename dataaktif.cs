using bismillahprojek.controller;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bismillahprojek
{
    public partial class dataaktif : Form
    {
        private anakcontroller ancontroller;
        validasicontroller val = new validasicontroller();


        public dataaktif()
        {
            ancontroller = new anakcontroller();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox8.Text == "" || comboBox3.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" 
                || textBox3.Text == " " || textBox8.Text == " " || comboBox3.Text == " " || dateTimePicker1.Text == " " || comboBox1.Text == " ")
            {
                MessageBox.Show("lengkapi data diatas terlebih dahulu!!", "Peringatan!!");
                textBox3.Clear();
                textBox8.Clear();
            }
            else
            {
                ancontroller = new anakcontroller();
                ancontroller.dataanak(
                    textBox3.Text, textBox8.Text, comboBox3.Text, dateTimePicker1.Text, comboBox1.Text);
                /*this.Controls.Clear();
                this.InitializeComponent();
                textBox1.Focus();*/

                dataaktif dk = new dataaktif();
                this.Hide();
                dk.Show();
            }

        }

        private void anak()
        {
            dataGridView1.DataSource = ancontroller.tampilanak();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // berfungsi untuk membuat atau auto colom
        }

        private void dataaktif_Load(object sender, EventArgs e)
        {
            anak();
            munculcombo();
            status();
        }

        void munculcombo()
        {

            comboBox3.Items.Add('P');
            comboBox3.Items.Add('L');
        }
        void status()
        {
            comboBox1.Items.Add("Yatim");
            comboBox1.Items.Add("Piatu");
            comboBox1.Items.Add("Tidak Diketahui");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ancontroller = new anakcontroller();
            ancontroller.updateanak(
                textBox3.Text, textBox8.Text, comboBox3.Text, dateTimePicker1.Text, comboBox1.Text);



            dataaktif dk = new dataaktif();
            this.Hide();
            dk.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ancontroller = new anakcontroller();
            string selectedValue = dataGridView1.SelectedRows[0].Cells["kode_unik"].Value.ToString();
            ancontroller.hapusdataanak(selectedValue);
            anak();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;user=root;database=panti_asuhan";
            MySqlConnection kon = new MySqlConnection(koneksi);

            kon.Open();
            string cari = "select * from data_anak where concat(kode_unik, nama,gender, " +
                "awalpanti, statuss) like '%" + textBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(cari, kon);
            DataTable tabel = new DataTable();
            da.Fill(tabel);
            dataGridView1.DataSource = tabel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.batas_nominal(textBox3, 99999, e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.hurufgen(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_angka_simbol_spasi(e);
        }
    }
}
