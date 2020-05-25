using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminWhatWeAre : System.Web.UI.Page
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
        variables.AdminUpdateWhatWeAreWWAID = 1;
        variables.AdminUpdateWhatWeAreHeading = txtheading.Value;
        variables.AdminUpdateWhatWeAreText = txtpara.Value;
        variables.AdminUpdateWhatWeAreFk_Modifiedby = Convert.ToInt32(Session["username"]);

        insert.AdminUpdateWhatWeAreForm(variables);
    }
}