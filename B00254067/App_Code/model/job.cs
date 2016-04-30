using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
/// <summary>
/// Summary description for job
/// </summary>
public class job
{
    
    public string jobDefaults(string jobID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select * from oldLife WHERE Id = '" + jobID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring = rdr["strength"].ToString() + ";" + rdr["craft"].ToString() + ";" + rdr["luck"].ToString() + ";" + rdr["life"].ToString() + ";" + rdr["aligment"].ToString() + ";" + rdr["start"].ToString() + ";" + rdr["name"].ToString();
        con.Close();
        return returnstring;
    }
}