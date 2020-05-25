using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddAssignTierLevel : System.Web.UI.Page
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
                    slcttierlevel.DataSource = Dropdown.GetAdminTierLevelDistributerFk_TierLevel();
                    slcttierlevel.DataTextField = "Text";
                    slcttierlevel.DataValueField = "Value";
                    slcttierlevel.DataBind();


                    slctdistributer.DataSource = Dropdown.GetAdminTierLevelDistributerFk_Distributer();
                    slctdistributer.DataTextField = "Text";
                    slctdistributer.DataValueField = "Value";
                    slctdistributer.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertAssignTierLevelFk_TierLevel = Convert.ToInt32(slcttierlevel.Value);
        variables.AdminInsertAssignTierLevelFk_Distributer = Convert.ToInt32(slctdistributer.Value);
        variables.AdminInsertAssignTierLevelFk_Createdby = Convert.ToInt32(Session["username"]);

        insert.AdminInsertAssignTierLevelForm(variables);
    }
}