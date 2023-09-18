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
using bismillahprojek.data_tampungan;

namespace bismillahprojek 
{
    public partial class detailinfaq : Form
    {
        private infaqcontroller incontroller;

        public detailinfaq()
        {
            incontroller = new infaqcontroller();
            InitializeComponent();
        }

        private void detailinfaq_Load(object sender, EventArgs e)
        {
            incontroller.getTotalInfaq();
            uang();
            peng();
            incontroller.OperasiTotal();
            label2.Text = operasi().ToString();
        }

        private void uang()
        {
            dataGridView1.DataSource = incontroller.tampilinfaq(); 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // berfungsi untuk membuat atau auto colom
        }
        private void peng()
        {
            dataGridView2.DataSource = incontroller.tampilpeng();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }

        public double operasi()
        {
            double hasil = Convert.ToDouble(Variabel_Infaq.getTotal) - Convert.ToDouble(Variabel_Infaq.getTotalPengeluaran);
            return hasil;
        }


    }
}
