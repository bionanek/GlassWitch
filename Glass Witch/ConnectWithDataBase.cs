﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Glass_Witch
{
    //
    class ConnectWithDataBase
    {
        private SqlConnection connection; //obiekt połączenia widoczny dla całej klasy



        /// <summary>
        /// Konstruktor do tworzenia połączenia za pomocą autoryzacji SQL Server.
        /// Dane do połączenia się z Bazą Danych zostały już wpisane w klasie ConnectWithDataBase.
        /// </summary>
        public ConnectWithDataBase()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Server = localhost\\SQLEXPRESS    ;" +
                                          "Database = GlassWitch;" +
                                          "User Id = sa;" +
                                          "Password = jakubelvisz;";
            connection.Open();
        }




        /// <summary>
        /// Konstruktor do tworzenia połącznia za pomocą autoryzacji Windows 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="dbdir"></param>
        public ConnectWithDataBase(string instance, string dbdir)
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source =" + instance + ";" +
                "Trusted_Connection=yes;" +
                "database=" + dbdir + "; " +
                "connection timeout=3";
            connection.Open();

        }

        ///Zapytanie SQL ///zwraca dane w obiekcie DataTable
        public DataTable download_data(string query)
        {
            DataTable dt = new DataTable(); // Deklaracja i utworzenie instancji obiektu Datatable
                                            // o nazwie dt

            SqlDataReader reader; // deklaracja obiektu SqlDataReader o nazwie dr

            SqlCommand command = command = new SqlCommand(query); //Deklaracja obiektu SqlCommand instacji SQLCommand, 
                                                            //która ma wykonac zapytanie
                                                            //podane jako parametr w zmiennej query

            command.Connection = this.connection; // wskazanie polaczenia do bazy danych
            
            reader = command.ExecuteReader(); // wykonanie zapytania i utworzenie wskaźnika dr
            dt.Load(reader); //zaladowanie danych do obiektu DataTable

            return dt;
        }

        // TEST

        public void PolaczZBaza()
        {
            
        }
    }
}
