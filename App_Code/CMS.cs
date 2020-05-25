using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text;

public class CMS
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;

    private static DataTable dt;


    public void DistributerCard(Properties P)
    {

        try
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UI_Distributer_MainPage";
                cmd.Connection = Getconnected.getconnecting();
                using (sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                            div1.Attributes["class"] = "col-md-3 mt-30";
                            P.MyProperty.Controls.Add(div1);



                            System.Web.UI.HtmlControls.HtmlGenericControl div2 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                            div2.Attributes["class"] = "border mt-30";
                            div1.Controls.Add(div2);
                            

                            System.Web.UI.HtmlControls.HtmlImage timerimag = new System.Web.UI.HtmlControls.HtmlImage();
                            timerimag.Attributes["class"] = "img-responsive";
                            //timerimag.Attributes["Width"] = "60px";
                            timerimag.Attributes["Height"] = "30%";
                            //timerimag.Width = 53;
                            timerimag.Height = 53;
                            timerimag.Src = sdr[2].ToString() + sdr[1].ToString();
                            timerimag.Alt = sdr[2].ToString();
                            div2.Controls.Add(timerimag);


                            //System.Web.UI.HtmlControls.HtmlGenericControl timerspan = new System.Web.UI.HtmlControls.HtmlGenericControl("br");
                            //timerspan.InnerText = "Locations : Karachi,Islamabad,Lahore";
                            //div2.Controls.Add(timerspan);

                            System.Web.UI.HtmlControls.HtmlGenericControl p2 = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
                           
                            StringBuilder sb = new StringBuilder();
                            sb.Append("Tier Level : 1");
                            sb.AppendLine("<br>" );
                            sb.Append("Locations : Karachi, Lahore, Islamabad");
                            sb.AppendLine("<br>");
                            sb.Append(sdr[3].ToString().Replace("https://", "www."));
                            sb.AppendLine("<br>");
                            sb.Append("Patner Status : " + sdr[4].ToString());
                            p2.InnerHtml = sb.ToString();
                            div2.Controls.Add(p2);
                            
                        }
                    }
                }
            }
        }
        catch (Exception ex) { }

    }


    public void VendorLogoMainPage(Properties P)
    {

        try
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UI_VendorLogos_MainPage";
                cmd.Connection = Getconnected.getconnecting();
                using (sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                            div1.Attributes["class"] = "col-md-3";
                            P.UI_VendorControl.Controls.Add(div1);
                            
                            System.Web.UI.HtmlControls.HtmlAnchor a = new System.Web.UI.HtmlControls.HtmlAnchor();
                            a.HRef = "#slider1";
                            a.Attributes["onclick"] = "#slider1";
                            div1.Controls.Add(a);
                            
                            System.Web.UI.HtmlControls.HtmlImage timerimag = new System.Web.UI.HtmlControls.HtmlImage();
                            //timerimag.Width = 292;
                            //timerimag.Height = 90;
                            timerimag.Src = sdr[1].ToString() + sdr[0].ToString();
                            timerimag.Alt = sdr[0].ToString();
                            a.Controls.Add(timerimag);


                        }
                    }
                }
            }
        }

        catch (Exception ex) { }

    }
}