using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeletingCityGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeletingCity();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int CID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeletingCityGridViewCID = Convert.ToInt64(CID);
        insert.AdminDeletedCityGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeletingCity();
        gvtblImages.DataBind();
    }
}