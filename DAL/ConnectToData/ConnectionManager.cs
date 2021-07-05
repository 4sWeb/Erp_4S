using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.ConnectToData
{
    public static class ConnectionManager
    {
        private static string connString = "Data Source=10.8.2.154/DOTNET.lehaa.local;User Id=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False;";

        public static IDbConnection GetConnection()
        {
            var conn = new OracleConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void CloseConnection(IDbConnection conn)
        {
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
            {
                conn.Close();
            }
        }
    }
}
