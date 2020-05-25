using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Dashboard : System.Web.UI.Page
{
    Fetch f = new Fetch();
    private static DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null) { }
        else { Response.Redirect("SignIn.aspx"); }

        dt = new DataTable();
        //Daily Fetch//
        dt = f.AdminFetchTotalScanningInword_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalScanningInword.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingInword_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingInword.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDInword_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDInword.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalScanningOutward_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalScanningOutward.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingOutward_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingOutward.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDOutward_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDOutward.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingCaseInword_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingCaseInword.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingCaseOutward_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingCaseOutward.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDCaseInword_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDCaseInword.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDCaseOutward_Today();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDCaseOutward.Text = dt.Rows[0][0].ToString();
        }
        //Daily Fetch//


        //Pending Fetch//
        dt = f.AdminFetchTotalScanningSheetOutward_Pending();
        if (dt.Rows.Count > 0)
        {
            lblTotalScanningSheetOutward_Pending.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingSheetOutward_Pending();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingSheetOutward_Pending.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDSheetOutward_Pending();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDSheetOutward_Pending.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalSearchingCaseOutward_Pending();
        if (dt.Rows.Count > 0)
        {
            lblTotalSearchingCaseOutward_Pending.Text = dt.Rows[0][0].ToString();
        }

        dt = f.AdminFetchTotalNewIDCaseOutward_Pending();
        if (dt.Rows.Count > 0)
        {
            lblTotalNewIDCaseOutward_Pending.Text = dt.Rows[0][0].ToString();
        }
        //Pending Fetch//
    }
}