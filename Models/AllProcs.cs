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

        //public static DataTable GetUsers()
        ////{
        //    SqlConnection con = new SqlConnection(GetConnection);
        //    SqlCommand cmd = new SqlCommand("GetUsers", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter sd = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        sd.SelectCommand = cmd;
        //        sd.Fill(dt);
        //    }
        //    catch (Exception) { }
        //    return dt;
        //}

        //public static DataTable Searching(string Data = null)
        //{
        //    SqlConnection con = new SqlConnection(GetConnection);
        //    SqlCommand cmd = new SqlCommand("Searching",con);
        //    cmd.Parameters.AddWithValue("@Data", Data);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter sd = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        sd.SelectCommand = cmd;
        //        sd.Fill(dt);
        //    }
        //    catch (Exception){ }
        //    return dt;
        //}
        //public static DataSet Pagination(int? Row, int? Offset)
        //{
        //    SqlConnection con = new SqlConnection(GetConnection);
        //    SqlCommand cmd = new SqlCommand("Pagination", con);
        //    cmd.Parameters.AddWithValue("@Rows", Row);
        //    cmd.Parameters.AddWithValue("@Offset", Offset);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter sd = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        sd.SelectCommand = cmd;
        //        sd.Fill(ds);
        //    }
        //    catch (Exception) { }
        //    return ds;
        //}

        public static DataSet Pagination(int? Row, int? Offset, string Columns, string Table, string Data = null)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("Pagination", con);
            cmd.Parameters.AddWithValue("@Row", Row);
            cmd.Parameters.AddWithValue("@Offset", Offset);
            cmd.Parameters.AddWithValue("@Columns", Columns);
            cmd.Parameters.AddWithValue("@Table", Table);
            cmd.Parameters.AddWithValue("@Data", Data);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(ds);
            }
            catch (Exception) { }
            return ds;
        }
    }
}