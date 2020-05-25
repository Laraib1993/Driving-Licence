using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditRegionForm : System.Web.UI.Page
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
                    slcteditregion.DataSource = Dropdown.GetAdminCountryFormRegion();
                    slcteditregion.DataTextField = "Text";
                    slcteditregion.DataValueField = "Value";
                    slcteditregion.DataBind();
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
            variables.AdminUpdateRegionRID = Convert.ToInt32(slcteditregion.SelectedValue);
            variables.AdminUpdateRegionRegion = txtregion.Value;
            variables.AdminUpdateRegionFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateRegionFK_Status = 1;

            insert.AdminUpdateRegion(variables);
            txtregion.Value = "";
            slcteditregion.DataSource = Dropdown.GetAdminCountryFormRegion();
            slcteditregion.DataTextField = "Text";
            slcteditregion.DataValueField = "Value";
            slcteditregion.DataBind();
        }
        catch(Exception ex) { }
        
    }

    protected void slcteditregion_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditRegionForm = Convert.ToInt16(slcteditregion.SelectedValue);
            table = ed.AdminEditRegionForm(variables);
            txtregion.Value = table.Rows[0][1].ToString().Trim();
        }
        catch(Exception ex) { }
        
    }
}