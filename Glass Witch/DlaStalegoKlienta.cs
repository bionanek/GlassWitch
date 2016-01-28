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
        //
        SqlConnection connection = new SqlConnection();
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        int klik = 0;
        int wybranyWiersz = 0;
        string nazwa;
        string kraj;
        string daneKlienta;
        DataTable wszyscyKlienci;
        DataTable dane_klienta;
        private DataTable _wybraneProdukty;
        DataGridView dgv1_wybraneProdukty;

        StaliKlienciModel skm = new StaliKlienciModel();
        ConnectWithDataBase cwd = new ConnectWithDataBase();

        public DlaStalegoKlienta(DataTable wybraneProdukty)
        {
            InitializeComponent();
            _wybraneProdukty = wybraneProdukty;
        }
     

        private void DlaStalegoKlienta_Load(object sender, EventArgs e)
        {
            this.Size = new Size(358, 393);
            wszyscyKlienci = cwd.download_data("select Nazwa, Kraj from Klienci");
            dgv1_zamStaliKlienci.DataSource = wszyscyKlienci;
            dgv1_zamStaliKlienci.Rows[0].Selected = false;

        }
        public string DownloadCustomerDataToString()
        {

            for (int i = 2; i <= 10; i++)
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
           
        }

        private void dgv1_zamStaliKlienci_SelectionChanged(object sender, EventArgs e)
        {
            daneKlienta = "";
            wybranyWiersz = dgv1_zamStaliKlienci.CurrentCell.RowIndex;
            nazwa = dgv1_zamStaliKlienci.Rows[wybranyWiersz].Cells[0].Value.ToString();
        }
            /*if (klik > 3)
            {
                //ToolTip1.SetToolTip(this.but_szukajKlienta, DownloadCustomerDataToString());
                ToolTip1.Show(DownloadCustomerDataToString(), this.but_szukajKlienta, 999999);
                ToolTip1.OwnerDraw = true;
                ToolTip1.Draw += new DrawToolTipEventHandler(ToolTip1_Draw);
                ToolTip1.Popup += new PopupEventHandler(ToolTip1_Popup);
            }

            klik++;
        }
        void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

            // on popip set the size of tool tip
            e.ToolTipSize = TextRenderer.MeasureText(DownloadCustomerDataToString(), new Font("Arial", 16.0f));
        }
        void ToolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 16.0f);
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(2, 2));
        }*/

        private void DlaStalegoKlienta_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void but_DoZamowienia_Click(object sender, EventArgs e)
        {
            Zamowienie zamowienie = new Zamowienie(dane_klienta, _wybraneProdukty);
            this.Hide();
            zamowienie.Show();
        }

        private void dgv1_zamStaliKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dane_klienta = cwd.download_data("Select * from Klienci where Nazwa like '" + 
                dgv1_zamStaliKlienci.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");

            this.Size = new Size(358, 449);
            but_DoZamowienia.Visible = true;
        }

        private void txt_szukajKlienta_TextChanged_1(object sender, EventArgs e)
        {
            string zawartoscKomorki = "";
            bool znalezione = false;
            bool pierwszePrzejscie = false;
            DataTable zawartoscWiersza = wszyscyKlienci.Clone();

            if (string.IsNullOrWhiteSpace(txt_szukajKlienta.Text))
            {
                dgv1_zamStaliKlienci.DataSource = wszyscyKlienci;
            }
            else
            {
                for (int i = 0; i < wszyscyKlienci.Rows.Count; i++)
                {
                    znalezione = false;
                    for (int j = 0; j < wszyscyKlienci.Columns.Count; j++)
                    {
                        zawartoscKomorki = wszyscyKlienci.Rows[i][j].ToString().ToLower();
                        if (zawartoscKomorki.IndexOf(txt_szukajKlienta.Text.ToLower()) >= 0)
                        {
                            znalezione = true;
                        }
                        else { }
                        if (znalezione == true)
                        {
                            if (pierwszePrzejscie == false)
                            {
                                pierwszePrzejscie = true;
                                dgv1_zamStaliKlienci.DataSource = null;
                            }
                            zawartoscWiersza.ImportRow(wszyscyKlienci.Rows[i]);
                            znalezione = false;
                            dgv1_zamStaliKlienci.DataSource = zawartoscWiersza;

                        }
                    }
                }
            }
        }

        private void but_do_wprowadzania_Click(object sender, EventArgs e)
        {
            this.Close();
            WprowadzanieNowegoKlienta wnk = new WprowadzanieNowegoKlienta();
            wnk.Show();
        }
    }
}




