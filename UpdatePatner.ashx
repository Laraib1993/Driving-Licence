<%@ WebHandler Language="C#" Class="UpdatePatner" %>

using System;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

public class UpdatePatner : IHttpHandler {

    public void ProcessRequest (HttpContext context) {

        Properties P = new Properties();
        P.AdminUpdatePatnerPID = Convert.ToInt32(context.Request.Params["slctpatner"].ToString().Replace(@"""", ""));
        P.AdminUpdatePatnerName = context.Request.Params["Companyname"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerCity = Convert.ToInt32(context.Request.Params["city"].ToString().Replace(@"""", ""));
        P.AdminUpdatePatnerEmail = context.Request.Params["email"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerPhone = context.Request.Params["phone"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerAddress = context.Request.Params["address"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerPostalCode = context.Request.Params["postalcode"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerContactPersonName = context.Request.Params["contactpersonname"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerContactPersonEmail = context.Request.Params["contactpersonalemail"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerContactPersonPhone = context.Request.Params["contactpersonphone"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerWebsite = context.Request.Params["website"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerCompanySize = context.Request.Params["companysize"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerAnnualRevenue = context.Request.Params["companyrevenue"].ToString().Replace(@"""", "");
        P.AdminUpdatePatnerPatnerType = Convert.ToInt32(context.Request.Params["patner"].ToString().Replace(@"""", ""));


        if (context.Request.Files.Count > 0)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            HttpFileCollection files = context.Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                string fname;
                if (HttpContext.Current.Request.Browser.Browser.ToUpper() == "IE" || HttpContext.Current.Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                {
                    string[] testfiles = file.FileName.Split(new char[] { '\\' });
                    fname = testfiles[testfiles.Length - 1];
                }
                else
                {
                    fname = "Logo_" + P.PatnerFormsName + P.PatnerFormsPhone + GeneratePassword() +".png";

                }
                string path = context.Server.MapPath("~/Images/Patner/");

                System.Drawing.Image img = System.Drawing.Image.FromStream(file.InputStream);
                img = resizeImage(img);
                img.Save(string.Concat(path,fname));


                //final = Path.Combine(context.Server.MapPath("~/Images/Patner/"), fname);
                //file.SaveAs(final);

                using (SqlCommand cmd = new SqlCommand())
                {

                    P.AdminUpdatePatnerLogoName =  fname;
                    P.AdminUpdatePatnerLogoPath = "/Images/Patner/";
                    P.AdminUpdatePatnerCreatedby = 8;
                    P.AdminUpdatePatnerStatus = 1;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_AdminUpdatePartner";
                    cmd.Connection = Getconnected.getconnecting();
                    cmd.Parameters.AddWithValue("@PID", P.AdminUpdatePatnerPID);
                    cmd.Parameters.AddWithValue("@Name", P.AdminUpdatePatnerName);
                    cmd.Parameters.AddWithValue("@Address", P.AdminUpdatePatnerAddress);
                    cmd.Parameters.AddWithValue("@Email", P.AdminUpdatePatnerEmail);
                    cmd.Parameters.AddWithValue("@Phone", P.AdminUpdatePatnerPhone);
                    cmd.Parameters.AddWithValue("@Website", P.AdminUpdatePatnerWebsite);
                    cmd.Parameters.AddWithValue("@ContactPersonName", P.AdminUpdatePatnerContactPersonName);
                    cmd.Parameters.AddWithValue("@ContactPersonPhone", P.AdminUpdatePatnerContactPersonPhone);
                    cmd.Parameters.AddWithValue("@ContactPersonEmail", P.AdminUpdatePatnerContactPersonEmail);
                    cmd.Parameters.AddWithValue("@Logoname", P.AdminUpdatePatnerLogoName);
                    cmd.Parameters.AddWithValue("@Logopath", P.AdminUpdatePatnerLogoPath);
                    cmd.Parameters.AddWithValue("@PostalCode", P.AdminUpdatePatnerPostalCode);
                    cmd.Parameters.AddWithValue("@AunaualRevenue", P.AdminUpdatePatnerAnnualRevenue);
                    cmd.Parameters.AddWithValue("@CompanySize", P.AdminUpdatePatnerCompanySize);
                    cmd.Parameters.AddWithValue("@FK_Createdby", P.AdminUpdatePatnerCreatedby);
                    cmd.Parameters.AddWithValue("@FK_City", P.AdminUpdatePatnerCity);
                    cmd.Parameters.AddWithValue("@FK_PatnerType", P.AdminUpdatePatnerPatnerType);
                    cmd.Parameters.AddWithValue("@FK_Status", P.AdminUpdatePatnerStatus);
                    cmd.ExecuteNonQuery();
                }


            }

        }



    }

    public bool IsReusable {
        get {
            return false;
        }
    }


    [Serializable]
    public class Titles
    {
        public List<Properties> TheTitles { get; set; }

    }


    public string GeneratePassword()
    {
        string PasswordLength = "8";
        string NewPassword = "";

        string allowedChars = "";
        allowedChars = "1,2,3,4,5,6,7,8,9,0";
        allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
        allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

        char[] sep = {
            ','
        };
        string[] arr = allowedChars.Split(sep);


        string IDString = "";
        string temp = "";

        Random rand = new Random();

        for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
        {
            temp = arr[rand.Next(0, arr.Length)];
            IDString += temp;
            NewPassword = IDString;

        }
        return NewPassword;
    }



    private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
    {
        Properties P = new Properties();
        //Get the image current width
        int sourceWidth = imgToResize.Width;
        //Get the image current height
        int sourceHeight = imgToResize.Height;

        float nPercent = 0;
        float nPercentW = 0;
        float nPercentH = 0;
        //New Width
       int destWidth;
        //New Height
        int destHeight;

        if ((Convert.ToInt32(HttpContext.Current.Request.Params["patner"].ToString().Replace(@"""", ""))) == 5)
        {
            //New Width
            destWidth = 292;
            //New Height
            destHeight = 92;
        }

        else if((Convert.ToInt32(HttpContext.Current.Request.Params["patner"].ToString().Replace(@"""", ""))) == 6)
        {
            //New Width
            destWidth = 53;
            //New Height
            destHeight = 53;

        }
        else if((Convert.ToInt32(HttpContext.Current.Request.Params["patner"].ToString().Replace(@"""", ""))) == 7)
        {
            //New Width
            destWidth = 53;
            //New Height
            destHeight = 53;


        }


        Bitmap b = new Bitmap(destWidth, destHeight);
        Graphics g = Graphics.FromImage((System.Drawing.Image)b);
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        // Draw image with new width and height
        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
        g.Dispose();

        return (System.Drawing.Image)b;
    }


    private System.Drawing.Image resizeImage(System.Drawing.Image img)
    {
        Bitmap b = new Bitmap(img);
        System.Drawing.Image i = resizeImage(b, new Size(500,500));
        return i;
    }

}