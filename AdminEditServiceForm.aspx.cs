using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class AdminEditServiceForm : System.Web.UI.Page
{
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    edit ed = new edit();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    //slcteditservice.DataSource = Dropdown.GetAdminProductCateoryService();
                    //slcteditservice.DataTextField = "Text";
                    //slcteditservice.DataValueField = "Value";
                    //slcteditservice.DataBind();

                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            variables.AdminUpdateServicePSID = Convert.ToInt16(slcteditservice.SelectedValue);
            variables.AdminUpdateServiceService = txtservice.Value;
            variables.AdminUpdateServiceDetail = txtdetail.Value;
            variables.AdminUpdateServiceFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateServiceFK_Status = 1;

            HttpPostedFile postedFile = pic1.PostedFile;
            string filename = "Glocali_ProductEditService" + GeneratePassword() + ".jpg";
            string fileExtension = postedFile.ContentType;


            if (fileExtension == "image/jpeg" || fileExtension == "image/png")
            {

                variables.AdminUpdateServicePic_Name = filename;
                variables.AdminUpdateServicePic_Path = "/Images/Product/Services/";
                postedFile.SaveAs(Server.MapPath("~/Images/Product/Services/" + filename));

                insert.AdminUpdateService(variables);

                Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            }

            else
            {
                Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            }

            txtdetail.Value = "";
            txtservice.Value = "";

            //slcteditservice.DataSource = Dropdown.GetAdminProductCateoryService();
            //slcteditservice.DataTextField = "Text";
            //slcteditservice.DataValueField = "Value";
            //slcteditservice.DataBind();
        }
        catch(Exception ex) { }
        

    }

    protected void slcteditservice_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditServiceFetch = Convert.ToInt16(slcteditservice.SelectedValue);
            table = ed.AdminEditServiceFetch(variables);

            txtdetail.Value = table.Rows[0][2].ToString().Trim();
            txtservice.Value = table.Rows[0][1].ToString().Trim();
        }
        catch(Exception ex) { }
        
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
}