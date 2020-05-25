using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ResellerAddProductForm : System.Web.UI.Page
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
                    slctproduct.DataSource = Dropdown.GetAdminProductFormPatner();
                    slctproduct.DataTextField = "Text";
                    slctproduct.DataValueField = "Value";
                    slctproduct.DataBind();
                }


            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        variables.ResellerAddProductFormFK_Product =Convert.ToInt16(slctproduct.SelectedValue);
        variables.ResellerAddProductFormFK_Patner = Convert.ToInt16(Session["username"]);
        variables.ResellerAddProductFormFK_Status = 1;
        variables.ResellerAddProductFormFK_Createdby = Convert.ToInt16(Session["username"]);

        insert.ReselerAddProductForm(variables);

        //P.ResellerInsertProductFormProductName = txtproductname.Value;
        //P.ResellerInsertProductFormDetail = txtdetail.Value;
        //P.ResellerInsertProductFormModelNo = txtmodelno.Value;
        //P.ResellerInsertProductFormPrice = Convert.ToDecimal(txtprice.Value);
        //P.ResellerInsertProductFormLaunchDate = Convert.ToDateTime(txtlaunchdate.Value);
        //P.ResellerInsertProductFormFK_Createdby = Convert.ToInt16(Session["username"]);
        //P.ResellerInsertProductFormFK_ProductType = 7;


        //    P.ResellerInsertProductFormFK_Patner = Convert.ToInt16(Session["username"]);
        //    //Convert.ToInt16(Session["username"])


        //    P.ResellerInsertProductFormFK_Status = 1;
        //    insert.ResellerInsertProductForm(P);

        //    Page.Response.Redirect(Page.Request.Url.AbsolutePath);


    }



    protected void slctproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        variables.ResellerAddProductFetch = Convert.ToInt16(slctproduct.SelectedValue);
        table = ed.ResellerAddProductForm(variables);

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