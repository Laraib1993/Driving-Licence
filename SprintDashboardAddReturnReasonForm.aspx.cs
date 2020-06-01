using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddReturnReasonForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertReturnReason_Reason = txtreason.Value;
        p.SprintInsertReturnReason_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.SprintInsertReturnReason(p);
    }
}