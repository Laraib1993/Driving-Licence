using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddServiceTypeForm : System.Web.UI.Page
{
    Insertion insert = new Insertion();
    Properties variables = new Properties();
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

                    slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_3();
                    slctinword.DataTextField = "Text";
                    slctinword.DataValueField = "Value";
                    slctinword.DataBind();

                    slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
                    slctOutwardto.DataTextField = "Text";
                    slctOutwardto.DataValueField = "Value";
                    slctOutwardto.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        variables.AdminInsertSearchingSheetOutward_NoofNewID = Convert.ToInt32(txtnoofNewID.Value);
        variables.AdminInsertSearchingSheetOutward_NoofSameID = Convert.ToInt32(txtSameid.Value);
        variables.AdminInsertSearchingSheetOutward_NoofModification = Convert.ToInt32(txtnoofModification.Value);
        variables.AdminInsertSearchingSheetOutward_Discription = txtDiscription.Value;
        //variables.AdminInsertSearchingSheetOutward_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertSearchingSheetOutward_SearchingSheetInwordID = Convert.ToInt32(slctinword.SelectedValue);
        variables.AdminInsertSearchingSheetOutward_FK_Createdby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertSearchingSheetOutward_FK_OutwardTo = Convert.ToInt32(slctOutwardto.Value);
        variables.AdminInsertSearchingSheetOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertSearchingSheetOutward_FK_ReasonDoneID = slctinword.SelectedItem.Text;

        insert.AdminInsertSearchingSheetOutward(variables);

        //Page.Response.Redirect(Page.Request.Url.AbsolutePath);
        //updation start//
        variables.AdminUpdateMainForSearchingOutward_Sno = slctinword.SelectedItem.Text;
        variables.AdminUpdateMainForSearchingOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateMainForSearchingOutward_Outwardby = Convert.ToString(Session["username"]);

        insert.AdminUpdateMainForSearchingOutward(variables);

        slctinword.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_3();
        slctinword.DataTextField = "Text";
        slctinword.DataValueField = "Value";
        slctinword.DataBind();
        
     
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