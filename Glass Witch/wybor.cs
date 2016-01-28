using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glass_Witch
{
    public partial class wybor : Form
    {
        private DataTable _wybraneProdukty;
        public wybor(DataTable wybraneProdukty)
        {
            InitializeComponent();
            _wybraneProdukty = wybraneProdukty;
        }

        private void wybor_Load(object sender, EventArgs e)
        {

        }

        private void but_powrot_Click(object sender, EventArgs e)
        {
            this.Close();
            Start start = new Start();
            start.Show();
        }

       
        private void but_nowy_klient_Click(object sender, EventArgs e)
        {
            this.Close();
            WprowadzanieNowegoKlienta wnk = new WprowadzanieNowegoKlienta();
            wnk.Show();
        }

        private void wybor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void but_staly_klient_Click(object sender, EventArgs e)
        {
            this.Close();
            DlaStalegoKlienta dsk = new DlaStalegoKlienta(_wybraneProdukty);
            dsk.Show();
        }
    }
}
