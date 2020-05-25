using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class edit
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;

    private static DataTable dt;



    public DataTable AdminEditScanningOutwardForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchScanningOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Sno", P.AdminUpdateMainForScanning);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminAddPatnerNewTypeFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchPatnerTypeRelation";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Patner", P.AdminPatnerTypeRelationFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminEditPatnerFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchPatner";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminEditPatnerFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminEditCityFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchCity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CID", P.AdminEditCityFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminEditServiceFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchService";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PSID", P.AdminEditServiceFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminEditProductTypeForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchProductType";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminEditProductTypeFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }





    public DataTable AdminEditRegionForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchRegion";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@RID", P.AdminEditRegionForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminEditCountryForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchCountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CountID", P.AdminEditCountryForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminEditProductCategoryForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchProductCategory";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PCID", P.AdminEditProductCategoryForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminEditTierLevelForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchTierLevel";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@TLID", P.AdminEditTierLevelForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminEditAssignTierLevelForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchTierLevelDistributer";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@TID", P.AdminEditAssignTierLevelForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminEditPatnerBranchFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchBranch";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@BranchID", P.AdminEditPatnerBranchForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminEditProductForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdmnEditProductFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminEditProductPatnerRelationshipFetch(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchProductPatnerRelationship";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Patner", P.AdminEditProductPatnerRelationshipFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable VendorEditProductForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_VendorFetchProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.VendorEditProductFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable ResellerAddProductForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ResellerFetchProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.ResellerAddProductFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable DistributerAddProductForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerFetchProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.DistributerAddProductFetch);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }
}