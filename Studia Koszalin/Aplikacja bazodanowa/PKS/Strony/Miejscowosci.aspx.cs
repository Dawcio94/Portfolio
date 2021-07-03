using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Miejscowosci : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btdodajmiej_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Miejscowosciedycja.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = gvmiej.Rows[e.NewEditIndex];
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        Response.Redirect("~/Strony/Miejscowosciedycja.aspx?id=" + rowId);
    }
}