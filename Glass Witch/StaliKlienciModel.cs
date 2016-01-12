using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Glass_Witch
{
    class StaliKlienciModel
    {
        //
        ConnectWithDataBase cwd = new ConnectWithDataBase("JAKUB\\SQLEXPRESS", "GlassWitch");

        public StaliKlienciModel()
        {

        }

        public string GetData(string query)
        {
            return query;
        }

        public DataTable PobierzDaneKlienta()
        {
            DataTable nazwa = cwd.download_data("SELECT Nazwa from Klienci");
            
            return nazwa;
        }
    }
}