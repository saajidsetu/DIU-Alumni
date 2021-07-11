using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MyCollegeWebSite
{
    public class DBConnector
    {
        string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public int ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch(SqlException ex)
            {
                return 0;
            }
        }
        public DataTable getTable(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable td = new DataTable();
                adapter.Fill(td);
                return td;
            }
            catch(SqlException ex)
            {
                return null;
            }
        }
    }
}