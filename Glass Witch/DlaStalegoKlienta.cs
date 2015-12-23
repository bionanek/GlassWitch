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
    public partial class DlaStalegoKlienta : Form
    {
        StaliKlienciModel skm = new StaliKlienciModel();
        public DlaStalegoKlienta()
        {
            InitializeComponent();
        }

        private void DlaStalegoKlienta_Load(object sender, EventArgs e)
        {

        }

        private void txt_szukajKlienta_TextChanged(object sender, EventArgs e)
        {
            txt_szukajKlienta.Text = txt_szukajKlienta.Text.ToLower();
        }

        private void but_szukajKlienta_Click(object sender, EventArgs e)
        {
            txt_szukajKlienta.Text = skm.GetData("dupa");
        }

        private void DlaStalegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            wybor wybor = new wybor();
            wybor.Show();
        }
    }
}