using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bismillahprojek.data_tampungan;


namespace bismillahprojek.controller
{
    class panticontroller : model.connection
    {
        public DataTable tampiladop()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "select * from formulir2";
                da = new MySqlConnector.MySqlDataAdapter(tampil, Getconn());
                da.Fill(data);
                // fil berfungsi untuk menampilkan data ke data view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return data;

        }



        public void dataadop(string nomorunik, string namaortu, string tanggallahir, string jeniskel, string alamat, string pekerjaan, string penghasilan, string kodeunik, string nama, string gender, string awalpanti, string statuss, string tanggaladop)
        {
            string anakanak = "insert into formulir2  values(" + "@nomorunik,@namaortu,@tanggallahir,@jeniskel,@alamat,@pekerjaan,@penghasilan,@kodeunik,@nama,@gender,@awalpanti,@statuss,@tanggaladop )";
            try
            {
                cmd = new MySqlCommand(anakanak, Getconn());
                cmd.Parameters.Add("@nomorunik", MySqlConnector.MySqlDbType.VarChar).Value = nomorunik;
                cmd.Parameters.Add("@namaortu", MySqlConnector.MySqlDbType.VarChar).Value = namaortu;
                cmd.Parameters.Add("@tanggallahir", MySqlConnector.MySqlDbType.VarChar).Value = tanggallahir;
                cmd.Parameters.Add("@jeniskel", MySqlConnector.MySqlDbType.VarChar).Value = jeniskel;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@pekerjaan", MySqlConnector.MySqlDbType.VarChar).Value = pekerjaan;
                cmd.Parameters.Add("@penghasilan", MySqlConnector.MySqlDbType.VarChar).Value = penghasilan;
                cmd.Parameters.Add("@kodeunik", MySqlConnector.MySqlDbType.VarChar).Value = kodeunik;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@awalpanti", MySqlConnector.MySqlDbType.VarChar).Value = awalpanti;
                cmd.Parameters.Add("@statuss", MySqlConnector.MySqlDbType.VarChar).Value = statuss;
                cmd.Parameters.Add("@tanggaladop", MySqlConnector.MySqlDbType.VarChar).Value = tanggaladop;



                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data anak gagal " + ex.Message);
            }
        }


        public int login(string username, string password)
        {

            int a = 0;
            int cek = 0;
            string login = "select username,passwordd from admin where username = '" + username + "' and passwordd='" + password + "';";
            cmd = new MySqlCommand(login, Getconn());
            dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("BERHASIL LOGIN");
                    cek = 1;
                }
                else
                {
                    MessageBox.Show("ANDA GAGAL LOGIN");
                    a++;
                }
                return cek;
            


        }
    }
}
