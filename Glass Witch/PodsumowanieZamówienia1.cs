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
    public partial class PodsumowanieZamówienia1 : Form
    {
        DataTable klient;
        DataTable zamowienie;
        int CurrentYear;
        DataGridView data_produkty;
        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public PodsumowanieZamówienia1(DataTable dane_klient, int year, DataGridView dgv1_wybraneProdukty)
        {
            klient = dane_klient;
            CurrentYear = year;
            data_produkty = dgv1_wybraneProdukty;

            InitializeComponent();
        }

        private void GenerujPDF_Click(object sender, EventArgs e)
        {
            //ZAPIS PDF W GlassWitch/bin/Debug !!!!!!!!!!!!!!!!!!!!!!!

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Zamówienie " + CurrentYear.ToString() + " " + klient.Rows[0]["Nazwa"].ToString() + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("                                                                   *ORDER CONFIRMATION*                  ");
            doc.Add(paragraph);

            List list = new List(List.NUMERICAL);

            list.Add(new ListItem(klient.Rows[0]["Nazwa"].ToString()));
            list.Add(klient.Rows[0]["OsobaKontaktowa"].ToString());
            list.Add(klient.Rows[0]["Email"].ToString());
            list.Add(klient.Rows[0]["Ulica"].ToString());
            list.Add(klient.Rows[0]["KodPocztowy"].ToString());
            list.Add(klient.Rows[0]["Miasto"].ToString());
            list.Add(klient.Rows[0]["Kraj"].ToString());
            list.Add(klient.Rows[0]["VatNo"].ToString());
            list.Add("");
            list.Add("    Produkty |   ");
            doc.Add(list);

            PdfPTable table = new PdfPTable(data_produkty.Columns.Count);

            PdfPTable pdfTable = new PdfPTable(8);
            foreach (DataGridViewRow row in data_produkty.Rows)
            {
                foreach (DataGridViewCell celli in row.Cells)
                {
                    try
                    {
                        pdfTable.AddCell(celli.Value.ToString());
                    }
                    catch { }
                }
            }
            doc.Add(pdfTable);
            
            //Add the headers from data_produkty to the table
            for (int j = 0; j < data_produkty.Columns.Count; j++)
            {
                if (data_produkty.Columns[j].Name == "SRANIE")
                {
                    continue;
                }
                table.AddCell(new Phrase(data_produkty.Columns[j].HeaderText));

            }

            //Flag the first row as a header
            table.HeaderRows = 1;

            //Add the actual rows from the data_produkty to the table
            for (int i = 0; i < data_produkty.Columns.Count - 1; i++)
            {
                for (int k = 0; k < data_produkty.Rows.Count - 1; k++)
                {
                    if (data_produkty[i, k].Value != null)
                    {
                        table.AddCell(new Phrase(data_produkty[i, k].Value.ToString()));
                    }
                }
            } 
            

            //Add out table
            doc.Close();
        }
    }
}
