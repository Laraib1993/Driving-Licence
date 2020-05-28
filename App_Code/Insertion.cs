using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Data;

public class Insertion
{
    protected static SqlCommand cmd;
    protected static SqlDataReader sdr;
    protected static SqlDataAdapter sda;



    public void AdminInsertcity(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertcity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@City", P.AdminInsertcitycity);
            cmd.Parameters.AddWithValue("@FK_Country", P.AdminInsertcitycountry);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertcitycreatedon);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminInsertCountry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertcountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Country", P.AdminInsertcountrycountry);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertcountrycreatedon);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertdeliveredstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertdeliveredstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@deliveredon", P.AdminInsertdelivereddeliveredon);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminInsertdeliveredRider);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminInsertdeliveredshipment);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertdeliveredcreatedby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertdistrict(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertdistrict";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@District", P.AdminInsertdistrictdistrict);
            cmd.Parameters.AddWithValue("@FK_City", P.AdminInserdistrictcity);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertdistrictcreated);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertongoingstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertongoingstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@assignedon", P.AdminInsertongoingassignedon);
            cmd.Parameters.AddWithValue("@estimateddeliveredon", P.AdminInsertongoingestimatedtime);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminInsertongoingrider);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertongoingcreatedby);
            cmd.Parameters.AddWithValue("@FK_shipment", P.AdminInsertongoingshipment);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertreturnreason(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertreturnreason";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Reason", P.AdminInsertreasonreason);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertreasoncreateon);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertReturnstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertreturnstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Returnedon", P.AdminInsertreturnerturnon);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertreturncreatedby);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminInsertreturnshipment);
            cmd.Parameters.AddWithValue("@FK_Reason", P.AdminInsertreturnreason);
            cmd.Parameters.AddWithValue("@Description", P.AdminInsertreturndisccription);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminInsertreturnrider);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertrider(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertrider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@rider", P.AdminInsertrider);
            cmd.Parameters.AddWithValue("@cnic", P.AdminInsertridercnic);
            cmd.Parameters.AddWithValue("@address", P.AdminInsertrideraddress);
            cmd.Parameters.AddWithValue("@phone", P.AdminInsertriderphone);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertridercreatedby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertshipmentdetail(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertshipmentdetail";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@shipmentID", P.AdminInsertshipmentid);
            cmd.Parameters.AddWithValue("@cnic", P.AdminInsertshipmentcnic);
            cmd.Parameters.AddWithValue("@FK_District", P.AdminInsertshipmentdistrict);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertshipmentcreatedby);
            cmd.Parameters.AddWithValue("@FK_ShipmentStatus", P.AdminInsertshipmentstatus);
            cmd.Parameters.AddWithValue("@address", P.AdminInsertshipmentaddress);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertUser(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertuser";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@email", P.AdminInsertuseremail);
            cmd.Parameters.AddWithValue("@password", P.AdminInsertuserpassword);
            cmd.Parameters.AddWithValue("@role", P.AdminInsertuserrole);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminInsertshipmententry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_shipmententry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@receivedon", P.AdminInsertentryreceivedon);
            cmd.Parameters.AddWithValue("@receivedby", P.AdminInsertentryreceivedby);
            cmd.Parameters.AddWithValue("@estimatedongoingdate", P.AdminInsertentryestimatedongoingdate);
            cmd.Parameters.AddWithValue("@FK_Createdon", P.AdminInsertentrycreatedby);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminInsertentryshipment);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminInsertentryrider);
            cmd.ExecuteNonQuery();

        }
    }

   
}