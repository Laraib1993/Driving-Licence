using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminAddPatnerNewType : System.Web.UI.Page
{
    Properties Variables = new Properties();
    Insertion Insert = new Insertion();
    edit ed = new edit();
    DataTable table = new DataTable();
    protected static SqlCommand cmd;
    protected static SqlDataReader sdr;
    protected static SqlDataAdapter sda;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slctinwordno.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_1();
                    slctinwordno.DataTextField = "Text";
                    slctinwordno.DataValueField = "Value";
                    slctinwordno.DataBind();

                    slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
                    slctOutwardto.DataTextField = "Text";
                    slctOutwardto.DataValueField = "Value";
                    slctOutwardto.DataBind();


                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex)
        { }
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Variables.AdminInsertOutwardHistory_OutwarddateTime = Convert.ToDateTime(txtlaunchdate.Value);
        Variables.AdminInsertOutwardHistory_FK_Reason = 2;
        Variables.AdminInsertOutwardHistory_FK_InwordhistoryID = Convert.ToInt32(slctinwordno.SelectedValue);
        Variables.AdminInsertOutwardHistory_FK_Outwardto = Convert.ToInt32(slctOutwardto.Value);
        Variables.AdminInsertOutwardHistory_FK_Outwardby = Convert.ToInt32(Session["username"]);
        Variables.AdminInsertOutwardHistory_FK_Status = 1;
        Variables.AdminUpdateOutwardHistory_FK_ReasonDoneID = slctinwordno.SelectedItem.Text;

        Insert.AdminInsertOutwardHistory(Variables);
        //updation start//
        Variables.AdminUpdateMain_Sno = slctinwordno.SelectedItem.Text;
        Variables.AdminUpdateMain_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        Variables.AdminUpdateMain_OutwardBy = Convert.ToString(Session["username"]);
        Variables.AdminUpdateMain_Outwardto = Convert.ToInt32(slctOutwardto.Value);

        Insert.AdminUpdateMainForScanning(Variables);

        slctinwordno.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_1();
        slctinwordno.DataTextField = "Text";
        slctinwordno.DataValueField = "Value";
        slctinwordno.DataBind();

        slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
        slctOutwardto.DataTextField = "Text";
        slctOutwardto.DataValueField = "Value";
        slctOutwardto.DataBind();

    }

    //protected void slctpatner_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (chkdistributer.Checked == true && chkreseller.Checked == true && chkvendor.Checked == true) { chkdistributer.Checked = false; chkvendor.Checked = false; chkreseller.Checked = false; chkdistributer.Disabled = false; chkvendor.Disabled = false; chkreseller.Disabled = false; }
    //        else if (chkdistributer.Checked == true && chkreseller.Checked == true) { chkdistributer.Checked = false; chkreseller.Checked = false; chkdistributer.Disabled = false; chkreseller.Disabled = false; }
    //        else if (chkdistributer.Checked == true && chkvendor.Checked == true) { chkdistributer.Checked = false; chkvendor.Checked = false; chkdistributer.Disabled = false; chkvendor.Disabled = false; }
    //        else if (chkreseller.Checked == true && chkvendor.Checked == true) { chkvendor.Checked = false; chkreseller.Checked = false; chkvendor.Disabled = false; chkreseller.Disabled = false; }
    //        else if (chkdistributer.Checked == true) { chkdistributer.Checked = false; chkdistributer.Disabled = false; }
    //        else if (chkreseller.Checked == true) { chkreseller.Checked = false; chkreseller.Disabled = false; }
    //        else if (chkvendor.Checked == true) { chkvendor.Checked = false; chkvendor.Disabled = false; }


    //        Variables.AdminPatnerTypeRelationFetch = Convert.ToInt32(slctpatner.SelectedValue);
    //        table = fetching.AdminAddPatnerNewTypeFetch(Variables);
    //        int checkbox;

    //        using (cmd = new SqlCommand())
    //        {

    //            cmd.CommandType = CommandType.StoredProcedure;
    //            cmd.CommandText = "sp_AdminFetchPatnerTypeRelation";
    //            cmd.Connection = Getconnected.getconnecting();
    //            cmd.Parameters.AddWithValue("@FK_Patner", Variables.AdminPatnerTypeRelationFetch);
    //            using (sdr = cmd.ExecuteReader())
    //            {

    //                while (sdr.Read())
    //                {
    //                    checkbox = Convert.ToInt32(sdr[1]);
    //                    if (checkbox == 5) { chkvendor.Disabled = true; chkvendor.Checked = true; }
    //                    else if (checkbox == 6) { chkdistributer.Disabled = true; chkdistributer.Checked = true; }
    //                    else if (checkbox == 7) { chkreseller.Disabled = true; chkreseller.Checked = true; }
    //                }
    //            }

    //        }
    //    }
        
    //    catch(Exception ex) { }

        
    //        //int checkbox = Convert.ToInt32(U);
    //        //if (checkbox == 5) { chkvendor.Disabled = true; chkvendor.Checked = true; }
    //        //else if (checkbox == 6) { chkdistributer.Disabled = true; chkdistributer.Checked = true; }
    //        //else if (checkbox == 7) { chkreseller.Disabled = true; chkreseller.Checked = true; }
        


    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            //Variables.AdminUpdateMainForScanning = Convert.ToInt32(slctinwordno.SelectedValue);
            //table = ed.AdminEditScanningOutwardForm(Variables);
            //slctinwordno.SelectedValue = table.Rows[0][1].ToString().Trim();
            //slctOutwardto.Value = table.Rows[0][8].ToString().Trim();
            //slctreason.Value = table.Rows[0][9].ToString().Trim();
            
        }
        catch (Exception ex) { }
    }
}