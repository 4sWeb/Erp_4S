//using DAL.Entities;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class TestQuery
    {

        //public void Get ()
        //{
        //    string connectionString = @"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
        //    string query = "select *from STORE_TRNS";

        //    OracleConnection conn = new OracleConnection(connectionString); 
        //    OracleCommand cmd = new OracleCommand(query, conn);
        //    if(conn.State== ConnectionState.Closed)conn.Open();
        //    OracleDataReader Reader = cmd.ExecuteReader();
        //    DataTable Data = new DataTable();
        //    Data.Load(Reader);
        //    conn.Close();
        //    Reader.Close();
        //    var tt =  Data;

        //}

        public async Task<object> Get(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            string connectionString = @"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
            string command = squery;

            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                await using (OracleCommand cmd = new OracleCommand(command, conn))
                {
                    if (type == 1)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<OracleParameter> orapar = new List<OracleParameter>();
                        foreach (var item in para)
                        {
                            var param = new OracleParameter();
                            param.ParameterName = item.Key;
                            param.OracleDbType = OracleDbType.Decimal;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                        cmd.Parameters.Add("result", OracleDbType.RefCursor, ParameterDirection.Output);
                    }
                    OracleDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    if (type == 1)
                    {
                        var value = cmd.ExecuteScalar();
                        Data.Columns.Add("ID");
                        Data.Columns.Add("Quntity");
                        var row = Data.NewRow();
                        row["ID"] = cmd.Parameters[1].Value;
                        row["Quntity"] = value;
                        Data.Rows.Add(row);
                    }
                    else
                    {
                        Reader = cmd.ExecuteReader();
                        Data.Load(Reader);
                    }
                    return FromDataTableToJson(Data);
                }
            }
        }

        public object FromDataTableToJson(DataTable dt)
        {
            var list = new List<Dictionary<string, object>>();
            foreach (DataRow row in dt.Rows)
            {
                var dic = new Dictionary<string, object>();
                foreach (DataColumn column in dt.Columns)
                    dic[column.ColumnName] = (Convert.ToString(row[column]));
                list.Add(dic);
            }
            return list;
        }

    }
}
