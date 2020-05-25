using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class AdminEditProductCategoryForm : System.Web.UI.Page
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
                    //slcteditrpoductcategory.DataSource = Dropdown.GetAdminProductTypeProductCategory();
                    //slcteditrpoductcategory.DataTextField = "Text";
                    //slcteditrpoductcategory.DataValueField = "Value";
                    //slcteditrpoductcategory.DataBind();


                    //slctservices.DataSource = Dropdown.GetAdminProductCateoryService();
                    //slctservices.DataTextField = "Text";
                    //slctservices.DataValueField = "Value";
                    //slctservices.DataBind();


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
            variables.AdminUpdateProductCategoryPCID = Convert.ToInt16(slcteditrpoductcategory.SelectedValue);
            variables.AdminUpdateCategoryFormCategory = txtproductcategory.Value;
            variables.AdminUpdateProductCategoryFK_Srevicetype = Convert.ToInt16(slctservices.Value);
            variables.AdminUpdateProductCategoryFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateProductCategoryFK_Status = 1;

            HttpPostedFile postedFile = pic1.PostedFile;
            string filename = "Glocali_ProductCategory" + GeneratePassword() + ".jpg";
            string fileExtension = postedFile.ContentType;


            if (fileExtension == "image/jpeg" || fileExtension == "image/png")
            {

                variables.AdminUpdateProductCategoryPic_Name = filename;
                variables.AdminUpdateProductCategoryPic_Path = "/Images/Product/Category/";
                postedFile.SaveAs(Server.MapPath("~/Images/Product/Category/" + filename));

                insert.AdminUpdateProductCategory(variables);

                Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            }

            else
            {
                
            }


            txtproductcategory.Value = "";

            //slcteditrpoductcategory.DataSource = Dropdown.GetAdminProductTypeProductCategory();
            //slcteditrpoductcategory.DataTextField = "Text";
            //slcteditrpoductcategory.DataValueField = "Value";
            //slcteditrpoductcategory.DataBind();


            //slctservices.DataSource = Dropdown.GetAdminProductCateoryService();
            //slctservices.DataTextField = "Text";
            //slctservices.DataValueField = "Value";
            //slctservices.DataBind();

        }
        catch (Exception ex) { }
       
    }

    protected void slcteditrpoductcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditProductCategoryForm = Convert.ToInt16(slcteditrpoductcategory.SelectedValue);
            table = ed.AdminEditProductCategoryForm(variables);

            txtproductcategory.Value = table.Rows[0][1].ToString().Trim();
            slctservices.Value = table.Rows[0][3].ToString().Trim();
        }
        catch(Exception ex)
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