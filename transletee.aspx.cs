using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class transletee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void IMBT_TRANSLETE_Click(object sender, ImageClickEventArgs e)
    {
        ClassTR oo = new ClassTR();
        TB_TO.Text = oo.ClassTR_(TB_FROM.Text);        
    }
}