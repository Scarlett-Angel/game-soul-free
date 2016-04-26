﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DBconnect
/// </summary>
public class DBconnect
{
    private SqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    //Constructor
    public DBconnect()
    {
        Initialise();
    }

    private void Initialise()
    {
        server = "localhost";
        database = "soulfree";
        uid = "root";
        password = "";
        //   server = "79.170.44.209";
        //  database = "web209-soulfree";
        //  uid = "web209-soulfree";
        //  password = "UC.KJEH9f";
        string connectionString;
        connectionString = "Server=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + ";";

        connection = new SqlConnection(connectionString);
    }
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch
        {
            return false;
        }
    }
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void Command(string query)
    {
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
    }

    public bool VerifyUser(string username, string password)
    {
        string query = "SELECT COUNT(*) FROM users WHERE username='" + username + "' AND pw='" + password + "';";
        int countusers;
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            countusers = int.Parse(cmd.ExecuteScalar() + "");
            this.CloseConnection();
            if (countusers > 0)
            { return true; }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public bool NewUser(string email, string username, string password)
    {
        string query = "INSERT INTO users (id, email, username, pw) VALUES (NULL,'" + email + "','" + username + "','" + password + "')";
        if (this.OpenConnection() == true)
        {

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
            return true;
        }
        else
        {
            return false;
        }
    }
    public int userHasCharacter(string username)
    {
        int count;
        if (this.OpenConnection() == true)
        {
            string query = "SELECT COUNT(*) FROM (SELECT users.id, characters.userid from `users` INNER JOIN `characters` on users.id = characters.userid WHERE username = '" + username + "') temptable;";
            SqlCommand cmd = new SqlCommand(query, connection);
            count = int.Parse(cmd.ExecuteScalar() + "");
            if (count > 0)
            {
                //has character
                return 1;
            }
            else
            {
                //no character
                return 2;
            }
        }
        else
        {
            return 999;
        }

    }
    private int getCharId(string id)
    {
        string query = "Select id from characters where userid ='" + id + "' and death is NULL;";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            int charId = int.Parse(cmd.ExecuteScalar() + "");
            this.CloseConnection();
            return charId;
        }
        else { return 0; }
    }
    public void levelUpSkill(string uid, string sid)
    {
        int count = 0;
        int charid = getCharId(uid);
        string query = "SELECT COUNT(*) FROM character_skills WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            count = int.Parse(cmd.ExecuteScalar() + "");
            this.CloseConnection();
        }
        if (count > 0)
        {
            query = "UPDATE character_skills SET value = value + 1 WHERE characterid='" + charid + "' AND skillid='" + sid + "';";
            if (this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }

        }
        else
        {
            query = "INSERT INTO character_skills (characterid, skillid, value) VALUES ('" + charid + "','" + sid + "', '1');";
            if (this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }


        }
    }
    public void createCharacter(string characterName, string id)
    {
        int charId = 0;
        string query = "INSERT INTO characters ( name, userid) VALUES ('" + characterName + "','" + id + "');";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
        charId = getCharId(id);
        query = "INSERT INTO character_levels (characterid, levelid, rating, progression) VALUES ('" + charId + "', '1', '1','0'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','1','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','2','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','3','1'); INSERT INTO character_skills(characterid, skillid, value) VALUES ('" + charId + "','4','1');";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }

        return;
    }

    public int getAccountId(string username)
    {
        string query = "Select id from users where username='" + username + "';";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);

            int id = int.Parse(cmd.ExecuteScalar() + "");
            return id;
        }
        else
        {
            return 0;
        }

    }
    public int getCharLevel(string id)
    {
        int charid = getCharId(id);
        string query = "Select rating from character_levels where characterid ='" + charid + "' AND levelid ='1';";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);

            int level = int.Parse(cmd.ExecuteScalar() + "");
            return level;
        }
        else { return 0; }
    }

    public void sqlquery(string query)
    {
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }
    }

    public string getskillid(string uid, string sid)
    {
        int charid = getCharId(uid);
        string query = "Select value from character_skills where characterid ='" + charid + "' and skillid='" + sid + "';";
        if (this.OpenConnection() == true)
        {
            SqlCommand cmd = new SqlCommand(query, connection);

            var getvalue = cmd.ExecuteScalar();
            this.CloseConnection();
            if (getvalue != null)
            {
                string skillLevel = getvalue.ToString();
                return skillLevel;
            }
            else
            {
                return "0";
            }

        }
        else
        {
            return "0";
        }

    }

}