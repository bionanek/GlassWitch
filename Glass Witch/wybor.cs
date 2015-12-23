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
        public wybor()
        {
            InitializeComponent();
        }

        private void wybor_Load(object sender, EventArgs e)
        {

            Start start = new Start();
            start.Close();
        }

        private void but_powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

       
        private void but_nowy_klient_Click(object sender, EventArgs e)
        {
            this.Hide();
            WprowadzanieNowegoKlienta wnk = new WprowadzanieNowegoKlienta();
            wnk.Show();
        }

        private void wybor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
