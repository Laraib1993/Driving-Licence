using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DataEntryShipmentDetail : System.Web.UI.Page
{
    Fetch f = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.AdminInsertshipmentid = txtlicence.Value;
        P.AdminInsertshipmentcnic = txtcnic.Value;
        P.AdminInsertshipmentdistrict = Convert.ToInt32(slctdistrict.SelectedValue);
        P.AdminInsertshipmentcreatedby = Convert.ToInt32(Session["username"]);
        P.AdminInsertshipmentstatus = 1;
        P.AdminInsertshipmentaddress = Convert.ToString(txtarea.Value);
        P.AdminFetchID = Convert.ToInt32(txtlicence.Value);
        dt = f.AdminFetchshipmentdetail(P);

        if (dt.Rows[0][0] != null)
        {
            insert.AdminInsertshipmentdetail(P);
        }

        else {  }

    }
}