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
    }
}


