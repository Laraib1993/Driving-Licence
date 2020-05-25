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

public partial class AdminActivePatnerReport : System.Web.UI.Page
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                //DataTable dt = new DataTable("data");

                //dt.Columns.Add("ID");
                //dt.Columns.Add("Name");
                //dt.Columns.Add("RollNo");

                //for (int i = 0; i < 5; i++)
                //{
                //    DataRow dr = dt.NewRow();

                //    dr["ID"] = i.ToString();
                //    dr["Name"] = "Laraib" + i.ToString();
                //    dr["RollNo"] = "01" + i.ToString();
                //    dt.Rows.Add(dr);
                //}
                //dt.AcceptChanges();

                //string filePath = Path.Combine(HttpContext.Current.Server.MapPath("~/dt-json-data/json.json"));

                //WriteJason(dt, filePath);getattendance()
                getattendance();

            }
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
            cmd.CommandText = "sp_AdminActivePatnerReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string logo = Convert.ToString(sdr[1])+ Convert.ToString(sdr[9]);
                        string name = Convert.ToString(sdr[2]);
                        string email = Convert.ToString(sdr[3]);
                        string phone = Convert.ToString(sdr[4]);
                        string type = Convert.ToString(sdr[5]);
                        string contactpersonname = Convert.ToString(sdr[6]);
                        string contactpersonemail = Convert.ToString(sdr[7]);
                        string contactpersonphone = Convert.ToString(sdr[8]);
                        string logoname = Convert.ToString(sdr[9]);
                        string revenue = Convert.ToString(sdr[10]);
                        string compsize = Convert.ToString(sdr[11]);
                        string region = Convert.ToString(sdr[14]);
                        string country = Convert.ToString(sdr[13]);
                        string city = Convert.ToString(sdr[12]);

                        data += "<tr><td>" + sno + "</td><td>"+ "<img src='"+logo+"' width='80' height='30' />" + "</td><td>"
                            + name + "</td><td>" + email + "</td><td>"
                            + phone + "</td><td>" + type + "</td><td>" + contactpersonname + "</td><td>"+ contactpersonemail + "</td><td>"+contactpersonphone + "</td><td>" +
                            revenue + "</td><td>" + compsize + "</td><td>" + region + "</td><td>" + country + "</td><td>" + city + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }






    //public bool WriteJason(DataTable dt, string path)
    //{


    //        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
    //        ArrayList datarow = new ArrayList();
    //        //Dictionary<string, string> datarow = new Dictionary<string, string>();
    //    List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
    //        Dictionary<string, string> row = null;


    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            row = new Dictionary<string, string>();
    //            foreach (DataColumn col in dt.Columns)
    //            {
    //                row.Add(col.ColumnName.Trim().ToString(), Convert.ToString(dr[col]));
    //            }

    //            rows.Add(row);
    //       // datarow.Add("data", rows.ToString());

    //    }

    //        string jsonstring = serializer.Serialize(datarow);

    //        using (var file = new StreamWriter(path, false))
    //        {
    //            file.Write(jsonstring);
    //            file.Close();
    //            file.Dispose();
    //        }
    //        return true;

    //}


}