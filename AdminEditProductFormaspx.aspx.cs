using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditProductFormaspx : System.Web.UI.Page
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

                    Slctproduct.DataSource = Dropdown.GetAdminProductFormPatner();
                    Slctproduct.DataTextField = "Text";
                    Slctproduct.DataValueField = "Value";
                    Slctproduct.DataBind();

                    //slctvendor.DataSource = Dropdown.GetResellerAddProductFormVendor();
                    //slctvendor.DataTextField = "Text";
                    //slctvendor.DataValueField = "Value";
                    //slctvendor.DataBind();

                    //slctproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
                    //slctproducttype.DataTextField = "Text";
                    //slctproducttype.DataValueField = "Value";
                    //slctproducttype.DataBind();
                }

            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateProductFormPID = Convert.ToInt16(Slctproduct.SelectedValue);
        variables.AdminUpdateProductFormProductName = txtproductname.Value;
        variables.AdminUpdateProductFormDetail= txtdetail.Value;
        variables.AdminUpdateProductFormModelNo = txtmodelno.Value;
        variables.AdminUpdateProductFormPrice = Convert.ToDecimal(txtprice.Value);
        variables.AdminUpdateProductFormLaunchDate = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateProductFormFk_Createdby = Convert.ToInt16(Session["username"]);
        variables.AdminUpdateProductFormFk_ProductType = Convert.ToInt16(slctproducttype.Value);

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

            string filename = "Glocali_Product_By_Admin" + Convert.ToInt64(Slctproduct.SelectedValue) + Convert.ToInt64(slctproducttype.Value) + "_1.jpg";
            postedFile.SaveAs(Server.MapPath("~/Images/Product/" + filename));

            string pict2filename = "Glocali_Product_By_Admin" + Convert.ToInt64(Slctproduct.SelectedValue) + Convert.ToInt64(slctproducttype.Value) + "_2.jpg";
            pict2.SaveAs(Server.MapPath("~/Images/Product/" + pict2filename));

            string pict3filname = "Glocali_Product_By_Admin" + Convert.ToInt64(Slctproduct.SelectedValue) + Convert.ToInt64(slctproducttype.Value) + "_3.jpg";
            pict3.SaveAs(Server.MapPath("~/Images/Product/" + pict3filname));

            variables.AdminUpdateProductFormPic1name = filename;
            variables.AdminUpdateProductFormPic2name = pict2filename;
            variables.AdminUpdateProductFormPic3name = pict3filname;

            variables.AdminUpdateProductFormPic1path = "/Images/Product/";
            variables.AdminUpdateProductFormPic2path = "/Images/Product/";
            variables.AdminUpdateProductFormPic3path = "/Images/Product/";

            variables.AdminUpdateProductFormFk_Patner = Convert.ToInt16(Slctproduct.SelectedValue);
            //Convert.ToInt16(Session["username"])


            variables.AdminUpdateProductFormFk_Status = 1;
            insert.AdminUpdateProductForm(variables);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);

        }

        else
        {

        }

        txtproductname.Value = "";

        

        Slctproduct.DataSource = Dropdown.GetAdminProductFormPatner();
        Slctproduct.DataTextField = "Text";
        Slctproduct.DataValueField = "Value";
        Slctproduct.DataBind();

        //slctvendor.DataSource = Dropdown.GetResellerAddProductFormVendor();
        //slctvendor.DataTextField = "Text";
        //slctvendor.DataValueField = "Value";
        //slctvendor.DataBind();

        //slctproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
        //slctproducttype.DataTextField = "Text";
        //slctproducttype.DataValueField = "Value";
        //slctproducttype.DataBind();
    }

    protected void slcteditproducttype_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            
        }
        catch(Exception ex) { }
       
    }

    protected void Slctproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdmnEditProductFetch = Convert.ToInt16(Slctproduct.SelectedValue);
            table = ed.AdminEditProductForm(variables);

            txtproductname.Value = table.Rows[0][1].ToString().Trim();
            txtdetail.Value = table.Rows[0][2].ToString().Trim();
            txtmodelno.Value = table.Rows[0][3].ToString().Trim();
            txtprice.Value = table.Rows[0][4].ToString().Trim();
            txtlaunchdate.Value = table.Rows[0][5].ToString().Trim();
            slctvendor.Value = table.Rows[0][6].ToString().Trim();
            slctproducttype.Value = table.Rows[0][8].ToString().Trim();
            
        }
        catch (Exception ex)
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