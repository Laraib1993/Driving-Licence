using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// ------- //
using System.Data;
// ------ //
public partial class AdminEditCityForm : System.Web.UI.Page
{
    // ---------------------------- //
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    edit ed = new edit();
    // ---------------------------- //
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {

                if (!IsPostBack)
                {
                    slcteditcity.DataSource = Dropdown.GetAdminEditCityFormCity();
                    slcteditcity.DataTextField = "Text";
                    slcteditcity.DataValueField = "Value";
                    slcteditcity.DataBind();


                    slctcountry.DataSource = Dropdown.GetAdminCityFormCountryName();
                    slctcountry.DataTextField = "Text";
                    slctcountry.DataValueField = "Value";
                    slctcountry.DataBind();


                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
        
        


    }

    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            variables.AdminUpdateCityCID = Convert.ToInt16(slcteditcity.SelectedValue);
            variables.AdminUpdateCityCity = txtcity.Value;
            variables.AdminUpdateCityFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateCityFK_Status = 1;
            variables.AdminUpdateCityFK_CountryName = Convert.ToInt16(slctcountry.Value);
            insert.AdminUpdateCity(variables);

            txtcity.Value = "";
            slcteditcity.DataSource = Dropdown.GetAdminEditCityFormCity();
            slcteditcity.DataTextField = "Text";
            slcteditcity.DataValueField = "Value";
            slcteditcity.DataBind();
            // ------ //
            slctcountry.DataSource = Dropdown.GetAdminCityFormCountryName();
            slctcountry.DataTextField = "Text";
            slctcountry.DataValueField = "Value";
            slctcountry.DataBind();
        }
        catch(Exception ex) { }
       
    }

    protected void slcteditcity_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditCityFetch = Convert.ToInt16(slcteditcity.SelectedValue);
            table = ed.AdminEditCityFetch(variables);

            txtcity.Value = table.Rows[0][1].ToString().Trim();
            slctcountry.Value = table.Rows[0][5].ToString().Trim();
        }
        catch(Exception ex) { }
       
    }

    //protected void slcteditcity_TextChanged(object sender, EventArgs e)
    //{
    //    variables.AdminEditCityFetch = Convert.ToInt16(slcteditcity.SelectedValue);
    //    table = ed.AdminEditCityFetch(variables);

    //    txtcity.Value = table.Rows[0][1].ToString().Trim();
    //    slctcountry.Value = table.Rows[0][5].ToString().Trim();
    //}
}