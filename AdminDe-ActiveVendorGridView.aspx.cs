using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDe_ActiveVendorGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeActiveVendor();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int PID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeActiveVendorGridViewPID = Convert.ToInt64(PID);
        insert.AdminDeActiveVendorGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeActiveVendor();
        gvtblImages.DataBind();
    }
}