using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddRiderForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertRider_RiderName = txtname.Value;
        p.SprintInsertRider_CNIC = txtemail.Value;
        p.SprintInsertRider_Address = txtAddress.Value;
        p.SprintInsertRider_Phone = txtcell.Value;
        p.SprintInsertRider_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.SprintInsertRider(p);
    }
}