using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditProductPatnerRelationship : System.Web.UI.Page
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

                   SlctPatner.DataSource = Dropdown.GetAdminProductPatnerRelationshipForPatner();
                   SlctPatner.DataTextField = "Text";
                   SlctPatner.DataValueField = "Value";
                   SlctPatner.DataBind();

                   ddlproduct.DataSource = Dropdown.GetAdminProductPatnerRelationshipForProduct();
                   ddlproduct.DataTextField = "Text";
                   ddlproduct.DataValueField = "Value";
                   ddlproduct.DataBind();
                    

                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateProductPatnerRelationshipPPRID = Convert.ToInt16(SlctPatner.SelectedValue);
        variables.AdminUpdateProductPatnerRelationshipFK_Patner =Convert.ToInt16(SlctPatner.SelectedValue);
        variables.AdminUpdateProductPatnerRelationshipFK_Product = Convert.ToInt16(ddlproduct.SelectedValue);
        variables.AdminUpdateProductPatnerRelationshipFK_Createdby = Convert.ToInt16(Session["username"]);
        variables.AdminUpdateProductPatnerRelationshipFK_Status = 1;

        insert.AdminUpdateProductPatnerRelationshipForm(variables);

        //ddlproduct.Value = "";
        SlctPatner.DataSource = Dropdown.GetAdminProductPatnerRelationshipForPatner();
        SlctPatner.DataTextField = "Text";
        SlctPatner.DataValueField = "Value";
        SlctPatner.DataBind();

        ddlproduct.DataSource = Dropdown.GetAdminProductPatnerRelationshipForProduct();
        ddlproduct.DataTextField = "Text";
        ddlproduct.DataValueField = "Value";
        ddlproduct.DataBind();
    }

    protected void ddlproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void SlctPatner_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
            variables.AdminEditProductPatnerRelationshipFetch = Convert.ToInt16(SlctPatner.SelectedValue);
            table = ed.AdminEditProductPatnerRelationshipFetch(variables);
            string a = table.Rows[0][1].ToString().Trim();
            ddlproduct.SelectedValue = a;

        //}
        //catch (Exception ex) { }
    }
}