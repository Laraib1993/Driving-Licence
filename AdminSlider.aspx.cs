using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminSlider : System.Web.UI.Page
{
    Insertion insert = new Insertion();
    Properties variables = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null) { }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateSliderASID = 1;
        variables.AdminUpdateSliderASliderFirstHeadingFirstText = txtheading1.Value;
        variables.AdminUpdateSliderASliderBoldTechnologyText = txtheading2.Value;
        //variables.AdminUpdateSliderAFk_Modifiedby = Convert.ToInt32(Session["username"]);

        insert.AdminUpdateSliderA(variables);
    }
}