using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SprintDashboardReturnedShipmentWeeklyReport : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        //getattendance();
    }

    //public string getattendance()
    //{
    //    string data = "";
    //    using (cmd = new SqlCommand())
    //    {
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "sp_DataEntryStep2";
    //        cmd.Connection = Getconnected.getconnecting();
    //        using (sdr = cmd.ExecuteReader())
    //        {
    //            if (sdr.HasRows)
    //            {
    //                while (sdr.Read())
    //                {
    //                    int sno = Convert.ToInt16(sdr[0]);
    //                    string inword = Convert.ToString(sdr[1]);
    //                    string inworddate = Convert.ToDateTime(sdr[2]).ToLongDateString();
    //                    string outwarddatetime = Convert.ToDateTime(sdr[3]).ToLongDateString() + " " + Convert.ToDateTime(sdr[3]).ToShortTimeString();
    //                    string Employeename = Convert.ToString(sdr[4]);
    //                    string department = Convert.ToString(sdr[5]);
    //                    string reson = Convert.ToString(sdr[6]);
    //                    string user = Convert.ToString(sdr[7]);
    //                    data += "<tr><td>" + sno + "</td><td>" + inword + "</td><td>" + inworddate + "</td><td>"
    //                        + outwarddatetime + "</td><td>" + Employeename + "</td><td>" + department + "</td><td>" + reson + "</td><td>"
    //                        + user + "</td></tr>";
    //                }
    //            }
    //        }
    //        return data;
    //    }
    //}
}