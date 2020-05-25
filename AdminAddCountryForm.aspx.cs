using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddCountryForm : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion inert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slct.DataSource = Dropdown.GetAdminCountryFormRegion();
                    slct.DataTextField = "Text";
                    slct.DataValueField = "Value";
                    slct.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertCountryFormCountry = txtcountry.Value;
        variables.AdminInsertCountryFormFKCreatedby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertCountryFormFKRegion = Convert.ToInt32(slct.Value);
        variables.AdminInsertCountryFormFKStatus = 1;

        inert.AdminInsertCountryForm(variables);
    }
}