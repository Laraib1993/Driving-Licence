using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

public partial class AdminDeletedProductServiceReport : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null && Session["password"] != null)
        {

            try { getattendance(); }
            catch (Exception ex) { }



        }
        else { Response.Redirect("SignIn.aspx"); }
    }

    public string getattendance()
    {
        string data = "";
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedProductServiceReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string service = Convert.ToString(sdr[1]);
                        string detail = Convert.ToString(sdr[2]);
                        string createdon = Convert.ToDateTime(sdr[3]).ToLongDateString();
                        string status = Convert.ToString(sdr[4]);

                        data += "<tr><td>" + sno + "</td><td>" + service + "</td><td>" + detail + "</td><td>"
                            + createdon + "</td><td>" + status + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}