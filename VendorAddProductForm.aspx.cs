using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorAddProductForm : System.Web.UI.Page
{
    Insertion insert = new Insertion();
    Properties P = new Properties();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    //slctproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
                    //slctproducttype.DataTextField = "Text";
                    //slctproducttype.DataValueField = "Value";
                    //slctproducttype.DataBind();

                    

                }


            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.VendorInsertProductFormProductName = txtproductname.Value;
        P.VendorInsertProductFormDetail = txtdetail.Value;
        P.VendorInsertProductFormModelNo = txtmodelno.Value;
        P.VendorInsertProductFormPrice = Convert.ToDecimal(txtprice.Value);
        P.VendorInsertProductFormLaunchDate = Convert.ToDateTime(txtlaunchdate.Value);
        P.VendorInsertProductFormFK_Createdby = Convert.ToInt16(Session["username"]);
        P.VendorInsertProductFormFK_ProductType = Convert.ToInt64(slctproducttype.Value);
        P.VendorInsertProductFormFK_Vendor = Convert.ToInt16(Session["username"]);


        // First Picture Saving Start
        HttpPostedFile postedFile = pic1.PostedFile;
        string fileExtension = postedFile.ContentType;
        // First Picture Saving End

        // Second Picture Saving Start
        HttpPostedFile pict2 = pic2.PostedFile;
        string pict2extension = pict2.ContentType;
        // Second Picture Saving End


        // Third Picture Saving Start
        HttpPostedFile pict3 = pic3.PostedFile;
        string pict3Extension = pict3.ContentType;
        // Third Picture Saving End


        // To check pictures is in jpeg and png formet
        if (fileExtension == "image/jpeg" || fileExtension == "image/png" && pict2extension == "image/jpeg" || pict2extension == "image/png" && pict3Extension == "image/jpeg" || pict3Extension == "image/png")
        {

            string filename = "Glocali_Product_By_Vendor"  + Convert.ToInt64(slctproducttype.Value) + "_1.jpg";
            postedFile.SaveAs(Server.MapPath("~/Images/Product/" + filename));

            string pict2filename = "Glocali_Product_By_Vendor"  + Convert.ToInt64(slctproducttype.Value) + "_2.jpg";
            pict2.SaveAs(Server.MapPath("~/Images/Product/" + pict2filename));

            string pict3filname = "Glocali_Product_By_Vendor"  + Convert.ToInt64(slctproducttype.Value) + "_3.jpg";
            pict3.SaveAs(Server.MapPath("~/Images/Product/" + pict3filname));


            P.VendorInsertProductFormPic1name = filename;
            P.VendorInsertProductFormPic2name = pict2filename;
            P.VendorInsertProductFormPic3name = pict3filname;

            P.VendorInsertProductFormPic1path = "/Images/Product/";
            P.VendorInsertProductFormPic2path = "/Images/Product/";
            P.VendorInsertProductFormPic3path = "/Images/Product/";


            //P.AdminInsertProductFormFK_Patner = Convert.ToInt16(Session["username"]);
            //Convert.ToInt16(Session["username"])


            P.VendorInsertProductFormFK_Patner = 1;
            insert.VendorInsertProductForm(P);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);

        }

        else
        {

        }


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