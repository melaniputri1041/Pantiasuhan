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
    public partial class syaratadop : Form
    {
        public syaratadop()
        {
            InitializeComponent();
        }

        private void syaratadop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuutama mu = new menuutama();
            mu.Show();
            this.Hide();
        }

    }
}
