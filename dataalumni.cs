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
    public partial class dataalumni : Form
    {
        private panticontroller pntcontroller = new panticontroller();
        validasicontroller val = new validasicontroller();
        public dataalumni()
        {
            pntcontroller = new panticontroller();

            InitializeComponent();
        }

        private void dataalumni_Load(object sender, EventArgs e)
        {
            adospdata();
        }

        private void adospdata()
        {
            dataGridView1.DataSource = pntcontroller.tampiladop();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // berfungsi untuk membuat atau auto colom
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;user=root;database=panti_asuhan";
            MySqlConnection kon = new MySqlConnection(koneksi);

            kon.Open();
            string cari = "select * from formulir2 where concat(nomorunik,namaortu,tanggallahir,jeniskel,alamat,pekerjaan,penghasilan," +
                "kode_unik,nama,gender,awalpanti,statuss,tanggaladop) like '%" + textBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(cari, kon);
            DataTable tabel = new DataTable();
            da.Fill(tabel);
            dataGridView1.DataSource = tabel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_angka_simbol_spasi(e);
        }
    }
}
