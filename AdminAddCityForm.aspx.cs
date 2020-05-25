using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddCityForm : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                // -------- //
                if (!IsPostBack)
                {
                    slctcountry.DataSource = Dropdown.GetAdminCityFormCountryName();
                    slctcountry.DataTextField = "Text";
                    slctcountry.DataValueField = "Value";
                    slctcountry.DataBind();
                }
                // ------- //

            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertCityFormCity = txtcity.Value;
        variables.AdminInsertCityFormFKCreatedby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertCityFormFKStatus = 1;
        variables.AdminInsertCityFormFKCountryName = Convert.ToInt32(slctcountry.Value);

        insert.AdminInsertCityForm(variables);
    }
}