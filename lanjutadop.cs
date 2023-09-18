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
    public partial class lanjutadop : Form
    {
        private panticontroller pntcontroller;
        validasicontroller val = new validasicontroller();
        public lanjutadop()
        {
            pntcontroller = new panticontroller();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("lengkapi data diatas terlebih dahulu!!", "Peringatan!!");
                Application.Exit();
            }
            else
            {
                pntcontroller = new panticontroller();
                pntcontroller.dataadop(
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, dateTimePicker1.Text);

                dataalumni du = new dataalumni();
                du.Show();
                this.Hide();
            }

            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lanjutadop_Load(object sender, EventArgs e)
        {

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
            val.huruf_angka_simbol_spasi(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.hurufgen(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.angka(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            val.angka(e);
*/        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.hurufgen(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_angka_simbol_spasi(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.huruf_spasi(e);
        }
    }
}
