<%@ WebHandler Language="C#" Class="RegisterHandler" %>

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

public class RegisterHandler : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        Properties P = new Properties();
        P.PatnerFormsName = context.Request.Params["Companyname"].ToString().Replace(@"""", "");
        P.PatnerFormsCity = Convert.ToInt32(context.Request.Params["city"].ToString().Replace(@"""", ""));
        P.PatnerFormsEmail = context.Request.Params["email"].ToString().Replace(@"""", "");
        P.PatnerFormsPhone = context.Request.Params["phone"].ToString().Replace(@"""", "");
        P.PatnerFormsAddress = context.Request.Params["address"].ToString().Replace(@"""", "");
        P.PatnerFormsPostalcode = context.Request.Params["postalcode"].ToString().Replace(@"""", "");
        P.PatnerFormsContactPersonname = context.Request.Params["contactpersonname"].ToString().Replace(@"""", "");
        P.PatnerFormsContactPersonEmail = context.Request.Params["contactpersonalemail"].ToString().Replace(@"""", "");
        P.PatnerFormsContactPersonPhone = context.Request.Params["contactpersonphone"].ToString().Replace(@"""", "");
    
        P.PatnerFormsWebsite = context.Request.Params["website"].ToString().Replace(@"""", "");
        P.PatnerFormsCompanysize = context.Request.Params["companysize"].ToString().Replace(@"""", "");
        P.PatnerFormsAunnualRevenue = context.Request.Params["companyrevenue"].ToString().Replace(@"""", "");
        P.PatnerFormsPatnerType = Convert.ToInt32(context.Request.Params["patner"].ToString().Replace(@"""", ""));


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
                    fname = "Logo" + P.PatnerFormsName + P.PatnerFormsPhone + GeneratePassword() +".png" ;

                }

                 string path = context.Server.MapPath("~/Images/Patner/");

                System.Drawing.Image img = System.Drawing.Image.FromStream(file.InputStream);
                img = resizeImage(img);
                img.Save(string.Concat(path,fname));

                using (SqlCommand cmd = new SqlCommand())
                {

                    P.PatnerFormsLogoName =  fname;
                    P.PatnerFormsLogoPath = "/Images/Patner/";
                    P.PatnerFormsCreatedby = 8;
                    P.PatnerFormsStatus = 2;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_AdminInsertPatnerForm";
                    cmd.Connection = Getconnected.getconnecting();
                    cmd.Parameters.AddWithValue("@Name", P.PatnerFormsName);
                    cmd.Parameters.AddWithValue("@Address", P.PatnerFormsAddress);
                    cmd.Parameters.AddWithValue("@Email", P.PatnerFormsEmail);
                    cmd.Parameters.AddWithValue("@Phone", P.PatnerFormsPhone);
                    cmd.Parameters.AddWithValue("@ContactPersonName", P.PatnerFormsContactPersonname);
                    cmd.Parameters.AddWithValue("@ContactPersonEmail", P.PatnerFormsContactPersonEmail);
                    cmd.Parameters.AddWithValue("@ContactPersonPhone", P.PatnerFormsContactPersonPhone);
                    cmd.Parameters.AddWithValue("@Logoname", P.PatnerFormsLogoName);
                    cmd.Parameters.AddWithValue("@Logopath", P.PatnerFormsLogoPath);
                    cmd.Parameters.AddWithValue("@PostalCode", P.PatnerFormsPostalcode);
                    cmd.Parameters.AddWithValue("@AunaualRevenue", P.PatnerFormsAunnualRevenue);
                    cmd.Parameters.AddWithValue("@CompanySize", P.PatnerFormsCompanysize);
                    cmd.Parameters.AddWithValue("@FK_Createdby", P.PatnerFormsCreatedby);
                    cmd.Parameters.AddWithValue("@FK_City", P.PatnerFormsCity);
                    cmd.Parameters.AddWithValue("@FK_PatnerType", P.PatnerFormsPatnerType);
                    cmd.Parameters.AddWithValue("@FK_Status", 2);
                    cmd.Parameters.AddWithValue("@Website", P.PatnerFormsWebsite);
                    cmd.ExecuteNonQuery();
                }


            }

        }
        
           context.Response.Write("Record Has Been Inserted");

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
        int destWidth = 290;
        //New Height
        int destHeight = 92;

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