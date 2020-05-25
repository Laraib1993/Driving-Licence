using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AdminReasonInfo : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        getattendance();
    }

    public string getattendance()
    {
        string data = "";
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_AdminReasonInfo";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string inword = Convert.ToString(sdr[1]);
                        string reason_done = Convert.ToString(sdr[2]);
                        data += "<tr><td>" + sno + "</td><td>" + inword + "</td><td>" + reason_done + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}