using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddDistrictForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertDistrict_DistrictName = txtDistrict.Value;
        p.SprintInsertDistrict_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.SprintInsertDistrict(p);
    }
}