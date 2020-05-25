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



    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_1()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_1";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_7()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_7";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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


    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_8()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_8";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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


    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_9()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_9";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminOutwardScanningForm_InwordNo()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownOutwardHistoryInwordNo";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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


    public static List<ListItem> GetAdminOutwardScanningForm_EmployeeName()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownOutwardHistoryEmployee";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Employee Name" });
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

    public static List<ListItem> GetAdminInwordForSearching()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordForSearching";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_5()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_5";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_4()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_4";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_3()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_3";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminDropdownInwordno_ShowReason_2()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownInwordno_ShowReason_2";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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

    public static List<ListItem> GetAdminProductFormPatner()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownPatnerForProduct";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Patner For New Product" });
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


    public static List<ListItem> GetAdminOutward()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownOutward";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Outward" });
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


    public static List<ListItem> GetAdminScanningCase_InwordNo()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownScanningCase_InwordNo";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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


    public static List<ListItem> GetAdminPatnerBranchFormCity()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownCity";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select City For New Branch" });
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


    public static List<ListItem> GetAdminScanningInwordNo()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownScanningInwordNo";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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







    public static List<ListItem> GetAdminEditPatnerFormCity()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownCity";
            cmd.Connection = Getconnected.getconnecting();
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

    public static List<ListItem> GetAdminEditPatnerFormPatner()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownPartner";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Patner To Be Edited" });
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

    public static List<ListItem> GetAdminDistrict()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownDistrict";
            cmd.Connection = Getconnected.getconnecting();
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



    public static List<ListItem> GetAdminEditCityFormCity()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownCity";
            cmd.Connection = Getconnected.getconnecting();
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






    public static List<ListItem> GetAdminCountryFormRegion()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownRegion";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Region" });
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






    public static List<ListItem> GetAdminNewIDSheet_Inwordno()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownNewID_Inwordno";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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






    public static List<ListItem> GetAdminCityFormCountryName()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownCountry";
            cmd.Connection = Getconnected.getconnecting();
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






    public static List<ListItem> GetAdminNewID_Inwordno_Case()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownNewID_Inwordno_Case";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Inword No" });
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






    public static List<ListItem> GetAdminReason()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownReason";
            cmd.Connection = Getconnected.getconnecting();
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



    public static List<ListItem> GetAdminTierLevelTierLevel()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownTierLevel";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Tier Level Name To Be Edited" });
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




    public static List<ListItem> GetAdminTierLevelDistributerFk_TierLevel()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownTierLevelDistributerFK_TierLevel";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Tier Level" });
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




    public static List<ListItem> GetAdminTierLevelDistributerFk_Distributer()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownTierLevelDistributerFK_Distributer";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Distributer" });
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





    public static List<ListItem> GetAdminTierLevelDistributerForEdit()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownTierLevelDistributerForEdit";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Distributer For Edit" });
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


    public static List<ListItem> GetAdminDepartment()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownDepartment";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Department" });
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

    public static List<ListItem> GetAdminProductPatnerRelationshipForProduct()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownProductPatnerRealtionship";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Product" });
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




    public static List<ListItem> GetAdminProductPatnerRelationshipForPatner()
    {
        using (cmd = new SqlCommand())
        {
            List<ListItem> type = new List<ListItem>();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDropdownDistributerOrReseller";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                type.Add(new ListItem { Text = "Select Patner" });
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