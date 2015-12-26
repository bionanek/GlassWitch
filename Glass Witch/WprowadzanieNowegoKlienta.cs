using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glass_Witch
{
    public partial class WprowadzanieNowegoKlienta : Form
    {
        public WprowadzanieNowegoKlienta()
        {
            InitializeComponent();
        }

        private void WprowadzanieNowegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {          
            wybor wybor = new wybor();
            wybor.Show();           
        }

        private void adres_faktury_CheckedChanged(object sender, EventArgs e)
        {
            if(adres_faktury.Checked)
            {
                this.Size = new Size(660, 460);
            }
            else
            {
                this.Size = new Size(660, 645);
            }
        }

        private void button_DoZamowienia_Click(object sender, EventArgs e)
        {
            this.Hide();
            SkładanieZamówienia DoZamowienia = new SkładanieZamówienia();
            DoZamowienia.Show();
        }



        //TEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃ

        private void textBox_NazwaFirmy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KrajZamowienia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MiastoZamowienia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KodPocztowy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Ulica_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Telefon_TextChanged(object sender, EventArgs e)
        {

        }
        //TEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃTEXBOXY ZAMÓWIEŃ




        //TEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃ
        private void textBox_KrajDostarczenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MiastoDostarczenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KodPocztowyDostarczenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UlicaDostarczenia_TextChanged(object sender, EventArgs e)
        {

        }
        //TEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃTEXTBOXY DOSTARCZEŃ
    }
}