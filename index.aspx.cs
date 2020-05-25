using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    Properties variables = new Properties();
    CMS Cms = new CMS();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {

                variables.MyProperty = divdistributerinfo;
                Cms.DistributerCard(variables);


                variables.UI_VendorControl = vendor;
                Cms.VendorLogoMainPage(variables);

            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }
}