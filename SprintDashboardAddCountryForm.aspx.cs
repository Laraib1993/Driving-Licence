using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddCountryForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertCountry_CountryName = txtcountry.Value;
        p.SprintInsertCountry_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.SprintInsertCountry(p);
    }
}