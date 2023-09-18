using bismillahprojek.controller;
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
    public partial class infaquang : Form
    {
        private infaqcontroller incontroller;
        validasicontroller val = new validasicontroller();
        public infaquang()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""|| textBox2.Text == " " || dateTimePicker1.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("lengkapi data terlebih dahulu!!!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                infaquang iu = new infaquang();
                this.Hide();
                iu.Show();
                textBox1.Focus();
            }
            else
            {
                incontroller = new infaqcontroller();
                incontroller.infaqduit(
                    textBox1.Text, textBox2.Text, dateTimePicker1.Text, comboBox1.Text, textBox3.Text, textBox4.Text);


                detailinfaq di = new detailinfaq();
                di.Show();
                this.Hide();
            }
        }

        private void infaquang_Load(object sender, EventArgs e)
        {
            munculcombo();
        }

        void munculcombo()
        {

            comboBox1.Items.Add('P');
            comboBox1.Items.Add('L');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            this.Hide();
            mu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.angka(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_simbol_spasi(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.angka(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
