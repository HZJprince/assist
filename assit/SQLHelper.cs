using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;

namespace assit
{
    class SQLHelper
    {
        //private SqlConnection con;
        public static int ExecuteNonQuery(string sql, params OleDbParameter[] parameteres)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["informix_con"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(ConStr))
            //using (OdbcConnection conn = new OdbcConnection(ConStr))
            {
                conn.Open();
                using (OleDbCommand ConCmd = conn.CreateCommand())
                //using (OdbcCommand ConCmd = conn.CreateCommand())
                {
                    ConCmd.CommandText = sql;
                    foreach (OleDbParameter param in parameteres)
                    {
                        ConCmd.Parameters.Add(param);
                    }
                    return ConCmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params OleDbParameter[] parameteres)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["informix_con"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(ConStr))
            {
                conn.Open();
                using (OleDbCommand ConCmd = conn.CreateCommand())
                {
                    ConCmd.CommandText = sql;
                    foreach (OleDbParameter param in parameteres)
                    {
                        ConCmd.Parameters.Add(param);
                    }
                    return ConCmd.ExecuteScalar();
                }
            }
        }

        public static object ExecuteScalar(string sql)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["informix_con"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(ConStr))
            {
                conn.Open();
                using (OleDbCommand ConCmd = conn.CreateCommand())
                {
                    ConCmd.CommandText = sql;
                    return ConCmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, params OleDbParameter[] parameteres)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["informix_con"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(ConStr))
            {
                conn.Open();
                using (OleDbCommand ConCmd = conn.CreateCommand())
                {
                    ConCmd.CommandText = sql;
                    foreach (OleDbParameter param in parameteres)
                    {
                        ConCmd.Parameters.Add(param);
                    }
                    DataSet dataset = new DataSet();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(ConCmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["informix_con"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(ConStr))
            {
                conn.Open();
                using (OleDbCommand ConCmd = conn.CreateCommand())
                {
                    ConCmd.CommandText = sql;
                    DataSet dataset = new DataSet();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(ConCmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }
    }
}
