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
    public partial class Ilosc : Form
    {
        WyborProduktow form1;
        public int ilosc_ozdob;
        public Ilosc(WyborProduktow forma)
        {
            this.form1 = forma;
            InitializeComponent();
        }

        private void but_zatwierdz_Click(object sender, EventArgs e)
        {
            form1.liczba_ozdob = int.Parse(txt_ilosc.Text);
            this.Close();
        }
    }
}
