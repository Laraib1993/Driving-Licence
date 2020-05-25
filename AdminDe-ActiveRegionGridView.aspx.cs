using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDe_ActiveRegionGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeActiveRegion();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int RID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeActiveRegionGridViewRID = Convert.ToInt64(RID);
        insert.AdminDeActiveRegionGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeActiveRegion();
        gvtblImages.DataBind();
    }
}