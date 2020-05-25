using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminSignupThird : System.Web.UI.Page
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
        variables.AdminUpdateUI_PatnerRegistrationThirdPRID = 3;
        variables.AdminUpdateUI_PatnerRegistrationThirdHeading = txtheading.Value;
        variables.AdminUpdateUI_PatnerRegistrationThirdTextArea = txttext.Value;
        variables.AdminUpdateUI_PatnerRegistrationThirdButtonText = txtbtntext.Value;
        variables.AdminUpdateUI_PatnerRegistrationThirdFk_Modifiedby = Convert.ToInt32(Session["username"]);

        //variables.AdminUpdateUI_PatnerRegistrationFirstModifiedon = Convert.ToDateTime(Session["username"]);

        HttpPostedFile postedFile = flppic.PostedFile;
        string filename = "Glocali_AdminEditUI_PatnerRegistration_3" + ".jpg";
        string fileExtension = postedFile.ContentType;


        if (fileExtension == "image/jpeg" || fileExtension == "image/png")
        {

            variables.AdminUpdateUI_PatnerRegistrationThirdPicName = filename;
            variables.AdminUpdateUI_PatnerRegistrationThirdPicPath = "/Images/Admin/";
            postedFile.SaveAs(Server.MapPath("~/Images/Admin/" + filename));

            insert.AdminUpdateUI_PatnerRegistrationThird(variables);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);
        }
        else
        {

        }
    }
}