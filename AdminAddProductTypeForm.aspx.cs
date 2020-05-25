using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddProductTypeForm : System.Web.UI.Page
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
                    slctInwordNo.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_5();
                    slctInwordNo.DataTextField = "Text";
                    slctInwordNo.DataValueField = "Value";
                    slctInwordNo.DataBind();

                    slctOutwardto.DataSource = Dropdown.GetAdminOutwardScanningForm_EmployeeName();
                    slctOutwardto.DataTextField = "Text";
                    slctOutwardto.DataValueField = "Value";
                    slctOutwardto.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //DateTime d = Convert.ToDateTime(txtlaunchdate.Value);
       
            
        variables.AdminInsertNewIDSheetOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertNewIDSheetOutward_Createdon = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminInsertNewIDSheetOutward_Discription = txtDiscription.Value;
        variables.AdminInsertNewIDSheetOutward_FK_NewIDSheetInwordID = Convert.ToInt32(slctInwordNo.SelectedValue);
        variables.AdminInsertNewIDSheetOutward_FK_Createdby = Convert.ToInt32(Session["username"]);
        variables.AdminInsertNewIDSheetOutward_FK_OutwardTo = Convert.ToInt32(slctOutwardto.Value);
        variables.AdminInsertNewIDSheetOutward_FK_ReasonDoneID = slctInwordNo.SelectedItem.Text;

        insert.AdminInsertNewIDSheetOutward(variables);
        //updation start//
        variables.AdminUpdateNewIDOutward_Sno = slctInwordNo.SelectedItem.Text;
        variables.AdminUpdateNewIDOutward_OutwardDateTime = Convert.ToDateTime(txtlaunchdate.Value);
        variables.AdminUpdateNewIDOutward_Outwardby = Convert.ToString(Session["username"]);

        insert.AdminUpdateMainForNewIDSheetOutward(variables);

        slctInwordNo.DataSource = Dropdown.GetAdminDropdownInwordno_ShowReason_5();
        slctInwordNo.DataTextField = "Text";
        slctInwordNo.DataValueField = "Value";
        slctInwordNo.DataBind();
        
        //catch(Exception ex) { }
        
    }
}