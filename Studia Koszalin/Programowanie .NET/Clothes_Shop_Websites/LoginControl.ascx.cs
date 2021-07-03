using System;
using System.Web.Security;

public partial class LoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btlogin_Click(object sender, EventArgs e)
    {
        if (Membership.ValidateUser(tblogin.Text.ToString(),tbpassword.Text.ToString()))
        {
            FormsAuthentication.RedirectFromLoginPage(tblogin.Text.ToString(), false);
            Response.Redirect("~/Pages/Main_Page.aspx");
        }
        else
        {
            Response.Write("Input correct User Name and Password!");
        }
    }
}
