using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DataEntryUpdateShipmentEntryForm : System.Web.UI.Page
{
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Fetch f = new Fetch();
    Properties p = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {

        //try
        //{
        //    if (Session["username"] != null && Session["password"] != null)
        //    {
                //if (!IsPostBack)
                //{
                //    //slctproductcategory.DataSource = Dropdown.GetAdminProductTypeProductCategory();
                //    //slctproductcategory.DataTextField = "Text";
                //    //slctproductcategory.DataValueField = "Value";
                //    //slctproductcategory.DataBind();
                //}

        //    }
        //    else { Response.Redirect("SignIn.aspx"); }
        //}

        //catch (Exception ex)
        //{

        //}
    }

    protected void ddllicence_SelectedIndexChanged(object sender, EventArgs e)
    {
        p.AdminFetchID = 2;
        table = f.AdminFetchshipmentdetail(p);
        txtlicence.Value = table.Rows[0][1].ToString().Trim();
        txtarea.Value = table.Rows[0][3].ToString().Trim();
        txtcnic.Value = table.Rows[0][2].ToString().Trim();
        txtreceivedate.Value = table.Rows[0][1].ToString().Trim();
        slctdistrict.SelectedValue = table.Rows[0][1].ToString().Trim();
        ddlreceiveby.SelectedValue = table.Rows[0][1].ToString().Trim();

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

    }
}