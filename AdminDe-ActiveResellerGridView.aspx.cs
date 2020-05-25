using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDe_ActiveResellerGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeActiveReseller();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int PID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeActiveResellerGridViewPID = Convert.ToInt64(PID);
        insert.AdminDeActiveResellerGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeActiveReseller();
        gvtblImages.DataBind();
    }
}