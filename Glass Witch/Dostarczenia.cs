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
    public partial class Dostarczenia : Form
    {
        DateTime CurrentDate = DateTime.Today;

        ConnectWithDataBase cwd = new ConnectWithDataBase("ELVISZ\\SQLEXPRESS", "GlassWitch");

        public Dostarczenia()
        {
            InitializeComponent();
        }

        private void Dostarczenia_Load(object sender, EventArgs e)
        {
            txt_Data.Text = CurrentDate.ToString("d");
        }

        private void Zamowienie_Click(object sender, EventArgs e)
        {
            cwd.download_data("INSERT INTO Zamowienia VALUES ( '" +
                    txt_Data.Text + "', '" +
                    txt_DataOczekiwana.Text + "', '" +
                    txt_UlicaDostarczenia.Text + "', '" +
                    txt_MiastoDostarczenia.Text + "', '" +
                    txt_KodPocztowyDostarczenia.Text + "', '" +
                    txt_KrajDostarczenia.Text + "') ");

            this.Hide();
            SkładanieZamówienia DoZamowienia = new SkładanieZamówienia();
            DoZamowienia.Show();
        }

        private void Dostarczenia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            WprowadzanieNowegoKlienta wnk = new WprowadzanieNowegoKlienta();
            wnk.Show();
        }
    }
}
