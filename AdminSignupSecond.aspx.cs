using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminSignupSecond : System.Web.UI.Page
{
    Insertion insert = new Insertion();
    Properties variables = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null) { }
        else { Response.Redirect("SignIn.aspx"); }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateUI_PatnerRegistrationSecondPRID = 2;
        variables.AdminUpdateUI_PatnerRegistrationSecondHeading = txtheading.Value;
        variables.AdminUpdateUI_PatnerRegistrationSecondTextArea = txttext.Value;
        variables.AdminUpdateUI_PatnerRegistrationSecondButtonText = txtbtntext.Value;
        variables.AdminUpdateUI_PatnerRegistrationSecondFk_Modifiedby = Convert.ToInt32(Session["username"]);

        //variables.AdminUpdateUI_PatnerRegistrationFirstModifiedon = Convert.ToDateTime(Session["username"]);

        HttpPostedFile postedFile = flppic.PostedFile;
        string filename = "Glocali_AdminEditUI_PatnerRegistration_2" + ".jpg";
        string fileExtension = postedFile.ContentType;


        if (fileExtension == "image/jpeg" || fileExtension == "image/png")
        {

            variables.AdminUpdateUI_PatnerRegistrationSecondPicName = filename;
            variables.AdminUpdateUI_PatnerRegistrationSecondPicPath = "/Images/Admin/";
            postedFile.SaveAs(Server.MapPath("~/Images/Admin/" + filename));

            insert.AdminUpdateUI_PatnerRegistrationSecond(variables);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);
        }
        else
        {

        }
    }
}