using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddSearchingCase : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {
            if (!IsPostBack)
            {

            }
        }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminInsertSearchingCaseInword_Inwordno = txtinwordno.Value;
        variables.AdminInsertSearchingCaseInword_Discription = txtDiscription.Value;
        variables.AdminInsertSearchingCaseInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertSearchingCaseInword_NoofIDs = Convert.ToInt32(txtNoofID.Value);
        variables.AdminInsertSearchingCaseInword_NoofPages = Convert.ToInt32(txtpages.Value);
        variables.AdminInsertSearchingCaseInword_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.AdminInsertSearchingCaseInword(variables);
        //insertion start for main//

        variables.AdminInsertMainForSearchingCase_InwordNo = txtinwordno.Value;
        variables.AdminInsertMainForSearchingCase_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertMainForSearchingCase_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.AdminInsertMainForSearchingCaseInword(variables);
    }
}