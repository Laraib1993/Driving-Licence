using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditAssignTierLevel : System.Web.UI.Page
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

                    Select1.DataSource = Dropdown.GetAdminTierLevelDistributerForEdit();
                    Select1.DataTextField = "Text";
                    Select1.DataValueField = "Value";
                    Select1.DataBind();

                    slcttierlevel.DataSource = Dropdown.GetAdminTierLevelDistributerFk_TierLevel();
                    slcttierlevel.DataTextField = "Text";
                    slcttierlevel.DataValueField = "Value";
                    slcttierlevel.DataBind();


                    slctdistributer.DataSource = Dropdown.GetAdminTierLevelDistributerFk_Distributer();
                    slctdistributer.DataTextField = "Text";
                    slctdistributer.DataValueField = "Value";
                    slctdistributer.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateAssignTierLevelTID = 1;
        variables.AdminUpdateAssignTierLevelFk_TierLevel = Convert.ToInt32(slcttierlevel.Value);
        variables.AdminUpdateAssignTierLevelFk_Distributer = Convert.ToInt32(slctdistributer.Value);
        variables.AdminUpdateAssignTierLevelFk_Modifiedby = Convert.ToInt32(Session["username"]);

        insert.AdminUpdateAssignTierLevelForm(variables);

        slcttierlevel.Value = "";

        Select1.DataSource = Dropdown.GetAdminTierLevelDistributerForEdit();
        Select1.DataTextField = "Text";
        Select1.DataValueField = "Value";
        Select1.DataBind();

        slcttierlevel.DataSource = Dropdown.GetAdminTierLevelDistributerFk_TierLevel();
        slcttierlevel.DataTextField = "Text";
        slcttierlevel.DataValueField = "Value";
        slcttierlevel.DataBind();


        slctdistributer.DataSource = Dropdown.GetAdminTierLevelDistributerFk_Distributer();
        slctdistributer.DataTextField = "Text";
        slctdistributer.DataValueField = "Value";
        slctdistributer.DataBind();
    }

    protected void slcttierlevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void slcttierlevel_SelectedIndexChanged1(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditAssignTierLevelForm = Convert.ToInt16(Select1.SelectedValue);
            table = ed.AdminEditAssignTierLevelForm(variables);

            slcttierlevel.Value = table.Rows[0][1].ToString().Trim();
            slctdistributer.Value = table.Rows[0][2].ToString().Trim();

        }
        catch (Exception ex)
        {

        }
    }
}