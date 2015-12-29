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
    public partial class SkładanieZamówienia : Form
    {
        public SkładanieZamówienia()
        {
            InitializeComponent();
        }

        private void SkładanieZamówienia_Load(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Close();
        }

        private void SkładanieZamówienia_FormClosing(object sender, FormClosingEventArgs e)
        {
            WprowadzanieNowegoKlienta wnk = new WprowadzanieNowegoKlienta();
            wnk.Show();
        }
    }
}
