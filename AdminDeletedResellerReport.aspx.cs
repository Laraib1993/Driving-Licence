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

public partial class AdminDeletedResellerReport : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null) { getattendance(); }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch(Exception ex) { }
        
    }

    public string getattendance()
    {
        string data = "";
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminDeletedResellerReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string logo = Convert.ToString(sdr[1]) + Convert.ToString(sdr[9]);
                        string name = Convert.ToString(sdr[2]);
                        string email = Convert.ToString(sdr[3]);
                        string phone = Convert.ToString(sdr[4]);
                        string web = Convert.ToString(sdr[5]);
                        string contactpersonname = Convert.ToString(sdr[6]);
                        string contactpersonemail = Convert.ToString(sdr[7]);
                        string contactpersonphone = Convert.ToString(sdr[8]);
                        string logoname = Convert.ToString(sdr[9]);
                        string website = Convert.ToString(sdr[10]);
                        string revenue = Convert.ToString(sdr[11]);
                        string size = Convert.ToString(sdr[12]);

                        data += "<tr><td>" + sno + "</td><td>" + "<img src='" + logo + "' width='85' height='35' />" + "</td><td>"
                            + name + "</td><td>" + email + "</td><td>"
                            + phone + "</td><td>" + website + "</td><td>" + contactpersonname + "</td><td>" + contactpersonemail + "</td><td>" + contactpersonphone + "</td><td>" + revenue +
                           "</td><td>" + size + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}