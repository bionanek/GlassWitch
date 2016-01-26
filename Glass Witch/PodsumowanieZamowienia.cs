using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace Glass_Witch
{
    public partial class PodsumowanieZamowienia : Form
    {
        DataTable klient;
        DataTable zamowienie;
        private int CurrentYear;
        private DataGridView data_produkty;
        ConnectWithDataBase cwd = new ConnectWithDataBase();

        private void PodsumowanieZamowienia_Load(object sender, EventArgs e)
        {

        }

        public PodsumowanieZamowienia(DataTable dane_klient, int year, DataGridView dgv1_produkty)
        {
            InitializeComponent();
            klient = dane_klient;
            CurrentYear = year;
            data_produkty = dgv1_produkty;
        }

        private void but_generowanie_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("C:/Users/oskar/Documents/GitHub/GlassWitch/Glass Witch/CrystalReport1.rpt");


            crConnectionInfo.ServerName = "ELVISZ/SQLEXPRESS";
            crConnectionInfo.DatabaseName = "GlassWitch";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "jakubelvisz";

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();          
        }
    }
}
      