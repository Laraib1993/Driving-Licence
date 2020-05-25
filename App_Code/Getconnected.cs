using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class Getconnected
{
    private static SqlConnection conn;

    public static SqlConnection getconnecting()
    {
        if (conn == null)
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connected"].ConnectionString;
            conn.Open();
        }

        return conn;
    }
}