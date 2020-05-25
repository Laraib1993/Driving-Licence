using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDe_ActiveCityGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeActiveCity();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int CID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeActiveCityGridViewCID = Convert.ToInt64(CID);
        insert.AdminDeActivedCityGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeActiveCity();
        gvtblImages.DataBind();
    }
}