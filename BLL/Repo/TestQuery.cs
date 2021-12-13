//using DAL.Entities;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Reflection;

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

       

        public async Task<List<object>> Get(string squery, Dictionary<string, object> para = null, int type = 0)
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
                            if (param.ParameterName.Contains("transDate")) param.OracleDbType = OracleDbType.Date;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                        cmd.Parameters.Add("CURSORPARAM", OracleDbType.RefCursor, ParameterDirection.Output);
                    }
                    OracleDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    if(type == 2) { 
                    cmd.ExecuteNonQuery();
                    }
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                    return FromDataTableToJson(Data);
                }
            }
        }

        public List<object> FromDataTableToJson(DataTable dt)
        {
            var list = new List< object>();
            foreach (DataRow row in dt.Rows)
            {
                var dic = new Dictionary<string, object>();
                foreach (DataColumn column in dt.Columns)
                    dic[column.ColumnName] = (Convert.ToString(row[column]));
                list.Add(dic);
            }
            return list;
        }


        public static async Task<List<T>> Get<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            string connectionString = @"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=GREENHOPE0411;Password=GREENHOPE0411;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
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
                        cmd.Parameters.Add("CURSORPARAM", OracleDbType.RefCursor, ParameterDirection.Output);
                    }
                    OracleDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                    return ConvertDataTable<T>(Data);
                    //return ConvertDataTable<object>(Data);// FromDataTableToJson(Data);
                }
            }
        }


        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}
