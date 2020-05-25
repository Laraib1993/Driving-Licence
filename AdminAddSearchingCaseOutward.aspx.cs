using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminAddSearchingCaseOutward : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion Insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_7();
                    slctinword.DataTextField = "Text";
                    slctinword.DataValueField = "Value";
                    slctinword.DataBind();

                    slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
                    slctOutwardto.DataTextField = "Text";
                    slctOutwardto.DataValueField = "Value";
                    slctOutwardto.DataBind();


                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex)
        { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertSearchingCaseOutward_NoofNewID = Convert.ToInt32(txtnoofNewID.Value);
        variables.AdminInsertSearchingCaseOutward_NoofSameID = Convert.ToInt32(txtSameid.Value);
        variables.AdminInsertSearchingCaseOutward_NoofModification = Convert.ToInt32(txtnoofModification.Value);
        variables.AdminInsertSearchingCaseOutward_Discription = txtDiscription.Value;
        variables.AdminInsertSearchingCaseOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertSearchingCaseOutward_FK_SearchingCaseInwordID = Convert.ToInt32(slctinword.SelectedValue);
        variables.AdminInsertSearchingCaseOutward_FK_OutwardTo = Convert.ToInt32(slctOutwardto.Value);
        variables.AdminInsertSearchingCaseOutward_FK_Createdby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertSearchingCaseOutward_FK_ReasonDoneID = slctinword.SelectedItem.Text;

        Insert.AdminInsertSearchingCaseOutward(variables);
        //updation start//
        variables.AdminUpdateMainForSearchingCaseOutward_Sno = Convert.ToInt32(slctinword.SelectedItem.Text);
        variables.AdminUpdateMainForSearchingCaseOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateMainForSearchingCaseOutward_OutwardBy = Convert.ToString(Session["username"]);
        variables.AdminUpdateMainForSearchingCaseOutward_OutwardTo = Convert.ToInt32(slctOutwardto.Value);

        Insert.AdminUpdateMainForSearchingCaseOutward(variables);

        slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_7();
        slctinword.DataTextField = "Text";
        slctinword.DataValueField = "Value";
        slctinword.DataBind();

        slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
        slctOutwardto.DataTextField = "Text";
        slctOutwardto.DataValueField = "Value";
        slctOutwardto.DataBind();
    }
}