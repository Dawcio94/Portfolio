using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Przebieg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sdsmiasto.SelectCommand = "Select * From Miejscowości as m Inner Join Przebieg as p on m.Id_miejscowosci=p.Id_miejscowosci Order By p.Id_przebiegu";
        sdstrasa.SelectCommand = "Select * From Trasa as t Inner Join Przebieg as p on t.Id_trasy=p.Id_trasy Order By p.Id_przebiegu";
    }

    protected void btdodajmiej_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Przebiegedycja.aspx");
    }

    protected void gvprzebieg_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = gvprzebieg.Rows[e.NewEditIndex];
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        Response.Redirect("~/Strony/Przebiegedycja.aspx?id=" + rowId);
    }
}