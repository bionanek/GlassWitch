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
    public partial class StaliKlienci : Form
    {
        //
        ConnectWithDataBase cwd = new ConnectWithDataBase();
        public StaliKlienci()
        {
            InitializeComponent();
        }

        private void StaliKlienci_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void StaliKlienci_Load(object sender, EventArgs e)
        {
            DataTable klienci = cwd.download_data("select * from Klienci");
            dgv1_StaliKlienci.DataSource = klienci;
        }
    }
}
