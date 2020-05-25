using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SignIn : System.Web.UI.Page
{
    login login = new login();
    Properties P = new Properties();
    string email2;
    string password2;
    int role;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {
            Session.Clear();
            Session.Abandon();
        }
        
        else {  }
        
        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        DataTable table = new DataTable(); 
        P.LoginUsername = txtemail.Value;
        P.LoginPassword = password.Value;
        table = login.loginform(P);

        if (table.Rows.Count > 0)
        {
            email2 = table.Rows[0][1].ToString().Trim();
            password2 = table.Rows[0][2].ToString().Trim();
            role = Convert.ToInt32(table.Rows[0][5]);
            Session["username"] = table.Rows[0][0].ToString().Trim();
            Session["password"] = table.Rows[0][2].ToString().Trim();
            Session["role"] = table.Rows[0][3].ToString().Trim();
            Session["status"] = table.Rows[0][4].ToString().Trim();

            if (email2 == txtemail.Value && password2 == password.Value && role == 1)
            {
                Response.Redirect("Dashboard.aspx");
            }

            else if (email2 == txtemail.Value && password2 == password.Value && role == 2)
            {
                //div.Visible = true;
                //btnvisible.Visible = true;
                //error.Visible = true;
                //error.InnerText = "You are not allowed to login";
                Response.Redirect("AdminReasonInfo.aspx");
            }

            else if (email2 != txtemail.Value && password2 != password.Value)
            {
                Response.Redirect("/files/extra-pages/404/1/index-bubble.html");
            }
        }

        else
        {
            //div.Visible = true;
            //btnvisible.Visible = true;
            //error.Visible = true;
            //error.InnerText = "You are not allowed to login";
            Response.Redirect("/files/extra-pages/404/1/index-bubble.html");
        }


    }
}