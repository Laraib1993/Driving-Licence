using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DataEntryStep8History : System.Web.UI.Page
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
            cmd.CommandText = "sp_DataEntryStep8";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string inword = Convert.ToString(sdr[1]);
                        string noofnewid = Convert.ToString(sdr[2]);
                        string noofsameid = Convert.ToString(sdr[3]);
                        string noofmodification = Convert.ToString(sdr[4]);
                        string discription = Convert.ToString(sdr[5]);
                        string Outwardon = Convert.ToDateTime(sdr[6]).ToLongDateString();
                        string outwardto = Convert.ToString(sdr[7]);
                        string reason = Convert.ToString(sdr[8]);
                        string user = Convert.ToString(sdr[9]);
                        data += "<tr><td>" + sno + "</td><td>" + inword + "</td><td>" + noofnewid + "</td><td>"
                            + noofsameid + "</td><td>" + noofmodification + "</td><td>" + discription + "</td><td>" + Outwardon + "</td><td>"
                            + outwardto + "</td><td>" + user + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}