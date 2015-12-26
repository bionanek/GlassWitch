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
        int wybranyWiersz = 0;
        string nazwa;
        string kraj;


        StaliKlienciModel skm = new StaliKlienciModel();
        ConnectWithDataBase cwd = new ConnectWithDataBase("JAKUB\\SQLEXPRESS", "GlassWitch");
        public DlaStalegoKlienta()
        {
            InitializeComponent();
        }

        private void DlaStalegoKlienta_Load(object sender, EventArgs e)
        {
            int szerokosc = 0;
            int wysokosc = 0;

            dgv1_zamStaliKlienci.DataSource = cwd.download_data("select Nazwa, Kraj from Klienci");

           /* foreach (DataGridViewColumn col in dgv1_zamStaliKlienci.Columns)
            {
                szerokosc += col.Width;
                

            }
            dgv1_zamStaliKlienci.Width = szerokosc + dgv1_zamStaliKlienci.RowHeadersWidth + 2;*/
            dgv1_zamStaliKlienci.Rows[0].Selected = false;

        }

        private void txt_szukajKlienta_TextChanged(object sender, EventArgs e)
        {
            txt_szukajKlienta.Text = txt_szukajKlienta.Text.ToLower();
        }

        private void but_szukajKlienta_Click(object sender, EventArgs e)
        {
            nazwa = dgv1_zamStaliKlienci.SelectedCells[0].Value.ToString();
            kraj = dgv1_zamStaliKlienci.SelectedCells[1].Value.ToString();
            textBox1.Text = nazwa + " z  kraju " + kraj;   
        } 

        private void DlaStalegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            wybor wybor = new wybor();
            wybor.Show();
        }



        private void dgv1_zamStaliKlienci_SelectionChanged(object sender, EventArgs e)
        {
            wybranyWiersz = dgv1_zamStaliKlienci.CurrentCell.RowIndex;
        }
    }
} 



// DupaoooO