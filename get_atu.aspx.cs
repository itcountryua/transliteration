using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;
using System.Data;


public partial class get_atu : System.Web.UI.Page
{
    string API_KEY = "Wmh1TFhSOE5Ja3ViTVd3eHNLREphaFp4aFNjdklHY1U2dHR0TWs2aXpRRT0=";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {            
            LOAD_ATU();
        }    
    }
    public void LOAD_ATU()
    {
        XmlDocument doc = new XmlDocument();
        string URL = "https://www.drv.gov.ua/apex/RDM$ADR.pgetATO?p_F7571=0&pKey=" + API_KEY;
        doc.Load(URL);        
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            TreeNode item = new TreeNode();
            item.Value = node["F7571"].InnerText;
            item.Text = node["NU101"].InnerText;
            item.PopulateOnDemand = true;
            item.Collapse();
            TreeView1.Nodes.Add(item);
        }
    }
    public void LOAD_ATU(string IDD)
    {
        
    }    
    protected void TreeView1_TreeNodePopulate(object sender, TreeNodeEventArgs e)
    {    
        int IDD = Int32.Parse(e.Node.Value);        
        XmlDocument doc = new XmlDocument();
        //string URL = "https://www.drv.gov.ua/apex/RDM$ADR.pgetATO?p_F7571=" + IDD + "&pKey=" + API_KEY;
        string URL = "https://www.drv.gov.ua/apex/RDM$ADR.pgetATO?p_F7571="+ IDD + "&p_all=T&pKey="+API_KEY+"";
        doc.Load(URL);
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            string LVL = node["LVL"].InnerText;
            if (LVL == "2")
            {
                TreeNode item = new TreeNode();
                item.Value = node["F7571"].InnerText;
                item.Text = node["NU101"].InnerText;
                string CNT_NXT = node["CNT_NXT"].InnerText;
                if (CNT_NXT != "0")
                {
                    item.PopulateOnDemand = true;
                }
                item.Collapse();
                e.Node.ChildNodes.Add(item);
            }
        }        
    }
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        
        //https://www.drv.gov.ua/apex/RDM$ADR.pgetATO?p_F7571=5056&p_all=T&pKey=Wmh1TFhSOE5Ja3ViTVd3eHNLREphaFp4aFNjdklHY1U2dHR0TWs2aXpRRT0=        
        //string IDD = TreeView1.SelectedNode.ChildNodes.ToString();        
        string[] ID_ = TreeView1.SelectedNode.ValuePath.Split('/');
        string ATO = string.Empty;
        foreach (string LA in ID_)
        {
            ATO += GET_GUR_ATO(LA)+" ";
        }
        Label1.Text = ATO;
        ClassTR oo_ = new ClassTR();        
        Label2.Text = oo_.ClassTR_(ATO);

        string IDD = TreeView1.SelectedNode.Value;
        DataTable DT = new DataTable();
        DT.Columns.Add("RAZ", typeof(string));
        DT.Columns.Add("DVA", typeof(string));    
        XmlDocument doc = new XmlDocument();        
        string URL = "https://www.drv.gov.ua/apex/RDM$ADR.pgetGEON?p_F7571="+IDD+"&pKey="+API_KEY+"";
        try
        {
            doc.Load(URL);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string F3302 = node["F3302"].InnerText;
                ClassTR oo = new ClassTR();                
                string op = oo.ClassTR_(F3302);
                DT.Rows.Add(F3302, op);
            }
            GridView1.DataSource = DT;
            GridView1.DataBind();
        }
        catch
        {           
            GridView1.DataSource = null;
            GridView1.DataBind();
        }        
    }   
    public string GET_GUR_ATO(string IDD)
    {
        string ATU_NU101 = string.Empty;
        XmlDocument doc = new XmlDocument();        
        string URL = "https://www.drv.gov.ua/apex/RDM$ADR.p_getCurrATO?p_F7571="+ IDD + "&pKey="+API_KEY+"";
        doc.Load(URL);        
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            ATU_NU101 = node["NU101"].InnerText;            
        }        
        return ATU_NU101;
    }    
}