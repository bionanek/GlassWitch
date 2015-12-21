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

        private void but_nowe_Click(object sender, EventArgs e)
        {
            this.Hide();
            wybor wybor = new wybor();
            wybor.Show();

        }
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectWithDataBase baza = new ConnectWithDataBase("JAKUB\\SQLEXPRESS", "GlassWitch");
            dataGridView1.DataSource = baza.download_data("Select * from Produkty");
        }
    }
}

// RUCHANKO W DUPALA