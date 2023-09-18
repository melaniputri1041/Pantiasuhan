using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bismillahprojek.model
{
    class connection
    {

        public MySqlCommand cmd;
        public DataSet ds;  //menyimpan data 
        public MySqlDataAdapter da;
        public MySqlDataReader dr;

        public MySqlConnection Getconn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; user=root; database=panti_asuhan;AllowUserVariables=true";
            //connectionstring menyambungkan ke database
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("kembali gagal " + ex.Message);
            }
            return conn;
        }
    }
}
