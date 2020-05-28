using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DataEntryFinalStep : System.Web.UI.Page
{

    Properties P = new Properties();
    Insertion insert = new Insertion();
    DataTable dt = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();
    Fetch F = new Fetch();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        //    if (Session["username"] != null && Session["password"] != null)
        //    {
        //    }
        //    else { Response.Redirect("SignIn.aspx"); }
        //}
        //catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (Request.Form["chkPassPort"] != null)
        {
            if (Request.Form["chkPassPort"] == "delivered")
            {
                ddlreason.SelectedIndex = -1;
                txtreturned.Value = null;
                txtdescription.Value = null;
                P.AdminInsertdelivereddeliveredon = Convert.ToDateTime(txtdelivered.Value);
                P.AdminInsertdeliveredshipment = Convert.ToInt32(ddlshipment.SelectedValue);
                P.AdminInsertdeliveredcreatedby = Convert.ToInt32(Session["username"]);
                P.AdminFetchID = Convert.ToInt32(ddlshipment.SelectedValue);
                dt2 = F.AdminFetchcheckongoingstep(P);
                dt3 = F.AdminFetchcheckdeliveredstep(P);
                if (dt2.Rows[0][0] != null)
                {
                    P.AdminInsertdeliveredRider = Convert.ToInt32(dt2.Rows[0][0]);

                    if (dt3.Rows[0][0] != null)
                    {
                        insert.AdminInsertdeliveredstep(P);
                    }

                    else { }
                }

                else { }

                

            }

            else if (Request.Form["chkPassPort"] == "returned")
            {
                txtdelivered.Value = null;
                P.AdminInsertreturnerturnon = Convert.ToDateTime(txtreturned.Value);
                P.AdminInsertreturncreatedby = Convert.ToInt32(Session["username"]);
                P.AdminInsertreturnshipment = Convert.ToInt32(ddlshipment.SelectedValue);
                P.AdminInsertreturnreason = Convert.ToInt32(ddlreason.SelectedValue);
                P.AdminInsertreturndisccription = txtdescription.InnerText;
                P.AdminFetchID = Convert.ToInt32(ddlshipment.SelectedValue); 
                 dt = F.AdminFetchcheckreturnstep(P);

                if (dt2.Rows[0][0] != null)
                {
                    P.AdminInsertreturnrider = Convert.ToInt32(dt2.Rows[0][0]);

                    if (dt.Rows[0][0] != null)
                    {
                        insert.AdminInsertReturnstep(P);
                    }

                    else { }
                }

                else { }
            }
            
        }
    }


}