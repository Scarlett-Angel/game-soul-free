using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
/// <summary>
/// Summary description for travel
/// </summary>
public class travel
{

    SqlConnection con = new SqlConnection();

        
    private SqlCommand sqlquery(string query)
    {
        SqlCommand thequery = new SqlCommand(query, con);
        return thequery;
    }
    SqlDataReader thereader;
    public travel()
    {
        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\project\\game-soul-free\\B00254067\\App_Data\\Database.mdf;Integrated Security=True";
    }

   /* public string getLocation(string id)
    {

    }*/
}