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
    public partial class PodsumowanieZamowienia : Form
    {
        DataTable klient;
        DataTable zamowienie;
        private int CurrentYear;
        private DataGridView data_produkty;
        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public PodsumowanieZamowienia(DataTable dane_klient, int year, DataGridView dgv1_produkty)
        {
            InitializeComponent();
            klient = dane_klient;
            CurrentYear = year;
            data_produkty = dgv1_produkty;
        }

        private void but_doPDF_Click(object sender, EventArgs e)
        {

            //ZAPIS PDF W GlassWitch/bin/Debug !!!!!!!!!!!!!!!!!!!!!!!

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Zamówienie " + CurrentYear.ToString() + " " + klient.Rows[0]["Nazwa"].ToString() + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("                                                                   *ORDER CONFIRMATION*                  ");
            doc.Add(paragraph);

            List list = new List(List.NUMERICAL);

            list.Add(new ListItem("Nazwa firmy: " + klient.Rows[0]["Nazwa"].ToString()));
            list.Add("Osoba Kontaktowa: " + klient.Rows[0]["OsobaKontaktowa"].ToString());
            list.Add("E-Mail: " + klient.Rows[0]["Email"].ToString());
            list.Add("Ulica: " + klient.Rows[0]["Ulica"].ToString());
            list.Add("Kod Pocztowy: " + klient.Rows[0]["KodPocztowy"].ToString());
            list.Add("Miasto: " + klient.Rows[0]["Miasto"].ToString());
            list.Add("Kraj: " + klient.Rows[0]["Kraj"].ToString());
            list.Add("Numer VAT: " + klient.Rows[0]["VatNo"].ToString());
            doc.Add(list);

            PdfPTable table = new PdfPTable(data_produkty.Columns.Count);

            //Add the headers from data_produkty to the table
            for (int j = 0; j < data_produkty.Columns.Count; j++)
            {
                table.AddCell(new Phrase(data_produkty.Columns[j].HeaderText));
            }

            //Flag the first row as a header
            table.HeaderRows = 1;

            //Add the actual rows from the data_produkty to the table
            for (int i = 0; i < data_produkty.Columns.Count; i++)
            {
                for (int k = 0; k < data_produkty.Columns.Count; k++)
                {
                    if (data_produkty[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(data_produkty[k, i].Value.ToString()));
                    }
                }
            }


            //Add out table
            doc.Close();
        }
    }
}