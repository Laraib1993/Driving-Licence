using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeletingProductCategoryGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeletingProductCategory();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int PCID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeletingProductCategoryGridViewPCID = Convert.ToInt64(PCID);
        insert.AdminDeletedProductCategoryGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeletingProductCategory();
        gvtblImages.DataBind();
    }
}