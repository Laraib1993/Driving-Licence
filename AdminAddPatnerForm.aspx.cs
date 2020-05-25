using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Script.Services;
using System.IO;
using System.Web.UI.WebControls;

public partial class AdminResellerForm : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    Properties P = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {
            txtcity.DataSource = Dropdown.GetAdminEditPatnerFormCity();
            txtcity.DataTextField = "Text";
            txtcity.DataValueField = "Value";
            txtcity.DataBind();
        }
        else { Response.Redirect("SignIn.aspx"); }
    }
     
   
    

 
    

    protected void Button1_Click(object sender, EventArgs e)
    {
    }
}