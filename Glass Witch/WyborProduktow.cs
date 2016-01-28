using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Glass_Witch
{
    public partial class WyborProduktow : Form
    {
        string wybranaWaluta = "";
        public int liczba_ozdob = 0;
        ConnectWithDataBase cwd = new ConnectWithDataBase();
        DataTable _produkty;
        DataTable _daneProduktu;
        private DataTable wybraneProdukty;
        private DataRow row;

        int index;
        private int zamowienieID;

        public WyborProduktow()
        {
            InitializeComponent();
        }

        public DataTable ZwrocTabele()
        {
            return wybraneProdukty;
        }
        private void WyborProduktow_Load(object sender, EventArgs e)
        {
            
            dgv1_produkty.ReadOnly = true;
            
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
                    for (int j = 0; j < 2; j++)
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

            DataGridViewRow clonedRow = (DataGridViewRow) dgv1_produkty.Rows[index].Clone();
            for (int ind = 0; ind < dgv1_produkty.Rows[index].Cells.Count; ind++)
            {
                clonedRow.Cells[ind].Value = dgv1_produkty.Rows[index].Cells[ind].Value;
            }

            dgv1_wybraneProdukty.Rows.Add(clonedRow);

            Ilosc ilosc = new Ilosc(this);
            ilosc.ShowDialog();


            dgv1_wybraneProdukty.Rows[dgv1_wybraneProdukty.RowCount - 1].
                Cells[dgv1_wybraneProdukty.Columns["ilosc"].Index].Value = liczba_ozdob;

            double cenaOzdoby = double.Parse(dgv1_wybraneProdukty.Rows[dgv1_wybraneProdukty.RowCount - 1].
                Cells[dgv1_wybraneProdukty.Columns["waluta"].Index].Value.ToString());

            switch (cmb_waluta.SelectedIndex)
            {
                case 0:
                {
                    dgv1_wybraneProdukty.Rows[dgv1_wybraneProdukty.RowCount - 1].
                        Cells[dgv1_wybraneProdukty.Columns["suma"].Index].Value = (cenaOzdoby * liczba_ozdob) + " €";
                    break;
                }
                case 1:
                {
                    dgv1_wybraneProdukty.Rows[dgv1_wybraneProdukty.RowCount - 1].
                        Cells[dgv1_wybraneProdukty.Columns["suma"].Index].Value = (cenaOzdoby * liczba_ozdob) + " $";
                    break;
                }
                case 2:
                {
                        dgv1_wybraneProdukty.Rows[dgv1_wybraneProdukty.RowCount - 1].
                            Cells[dgv1_wybraneProdukty.Columns["suma"].Index].Value = (cenaOzdoby * liczba_ozdob) + " PLN";
                    break;
                }

            }
        }

        private void dgv1_produkty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            but_dodaj.Enabled = true;
        }

        private void cmb_waluta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            switch (cmb_waluta.SelectedIndex)
            {
                case 0:
                {
                    _produkty = 
                            cwd.download_data("select ProduktID, Nazwa, Rok, Pakowanie, IloscMagazyn, CenaEUR from Produkty");
                    wybranaWaluta = "Euro";

                    break;
                }
                case 1:
                {
                    _produkty =
                        cwd.download_data("select ProduktID, Nazwa, Rok, Pakowanie, IloscMagazyn, CenaDOL from Produkty");
                    wybranaWaluta = "Dolar";
                    break;
                }
                case 2:
                {
                    _produkty =
                        cwd.download_data("select ProduktID, Nazwa, Rok, Pakowanie, IloscMagazyn, CenaPln from Produkty");
                    wybranaWaluta = "PLN";
                    break;
                }

            }
            dgv1_wybraneProdukty.Columns.Clear();
            dgv1_wybraneProdukty.Columns.Add("produktid", "ID");
            dgv1_wybraneProdukty.Columns.Add("nazwa", "Nazwa");
            dgv1_wybraneProdukty.Columns.Add("rok", "Rok");
            dgv1_wybraneProdukty.Columns.Add("pakowanie", "Pakowanie");
            dgv1_wybraneProdukty.Columns.Add("magazyn", "Magazyn");
            dgv1_wybraneProdukty.Columns.Add("waluta", wybranaWaluta);
            dgv1_wybraneProdukty.Columns.Add("suma", "Suma");
            dgv1_wybraneProdukty.Columns.Add("ilosc", "Ilość");
            foreach (DataGridViewColumn col in dgv1_wybraneProdukty.Columns)
            {
                col.ReadOnly = true;
            }
            dgv1_wybraneProdukty.Columns["suma"].ReadOnly = false;

            dgv1_produkty.DataSource = _produkty;
        }

        private void but_doKlienta_Click(object sender, EventArgs e)
        {
            wybraneProdukty = new DataTable();
            foreach (DataGridViewColumn col in dgv1_wybraneProdukty.Columns)
            {
                wybraneProdukty.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgv1_wybraneProdukty.Rows)
            {
                DataRow dRow = wybraneProdukty.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                wybraneProdukty.Rows.Add(dRow);
            }

            wybor wybor = new wybor(wybraneProdukty);
            wybor.Show();
            this.Close();
            
        }
    }
}
