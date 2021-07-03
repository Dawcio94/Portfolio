using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Autokary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvautokary_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = gvautokary.Rows[e.NewEditIndex];
        decimal rowId = decimal.Parse(row.Cells[1].Text);
        Response.Redirect("~/Strony/Autokaryedycja.aspx?id=" + rowId);

    }

    protected void btdodajautokar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Autokaryedycja.aspx");
    }

    protected void gvautokary_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            Int16 index = Convert.ToInt16(e.CommandArgument);
            sdskierowca.SelectCommand = "Select * from Kierowca as k Inner join Kurs as ku on k.Id_kursu=ku.Id_kursu Inner join Autokar as a on ku.Id_kursu=a.Id_kursu where k.Id_kursu='" + decimal.Parse(gvautokary.Rows[index].Cells[1].Text) + "' and a.Id_kursu='"+ decimal.Parse(gvautokary.Rows[index].Cells[1].Text)+"'";
            GridView1.DataSource = sdskierowca;
            GridView1.DataBind();
        }
    }
}
