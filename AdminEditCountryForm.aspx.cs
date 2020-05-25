using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class AdminEditCountryForm : System.Web.UI.Page
{
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    edit ed = new edit();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slcteditcountry.DataSource = Dropdown.GetAdminCityFormCountryName();
                    slcteditcountry.DataTextField = "Text";
                    slcteditcountry.DataValueField = "Value";
                    slcteditcountry.DataBind();


                    slctregion.DataSource = Dropdown.GetAdminCountryFormRegion();
                    slctregion.DataTextField = "Text";
                    slctregion.DataValueField = "Value";
                    slctregion.DataBind();


                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            variables.AdminUpdateCountryCountID = Convert.ToInt16(slcteditcountry.SelectedValue);
            variables.AdminUpdateCountryCountry = txtcountry.Value;
            variables.AdminUpdateCountryFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateCountryFK_Region = Convert.ToInt16(slctregion.Value);
            variables.AdminUpdateCountryFK_Status = 1;
            insert.AdminUpdateCountry(variables);


            txtcountry.Value = "";

            slcteditcountry.DataSource = Dropdown.GetAdminCityFormCountryName();
            slcteditcountry.DataTextField = "Text";
            slcteditcountry.DataValueField = "Value";
            slcteditcountry.DataBind();


            slctregion.DataSource = Dropdown.GetAdminCountryFormRegion();
            slctregion.DataTextField = "Text";
            slctregion.DataValueField = "Value";
            slctregion.DataBind();
        }
        catch(Exception ex) { }
       


    }

    protected void slcteditcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditCountryForm = Convert.ToInt16(slcteditcountry.SelectedValue);
            table = ed.AdminEditCountryForm(variables);

            txtcountry.Value = table.Rows[0][1].ToString().Trim();
            slctregion.Value = table.Rows[0][4].ToString().Trim();
        }
        catch(Exception ex)
        {

        }
       
    }
}