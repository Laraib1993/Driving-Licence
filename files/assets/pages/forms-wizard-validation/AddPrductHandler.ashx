<%@ WebHandler Language="C#" Class="AddPrductHandler" %>

using System;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Collections;

public class AddPrductHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
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
                    fname = "Logo" + P.PatnerFormsName+".png" ;

                }

                fname = Path.Combine(context.Server.MapPath("~/Images/Patner/"), fname);
                file.SaveAs(fname);

                using (SqlCommand cmd = new SqlCommand())
                {

                    P.PatnerFormsLogoName =  "Logo_" + P.PatnerFormsName + P.PatnerFormsPhone;
                    P.PatnerFormsLogoPath = "~/Images/Patner/";
                    P.PatnerFormsCreatedby = 8;
                    P.PatnerFormsStatus = 1;
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
                    cmd.Parameters.AddWithValue("@FK_Status", 1);
                    cmd.Parameters.AddWithValue("@Website", P.PatnerFormsWebsite);
                    cmd.ExecuteNonQuery();
                }


            }

        }
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}