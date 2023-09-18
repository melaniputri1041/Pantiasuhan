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
using bismillahprojek.controller;

namespace bismillahprojek
{
	public partial class login : Form
	{
		panticontroller panti = new panticontroller();
		validasicontroller val = new validasicontroller();
		public login()
		{
			InitializeComponent();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}


		DataTable data = new DataTable();
		public MySqlCommand cmd;
		public DataSet ds;  //menyimpan data 
		public MySqlDataAdapter da;



		private void button4_Click(object sender, EventArgs e)
		{

			if (panti.login(textBox1.Text, textBox2.Text) == 1)
			{
				menuutama mu = new menuutama();
				mu.Show();
				this.Hide();
			}
			else
			{

				textBox1.Text = "";
				textBox2.Text = "";
				textBox1.Focus();


			}

		}

		private void login_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			val.huruf(e);
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			val.huruf(e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
