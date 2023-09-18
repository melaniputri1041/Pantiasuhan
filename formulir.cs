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
    public partial class formulir : Form
    {
        private anakcontroller ancontroller;
        validasicontroller val = new validasicontroller();

        public formulir()
        {
            ancontroller = new anakcontroller();

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }


        private void anak2()
        {
            dataGridView1.DataSource = ancontroller.tampilanak();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // berfungsi untuk membuat atau auto colom
        }
        private void formulir_Load(object sender, EventArgs e)
        {
            anak2();
            gend();
            pekerjaan();
        }


        private void button3_Click(object sender, EventArgs e)
        {


            if (textnik.Text == "" || textname.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || textala.Text == ""
                 ||comboBox2.Text =="" || textpeng.Text == "")
            {
                MessageBox.Show("DATA TIDAK BOLEH KOSONG !!!!");
                textnik.Clear();
                textname.Clear();
                textala.Clear();
                textpeng.Clear();

                formulir fr = new formulir();
                fr.Show();
                this.Hide();

            }
            else
            {
                lanjutadop la = new lanjutadop();
                la.Show();
                this.Hide();


                la.textBox1.Text = this.textnik.Text;
                la.textBox2.Text = this.textname.Text;
                la.textBox3.Text = this.dateTimePicker1.Text;
                la.textBox4.Text = this.comboBox1.Text;
                la.textBox5.Text = this.textala.Text;
                la.textBox6.Text = this.comboBox2.Text;
                la.textBox7.Text = this.textpeng.Text;
                la.textBox8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                la.textBox9.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                la.textBox10.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                la.textBox11.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                la.textBox12.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                ancontroller = new anakcontroller();
                string selectedValue = dataGridView1.SelectedRows[0].Cells["kode_unik"].Value.ToString();

                ancontroller.hapusdataanak(selectedValue);

                anak2();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void gend()
        {

            comboBox1.Items.Add('P');
            comboBox1.Items.Add('L');
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
        }

        private void textnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.angka(e);
        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem.ToString();
        }

        void pekerjaan()
        {
            comboBox2.Items.Add("PNS");
            comboBox2.Items.Add("WIRASWATA");
            comboBox2.Items.Add("PENGUSAHA");
        }

        private void textpeng_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.angka(e);
        }

        private void textala_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }
    }
}
