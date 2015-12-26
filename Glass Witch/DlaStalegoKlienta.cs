using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Glass_Witch
{
    public partial class DlaStalegoKlienta : Form
    {
        SqlConnection connection = new SqlConnection();
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        int klik = 0;
        int wybranyWiersz = 0;
        string nazwa;
        string kraj;
        string daneKlienta;

        StaliKlienciModel skm = new StaliKlienciModel();
        ConnectWithDataBase cwd = new ConnectWithDataBase("JAKUB\\SQLEXPRESS", "GlassWitch");
        public DlaStalegoKlienta()
        {
            InitializeComponent();
        }
     

        private void DlaStalegoKlienta_Load(object sender, EventArgs e)
        {
            dgv1_zamStaliKlienci.DataSource = cwd.download_data("select Nazwa, Kraj from Klienci");
            dgv1_zamStaliKlienci.Rows[0].Selected = false;

            string test = "hello";

            ToolTip1.SetToolTip(this.but_szukajKlienta, DownloadCustomerDataToString());


            int szerokosc = 0;
            int wysokosc = 0;

            

        }
        public string DownloadCustomerDataToString()
        {

            for (int i = 1; i <= 10; i++)
            {
                daneKlienta += cwd.download_data("Select * from Klienci where Nazwa = '" + nazwa + "'").Rows[0][i].ToString() + " ";
            }
            return daneKlienta;
        }

        private void txt_szukajKlienta_TextChanged(object sender, EventArgs e)
        {
            txt_szukajKlienta.Text = txt_szukajKlienta.Text.ToLower();
        }

        private void but_szukajKlienta_Click(object sender, EventArgs e)
        {
            txt_szukajKlienta.Text = nazwa;
        }

        private void DlaStalegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            wybor wybor = new wybor();
            wybor.Show();
        }



        private void dgv1_zamStaliKlienci_SelectionChanged(object sender, EventArgs e)
        {
            daneKlienta = "";
            wybranyWiersz = dgv1_zamStaliKlienci.CurrentCell.RowIndex;
            nazwa = dgv1_zamStaliKlienci.Rows[wybranyWiersz].Cells[0].Value.ToString();
            if (klik > 3)
            {
                ToolTip1.SetToolTip(this.but_szukajKlienta, DownloadCustomerDataToString());
            }

            klik++;
        }
    }
} 



