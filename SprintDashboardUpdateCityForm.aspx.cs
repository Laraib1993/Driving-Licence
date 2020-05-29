using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SprintDashboardUpdateCityForm : System.Web.UI.Page
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
                    slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slcteditCity.DataTextField = "Text";
                    slcteditCity.DataValueField = "Value";
                    slcteditCity.DataBind();


                    slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slcteditCity.DataTextField = "Text";
                    slcteditCity.DataValueField = "Value";
                    slcteditCity.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }

    protected void slcteditCity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}