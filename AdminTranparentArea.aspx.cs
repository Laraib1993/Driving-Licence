using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminTranparentArea : System.Web.UI.Page
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
        variables.AdminUpdateUI_TransparentAreaTAID = 2;
        variables.AdminUpdateUI_TransparentAreaHeading = txtheading.Value;
        variables.AdminUpdateUI_TransparentAreaTextArea = txttext.Value;
        variables.AdminUpdateUI_TransparentAreaButtonText = txtbtntext.Value;
        variables.AdminUpdateUI_TransparentAreaFk_Modifiedby = Convert.ToInt32(Session["username"]);

        //variables.AdminUpdateUI_PatnerRegistrationFirstModifiedon = Convert.ToDateTime(Session["username"]);

        HttpPostedFile postedFile = flppic.PostedFile;
        string filename = "Glocali_AdminEditUI_TransparentArea" + ".jpg";
        string fileExtension = postedFile.ContentType;


        if (fileExtension == "image/jpeg" || fileExtension == "image/png")
        {

            variables.AdminUpdateUI_TransparentAreaPicName = filename;
            variables.AdminUpdateUI_TransparentAreaPicPath = "/Images/Admin/";
            postedFile.SaveAs(Server.MapPath("~/Images/Admin/" + filename));

            insert.AdminUpdateUI_TransparentArea(variables);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);
        }
        else
        {

        }
    }
}