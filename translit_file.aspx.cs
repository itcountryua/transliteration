using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

using System.IO;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenXmlPowerTools;

using System.Net;
using System.Drawing.Imaging;


public partial class translit_file : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void IMBT_TRANSLITERATION_Click(object sender, ImageClickEventArgs e)
    {
        if (FileUploadControl.HasFile)
            try
            {
                string fileNameFromUser = FileUploadControl.FileName;

                var fiFileName = new FileInfo(fileNameFromUser);
                if (Util.IsWordprocessingML(fiFileName.Extension))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        memoryStream.Write(FileUploadControl.FileBytes, 0, FileUploadControl.FileBytes.Length);
                        using (WordprocessingDocument wDoc = WordprocessingDocument.Open(memoryStream, true))
                        {

                        }
                        Session["ByteArray"] = FileUploadControl.FileBytes;
                        Session["FileNameFromUser"] = fileNameFromUser;
                        TRA();
                        DOWNLO();
                    }
                }
                else
                {
                    Session["ByteArray"] = null;
                    Session["FileNameFromUser"] = null;
                }
            }
            catch (Exception ex)
            {
                Session["ByteArray"] = null;
                Session["FileNameFromUser"] = null;
            }
        else
        {
            Session["ByteArray"] = null;
            Session["FileNameFromUser"] = null;
        }
    }
    public void TRA()
    {
        byte[] byteArray = (byte[])(Session["ByteArray"]);
        if (byteArray != null)
        {
            try
            {

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(byteArray, 0, byteArray.Length);
                    using (WordprocessingDocument wDoc =
                        WordprocessingDocument.Open(memoryStream, true))
                    {
                        var body = wDoc.MainDocumentPart.Document.Body;
                        foreach (var text in body.Descendants<Text>())
                        {
                            string source = text.Text;
                            ClassTR oo = new ClassTR();
                            text.Text = oo.ClassTR_(text.Text);                            
                        }
                    }
                    Session["ByteArray"] = memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                //lblMessage.Text = "ERROR: "+ex.Message.ToString();
            }
        }
        else
        {
            //lblMessage.Text = "You have not specified a file.";
        }
    }
    public void DOWNLO()
    {
        byte[] byteArray = (byte[])(Session["ByteArray"]);

        if (byteArray != null)
        {
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            string fileName = (string)(Session["FileNameFromUser"]);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", fileName));
            Response.BinaryWrite(byteArray);
            Response.Flush();
            Response.End();
        }
        else
        {
            //lblMessage.Text = "You have not specified a file.";
        }
    }
}