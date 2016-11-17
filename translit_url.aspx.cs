using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;

using System.Text;

using System.IO;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenXmlPowerTools;
using System.Net;
using System.Drawing.Imaging;

using System.Net.Cache;

public partial class translit_url : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void IMBT_TRANSLITERATION_Click(object sender, ImageClickEventArgs e)
    {
        WebRequest myWebRequest = (HttpWebRequest)HttpWebRequest.Create(TB_URL.Text.ToString());
        myWebRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
        myWebRequest.Method = "GET";
        HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
        string source = string.Empty;
        if (myWebResponse.CharacterSet == "windows-1251")
        {
            StreamReader streamReader = new StreamReader(myWebRequest.GetResponse().GetResponseStream(), Encoding.Default);
            String content = streamReader.ReadToEnd();
            source = content;
        }
        else
        {
            StreamReader streamReader = new StreamReader(myWebRequest.GetResponse().GetResponseStream());
            String content = streamReader.ReadToEnd();
            source = content;
        }
        ClassTR oo = new ClassTR();
        TEKST_DOKUMENTU.InnerHtml = oo.ClassTR_(source);        
    }
}