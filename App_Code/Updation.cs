using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Data;


public class Updation
{

    protected static SqlCommand cmd;
    protected static SqlDataReader sdr;
    protected static SqlDataAdapter sda;
    public void AdminUpdatecity(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatecity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@city", P.AdminUpdatecitycity);
            cmd.Parameters.AddWithValue("@FK_Updateon", P.AdminUpdatecityupdatedby);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdatecityID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateCountry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatecountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@country", P.AdminUpdatecountrycountry);
            cmd.Parameters.AddWithValue("@FK_Updatedon", P.AdminUpdatecountryupdatedby);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdatecountryID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdatedeliveredstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatedeliveredstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@deliveredon", P.AdminUpdatedeliveredon);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminUpdatedeliveredrider);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminUpdatedeliveredshipment);
            cmd.Parameters.AddWithValue("@FK_Updateby", P.AdminUpdatedeliveredupdatedby);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdatedeliveredid);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminUpdateDistrict(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatedistrict";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@district", P.AdminUpdatedistrictdistrict);
            cmd.Parameters.AddWithValue("@FK_City", P.AdminUpdatedistrictupdatedby);
            cmd.Parameters.AddWithValue("@FK_Updateon", P.AdminUpdatedistrictcity);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateDistrictID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateongoingstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateongoingstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@assignedon", P.AdminUpdateongoingassignedon);
            cmd.Parameters.AddWithValue("@estimateddeliveredon", P.AdminUpdateongoingestimatedon);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminUpdateongoingrider);
            cmd.Parameters.AddWithValue("@FK_Updateby", P.AdminUpdateongoingupdateby);
            cmd.Parameters.AddWithValue("@FK_shipment", P.AdminUpdateongoingshipment);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateongoingID);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminUpdatereturnreason(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatereturnreason";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@reason", P.AdminUpdatereasonreason);
            cmd.Parameters.AddWithValue("@FK_Updatedon", P.AdminUpdatereasonupdatedby);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdatereasonID);

            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdatereturnstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatereturnstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Returnedon", P.AdminUpdatereturndatetime);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminUpdatereturnrider);
            cmd.Parameters.AddWithValue("@FK_Updateby", P.AdminUpdatereturnupdateby);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminUpdatereturnshipment);
            cmd.Parameters.AddWithValue("@FK_Reason", P.AdminUpdatereturnreason);
            cmd.Parameters.AddWithValue("@Description", P.AdminUpdatereturndescription);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdatereturnID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdaterider(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updaterider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@rider", P.AdminUpdateriderrider);
            cmd.Parameters.AddWithValue("@cnic", P.AdminUpdateridercnic);
            cmd.Parameters.AddWithValue("@address", P.AdminUpdaterideraddress);
            cmd.Parameters.AddWithValue("@phone", P.AdminUpdateriderphone);
            cmd.Parameters.AddWithValue("@FK_Updatedon", P.AdminUpdateriderupdateby);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateriderID);
            cmd.ExecuteNonQuery();
        }
    }


    public void AdminUpdateshipmentdetail(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateshipmentdetail";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@shipmentID", P.AdminUpdatshipmentshipmentID);
            cmd.Parameters.AddWithValue("@cnic", P.AdminUpdateshipmentcnicno);
            cmd.Parameters.AddWithValue("@address", P.AdminUpdateshipmentaddress);
            cmd.Parameters.AddWithValue("@FK_District", P.AdminUpdateshipmentdistrict);
            cmd.Parameters.AddWithValue("@FK_Updatedby", P.AdminUpdateshipmentupdate);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminUpdateshipmentrider);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateshipmentID);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateshipmententry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateshipmententry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@receivedon", P.AdminUpdatentryreceivedon);
            cmd.Parameters.AddWithValue("@receivedby", P.AdminUpdateentryreceivedby);
            cmd.Parameters.AddWithValue("@estimatedongoingdate", P.AdminUpdateentryestimatedon);
            cmd.Parameters.AddWithValue("@FK_Updated", P.AdminUpdateentryshipment);
            cmd.Parameters.AddWithValue("@FK_Shipment", P.AdminUpdateentryupdate);
            cmd.Parameters.AddWithValue("@FK_Rider", P.AdminUpdateentryrider);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateentryID);
            cmd.ExecuteNonQuery();
        }
    }

    public void AdminUpdateuser(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateuserinfo";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@email", P.AdminUpdatuseremail);
            cmd.Parameters.AddWithValue("@password", P.AdminUpdateuserpassword);
            cmd.Parameters.AddWithValue("@role", P.AdminUpdateuserrole);
            cmd.Parameters.AddWithValue("@id", P.AdminUpdateuserID);
            cmd.ExecuteNonQuery();

        }
    }

}