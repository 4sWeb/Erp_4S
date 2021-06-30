using DAL.Entities;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Principal;
namespace BLL.Repo
{
    public class TestQuery
    {

        public void Get ()
        {
            string connectionString = @"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
            string query = "select *from STORE_TRNS";

            OracleConnection conn = new OracleConnection(connectionString); 
            OracleCommand cmd = new OracleCommand(query, conn);
            if(conn.State== ConnectionState.Closed)conn.Open();
            OracleDataReader Reader = cmd.ExecuteReader();
            DataTable Data = new DataTable();
            Data.Load(Reader);
            conn.Close();
            Reader.Close();
            var tt =  Data;

        }

    }
}
