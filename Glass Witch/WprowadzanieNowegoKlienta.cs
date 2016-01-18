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
        DateTime CurrentDate = DateTime.Today;

        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "OPCJONALNE")
            {
                tb.Text = " ";
                tb.ForeColor = Color.Black;
            }
        } 
        
        public WprowadzanieNowegoKlienta()
        {
            InitializeComponent();
        }


        private void WprowadzanieNowegoKlienta_Load(object sender, EventArgs e)
        {
            txt_Data.Text = CurrentDate.ToString("d");

            txt_OsobaKontakt.GotFocus += new EventHandler(this.TextGotFocus);
            txt_StanowiskoKontakt.GotFocus += new EventHandler(this.TextGotFocus);
            txt_Telefon.GotFocus += new EventHandler(this.TextGotFocus);
            txt_VatNo.GotFocus += new EventHandler(this.TextGotFocus);  
        }


        private void WprowadzanieNowegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {
            wybor wybor = new wybor();
            wybor.Show();
        }

        private void button_DoZamowienia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NazwaFirmy.Text)          ||
                string.IsNullOrWhiteSpace(txt_Ulica.Text)               ||
                string.IsNullOrWhiteSpace(txt_MiastoZamowienia.Text)    ||
                string.IsNullOrWhiteSpace(txt_KrajZamowienia.Text)      ||
                string.IsNullOrWhiteSpace(txt_KodPocztowy.Text)         ||
                string.IsNullOrWhiteSpace(txt_Email.Text))
            {

                MessageBox.Show("WYPEŁNIJ WSZYSTKIE WYMAGANE POLA");

            } else
            {
                cwd.download_data("INSERT INTO Klienci VALUES ( '" +
                txt_NazwaFirmy.Text + "', '" +
                txt_OsobaKontakt.Text + "', '" +            //OPCJONALNE
                txt_StanowiskoKontakt.Text + "', '" +       //OPCJONALNE
                txt_Ulica.Text + "', '" +
                txt_MiastoZamowienia.Text + "', '" +
                txt_KodPocztowy.Text + "', '" +
                txt_KrajZamowienia.Text + "', '" +
                txt_VatNo.Text + "', '" +                   //OPCJONALNE    
                txt_Telefon.Text + "', '" +                 //OPCJONALNE
                txt_Email.Text + "') ");

                if (adres_faktury.Checked == false)
                {

                int klientid =
                       int.Parse(cwd.download_data("Select KlientID from Klienci where Nazwa = '" + 
                       txt_NazwaFirmy.Text + "'").Rows[0][0].ToString());
                cwd.download_data("INSERT INTO Zamowienia VALUES ( " +
                klientid + " , '" +
                CurrentDate + "', '" +
                txt_DataOczekiwana.Text + "'," +
                "null, '" +
                txt_UlicaDostarczenia.Text + "', '" +
                txt_MiastoDostarczenia.Text + "', '" +
                txt_KodPocztowyDostarczenia.Text + "', '" +
                txt_KrajDostarczenia.Text + "') ");

                }

                this.Hide();
                SkładanieZamówienia DoZamowienia = new SkładanieZamówienia();
                DoZamowienia.Show();
            }
        }

        private void adres_faktury_CheckedChanged(object sender, EventArgs e)
        {
            if (adres_faktury.Checked)
            {
                this.Size = new Size(750, 400);
            }
            else
            {
                this.Size = new Size(750, 570);
            }
        }
    }
}