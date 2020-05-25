using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditPatnerBranchForm : System.Web.UI.Page
{
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    edit ed = new edit();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {
            if (!IsPostBack)
            {

                slcteditpatner.DataSource = Dropdown.GetAdminEditPatnerFormPatner();
                slcteditpatner.DataTextField = "Text";
                slcteditpatner.DataValueField = "Value";
                slcteditpatner.DataBind();

                //slctpatnerbranch.DataSource = Dropdown.GetAdminPatnerBranchFormPatner();
                //slctpatnerbranch.DataTextField = "Text";
                //slctpatnerbranch.DataValueField = "Value";
                //slctpatnerbranch.DataBind();


                Slctcity.DataSource = Dropdown.GetAdminPatnerBranchFormCity();
                Slctcity.DataTextField = "Text";
                Slctcity.DataValueField = "Value";
                Slctcity.DataBind();

            }
        }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdatePatnerBranchFormBranchID = Convert.ToInt16(slcteditpatner.SelectedValue);
        variables.AdminUpdatePatnerBranchFormAddress = txtaddress.Value;
        variables.AdminUpdatePatnerBranchFormPostalcode = txtpostalcode.Value;
        variables.AdminUpdatePatnerBranchFormFk_Patner = Convert.ToInt16(slctpatnerbranch.Value);
        variables.AdminUpdatePatnerBranchFormFk_City = Convert.ToInt32(Slctcity.Value);
        variables.AdminUpdatePatnerBranchFormFk_Modifiedby = Convert.ToInt32(Session["username"]);
        variables.AdminUpdatePatnerBranchFormFk_Status = 1;

        insert.AdminUpdatePatnerBranchForm(variables);

        txtaddress.Value = "";
        txtpostalcode.Value = "";

        slcteditpatner.DataSource = Dropdown.GetAdminEditPatnerFormPatner();
        slcteditpatner.DataTextField = "Text";
        slcteditpatner.DataValueField = "Value";
        slcteditpatner.DataBind();

        //slctpatnerbranch.DataSource = Dropdown.GetAdminPatnerBranchFormPatner();
        //slctpatnerbranch.DataTextField = "Text";
        //slctpatnerbranch.DataValueField = "Value";
        //slctpatnerbranch.DataBind();


        Slctcity.DataSource = Dropdown.GetAdminPatnerBranchFormCity();
        Slctcity.DataTextField = "Text";
        Slctcity.DataValueField = "Value";
        Slctcity.DataBind();
    }

    protected void slcteditpatner_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void slcteditpatner_SelectedIndexChanged1(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditPatnerBranchForm = Convert.ToInt16(slcteditpatner.SelectedValue);
            table = ed.AdminEditPatnerBranchFetch(variables);

            slctpatnerbranch.Value = table.Rows[0][6].ToString().Trim();
            Slctcity.Value = table.Rows[0][5].ToString().Trim();
            txtaddress.Value = table.Rows[0][1].ToString().Trim();
            txtpostalcode.Value = table.Rows[0][2].ToString().Trim();
        }
        catch (Exception ex)
        {

        }
    }
}