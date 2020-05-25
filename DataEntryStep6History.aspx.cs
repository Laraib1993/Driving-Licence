using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DataEntryStep6History : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
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
            cmd.CommandText = "sp_DataEntryStep6";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string inword = Convert.ToString(sdr[1]);
                        string outwarddatetime = Convert.ToDateTime(sdr[2]).ToLongDateString() + " " + Convert.ToDateTime(sdr[2]).ToShortTimeString();
                        string noofnewid = Convert.ToString(sdr[3]);
                        string discription = Convert.ToString(sdr[4]);
                        string reason = Convert.ToString(sdr[5]);
                        string user = Convert.ToString(sdr[6]);
                        data += "<tr><td>" + sno + "</td><td>" + inword + "</td><td>"
                            + outwarddatetime + "</td><td>" + noofnewid + "</td><td>" + discription + "</td><td>" + reason + "</td><td>"
                            + user + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}