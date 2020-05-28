using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Data;

public class Fetch
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;

    private static DataTable dt;




    public DataTable AdminFetchcheckdeliveredstep(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcheckdeliveredstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_shipment", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchcheckreturnstep(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcheckreturnstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_shipment", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchcheckongoingstep(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcheckongoingstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_shipment", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchcheckshipmentdetail(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcheckshipmentdetail";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@shipmentID", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchcheckshipmententry(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcheckshipmententry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminFetchuserinfo(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchuserinfo";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchcity(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchcountry(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchdeliveredstep(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchdeliveredstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchdistrict(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchdistrict";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchongoingstep(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchOngoingStep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchreturnreason(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchreturnreason";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchrider(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchrider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchshipmentdetail(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchshipmentdetail";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchshipmententry(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchshipmententry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

}