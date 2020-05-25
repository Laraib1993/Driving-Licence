using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResellerDeletingProductGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)

    {
        P.ResellerDeletingProductGridViewFK_Createdby = Convert.ToInt32(Session["username"]);
        gvtblImages.DataSource = fet.ResellerFetchDeletingProduct(P);
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int PID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.ResellerDeletingProductGridViewPID = Convert.ToInt64(PID);
        P.ResellerDeletingProductGridViewFK_Createdby = Convert.ToInt32(Session["username"]);
        insert.ResellerDeleteProductGridView(P);


        gvtblImages.DataSource = fet.ResellerFetchDeletingProduct(P);
        gvtblImages.DataBind();
    }
}