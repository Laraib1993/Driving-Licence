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


    public DataTable AdminFetchAdmin(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminFetchAdmin";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@AminID", P.AdminUpdateFetchProfileID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchDeletingVendor()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingVendor()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveVendor()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchPendingReseller()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingReseller()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchDeActiveReseller()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchPendingDistributer()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchDeletingDistributer()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveDistributer()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingProductCategory()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingProductCategory()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable AdminFetchDeActiveProductCategory()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingProductType()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingProductType()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveProductType()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingProductService()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingProductService()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveProductService()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchPendingRegion()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingRegion()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchDeActiveRegion()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingCountry()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeletingCountry()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveCountry()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchPendingCity()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendingCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable AdminFetchDeletingCity()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletingCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable AdminFetchDeActiveCity()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActiveCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }



    public DataTable ResellerFetchDeletingProduct(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ResellerDeletingProductGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerDeletingProductGridViewFK_Createdby);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }




    public DataTable DistributerFetchDeletingProduct(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerDeletingProductGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Createdby", P.DistributerDeletingProductGridViewFK_Createdby);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalScanningInword_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalScanningInword_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingInword_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingInword_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDInword_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDInword_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalScanningOutward_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalScanningOutward_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingOutward_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingOutward_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDOutward_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDOutward_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingCaseInword_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingCaseInword_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingCaseOutward_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingCaseOutward_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDCaseInword_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDCaseInword_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDCaseOutward_Today()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDCaseOutward_Today";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalScanningSheetOutward_Pending()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalScanningOutward_Pending";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingSheetOutward_Pending()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingOutward_Pending";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDSheetOutward_Pending()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDOutward_Pending";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalSearchingCaseOutward_Pending()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalSearchingCaseOutward_Pending";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }

    public DataTable AdminFetchTotalNewIDCaseOutward_Pending()
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDashboardTotalNewIDCaseOutward_Pending";
            cmd.Connection = Getconnected.getconnecting();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }
}