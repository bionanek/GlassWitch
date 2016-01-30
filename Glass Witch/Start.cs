using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Glass_Witch
{
    public partial class Start : Form
    {
        
        public Start()
        {
            InitializeComponent();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void but_nowe_Click(object sender, EventArgs e)
        {
            WyborProduktow wp = new WyborProduktow();
            wp.Show(); 
        }

        private void but_wszystkie_Click(object sender, EventArgs e)
        {
            WszystkieZamowienia wz = new WszystkieZamowienia();
            wz.Show();
        }

        private void but_klienci_Click(object sender, EventArgs e)
        {
            StaliKlienci sk = new StaliKlienci();
            sk.Show();
        }

        private void but_dodajProdukt_Click(object sender, EventArgs e)
        {
            DodawanieProduktowDoBazy dpdb = new DodawanieProduktowDoBazy();
            dpdb.Show();
        }
    }
}

