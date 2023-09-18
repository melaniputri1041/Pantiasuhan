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
    class infaqcontroller : model.connection
    {
        public DataTable tampilinfaq()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "select * from infaquangya";
                da = new MySqlDataAdapter(tampil, Getconn());
                da.Fill(data);
                // fil berfungsi untuk menampilkan data ke data view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable tampilpeng()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "select * from detpengeluaran";
                da = new MySqlDataAdapter(tampil, Getconn());
                da.Fill(data);
                // fil berfungsi untuk menampilkan data ke data view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void infaqduit(string kodeunik, string nama, string tanggalinfaq, string gender, string alamat, string nominal)
        {
            string detailinfaq = "insert into infaquangya  values(" + "@kode_unik,@nama,@tanggalinfaq,@gender,@alamat,@nominal )";
            try
            {
                cmd = new MySqlCommand(detailinfaq, Getconn());
                cmd.Parameters.Add("@kode_unik", MySqlConnector.MySqlDbType.VarChar).Value = kodeunik;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@tanggalinfaq", MySqlConnector.MySqlDbType.VarChar).Value = tanggalinfaq;
                cmd.Parameters.Add("@gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@nominal", MySqlConnector.MySqlDbType.VarChar).Value = nominal;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Detail infaq gagal " + ex.Message);
            }
        }

        public void detailpengeluaran(string nomorbukti, string keperluan, string tanggal, string nominal)
        {
            string catpengeluaran = "insert into detpengeluaran values (" + "@nomorbukti,@keperluan,@tanggal,@nominal)";
            try
            {
                cmd = new MySqlCommand(catpengeluaran, Getconn());
                cmd.Parameters.Add("@nomorbukti", MySqlConnector.MySqlDbType.VarChar).Value = nomorbukti;
                cmd.Parameters.Add("@keperluan", MySqlConnector.MySqlDbType.VarChar).Value = keperluan;
                cmd.Parameters.Add("@tanggal", MySqlConnector.MySqlDbType.VarChar).Value = tanggal;
                cmd.Parameters.Add("@nominal", MySqlConnector.MySqlDbType.VarChar).Value = nominal;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah pengeluaran gagal " + ex.Message);
            }
        }

        public void getTotalInfaq()
        {
            string totalInfaq = "SELECT SUM(nominal) AS jumlah FROM infaquangya;";
            cmd = new MySqlCommand(totalInfaq, Getconn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Variabel_Infaq.getTotal = dr[0].ToString();
                
            }
        }

        public void OperasiTotal()
        {
            string total = "SELECT SUM(nominal) AS jumlah_pengeluaran FROM detpengeluaran;";
            cmd = new MySqlCommand(total, Getconn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Variabel_Infaq.getTotalPengeluaran = dr[0].ToString();

            }
        }


    }
}
