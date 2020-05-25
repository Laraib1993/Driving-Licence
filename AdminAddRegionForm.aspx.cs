using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddRegionForm : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slctOutward.DataSource = Dropdown.GetAdminOutward();
                    slctOutward.DataTextField = "Text";
                    slctOutward.DataValueField = "Value";
                    slctOutward.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            variables.AdminInsertOutwardForm_Outwardno = slctOutward.Value;
            variables.AdminInsertOutwardForm_DateTime = Convert.ToDateTime(txtlaunchdate.Value);
            variables.AdminInsertOutwardForm_Createdby = Convert.ToInt32(Session["username"]);
            variables.AdminInsertNewIDCaseForm_Status = 1;
            insert.AdminInsertOutwardForm(variables);
        }
        catch(Exception ex)
        {

        }
    }
}