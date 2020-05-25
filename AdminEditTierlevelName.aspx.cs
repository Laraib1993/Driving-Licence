using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminEditTierlevelName : System.Web.UI.Page
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
                    slcttierlevel.DataSource = Dropdown.GetAdminTierLevelTierLevel();
                    slcttierlevel.DataTextField = "Text";
                    slcttierlevel.DataValueField = "Value";
                    slcttierlevel.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.AdminUpdateTierLevelTLID = Convert.ToInt16(slcttierlevel.SelectedValue);
        variables.AdminUpdateTierLevelTierLevel = txttierlevel.Value;
        variables.AdminUpdateTierLevelFk_Createdby = Convert.ToInt32(Session["username"]);

        insert.AdminUpdateTierLevelForm(variables);

        txttierlevel.Value = "";

        slcttierlevel.DataSource = Dropdown.GetAdminTierLevelTierLevel();
        slcttierlevel.DataTextField = "Text";
        slcttierlevel.DataValueField = "Value";
        slcttierlevel.DataBind();
    }

    protected void slcttierlevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminUpdateTierLevelTLID = Convert.ToInt16(slcttierlevel.SelectedValue);
            table = ed.AdminEditTierLevelForm(variables);

            txttierlevel.Value = table.Rows[0][1].ToString().Trim();
            
        }
        catch (Exception ex)
        {

        }
    }
}