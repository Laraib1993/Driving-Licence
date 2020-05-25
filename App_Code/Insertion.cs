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





    

    public void AdminInsertInwordHistory(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertInwordHistory";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertScanningInword_Inwordno);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertScanningInword_Discription);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertScanningInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@NoofIDs", P.AdminInsertScanningInword_NoofIDs);
            cmd.Parameters.AddWithValue("@NoofPages", P.AdminInsertScanningInword_NoofPages);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertScanningInword_Createdon);
            cmd.Parameters.AddWithValue("FK_Department", P.AdminInsertScanningInword_FK_Department);
            cmd.Parameters.AddWithValue("FK_Createdby", P.AdminInsertScanningInword_FK_Createdby);
            //cmd.Parameters.AddWithValue("FK_Reason", P.AdminInsertScanningInword_FK_Reason);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminInsertScanningInword_FK_Status);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminInsertMain(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertMain";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertMain_Inwordno);
            cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertMain_Createdon);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertMain_InwordDateTime);
            cmd.Parameters.AddWithValue("FK_Department", P.AdminInsertMain_FK_Department);
            cmd.Parameters.AddWithValue("FK_Createdby", P.AdminInsertMain_FK_Createdby);
            //cmd.Parameters.AddWithValue("FK_Reason", P.AdminInsertMain_FK_Reason);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertOutwardHistory(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertOutwardHistory";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminInsertOutwardHistory_OutwarddateTime);
            cmd.Parameters.AddWithValue("@FK_Reason", P.AdminInsertOutwardHistory_FK_Reason);
            cmd.Parameters.AddWithValue("@FK_InwordHistoryID", P.AdminInsertOutwardHistory_FK_InwordhistoryID);
            cmd.Parameters.AddWithValue("@FK_OutwardTo", P.AdminInsertOutwardHistory_FK_Outwardto);
            cmd.Parameters.AddWithValue("@FK_Outwardby", P.AdminInsertOutwardHistory_FK_Outwardby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminInsertOutwardHistory_FK_Status);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminUpdateOutwardHistory_FK_ReasonDoneID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForScanning(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForScanning";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMain_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateMain_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateMain_OutwardBy);
            cmd.Parameters.AddWithValue("@OutwardTo", P.AdminUpdateMain_Outwardto);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertSearchingSheetInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertSearchingInwordSheet";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertSearchingSheetInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertSearchingSheetInword_Createdon);
            cmd.Parameters.AddWithValue("@FK_OutwardHistoryID", P.AdminInsertSearchingSheetInword_FK_OutwardHistoryID);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertSearchingSheetInword_FK_Createdby);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertSearchingSheetInword_FK_ReasonDoneID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForSearchingInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForSearchingInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMainForSearchingInword_Sno);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminUpdateMainForSearchingInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateMainForSearchingInword_FK_Createdby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertSearchingSheetOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertSearchingOutwardSheet";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@NoofNewID", P.AdminInsertSearchingSheetOutward_NoofNewID);
            cmd.Parameters.AddWithValue("@NoofSameID", P.AdminInsertSearchingSheetOutward_NoofSameID);
            cmd.Parameters.AddWithValue("@NoofModification", P.AdminInsertSearchingSheetOutward_NoofModification);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertSearchingSheetOutward_Discription);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertSearchingSheetOutward_Createdon);
            cmd.Parameters.AddWithValue("@FK_SearchingSheetInwordID", P.AdminInsertSearchingSheetOutward_SearchingSheetInwordID);
            cmd.Parameters.AddWithValue("@FK_OutwardTo", P.AdminInsertSearchingSheetOutward_FK_OutwardTo);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertSearchingSheetOutward_FK_Createdby);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminInsertSearchingSheetOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertSearchingSheetOutward_FK_ReasonDoneID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForSearchingOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForSearchingOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMainForSearchingOutward_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateMainForSearchingOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateMainForSearchingOutward_Outwardby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertNewIDSheetInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertNewIDInwordSheet";
            cmd.Connection = Getconnected.getconnecting();
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertNewIDSheetInword_Createdon);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertNewIDSheetInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertNewIDSheetInword_Discription);
            cmd.Parameters.AddWithValue("@FK_SearchingOutwardID", P.AdminInsertNewIDSheetInword_FK_SearchingOutwardID);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertNewIDSheetInword_FK_Createdby);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertNewIDSheetInword_FK_ReasonDoneID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForNewIDSheetInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForNewIDSheetInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMainForNewIDInword_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateMainForNewIDInword_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateMainForNewIDInword_Outwardby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertNewIDSheetOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertNewIDSheetOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminInsertNewIDSheetOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertNewIDSheetOutward_Createdon);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertNewIDSheetOutward_Discription);
            cmd.Parameters.AddWithValue("@FK_NewIDSheetInwordID", P.AdminInsertNewIDSheetOutward_FK_NewIDSheetInwordID);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertNewIDSheetOutward_FK_Createdby);
            cmd.Parameters.AddWithValue("@FK_OutwardTo", P.AdminInsertNewIDSheetOutward_FK_OutwardTo);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertNewIDSheetOutward_FK_ReasonDoneID);
            
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForNewIDSheetOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForNewIDSheetOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateNewIDOutward_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateNewIDOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateNewIDOutward_Outwardby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertSearchingCaseInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertSearchingCaseInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertSearchingCaseInword_Inwordno);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertSearchingCaseInword_Discription);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertSearchingCaseInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@NoofIDs", P.AdminInsertSearchingCaseInword_NoofIDs);
            cmd.Parameters.AddWithValue("@NoofPages", P.AdminInsertSearchingCaseInword_NoofPages);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertScanningInword_Createdon);
            cmd.Parameters.AddWithValue("FK_Createdby", P.AdminInsertSearchingCaseInword_FK_Createdby);
            //cmd.Parameters.AddWithValue("FK_Reason", P.AdminInsertScanningInword_FK_Reason);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertMainForSearchingCaseInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertMainForSearchingCaseInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertMainForSearchingCase_InwordNo);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertMainForSearchingCase_InwordDateTime);
            cmd.Parameters.AddWithValue("FK_Createdby", P.AdminInsertMainForSearchingCase_FK_Createdby);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertSearchingCaseOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertSearchingCaseOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@NoofNewID", P.AdminInsertSearchingCaseOutward_NoofNewID);
            cmd.Parameters.AddWithValue("@NoofSameID", P.AdminInsertSearchingCaseOutward_NoofSameID);
            cmd.Parameters.AddWithValue("@NoofModification", P.AdminInsertSearchingCaseOutward_NoofModification);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertSearchingCaseOutward_Discription);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminInsertSearchingCaseOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@FK_SearchingCaseInwordID", P.AdminInsertSearchingCaseOutward_FK_SearchingCaseInwordID);
            cmd.Parameters.AddWithValue("@FK_OutwardTo", P.AdminInsertSearchingCaseOutward_FK_OutwardTo);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertSearchingCaseOutward_FK_Createdby);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertSearchingCaseOutward_FK_ReasonDoneID);
            
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForSearchingCaseOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForSearchingCaseOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMainForSearchingCaseOutward_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateMainForSearchingCaseOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateMainForSearchingCaseOutward_OutwardBy);
            cmd.Parameters.AddWithValue("@OutwardTo", P.AdminUpdateMainForSearchingCaseOutward_OutwardTo);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminInsertNewIDCaseInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertNewIDCaseInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminInsertNewIDCaseInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertNewIDCaseInword_Discription);
            cmd.Parameters.AddWithValue("@FK_SearchingOutwardCaseID", P.AdminInsertNewIDCaseInword_FK_SearchingOutwardCaseID);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertNewIDCaseInword_FK_Createdby);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertNewIDCaseInword_FK_ReasonDoneID);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForNewIDCaseInword(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForNewIDCaseInword";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateMainForNewIDCaseInword_Sno);
            cmd.Parameters.AddWithValue("@InwordDateTime", P.AdminUpdateMainForNewIDCaseInword_InwordDateTime);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateMainForNewIDCaseInword_FK_Createdby);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminInsertNewIDCaseOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertNewIDCaseOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminInsertNewIDCaseOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertNewIDCaseOutward_Discription);
            cmd.Parameters.AddWithValue("@FK_NewIDCaseInwordID", P.AdminInsertNewIDCaseOutward_FK_NewIDCaseInwordID);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertNewIDCaseOutward_FK_Createdby);
            cmd.Parameters.AddWithValue("@FK_OutwardTo", P.AdminInsertNewIDCaseOutward_FK_OutwardTo);
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertNewIDCaseOutward_FK_ReasonDoneID);

            cmd.ExecuteNonQuery();

        }
    }

    public void AdminUpdateMainForNewIDCaseOutward(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainForNewIDCaseOutward";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Inwordno", P.AdminUpdateNewIDCaseOutward_Sno);
            cmd.Parameters.AddWithValue("@OutwardDateTime", P.AdminUpdateNewIDCaseOutward_OutwardDateTime);
            cmd.Parameters.AddWithValue("@OutwardBy", P.AdminUpdateNewIDCaseOutward_Outwardby);
            cmd.Parameters.AddWithValue("@OutwardTo", P.AdminUpdateNewIDCaseOutward_OutwardTo);
            cmd.ExecuteNonQuery();

        }
    }
    //======================================================//

    public void AdminInsertOutwardForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertOutwardForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@OutwardNo", P.AdminInsertOutwardForm_Outwardno);
            cmd.Parameters.AddWithValue("@DateTime", P.AdminInsertOutwardForm_DateTime);
            cmd.Parameters.AddWithValue("@Createdby", P.AdminInsertOutwardForm_Createdby);
            cmd.Parameters.AddWithValue("@Status", P.AdminInsertNewIDCaseForm_Status);
            cmd.ExecuteNonQuery();
        }
    }


    public void AdminInsertCompleteSheetForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertCompleteSheetForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertCompleteSheetForm_InwordNo);
            //cmd.Parameters.AddWithValue("@NoofNewIDs", P.AdminInsertCompleteSheetForm_NoofNewID);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertCompleteSheetForm_Discription);
            //cmd.Parameters.AddWithValue("@PicName", P.AdminInsertCompleteSheetForm_PicName);
            //cmd.Parameters.AddWithValue("@PicPath", P.AdminInsertCompleteSheetForm_PicPath);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertCompleteSheetForm_FkCreatedby);
            cmd.Parameters.AddWithValue("@Status", P.AdminInsertCompleteSheetForm_Status);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminInsertNewIDCaseForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertCompleteCaseForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertNewIDCaseForm_InwordNo);
            //cmd.Parameters.AddWithValue("@NoofNewIDs", P.AdminInsertNewIDCaseForm_NoofNewID);
            cmd.Parameters.AddWithValue("@Discription", P.AdminInsertNewIDCaseForm_Discription);
            //cmd.Parameters.AddWithValue("@PicName", P.AdminInsertNewIDCaseForm_PicName);
            //cmd.Parameters.AddWithValue("@PicPath", P.AdminInsertNewIDCaseForm_PicPath);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertNewIDCaseForm_FKCreatedby);
            cmd.Parameters.AddWithValue("@Status", P.AdminInsertNewIDCaseForm_Status);
            cmd.ExecuteNonQuery();
        }
    }

    public void AdminInsertInitialInwordForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertInitialInwordForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertInitialInwordFormInwordNo);
            cmd.Parameters.AddWithValue("@FK_DepttID", P.AdminInsertInitialInwordFormFK_Deptt_ID);
            cmd.Parameters.AddWithValue("@DateAndTime", P.AdminInsertInitialInwordFormLaunchDate);
            cmd.Parameters.AddWithValue("@Reason", P.AdminInsertInitialInwordFormReason);
            cmd.Parameters.AddWithValue("@NoOfRecords", P.AdminInsertInitialInwordFormNoofRecord);
            cmd.ExecuteNonQuery();

        }
    }

    public void AdminInsertInitialInwordCaseForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertInitialInwordCaseForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertInitialInwordCaseForm_InwordNo);
            cmd.Parameters.AddWithValue("@Reason_of_Inword", P.AdminInsertInitialInwordCaseForm_ReasonofInword);
            cmd.Parameters.AddWithValue("@DateandTime", P.AdminInsertInitialInwordCaseForm_Datetime);
            cmd.Parameters.AddWithValue("@District", P.AdminInsertInitialInwordCaseForm_District);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertInitialInwordCaseForm_FK_Createdby);
            cmd.Parameters.AddWithValue("@Status", P.AdminInsertInitialInwordCaseForm_Status);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminInsertScanningSheetForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertScanningSheetForm";
            cmd.Connection = Getconnected.getconnecting();
            //cmd.Parameters.AddWithValue("@InwordNo", P.AdminInsertScanningInword_Inwordno);
            //cmd.Parameters.AddWithValue("@NoofRecord", P.AdminInsertScanningInword_NoofRecord);
            //cmd.Parameters.AddWithValue("@NewID", P.AdminInsertScanningInword_NewID);
            //cmd.Parameters.AddWithValue("@SameID", P.AdminInsertScanningInword_SameID);
            //cmd.Parameters.AddWithValue("@Modification", P.AdminInsertScanningInword_Modification);
            //cmd.Parameters.AddWithValue("@Discription", P.AdminInsertScanningInword_Discription);
            //cmd.Parameters.AddWithValue("@PicName", P.AdminInsertScanningInword_PicName);
            //cmd.Parameters.AddWithValue("@PicPath", P.AdminInsertScanningInword_PicPath);
            //cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertScanningInword_FKCreatedby);
            //cmd.Parameters.AddWithValue("@Status", P.AdminInsertScanningInword_Status);
            cmd.ExecuteNonQuery();

        }
    }

    public void ResellerInsertProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@product",P.ResellerInsertProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail",P.ResellerInsertProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo",P.ResellerInsertProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price",P.ResellerInsertProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate",P.ResellerInsertProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name",P.ResellerInsertProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path",P.ResellerInsertProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.ResellerInsertProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path",P.ResellerInsertProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.ResellerInsertProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path",P.ResellerInsertProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby",P.ResellerInsertProductFormFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.ResellerInsertProductFormFK_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor",P.ResellerInsertProductFormFK_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status",1);
            cmd.ExecuteNonQuery();

        }
    }



    public void ResellerUpdateProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ResellerUpdateProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@product", P.ResellerInsertProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.ResellerInsertProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.ResellerInsertProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.ResellerInsertProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.ResellerInsertProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.ResellerInsertProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.ResellerInsertProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.ResellerInsertProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.ResellerInsertProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.ResellerInsertProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.ResellerInsertProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerInsertProductFormFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.ResellerInsertProductFormFK_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.ResellerInsertProductFormFK_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", P.ResellerInsertProductFormFK_Status);
            cmd.Parameters.AddWithValue("@PID", P.ResellerInsertProductFormFK_Status);
            cmd.ExecuteNonQuery();

        }
    }


    public void DistributerInsertProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerInsertProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@product", P.DistributerInsertProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.DistributerInsertProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.DistributerInsertProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.DistributerInsertProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.DistributerInsertProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.DistributerInsertProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.DistributerInsertProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.DistributerInsertProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.DistributerInsertProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.DistributerInsertProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.DistributerInsertProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.DistributerInsertProductFormFk_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.DistributerInsertProductFormFk_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.DistributerInsertProductFormFk_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminUpdateProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminUpdateProductFormPID);
            cmd.Parameters.AddWithValue("@Product", P.AdminUpdateProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.AdminUpdateProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.AdminUpdateProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.AdminUpdateProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.AdminUpdateProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.AdminUpdateProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.AdminUpdateProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.AdminUpdateProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.AdminUpdateProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.AdminUpdateProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.AdminUpdateProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateProductFormFk_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.AdminUpdateProductFormFk_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.AdminUpdateProductFormFk_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            cmd.ExecuteNonQuery();

        }
    }




    public void AdminInsertCountryForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertCountryForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Country", P.AdminInsertCountryFormCountry);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertCountryFormFKCreatedby);
            cmd.Parameters.AddWithValue("@FK_region", P.AdminInsertCountryFormFKRegion);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminInsertCountryFormFKStatus);
            cmd.ExecuteNonQuery();
        }
    }





    public void AdminInsertCityForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertCity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@City", P.AdminInsertCityFormCity);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertCityFormFKCreatedby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminInsertCityFormFKStatus);
            cmd.Parameters.AddWithValue("@FK_CountryName", P.AdminInsertCityFormFKCountryName);
            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdateProfile(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProfile";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@Name", P.AdminUpdateProfileName);
            cmd.Parameters.AddWithValue("@Gender", P.AdminUpdateProfileGender);
            cmd.Parameters.AddWithValue("@MartialStatus", P.AdminUpdateProfileMartialStatus);
            cmd.Parameters.AddWithValue("@Birthdate", P.AdminUpdateProfileBirthday);
            cmd.Parameters.AddWithValue("@phone", P.AdminUpdateProfilePhone);
            cmd.Parameters.AddWithValue("@email", P.AdminUpdateProfileEmail);
            cmd.Parameters.AddWithValue("@picname", P.AdminUpdateProfilePicName);
            cmd.Parameters.AddWithValue("@picpath", P.AdminUpdateProfilePicPath);
            cmd.Parameters.AddWithValue("@UID", P.AdminUpdateProfileID);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateProductCategory(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProductCategory";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PCID", P.AdminUpdateProductCategoryPCID);
            cmd.Parameters.AddWithValue("@Category", P.AdminUpdateCategoryFormCategory);
            cmd.Parameters.AddWithValue("@Pic_Name", P.AdminUpdateProductCategoryPic_Name);
            cmd.Parameters.AddWithValue("@Pic_Path", P.AdminUpdateProductCategoryPic_Path);
            cmd.Parameters.AddWithValue("@FK_Srevicetype", P.AdminUpdateProductCategoryFK_Srevicetype);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateProductCategoryFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateProductCategoryFK_Status);
            cmd.ExecuteNonQuery();
        }
    }







    public void AdminUpdateCity(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateCity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CID", P.AdminUpdateCityCID);
            cmd.Parameters.AddWithValue("@City", P.AdminUpdateCityCity);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateCityFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateCityFK_Status);
            cmd.Parameters.AddWithValue("@FK_CountryName", P.AdminUpdateCityFK_CountryName);
            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdateCountry(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateCountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CountID", P.AdminUpdateCountryCountID);
            cmd.Parameters.AddWithValue("@Country", P.AdminUpdateCountryCountry);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateCountryFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Region", P.AdminUpdateCountryFK_Region);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateCountryFK_Status);

            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdatePartnerType(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdatePartnerType";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminUpdatePartnerTypePTID);
            cmd.Parameters.AddWithValue("@Type", P.AdminUpdatePartnerTypeType);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdatePartnerTypeFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdatePartnerTypeFK_Status);

            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdateRegion(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateRegion";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@RID", P.AdminUpdateRegionRID);
            cmd.Parameters.AddWithValue("@Region", P.AdminUpdateRegionRegion);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateRegionFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateRegionFK_Status);

            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdateProductType(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProductType";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminUpdateProductTypePTID);
            cmd.Parameters.AddWithValue("@Type", P.AdminUpdateProductTypeType);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateProductTypeFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductCategory", P.AdminUpdateProductTypeFK_ProductCategory);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateProductTypeFK_Status);
            cmd.Parameters.AddWithValue("@Createdon", P.AdminUpdateProductTypeCreatedon);
            cmd.ExecuteNonQuery();
        }
    }





    public void AdminUpdateService(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProductService";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PSID", P.AdminUpdateServicePSID);
            cmd.Parameters.AddWithValue("@Service", P.AdminUpdateServiceService);
            cmd.Parameters.AddWithValue("@Pic_Name", P.AdminUpdateServicePic_Name);
            cmd.Parameters.AddWithValue("@Pic_Path", P.AdminUpdateServicePic_Path);
            cmd.Parameters.AddWithValue("@Detail", P.AdminUpdateServiceDetail);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateServiceFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateServiceFK_Status);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateUI_PatnerRegistrationFirst(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UI_AdminUpdatePatnerRegistration";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PRID", P.AdminUpdateUI_PatnerRegistrationFirstPRID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateUI_PatnerRegistrationFirstHeading);
            cmd.Parameters.AddWithValue("@TextArea", P.AdminUpdateUI_PatnerRegistrationFirstTextArea);
            cmd.Parameters.AddWithValue("@ButtonText", P.AdminUpdateUI_PatnerRegistrationFirstButtonText);
            cmd.Parameters.AddWithValue("@PicName", P.AdminUpdateUI_PatnerRegistrationFirstPicName);
            cmd.Parameters.AddWithValue("@PicPath", P.AdminUpdateUI_PatnerRegistrationFirstPicPath);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateUI_PatnerRegistrationFirstFk_Modifiedby);
            

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateUI_PatnerRegistrationSecond(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UI_AdminUpdatePatnerRegistration";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PRID", P.AdminUpdateUI_PatnerRegistrationSecondPRID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateUI_PatnerRegistrationSecondHeading);
            cmd.Parameters.AddWithValue("@TextArea", P.AdminUpdateUI_PatnerRegistrationSecondTextArea);
            cmd.Parameters.AddWithValue("@ButtonText", P.AdminUpdateUI_PatnerRegistrationSecondButtonText);
            cmd.Parameters.AddWithValue("@PicName", P.AdminUpdateUI_PatnerRegistrationSecondPicName);
            cmd.Parameters.AddWithValue("@PicPath", P.AdminUpdateUI_PatnerRegistrationSecondPicPath);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateUI_PatnerRegistrationSecondFk_Modifiedby);


            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateUI_PatnerRegistrationThird(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UI_AdminUpdatePatnerRegistration";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PRID", P.AdminUpdateUI_PatnerRegistrationThirdPRID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateUI_PatnerRegistrationThirdHeading);
            cmd.Parameters.AddWithValue("@TextArea", P.AdminUpdateUI_PatnerRegistrationThirdTextArea);
            cmd.Parameters.AddWithValue("@ButtonText", P.AdminUpdateUI_PatnerRegistrationThirdButtonText);
            cmd.Parameters.AddWithValue("@PicName", P.AdminUpdateUI_PatnerRegistrationThirdPicName);
            cmd.Parameters.AddWithValue("@PicPath", P.AdminUpdateUI_PatnerRegistrationThirdPicPath);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateUI_PatnerRegistrationThirdFk_Modifiedby);


            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateUI_TransparentArea(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UI_AdminUpdateTransparentArea";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@TAID", P.AdminUpdateUI_TransparentAreaTAID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateUI_TransparentAreaHeading);
            cmd.Parameters.AddWithValue("@TextArea", P.AdminUpdateUI_TransparentAreaTextArea);
            cmd.Parameters.AddWithValue("@ButtonText", P.AdminUpdateUI_TransparentAreaButtonText);
            cmd.Parameters.AddWithValue("@PicName", P.AdminUpdateUI_TransparentAreaPicName);
            cmd.Parameters.AddWithValue("@PicPath", P.AdminUpdateUI_TransparentAreaPicPath);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateUI_TransparentAreaFk_Modifiedby);


            cmd.ExecuteNonQuery();
        }
    }



    public void DistributerUpdateProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerUpdateProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.DistributerUpdateProductFormPID);
            cmd.Parameters.AddWithValue("@product", P.DistributerUpdateProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.DistributerUpdateProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.DistributerUpdateProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.DistributerUpdateProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.DistributerUpdateProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.DistributerUpdateProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.DistributerUpdateProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.DistributerUpdateProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.DistributerUpdateProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.DistributerUpdateProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.DistributerUpdateProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.DistributerUpdateProductFormFk_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.DistributerUpdateProductFormFk_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.DistributerUpdateProductFormFk_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            cmd.ExecuteNonQuery();

        }
    }


    public void AdminDeleteVendorGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeleteVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeleteVendorGridviewPID);

            cmd.ExecuteNonQuery();
        }
    }




    public void AdminPendedVendorGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminPendngVendorGridviewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminDeActiveVendorGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedVendorGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeActiveVendorGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminPendedResellerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminPendingResellerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminDeleteResellerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeletingResellerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminDeActiveResellerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedResellerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeActiveResellerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminPendedDistributerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminPendingDistributerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminDeleteDistributerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeletingDistributerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }


    public void AdminDeActiveDistributerGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedDistributerGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.AdminDeActiveDistributerGridViewPID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedProductCategoryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PCID", P.AdminPendingProductCategoryGridViewPCID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedProductCategoryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PCID", P.AdminDeletingProductCategoryGridViewPCID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActiveProductCategoryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedProductCategoryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PCID", P.AdminDeActiveProductCategoryGridViewPCID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedProductTypeGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminPendingProductTypeGridViewPTID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedProductTypeGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminDeletingProductTypeGridViewPTID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActiveProductTypeGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedProductTypeGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PTID", P.AdminDeActiveProductTypeGridViewPTID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedProductServiceGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PSID", P.AdminPendingProductServiceGridViewPSID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedProductServiceGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PSID", P.AdminDeletingProductServiceGridViewPSID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActiveProductServiceGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedProductServiceGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PSID", P.AdminDeActiveProductServiceGridViewPSID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedRegionGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@RID", P.AdminPendingRegionGridViewRID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedRegionGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@RID", P.AdminDeletingRegionGridViewRID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActiveRegionGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedRegionGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@RID", P.AdminDeActiveRegionGridViewRID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedCountryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CountID", P.AdminPendingCountryGridViewCountID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedCountryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CountID", P.AdminDeletingCountryGridViewCountID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActivedCountryGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedCountryGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CountID", P.AdminDeActiveCountryGridViewCountID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminPendedCityGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminPendedCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CID", P.AdminPendingCityGridViewCID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeletedCityGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CID", P.AdminDeletingCityGridViewCID);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminDeActivedCityGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDe_ActivedCityGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@CID", P.AdminInwordGridView);

            cmd.ExecuteNonQuery();
        }
    }


    public void ResellerDeleteProductGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ResellerDeletedProductGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.ResellerDeletingProductGridViewPID);
            //cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerDeletingProductGridViewFK_Createdby);
            cmd.ExecuteNonQuery();
        }
    }




    public void DistributerDeleteProductGridView(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerDeletedProductGridView";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.DistributerDeletingProductGridViewPID);
            //cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerDeletingProductGridViewFK_Createdby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateSliderA(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateMainHeadingText";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@SID", P.AdminUpdateSliderASID);
            cmd.Parameters.AddWithValue("@SliderFirstHeadingFirstText", P.AdminUpdateSliderASliderFirstHeadingFirstText);
            cmd.Parameters.AddWithValue("@SliderBoldTechnologyText", P.AdminUpdateSliderASliderBoldTechnologyText);
            //cmd.Parameters.AddWithValue("@Modifiedon", P.AdminUpdateSliderAModifiedon);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateSliderAFk_Modifiedby);

            cmd.ExecuteNonQuery();
        }
    }




    public void AdminUpdateSideSlider(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateSideSlider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@SID", P.AdminUpdateSideSliderSID);
            cmd.Parameters.AddWithValue("@SignuptodayHeading1", P.AdminUpdateSideSliderSignuptodayHeading1);
            cmd.Parameters.AddWithValue("@SignuptodayHeading2", P.AdminUpdateSideSliderSignuptodayHeading2);
            cmd.Parameters.AddWithValue("@SignuptodayHeading3", P.AdminUpdateSideSliderSignuptodayHeading3);
            cmd.Parameters.AddWithValue("@SignuptodayText1", P.AdminUpdateSideSliderSignuptodayText1);
            cmd.Parameters.AddWithValue("@SignuptodayText2", P.AdminUpdateSideSliderSignuptodayText2);
            cmd.Parameters.AddWithValue("@SignuptodayText3", P.AdminUpdateSideSliderSignuptodayText3);
            //cmd.Parameters.AddWithValue("@Modifiedon", P.AdminUpdateSliderAModifiedon);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateSideSliderFk_Modifiedby);

            cmd.ExecuteNonQuery();
        }
    }



    public void AdminInsertTierLevelForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertTierLevel";
            cmd.Connection = Getconnected.getconnecting();
            //cmd.Parameters.AddWithValue("@TLID", P.AdminInsertTierLevelTLID);
            cmd.Parameters.AddWithValue("@TierLevel", P.AdminInsertTierLevelTierLevel);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_CreatedBy", P.AdminInsertTierLevelFk_Createdby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateTierLevelForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateTierLevel";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@TLID", P.AdminUpdateTierLevelTLID);
            cmd.Parameters.AddWithValue("@TierLevel", P.AdminUpdateTierLevelTierLevel);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_CreatedBy", P.AdminUpdateTierLevelFk_Createdby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminInsertAssignTierLevelForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertTierLevelDistributer";
            cmd.Connection = Getconnected.getconnecting();
            //cmd.Parameters.AddWithValue("@TLID", P.AdminInsertTierLevelTLID);
            cmd.Parameters.AddWithValue("@FK_TierLevel", P.AdminInsertAssignTierLevelFk_TierLevel);
            cmd.Parameters.AddWithValue("@FK_Distributer", P.AdminInsertAssignTierLevelFk_Distributer);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminInsertAssignTierLevelFk_Createdby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateAssignTierLevelForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateTierLevelDistributer";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@TID", P.AdminUpdateAssignTierLevelTID);
            cmd.Parameters.AddWithValue("@FK_TierLevel", P.AdminUpdateAssignTierLevelFk_TierLevel);
            cmd.Parameters.AddWithValue("@FK_Distributer", P.AdminUpdateAssignTierLevelFk_Distributer);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateAssignTierLevelFk_Modifiedby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateWhatWeDoForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateWhatWeDo";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@WWDID", P.AdminUpdateWhatWeDoWWDID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateWhatWeDoHeading);
            cmd.Parameters.AddWithValue("@Text", P.AdminUpdateWhatWeDoText);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateWhatWeDoModifiedby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateWhatWeAreForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateWhatWeAre";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@WWAID", P.AdminUpdateWhatWeAreWWAID);
            cmd.Parameters.AddWithValue("@Heading", P.AdminUpdateWhatWeAreHeading);
            cmd.Parameters.AddWithValue("@Text", P.AdminUpdateWhatWeAreText);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateWhatWeAreFk_Modifiedby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminInsertSubscriberInfoForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminInsertSubscriberInfo";
            cmd.Connection = Getconnected.getconnecting();
            //cmd.Parameters.AddWithValue("@SIID", P.AdminInsertSubscriberInfoSIID);
            cmd.Parameters.AddWithValue("@SubscriberEmail", P.AdminInsertSubscriberInfoSubscriberEmail);
            //cmd.Parameters.AddWithValue("@Createdon", P.AdminInsertTierLevelCreatedon);
            cmd.Parameters.AddWithValue("@FK_CreatedBy", P.AdminInsertSubscriberInfoFk_Createdby);
            cmd.ExecuteNonQuery();
        }
    }



    public void AdminUpdateSocialMediaLinksForm(Properties P)
    {


        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateSocialMediaTable";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@SMTID", P.AdminUpdateSocialMediaLinksSMTID);
            cmd.Parameters.AddWithValue("@facebook", P.AdminUpdateSocialMediaLinksFacebook);
            cmd.Parameters.AddWithValue("@Youtube", P.AdminUpdateSocialMediaLinksYouTube);
            cmd.Parameters.AddWithValue("@Google", P.AdminUpdateSocialMediaLinksGoogle);
            cmd.Parameters.AddWithValue("@Twitter", P.AdminUpdateSocialMediaLinksTwitter);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdateSocialMediaLinksFk_Modifiedby);
            cmd.ExecuteNonQuery();
        }
    }




    public void AdminUpdatePatnerBranchForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateBranch";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@BranchID", P.AdminUpdatePatnerBranchFormBranchID);
            cmd.Parameters.AddWithValue("@Address", P.AdminUpdatePatnerBranchFormAddress);
            cmd.Parameters.AddWithValue("@Postalcode", P.AdminUpdatePatnerBranchFormPostalcode);
            cmd.Parameters.AddWithValue("@FK_City", P.AdminUpdatePatnerBranchFormFk_City);
            cmd.Parameters.AddWithValue("@FK_Patner", P.AdminUpdatePatnerBranchFormFk_Patner);
            cmd.Parameters.AddWithValue("@FK_Modifiedby", P.AdminUpdatePatnerBranchFormFk_Modifiedby);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            cmd.ExecuteNonQuery();

        }
    }



    public void AdminUpdateProductPatnerRelationshipForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminUpdateProductPatnerRelationship";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PPRID", P.AdminUpdateProductPatnerRelationshipPPRID);
            cmd.Parameters.AddWithValue("@FK_Product", P.AdminUpdateProductPatnerRelationshipFK_Product);
            cmd.Parameters.AddWithValue("@FK_Patner", P.AdminUpdateProductPatnerRelationshipFK_Patner);
            cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdateProductPatnerRelationshipFK_Status);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdateProductPatnerRelationshipFK_Createdby);

            cmd.ExecuteNonQuery();

        }
    }




    public void VendorInsertProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_VendorInsertProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@product", P.VendorInsertProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.VendorInsertProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.VendorInsertProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.VendorInsertProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.VendorInsertProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.VendorInsertProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.VendorInsertProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.VendorInsertProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.VendorInsertProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.VendorInsertProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.VendorInsertProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.VendorInsertProductFormFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.VendorInsertProductFormFK_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.VendorInsertProductFormFK_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            //cmd.Parameters.AddWithValue("@FK_Patner", P.AdminInsertProductFormFK_Patner);
            cmd.ExecuteNonQuery();

        }
    }




    public void VendorUpdateProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_VendorUpdateProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@PID", P.VendorUpdateProductFormPID);
            cmd.Parameters.AddWithValue("@product", P.VendorUpdateProductFormProductName);
            cmd.Parameters.AddWithValue("@Detail", P.VendorUpdateProductFormDetail);
            cmd.Parameters.AddWithValue("@ModelNo", P.VendorUpdateProductFormModelNo);
            cmd.Parameters.AddWithValue("@Price", P.VendorUpdateProductFormPrice);
            cmd.Parameters.AddWithValue("@Launchdate", P.VendorUpdateProductFormLaunchDate);
            cmd.Parameters.AddWithValue("@pic1name", P.VendorUpdateProductFormPic1name);
            cmd.Parameters.AddWithValue("@pic1path", P.VendorUpdateProductFormPic1path);
            cmd.Parameters.AddWithValue("@pic2name", P.VendorUpdateProductFormPic2name);
            cmd.Parameters.AddWithValue("@pic2path", P.VendorUpdateProductFormPic2path);
            cmd.Parameters.AddWithValue("@pic3name", P.VendorUpdateProductFormPic3name);
            cmd.Parameters.AddWithValue("@pic3path", P.VendorUpdateProductFormPic3path);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.VendorUpdateProductFormFK_Createdby);
            cmd.Parameters.AddWithValue("@FK_ProductType", P.VendorUpdateProductFormFK_ProductType);
            cmd.Parameters.AddWithValue("@FK_Vendor", P.VendorUpdateProductFormFK_Vendor);
            cmd.Parameters.AddWithValue("@FK_Status", 1);
            //cmd.Parameters.AddWithValue("@FK_Patner", P.AdminInsertProductFormFK_Patner);
            cmd.ExecuteNonQuery();

        }
    }



    public void ReselerAddProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ResellerInsertProductForm";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Product", P.ResellerAddProductFormFK_Product);
            cmd.Parameters.AddWithValue("@FK_Patner", P.ResellerAddProductFormFK_Patner);
            cmd.Parameters.AddWithValue("@FK_Status", P.ResellerAddProductFormFK_Status);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.ResellerAddProductFormFK_Createdby);

            cmd.ExecuteNonQuery();

        }
    }




    public void DistributerAddProductForm(Properties P)
    {
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DistributerInsertProduct";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@FK_Product",   P.DistributerAddProductFormFK_Product);
            cmd.Parameters.AddWithValue("@FK_Patner",    P.DistributerAddProductFormFK_Patner);
            cmd.Parameters.AddWithValue("@FK_Status",    P.DistributerAddProductFormFK_Status);
            cmd.Parameters.AddWithValue("@FK_Createdby", P.DistributerAddProductFormFK_Createdby);

            cmd.ExecuteNonQuery();

        }
    }
}