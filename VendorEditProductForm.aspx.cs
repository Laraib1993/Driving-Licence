using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class VendorEditProductForm : System.Web.UI.Page
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

                    Slcteditproduct.DataSource = Dropdown.GetAdminProductFormPatner();
                    Slcteditproduct.DataTextField = "Text";
                    Slcteditproduct.DataValueField = "Value";
                    Slcteditproduct.DataBind();

                    

                    //slctproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
                    //slctproducttype.DataTextField = "Text";
                    //slctproducttype.DataValueField = "Value";
                    //slctproducttype.DataBind();
                }

            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        variables.VendorUpdateProductFormPID = Convert.ToInt16(Slcteditproduct.SelectedValue);
        variables.VendorUpdateProductFormProductName = txtproductname.Value;
        variables.VendorUpdateProductFormDetail = txtdetail.Value;
        variables.VendorUpdateProductFormModelNo = txtmodelno.Value;
        variables.VendorUpdateProductFormPrice = Convert.ToDecimal(txtprice.Value);
        variables.VendorUpdateProductFormLaunchDate = Convert.ToDateTime(txtlaunchdate.Value);
        variables.VendorUpdateProductFormFK_Createdby = Convert.ToInt16(Session["username"]);
        variables.VendorUpdateProductFormFK_ProductType = Convert.ToInt16(slctproducttype.Value);
        variables.VendorUpdateProductFormFK_Vendor = Convert.ToInt16(Session["username"]);



        // First Picture Saving Start
        HttpPostedFile postedFile = pic1.PostedFile;
        string fileExtension = postedFile.ContentType;
        // First Picture Saving End

        // Second Picture Saving Start
        HttpPostedFile pict2 = pic2.PostedFile;
        string pict2extension = pict2.ContentType;
        // Second Picture Saving End


        // Third Picture Saving Start
        HttpPostedFile pict3 = pic3.PostedFile;
        string pict3Extension = pict3.ContentType;
        // Third Picture Saving End


        // To check pictures is in jpeg and png formet
        if (fileExtension == "image/jpeg" || fileExtension == "image/png" && pict2extension == "image/jpeg" || pict2extension == "image/png" && pict3Extension == "image/jpeg" || pict3Extension == "image/png")
        {

            string filename = "Glocali_Product_By_Vendor" + Convert.ToInt64(slctproducttype.Value) + "_1.jpg";
            postedFile.SaveAs(Server.MapPath("~/Images/Product/" + filename));

            string pict2filename = "Glocali_Product_By_Vendor" + Convert.ToInt64(slctproducttype.Value) + "_2.jpg";
            pict2.SaveAs(Server.MapPath("~/Images/Product/" + pict2filename));

            string pict3filname = "Glocali_Product_By_Vendor" + Convert.ToInt64(slctproducttype.Value) + "_3.jpg";
            pict3.SaveAs(Server.MapPath("~/Images/Product/" + pict3filname));


            variables.VendorUpdateProductFormPic1name = filename;
            variables.VendorUpdateProductFormPic2name = pict2filename;
            variables.VendorUpdateProductFormPic3name = pict3filname;

            variables.VendorUpdateProductFormPic1path = "/Images/Product/";
            variables.VendorUpdateProductFormPic2path = "/Images/Product/";
            variables.VendorUpdateProductFormPic3path = "/Images/Product/";


            //variables.VendorUpdateProductFormFK_Patner = Convert.ToInt16(Slcteditproduct.SelectedValue);
            //Convert.ToInt16(Session["username"])


            variables.VendorUpdateProductFormFK_Status = 1;
            insert.VendorUpdateProductForm(variables);

            Page.Response.Redirect(Page.Request.Url.AbsolutePath);

        }

        else
        {

        }

        txtproductname.Value = "";



        Slcteditproduct.DataSource = Dropdown.GetAdminProductFormPatner();
        Slcteditproduct.DataTextField = "Text";
        Slcteditproduct.DataValueField = "Value";
        Slcteditproduct.DataBind();



        //slctproducttype.DataSource = Dropdown.GetAdminProductTypeProductType();
        //slctproducttype.DataTextField = "Text";
        //slctproducttype.DataValueField = "Value";
        //slctproducttype.DataBind();
    }

    protected void Slcteditproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.VendorEditProductFetch = Convert.ToInt16(Slcteditproduct.SelectedValue);
            table = ed.VendorEditProductForm(variables);

            txtproductname.Value = table.Rows[0][1].ToString().Trim();
            txtdetail.Value = table.Rows[0][2].ToString().Trim();
            txtmodelno.Value = table.Rows[0][3].ToString().Trim();
            txtprice.Value = table.Rows[0][4].ToString().Trim();
            txtlaunchdate.Value = table.Rows[0][5].ToString().Trim();
            //slctvendor.Value = table.Rows[0][6].ToString().Trim();
            slctproducttype.Value = table.Rows[0][8].ToString().Trim();

        }
        catch (Exception ex)
        {

        }
    }
}