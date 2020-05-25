using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUpDistributer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        slctcity.DataSource = Dropdown.GetAdminEditPatnerFormCity();
        slctcity.DataTextField = "Text";
        slctcity.DataValueField = "Value";
        slctcity.DataBind();
    }
}