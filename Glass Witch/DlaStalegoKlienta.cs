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
            txt_szukajKlienta.Text = nazwa;
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
            this.Hide();
            wybor wybor = new wybor();
            wybor.Show();
        }

    }
}




