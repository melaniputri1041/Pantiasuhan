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
    public partial class pengeluaran : Form
    {
        private infaqcontroller incontroller;
        validasicontroller val = new validasicontroller();
        public pengeluaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("Data Tidak Boleh Kosong");
                pengeluaran pn = new pengeluaran();
                pn.Show();
                textBox1.Focus();
            }
            else
            {
                incontroller = new infaqcontroller();
                incontroller.detailpengeluaran(
                    textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text);
                /*this.Controls.Clear();
                this.InitializeComponent();
                textBox1.Focus();*/

                detailinfaq di = new detailinfaq();
                di.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pengeluaran_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.batas_nominal(textBox1,99999,e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.batas_nominal(textBox3, 2000000, e);

        }
    }
}
