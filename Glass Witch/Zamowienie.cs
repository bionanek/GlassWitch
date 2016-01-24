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
    public partial class Zamowienie : Form
    {

        DataTable klient;
        DateTime CurrentDate = DateTime.Today;
        ConnectWithDataBase cwd = new ConnectWithDataBase();
       
        public Zamowienie(DataTable dane_klient)
        {
            InitializeComponent();
            klient = dane_klient;
            
        }

        private void Zamowienie_Load(object sender, EventArgs e)
        {
            dgv1_produkty.DataSource = cwd.download_data("select * from Produkty");
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

            this.Hide();
            PodsumowanieZamowienia Podsumowanie = new PodsumowanieZamowienia(klient, CurrentYear, dgv1_produkty);
            Podsumowanie.Show();
        }
    }
}