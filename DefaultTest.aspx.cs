using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;

public partial class DefaultTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ImageName = "Image Name";
        if (flp.PostedFile != null && flp.PostedFile.FileName != null)
        {

            string strExtension = System.IO.Path.GetExtension(flp.FileName);
            if ((strExtension.ToUpper() == ".PNG") | (strExtension.ToUpper() == ".GIF"))
            {
                // Resize Image Before Uploading to DataBase
                FileUpload fi = new FileUpload();
                fi = flp;

                System.Drawing.Image imageToBeResized = System.Drawing.Image.FromStream(fi.PostedFile.InputStream);
                int imageHeight = imageToBeResized.Height;
                int imageWidth = imageToBeResized.Width;
                int maxHeight = 120;
                int maxWidth = 160;
                imageHeight = (imageHeight * maxWidth) / imageWidth;
                imageWidth = maxWidth;

                if (imageHeight > maxHeight)
                {
                    imageWidth = (imageWidth * maxHeight) / imageHeight;
                    imageHeight = maxHeight;
                }

                Bitmap bitmap = new Bitmap(imageToBeResized, imageWidth, imageHeight);
                System.IO.MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
               
                stream.Position = 0;
                byte[] image = new byte[stream.Length + 1];
                stream.Read(image, 0, image.Length);

                //final = Path.Combine(context.Server.MapPath("~/Images/Patner/"), fname);
                //file.SaveAs(final);
                //// Create SQL Connection 
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["connected"].ConnectionString;

                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "insert into Patner(Logoname,Logopath) VALUES (@ImageName,@Image)";
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = con;

                //SqlParameter ImageName1 = new SqlParameter("@ImageName", SqlDbType.VarChar, 50);
                //ImageName1.Value = ImageName.ToString();
                //cmd.Parameters.Add(ImageName1);

                //SqlParameter UploadedImage = new SqlParameter("@Image", SqlDbType.Image, image.Length);
                //UploadedImage.Value = image;
                //cmd.Parameters.Add(UploadedImage);
                //con.Open();
                //int result = cmd.ExecuteNonQuery();
                //con.Close();
                //if (result > 0)
                //    lblMessage.Text = "File Uploaded";
                //GridView1.DataBind();
            }

        }

    }
}