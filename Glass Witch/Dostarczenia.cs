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

        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public Dostarczenia()
        {
            InitializeComponent();
        }

        private void Dostarczenia_Load(object sender, EventArgs e)
        {
            
        }

        private void Zamowienie_Click(object sender, EventArgs e)
        {
            

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
