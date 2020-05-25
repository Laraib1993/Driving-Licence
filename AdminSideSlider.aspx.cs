using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminSideSlider : System.Web.UI.Page
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
        variables.AdminUpdateSideSliderSID = 1;
        variables.AdminUpdateSideSliderSignuptodayHeading1 = txtheading1.Value;
        variables.AdminUpdateSideSliderSignuptodayHeading2 = txtheading2.Value;
        variables.AdminUpdateSideSliderSignuptodayHeading3 = txtheading3.Value;

        variables.AdminUpdateSideSliderSignuptodayText1 = txttext1.Value;
        variables.AdminUpdateSideSliderSignuptodayText2 = txttext2.Value;
        variables.AdminUpdateSideSliderSignuptodayText3 = txttext3.Value;
        insert.AdminUpdateSideSlider(variables);
    }
}