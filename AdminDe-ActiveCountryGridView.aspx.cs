using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDe_ActiveCountryGridView : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        gvtblImages.DataSource = fet.AdminFetchDeActiveCountry();
        gvtblImages.DataBind();
    }

    protected void LnkSelect_Click(object sender, EventArgs e)
    {
        int CountID = Convert.ToInt32((sender as LinkButton).CommandArgument);
        P.AdminDeActiveCountryGridViewCountID = Convert.ToInt64(CountID);
        insert.AdminDeActivedCountryGridView(P);


        gvtblImages.DataSource = fet.AdminFetchDeActiveCountry();
        gvtblImages.DataBind();
    }
}