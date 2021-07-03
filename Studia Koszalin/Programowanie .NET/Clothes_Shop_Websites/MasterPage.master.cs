using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;
        
        if (user.IsAuthenticated)
        {
            HyperLink5.Visible = true;
            HyperLink6.Visible = true;
        }
        if (user.Name == "Kozak")
        {
            HyperLink5.Visible = true;
            HyperLink6.Visible = true;
            HyperLink7.Visible = true;
        }

    }

}
