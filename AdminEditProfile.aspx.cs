using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Script.Services;
using System.IO;
using System.Web.UI.WebControls;
public partial class AdminEditProfile : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    Properties P = new Properties();
    Insertion insert = new Insertion();
    DataTable dt = new DataTable();
    Fetch F = new Fetch();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                P.AdminUpdateFetchProfileID = 2;
                dt = F.AdminFetchAdmin(P);
                imgadminlogo.Src = dt.Rows[0][8].ToString().Trim();
                hflname.InnerText = dt.Rows[0][1].ToString().Trim();
                tbgender.InnerText = dt.Rows[0][2].ToString().Trim();
                tbfulname.InnerText = dt.Rows[0][1].ToString().Trim();
                tbmartial.InnerText = dt.Rows[0][3].ToString().Trim();
                tbdate.InnerText = Convert.ToDateTime(dt.Rows[0][4]).ToLongDateString();
                tbphone.InnerText = dt.Rows[0][5].ToString().Trim();
                tbemail.InnerText = dt.Rows[0][6].ToString().Trim();
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string selectedagevalue = Request.Form["radio"];
            P.AdminUpdateProfileName = txtfullname.Value;
            P.AdminUpdateProfileGender = selectedagevalue;
            P.AdminUpdateProfileMartialStatus = slctmartial.Value;
            P.AdminUpdateProfileBirthday = Convert.ToDateTime(txtbday.Value);
            P.AdminUpdateProfilePhone = txtphonwe.Value;
            P.AdminUpdateProfileEmail = txtemail.Value;

            HttpPostedFile postedFile = flpupload.PostedFile;
            string pic = "Profile_Pic_Admin";
            string filename = "GLOCALI" + pic + ".png";
            //string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;
            postedFile.SaveAs(Server.MapPath("~/Images/Admin/" + filename));

            if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                P.AdminUpdateProfilePicName = filename;
                P.AdminUpdateProfilePicPath = "~/Images/Admin/" + filename;
                P.AdminUpdateProfileID = 2;

                insert.AdminUpdateProfile(P);
                Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            }

            else
            {
                Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            }
        }

        catch(Exception ex) { }
        

    }
}