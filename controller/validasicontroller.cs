using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bismillahprojek.controller
{
    class validasicontroller
    {
        public Boolean huruf(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^A-Za-z\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;

        }


        public Boolean hurufgen(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^P,L\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;

        }

        public Boolean huruf_spasi(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^A-Za-z\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean huruf_angka_spasi(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^A-Za-z0-9\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        public Boolean huruf_simbol_spasi(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^A-Za-z.,\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean huruf_angka_simbol_spasi(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^A-Za-z0-9.,\b\x20]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean angka(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean batas_nominal(TextBox TB,int batas, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((!char.IsDigit(c)||Convert.ToInt32(TB.Text+c)>batas|| TB.Text=="0") && c!= '\b')
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public Boolean batas_nominal2(TextBox TB, int batas, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) || Convert.ToInt32(TB.Text + c) > batas || TB.Text == "0") && c != '\b')
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        

    }
}
