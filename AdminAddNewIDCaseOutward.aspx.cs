using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminAddNewIDCaseOutward : System.Web.UI.Page
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
                    slctInwordNo.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_9();
                    slctInwordNo.DataTextField = "Text";
                    slctInwordNo.DataValueField = "Value";
                    slctInwordNo.DataBind();

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
        variables.AdminInsertNewIDCaseOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertNewIDCaseOutward_Discription = txtDiscription.Value;
        variables.AdminInsertNewIDCaseOutward_FK_NewIDCaseInwordID = Convert.ToInt32(slctInwordNo.SelectedValue);
        variables.AdminInsertNewIDCaseOutward_FK_Createdby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertNewIDCaseOutward_FK_OutwardTo = Convert.ToInt32(slctOutwardto.Value);
        variables.AdminInsertNewIDCaseOutward_FK_ReasonDoneID = slctInwordNo.SelectedItem.Text;

        Insert.AdminInsertNewIDCaseOutward(variables);
        //updation start//
        variables.AdminUpdateNewIDCaseOutward_Sno = slctInwordNo.SelectedItem.Text;
        variables.AdminUpdateNewIDCaseOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateNewIDCaseOutward_Outwardby = Convert.ToString(Session["username"]);
        variables.AdminUpdateNewIDCaseOutward_OutwardTo = Convert.ToInt32(slctOutwardto.Value);

        Insert.AdminUpdateMainForNewIDCaseOutward(variables);

        slctInwordNo.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_9();
        slctInwordNo.DataTextField = "Text";
        slctInwordNo.DataValueField = "Value";
        slctInwordNo.DataBind();

        slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
        slctOutwardto.DataTextField = "Text";
        slctOutwardto.DataValueField = "Value";
        slctOutwardto.DataBind();
    }
}