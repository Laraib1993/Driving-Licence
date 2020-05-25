using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddProductForm : System.Web.UI.Page
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
                    //slctReason.DataSource = Dropdown.GetAdminReason();
                    //slctReason.DataTextField = "Text";
                    //slctReason.DataValueField = "Value";
                    //slctReason.DataBind();

                    slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_2();
                    slctinword.DataTextField = "Text";
                    slctinword.DataValueField = "Value";
                    slctinword.DataBind();

                }


            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.AdminInsertSearchingSheetInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        P.AdminInsertSearchingSheetInword_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
        P.AdminInsertSearchingSheetInword_FK_OutwardHistoryID = Convert.ToInt32(slctinword.SelectedValue);
        P.AdminInsertSearchingSheetInword_FK_Reason = 3;
        P.AdminInsertSearchingSheetInword_FK_Createdby = Convert.ToInt32(Session["username"]);
        P.AdminInsertSearchingSheetInword_FK_ReasonDoneID = slctinword.SelectedItem.Text;


        insert.AdminInsertSearchingSheetInword(P);

        //updation start//
        P.AdminUpdateMainForSearchingInword_Sno = slctinword.SelectedItem.Text;
        P.AdminUpdateMainForSearchingInword_InwordDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        P.AdminUpdateMainForSearchingInword_FK_Createdby = Convert.ToInt32(Session["username"]);
        //P.AdminUpdateMainForSearchingInword_FK_Reason = 3;

        insert.AdminUpdateMainForSearchingInword(P);

        slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_2();
        slctinword.DataTextField = "Text";
        slctinword.DataValueField = "Value";
        slctinword.DataBind();

    }

//    public string GeneratePassword()
//    {
//        string PasswordLength = "8";
//        string NewPassword = "";

//        string allowedChars = "";
//        allowedChars = "1,2,3,4,5,6,7,8,9,0";
//        allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
//        allowedChars += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

//        char[] sep = {
//            ','
//        };
//        string[] arr = allowedChars.Split(sep);


//        string IDString = "";
//        string temp = "";

//        Random rand = new Random();

//        for (int i = 0; i < Convert.ToInt32(PasswordLength); i++)
//        {
//            temp = arr[rand.Next(0, arr.Length)];
//            IDString += temp;
//            NewPassword = IDString;

//        }
//        return NewPassword;
//    }
}
