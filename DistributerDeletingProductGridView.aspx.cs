using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DistributerDeletingProductGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        P.DistributerDeletingProductGridViewFK_Createdby = Convert.ToInt32(Session["username"]);
        gvtblImages.DataSource = fet.DistributerFetchDeletingProduct(P);
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int PID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.DistributerDeletingProductGridViewPID = Convert.ToInt64(PID);
        P.DistributerDeletingProductGridViewFK_Createdby = Convert.ToInt32(Session["username"]);
        insert.DistributerDeleteProductGridView(P);


        gvtblImages.DataSource = fet.DistributerFetchDeletingProduct(P);
        gvtblImages.DataBind();
    }
}