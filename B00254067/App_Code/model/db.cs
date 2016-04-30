using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

/// <summary>
/// Summary description for con2db
/// </summary>
public class db
{
    
    public static string con()
    {
        string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\project\\game-soul-free\\B00254067\\App_Data\\Database.mdf;Integrated Security = True";
        return con;
    }

    public static SqlCommand query(string query, SqlConnection con)
    {
        SqlCommand command = new SqlCommand(query, con);
        return command;
    }
}