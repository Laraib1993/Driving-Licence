using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminAddNewIDCaseInword : System.Web.UI.Page
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
                    slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_8();
                    slctinword.DataTextField = "Text";
                    slctinword.DataValueField = "Value";
                    slctinword.DataBind();

                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex)
        { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertNewIDCaseInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertNewIDCaseInword_Discription = txtDiscription.Value;
        variables.AdminInsertNewIDCaseInword_FK_SearchingOutwardCaseID = Convert.ToInt32(slctinword.SelectedValue);
        variables.AdminInsertNewIDCaseInword_FK_Createdby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertNewIDCaseInword_FK_ReasonDoneID = slctinword.SelectedItem.Text;

        Insert.AdminInsertNewIDCaseInword(variables);
        //updation start//
        variables.AdminUpdateMainForNewIDCaseInword_Sno = slctinword.SelectedItem.Text;
        variables.AdminUpdateMainForNewIDCaseInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateMainForNewIDCaseInword_FK_Createdby = Convert.ToInt32(Session["username"]);

        Insert.AdminUpdateMainForNewIDCaseInword(variables);

        slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_8();
        slctinword.DataTextField = "Text";
        slctinword.DataValueField = "Value";
        slctinword.DataBind();
    }
}