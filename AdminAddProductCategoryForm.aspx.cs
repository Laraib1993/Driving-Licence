using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddProductCategoryForm : System.Web.UI.Page
{
    Properties variables = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                if (!IsPostBack)
                {
                    slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_4();
                    slctinword.DataTextField = "Text";
                    slctinword.DataValueField = "Value";
                    slctinword.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
        
       
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
            //variables.AdminInsertNewIDSheetInword_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
            variables.AdminInsertNewIDSheetInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
            variables.AdminInsertNewIDSheetInword_Discription = txtDiscription.Value;
            variables.AdminInsertNewIDSheetInword_FK_SearchingOutwardID = Convert.ToInt32(slctinword.SelectedValue);
            variables.AdminInsertNewIDSheetInword_FK_Createdby = Convert.ToInt32(Session["username"]);
            variables.AdminInsertNewIDSheetInword_FK_ReasonDoneID = slctinword.SelectedItem.Text;
            insert.AdminInsertNewIDSheetInword(variables);
            //updation start//

            variables.AdminUpdateMainForNewIDInword_Sno = slctinword.SelectedItem.Text;
            variables.AdminUpdateMainForNewIDInword_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
            variables.AdminUpdateMainForNewIDInword_Outwardby = Convert.ToString(Session["username"]);

            insert.AdminUpdateMainForNewIDSheetInword(variables);

            slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_4();
            slctinword.DataTextField = "Text";
            slctinword.DataValueField = "Value";
            slctinword.DataBind();

            //HttpPostedFile postedFile = pic1.PostedFile;
            //string filename = "Glocali_ProductCategory" + GeneratePassword() + ".jpg";
            //string fileExtension = postedFile.ContentType;


            //if (fileExtension == "image/jpeg" || fileExtension == "image/png")
            //{

            //    variables.AdminInsertProductCategoryPic_Name = filename;
            //    variables.AdminInsertProductCategoryPic_Path = "/Images/Product/Category/";
            //    postedFile.SaveAs(Server.MapPath("~/Images/Product/Category/" + filename));

                



            //    Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            //}

            //else
            //{
            //    Page.Response.Redirect(Page.Request.Url.AbsolutePath);
            //}

        
     
    }



    //public string GeneratePassword()
    //{
    //    string PasswordLength = "8";
    //    string NewPassword = "";

    //    string allowedChars = "";
    //    allowedChars = "1,2,3,4,5,6,7,8,9,0";
    //    allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
    //    allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

    //    char[] sep = {
    //        ','
    //    };
    //    string[] arr = allowedChars.Split(sep);


    //    string IDString = "";
    //    string temp = "";

    //    Random rand = new Random();

    //    for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
    //    {
    //        temp = arr[rand.Next(0, arr.Length)];
    //        IDString += temp;
    //        NewPassword = IDString;

    //    }
    //    return NewPassword;
    //}
}