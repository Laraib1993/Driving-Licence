using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddResellerForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                txtcity.DataSource = Dropdown.GetAdminEditPatnerFormCity();
                txtcity.DataTextField = "Text";
                txtcity.DataValueField = "Value";
                txtcity.DataBind();
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }
}