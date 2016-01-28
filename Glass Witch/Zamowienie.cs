using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Glass_Witch
{
    public partial class Zamowienie : Form
    {
        DataGridView data_produkty;
        DataTable klient;
        private DataTable _wybraneProdukty;
        DateTime CurrentDate = DateTime.Today;
        
        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public Zamowienie(DataTable dane_klient, DataTable wybraneProdukty)
        {
            InitializeComponent();
            klient = dane_klient;
            _wybraneProdukty = wybraneProdukty;
        }

        private void Zamowienie_Load(object sender, EventArgs e)
        {
            WyborProduktow wp = new WyborProduktow();
            
            dgv1_wybraneProdukty.DataSource = _wybraneProdukty;

            // USUNIĘCIE NIEPOTRZEBNYCH KOLUMN
            dgv1_wybraneProdukty.Columns.Remove("Nazwa");
            dgv1_wybraneProdukty.Columns.Remove("Rok");
            dgv1_wybraneProdukty.Columns.Remove("Magazyn");
            dgv1_wybraneProdukty.Columns.Remove("Pakowanie");

            // USTAWIENIE KOLEJNOŚCI KOLUMN
            dgv1_wybraneProdukty.Columns[0].DisplayIndex = 0;
            dgv1_wybraneProdukty.Columns[1].DisplayIndex = 1;
            dgv1_wybraneProdukty.Columns[2].DisplayIndex = 3;
            dgv1_wybraneProdukty.Columns[3].DisplayIndex = 2;

            // ZMIANA NAGŁÓWKÓW NA ANGIELSKIE
            dgv1_wybraneProdukty.Columns[0].HeaderText = "Product ID";
            dgv1_wybraneProdukty.Columns[1].HeaderText = "Price";
            dgv1_wybraneProdukty.Columns[2].HeaderText = "Total price";
            dgv1_wybraneProdukty.Columns[3].HeaderText = "Quantity";

            // PRZYPISANIE DANYCH KLIENTA DO LABELI
            lab_nazwa.Text = klient.Rows[0]["Nazwa"].ToString();
            lab_ulica.Text = klient.Rows[0]["Ulica"].ToString();
            lab_KrajKod.Text = klient.Rows[0]["KodPocztowy"].ToString() + " " +
                klient.Rows[0]["Kraj"].ToString();
            lab_vat.Text = klient.Rows[0]["VatNo"].ToString();
            lab_osobaKontaktowa.Text = klient.Rows[0]["OsobaKontaktowa"].ToString();
            lab_mail.Text = klient.Rows[0]["Email"].ToString();
            lab_data.Text = CurrentDate.ToString("d");

        }

        private void Zamowienie_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void but_zatwierdź_Click(object sender, EventArgs e)
        {
            int CurrentYear = CurrentDate.Year;

            /*this.Hide();
            PodsumowanieZamowienia Podsumowanie = new PodsumowanieZamowienia(klient, CurrentYear, dgv1_wybraneProdukty);
            Podsumowanie.Show(); */

            this.Hide();
            PodsumowanieZamówienia1 Podsumowanie1 = new PodsumowanieZamówienia1(klient, CurrentYear, dgv1_wybraneProdukty);
            Podsumowanie1.Show();
        }
    }
}