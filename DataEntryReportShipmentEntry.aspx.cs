using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DataEntryReportShipmentEntry : System.Web.UI.Page
{
    Fetch f = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}