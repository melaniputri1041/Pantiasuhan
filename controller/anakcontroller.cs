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
    class anakcontroller : model.connection
    {

        public DataTable tampilanak()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "select * from data_anak";
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

        public void dataanak(string kodeunik, string nama, string gender, string awalpanti, string statuss)
        {
            string anakanak = "insert into data_anak  values(" + "@kode_unik,@nama,@gender,@awalpanti,@statuss )";
            try
            {
                cmd = new MySqlCommand(anakanak, Getconn());
                cmd.Parameters.Add("@kode_unik", MySqlConnector.MySqlDbType.VarChar).Value = kodeunik;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@awalpanti", MySqlConnector.MySqlDbType.VarChar).Value = awalpanti;
                cmd.Parameters.Add("@statuss", MySqlConnector.MySqlDbType.VarChar).Value = statuss;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data anak gagal " + ex.Message);
            }
        }

        public void updateanak(string kodeunik, string nama, string gender, string awalpanti, string statuss)
        {
            string update = "update data_anak set " + "nama=@nama,gender=@gender,awalpanti=@awalpanti,statuss=@statuss where kode_unik=" + kodeunik;
            try
            {
                cmd = new MySqlCommand(update, Getconn());
                cmd.Parameters.Add("@kode_unik", MySqlConnector.MySqlDbType.Int24).Value = kodeunik;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@awalpanti", MySqlConnector.MySqlDbType.VarChar).Value = awalpanti;
                cmd.Parameters.Add("@statuss", MySqlConnector.MySqlDbType.VarChar).Value = statuss;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak ada data yang di update!!!");
            }
        }

        public void hapusdataanak(string kodeunik)
        {

                string delete = "DELETE FROM data_anak WHERE kode_unik=" + kodeunik;

                try
                {
                    cmd = new MySqlConnector.MySqlCommand(delete, Getconn());
                    cmd.Parameters.Add("@kode_unik", MySqlConnector.MySqlDbType.VarChar).Value = kodeunik;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed!!" + ex.Message);
                }
            
        }
    }
}
