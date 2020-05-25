using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddTierLevelName : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null) { }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
        variables.AdminInsertTierLevelTierLevel = txttierlevel.Value;
        variables.AdminInsertTierLevelFk_Createdby = Convert.ToInt32(Session["username"]);

        insert.AdminInsertTierLevelForm(variables);
    }
}