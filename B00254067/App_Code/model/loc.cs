using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

/// <summary>
/// Summary description for loc
/// </summary>
public class loc
{
  
        public string getlocationDetails(int locationID)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        con.ConnectionString = db.con();
        string query = "Select * from area WHERE Id = '" + locationID + "';";
        cmd = db.query(query, con);
        con.Open();
        rdr = cmd.ExecuteReader();
        rdr.Read();
        string returnstring = rdr["name"].ToString() + ";" + rdr["description"].ToString();
        con.Close();
        return returnstring;
    }

}