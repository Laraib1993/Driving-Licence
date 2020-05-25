using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class AdminEditProductTypeForm : System.Web.UI.Page
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
                    //slcteditproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
                    //slcteditproducttype.DataTextField = "Text";
                    //slcteditproducttype.DataValueField = "Value";
                    //slcteditproducttype.DataBind();



                    //slctproductcategory.DataSource = Dropdown.GetAdminProductTypeProductCategory();
                    //slctproductcategory.DataTextField = "Text";
                    //slctproductcategory.DataValueField = "Value";
                    //slctproductcategory.DataBind();
                }

            }
            else { Response.Redirect("SignIn.aspx"); }
        }

        catch(Exception ex)
        {

        }
     
        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            variables.AdminUpdateProductTypePTID = Convert.ToInt16(slcteditproducttype.SelectedValue);
            variables.AdminUpdateProductTypeType = txtproducttype.Value;
            variables.AdminUpdateProductTypeFK_Createdby = Convert.ToInt16(Session["username"]);
            variables.AdminUpdateProductTypeFK_ProductCategory = Convert.ToInt16(slctproductcategory.Value);
            variables.AdminUpdateProductTypeFK_Status = 1;
            variables.AdminUpdateProductTypeCreatedon = Convert.ToDateTime(txtlaunchdate.Value);
            insert.AdminUpdateProductType(variables);


            txtlaunchdate.Value = "";
            txtproducttype.Value = "";

            //slcteditproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
            //slcteditproducttype.DataTextField = "Text";
            //slcteditproducttype.DataValueField = "Value";
            //slcteditproducttype.DataBind();



            //slctproductcategory.DataSource = Dropdown.GetAdminProductTypeProductCategory();
            //slctproductcategory.DataTextField = "Text";
            //slctproductcategory.DataValueField = "Value";
            //slctproductcategory.DataBind();
        }
        catch(Exception ex)
        {

        }
       

    }

    protected void slcteditproducttype_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.AdminEditProductTypeFetch = Convert.ToInt16(slcteditproducttype.SelectedValue);
            table = ed.AdminEditProductTypeForm(variables);

            txtproducttype.Value = table.Rows[0][1].ToString().Trim();
            txtlaunchdate.Value = Convert.ToDateTime(table.Rows[0][2]).ToLongDateString().Trim();
            slctproductcategory.Value = table.Rows[0][4].ToString().Trim();
        }
        catch(Exception ex)
        {

        }
       
    }
}