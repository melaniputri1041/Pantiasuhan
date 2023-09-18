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
    public partial class menuutama : Form
    {
        public menuutama()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                login lg = new login();
                lg.Show();
                this.Hide();       
        }

        private void label4_Click(object sender, EventArgs e)
        {
            infaquang iu = new infaquang();
            iu.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            syaratadop sa = new syaratadop();
            sa.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            formulir fo = new formulir();
            fo.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            dataaktif da = new dataaktif();
            da.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            dataalumni du = new dataalumni();
            du.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infaquang iu = new infaquang();
            iu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pengeluaran pn = new pengeluaran();
            pn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            syaratadop sa = new syaratadop();
            sa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formulir fo = new formulir();
            fo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataaktif da = new dataaktif();
            da.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            dataalumni du = new dataalumni();
            du.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            detailinfaq di = new detailinfaq();
            di.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
