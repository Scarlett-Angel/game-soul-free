using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

/// <summary>
/// Summary description for debug
/// </summary>
static public class debugmod
{
    static public void run(string query)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = db.con();
        
        cmd = db.query(query, con);
        con.Open();
        int erd = cmd.ExecuteNonQuery();
        con.Close();
    }
}