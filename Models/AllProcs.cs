using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Users.Models
{
    public class AllProcs
    {
        public static string GetConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
            }
        }
        public static DataTable GetUsers()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("GetUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception){ }
            return dt;
        }
    }
}