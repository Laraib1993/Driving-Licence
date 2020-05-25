using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AdminEditPatnerForm : System.Web.UI.Page
{
    protected static SqlCommand cmd;
    protected static SqlDataReader sdr;
    protected static SqlDataAdapter sda;
    edit fetch = new edit();
    Properties variables = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    ddlpatnertobeedit.DataSource = Dropdown.GetAdminEditPatnerFormPatner();
                    ddlpatnertobeedit.DataTextField = "Text";
                    ddlpatnertobeedit.DataValueField = "Value";
                    ddlpatnertobeedit.DataBind();

                    slctcity.DataSource = Dropdown.GetAdminEditPatnerFormCity();
                    slctcity.DataTextField = "Text";
                    slctcity.DataValueField = "Value";
                    slctcity.DataBind();

                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }

    protected void ddlpatnertobeedit_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditPatnerFetch = Convert.ToInt32(ddlpatnertobeedit.SelectedValue);
            DataTable table = new DataTable();
            table = fetch.AdminEditPatnerFetch(variables);

            if (table.Rows.Count > 0)
            {
                txtname.Value = table.Rows[0][1].ToString().Trim();
                txtaddress.Value = table.Rows[0][2].ToString().Trim();
                txtemail.Value = table.Rows[0][3].ToString().Trim();
                txtphone.Value = table.Rows[0][4].ToString().Trim();
                txtwebsite.Value = table.Rows[0][5].ToString().Trim();
                txtcontactpersonname.Value = table.Rows[0][6].ToString().Trim();
                txtcontactpersonemail.Value = table.Rows[0][7].ToString().Trim();
                txtcontactpersonphone.Value = table.Rows[0][8].ToString().Trim();
                txtpostalcode.Value = table.Rows[0][11].ToString().Trim();
                slctcompsize.Value = table.Rows[0][12].ToString().Trim();
                slctrevenue.Value = table.Rows[0][13].ToString().Trim();
                slctcity.SelectedValue = table.Rows[0][14].ToString().Trim();

            }
        }
        catch(Exception ex) { }
       
    }

    protected void slctcity_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DataTable table = new DataTable();
        //table = f.AdminFetchcountryregion();

        //if (table.Rows.Count > 0)
        //{
        //    txtcountry.Value = table.Rows[0][2].ToString().Trim();
            
        //}
    }
}