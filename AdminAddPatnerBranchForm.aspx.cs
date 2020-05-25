using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddPatnerBranchForm : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {
            if (!IsPostBack)
            {
                //slctreason.DataSource = Dropdown.GetAdminReason();
                //slctreason.DataTextField = "Text";
                //slctreason.DataValueField = "Value";
                //slctreason.DataBind();

                slctdepartment.DataSource = Dropdown.GetAdminDepartment();
                slctdepartment.DataTextField = "Text";
                slctdepartment.DataValueField = "Value";
                slctdepartment.DataBind();

            }
        }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertScanningInword_Inwordno = txtinwordno.Value;
        variables.AdminInsertScanningInword_Discription = txtDiscription.Value;
        variables.AdminInsertScanningInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertScanningInword_NoofIDs = Convert.ToInt32(txtNoofID.Value);
        variables.AdminInsertScanningInword_NoofPages = Convert.ToInt32(txtpages.Value);
        //variables.AdminInsertScanningInword_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertScanningInword_FK_Department = Convert.ToInt32(slctdepartment.Value);
        variables.AdminInsertScanningInword_FK_Createdby = Convert.ToInt32(Session["username"]);
        //variables.AdminInsertScanningInword_FK_Reason = Convert.ToInt32(slctreason.Value);
        variables.AdminInsertScanningInword_FK_Status = 1;

        insert.AdminInsertInwordHistory(variables);

        variables.AdminInsertMain_Inwordno = txtinwordno.Value;
        variables.AdminInsertMain_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertMain_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertMain_FK_Department = Convert.ToInt32(slctdepartment.Value);
        variables.AdminInsertMain_FK_Createdby = Convert.ToInt32(Session["username"]);
        //variables.AdminInsertMain_FK_Reason = Convert.ToInt32(slctreason.Value);

        insert.AdminInsertMain(variables);
    }
}