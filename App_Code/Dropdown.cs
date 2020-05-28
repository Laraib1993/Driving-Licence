using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class Dropdown
{
    protected static SqlCommand cmd;
    protected static SqlDataReader sdr;
    protected static SqlDataAdapter sda;



    public static List<ListItem> GetAdminDropdownfetchuserinfo(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchuserinfo";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Email" });
                while (sdr.Read())
                {

                    type.Add(new ListItem
                    {

                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminDropdowncity(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select City" });
                while (sdr.Read())
                {

                    type.Add(new ListItem
                    {

                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }


    public static List<ListItem> GetAdminDropdowncountry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Country" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }


    public static List<ListItem> GetAdminDropdowndeliveredstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchdeliveredstep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Shipment" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminOutwarddistrict(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchdistrict";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select District" });
                while (sdr.Read())
                {

                    type.Add(new ListItem
                    {

                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }


    public static List<ListItem> GetAdminOutwardongoingstep(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchOngoingStep";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Shipment" });
                while (sdr.Read())
                {

                    type.Add(new ListItem
                    {

                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminreturnreason(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchreturnreason";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Reason" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminDropdownrider(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchrider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Rider" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminDropdownshipmentdetail(Properties P )
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchshipmentdetail";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Shipment" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

    public static List<ListItem> GetAdminDropdownshipmententry(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchshipmententry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.AdminFetchID);
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Shipment" });
                while (sdr.Read())
                {
                    type.Add(new ListItem
                    {
                        Value = sdr[0].ToString(),
                        Text = sdr[1].ToString()
                    });
                }
            }

            return type;
        }
    }

  


}