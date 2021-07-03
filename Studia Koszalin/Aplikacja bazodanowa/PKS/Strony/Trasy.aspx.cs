using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Trasy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sdsmiastopocz.SelectCommand = "Select * From Miejscowości as m Inner Join Trasa as t on m.Id_miejscowosci=t.Id_miejscowosci_poczatek";
        sdsmiastokon.SelectCommand = "Select * From Miejscowości as m Inner Join Trasa as t on m.Id_miejscowosci=t.Id_miejscowosci_koniec";
    }

    protected void btdodajprzeb_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Trasyedycja.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.NewEditIndex];
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        Response.Redirect("~/Strony/Trasyedycja.aspx?id=" + rowId);
    }
}