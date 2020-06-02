using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddUsersForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertUserInfo_email = txtEmail.Value;
        p.SprintInsertUserInfo_Password = txtPassword.Value;
        p.SprintInsertUserInfo_Role = "abc";

        insert.SprintInsertUserInfo(p);
    }
}