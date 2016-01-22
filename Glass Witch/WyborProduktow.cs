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
    public partial class WyborProduktow : Form
    {
        ConnectWithDataBase cwd = new ConnectWithDataBase();
        DataTable _produkty;
        DataTable _daneProduktu;
        private DataRow row;
        private DataTable wybranyWiersz;


        int index;
        public WyborProduktow()
        {
            InitializeComponent();
        }

        private void WyborProduktow_Load(object sender, EventArgs e)
        {
            

            _produkty = cwd.download_data("select * from Produkty");
            dgv1_produkty.DataSource = _produkty;
            dgv1_wybraneProdukty.Columns.Add("ProduktID", "ID");
            dgv1_wybraneProdukty.Columns.Add("Nazwa", "Nazwa");
            dgv1_wybraneProdukty.Columns.Add("Rok", "Rok");
            dgv1_wybraneProdukty.Columns.Add("Pakowanie", "Pakowanie");
            dgv1_wybraneProdukty.Columns.Add("Ilość Magazyn", "IloscMagazyn");
            dgv1_wybraneProdukty.Columns.Add("CenaEUR", "Euro");
            dgv1_wybraneProdukty.Columns.Add("CenaDOL", "Dolary");
            dgv1_wybraneProdukty.Columns.Add("CenaPln", "Pln");
        }

        private void txt_szukaj_TextChanged(object sender, EventArgs e)
        {
            string zawartoscKomorki = "";
            bool znalezione = false;
            bool pierwszePrzejscie = false;
            DataTable zawartoscWiersza = _produkty.Clone();

            if (string.IsNullOrWhiteSpace(txt_szukaj.Text))
            {
                dgv1_produkty.DataSource = _produkty;
            }
            else
            {
                for (int i = 0; i < _produkty.Rows.Count; i++)
                {
                    znalezione = false;
                    for (int j = 0; j < _produkty.Columns.Count; j++)
                    {
                        zawartoscKomorki = _produkty.Rows[i][j].ToString().ToLower();
                        if (zawartoscKomorki.IndexOf(txt_szukaj.Text.ToLower()) >= 0)
                        {
                            znalezione = true;
                        }
                        else { }
                        if (znalezione == true)
                        {
                            if (pierwszePrzejscie == false)
                            {
                                pierwszePrzejscie = true;
                                dgv1_produkty.DataSource = null;
                            }
                            zawartoscWiersza.ImportRow(_produkty.Rows[i]);
                            znalezione = false;
                            dgv1_produkty.DataSource = zawartoscWiersza;

                        }
                    }
                }
            }
        }

        private void but_dodaj_Click(object sender, EventArgs e)
        {
            _daneProduktu = _produkty.Clone();
            //if (_daneProduktu == null)
            //{
            //    _daneProduktu = cwd.download_data("select * from Produkty where Nazwa = '" +
            //                                      dgv1_produkty.Rows[index].Cells[1].Value.ToString() + "'");
            //}
            //else
            //{
            //    _daneProduktu.ImportRow(wybranyWiersz.Rows[0]);

            //}
            //wybranyWiersz.Clear();

            _daneProduktu.ImportRow(_produkty.Rows[0]);
            _daneProduktu.ImportRow(_produkty.Rows[1]);

            dgv1_wybraneProdukty.DataSource = _daneProduktu;

            //foreach (DataGridViewRow row in dgv1_produkty.SelectedRows)
            //{
            //    dgv1_wybraneProdukty.Rows.Add(row);

            //}

        }

        private void dgv1_produkty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            wybranyWiersz= cwd.download_data("select * from Produkty where Nazwa = '" +
                                              dgv1_produkty.Rows[index].Cells[1].Value.ToString() + "'");
        }
    }
}
