using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class name : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void TB_PR_TextChanged(object sender, EventArgs e)
    {        
        ClassTR oo = new ClassTR();
        LB_PR.Text = oo.ClassTR_(TB_PR.Text).ToUpper();
    }

    protected void TB_IM_TextChanged(object sender, EventArgs e)
    {
        ClassTR oo = new ClassTR();
        LB_IM.Text = oo.ClassTR_(TB_IM.Text).ToUpper();
    }

    protected void TB_PB_TextChanged(object sender, EventArgs e)
    {
        ClassTR oo = new ClassTR();
        LB_PB.Text = oo.ClassTR_(TB_PB.Text).ToUpper();
    }   
}