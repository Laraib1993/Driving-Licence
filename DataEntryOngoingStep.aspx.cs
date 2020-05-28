using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DataEntryOngoingStep : System.Web.UI.Page
{
    Properties P = new Properties();
    Insertion insert = new Insertion();
    DataTable dt = new DataTable();
    Fetch F = new Fetch();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        //    if (Session["username"] != null && Session["password"] != null)
        //    {
        //    }
        //    else { Response.Redirect("SignIn.aspx"); }
        //}
        //catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.AdminInsertongoingassignedon = Convert.ToDateTime(txtassignedon.Value);
        P.AdminInsertongoingestimatedtime = Convert.ToDateTime(txtassignedon.Value).AddDays(1);
        P.AdminInsertongoingrider = Convert.ToInt32(ddlrider.SelectedValue);
        P.AdminInsertongoingcreatedby = Convert.ToInt32(Session["username"]);
        P.AdminInsertongoingshipment = Convert.ToInt32(ddlshipment.SelectedValue);
        P.AdminFetchID = Convert.ToInt32(ddlshipment.SelectedValue);
        dt = F.AdminFetchcheckongoingstep(P);
        if (dt.Rows[0][0] != null)
        {
            insert.AdminInsertongoingstep(P);
        }

        else { }

    }
}