using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private string termin;

        public Zamowienie(DataTable dane_klient, DataTable wybraneProdukty, string deadline)
        {
            InitializeComponent();
            klient = dane_klient;
            _wybraneProdukty = wybraneProdukty;
            termin = deadline;
        }

        public Zamowienie()
        {
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
            lab_kodPocztowy.Text = klient.Rows[0]["KodPocztowy"].ToString();
            lab_kraj.Text = klient.Rows[0]["Kraj"].ToString();
            lab_miasto.Text = klient.Rows[0]["Miasto"].ToString();
            lab_vat.Text = klient.Rows[0]["VatNo"].ToString();
            lab_osobaKontaktowa.Text = klient.Rows[0]["OsobaKontaktowa"].ToString();
            lab_mail.Text = klient.Rows[0]["Email"].ToString();
            lab_data.Text = CurrentDate.ToString("d");
            lab_termin.Text = termin;

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
            int klientid =
                int.Parse(cwd.download_data("Select KlientID from Klienci where Nazwa = '" +
                                            lab_nazwa.Text + "'").Rows[0][0].ToString());

            cwd.download_data("insert into Zamowienia VALUES ( " +
                klientid + " , '" +
                CurrentDate + "' , '" +
                termin + "' ," +
                "null, '" +
                lab_ulica.Text + "', '" +
                lab_miasto.Text + "', '" +
                lab_kodPocztowy.Text + "', '" +
                lab_kraj.Text + "') " );

            char waluta =
                _wybraneProdukty.Rows[0][6].ToString()[_wybraneProdukty.Rows[0][6].ToString().Length - 1];
            string StrQuery;
            int zamowienieid = Int32.Parse(cwd.download_data("select max(ZamowienieID) from Zamowienia").Rows[0][0].ToString());

            string cena;
            
                using (SqlConnection conn = new SqlConnection("Server = localhost\\SQLEXPRESS    ;" +
                                                              "Database = GlassWitch;" +
                                                              "User Id = sa;" +
                                                              "Password = jakubelvisz;"))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();
                        

                        for (int wiersze = 0; wiersze < dgv1_wybraneProdukty.Rows.Count; wiersze++)
                        {
                            string nowaCena;
                            cena = dgv1_wybraneProdukty.Rows[wiersze].Cells[1].Value.ToString();
                            if (cena.IndexOf(',') >= 0)
                            {
                                int przecinek = cena.IndexOf(',');
                                StringBuilder sb = new StringBuilder(cena);
                                sb[przecinek] = '.';
                                cena = sb.ToString();

                            }
                            else
                            {
                            }
                            StrQuery = "insert into SzczegolyZamowienia VALUES ( " +

                                           zamowienieid + ", '" +
                                           dgv1_wybraneProdukty.Rows[wiersze].Cells["ID"].Value.ToString() + "' , " +
                                           cena + ", '" +
                                           waluta + "' , " +
                                           dgv1_wybraneProdukty.Rows[wiersze].Cells[3].Value.ToString() + ")";

                                comm.CommandText = StrQuery;
                                comm.ExecuteNonQuery();
                        }
                    }
                }
            

            this.Hide();
            PodsumowanieZamówienia1 Podsumowanie1 = new PodsumowanieZamówienia1(klient, CurrentYear, dgv1_wybraneProdukty);
            Podsumowanie1.Show();
        }
    }
}