﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glass_Witch
{
    public partial class WszystkieZamowienia : Form
    {
        //
        ConnectWithDataBase cwd = new ConnectWithDataBase(); //
        
        public WszystkieZamowienia()
        {
            InitializeComponent();
        }

        private void WszystkieZamowienia_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void WszystkieZamowienia_Load(object sender, EventArgs e)
        {
            DataTable zamowienia = cwd.download_data("select * from Zamowienia");
            dgv1_zamowienia.DataSource = zamowienia;
        }
    }
}
