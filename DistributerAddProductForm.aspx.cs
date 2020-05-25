using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DistributerAddProductForm : System.Web.UI.Page
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
                    slcteditproduct.DataSource = Dropdown.GetAdminProductFormPatner();
                    slcteditproduct.DataTextField = "Text";
                    slcteditproduct.DataValueField = "Value";
                    slcteditproduct.DataBind();
                }

                
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.DistributerAddProductFormFK_Product = Convert.ToInt16(slcteditproduct.SelectedValue);
        variables.DistributerAddProductFormFK_Patner = Convert.ToInt16(Session["username"]);
        variables.DistributerAddProductFormFK_Status = 1;
        variables.DistributerAddProductFormFK_Createdby = Convert.ToInt16(Session["username"]);

        insert.DistributerAddProductForm(variables);


    }



    protected void slcteditproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        variables.DistributerAddProductFetch = Convert.ToInt16(slcteditproduct.SelectedValue);
        table = ed.DistributerAddProductForm(variables);

        imgprodA.Src = table.Rows[0][5].ToString().Trim() + table.Rows[0][4].ToString().Trim();
        ProductNameA.InnerText = table.Rows[0][1].ToString().Trim();
        VendornameA.InnerText = table.Rows[0][2].ToString().Trim();
        DetailA.InnerText = table.Rows[0][3].ToString().Trim();

        imgprodB.Src = table.Rows[0][7].ToString().Trim() + table.Rows[0][6].ToString().Trim();
        ProductNameB.InnerText = table.Rows[0][1].ToString().Trim();
        VendornameB.InnerText = table.Rows[0][2].ToString().Trim();
        DetailB.InnerText = table.Rows[0][3].ToString().Trim();

        imgprodC.Src = table.Rows[0][9].ToString().Trim() + table.Rows[0][8].ToString().Trim();
        ProductNameC.InnerText = table.Rows[0][1].ToString().Trim();
        VendorNameC.InnerText = table.Rows[0][2].ToString().Trim();
        DetailC.InnerText = table.Rows[0][3].ToString().Trim();

        //ProductNameA.InnerText = "Hassan Product";
        //VendornameA.InnerText = "Hassan Munawer";
        //DetailA.InnerText = "Ming sits in the corner the whole day. She's into crochet Ming sits in the corner the whole day. She's into crochet";
    }
}